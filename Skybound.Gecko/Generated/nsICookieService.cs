// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICookieService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICookieService.idl
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
	
	
	/// <summary>nsICookieService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2aaa897a-293c-4d2b-a657-8c9b7136996d")]
	public interface nsICookieService
	{
		
		/// <summary>Member GetCookieString </summary>
		/// <param name='aURI'> </param>
		/// <param name='aChannel'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCookieString([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel  aChannel);
		
		/// <summary>Member GetCookieStringFromHttp </summary>
		/// <param name='aURI'> </param>
		/// <param name='aFirstURI'> </param>
		/// <param name='aChannel'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCookieStringFromHttp([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI  aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIChannel  aChannel);
		
		/// <summary>Member SetCookieString </summary>
		/// <param name='aURI'> </param>
		/// <param name='aPrompt'> </param>
		/// <param name='aCookie'> </param>
		/// <param name='aChannel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookieString([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIPrompt  aPrompt, [MarshalAs(UnmanagedType.LPStr)] System.String  aCookie, [MarshalAs(UnmanagedType.Interface)] nsIChannel  aChannel);
		
		/// <summary>Member SetCookieStringFromHttp </summary>
		/// <param name='aURI'> </param>
		/// <param name='aFirstURI'> </param>
		/// <param name='aPrompt'> </param>
		/// <param name='aCookie'> </param>
		/// <param name='aServerTime'> </param>
		/// <param name='aChannel'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookieStringFromHttp([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI  aFirstURI, [MarshalAs(UnmanagedType.Interface)] nsIPrompt  aPrompt, [MarshalAs(UnmanagedType.LPStr)] System.String  aCookie, [MarshalAs(UnmanagedType.LPStr)] System.String  aServerTime, [MarshalAs(UnmanagedType.Interface)] nsIChannel  aChannel);
	}
}