// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICiter.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICiter.idl
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
	
	
	/// <summary>nsICiter </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf9102-15b3-11d2-932e-00805f8add32")]
	public interface nsICiter
	{
		
		/// <summary>Member GetCiteString </summary>
		/// <param name='aInString'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetCiteString([MarshalAs(UnmanagedType.LPStruct)] nsAString aInString);
		
		/// <summary>Member StripCites </summary>
		/// <param name='aInString'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString StripCites([MarshalAs(UnmanagedType.LPStruct)] nsAString aInString);
		
		/// <summary>Member Rewrap </summary>
		/// <param name='aInString'> </param>
		/// <param name='aWrapCol'> </param>
		/// <param name='aFirstLineOffset'> </param>
		/// <param name='aRespectNewlines'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString Rewrap([MarshalAs(UnmanagedType.LPStruct)] nsAString aInString, System.UInt32  aWrapCol, System.UInt32  aFirstLineOffset, System.Boolean  aRespectNewlines);
	}
}