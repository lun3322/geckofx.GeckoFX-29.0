// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIToolkitProfile.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIToolkitProfile.idl
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
	
	
	/// <summary>nsIProfileLock </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("50e07b0a-f338-4da3-bcdb-f4bb0db94dbe")]
	public interface nsIProfileLock
	{
		
		/// <summary>Member GetDirectoryAttribute </summary>
		/// <returns>A nsILocalFile </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile  GetDirectoryAttribute();
		
		/// <summary>Member GetLocalDirectoryAttribute </summary>
		/// <returns>A nsILocalFile </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile  GetLocalDirectoryAttribute();
		
		/// <summary>Member Unlock </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unlock();
	}
	
	/// <summary>nsIToolkitProfile </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7422b090-4a86-4407-972e-75468a625388")]
	public interface nsIToolkitProfile
	{
		
		/// <summary>Member GetRootDirAttribute </summary>
		/// <returns>A nsILocalFile </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile  GetRootDirAttribute();
		
		/// <summary>Member GetLocalDirAttribute </summary>
		/// <returns>A nsILocalFile </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILocalFile  GetLocalDirAttribute();
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member Remove </summary>
		/// <param name='removeFiles'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove(System.Boolean  removeFiles);
		
		/// <summary>Member Lock </summary>
		/// <param name='aUnlocker'> </param>
		/// <returns>A nsIProfileLock</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProfileLock Lock([MarshalAs(UnmanagedType.Interface)] out nsIProfileUnlocker  aUnlocker);
	}
}