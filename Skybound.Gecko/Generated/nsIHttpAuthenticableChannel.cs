// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIHttpAuthenticableChannel.idl
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
	
	
	/// <summary>nsIHttpAuthenticableChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("701093ac-5c7f-429c-99e3-423b041fccb4")]
	public interface nsIHttpAuthenticableChannel : nsIProxiedChannel
	{
		
		/// <summary>
        /// Gets the proxy info the channel was constructed with. null or a
        /// proxyInfo with type "direct" mean no proxy.
        ///
        /// The returned proxy info must not be modified.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIProxyInfo GetProxyInfoAttribute();
		
		/// <summary>
        /// If the channel being authenticated is using SSL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSSLAttribute();
		
		/// <summary>
        /// Returns if the proxy HTTP method used is CONNECT. If no proxy is being
        /// used it must return PR_FALSE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProxyMethodIsConnectAttribute();
		
		/// <summary>
        /// Cancels the current request. See nsIRequest.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aStatus);
		
		/// <summary>
        /// The load flags of this request. See nsIRequest.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLoadFlagsAttribute();
		
		/// <summary>
        /// The URI corresponding to the channel. See nsIChannel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// The load group of this request. It is here for querying its
        /// notificationCallbacks. See nsIRequest.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The notification callbacks for the channel. See nsIChannel.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInterfaceRequestor GetNotificationCallbacksAttribute();
		
		/// <summary>
        /// The HTTP request method. See nsIHttpChannel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRequestMethodAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRequestMethod);
		
		/// <summary>
        /// The "Server" response header.
        /// Return NS_ERROR_NOT_AVAILABLE if not available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetServerResponseHeaderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aServerResponseHeader);
		
		/// <summary>
        /// The Proxy-Authenticate response header.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProxyChallengesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aProxyChallenges);
		
		/// <summary>
        /// The WWW-Authenticate response header.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWWWChallengesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aWWWChallenges);
		
		/// <summary>
        /// Sets the Proxy-Authorization request header. An empty string
        /// will clear it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProxyCredentials([MarshalAs(UnmanagedType.LPStruct)] nsAString credentials);
		
		/// <summary>
        /// Sets the Authorization request header. An empty string
        /// will clear it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWWWCredentials([MarshalAs(UnmanagedType.LPStruct)] nsAString credentials);
		
		/// <summary>
        /// Called when authentication information is ready and has been set on this
        /// object using setWWWCredentials/setProxyCredentials. Implementations can
        /// continue with the request and send the given information to the server.
        ///
        /// It is called asynchronously from
        /// nsIHttpChannelAuthProvider::processAuthentication if that method returns
        /// NS_ERROR_IN_PROGRESS.
        ///
        /// @note  Any exceptions thrown from this method should be ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthAvailable();
		
		/// <summary>
        /// Notifies that the prompt was cancelled. It is called asynchronously
        /// from nsIHttpChannelAuthProvider::processAuthentication if that method
        /// returns NS_ERROR_IN_PROGRESS.
        ///
        /// @param userCancel
        /// If the user was cancelled has cancelled the authentication prompt.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthCancelled(bool userCancel);
	}
}
