﻿namespace HexaGen.FunctionGeneration
{
    using CppAst;
    using HexaGen;
    using HexaGen.Core.CSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FunctionGenerator
    {
        private readonly CsCodeGeneratorConfig settings;
        private readonly List<FunctionGenRule> rules = new();
        private readonly List<FunctionGenStep> steps = new();

        public FunctionGenerator(CsCodeGeneratorConfig settings)
        {
            this.settings = settings;
            rules.Add(new FunctionGenRuleRef());
            rules.Add(new FunctionGenRuleSpan());
            rules.Add(new FunctionGenRuleString());
            steps.Add(new DefaultValueGenStep());
            steps.Add(new ReturnVariationGenStep());
            steps.Add(new StringReturnGenStep());
        }

        public static FunctionGenerator CreateDefault(CsCodeGeneratorConfig config)
        {
            FunctionGenerator generator = new(config);
            generator.rules.Add(new FunctionGenRuleRef());
            generator.rules.Add(new FunctionGenRuleSpan());
            generator.rules.Add(new FunctionGenRuleString());
            generator.steps.Add(new DefaultValueGenStep());
            generator.steps.Add(new ReturnVariationGenStep());
            generator.steps.Add(new StringReturnGenStep());
            return generator;
        }

        public static FunctionGenerator CreateForCOM(CsCodeGeneratorConfig config)
        {
            FunctionGenerator generator = new(config);
            generator.rules.Add(new FunctionGenRuleRef());
            generator.rules.Add(new FunctionGenRuleSpan());
            generator.rules.Add(new FunctionGenRuleString());
            generator.rules.Add(new FunctionGenRuleCOM());
            generator.steps.Add(new DefaultValueGenStep());
            generator.steps.Add(new ReturnVariationGenStep());
            generator.steps.Add(new StringReturnGenStep());
            return generator;
        }

        public IReadOnlyList<FunctionGenRule> Rules => rules;

        public IReadOnlyList<FunctionGenStep> Steps => steps;

        public void OverwriteStep<T>(FunctionGenStep step) where T : FunctionGenStep
        {
            for (int i = 0; i < steps.Count; i++)
            {
                if (steps[i] is T)
                {
                    steps[i] = step;
                    return;
                }
            }
        }

        public void OverwriteRule<T>(FunctionGenRule rule) where T : FunctionGenRule
        {
            for (int i = 0; i < rules.Count; i++)
            {
                if (rules[i] is T)
                {
                    rules[i] = rule;
                    return;
                }
            }
        }

        public void AddRule(FunctionGenRule rule)
        {
            rules.Add(rule);
        }

        public void RemoveRule(FunctionGenRule rule)
        {
            rules.Remove(rule);
        }

        public void AddStep(FunctionGenStep step)
        {
            steps.Add(step);
        }

        public void RemoveStep(FunctionGenStep step)
        {
            steps.Remove(step);
        }

        public virtual void GenerateConstructorVariations(CppClass cppClass, List<CsSubClass> subClasses, string csName, CsFunctionOverload function)
        {
            settings.TryGetFunctionMapping(function.ExportedName, out var mapping);

            if (mapping != null)
            {
                function.Comment = mapping.Comment;
            }

            var fields = cppClass.Fields;

            CsParameterInfo[] parameterList = new CsParameterInfo[fields.Count];
            CsParameterInfo[] spanParameterList = new CsParameterInfo[fields.Count];
            for (int i = 0; i < fields.Count; i++)
            {
                CppField cppField = fields[i];
                CppPrimitiveKind kind = cppField.Type.GetPrimitiveKind();

                var fieldCsName = settings.GetFieldName(cppField.Name);
                var paramCsTypeName = settings.GetCsTypeName(cppField.Type, false);
                var paramCsName = settings.GetParameterName(i, cppField.Name);
                var direction = cppField.Type.GetDirection();

                {
                    if (cppField.Type is CppArrayType arrayType && arrayType.ElementType is CppPointerType pointerType && pointerType.ElementType is CppFunctionType && settings.DelegatesAsVoidPointer)
                    {
                        paramCsTypeName = "nint*";
                    }
                }

                var subClass = subClasses.Find(x => x.CppType == cppField.Type);
                if (subClass != null && cppField.Type is CppClass cppClass1 && cppClass1.ClassKind == CppClassKind.Union)
                {
                    subClass = subClasses.First(x => x.CppType == cppClass1);
                    paramCsTypeName = subClass.Name;
                    paramCsName = subClass.FieldName.ToLower();
                    fieldCsName = subClass.FieldName;
                }

                if (subClass != null)
                {
                    paramCsTypeName = subClass.Name;
                }

                int depth = 0;
                var subClass1 = subClasses.FirstOrDefault(x => x.CppType.IsPointerOf(cppField.Type, ref depth));
                if (subClass1 != null)
                {
                    paramCsTypeName = subClass1.Name + new string('*', depth);
                }

                parameterList[i] = new(paramCsName, cppField.Type, new(paramCsTypeName, kind), direction, "default", fieldCsName);

                {
                    if (cppField.Type is CppArrayType arrayType)
                    {
                        var arrayElementTypeName = settings.GetCsWrappedPointerTypeName(arrayType.ElementType, false);
                        spanParameterList[i] = new(paramCsName, cppField.Type, new($"Span<{arrayElementTypeName}>", kind), direction, "default", fieldCsName);
                    }
                    else
                    {
                        spanParameterList[i] = new(paramCsName, cppField.Type, new(paramCsTypeName, kind), direction, "default", fieldCsName);
                    }
                }
            }

            CsFunctionVariation variation = function.CreateVariationWith();
            variation.Parameters.AddRange(parameterList);

            CsFunctionVariation spanVariation = function.CreateVariationWith();
            spanVariation.Parameters.AddRange(spanParameterList);

            function.TryAddVariation(variation);

            function.TryAddVariation(spanVariation);
        }

        public virtual void GenerateVariations(IList<CppParameter> parameters, CsFunctionOverload function)
        {
            settings.TryGetFunctionMapping(function.ExportedName, out var mapping);

            if (mapping != null && mapping.Comment != null)
            {
                function.Comment = settings.WriteCsSummary(mapping.Comment);
            }

            long maxVariations = (long)Math.Pow(2L, parameters.Count);
            for (long ix = 0; ix < maxVariations; ix++)
            {
                CsFunctionVariation[] variations = new CsFunctionVariation[rules.Count];
                CsParameterInfo[][] parameterLists = new CsParameterInfo[rules.Count][];
                for (int i = 0; i < rules.Count; i++)
                {
                    variations[i] = function.CreateVariationWith();
                    parameterLists[i] = new CsParameterInfo[parameters.Count];
                }

                CsParameterInfo[][]? customParameterList = mapping != null ? new CsParameterInfo[mapping.CustomVariations.Count][] : null;

                if (customParameterList != null)
                {
                    for (int i = 0; i < customParameterList.Length; i++)
                    {
                        customParameterList[i] = new CsParameterInfo[parameters.Count];
                    }
                }

                for (int j = 0; j < parameters.Count; j++)
                {
                    var bit = (ix & 1 << j - 64) != 0;
                    CppParameter cppParameter = parameters[j];
                    CppPrimitiveKind kind = cppParameter.Type.GetPrimitiveKind();

                    var paramCsName = settings.GetParameterName(j, cppParameter.Name);
                    var direction = cppParameter.Type.GetDirection();

                    for (int i = 0; i < rules.Count; i++)
                    {
                        var rule = rules[i];
                        parameterLists[i][j] = bit
                            ? rule.CreateParameter(cppParameter, paramCsName, kind, direction, settings, parameters, parameterLists[i], j, variations[i])
                            : rule.CreateDefaultParameter(cppParameter, paramCsName, kind, direction, settings);
                    }

                    if (customParameterList != null)
                    {
                        for (int i = 0; i < customParameterList.Length; i++)
                        {
                            // mapping cant be null here, because customParameterList is only created if mapping is not null
                            customParameterList[i][j] = mapping!.CustomVariations[i].TryGetValue(paramCsName, out var paramType)
                                ? new CsParameterInfo(paramCsName, cppParameter.Type, new CsType(paramType, kind), direction)
                                : new CsParameterInfo(paramCsName, cppParameter.Type, new CsType(settings.GetCsWrapperTypeName(cppParameter.Type, false), kind), direction);
                        }
                    }

                    for (int i = 0; i < rules.Count; i++)
                    {
                        var parameter = parameterLists[i][j];
                        GenerateAttributes(cppParameter, direction, parameter, parameter.Attributes);
                    }

                    if (customParameterList != null)
                    {
                        for (int i = 0; i < customParameterList.Length; i++)
                        {
                            var parameter = customParameterList[i][j];
                            GenerateAttributes(cppParameter, direction, parameter, parameter.Attributes);
                        }
                    }
                }

                for (int i = 0; i < rules.Count; i++)
                {
                    CsFunctionVariation ruleVariation = variations[i];
                    ruleVariation.Parameters.AddRange(parameterLists[i]);
                    if (function.TryAddVariation(ruleVariation))
                    {
                        ApplySteps(function, ruleVariation);
                    }
                }

                if (customParameterList != null)
                {
                    for (int i = 0; i < customParameterList.Length; i++)
                    {
                        CsFunctionVariation customVariation = function.CreateVariationWith();
                        customVariation.Parameters.AddRange(customParameterList[i]);
                        if (function.TryAddVariation(customVariation))
                        {
                            ApplySteps(function, customVariation);
                        }
                    }
                }
            }
        }

        public virtual void GenerateAttributes(CppParameter cppParameter, Direction direction, CsParameterInfo parameter, List<string> attributes)
        {
            string paramAttr = $"[NativeName(NativeNameType.Param, \"{cppParameter.Name}\")]";
            string typeAttr = $"[NativeName(NativeNameType.Type, \"{cppParameter.Type.GetDisplayName()}\")]";
            attributes.Add(paramAttr);
            attributes.Add(typeAttr);
        }

        public virtual void ApplySteps(CsFunctionOverload function, CsFunctionVariation variation)
        {
            foreach (var step in steps)
            {
                if (step.ShouldSkip(function, variation)) continue;
                step.GenSteps = steps;
                step.GenerateVariations(function, variation);
            }
        }

        public virtual void ApplyStep<T>(CsFunctionOverload function, CsFunctionVariation variation) where T : FunctionGenStep
        {
            foreach (var step in steps)
            {
                if (step.ShouldSkip(function, variation)) continue;
                if (step is T t)
                {
                    t.GenSteps = steps;
                    t.GenerateVariations(function, variation);
                }
            }
        }
    }
}