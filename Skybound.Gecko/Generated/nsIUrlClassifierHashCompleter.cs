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
// Generated by IDLImporter from file nsIUrlClassifierHashCompleter.idl
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
    /// This interface is implemented by nsIUrlClassifierHashCompleter clients.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bbd6c954-7cb4-4447-bc55-8cefd1ceed89")]
	public interface nsIUrlClassifierHashCompleterCallback
	{
		
		/// <summary>
        /// A complete hash has been found that matches the partial hash.
        /// This method may be called 0-n times for a given
        /// nsIUrlClassifierCompleter::complete() call.
        ///
        /// @param hash
        /// The 128-bit hash that was discovered.
        /// @param table
        /// The name of the table that this hash belongs to.
        /// @param chunkId
        /// The database chunk that this hash belongs to.
        /// @param trusted
        /// The completion was verified with a MAC and can be cached.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Completion([MarshalAs(UnmanagedType.LPStruct)] nsAString hash, [MarshalAs(UnmanagedType.LPStruct)] nsAString table, uint chunkId, bool trusted);
		
		/// <summary>
        /// The completion is complete.  This method is called once per
        /// nsIUrlClassifierCompleter::complete() call, after all completion()
        /// calls are finished.
        ///
        /// @param status
        /// NS_OK if the request completed successfully, or an error code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CompletionFinished(int status);
	}
	
	/// <summary>
    /// Clients updating the url-classifier database have the option of sending
    /// partial (32-bit) hashes of URL fragments to be blacklisted.  If the
    /// url-classifier encounters one of these truncated hashes, it will ask
    /// an nsIUrlClassifierCompleter instance to asynchronously provide the
    /// complete hash, along with some associated metadata.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ade9b72b-3562-44f5-aba6-e63246be53ae")]
	public interface nsIUrlClassifierHashCompleter
	{
		
		/// <summary>
        /// Request a completed hash.
        ///
        /// @param partialHash
        /// The 32-bit hash encountered by the url-classifier.
        /// @param callback
        /// An nsIUrlClassifierCompleterCallback instance.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Complete([MarshalAs(UnmanagedType.LPStruct)] nsAString partialHash, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierHashCompleterCallback callback);
		
		/// <summary>
        /// Set the client and wrapped key for verified updates.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetKeys([MarshalAs(UnmanagedType.LPStruct)] nsAString clientKey, [MarshalAs(UnmanagedType.LPStruct)] nsAString wrappedKey);
		
		/// <summary>
        /// The URL for the gethash request
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGethashUrlAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aGethashUrl);
		
		/// <summary>
        /// The URL for the gethash request
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGethashUrlAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aGethashUrl);
	}
}
