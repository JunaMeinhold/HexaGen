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
	/// Renderer capabilities.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "bgfx_caps_s")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct BgfxCaps
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "rendererType")]
		[NativeName(NativeNameType.Type, "bgfx_renderer_type_t")]
		public BgfxRendererType RendererType;

		/// <summary>
		/// Supported functionality.<br/>
		/// <br/>
		/// <summary>
		/// To be documented.
		/// </summary>
		/// </summary>
		[NativeName(NativeNameType.Field, "supported")]
		[NativeName(NativeNameType.Type, "uint64_t")]
		public ulong Supported;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "vendorId")]
		[NativeName(NativeNameType.Type, "uint16_t")]
		public ushort VendorId;

		/// <summary>
		/// Selected GPU vendor PCI id.              <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "deviceId")]
		[NativeName(NativeNameType.Type, "uint16_t")]
		public ushort DeviceId;

		/// <summary>
		/// Selected GPU device id.                  <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "homogeneousDepth")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte HomogeneousDepth;

		/// <summary>
		/// True when NDC depth is in [-1, 1] range, otherwise its [0, 1]. <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "originBottomLeft")]
		[NativeName(NativeNameType.Type, "bool")]
		public byte OriginBottomLeft;

		/// <summary>
		/// True when NDC origin is at bottom left.  <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "numGPUs")]
		[NativeName(NativeNameType.Type, "uint8_t")]
		public byte NumGPUs;

		/// <summary>
		/// Number of enumerated GPUs.               <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "gpu")]
		[NativeName(NativeNameType.Type, "bgfx_caps_gpu_t[4]")]
		public BgfxCapsGpu Gpu_0;
		public BgfxCapsGpu Gpu_1;
		public BgfxCapsGpu Gpu_2;
		public BgfxCapsGpu Gpu_3;

		/// <summary>
		/// Enumerated GPUs.                         <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "limits")]
		[NativeName(NativeNameType.Type, "bgfx_caps_limits_t")]
		public BgfxCapsLimits Limits;

		/// <summary>
		/// Supported texture format capabilities flags:<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_NONE` - Texture format is not supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_2D` - Texture format is supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_2D_SRGB` - Texture as sRGB format is supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_2D_EMULATED` - Texture format is emulated.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_3D` - Texture format is supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_3D_SRGB` - Texture as sRGB format is supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_3D_EMULATED` - Texture format is emulated.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_CUBE` - Texture format is supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_CUBE_SRGB` - Texture as sRGB format is supported.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_CUBE_EMULATED` - Texture format is emulated.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_VERTEX` - Texture format can be used from vertex shader.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_IMAGE_READ` - Texture format can be used as image<br/>
		/// and read from.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_IMAGE_WRITE` - Texture format can be used as image<br/>
		/// and written to.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_FRAMEBUFFER` - Texture format can be used as frame<br/>
		/// buffer.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_FRAMEBUFFER_MSAA` - Texture format can be used as MSAA<br/>
		/// frame buffer.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_MSAA` - Texture can be sampled as MSAA.<br/>
		/// - `BGFX_CAPS_FORMAT_TEXTURE_MIP_AUTOGEN` - Texture format supports auto-generated<br/>
		/// mips.<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "formats")]
		[NativeName(NativeNameType.Type, "uint16_t[96]")]
		public ushort Formats_0;
		public ushort Formats_1;
		public ushort Formats_2;
		public ushort Formats_3;
		public ushort Formats_4;
		public ushort Formats_5;
		public ushort Formats_6;
		public ushort Formats_7;
		public ushort Formats_8;
		public ushort Formats_9;
		public ushort Formats_10;
		public ushort Formats_11;
		public ushort Formats_12;
		public ushort Formats_13;
		public ushort Formats_14;
		public ushort Formats_15;
		public ushort Formats_16;
		public ushort Formats_17;
		public ushort Formats_18;
		public ushort Formats_19;
		public ushort Formats_20;
		public ushort Formats_21;
		public ushort Formats_22;
		public ushort Formats_23;
		public ushort Formats_24;
		public ushort Formats_25;
		public ushort Formats_26;
		public ushort Formats_27;
		public ushort Formats_28;
		public ushort Formats_29;
		public ushort Formats_30;
		public ushort Formats_31;
		public ushort Formats_32;
		public ushort Formats_33;
		public ushort Formats_34;
		public ushort Formats_35;
		public ushort Formats_36;
		public ushort Formats_37;
		public ushort Formats_38;
		public ushort Formats_39;
		public ushort Formats_40;
		public ushort Formats_41;
		public ushort Formats_42;
		public ushort Formats_43;
		public ushort Formats_44;
		public ushort Formats_45;
		public ushort Formats_46;
		public ushort Formats_47;
		public ushort Formats_48;
		public ushort Formats_49;
		public ushort Formats_50;
		public ushort Formats_51;
		public ushort Formats_52;
		public ushort Formats_53;
		public ushort Formats_54;
		public ushort Formats_55;
		public ushort Formats_56;
		public ushort Formats_57;
		public ushort Formats_58;
		public ushort Formats_59;
		public ushort Formats_60;
		public ushort Formats_61;
		public ushort Formats_62;
		public ushort Formats_63;
		public ushort Formats_64;
		public ushort Formats_65;
		public ushort Formats_66;
		public ushort Formats_67;
		public ushort Formats_68;
		public ushort Formats_69;
		public ushort Formats_70;
		public ushort Formats_71;
		public ushort Formats_72;
		public ushort Formats_73;
		public ushort Formats_74;
		public ushort Formats_75;
		public ushort Formats_76;
		public ushort Formats_77;
		public ushort Formats_78;
		public ushort Formats_79;
		public ushort Formats_80;
		public ushort Formats_81;
		public ushort Formats_82;
		public ushort Formats_83;
		public ushort Formats_84;
		public ushort Formats_85;
		public ushort Formats_86;
		public ushort Formats_87;
		public ushort Formats_88;
		public ushort Formats_89;
		public ushort Formats_90;
		public ushort Formats_91;
		public ushort Formats_92;
		public ushort Formats_93;
		public ushort Formats_94;
		public ushort Formats_95;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BgfxCaps(BgfxRendererType rendererType = default, ulong supported = default, ushort vendorId = default, ushort deviceId = default, bool homogeneousDepth = default, bool originBottomLeft = default, byte numGPUs = default, BgfxCapsGpu* gpu = default, BgfxCapsLimits limits = default, ushort* formats = default)
		{
			RendererType = rendererType;
			Supported = supported;
			VendorId = vendorId;
			DeviceId = deviceId;
			HomogeneousDepth = homogeneousDepth ? (byte)1 : (byte)0;
			OriginBottomLeft = originBottomLeft ? (byte)1 : (byte)0;
			NumGPUs = numGPUs;
			if (gpu != default(BgfxCapsGpu*))
			{
				Gpu_0 = gpu[0];
				Gpu_1 = gpu[1];
				Gpu_2 = gpu[2];
				Gpu_3 = gpu[3];
			}
			Limits = limits;
			if (formats != default(ushort*))
			{
				Formats_0 = formats[0];
				Formats_1 = formats[1];
				Formats_2 = formats[2];
				Formats_3 = formats[3];
				Formats_4 = formats[4];
				Formats_5 = formats[5];
				Formats_6 = formats[6];
				Formats_7 = formats[7];
				Formats_8 = formats[8];
				Formats_9 = formats[9];
				Formats_10 = formats[10];
				Formats_11 = formats[11];
				Formats_12 = formats[12];
				Formats_13 = formats[13];
				Formats_14 = formats[14];
				Formats_15 = formats[15];
				Formats_16 = formats[16];
				Formats_17 = formats[17];
				Formats_18 = formats[18];
				Formats_19 = formats[19];
				Formats_20 = formats[20];
				Formats_21 = formats[21];
				Formats_22 = formats[22];
				Formats_23 = formats[23];
				Formats_24 = formats[24];
				Formats_25 = formats[25];
				Formats_26 = formats[26];
				Formats_27 = formats[27];
				Formats_28 = formats[28];
				Formats_29 = formats[29];
				Formats_30 = formats[30];
				Formats_31 = formats[31];
				Formats_32 = formats[32];
				Formats_33 = formats[33];
				Formats_34 = formats[34];
				Formats_35 = formats[35];
				Formats_36 = formats[36];
				Formats_37 = formats[37];
				Formats_38 = formats[38];
				Formats_39 = formats[39];
				Formats_40 = formats[40];
				Formats_41 = formats[41];
				Formats_42 = formats[42];
				Formats_43 = formats[43];
				Formats_44 = formats[44];
				Formats_45 = formats[45];
				Formats_46 = formats[46];
				Formats_47 = formats[47];
				Formats_48 = formats[48];
				Formats_49 = formats[49];
				Formats_50 = formats[50];
				Formats_51 = formats[51];
				Formats_52 = formats[52];
				Formats_53 = formats[53];
				Formats_54 = formats[54];
				Formats_55 = formats[55];
				Formats_56 = formats[56];
				Formats_57 = formats[57];
				Formats_58 = formats[58];
				Formats_59 = formats[59];
				Formats_60 = formats[60];
				Formats_61 = formats[61];
				Formats_62 = formats[62];
				Formats_63 = formats[63];
				Formats_64 = formats[64];
				Formats_65 = formats[65];
				Formats_66 = formats[66];
				Formats_67 = formats[67];
				Formats_68 = formats[68];
				Formats_69 = formats[69];
				Formats_70 = formats[70];
				Formats_71 = formats[71];
				Formats_72 = formats[72];
				Formats_73 = formats[73];
				Formats_74 = formats[74];
				Formats_75 = formats[75];
				Formats_76 = formats[76];
				Formats_77 = formats[77];
				Formats_78 = formats[78];
				Formats_79 = formats[79];
				Formats_80 = formats[80];
				Formats_81 = formats[81];
				Formats_82 = formats[82];
				Formats_83 = formats[83];
				Formats_84 = formats[84];
				Formats_85 = formats[85];
				Formats_86 = formats[86];
				Formats_87 = formats[87];
				Formats_88 = formats[88];
				Formats_89 = formats[89];
				Formats_90 = formats[90];
				Formats_91 = formats[91];
				Formats_92 = formats[92];
				Formats_93 = formats[93];
				Formats_94 = formats[94];
				Formats_95 = formats[95];
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe BgfxCaps(BgfxRendererType rendererType = default, ulong supported = default, ushort vendorId = default, ushort deviceId = default, bool homogeneousDepth = default, bool originBottomLeft = default, byte numGPUs = default, Span<BgfxCapsGpu> gpu = default, BgfxCapsLimits limits = default, Span<ushort> formats = default)
		{
			RendererType = rendererType;
			Supported = supported;
			VendorId = vendorId;
			DeviceId = deviceId;
			HomogeneousDepth = homogeneousDepth ? (byte)1 : (byte)0;
			OriginBottomLeft = originBottomLeft ? (byte)1 : (byte)0;
			NumGPUs = numGPUs;
			if (gpu != default(Span<BgfxCapsGpu>))
			{
				Gpu_0 = gpu[0];
				Gpu_1 = gpu[1];
				Gpu_2 = gpu[2];
				Gpu_3 = gpu[3];
			}
			Limits = limits;
			if (formats != default(Span<ushort>))
			{
				Formats_0 = formats[0];
				Formats_1 = formats[1];
				Formats_2 = formats[2];
				Formats_3 = formats[3];
				Formats_4 = formats[4];
				Formats_5 = formats[5];
				Formats_6 = formats[6];
				Formats_7 = formats[7];
				Formats_8 = formats[8];
				Formats_9 = formats[9];
				Formats_10 = formats[10];
				Formats_11 = formats[11];
				Formats_12 = formats[12];
				Formats_13 = formats[13];
				Formats_14 = formats[14];
				Formats_15 = formats[15];
				Formats_16 = formats[16];
				Formats_17 = formats[17];
				Formats_18 = formats[18];
				Formats_19 = formats[19];
				Formats_20 = formats[20];
				Formats_21 = formats[21];
				Formats_22 = formats[22];
				Formats_23 = formats[23];
				Formats_24 = formats[24];
				Formats_25 = formats[25];
				Formats_26 = formats[26];
				Formats_27 = formats[27];
				Formats_28 = formats[28];
				Formats_29 = formats[29];
				Formats_30 = formats[30];
				Formats_31 = formats[31];
				Formats_32 = formats[32];
				Formats_33 = formats[33];
				Formats_34 = formats[34];
				Formats_35 = formats[35];
				Formats_36 = formats[36];
				Formats_37 = formats[37];
				Formats_38 = formats[38];
				Formats_39 = formats[39];
				Formats_40 = formats[40];
				Formats_41 = formats[41];
				Formats_42 = formats[42];
				Formats_43 = formats[43];
				Formats_44 = formats[44];
				Formats_45 = formats[45];
				Formats_46 = formats[46];
				Formats_47 = formats[47];
				Formats_48 = formats[48];
				Formats_49 = formats[49];
				Formats_50 = formats[50];
				Formats_51 = formats[51];
				Formats_52 = formats[52];
				Formats_53 = formats[53];
				Formats_54 = formats[54];
				Formats_55 = formats[55];
				Formats_56 = formats[56];
				Formats_57 = formats[57];
				Formats_58 = formats[58];
				Formats_59 = formats[59];
				Formats_60 = formats[60];
				Formats_61 = formats[61];
				Formats_62 = formats[62];
				Formats_63 = formats[63];
				Formats_64 = formats[64];
				Formats_65 = formats[65];
				Formats_66 = formats[66];
				Formats_67 = formats[67];
				Formats_68 = formats[68];
				Formats_69 = formats[69];
				Formats_70 = formats[70];
				Formats_71 = formats[71];
				Formats_72 = formats[72];
				Formats_73 = formats[73];
				Formats_74 = formats[74];
				Formats_75 = formats[75];
				Formats_76 = formats[76];
				Formats_77 = formats[77];
				Formats_78 = formats[78];
				Formats_79 = formats[79];
				Formats_80 = formats[80];
				Formats_81 = formats[81];
				Formats_82 = formats[82];
				Formats_83 = formats[83];
				Formats_84 = formats[84];
				Formats_85 = formats[85];
				Formats_86 = formats[86];
				Formats_87 = formats[87];
				Formats_88 = formats[88];
				Formats_89 = formats[89];
				Formats_90 = formats[90];
				Formats_91 = formats[91];
				Formats_92 = formats[92];
				Formats_93 = formats[93];
				Formats_94 = formats[94];
				Formats_95 = formats[95];
			}
		}


		/// <summary>
		/// Number of enumerated GPUs.               <br/>
		/// </summary>
		public unsafe Span<BgfxCapsGpu> Gpu
		
		{
			get
			{
				fixed (BgfxCapsGpu* p = &this.Gpu_0)
				{
					return new Span<BgfxCapsGpu>(p, 4);
				}
			}
		}
	}

}