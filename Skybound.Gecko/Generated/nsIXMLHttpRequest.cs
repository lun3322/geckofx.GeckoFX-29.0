// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIXMLHttpRequest.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIXMLHttpRequest.idl
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
	
	
	/// <summary>nsIXMLHttpRequestEventTarget </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6ce0a193-b033-4c3d-b748-f851b09261f5")]
	public interface nsIXMLHttpRequestEventTarget : nsIDOMEventTarget
	{
		
		/// <summary>Member AddEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture);
		
		/// <summary>Member RemoveEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture);
		
		/// <summary>Member DispatchEvent </summary>
		/// <param name='evt'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent  evt);
		
		/// <summary>Member GetOnabortAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnabortAttribute();
		
		/// <summary>Member SetOnabortAttribute </summary>
		/// <param name='aOnabort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnabortAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnabort);
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnerrorAttribute();
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnerror);
		
		/// <summary>Member GetOnloadAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnloadAttribute();
		
		/// <summary>Member SetOnloadAttribute </summary>
		/// <param name='aOnload'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnload);
		
		/// <summary>Member GetOnloadstartAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnloadstartAttribute();
		
		/// <summary>Member SetOnloadstartAttribute </summary>
		/// <param name='aOnloadstart'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadstartAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnloadstart);
		
		/// <summary>Member GetOnprogressAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnprogressAttribute();
		
		/// <summary>Member SetOnprogressAttribute </summary>
		/// <param name='aOnprogress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnprogress);
	}
	
	/// <summary>nsIXMLHttpRequestUpload </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("09ff3682-7759-4441-a765-f70e1a1fabcf")]
	public interface nsIXMLHttpRequestUpload : nsIXMLHttpRequestEventTarget
	{
		
		/// <summary>Member AddEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture);
		
		/// <summary>Member RemoveEventListener </summary>
		/// <param name='type'> </param>
		/// <param name='listener'> </param>
		/// <param name='useCapture'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  listener, System.Boolean  useCapture);
		
		/// <summary>Member DispatchEvent </summary>
		/// <param name='evt'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent  evt);
		
		/// <summary>Member GetOnabortAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener  GetOnabortAttribute();
		
		/// <summary>Member SetOnabortAttribute </summary>
		/// <param name='aOnabort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnabortAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnabort);
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener  GetOnerrorAttribute();
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnerror);
		
		/// <summary>Member GetOnloadAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener  GetOnloadAttribute();
		
		/// <summary>Member SetOnloadAttribute </summary>
		/// <param name='aOnload'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnloadAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnload);
		
		/// <summary>Member GetOnloadstartAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener  GetOnloadstartAttribute();
		
		/// <summary>Member SetOnloadstartAttribute </summary>
		/// <param name='aOnloadstart'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnloadstartAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnloadstart);
		
		/// <summary>Member GetOnprogressAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener  GetOnprogressAttribute();
		
		/// <summary>Member SetOnprogressAttribute </summary>
		/// <param name='aOnprogress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnprogress);
	}
	
	/// <summary>nsIXMLHttpRequest </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6bb91106-85f0-4d93-8cb4-e57b3d0624f2")]
	public interface nsIXMLHttpRequest
	{
		
		/// <summary>Member GetChannelAttribute </summary>
		/// <returns>A nsIChannel </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel  GetChannelAttribute();
		
		/// <summary>Member GetResponseXMLAttribute </summary>
		/// <returns>A nsIDOMDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument  GetResponseXMLAttribute();
		
		/// <summary>Member GetResponseTextAttribute </summary>
		/// <param name='aResponseText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponseTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aResponseText);
		
		/// <summary>Member GetMozResponseArrayBufferAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetMozResponseArrayBufferAttribute();
		
		/// <summary>Member GetStatusAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetStatusAttribute();
		
		/// <summary>Member GetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aStatusText);
		
		/// <summary>Member Abort </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Abort();
		
		/// <summary>Member GetAllResponseHeaders </summary>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetAllResponseHeaders();
		
		/// <summary>Member GetResponseHeader </summary>
		/// <param name='header'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  header);
		
		/// <summary>Member OpenRequest </summary>
		/// <param name='method'> </param>
		/// <param name='url'> </param>
		/// <param name='async'> </param>
		/// <param name='user'> </param>
		/// <param name='password'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenRequest([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  method, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  url, System.Boolean  async, [MarshalAs(UnmanagedType.LPStruct)] nsAString user, [MarshalAs(UnmanagedType.LPStruct)] nsAString password);
		
		/// <summary>Member Open </summary>
		/// <param name='method'> </param>
		/// <param name='url'> </param>
		/// <param name='async'> </param>
		/// <param name='user'> </param>
		/// <param name='password'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  method, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  url, System.Boolean  async, [MarshalAs(UnmanagedType.LPStruct)] nsAString user, [MarshalAs(UnmanagedType.LPStruct)] nsAString password);
		
		/// <summary>Member Send </summary>
		/// <param name='body'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Send([MarshalAs(UnmanagedType.Interface)] nsIVariant  body);
		
		/// <summary>Member SendAsBinary </summary>
		/// <param name='body'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendAsBinary([MarshalAs(UnmanagedType.LPStruct)] nsAString body);
		
		/// <summary>Member SetRequestHeader </summary>
		/// <param name='header'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  header, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  value);
		
		/// <summary>Member GetReadyStateAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetReadyStateAttribute();
		
		/// <summary>Member OverrideMimeType </summary>
		/// <param name='mimetype'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OverrideMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  mimetype);
		
		/// <summary>Member GetMultipartAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetMultipartAttribute();
		
		/// <summary>Member SetMultipartAttribute </summary>
		/// <param name='aMultipart'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMultipartAttribute(System.Boolean  aMultipart);
		
		/// <summary>Member GetMozBackgroundRequestAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetMozBackgroundRequestAttribute();
		
		/// <summary>Member SetMozBackgroundRequestAttribute </summary>
		/// <param name='aMozBackgroundRequest'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozBackgroundRequestAttribute(System.Boolean  aMozBackgroundRequest);
		
		/// <summary>Member GetWithCredentialsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetWithCredentialsAttribute();
		
		/// <summary>Member SetWithCredentialsAttribute </summary>
		/// <param name='aWithCredentials'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWithCredentialsAttribute(System.Boolean  aWithCredentials);
		
		/// <summary>Member Init </summary>
		/// <param name='principal'> </param>
		/// <param name='scriptContext'> </param>
		/// <param name='ownerWindow'> </param>
		/// <param name='baseURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal, System.IntPtr scriptContext, System.IntPtr ownerWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI  baseURI);
		
		/// <summary>Member GetUploadAttribute </summary>
		/// <returns>A nsIXMLHttpRequestUpload </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXMLHttpRequestUpload  GetUploadAttribute();
		
		/// <summary>Member GetOnreadystatechangeAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnreadystatechangeAttribute();
		
		/// <summary>Member SetOnreadystatechangeAttribute </summary>
		/// <param name='aOnreadystatechange'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnreadystatechangeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnreadystatechange);
	}
	
	/// <summary>nsIXHRSendable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("840d0d00-e83e-4a29-b3c7-67e96e90a499")]
	public interface nsIXHRSendable
	{
		
		/// <summary>Member GetSendInfo </summary>
		/// <param name='body'> </param>
		/// <param name='contentType'> </param>
		/// <param name='charset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSendInfo([MarshalAs(UnmanagedType.Interface)] out nsIInputStream  body, [MarshalAs(UnmanagedType.LPStruct)] nsAString  contentType, [MarshalAs(UnmanagedType.LPStruct)] nsAString  charset);
	}
	
	/// <summary>nsIJSXMLHttpRequest </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("423fdd3d-41c9-4149-8fe5-b14a1d3912a0")]
	public interface nsIJSXMLHttpRequest
	{
		
		/// <summary>Member GetOnuploadprogressAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnuploadprogressAttribute();
		
		/// <summary>Member SetOnuploadprogressAttribute </summary>
		/// <param name='aOnuploadprogress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnuploadprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnuploadprogress);
	}
}
