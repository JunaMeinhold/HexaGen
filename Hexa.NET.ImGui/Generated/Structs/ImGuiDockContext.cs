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
	[NativeName(NativeNameType.StructOrClass, "ImGuiDockContext")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockContext
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Nodes")]
		[NativeName(NativeNameType.Type, "ImGuiStorage")]
		public ImGuiStorage Nodes;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "Requests")]
		[NativeName(NativeNameType.Type, "ImVector_ImGuiDockRequest")]
		public ImVectorImGuiDockRequest Requests;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "NodesSettings")]
		[NativeName(NativeNameType.Type, "ImVector_ImGuiDockNodeSettings")]
		public ImVectorImGuiDockNodeSettings NodesSettings;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "WantFullRebuild")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte WantFullRebuild;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiDockContext(ImGuiStorage nodes = default, ImVectorImGuiDockRequest requests = default, ImVectorImGuiDockNodeSettings nodesSettings = default, bool wantFullRebuild = default)
		{
			Nodes = nodes;
			Requests = requests;
			NodesSettings = nodesSettings;
			WantFullRebuild = wantFullRebuild ? (byte)1 : (byte)0;
		}


	}

}