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
	/// Helper: Execute a block of code at maximum once a frame. Convenient if you want to quickly create a UI within deep-nested code that runs multiple times every frame.<br/>
	/// Usage: static ImGuiOnceUponAFrame oaf; if (oaf) ImGui::Text("This will be called only once per frame");<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "ImGuiOnceUponAFrame")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOnceUponAFrame
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "RefFrame")]
		[NativeName(NativeNameType.Type, "int")]
		public int RefFrame;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiOnceUponAFrame(int refFrame = default)
		{
			RefFrame = refFrame;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ImGuiOnceUponAFrame_destroy")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void Destroy()
		{
			fixed (ImGuiOnceUponAFrame* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

	}

}