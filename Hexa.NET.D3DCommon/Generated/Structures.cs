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
using HexaGen.Runtime.COM;

namespace HexaEngine.D3DCommon
{
	[Guid("8ba5fb08-5195-40e2-ac58-0d989c3a0102")]
	[NativeName(NativeNameType.StructOrClass, "ID3D10Blob")]
	public partial struct ID3D10Blob : IComObject, IComObject<ID3D10Blob>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public static readonly Guid Guid = new("8ba5fb08-5195-40e2-ac58-0d989c3a0102");

		public unsafe ID3D10Blob (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] Guid* rIID, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, Guid*, void**, HResult>)(*LpVtbl))(ptr, rIID, ppvObject);
			return ret;
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid rIID, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* prIID = &rIID)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)prIID, ppvObject);
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface<T>([NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid rIID, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* prIID = &rIID)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)prIID, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "AddRef")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint AddRef() 
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		[NativeName(NativeNameType.Func, "GetBufferPointer")]
		[return: NativeName(NativeNameType.Type, "LPVOID")]
		public readonly unsafe void* GetBufferPointer() 
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			void* ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, void*>)(LpVtbl[3]))(ptr);
			return ret;
		}

		[NativeName(NativeNameType.Func, "GetBufferSize")]
		[return: NativeName(NativeNameType.Type, "SIZE_T")]
		public readonly unsafe nuint GetBufferSize() 
		{
			ID3D10Blob* ptr = (ID3D10Blob*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			nuint ret = ((delegate* unmanaged[Stdcall]<ID3D10Blob*, nuint>)(LpVtbl[4]))(ptr);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3D10Blob value)
		{
			return Unsafe.As<ID3D10Blob, IUnknown>(ref value);
		}

	}

	[NativeName(NativeNameType.StructOrClass, "ID3DDestructionNotifier")]
	public partial struct ID3DDestructionNotifier : IComObject, IComObject<ID3DDestructionNotifier>, IComObject<IUnknown>
	{
		public unsafe void** LpVtbl;

		public unsafe ID3DDestructionNotifier (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] Guid* rIID, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, HResult>)(*LpVtbl))(ptr, rIID, ppvObject);
			return ret;
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid rIID, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] void** ppvObject) 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* prIID = &rIID)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)prIID, ppvObject);
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface<T>([NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			ppvObject = default;
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)(ComUtils.GuidPtrOf<T>()), (void**)ppvObject.GetAddressOf());
			return ret;
		}

		[NativeName(NativeNameType.Func, "QueryInterface")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult QueryInterface<T>([NativeName(NativeNameType.Param, "riid")] [NativeName(NativeNameType.Type, "const IID&")] ref Guid rIID, [NativeName(NativeNameType.Param, "ppvObject")] [NativeName(NativeNameType.Type, "void**")] out ComPtr<T> ppvObject) where T : unmanaged, IComObject, IComObject<T>
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (Guid* prIID = &rIID)
			{
				ppvObject = default;
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, Guid*, void**, HResult>)(*LpVtbl))(ptr, (Guid*)prIID, (void**)ppvObject.GetAddressOf());
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "AddRef")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint AddRef() 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)(LpVtbl[1]))(ptr);
			return ret;
		}

		[NativeName(NativeNameType.Func, "Release")]
		[return: NativeName(NativeNameType.Type, "ULONG")]
		public readonly unsafe uint Release() 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			uint ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint>)(LpVtbl[2]))(ptr);
			return ret;
		}

		[NativeName(NativeNameType.Func, "RegisterDestructionCallback")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult RegisterDestructionCallback([NativeName(NativeNameType.Param, "callbackFn")] [NativeName(NativeNameType.Type, "PFN_DESTRUCTION_CALLBACK")] PFN_DESTRUCTION_CALLBACK callbackFn, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] void* pData, [NativeName(NativeNameType.Param, "pCallbackID")] [NativeName(NativeNameType.Type, "UINT*")] uint* pCallbackId) 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PFN_DESTRUCTION_CALLBACK, void*, uint*, HResult>)(LpVtbl[3]))(ptr, callbackFn, pData, pCallbackId);
			return ret;
		}

		[NativeName(NativeNameType.Func, "RegisterDestructionCallback")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult RegisterDestructionCallback([NativeName(NativeNameType.Param, "callbackFn")] [NativeName(NativeNameType.Type, "PFN_DESTRUCTION_CALLBACK")] PFN_DESTRUCTION_CALLBACK callbackFn, [NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "void*")] void* pData, [NativeName(NativeNameType.Param, "pCallbackID")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pCallbackId) 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppCallbackId = &pCallbackId)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, PFN_DESTRUCTION_CALLBACK, void*, uint*, HResult>)(LpVtbl[3]))(ptr, callbackFn, pData, (uint*)ppCallbackId);
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "UnregisterDestructionCallback")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult UnregisterDestructionCallback([NativeName(NativeNameType.Param, "callbackID")] [NativeName(NativeNameType.Type, "UINT")] uint callbackId) 
		{
			ID3DDestructionNotifier* ptr = (ID3DDestructionNotifier*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3DDestructionNotifier*, uint, HResult>)(LpVtbl[4]))(ptr, callbackId);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

		public unsafe static implicit operator IUnknown (ID3DDestructionNotifier value)
		{
			return Unsafe.As<ID3DDestructionNotifier, IUnknown>(ref value);
		}

	}

	[NativeName(NativeNameType.StructOrClass, "_D3D_SHADER_MACRO")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct _D3D_SHADER_MACRO
	{
		[NativeName(NativeNameType.Field, "Name")]
		[NativeName(NativeNameType.Type, "LPCSTR")]
		public unsafe byte* Name;
		[NativeName(NativeNameType.Field, "Definition")]
		[NativeName(NativeNameType.Type, "LPCSTR")]
		public unsafe byte* Definition;


	}

	[NativeName(NativeNameType.StructOrClass, "ID3DInclude")]
	public partial struct ID3DInclude : IComObject, IComObject<ID3DInclude>
	{
		public unsafe void** LpVtbl;

		public unsafe ID3DInclude (void** lpVtbl = null)
		{
			LpVtbl = lpVtbl;
		}

		[NativeName(NativeNameType.Func, "Open")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult Open([NativeName(NativeNameType.Param, "IncludeType")] [NativeName(NativeNameType.Type, "D3D_INCLUDE_TYPE")] D3D_INCLUDE_TYPE includeType, [NativeName(NativeNameType.Param, "pFileName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pFileName, [NativeName(NativeNameType.Param, "pParentData")] [NativeName(NativeNameType.Type, "LPCVOID")] void* pParentData, [NativeName(NativeNameType.Param, "ppData")] [NativeName(NativeNameType.Type, "LPCVOID*")] void** ppData, [NativeName(NativeNameType.Param, "pBytes")] [NativeName(NativeNameType.Type, "UINT*")] uint* pBytes) 
		{
			ID3DInclude* ptr = (ID3DInclude*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3D_INCLUDE_TYPE, byte*, void*, void**, uint*, HResult>)(*LpVtbl))(ptr, includeType, pFileName, pParentData, ppData, pBytes);
			return ret;
		}

		[NativeName(NativeNameType.Func, "Open")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult Open([NativeName(NativeNameType.Param, "IncludeType")] [NativeName(NativeNameType.Type, "D3D_INCLUDE_TYPE")] D3D_INCLUDE_TYPE includeType, [NativeName(NativeNameType.Param, "pFileName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pFileName, [NativeName(NativeNameType.Param, "pParentData")] [NativeName(NativeNameType.Type, "LPCVOID")] void* pParentData, [NativeName(NativeNameType.Param, "ppData")] [NativeName(NativeNameType.Type, "LPCVOID*")] ref void* ppData, [NativeName(NativeNameType.Param, "pBytes")] [NativeName(NativeNameType.Type, "UINT*")] uint* pBytes) 
		{
			ID3DInclude* ptr = (ID3DInclude*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (void** pppData = &ppData)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3D_INCLUDE_TYPE, byte*, void*, void**, uint*, HResult>)(*LpVtbl))(ptr, includeType, pFileName, pParentData, (void**)pppData, pBytes);
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "Open")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult Open([NativeName(NativeNameType.Param, "IncludeType")] [NativeName(NativeNameType.Type, "D3D_INCLUDE_TYPE")] D3D_INCLUDE_TYPE includeType, [NativeName(NativeNameType.Param, "pFileName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pFileName, [NativeName(NativeNameType.Param, "pParentData")] [NativeName(NativeNameType.Type, "LPCVOID")] void* pParentData, [NativeName(NativeNameType.Param, "ppData")] [NativeName(NativeNameType.Type, "LPCVOID*")] void** ppData, [NativeName(NativeNameType.Param, "pBytes")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pBytes) 
		{
			ID3DInclude* ptr = (ID3DInclude*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (uint* ppBytes = &pBytes)
			{
				HResult ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3D_INCLUDE_TYPE, byte*, void*, void**, uint*, HResult>)(*LpVtbl))(ptr, includeType, pFileName, pParentData, ppData, (uint*)ppBytes);
				return ret;
			}
		}

		[NativeName(NativeNameType.Func, "Open")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult Open([NativeName(NativeNameType.Param, "IncludeType")] [NativeName(NativeNameType.Type, "D3D_INCLUDE_TYPE")] D3D_INCLUDE_TYPE includeType, [NativeName(NativeNameType.Param, "pFileName")] [NativeName(NativeNameType.Type, "LPCSTR")] byte* pFileName, [NativeName(NativeNameType.Param, "pParentData")] [NativeName(NativeNameType.Type, "LPCVOID")] void* pParentData, [NativeName(NativeNameType.Param, "ppData")] [NativeName(NativeNameType.Type, "LPCVOID*")] ref void* ppData, [NativeName(NativeNameType.Param, "pBytes")] [NativeName(NativeNameType.Type, "UINT*")] ref uint pBytes) 
		{
			ID3DInclude* ptr = (ID3DInclude*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			fixed (void** pppData = &ppData)
			{
				fixed (uint* ppBytes = &pBytes)
				{
					HResult ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3D_INCLUDE_TYPE, byte*, void*, void**, uint*, HResult>)(*LpVtbl))(ptr, includeType, pFileName, pParentData, (void**)pppData, (uint*)ppBytes);
					return ret;
				}
			}
		}

		[NativeName(NativeNameType.Func, "Close")]
		[return: NativeName(NativeNameType.Type, "HRESULT")]
		public readonly unsafe HResult Close([NativeName(NativeNameType.Param, "pData")] [NativeName(NativeNameType.Type, "LPCVOID")] void* pData) 
		{
			ID3DInclude* ptr = (ID3DInclude*)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
			HResult ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, HResult>)(LpVtbl[1]))(ptr, pData);
			return ret;
		}

		unsafe void*** IComObject.AsVtblPtr()
		{
			return (void***)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
		}

	}

}