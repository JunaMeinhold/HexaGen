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
	/// Helper to build glyph ranges from textstring data. Feed your application stringscharacters to it then call BuildRanges().<br/>
	/// This is essentially a tightly packed of vector of 64k booleans = 8KB storage.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "ImFontGlyphRangesBuilder")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyphRangesBuilder
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "UsedChars")]
		[NativeName(NativeNameType.Type, "ImVector_ImU32")]
		public ImVectorImU32 UsedChars;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImFontGlyphRangesBuilder(ImVectorImU32 usedChars = default)
		{
			UsedChars = usedChars;
		}


		/// <summary>
		/// Add character<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddChar")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddChar([NativeName(NativeNameType.Param, "c")] [NativeName(NativeNameType.Type, "ImWchar")] char c)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.AddCharNative(@this, c);
			}
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCIILatin+Ext<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddRanges")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddRanges([NativeName(NativeNameType.Param, "ranges")] [NativeName(NativeNameType.Type, "const ImWchar*")] char* ranges)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.AddRangesNative(@this, ranges);
			}
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCIILatin+Ext<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddRanges")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddRanges([NativeName(NativeNameType.Param, "ranges")] [NativeName(NativeNameType.Type, "const ImWchar*")] ref char ranges)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (char* pranges = &ranges)
				{
					ImGui.AddRangesNative(@this, (char*)pranges);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] byte* textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.AddTextNative(@this, text, textEnd);
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.AddTextNative(@this, text, (byte*)(default));
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] ref byte text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] byte* textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptext = &text)
				{
					ImGui.AddTextNative(@this, (byte*)ptext, textEnd);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] ref byte text)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptext = &text)
				{
					ImGui.AddTextNative(@this, (byte*)ptext, (byte*)(default));
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] ReadOnlySpan<byte> text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] byte* textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptext = text)
				{
					ImGui.AddTextNative(@this, (byte*)ptext, textEnd);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] ReadOnlySpan<byte> text)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptext = text)
				{
					ImGui.AddTextNative(@this, (byte*)ptext, (byte*)(default));
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] string text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] byte* textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (text != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(text);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(text, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.AddTextNative(@this, pStr0, textEnd);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] string text)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (text != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(text);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(text, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.AddTextNative(@this, pStr0, (byte*)(default));
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] ref byte textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptextEnd = &textEnd)
				{
					ImGui.AddTextNative(@this, text, (byte*)ptextEnd);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] ReadOnlySpan<byte> textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptextEnd = textEnd)
				{
					ImGui.AddTextNative(@this, text, (byte*)ptextEnd);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] string textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (textEnd != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(textEnd);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(textEnd, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				ImGui.AddTextNative(@this, text, pStr0);
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] ref byte text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] ref byte textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptext = &text)
				{
					fixed (byte* ptextEnd = &textEnd)
					{
						ImGui.AddTextNative(@this, (byte*)ptext, (byte*)ptextEnd);
					}
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] ReadOnlySpan<byte> text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] ReadOnlySpan<byte> textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (byte* ptext = text)
				{
					fixed (byte* ptextEnd = textEnd)
					{
						ImGui.AddTextNative(@this, (byte*)ptext, (byte*)ptextEnd);
					}
				}
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_AddText")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void AddText([NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] string text, [NativeName(NativeNameType.Param, "text_end")] [NativeName(NativeNameType.Type, "const char*")] string textEnd)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				byte* pStr0 = null;
				int pStrSize0 = 0;
				if (text != null)
				{
					pStrSize0 = Utils.GetByteCountUTF8(text);
					if (pStrSize0 >= Utils.MaxStackallocSize)
					{
						pStr0 = Utils.Alloc<byte>(pStrSize0 + 1);
					}
					else
					{
						byte* pStrStack0 = stackalloc byte[pStrSize0 + 1];
						pStr0 = pStrStack0;
					}
					int pStrOffset0 = Utils.EncodeStringUTF8(text, pStr0, pStrSize0);
					pStr0[pStrOffset0] = 0;
				}
				byte* pStr1 = null;
				int pStrSize1 = 0;
				if (textEnd != null)
				{
					pStrSize1 = Utils.GetByteCountUTF8(textEnd);
					if (pStrSize1 >= Utils.MaxStackallocSize)
					{
						pStr1 = Utils.Alloc<byte>(pStrSize1 + 1);
					}
					else
					{
						byte* pStrStack1 = stackalloc byte[pStrSize1 + 1];
						pStr1 = pStrStack1;
					}
					int pStrOffset1 = Utils.EncodeStringUTF8(textEnd, pStr1, pStrSize1);
					pStr1[pStrOffset1] = 0;
				}
				ImGui.AddTextNative(@this, pStr0, pStr1);
				if (pStrSize1 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr1);
				}
				if (pStrSize0 >= Utils.MaxStackallocSize)
				{
					Utils.Free(pStr0);
				}
			}
		}

		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_BuildRanges")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void BuildRanges([NativeName(NativeNameType.Param, "out_ranges")] [NativeName(NativeNameType.Type, "ImVector_ImWchar*")] ImVectorImWchar* outRanges)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.BuildRangesNative(@this, outRanges);
			}
		}

		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_BuildRanges")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void BuildRanges([NativeName(NativeNameType.Param, "out_ranges")] [NativeName(NativeNameType.Type, "ImVector_ImWchar*")] ref ImVectorImWchar outRanges)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				fixed (ImVectorImWchar* poutRanges = &outRanges)
				{
					ImGui.BuildRangesNative(@this, (ImVectorImWchar*)poutRanges);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_Clear")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void Clear()
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.ClearNative(@this);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_destroy")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void Destroy()
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_GetBit")]
		[return: NativeName(NativeNameType.Type, "bool")]
		public unsafe bool GetBit([NativeName(NativeNameType.Param, "n")] [NativeName(NativeNameType.Type, "size_t")] ulong n)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				byte ret = ImGui.GetBitNative(@this, n);
				return ret != 0;
			}
		}

		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_GetBit")]
		[return: NativeName(NativeNameType.Type, "bool")]
		public unsafe bool GetBit([NativeName(NativeNameType.Param, "n")] [NativeName(NativeNameType.Type, "size_t")] nuint n)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				byte ret = ImGui.GetBitNative(@this, n);
				return ret != 0;
			}
		}

		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_SetBit")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void SetBit([NativeName(NativeNameType.Param, "n")] [NativeName(NativeNameType.Type, "size_t")] ulong n)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.SetBitNative(@this, n);
			}
		}

		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		[NativeName(NativeNameType.Func, "ImFontGlyphRangesBuilder_SetBit")]
		[return: NativeName(NativeNameType.Type, "void")]
		public unsafe void SetBit([NativeName(NativeNameType.Param, "n")] [NativeName(NativeNameType.Type, "size_t")] nuint n)
		{
			fixed (ImFontGlyphRangesBuilder* @this = &this)
			{
				ImGui.SetBitNative(@this, n);
			}
		}

	}

}