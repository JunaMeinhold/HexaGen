// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "ImGuiComboFlags_")]
	public enum ImGuiComboFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_None")]
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		/// Align the popup toward the left by default<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_PopupAlignLeft")]
		[NativeName(NativeNameType.Value, "1")]
		PopupAlignLeft = unchecked(1),

		/// <summary>
		/// Max ~4 items visible. Tip: If you want your combo popup to be a specific size you can use SetNextWindowSizeConstraints() prior to calling BeginCombo()<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_HeightSmall")]
		[NativeName(NativeNameType.Value, "2")]
		HeightSmall = unchecked(2),

		/// <summary>
		/// Max ~8 items visible (default)<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_HeightRegular")]
		[NativeName(NativeNameType.Value, "4")]
		HeightRegular = unchecked(4),

		/// <summary>
		/// Max ~20 items visible<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_HeightLarge")]
		[NativeName(NativeNameType.Value, "8")]
		HeightLarge = unchecked(8),

		/// <summary>
		/// As many fitting items as possible<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_HeightLargest")]
		[NativeName(NativeNameType.Value, "16")]
		HeightLargest = unchecked(16),

		/// <summary>
		/// Display on the preview box without the square arrow button<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_NoArrowButton")]
		[NativeName(NativeNameType.Value, "32")]
		NoArrowButton = unchecked(32),

		/// <summary>
		/// Display only a square arrow button<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_NoPreview")]
		[NativeName(NativeNameType.Value, "64")]
		NoPreview = unchecked(64),

		/// <summary>
		/// Width dynamically calculated from preview contents<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_WidthFitPreview")]
		[NativeName(NativeNameType.Value, "128")]
		WidthFitPreview = unchecked(128),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "ImGuiComboFlags_HeightMask_")]
		[NativeName(NativeNameType.Value, "30")]
		HeightMask = unchecked(30),
	}
}