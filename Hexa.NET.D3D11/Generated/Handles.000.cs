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
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D11
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11SHADERREFLECTIONTYPE")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Shaderreflectiontype : IEquatable<LpD3D11Shaderreflectiontype>
	{
		public LpD3D11Shaderreflectiontype(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Shaderreflectiontype Null => new LpD3D11Shaderreflectiontype(0);
		public static implicit operator LpD3D11Shaderreflectiontype(nint handle) => new LpD3D11Shaderreflectiontype(handle);
		public static bool operator ==(LpD3D11Shaderreflectiontype left, LpD3D11Shaderreflectiontype right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Shaderreflectiontype left, LpD3D11Shaderreflectiontype right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Shaderreflectiontype left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Shaderreflectiontype left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Shaderreflectiontype other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Shaderreflectiontype handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Shaderreflectiontype [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11SHADERREFLECTIONVARIABLE")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Shaderreflectionvariable : IEquatable<LpD3D11Shaderreflectionvariable>
	{
		public LpD3D11Shaderreflectionvariable(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Shaderreflectionvariable Null => new LpD3D11Shaderreflectionvariable(0);
		public static implicit operator LpD3D11Shaderreflectionvariable(nint handle) => new LpD3D11Shaderreflectionvariable(handle);
		public static bool operator ==(LpD3D11Shaderreflectionvariable left, LpD3D11Shaderreflectionvariable right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Shaderreflectionvariable left, LpD3D11Shaderreflectionvariable right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Shaderreflectionvariable left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Shaderreflectionvariable left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Shaderreflectionvariable other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Shaderreflectionvariable handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Shaderreflectionvariable [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11SHADERREFLECTIONCONSTANTBUFFER")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Shaderreflectionconstantbuffer : IEquatable<LpD3D11Shaderreflectionconstantbuffer>
	{
		public LpD3D11Shaderreflectionconstantbuffer(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Shaderreflectionconstantbuffer Null => new LpD3D11Shaderreflectionconstantbuffer(0);
		public static implicit operator LpD3D11Shaderreflectionconstantbuffer(nint handle) => new LpD3D11Shaderreflectionconstantbuffer(handle);
		public static bool operator ==(LpD3D11Shaderreflectionconstantbuffer left, LpD3D11Shaderreflectionconstantbuffer right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Shaderreflectionconstantbuffer left, LpD3D11Shaderreflectionconstantbuffer right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Shaderreflectionconstantbuffer left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Shaderreflectionconstantbuffer left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Shaderreflectionconstantbuffer other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Shaderreflectionconstantbuffer handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Shaderreflectionconstantbuffer [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11SHADERREFLECTION")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Shaderreflection : IEquatable<LpD3D11Shaderreflection>
	{
		public LpD3D11Shaderreflection(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Shaderreflection Null => new LpD3D11Shaderreflection(0);
		public static implicit operator LpD3D11Shaderreflection(nint handle) => new LpD3D11Shaderreflection(handle);
		public static bool operator ==(LpD3D11Shaderreflection left, LpD3D11Shaderreflection right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Shaderreflection left, LpD3D11Shaderreflection right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Shaderreflection left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Shaderreflection left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Shaderreflection other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Shaderreflection handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Shaderreflection [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11LIBRARYREFLECTION")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Libraryreflection : IEquatable<LpD3D11Libraryreflection>
	{
		public LpD3D11Libraryreflection(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Libraryreflection Null => new LpD3D11Libraryreflection(0);
		public static implicit operator LpD3D11Libraryreflection(nint handle) => new LpD3D11Libraryreflection(handle);
		public static bool operator ==(LpD3D11Libraryreflection left, LpD3D11Libraryreflection right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Libraryreflection left, LpD3D11Libraryreflection right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Libraryreflection left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Libraryreflection left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Libraryreflection other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Libraryreflection handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Libraryreflection [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11FUNCTIONREFLECTION")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Functionreflection : IEquatable<LpD3D11Functionreflection>
	{
		public LpD3D11Functionreflection(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Functionreflection Null => new LpD3D11Functionreflection(0);
		public static implicit operator LpD3D11Functionreflection(nint handle) => new LpD3D11Functionreflection(handle);
		public static bool operator ==(LpD3D11Functionreflection left, LpD3D11Functionreflection right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Functionreflection left, LpD3D11Functionreflection right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Functionreflection left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Functionreflection left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Functionreflection other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Functionreflection handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Functionreflection [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Typedef, "LPD3D11FUNCTIONPARAMETERREFLECTION")]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct LpD3D11Functionparameterreflection : IEquatable<LpD3D11Functionparameterreflection>
	{
		public LpD3D11Functionparameterreflection(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static LpD3D11Functionparameterreflection Null => new LpD3D11Functionparameterreflection(0);
		public static implicit operator LpD3D11Functionparameterreflection(nint handle) => new LpD3D11Functionparameterreflection(handle);
		public static bool operator ==(LpD3D11Functionparameterreflection left, LpD3D11Functionparameterreflection right) => left.Handle == right.Handle;
		public static bool operator !=(LpD3D11Functionparameterreflection left, LpD3D11Functionparameterreflection right) => left.Handle != right.Handle;
		public static bool operator ==(LpD3D11Functionparameterreflection left, nint right) => left.Handle == right;
		public static bool operator !=(LpD3D11Functionparameterreflection left, nint right) => left.Handle != right;
		public bool Equals(LpD3D11Functionparameterreflection other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is LpD3D11Functionparameterreflection handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("LpD3D11Functionparameterreflection [0x{0}]", Handle.ToString("X"));
	}

}