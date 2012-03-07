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
// Generated by IDLImporter from file nsIXPIDialogService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// A service provided by embedding applications to override
    /// the default XUL implmementation of XPInstall dialogs.
    ///
    /// Embedding applications which wish to override the default
    /// XUL dialogs need to create a component which implements
    /// this interface and registers with the Contract ID
    /// "@mozilla.org/embedui/xpinstall-dialog-service;1"
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8cdd8baa-1dd2-11b2-909a-f0178da5c5ff")]
	public interface nsIXPIDialogService
	{
		
		/// <summary>
        /// @brief  Ask the user if it's OK to install
        ///
        /// When called the XPIDialogService implementation should pose an
        /// install confirmation dialog and return the user's response
        ///
        /// @param parent        a window that can be used to parent the modal dialog
        ///
        /// @param packageList   For each install package there will be three strings,
        /// a display name, a source URL, and a the name of the
        /// organization that signed this install.  Note that the
        /// name of the signer is not verified.  Verification
        /// happens when the the install has completely downloaded.
        /// Your user interface should only suggest that the
        /// install may be signed by this organization name.
        /// Note that an unsigned archive is indicated by an
        /// empty string.
        ///
        /// @param count         The number of strings in the packageList. This
        /// will always be three times the number of
        /// packages.
        ///
        /// @return true to install, false to cancel
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmInstall([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] System.IntPtr[] packageList, uint count);
		
		/// <summary>
        /// @brief Create and open a download-and-install progress dialog
        ///
        /// When called the XPIDialogService implementation creates and opens
        /// a dialog to display the status of the install. When the dialog
        /// is ready to be used then the observer must be called: the subject
        /// is an nsIXPIProgressDialog that nsXPInstallManager can use to control
        /// the dialog, the topic is "xpinstall-progress"  and the data is "open".
        ///
        /// If the user wishes to cancel the download, the dialog can call the
        /// observe method with the same subject and topic and the data "cancel".
        ///
        /// @note Unless this routine throws an exception the observer <b>must</b>
        /// be called or nsXPInstallManager will wait forever and never clean
        /// itself up.
        ///
        /// @param packageList   three strings per package as in confirmInstall()
        /// @param count         the number of strings in the list
        /// @param observer      nsIObserver to receive messages from the dialog
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenProgressDialog([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] System.IntPtr[] packageList, uint count, [MarshalAs(UnmanagedType.Interface)] nsIObserver observer);
	}
}
