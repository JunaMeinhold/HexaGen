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
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "ImPool_ImGuiTabBar")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPoolImGuiTabBar
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Buf")]
		[NativeName(NativeNameType.Type, "ImVector_ImGuiTabBar")]
		public ImVectorImGuiTabBar Buf;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Map")]
		[NativeName(NativeNameType.Type, "ImGuiStorage")]
		public ImGuiStorage Map;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "FreeIdx")]
		[NativeName(NativeNameType.Type, "ImPoolIdx")]
		public int FreeIdx;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "AliveCount")]
		[NativeName(NativeNameType.Type, "ImPoolIdx")]
		public int AliveCount;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPoolImGuiTabBar(ImVectorImGuiTabBar buf = default, ImGuiStorage map = default, int freeIdx = default, int aliveCount = default)
		{
			Buf = buf;
			Map = map;
			FreeIdx = freeIdx;
			AliveCount = aliveCount;
		}


	}

}