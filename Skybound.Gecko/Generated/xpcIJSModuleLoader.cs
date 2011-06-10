// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: xpcIJSModuleLoader.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file xpcIJSModuleLoader.idl
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
	
	
	/// <summary>xpcIJSModuleLoader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("89da3673-e699-4f26-9ed7-11a528011434")]
	public interface xpcIJSModuleLoader
	{
		
		/// <summary>Member Import </summary>
		/// <param name='aResourceURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Import([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aResourceURI);
		
		/// <summary>Member ImportInto </summary>
		/// <param name='aResourceURI'> </param>
		/// <param name='targetObj'> </param>
		/// <param name='cc'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr ImportInto([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aResourceURI, System.IntPtr  targetObj, System.IntPtr cc);
	}
}
