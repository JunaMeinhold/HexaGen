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

namespace Hexa.NET.Bgfx
{
	/// <summary>
	/// Renderer backend type enum.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "bgfx_renderer_type")]
	public enum BgfxRendererType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_NOOP")]
		[NativeName(NativeNameType.Value, "0")]
		Noop = unchecked(0),

		/// <summary>
		/// ( 0) No rendering.                  <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_AGC")]
		[NativeName(NativeNameType.Value, "1")]
		Agc = unchecked(1),

		/// <summary>
		/// ( 1) AGC                            <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_DIRECT3D11")]
		[NativeName(NativeNameType.Value, "2")]
		Direct3D11 = unchecked(2),

		/// <summary>
		/// ( 2) Direct3D 11.0                  <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_DIRECT3D12")]
		[NativeName(NativeNameType.Value, "3")]
		Direct3D12 = unchecked(3),

		/// <summary>
		/// ( 3) Direct3D 12.0                  <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_GNM")]
		[NativeName(NativeNameType.Value, "4")]
		Gnm = unchecked(4),

		/// <summary>
		/// ( 4) GNM                            <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_METAL")]
		[NativeName(NativeNameType.Value, "5")]
		Metal = unchecked(5),

		/// <summary>
		/// ( 5) Metal                          <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_NVN")]
		[NativeName(NativeNameType.Value, "6")]
		Nvn = unchecked(6),

		/// <summary>
		/// ( 6) NVN                            <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_OPENGLES")]
		[NativeName(NativeNameType.Value, "7")]
		Opengles = unchecked(7),

		/// <summary>
		/// ( 7) OpenGL ES 2.0+                 <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_OPENGL")]
		[NativeName(NativeNameType.Value, "8")]
		Opengl = unchecked(8),

		/// <summary>
		/// ( 8) OpenGL 2.1+                    <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_VULKAN")]
		[NativeName(NativeNameType.Value, "9")]
		Vulkan = unchecked(9),

		/// <summary>
		/// ( 9) Vulkan                         <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_RENDERER_TYPE_COUNT")]
		[NativeName(NativeNameType.Value, "10")]
		Count = unchecked(10),
	}
}
