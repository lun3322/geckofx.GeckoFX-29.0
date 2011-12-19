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
// Generated by IDLImporter from file nsIKeygenThread.idl
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
    /// nsIKeygenThread
    /// This is used to communicate with the thread generating a key pair,
    /// to be used by the dialog displaying status information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8712a243-5539-447c-9f47-8653f40c3a09")]
	public interface nsIKeygenThread
	{
		
		/// <summary>
        /// startKeyGeneration - run the thread
        /// A user interface using this interface needs to
        /// call this method as soon as the status information
        /// is displaying. This will trigger key generation.
        /// To allow the closure of the status information,
        /// the thread needs a handle to an observer.
        ///
        /// observer will be called on the UI thread.
        /// When the key generation is done, the observe method will
        /// be called with a topic of "keygen-finished" and null data
        /// and subject.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartKeyGeneration([MarshalAs(UnmanagedType.Interface)] nsIObserver observer);
		
		/// <summary>
        /// userCanceled - notify the thread
        /// If the user canceled, the thread is no longer allowed to
        /// close the dialog. However, if the thread already closed
        /// it, we are not allowed to close it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UserCanceled([MarshalAs(UnmanagedType.Bool)] ref bool threadAlreadyClosedDialog);
	}
}
