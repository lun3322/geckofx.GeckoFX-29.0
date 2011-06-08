// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIXPCScriptable.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIXPCScriptable.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIXPCScriptable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a40ce52e-2d8c-400f-9af2-f8784a656070")]
	public interface nsIXPCScriptable
	{
		
		/// <summary>Member GetClassNameAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetClassNameAttribute();
		
		/// <summary>Member GetScriptableFlagsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetScriptableFlagsAttribute();
		
		/// <summary>Member PreCreate </summary>
		/// <param name='nativeObj'> </param>
		/// <param name='cx'> </param>
		/// <param name='globalObj'> </param>
		/// <param name='parentObj'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreCreate([MarshalAs(UnmanagedType.Interface)] nsISupports  nativeObj, System.IntPtr  cx, System.IntPtr  globalObj, out System.IntPtr  parentObj);
		
		/// <summary>Member Create </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj);
		
		/// <summary>Member PostCreate </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj);
		
		/// <summary>Member AddProperty </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='id'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AddProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr id, System.IntPtr  vp);
		
		/// <summary>Member DelProperty </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='id'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DelProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr id, System.IntPtr  vp);
		
		/// <summary>Member GetProperty </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='id'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr id, System.IntPtr  vp);
		
		/// <summary>Member SetProperty </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='id'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr id, System.IntPtr  vp);
		
		/// <summary>Member Enumerate </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Enumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj);
		
		/// <summary>Member NewEnumerate </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='enum_op'> </param>
		/// <param name='statep'> </param>
		/// <param name='idp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewEnumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.UInt32  enum_op, System.IntPtr  statep, out System.IntPtr idp);
		
		/// <summary>Member NewResolve </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='id'> </param>
		/// <param name='flags'> </param>
		/// <param name='objp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewResolve([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr id, System.UInt32  flags, out System.IntPtr  objp);
		
		/// <summary>Member Convert </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='type'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Convert([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.UInt32  type, System.IntPtr  vp);
		
		/// <summary>Member Finalize </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finalize([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj);
		
		/// <summary>Member CheckAccess </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='id'> </param>
		/// <param name='mode'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckAccess([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr id, System.UInt32  mode, System.IntPtr  vp);
		
		/// <summary>Member Call </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='argc'> </param>
		/// <param name='argv'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Call([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.UInt32  argc, System.IntPtr  argv, System.IntPtr  vp);
		
		/// <summary>Member Construct </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='argc'> </param>
		/// <param name='argv'> </param>
		/// <param name='vp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Construct([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.UInt32  argc, System.IntPtr  argv, System.IntPtr  vp);
		
		/// <summary>Member HasInstance </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='val'> </param>
		/// <param name='bp'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasInstance([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr val, out System.Boolean  bp);
		
		/// <summary>Member Trace </summary>
		/// <param name='wrapper'> </param>
		/// <param name='trc'> </param>
		/// <param name='obj'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Trace([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr trc, System.IntPtr  obj);
		
		/// <summary>Member Equality </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <param name='val'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equality([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj, System.IntPtr val);
		
		/// <summary>Member OuterObject </summary>
		/// <param name='wrapper'> </param>
		/// <param name='cx'> </param>
		/// <param name='obj'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OuterObject([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative  wrapper, System.IntPtr  cx, System.IntPtr  obj);
		
		/// <summary>Member PostCreatePrototype </summary>
		/// <param name='cx'> </param>
		/// <param name='proto'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreatePrototype(System.IntPtr  cx, System.IntPtr  proto);
	}
}