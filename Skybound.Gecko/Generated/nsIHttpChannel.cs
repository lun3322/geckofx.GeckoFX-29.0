// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIHttpChannel.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIHttpChannel.idl
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
	
	
	/// <summary>nsIHttpChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9277fe09-f0cc-4cd9-bbce-581dd94b0260")]
	public interface nsIHttpChannel : nsIChannel
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
		
		/// <summary>Member IsPending </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsPending();
		
		/// <summary>Member GetStatusAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetStatusAttribute();
		
		/// <summary>Member Cancel </summary>
		/// <param name='aStatus'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(System.Int32  aStatus);
		
		/// <summary>Member Suspend </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Suspend();
		
		/// <summary>Member Resume </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resume();
		
		/// <summary>Member GetLoadGroupAttribute </summary>
		/// <returns>A nsILoadGroup </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILoadGroup  GetLoadGroupAttribute();
		
		/// <summary>Member SetLoadGroupAttribute </summary>
		/// <param name='aLoadGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup  aLoadGroup);
		
		/// <summary>Member GetLoadFlagsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetLoadFlagsAttribute();
		
		/// <summary>Member SetLoadFlagsAttribute </summary>
		/// <param name='aLoadFlags'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadFlagsAttribute(System.UInt32  aLoadFlags);
		
		/// <summary>Member GetOriginalURIAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI  GetOriginalURIAttribute();
		
		/// <summary>Member SetOriginalURIAttribute </summary>
		/// <param name='aOriginalURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOriginalURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aOriginalURI);
		
		/// <summary>Member GetURIAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI  GetURIAttribute();
		
		/// <summary>Member GetOwnerAttribute </summary>
		/// <returns>A nsISupports </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISupports  GetOwnerAttribute();
		
		/// <summary>Member SetOwnerAttribute </summary>
		/// <param name='aOwner'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports  aOwner);
		
		/// <summary>Member GetNotificationCallbacksAttribute </summary>
		/// <returns>A nsIInterfaceRequestor </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInterfaceRequestor  GetNotificationCallbacksAttribute();
		
		/// <summary>Member SetNotificationCallbacksAttribute </summary>
		/// <param name='aNotificationCallbacks'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNotificationCallbacksAttribute([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  aNotificationCallbacks);
		
		/// <summary>Member GetSecurityInfoAttribute </summary>
		/// <returns>A nsISupports </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISupports  GetSecurityInfoAttribute();
		
		/// <summary>Member GetContentTypeAttribute </summary>
		/// <param name='aContentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType);
		
		/// <summary>Member SetContentTypeAttribute </summary>
		/// <param name='aContentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentType);
		
		/// <summary>Member GetContentCharsetAttribute </summary>
		/// <param name='aContentCharset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentCharset);
		
		/// <summary>Member SetContentCharsetAttribute </summary>
		/// <param name='aContentCharset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aContentCharset);
		
		/// <summary>Member GetContentLengthAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetContentLengthAttribute();
		
		/// <summary>Member SetContentLengthAttribute </summary>
		/// <param name='aContentLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentLengthAttribute(System.Int32  aContentLength);
		
		/// <summary>Member Open </summary>
		/// <returns>A nsIInputStream</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream Open();
		
		/// <summary>Member AsyncOpen </summary>
		/// <param name='aListener'> </param>
		/// <param name='aContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncOpen([MarshalAs(UnmanagedType.Interface)] nsIStreamListener  aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
		
		/// <summary>Member GetRequestMethodAttribute </summary>
		/// <param name='aRequestMethod'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aRequestMethod);
		
		/// <summary>Member SetRequestMethodAttribute </summary>
		/// <param name='aRequestMethod'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aRequestMethod);
		
		/// <summary>Member GetReferrerAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetReferrerAttribute();
		
		/// <summary>Member SetReferrerAttribute </summary>
		/// <param name='aReferrer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aReferrer);
		
		/// <summary>Member GetRequestHeader </summary>
		/// <param name='aHeader'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHeader);
		
		/// <summary>Member SetRequestHeader </summary>
		/// <param name='aHeader'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aMerge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHeader, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aValue, System.Boolean  aMerge);
		
		/// <summary>Member VisitRequestHeaders </summary>
		/// <param name='aVisitor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitRequestHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor  aVisitor);
		
		/// <summary>Member GetAllowPipeliningAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowPipeliningAttribute();
		
		/// <summary>Member SetAllowPipeliningAttribute </summary>
		/// <param name='aAllowPipelining'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowPipeliningAttribute(System.Boolean  aAllowPipelining);
		
		/// <summary>Member GetRedirectionLimitAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetRedirectionLimitAttribute();
		
		/// <summary>Member SetRedirectionLimitAttribute </summary>
		/// <param name='aRedirectionLimit'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRedirectionLimitAttribute(System.UInt32  aRedirectionLimit);
		
		/// <summary>Member GetResponseStatusAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetResponseStatusAttribute();
		
		/// <summary>Member GetResponseStatusTextAttribute </summary>
		/// <param name='aResponseStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponseStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aResponseStatusText);
		
		/// <summary>Member GetRequestSucceededAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetRequestSucceededAttribute();
		
		/// <summary>Member GetResponseHeader </summary>
		/// <param name='header'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString  header);
		
		/// <summary>Member SetResponseHeader </summary>
		/// <param name='header'> </param>
		/// <param name='value'> </param>
		/// <param name='merge'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsAString  header, [MarshalAs(UnmanagedType.LPStruct)] nsAString  value, System.Boolean  merge);
		
		/// <summary>Member VisitResponseHeaders </summary>
		/// <param name='aVisitor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void VisitResponseHeaders([MarshalAs(UnmanagedType.Interface)] nsIHttpHeaderVisitor  aVisitor);
		
		/// <summary>Member IsNoStoreResponse </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNoStoreResponse();
		
		/// <summary>Member IsNoCacheResponse </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNoCacheResponse();
	}
}