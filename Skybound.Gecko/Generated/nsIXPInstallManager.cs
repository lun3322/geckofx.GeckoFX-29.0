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
// Generated by IDLImporter from file nsIXPInstallManager.idl
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
    /// Interface to XPInstallManager - manages download and install operations.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("83fdd52f-2d34-4e22-981d-cf3c4ae76faa")]
	public interface nsIXPInstallManager
	{
		
		/// <summary>
        /// Initiates a download and install operation of the supplied URLs
        /// and sends notifications to the supplied listener.
        /// @param aURLs     array of XPI urls to download and install
        /// @param aURLCount number of XPI urls in aURLs
        /// @param aListener a listener to receive status notifications
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitManagerFromChrome([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] System.IntPtr[] aURLs, uint aURLCount, [MarshalAs(UnmanagedType.Interface)] nsIXPIProgressDialog aListener);
		
		/// <summary>
        /// Initiates a set of downloads and checks the supplied hashes after
        /// download. Just like initManagerFromChrome() in all other respects
        /// @param aURLs     array of XPI urls to download and install
        /// @param aHashes   array of hash strings to validate. The entire array
        /// or individual hashes can be null to indicate no
        /// checking. If supplied looks like "type:hash", like
        /// "md5:3232bc5624041c507db0965324188024".
        /// Supports the types in nsICryptoHash
        /// @param aURLCount number of XPI urls in aURLs and aHashes
        /// @param aListener a listener to receive status notifications
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitManagerWithHashes([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] System.IntPtr[] aURLs, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] string[] aHashes, uint aURLCount, [MarshalAs(UnmanagedType.Interface)] nsIXPIProgressDialog aListener);
		
		/// <summary>
        /// Initiates a set of downloads based on an install info object. Will
        /// display confirmation dialog as if the install info had been supplied
        /// by content.
        /// @param aInstallInfo The install info object providing install triggers
        /// and script context for the install.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitManagerWithInstallInfo([MarshalAs(UnmanagedType.Interface)] nsIXPIInstallInfo aInstallInfo);
	}
}
