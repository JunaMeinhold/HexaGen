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
	/// Backbuffer resolution and reset parameters.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "bgfx_resolution_s")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct BgfxResolution
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "format")]
		[NativeName(NativeNameType.Type, "bgfx_texture_format_t")]
		public BgfxTextureFormat Format;

		/// <summary>
		/// Backbuffer format.                       <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "width")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Width;

		/// <summary>
		/// Backbuffer width.                        <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "height")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Height;

		/// <summary>
		/// Backbuffer height.                       <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "reset")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Reset;

		/// <summary>
		/// Reset parameters.                        <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "numBackBuffers")]
		[NativeName(NativeNameType.Type, "uint8_t")]
		public byte NumBackBuffers;

		/// <summary>
		/// Number of back buffers.                  <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "maxFrameLatency")]
		[NativeName(NativeNameType.Type, "uint8_t")]
		public byte MaxFrameLatency;

		/// <summary>
		/// Maximum frame latency.                   <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "debugTextScale")]
		[NativeName(NativeNameType.Type, "uint8_t")]
		public byte DebugTextScale;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BgfxResolution(BgfxTextureFormat format = default, uint width = default, uint height = default, uint reset = default, byte numBackBuffers = default, byte maxFrameLatency = default, byte debugTextScale = default)
		{
			Format = format;
			Width = width;
			Height = height;
			Reset = reset;
			NumBackBuffers = numBackBuffers;
			MaxFrameLatency = maxFrameLatency;
			DebugTextScale = debugTextScale;
		}


	}

}