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
	/// Uniform type enum.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "bgfx_uniform_type")]
	public enum BgfxUniformType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_UNIFORM_TYPE_SAMPLER")]
		[NativeName(NativeNameType.Value, "0")]
		Sampler = unchecked(0),

		/// <summary>
		/// ( 0) Sampler.                       <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_UNIFORM_TYPE_END")]
		[NativeName(NativeNameType.Value, "1")]
		End = unchecked(1),

		/// <summary>
		/// ( 1) Reserved, do not use.          <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_UNIFORM_TYPE_VEC4")]
		[NativeName(NativeNameType.Value, "2")]
		Vec4 = unchecked(2),

		/// <summary>
		/// ( 2) 4 floats vector.               <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_UNIFORM_TYPE_MAT3")]
		[NativeName(NativeNameType.Value, "3")]
		Mat3 = unchecked(3),

		/// <summary>
		/// ( 3) 3x3 matrix.                    <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_UNIFORM_TYPE_MAT4")]
		[NativeName(NativeNameType.Value, "4")]
		Mat4 = unchecked(4),

		/// <summary>
		/// ( 4) 4x4 matrix.                    <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_UNIFORM_TYPE_COUNT")]
		[NativeName(NativeNameType.Value, "5")]
		Count = unchecked(5),
	}
}