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
	/// Occlusion query result.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "bgfx_occlusion_query_result")]
	public enum BgfxOcclusionQueryResult : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_OCCLUSION_QUERY_RESULT_INVISIBLE")]
		[NativeName(NativeNameType.Value, "0")]
		Invisible = unchecked(0),

		/// <summary>
		/// ( 0) Query failed test.             <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_OCCLUSION_QUERY_RESULT_VISIBLE")]
		[NativeName(NativeNameType.Value, "1")]
		Visible = unchecked(1),

		/// <summary>
		/// ( 1) Query passed test.             <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_OCCLUSION_QUERY_RESULT_NORESULT")]
		[NativeName(NativeNameType.Value, "2")]
		Noresult = unchecked(2),

		/// <summary>
		/// ( 2) Query result is not available yet. <br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "BGFX_OCCLUSION_QUERY_RESULT_COUNT")]
		[NativeName(NativeNameType.Value, "3")]
		Count = unchecked(3),
	}
}
