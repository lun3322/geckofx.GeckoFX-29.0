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
// Generated by IDLImporter from file nsILoginMetaInfo.idl
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
    /// An object containing metainfo for a login stored by the login manager.
    ///
    /// Code using login manager can generally ignore this interface. When adding
    /// logins, default value will be created. When modifying logins, these
    /// properties will be unchanged unless a change is explicitly requested [by
    /// using modifyLogin() with a nsIPropertyBag]. When deleting a login or
    /// comparing logins, these properties are ignored.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("20d8eb40-c494-497f-b2a6-aaa32f807ebd")]
	public interface nsILoginMetaInfo
	{
		
		/// <summary>
        /// The GUID to uniquely identify the login. This can be any arbitrary
        /// string, but a format as created by nsIUUIDGenerator is recommended.
        /// For example, "{d4e1a1f6-5ea0-40ee-bff5-da57982f21cf}"
        ///
        /// addLogin will generate a random value unless a value is provided.
        ///
        /// addLogin and modifyLogin will throw if the GUID already exists.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aGuid);
		
		/// <summary>
        /// The GUID to uniquely identify the login. This can be any arbitrary
        /// string, but a format as created by nsIUUIDGenerator is recommended.
        /// For example, "{d4e1a1f6-5ea0-40ee-bff5-da57982f21cf}"
        ///
        /// addLogin will generate a random value unless a value is provided.
        ///
        /// addLogin and modifyLogin will throw if the GUID already exists.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aGuid);
		
		/// <summary>
        /// The time, in Unix Epoch milliseconds, when the login was first created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTimeCreatedAttribute();
		
		/// <summary>
        /// The time, in Unix Epoch milliseconds, when the login was first created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimeCreatedAttribute(ulong aTimeCreated);
		
		/// <summary>
        /// The time, in Unix Epoch milliseconds, when the login was last submitted
        /// in a form or used to begin an HTTP auth session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTimeLastUsedAttribute();
		
		/// <summary>
        /// The time, in Unix Epoch milliseconds, when the login was last submitted
        /// in a form or used to begin an HTTP auth session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimeLastUsedAttribute(ulong aTimeLastUsed);
		
		/// <summary>
        /// The time, in Unix Epoch milliseconds, when the login's password was
        /// last modified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetTimePasswordChangedAttribute();
		
		/// <summary>
        /// The time, in Unix Epoch milliseconds, when the login's password was
        /// last modified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimePasswordChangedAttribute(ulong aTimePasswordChanged);
		
		/// <summary>
        /// The number of times the login was submitted in a form or used to begin
        /// an HTTP auth session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTimesUsedAttribute();
		
		/// <summary>
        /// The number of times the login was submitted in a form or used to begin
        /// an HTTP auth session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTimesUsedAttribute(uint aTimesUsed);
	}
}
