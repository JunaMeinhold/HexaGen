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

namespace Hexa.NET.Vulkan
{

	[NativeName(NativeNameType.Enum, "VkIndirectStateFlagBitsNV")]
	public enum VkIndirectStateFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		FrontfaceBitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_INDIRECT_STATE_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkIndirectCommandsLayoutUsageFlagBitsNV")]
	public enum VkIndirectCommandsLayoutUsageFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		ExplicitPreprocessBitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NV")]
		[NativeName(NativeNameType.Value, "2")]
		IndexedSequencesBitNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NV")]
		[NativeName(NativeNameType.Value, "4")]
		UnorderedSequencesBitNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDeviceMemoryReportEventTypeEXT")]
	public enum VkDeviceMemoryReportEventTypeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		AllocateExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		FreeExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		ImportExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT")]
		[NativeName(NativeNameType.Value, "3")]
		UnimportExt = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		AllocationFailedExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDeviceDiagnosticsConfigFlagBitsNV")]
	public enum VkDeviceDiagnosticsConfigFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		EnableShaderDebugInfoBitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
		[NativeName(NativeNameType.Value, "2")]
		EnableResourceTrackingBitNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
		[NativeName(NativeNameType.Value, "4")]
		EnableAutomaticCheckpointsBitNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV")]
		[NativeName(NativeNameType.Value, "8")]
		EnableShaderErrorReportingBitNv = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_DIAGNOSTICS_CONFIG_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkGraphicsPipelineLibraryFlagBitsEXT")]
	public enum VkGraphicsPipelineLibraryFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_GRAPHICS_PIPELINE_LIBRARY_VERTEX_INPUT_INTERFACE_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		VertexInputInterfaceBitExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_GRAPHICS_PIPELINE_LIBRARY_PRE_RASTERIZATION_SHADERS_BIT_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		PreRasterizationShadersBitExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_SHADER_BIT_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		FragmentShaderBitExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_OUTPUT_INTERFACE_BIT_EXT")]
		[NativeName(NativeNameType.Value, "8")]
		FragmentOutputInterfaceBitExt = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_GRAPHICS_PIPELINE_LIBRARY_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkFragmentShadingRateTypeNV")]
	public enum VkFragmentShadingRateTypeNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV")]
		[NativeName(NativeNameType.Value, "0")]
		SizeNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV")]
		[NativeName(NativeNameType.Value, "1")]
		EnumsNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_TYPE_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkFragmentShadingRateNV")]
	public enum VkFragmentShadingRateNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
		[NativeName(NativeNameType.Value, "0")]
		Rate1InvocationPerPixelNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
		[NativeName(NativeNameType.Value, "1")]
		Rate1InvocationPer1X2PixelsNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
		[NativeName(NativeNameType.Value, "4")]
		Rate1InvocationPer2X1PixelsNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
		[NativeName(NativeNameType.Value, "5")]
		Rate1InvocationPer2X2PixelsNv = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
		[NativeName(NativeNameType.Value, "6")]
		Rate1InvocationPer2X4PixelsNv = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
		[NativeName(NativeNameType.Value, "9")]
		Rate1InvocationPer4X2PixelsNv = unchecked(9),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
		[NativeName(NativeNameType.Value, "10")]
		Rate1InvocationPer4X4PixelsNv = unchecked(10),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
		[NativeName(NativeNameType.Value, "11")]
		Rate2InvocationsPerPixelNv = unchecked(11),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
		[NativeName(NativeNameType.Value, "12")]
		Rate4InvocationsPerPixelNv = unchecked(12),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
		[NativeName(NativeNameType.Value, "13")]
		Rate8InvocationsPerPixelNv = unchecked(13),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
		[NativeName(NativeNameType.Value, "14")]
		Rate16InvocationsPerPixelNv = unchecked(14),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV")]
		[NativeName(NativeNameType.Value, "15")]
		NoInvocationsNv = unchecked(15),
		[NativeName(NativeNameType.EnumItem, "VK_FRAGMENT_SHADING_RATE_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkAccelerationStructureMotionInstanceTypeNV")]
	public enum VkAccelerationStructureMotionInstanceTypeNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV")]
		[NativeName(NativeNameType.Value, "0")]
		StaticNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV")]
		[NativeName(NativeNameType.Value, "1")]
		MatrixMotionNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV")]
		[NativeName(NativeNameType.Value, "2")]
		SrtMotionNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkImageCompressionFlagBitsEXT")]
	public enum VkImageCompressionFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_DEFAULT_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		DefaultExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		FixedRateDefaultExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		FixedRateExplicitExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_DISABLED_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		DisabledExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkImageCompressionFixedRateFlagBitsEXT")]
	public enum VkImageCompressionFixedRateFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		NoneExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		Rate1BpcBitExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		Rate2BpcBitExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		Rate3BpcBitExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "8")]
		Rate4BpcBitExt = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "16")]
		Rate5BpcBitExt = unchecked(16),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "32")]
		Rate6BpcBitExt = unchecked(32),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "64")]
		Rate7BpcBitExt = unchecked(64),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "128")]
		Rate8BpcBitExt = unchecked(128),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "256")]
		Rate9BpcBitExt = unchecked(256),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "512")]
		Rate10BpcBitExt = unchecked(512),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1024")]
		Rate11BpcBitExt = unchecked(1024),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "2048")]
		Rate12BpcBitExt = unchecked(2048),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "4096")]
		Rate13BpcBitExt = unchecked(4096),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "8192")]
		Rate14BpcBitExt = unchecked(8192),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "16384")]
		Rate15BpcBitExt = unchecked(16384),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "32768")]
		Rate16BpcBitExt = unchecked(32768),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "65536")]
		Rate17BpcBitExt = unchecked(65536),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "131072")]
		Rate18BpcBitExt = unchecked(131072),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "262144")]
		Rate19BpcBitExt = unchecked(262144),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "524288")]
		Rate20BpcBitExt = unchecked(524288),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1048576")]
		Rate21BpcBitExt = unchecked(1048576),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "2097152")]
		Rate22BpcBitExt = unchecked(2097152),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "4194304")]
		Rate23BpcBitExt = unchecked(4194304),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT")]
		[NativeName(NativeNameType.Value, "8388608")]
		Rate24BpcBitExt = unchecked(8388608),
		[NativeName(NativeNameType.EnumItem, "VK_IMAGE_COMPRESSION_FIXED_RATE_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDeviceFaultAddressTypeEXT")]
	public enum VkDeviceFaultAddressTypeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		NoneExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		ReadInvalidExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		WriteInvalidExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT")]
		[NativeName(NativeNameType.Value, "3")]
		ExecuteInvalidExt = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		InstructionPointerUnknownExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT")]
		[NativeName(NativeNameType.Value, "5")]
		InstructionPointerInvalidExt = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT")]
		[NativeName(NativeNameType.Value, "6")]
		InstructionPointerFaultExt = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_ADDRESS_TYPE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDeviceFaultVendorBinaryHeaderVersionEXT")]
	public enum VkDeviceFaultVendorBinaryHeaderVersionEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		OneExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDeviceAddressBindingTypeEXT")]
	public enum VkDeviceAddressBindingTypeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		BindExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		UnbindExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_ADDRESS_BINDING_TYPE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDeviceAddressBindingFlagBitsEXT")]
	public enum VkDeviceAddressBindingFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		InternalObjectBitExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DEVICE_ADDRESS_BINDING_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkMicromapTypeEXT")]
	public enum VkMicromapTypeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		OpacityMicromapExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_MICROMAP_TYPE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkBuildMicromapModeEXT")]
	public enum VkBuildMicromapModeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_MICROMAP_MODE_BUILD_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		Ext = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_MICROMAP_MODE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkCopyMicromapModeEXT")]
	public enum VkCopyMicromapModeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_COPY_MICROMAP_MODE_CLONE_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		CloneExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_COPY_MICROMAP_MODE_SERIALIZE_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		SerializeExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		DeserializeExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_COPY_MICROMAP_MODE_COMPACT_EXT")]
		[NativeName(NativeNameType.Value, "3")]
		CompactExt = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_COPY_MICROMAP_MODE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpacityMicromapFormatEXT")]
	public enum VkOpacityMicromapFormatEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		Format2StateExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		Format4StateExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_FORMAT_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpacityMicromapSpecialIndexEXT")]
	public enum VkOpacityMicromapSpecialIndexEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT")]
		[NativeName(NativeNameType.Value, "-1")]
		FullyTransparentExt = unchecked(-1),
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT")]
		[NativeName(NativeNameType.Value, "-2")]
		FullyOpaqueExt = unchecked(-2),
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT")]
		[NativeName(NativeNameType.Value, "-3")]
		FullyUnknownTransparentExt = unchecked(-3),
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT")]
		[NativeName(NativeNameType.Value, "-4")]
		FullyUnknownOpaqueExt = unchecked(-4),
		[NativeName(NativeNameType.EnumItem, "VK_OPACITY_MICROMAP_SPECIAL_INDEX_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkAccelerationStructureCompatibilityKHR")]
	public enum VkAccelerationStructureCompatibilityKHR : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR")]
		[NativeName(NativeNameType.Value, "0")]
		CompatibleKhr = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR")]
		[NativeName(NativeNameType.Value, "1")]
		IncompatibleKhr = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_MAX_ENUM_KHR")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumKhr = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkAccelerationStructureBuildTypeKHR")]
	public enum VkAccelerationStructureBuildTypeKHR : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR")]
		[NativeName(NativeNameType.Value, "0")]
		HostKhr = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR")]
		[NativeName(NativeNameType.Value, "1")]
		DeviceKhr = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR")]
		[NativeName(NativeNameType.Value, "2")]
		HostOrDeviceKhr = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_MAX_ENUM_KHR")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumKhr = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkBuildMicromapFlagBitsEXT")]
	public enum VkBuildMicromapFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		PreferFastTraceBitExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		PreferFastBuildBitExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		AllowCompactionBitExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_MICROMAP_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkMicromapCreateFlagBitsEXT")]
	public enum VkMicromapCreateFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		DeviceAddressCaptureReplayBitExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_MICROMAP_CREATE_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkSubpassMergeStatusEXT")]
	public enum VkSubpassMergeStatusEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_MERGED_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		MergedExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		DisallowedExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		NotMergedSideEffectsExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT")]
		[NativeName(NativeNameType.Value, "3")]
		NotMergedSamplesMismatchExt = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		NotMergedViewsMismatchExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT")]
		[NativeName(NativeNameType.Value, "5")]
		NotMergedAliasingExt = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT")]
		[NativeName(NativeNameType.Value, "6")]
		NotMergedDependenciesExt = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT")]
		[NativeName(NativeNameType.Value, "7")]
		NotMergedIncompatibleInputAttachmentExt = unchecked(7),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT")]
		[NativeName(NativeNameType.Value, "8")]
		NotMergedTooManyAttachmentsExt = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT")]
		[NativeName(NativeNameType.Value, "9")]
		NotMergedInsufficientStorageExt = unchecked(9),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT")]
		[NativeName(NativeNameType.Value, "10")]
		NotMergedDepthStencilCountExt = unchecked(10),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT")]
		[NativeName(NativeNameType.Value, "11")]
		NotMergedResolveAttachmentReuseExt = unchecked(11),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT")]
		[NativeName(NativeNameType.Value, "12")]
		NotMergedSingleSubpassExt = unchecked(12),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT")]
		[NativeName(NativeNameType.Value, "13")]
		NotMergedUnspecifiedExt = unchecked(13),
		[NativeName(NativeNameType.EnumItem, "VK_SUBPASS_MERGE_STATUS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkDirectDriverLoadingModeLUNARG")]
	public enum VkDirectDriverLoadingModeLUNARG : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG")]
		[NativeName(NativeNameType.Value, "0")]
		ExclusiveLunarg = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG")]
		[NativeName(NativeNameType.Value, "1")]
		InclusiveLunarg = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_DIRECT_DRIVER_LOADING_MODE_MAX_ENUM_LUNARG")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumLunarg = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpticalFlowPerformanceLevelNV")]
	public enum VkOpticalFlowPerformanceLevelNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV")]
		[NativeName(NativeNameType.Value, "0")]
		UnknownNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV")]
		[NativeName(NativeNameType.Value, "1")]
		SlowNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV")]
		[NativeName(NativeNameType.Value, "2")]
		MediumNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV")]
		[NativeName(NativeNameType.Value, "3")]
		FastNv = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpticalFlowSessionBindingPointNV")]
	public enum VkOpticalFlowSessionBindingPointNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV")]
		[NativeName(NativeNameType.Value, "0")]
		UnknownNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		InputNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV")]
		[NativeName(NativeNameType.Value, "2")]
		ReferenceNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV")]
		[NativeName(NativeNameType.Value, "3")]
		HintNv = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV")]
		[NativeName(NativeNameType.Value, "4")]
		VectorNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV")]
		[NativeName(NativeNameType.Value, "5")]
		BackwardFlowVectorNv = unchecked(5),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV")]
		[NativeName(NativeNameType.Value, "6")]
		CostNv = unchecked(6),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV")]
		[NativeName(NativeNameType.Value, "7")]
		BackwardCostNv = unchecked(7),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV")]
		[NativeName(NativeNameType.Value, "8")]
		GlobalFlowNv = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_BINDING_POINT_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpticalFlowGridSizeFlagBitsNV")]
	public enum VkOpticalFlowGridSizeFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV")]
		[NativeName(NativeNameType.Value, "0")]
		UnknownNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		Size1X1BitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV")]
		[NativeName(NativeNameType.Value, "2")]
		Size2X2BitNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV")]
		[NativeName(NativeNameType.Value, "4")]
		Size4X4BitNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV")]
		[NativeName(NativeNameType.Value, "8")]
		Size8X8BitNv = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_GRID_SIZE_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpticalFlowUsageFlagBitsNV")]
	public enum VkOpticalFlowUsageFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV")]
		[NativeName(NativeNameType.Value, "0")]
		UnknownNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		InputBitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV")]
		[NativeName(NativeNameType.Value, "2")]
		OutputBitNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV")]
		[NativeName(NativeNameType.Value, "4")]
		HintBitNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_COST_BIT_NV")]
		[NativeName(NativeNameType.Value, "8")]
		CostBitNv = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV")]
		[NativeName(NativeNameType.Value, "16")]
		GlobalFlowBitNv = unchecked(16),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_USAGE_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpticalFlowSessionCreateFlagBitsNV")]
	public enum VkOpticalFlowSessionCreateFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		EnableHintBitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV")]
		[NativeName(NativeNameType.Value, "2")]
		EnableCostBitNv = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV")]
		[NativeName(NativeNameType.Value, "4")]
		EnableGlobalFlowBitNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV")]
		[NativeName(NativeNameType.Value, "8")]
		AllowRegionsBitNv = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV")]
		[NativeName(NativeNameType.Value, "16")]
		BothDirectionsBitNv = unchecked(16),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_SESSION_CREATE_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkOpticalFlowExecuteFlagBitsNV")]
	public enum VkOpticalFlowExecuteFlagBitsNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV")]
		[NativeName(NativeNameType.Value, "1")]
		DisableTemporalHintsBitNv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_OPTICAL_FLOW_EXECUTE_FLAG_BITS_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkShaderCodeTypeEXT")]
	public enum VkShaderCodeTypeEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CODE_TYPE_BINARY_EXT")]
		[NativeName(NativeNameType.Value, "0")]
		BinaryExt = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CODE_TYPE_SPIRV_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		SpirvExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CODE_TYPE_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkShaderCreateFlagBitsEXT")]
	public enum VkShaderCreateFlagBitsEXT : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_LINK_STAGE_BIT_EXT")]
		[NativeName(NativeNameType.Value, "1")]
		LinkStageBitExt = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT")]
		[NativeName(NativeNameType.Value, "2")]
		AllowVaryingSubgroupSizeBitExt = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT")]
		[NativeName(NativeNameType.Value, "4")]
		RequireFullSubgroupsBitExt = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT")]
		[NativeName(NativeNameType.Value, "8")]
		NoTaskShaderBitExt = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT")]
		[NativeName(NativeNameType.Value, "16")]
		DispatchBaseBitExt = unchecked(16),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT")]
		[NativeName(NativeNameType.Value, "32")]
		FragmentShadingRateAttachmentBitExt = unchecked(32),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT")]
		[NativeName(NativeNameType.Value, "64")]
		FragmentDensityMapAttachmentBitExt = unchecked(64),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_CREATE_FLAG_BITS_MAX_ENUM_EXT")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumExt = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkRayTracingInvocationReorderModeNV")]
	public enum VkRayTracingInvocationReorderModeNV : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV")]
		[NativeName(NativeNameType.Value, "0")]
		NoneNv = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV")]
		[NativeName(NativeNameType.Value, "1")]
		Nv = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_RAY_TRACING_INVOCATION_REORDER_MODE_MAX_ENUM_NV")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumNv = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkBuildAccelerationStructureModeKHR")]
	public enum VkBuildAccelerationStructureModeKHR : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR")]
		[NativeName(NativeNameType.Value, "0")]
		Khr = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR")]
		[NativeName(NativeNameType.Value, "1")]
		UpdateKhr = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_BUILD_ACCELERATION_STRUCTURE_MODE_MAX_ENUM_KHR")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumKhr = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkAccelerationStructureCreateFlagBitsKHR")]
	public enum VkAccelerationStructureCreateFlagBitsKHR : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
		[NativeName(NativeNameType.Value, "1")]
		DeviceAddressCaptureReplayBitKhr = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
		[NativeName(NativeNameType.Value, "8")]
		DescriptorBufferCaptureReplayBitExt = unchecked(8),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV")]
		[NativeName(NativeNameType.Value, "4")]
		MotionBitNv = unchecked(4),
		[NativeName(NativeNameType.EnumItem, "VK_ACCELERATION_STRUCTURE_CREATE_FLAG_BITS_MAX_ENUM_KHR")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumKhr = unchecked(2147483647),
	}

	[NativeName(NativeNameType.Enum, "VkShaderGroupShaderKHR")]
	public enum VkShaderGroupShaderKHR : int
	{
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_GROUP_SHADER_GENERAL_KHR")]
		[NativeName(NativeNameType.Value, "0")]
		GeneralKhr = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR")]
		[NativeName(NativeNameType.Value, "1")]
		ClosestHitKhr = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_GROUP_SHADER_ANY_HIT_KHR")]
		[NativeName(NativeNameType.Value, "2")]
		AnyHitKhr = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_GROUP_SHADER_INTERSECTION_KHR")]
		[NativeName(NativeNameType.Value, "3")]
		IntersectionKhr = unchecked(3),
		[NativeName(NativeNameType.EnumItem, "VK_SHADER_GROUP_SHADER_MAX_ENUM_KHR")]
		[NativeName(NativeNameType.Value, "2147483647")]
		MaxEnumKhr = unchecked(2147483647),
	}

}
