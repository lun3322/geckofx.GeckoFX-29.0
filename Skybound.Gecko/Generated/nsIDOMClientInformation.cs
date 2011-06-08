// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMClientInformation.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMClientInformation.idl
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
	
	
	/// <summary>nsIDOMClientInformation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f8bbf8c3-c47b-465a-a221-22824449f689")]
	public interface nsIDOMClientInformation
	{
		
		/// <summary>Member RegisterContentHandler </summary>
		/// <param name='mimeType'> </param>
		/// <param name='uri'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
		
		/// <summary>Member RegisterProtocolHandler </summary>
		/// <param name='protocol'> </param>
		/// <param name='uri'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProtocolHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString protocol, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
		
		/// <summary>Member MozIsLocallyAvailable </summary>
		/// <param name='uri'> </param>
		/// <param name='whenOffline'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MozIsLocallyAvailable([MarshalAs(UnmanagedType.LPStruct)] nsAString uri, System.Boolean  whenOffline);
	}
}