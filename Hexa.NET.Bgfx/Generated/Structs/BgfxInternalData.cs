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

namespace Hexa.NET.Bgfx
{
	/// <summary>
	/// Internal data.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "bgfx_internal_data_s")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct BgfxInternalData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "caps")]
		[NativeName(NativeNameType.Type, "const bgfx_caps_t*")]
		public unsafe BgfxCaps* Caps;

		/// <summary>
		/// Renderer capabilities.                   <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "context")]
		[NativeName(NativeNameType.Type, "void*")]
		public unsafe void* Context;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BgfxInternalData(BgfxCaps* caps = default, void* context = default)
		{
			Caps = caps;
			Context = context;
		}


	}

}