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
// Generated by IDLImporter from file nsIRecoveryService.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("acb93ff8-aa6d-4bc8-bedd-2a6a3b802a74")]
	public interface nsIRecoveryService
	{
		
		/// <summary>
        /// Uses recovery to wipe the data and cache partitions. If this call is
        /// successful, the device should reboot before the function call ever returns.
        ///
        /// @throws NS_ERROR_FAILURE when rebooting into recovery fails for some reason.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FactoryReset();
		
		/// <summary>
        /// Use recovery to install an OTA update.zip. If this call is
        /// successful, the device should reboot before the function call ever returns.
        ///
        /// @throws NS_ERROR_FAILURE when rebooting into recovery fails for some reason.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InstallFotaUpdate([MarshalAs(UnmanagedType.LPStr)] string updatePath);
		
		/// <summary>
        /// @return The status of the last FOTA update. One of FOTA_UPDATE_UNKNOWN,
        /// FOTA_UPDATE_FAIL, FOTA_UPDATE_SUCCESS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFotaUpdateStatus();
	}
	
	/// <summary>nsIRecoveryServiceConsts </summary>
	public class nsIRecoveryServiceConsts
	{
		
		// <summary>
        // Possible values of fotaStatus.result. These should stay in sync with
        // librecovery/librecovery.h
        // </summary>
		public const long FOTA_UPDATE_UNKNOWN = 0;
		
		// 
		public const long FOTA_UPDATE_FAIL = 1;
		
		// 
		public const long FOTA_UPDATE_SUCCESS = 2;
	}
}
