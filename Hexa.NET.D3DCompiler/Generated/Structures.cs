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
using HexaEngine.D3DCommon;
using HexaEngine.D3D11;
using HexaGen.Runtime.COM;

namespace HexaEngine.D3DCompiler
{
	/// <summary>
	/// ----------------------------------------------------------------------------<br/>
	/// D3DCompressShaders:<br/>
	/// -----------------------<br/>
	/// Compresses a set of shaders into a more compact form.<br/>
	/// ----------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "_D3D_SHADER_DATA")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct _D3D_SHADER_DATA
	{
		[NativeName(NativeNameType.Field, "pBytecode")]
		[NativeName(NativeNameType.Type, "LPCVOID")]
		public unsafe void* PBytecode;
		[NativeName(NativeNameType.Field, "BytecodeLength")]
		[NativeName(NativeNameType.Type, "SIZE_T")]
		public nuint BytecodeLength;


	}

	[NativeName(NativeNameType.StructOrClass, "ID3D10Effect")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ID3D10Effect
	{


	}

}