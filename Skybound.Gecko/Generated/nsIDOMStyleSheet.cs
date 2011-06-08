// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMStyleSheet.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMStyleSheet.idl
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
	
	
	/// <summary>nsIDOMStyleSheet </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf9080-15b3-11d2-932e-00805f8add32")]
	public interface nsIDOMStyleSheet
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetDisabledAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDisabledAttribute();
		
		/// <summary>Member SetDisabledAttribute </summary>
		/// <param name='aDisabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabledAttribute(System.Boolean  aDisabled);
		
		/// <summary>Member GetOwnerNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode  GetOwnerNodeAttribute();
		
		/// <summary>Member GetParentStyleSheetAttribute </summary>
		/// <returns>A nsIDOMStyleSheet </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet  GetParentStyleSheetAttribute();
		
		/// <summary>Member GetHrefAttribute </summary>
		/// <param name='aHref'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHrefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		/// <summary>Member GetTitleAttribute </summary>
		/// <param name='aTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		/// <summary>Member GetMediaAttribute </summary>
		/// <returns>A nsIDOMMediaList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList  GetMediaAttribute();
	}
}