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
// Generated by IDLImporter from file nsIWebBrowserChrome3.idl
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
	
	
	/// <summary>
    /// nsIWebBrowserChrome3 is an extension to nsIWebBrowserChrome2.    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7f2aa813-b250-4e46-afeb-97b1e91bc9a5")]
	public interface nsIWebBrowserChrome3 : nsIWebBrowserChrome2
	{
		
		/// <summary>
        /// Called when the status text in the chrome needs to be updated.
        /// @param statusType indicates what is setting the text
        /// @param status status string. null is an acceptable value meaning
        /// no status.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetStatus(uint statusType, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string status);
		
		/// <summary>
        /// The currently loaded WebBrowser.  The browser chrome may be
        /// told to set the WebBrowser object to a new object by setting this
        /// attribute.  In this case the implementer is responsible for taking the
        /// new WebBrowser object and doing any necessary initialization or setup
        /// as if it had created the WebBrowser itself.  This includes positioning
        /// setting up listeners etc.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIWebBrowser GetWebBrowserAttribute();
		
		/// <summary>
        /// The currently loaded WebBrowser.  The browser chrome may be
        /// told to set the WebBrowser object to a new object by setting this
        /// attribute.  In this case the implementer is responsible for taking the
        /// new WebBrowser object and doing any necessary initialization or setup
        /// as if it had created the WebBrowser itself.  This includes positioning
        /// setting up listeners etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetWebBrowserAttribute([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser aWebBrowser);
		
		/// <summary>
        /// The chrome flags for this browser chrome. The implementation should
        /// reflect the value of this attribute by hiding or showing its chrome
        /// appropriately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetChromeFlagsAttribute();
		
		/// <summary>
        /// The chrome flags for this browser chrome. The implementation should
        /// reflect the value of this attribute by hiding or showing its chrome
        /// appropriately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetChromeFlagsAttribute(uint aChromeFlags);
		
		/// <summary>
        /// Asks the implementer to destroy the window associated with this
        /// WebBrowser object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DestroyBrowserWindow();
		
		/// <summary>
        /// Tells the chrome to size itself such that the browser will be the
        /// specified size.
        /// @param aCX new width of the browser
        /// @param aCY new height of the browser
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SizeBrowserTo(int aCX, int aCY);
		
		/// <summary>
        /// Shows the window as a modal window.
        /// @return (the function error code) the status value specified by
        /// in exitModalEventLoop.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ShowAsModal();
		
		/// <summary>
        /// Is the window modal (that is, currently executing a modal loop)?
        /// @return true if it's a modal window
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsWindowModal();
		
		/// <summary>
        /// Exit a modal event loop if we're in one. The implementation
        /// should also exit out of the loop if the window is destroyed.
        /// @param aStatus - the result code to return from showAsModal
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ExitModalEventLoop(int aStatus);
		
		/// <summary>
        /// Called when the status text in the chrome needs to be updated.  This
        /// method may be called instead of nsIWebBrowserChrome::SetStatus.  An
        /// implementor of this method, should still implement SetStatus.
        ///
        /// @param statusType
        /// Indicates what is setting the text.
        /// @param status
        /// Status string.  Null is an acceptable value meaning no status.
        /// @param contextNode
        /// An object that provides context pertaining to the status type.
        /// If statusType is STATUS_LINK, then statusContext may be a DOM
        /// node corresponding to the source of the link.  This value can
        /// be null if there is no context.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetStatusWithContext(uint statusType, [MarshalAs(UnmanagedType.LPStruct)] nsAString statusText, [MarshalAs(UnmanagedType.Interface)] nsISupports statusContext);
		
		/// <summary>
        /// Determines the appropriate target for a link.        ///
        ///
        /// @param originalTarget        ///
        /// The original link target.        ///
        /// @param linkURI        ///
        /// Link destination URI.        ///
        /// @param aDOMNode        ///
        /// Link DOM node.        ///
        /// @param isAppTab        ///
        /// Whether or not the link is in an app tab.        ///
        /// @returns A new link target, if appropriate.        ///
        /// Otherwise returns originalTarget.        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString OnBeforeLinkTraversal([MarshalAs(UnmanagedType.LPStruct)] nsAString originalTarget, [MarshalAs(UnmanagedType.Interface)] nsIURI linkURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode linkNode, bool isAppTab);
	}
}
