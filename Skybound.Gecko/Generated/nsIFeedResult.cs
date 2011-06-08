// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIFeedResult.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIFeedResult.idl
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
	
	
	/// <summary>nsIFeedResult </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7a180b78-0f46-4569-8c22-f3d720ea1c57")]
	public interface nsIFeedResult
	{
		
		/// <summary>Member GetBozoAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetBozoAttribute();
		
		/// <summary>Member SetBozoAttribute </summary>
		/// <param name='aBozo'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBozoAttribute(System.Boolean  aBozo);
		
		/// <summary>Member GetDocAttribute </summary>
		/// <returns>A nsIFeedContainer </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFeedContainer  GetDocAttribute();
		
		/// <summary>Member SetDocAttribute </summary>
		/// <param name='aDoc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedContainer  aDoc);
		
		/// <summary>Member GetUriAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetUriAttribute();
		
		/// <summary>Member SetUriAttribute </summary>
		/// <param name='aUri'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aUri);
		
		/// <summary>Member GetVersionAttribute </summary>
		/// <param name='aVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aVersion);
		
		/// <summary>Member SetVersionAttribute </summary>
		/// <param name='aVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aVersion);
		
		/// <summary>Member GetStylesheetAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetStylesheetAttribute();
		
		/// <summary>Member SetStylesheetAttribute </summary>
		/// <param name='aStylesheet'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStylesheetAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aStylesheet);
		
		/// <summary>Member GetHeadersAttribute </summary>
		/// <returns>A nsIProperties </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProperties  GetHeadersAttribute();
		
		/// <summary>Member SetHeadersAttribute </summary>
		/// <param name='aHeaders'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeadersAttribute([MarshalAs(UnmanagedType.Interface)] nsIProperties  aHeaders);
		
		/// <summary>Member RegisterExtensionPrefix </summary>
		/// <param name='aNamespace'> </param>
		/// <param name='aPrefix'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterExtensionPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespace, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
	}
}