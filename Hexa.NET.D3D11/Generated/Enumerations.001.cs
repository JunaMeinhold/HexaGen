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
using Hexa.NET.DXGI;
using Hexa.NET.D3DCommon;
using HexaGen.Runtime.COM;

namespace Hexa.NET.D3D11
{

	/// <summary>
	public enum D3D11ShaderTrackingResourceType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		UavDevicememory = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		NonUavDevicememory = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		AllDevicememory = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		GroupsharedMemory = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "5")]
		AllSharedMemory = unchecked(5),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		GroupsharedNonUav = unchecked(6),

		/// <summary>
		[NativeName(NativeNameType.Value, "7")]
		All = unchecked(7),

	}

	/// <summary>
	public enum D3D11ShaderTrackingOption : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Ignore = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		TrackUninitialized = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		TrackRaw = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		TrackWar = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		TrackWaw = unchecked(8),

		/// <summary>
		[NativeName(NativeNameType.Value, "16")]
		AllowSame = unchecked(16),

		/// <summary>
		[NativeName(NativeNameType.Value, "32")]
		TrackAtomicConsistency = unchecked(32),

		/// <summary>
		[NativeName(NativeNameType.Value, "64")]
		TrackRawAcrossThreadgroups = unchecked(64),

		/// <summary>
		[NativeName(NativeNameType.Value, "128")]
		TrackWarAcrossThreadgroups = unchecked(128),

		/// <summary>
		[NativeName(NativeNameType.Value, "256")]
		TrackWawAcrossThreadgroups = unchecked(256),

		/// <summary>
		[NativeName(NativeNameType.Value, "512")]
		TrackAtomicConsistencyAcrossThreadgroups = unchecked(512),

		/// <summary>
		[NativeName(NativeNameType.Value, "960")]
		UavSpecificFlags = unchecked(960),

		/// <summary>
		[NativeName(NativeNameType.Value, "1006")]
		AllHazards = unchecked(1006),

		/// <summary>
		[NativeName(NativeNameType.Value, "1022")]
		AllHazardsAllowingSame = unchecked(1022),

		/// <summary>
		[NativeName(NativeNameType.Value, "1023")]
		AllOptions = unchecked(1023),

	}

	/// <summary>
	public enum D3D11ShaderVersionType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		ShverPixelShader = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		ShverVertexShader = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		ShverGeometryShader = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		ShverHullShader = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		ShverDomainShader = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "5")]
		ShverComputeShader = unchecked(5),

		/// <summary>
		[NativeName(NativeNameType.Value, "65520")]
		ShverReserved0 = unchecked(65520),

	}

	/// <summary>
	public enum D3D11ShaderType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		VertexShader = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		HullShader = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		DomainShader = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		GeometryShader = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "5")]
		PixelShader = unchecked(5),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		ComputeShader = unchecked(6),

	}

	/// <summary>
	public enum D3D11TraceGsInputPrimitive : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Undefined = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Point = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Line = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		Triangle = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		LineAdj = unchecked(6),

		/// <summary>
		[NativeName(NativeNameType.Value, "7")]
		TriangleAdj = unchecked(7),

	}

	/// <summary>
	public enum D3D11TraceRegisterType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		OutputNullRegister = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		InputRegister = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		InputPrimitiveIdRegister = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		ImmediateConstantBuffer = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		TempRegister = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "5")]
		IndexableTempRegister = unchecked(5),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		OutputRegister = unchecked(6),

		/// <summary>
		[NativeName(NativeNameType.Value, "7")]
		OutputDepthRegister = unchecked(7),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		ConstantBuffer = unchecked(8),

		/// <summary>
		[NativeName(NativeNameType.Value, "9")]
		Immediate32 = unchecked(9),

		/// <summary>
		[NativeName(NativeNameType.Value, "10")]
		Sampler = unchecked(10),

		/// <summary>
		[NativeName(NativeNameType.Value, "11")]
		Resource = unchecked(11),

		/// <summary>
		[NativeName(NativeNameType.Value, "12")]
		Rasterizer = unchecked(12),

		/// <summary>
		[NativeName(NativeNameType.Value, "13")]
		OutputCoverageMask = unchecked(13),

		/// <summary>
		[NativeName(NativeNameType.Value, "14")]
		Stream = unchecked(14),

		/// <summary>
		[NativeName(NativeNameType.Value, "15")]
		ThisPointer = unchecked(15),

		/// <summary>
		[NativeName(NativeNameType.Value, "16")]
		OutputControlPointIdRegister = unchecked(16),

		/// <summary>
		[NativeName(NativeNameType.Value, "17")]
		InputForkInstanceIdRegister = unchecked(17),

		/// <summary>
		[NativeName(NativeNameType.Value, "18")]
		InputJoinInstanceIdRegister = unchecked(18),

		/// <summary>
		[NativeName(NativeNameType.Value, "19")]
		InputControlPointRegister = unchecked(19),

		/// <summary>
		[NativeName(NativeNameType.Value, "20")]
		OutputControlPointRegister = unchecked(20),

		/// <summary>
		[NativeName(NativeNameType.Value, "21")]
		InputPatchConstantRegister = unchecked(21),

		/// <summary>
		[NativeName(NativeNameType.Value, "22")]
		InputDomainPointRegister = unchecked(22),

		/// <summary>
		[NativeName(NativeNameType.Value, "23")]
		UnorderedAccessView = unchecked(23),

		/// <summary>
		[NativeName(NativeNameType.Value, "24")]
		ThreadGroupSharedMemory = unchecked(24),

		/// <summary>
		[NativeName(NativeNameType.Value, "25")]
		InputThreadIdRegister = unchecked(25),

		/// <summary>
		[NativeName(NativeNameType.Value, "26")]
		InputThreadGroupIdRegister = unchecked(26),

		/// <summary>
		[NativeName(NativeNameType.Value, "27")]
		InputThreadIdInGroupRegister = unchecked(27),

		/// <summary>
		[NativeName(NativeNameType.Value, "28")]
		InputCoverageMaskRegister = unchecked(28),

		/// <summary>
		[NativeName(NativeNameType.Value, "29")]
		InputThreadIdInGroupFlattenedRegister = unchecked(29),

		/// <summary>
		[NativeName(NativeNameType.Value, "30")]
		InputGsInstanceIdRegister = unchecked(30),

		/// <summary>
		[NativeName(NativeNameType.Value, "31")]
		OutputDepthGreaterEqualRegister = unchecked(31),

		/// <summary>
		[NativeName(NativeNameType.Value, "32")]
		OutputDepthLessEqualRegister = unchecked(32),

		/// <summary>
		[NativeName(NativeNameType.Value, "33")]
		Immediate64 = unchecked(33),

		/// <summary>
		[NativeName(NativeNameType.Value, "34")]
		InputCycleCounterRegister = unchecked(34),

		/// <summary>
		[NativeName(NativeNameType.Value, "35")]
		InterfacePointer = unchecked(35),

	}

	/// <summary>
	public enum D3D11LogicOp : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Clear = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Set = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Copy = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		CopyInverted = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		Noop = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "5")]
		Invert = unchecked(5),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		And = unchecked(6),

		/// <summary>
		[NativeName(NativeNameType.Value, "7")]
		Nand = unchecked(7),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		Or = unchecked(8),

		/// <summary>
		[NativeName(NativeNameType.Value, "9")]
		Nor = unchecked(9),

		/// <summary>
		[NativeName(NativeNameType.Value, "10")]
		Xor = unchecked(10),

		/// <summary>
		[NativeName(NativeNameType.Value, "11")]
		Equiv = unchecked(11),

		/// <summary>
		[NativeName(NativeNameType.Value, "12")]
		AndReverse = unchecked(12),

		/// <summary>
		[NativeName(NativeNameType.Value, "13")]
		AndInverted = unchecked(13),

		/// <summary>
		[NativeName(NativeNameType.Value, "14")]
		OrReverse = unchecked(14),

		/// <summary>
		[NativeName(NativeNameType.Value, "15")]
		OrInverted = unchecked(15),

	}

	/// <summary>
	public enum D3D11CryptoSessionStatus : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Ok = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		KeyLost = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		KeyAndContentLost = unchecked(2),

	}

	/// <summary>
	public enum D3D11CopyFlags : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		NoOverwrite = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Discard = unchecked(2),

	}

	/// <summary>
	public enum D3D111CreateDeviceContextStateFlag : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Singlethreaded = unchecked(1),

	}

	/// <summary>
	public enum D3D11VideoDecoderCaps : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Downsample = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		NonRealTime = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		DownsampleDynamic = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		DownsampleRequired = unchecked(8),

		/// <summary>
		[NativeName(NativeNameType.Value, "16")]
		Unsupported = unchecked(16),

	}

	/// <summary>
	public enum D3D11VideoProcessorBehaviorHints : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		HintMultiplaneOverlayRotation = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		HintMultiplaneOverlayResize = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		HintMultiplaneOverlayColorSpaceConversion = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		HintTripleBufferOutput = unchecked(8),

	}

	/// <summary>
	public enum D3D11TileMappingFlag : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		NoOverwrite = unchecked(1),

	}

	/// <summary>
	public enum D3D11TileRangeFlag : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Null = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Skip = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		ReuseSingleTile = unchecked(4),

	}

	/// <summary>
	public enum D3D11CheckMultisampleQualityLevelsFlag : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		TiledResource = unchecked(1),

	}

	/// <summary>
	public enum D3D11TileCopyFlag : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		NoOverwrite = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		LinearBufferToSwizzledTiledResource = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		SwizzledTiledResourceToLinearBuffer = unchecked(4),

	}

	/// <summary>
	public enum D3D11TextureLayout : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Undefined = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		RowMajor = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Layout64kStandardSwizzle = unchecked(2),

	}

	/// <summary>
	public enum D3D11ConservativeRasterizationMode : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Off = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		On = unchecked(1),

	}

	/// <summary>
	public enum D3D11ContextType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		All = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Type3D = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Compute = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		Copy = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		Video = unchecked(4),

	}

	/// <summary>
	public enum D3D11FenceFlag : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Shared = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		SharedCrossAdapter = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		NonMonitored = unchecked(8),

	}

	/// <summary>
	public enum DxgiHdrMetadataType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		None = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Hdr10 = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Hdr10Plus = unchecked(2),

	}

	/// <summary>
	public enum D3D11FeatureVideo : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		DecoderHistogram = unchecked(0),

	}

	/// <summary>
	public enum D3D11CryptoSessionKeyExchangeFlags : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		FlagNone = unchecked(0),

	}

	/// <summary>
	public enum D3D11VideoDecoderHistogramComponent : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Componenty = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Componentu = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Componentv = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		Componentr = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Componentg = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Componentb = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		Componenta = unchecked(3),

	}

	/// <summary>
	public enum D3D11VideoDecoderHistogramComponentFlags : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		FlagNone = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Flagy = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Flagu = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		Flagv = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		Flagr = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		Flagg = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		Flagb = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		Flaga = unchecked(8),

	}

	/// <summary>
	public enum D3DPrimitive : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		D3DPrimitiveUndefined = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		D3DPrimitivePoint = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		D3DPrimitiveLine = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		D3DPrimitiveTriangle = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		D3DPrimitiveLineAdj = unchecked(6),

		/// <summary>
		[NativeName(NativeNameType.Value, "7")]
		D3DPrimitiveTriangleAdj = unchecked(7),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		D3DPrimitive1ControlPointPatch = unchecked(8),

		/// <summary>
		[NativeName(NativeNameType.Value, "9")]
		D3DPrimitive2ControlPointPatch = unchecked(9),

		/// <summary>
		[NativeName(NativeNameType.Value, "10")]
		D3DPrimitive3ControlPointPatch = unchecked(10),

		/// <summary>
		[NativeName(NativeNameType.Value, "11")]
		D3DPrimitive4ControlPointPatch = unchecked(11),

		/// <summary>
		[NativeName(NativeNameType.Value, "12")]
		D3DPrimitive5ControlPointPatch = unchecked(12),

		/// <summary>
		[NativeName(NativeNameType.Value, "13")]
		D3DPrimitive6ControlPointPatch = unchecked(13),

		/// <summary>
		[NativeName(NativeNameType.Value, "14")]
		D3DPrimitive7ControlPointPatch = unchecked(14),

		/// <summary>
		[NativeName(NativeNameType.Value, "15")]
		D3DPrimitive8ControlPointPatch = unchecked(15),

		/// <summary>
		[NativeName(NativeNameType.Value, "16")]
		D3DPrimitive9ControlPointPatch = unchecked(16),

		/// <summary>
		[NativeName(NativeNameType.Value, "17")]
		D3DPrimitive10ControlPointPatch = unchecked(17),

		/// <summary>
		[NativeName(NativeNameType.Value, "18")]
		D3DPrimitive11ControlPointPatch = unchecked(18),

		/// <summary>
		[NativeName(NativeNameType.Value, "19")]
		D3DPrimitive12ControlPointPatch = unchecked(19),

		/// <summary>
		[NativeName(NativeNameType.Value, "20")]
		D3DPrimitive13ControlPointPatch = unchecked(20),

		/// <summary>
		[NativeName(NativeNameType.Value, "21")]
		D3DPrimitive14ControlPointPatch = unchecked(21),

		/// <summary>
		[NativeName(NativeNameType.Value, "22")]
		D3DPrimitive15ControlPointPatch = unchecked(22),

		/// <summary>
		[NativeName(NativeNameType.Value, "23")]
		D3DPrimitive16ControlPointPatch = unchecked(23),

		/// <summary>
		[NativeName(NativeNameType.Value, "24")]
		D3DPrimitive17ControlPointPatch = unchecked(24),

		/// <summary>
		[NativeName(NativeNameType.Value, "25")]
		D3DPrimitive18ControlPointPatch = unchecked(25),

		/// <summary>
		[NativeName(NativeNameType.Value, "26")]
		D3DPrimitive19ControlPointPatch = unchecked(26),

		/// <summary>
		[NativeName(NativeNameType.Value, "27")]
		D3DPrimitive20ControlPointPatch = unchecked(27),

		/// <summary>
		[NativeName(NativeNameType.Value, "28")]
		D3DPrimitive21ControlPointPatch = unchecked(28),

		/// <summary>
		[NativeName(NativeNameType.Value, "29")]
		D3DPrimitive22ControlPointPatch = unchecked(29),

		/// <summary>
		[NativeName(NativeNameType.Value, "30")]
		D3DPrimitive23ControlPointPatch = unchecked(30),

		/// <summary>
		[NativeName(NativeNameType.Value, "31")]
		D3DPrimitive24ControlPointPatch = unchecked(31),

		/// <summary>
		[NativeName(NativeNameType.Value, "32")]
		D3DPrimitive25ControlPointPatch = unchecked(32),

		/// <summary>
		[NativeName(NativeNameType.Value, "33")]
		D3DPrimitive26ControlPointPatch = unchecked(33),

		/// <summary>
		[NativeName(NativeNameType.Value, "34")]
		D3DPrimitive27ControlPointPatch = unchecked(34),

		/// <summary>
		[NativeName(NativeNameType.Value, "35")]
		D3DPrimitive28ControlPointPatch = unchecked(35),

		/// <summary>
		[NativeName(NativeNameType.Value, "36")]
		D3DPrimitive29ControlPointPatch = unchecked(36),

		/// <summary>
		[NativeName(NativeNameType.Value, "37")]
		D3DPrimitive30ControlPointPatch = unchecked(37),

		/// <summary>
		[NativeName(NativeNameType.Value, "38")]
		D3DPrimitive31ControlPointPatch = unchecked(38),

		/// <summary>
		[NativeName(NativeNameType.Value, "39")]
		D3DPrimitive32ControlPointPatch = unchecked(39),

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_UNDEFINED")]
		D3D10PrimitiveUndefined = D3DPrimitiveUndefined,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_POINT")]
		D3D10PrimitivePoint = D3DPrimitivePoint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_LINE")]
		D3D10PrimitiveLine = D3DPrimitiveLine,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_TRIANGLE")]
		D3D10PrimitiveTriangle = D3DPrimitiveTriangle,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_LINE_ADJ")]
		D3D10PrimitiveLineAdj = D3DPrimitiveLineAdj,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_TRIANGLE_ADJ")]
		D3D10PrimitiveTriangleAdj = D3DPrimitiveTriangleAdj,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_UNDEFINED")]
		Undefined = D3DPrimitiveUndefined,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_POINT")]
		Point = D3DPrimitivePoint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_LINE")]
		Line = D3DPrimitiveLine,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_TRIANGLE")]
		Triangle = D3DPrimitiveTriangle,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_LINE_ADJ")]
		LineAdj = D3DPrimitiveLineAdj,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_TRIANGLE_ADJ")]
		TriangleAdj = D3DPrimitiveTriangleAdj,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_1_CONTROL_POINT_PATCH")]
		Primitive1ControlPointPatch = D3DPrimitive1ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_2_CONTROL_POINT_PATCH")]
		Primitive2ControlPointPatch = D3DPrimitive2ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_3_CONTROL_POINT_PATCH")]
		Primitive3ControlPointPatch = D3DPrimitive3ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_4_CONTROL_POINT_PATCH")]
		Primitive4ControlPointPatch = D3DPrimitive4ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_5_CONTROL_POINT_PATCH")]
		Primitive5ControlPointPatch = D3DPrimitive5ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_6_CONTROL_POINT_PATCH")]
		Primitive6ControlPointPatch = D3DPrimitive6ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_7_CONTROL_POINT_PATCH")]
		Primitive7ControlPointPatch = D3DPrimitive7ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_8_CONTROL_POINT_PATCH")]
		Primitive8ControlPointPatch = D3DPrimitive8ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_9_CONTROL_POINT_PATCH")]
		Primitive9ControlPointPatch = D3DPrimitive9ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_10_CONTROL_POINT_PATCH")]
		Primitive10ControlPointPatch = D3DPrimitive10ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_11_CONTROL_POINT_PATCH")]
		Primitive11ControlPointPatch = D3DPrimitive11ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_12_CONTROL_POINT_PATCH")]
		Primitive12ControlPointPatch = D3DPrimitive12ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_13_CONTROL_POINT_PATCH")]
		Primitive13ControlPointPatch = D3DPrimitive13ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_14_CONTROL_POINT_PATCH")]
		Primitive14ControlPointPatch = D3DPrimitive14ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_15_CONTROL_POINT_PATCH")]
		Primitive15ControlPointPatch = D3DPrimitive15ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_16_CONTROL_POINT_PATCH")]
		Primitive16ControlPointPatch = D3DPrimitive16ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_17_CONTROL_POINT_PATCH")]
		Primitive17ControlPointPatch = D3DPrimitive17ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_18_CONTROL_POINT_PATCH")]
		Primitive18ControlPointPatch = D3DPrimitive18ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_19_CONTROL_POINT_PATCH")]
		Primitive19ControlPointPatch = D3DPrimitive19ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_20_CONTROL_POINT_PATCH")]
		Primitive20ControlPointPatch = D3DPrimitive20ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_21_CONTROL_POINT_PATCH")]
		Primitive21ControlPointPatch = D3DPrimitive21ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_22_CONTROL_POINT_PATCH")]
		Primitive22ControlPointPatch = D3DPrimitive22ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_23_CONTROL_POINT_PATCH")]
		Primitive23ControlPointPatch = D3DPrimitive23ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_24_CONTROL_POINT_PATCH")]
		Primitive24ControlPointPatch = D3DPrimitive24ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_25_CONTROL_POINT_PATCH")]
		Primitive25ControlPointPatch = D3DPrimitive25ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_26_CONTROL_POINT_PATCH")]
		Primitive26ControlPointPatch = D3DPrimitive26ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_27_CONTROL_POINT_PATCH")]
		Primitive27ControlPointPatch = D3DPrimitive27ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_28_CONTROL_POINT_PATCH")]
		Primitive28ControlPointPatch = D3DPrimitive28ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_29_CONTROL_POINT_PATCH")]
		Primitive29ControlPointPatch = D3DPrimitive29ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_30_CONTROL_POINT_PATCH")]
		Primitive30ControlPointPatch = D3DPrimitive30ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_31_CONTROL_POINT_PATCH")]
		Primitive31ControlPointPatch = D3DPrimitive31ControlPointPatch,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_PRIMITIVE_32_CONTROL_POINT_PATCH")]
		Primitive32ControlPointPatch = D3DPrimitive32ControlPointPatch,

	}

	/// <summary>
	public enum D3DResourceReturnType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		D3DReturnTypeUnorm = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		D3DReturnTypeSnorm = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		D3DReturnTypeSint = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		D3DReturnTypeUint = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "5")]
		D3DReturnTypeFloat = unchecked(5),

		/// <summary>
		[NativeName(NativeNameType.Value, "6")]
		D3DReturnTypeMixed = unchecked(6),

		/// <summary>
		[NativeName(NativeNameType.Value, "7")]
		D3DReturnTypeDouble = unchecked(7),

		/// <summary>
		[NativeName(NativeNameType.Value, "8")]
		D3DReturnTypeContinued = unchecked(8),

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_UNORM")]
		D3D10ReturnTypeUnorm = D3DReturnTypeUnorm,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_SNORM")]
		D3D10ReturnTypeSnorm = D3DReturnTypeSnorm,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_SINT")]
		D3D10ReturnTypeSint = D3DReturnTypeSint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_UINT")]
		D3D10ReturnTypeUint = D3DReturnTypeUint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_FLOAT")]
		D3D10ReturnTypeFloat = D3DReturnTypeFloat,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_MIXED")]
		D3D10ReturnTypeMixed = D3DReturnTypeMixed,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_UNORM")]
		Unorm = D3DReturnTypeUnorm,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_SNORM")]
		Snorm = D3DReturnTypeSnorm,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_SINT")]
		Sint = D3DReturnTypeSint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_UINT")]
		Uint = D3DReturnTypeUint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_FLOAT")]
		Float = D3DReturnTypeFloat,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_MIXED")]
		Mixed = D3DReturnTypeMixed,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_DOUBLE")]
		Double = D3DReturnTypeDouble,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_RETURN_TYPE_CONTINUED")]
		Continued = D3DReturnTypeContinued,

	}

	/// <summary>
	public enum D3DCbufferType : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		D3DCtCbuffer = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		D3DCtTbuffer = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		D3DCtInterfacePointers = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		D3DCtResourceBindInfo = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_CT_CBUFFER")]
		D3D10CtCbuffer = D3DCtCbuffer,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_CT_TBUFFER")]
		D3D10CtTbuffer = D3DCtTbuffer,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_CT_CBUFFER")]
		CtCbuffer = D3DCtCbuffer,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_CT_TBUFFER")]
		CtTbuffer = D3DCtTbuffer,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_CT_INTERFACE_POINTERS")]
		CtInterfacePointers = D3DCtInterfacePointers,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_CT_RESOURCE_BIND_INFO")]
		CtResourceBindInfo = D3DCtResourceBindInfo,

	}

	/// <summary>
	public enum D3DTessellatorDomain : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		D3DTessellatorDomainUndefined = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		D3DTessellatorDomainIsoline = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		D3DTessellatorDomainTri = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		D3DTessellatorDomainQuad = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_DOMAIN_UNDEFINED")]
		Undefined = D3DTessellatorDomainUndefined,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_DOMAIN_ISOLINE")]
		Isoline = D3DTessellatorDomainIsoline,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_DOMAIN_TRI")]
		Tri = D3DTessellatorDomainTri,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_DOMAIN_QUAD")]
		Quad = D3DTessellatorDomainQuad,

	}

	/// <summary>
	public enum D3DTessellatorPartitioning : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		D3DTessellatorPartitioningUndefined = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		D3DTessellatorPartitioningInteger = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		D3DTessellatorPartitioningPow2 = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		D3DTessellatorPartitioningFractionalOdd = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		D3DTessellatorPartitioningFractionalEven = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_PARTITIONING_UNDEFINED")]
		Undefined = D3DTessellatorPartitioningUndefined,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_PARTITIONING_INTEGER")]
		Integer = D3DTessellatorPartitioningInteger,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_PARTITIONING_POW2")]
		Pow2 = D3DTessellatorPartitioningPow2,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD")]
		FractionalOdd = D3DTessellatorPartitioningFractionalOdd,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN")]
		FractionalEven = D3DTessellatorPartitioningFractionalEven,

	}

	/// <summary>
	public enum D3DTessellatorOutputPrimitive : int
	{
		/// <summary>
		[NativeName(NativeNameType.Value, "0")]
		D3DTessellatorOutputUndefined = unchecked(0),

		/// <summary>
		[NativeName(NativeNameType.Value, "1")]
		D3DTessellatorOutputPoint = unchecked(1),

		/// <summary>
		[NativeName(NativeNameType.Value, "2")]
		D3DTessellatorOutputLine = unchecked(2),

		/// <summary>
		[NativeName(NativeNameType.Value, "3")]
		D3DTessellatorOutputTriangleCw = unchecked(3),

		/// <summary>
		[NativeName(NativeNameType.Value, "4")]
		D3DTessellatorOutputTriangleCcw = unchecked(4),

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_OUTPUT_UNDEFINED")]
		Undefined = D3DTessellatorOutputUndefined,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_OUTPUT_POINT")]
		Point = D3DTessellatorOutputPoint,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_OUTPUT_LINE")]
		Line = D3DTessellatorOutputLine,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW")]
		TriangleCw = D3DTessellatorOutputTriangleCw,

		/// <summary>
		[NativeName(NativeNameType.Value, "D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW")]
		TriangleCcw = D3DTessellatorOutputTriangleCcw,

	}

}