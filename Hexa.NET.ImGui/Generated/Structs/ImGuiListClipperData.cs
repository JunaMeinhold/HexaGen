// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "ImGuiListClipperData")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ListClipper")]
		[NativeName(NativeNameType.Type, "ImGuiListClipper*")]
		public unsafe ImGuiListClipper* ListClipper;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "LossynessOffset")]
		[NativeName(NativeNameType.Type, "float")]
		public float LossynessOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "StepNo")]
		[NativeName(NativeNameType.Type, "int")]
		public int StepNo;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "ItemsFrozen")]
		[NativeName(NativeNameType.Type, "int")]
		public int ItemsFrozen;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Ranges")]
		[NativeName(NativeNameType.Type, "ImVector_ImGuiListClipperRange")]
		public ImVectorImGuiListClipperRange Ranges;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiListClipperData(ImGuiListClipper* listClipper = default, float lossynessOffset = default, int stepNo = default, int itemsFrozen = default, ImVectorImGuiListClipperRange ranges = default)
		{
			ListClipper = listClipper;
			LossynessOffset = lossynessOffset;
			StepNo = stepNo;
			ItemsFrozen = itemsFrozen;
			Ranges = ranges;
		}


	}

}