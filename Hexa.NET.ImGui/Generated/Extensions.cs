// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace HexaEngine.ImGuiNET
{
	public static unsafe class Extensions
	{
		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "uv0")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV0, [NativeName(NativeNameType.Param, "uv1")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV1, [NativeName(NativeNameType.Param, "tint_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 tintCol, [NativeName(NativeNameType.Param, "border_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 borderCol)
		{
			ImGui.ImageNative(userTextureId, sIZE, uV0, uV1, tintCol, borderCol);
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "uv0")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV0, [NativeName(NativeNameType.Param, "uv1")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV1, [NativeName(NativeNameType.Param, "tint_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 tintCol)
		{
			ImGui.ImageNative(userTextureId, sIZE, uV0, uV1, tintCol, (Vector4)(new Vector4(0,0,0,0)));
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "uv0")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV0, [NativeName(NativeNameType.Param, "uv1")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV1)
		{
			ImGui.ImageNative(userTextureId, sIZE, uV0, uV1, (Vector4)(new Vector4(1,1,1,1)), (Vector4)(new Vector4(0,0,0,0)));
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "uv0")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV0)
		{
			ImGui.ImageNative(userTextureId, sIZE, uV0, (Vector2)(new Vector2(1,1)), (Vector4)(new Vector4(1,1,1,1)), (Vector4)(new Vector4(0,0,0,0)));
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE)
		{
			ImGui.ImageNative(userTextureId, sIZE, (Vector2)(new Vector2(0,0)), (Vector2)(new Vector2(1,1)), (Vector4)(new Vector4(1,1,1,1)), (Vector4)(new Vector4(0,0,0,0)));
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "uv0")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV0, [NativeName(NativeNameType.Param, "tint_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 tintCol)
		{
			ImGui.ImageNative(userTextureId, sIZE, uV0, (Vector2)(new Vector2(1,1)), tintCol, (Vector4)(new Vector4(0,0,0,0)));
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "tint_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 tintCol)
		{
			ImGui.ImageNative(userTextureId, sIZE, (Vector2)(new Vector2(0,0)), (Vector2)(new Vector2(1,1)), tintCol, (Vector4)(new Vector4(0,0,0,0)));
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "uv0")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 uV0, [NativeName(NativeNameType.Param, "tint_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 tintCol, [NativeName(NativeNameType.Param, "border_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 borderCol)
		{
			ImGui.ImageNative(userTextureId, sIZE, uV0, (Vector2)(new Vector2(1,1)), tintCol, borderCol);
		}

		[NativeName(NativeNameType.Func, "igImage")]
		[return: NativeName(NativeNameType.Type, "void")]
		public static void Image(this ImTextureID userTextureId, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "const ImVec2")] Vector2 sIZE, [NativeName(NativeNameType.Param, "tint_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 tintCol, [NativeName(NativeNameType.Param, "border_col")] [NativeName(NativeNameType.Type, "const ImVec4")] Vector4 borderCol)
		{
			ImGui.ImageNative(userTextureId, sIZE, (Vector2)(new Vector2(0,0)), (Vector2)(new Vector2(1,1)), tintCol, borderCol);
		}

		[NativeName(NativeNameType.Func, "igImFileClose")]
		[return: NativeName(NativeNameType.Type, "bool")]
		public static bool Close(this ImFileHandle fILE)
		{
			byte ret = ImGui.ImFileCloseNative(fILE);
			return ret != 0;
		}

		[NativeName(NativeNameType.Func, "igImFileGetSize")]
		[return: NativeName(NativeNameType.Type, "ImU64")]
		public static ulong GetSize(this ImFileHandle fILE)
		{
			ulong ret = ImGui.ImFileGetSizeNative(fILE);
			return ret;
		}

	}
}