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
// Generated by IDLImporter from file nsIDOMClientInformation.idl
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
	
	
	/// <summary>nsIDOMClientInformation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f8bbf8c3-c47b-465a-a221-22824449f689")]
	public interface nsIDOMClientInformation
	{
		
		/// <summary>
        /// Web Applications 1.0 Browser State: registerContentHandler
        /// Allows web services to register themselves as handlers for certain content
        /// types.
        /// http://whatwg.org/specs/web-apps/current-work/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString mimeType, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
		
		/// <summary>Member RegisterProtocolHandler </summary>
		/// <param name='protocol'> </param>
		/// <param name='uri'> </param>
		/// <param name='title'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProtocolHandler([MarshalAs(UnmanagedType.LPStruct)] nsAString protocol, [MarshalAs(UnmanagedType.LPStruct)] nsAString uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString title);
		
		/// <summary>Member MozIsLocallyAvailable </summary>
		/// <param name='uri'> </param>
		/// <param name='whenOffline'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MozIsLocallyAvailable([MarshalAs(UnmanagedType.LPStruct)] nsAString uri, bool whenOffline);
	}
}
