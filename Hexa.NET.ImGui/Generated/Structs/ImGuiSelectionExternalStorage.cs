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
	/// Optional helper to apply multi-selection requests to existing randomly accessible storage.<br/>
	/// Convenient if you want to quickly wire multi-select API on e.g. an array of bool or items storing their own selection state.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "ImGuiSelectionExternalStorage")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionExternalStorage
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "UserData")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* UserData;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AdapterSetItemSelected")]
		[NativeName(NativeNameType.Type, "void (*)(ImGuiSelectionExternalStorage* self, int idx, bool selected)*")]
		public unsafe void* AdapterSetItemSelected;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiSelectionExternalStorage(void* userData = default, delegate*<ImGuiSelectionExternalStorage*, int, byte, void> adapterSetItemSelected = default)
		{
			UserData = userData;
			AdapterSetItemSelected = (void*)adapterSetItemSelected;
		}


		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImGuiSelectionExternalStorage_ApplyRequests")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void ApplyRequests([NativeName(NativeNameType.Param, "ms_io")] [NativeName(NativeNameType.Type, "ImGuiMultiSelectIO*")] ImGuiMultiSelectIO* msIo)
		{
			fixed (ImGuiSelectionExternalStorage* @this = &this)
			{
				ImGui.ApplyRequestsNative(@this, msIo);
			}
		}

		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImGuiSelectionExternalStorage_ApplyRequests")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void ApplyRequests([NativeName(NativeNameType.Param, "ms_io")] [NativeName(NativeNameType.Type, "ImGuiMultiSelectIO*")] ref ImGuiMultiSelectIO msIo)
		{
			fixed (ImGuiSelectionExternalStorage* @this = &this)
			{
				fixed (ImGuiMultiSelectIO* pmsIo = &msIo)
				{
					ImGui.ApplyRequestsNative(@this, (ImGuiMultiSelectIO*)pmsIo);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ImGuiSelectionExternalStorage_destroy")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void Destroy()
		{
			fixed (ImGuiSelectionExternalStorage* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

	}

}