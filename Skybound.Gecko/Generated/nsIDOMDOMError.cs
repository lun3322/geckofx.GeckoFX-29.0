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
// Generated by IDLImporter from file nsIDOMDOMError.idl
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
    /// The nsIDOMDOMError interface is "An non-zero implementation
    /// dependent error code describing the error, or 0 if there is no
    /// error." [sic]
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/2002/WD-DOM-Level-3-Core-20020409/core.html
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("475790ce-d8fa-4e02-a167-e6308ba9b120")]
	public interface nsIDOMDOMError
	{
		
		/// <summary>
        /// The nsIDOMDOMError interface is "An non-zero implementation
        /// dependent error code describing the error, or 0 if there is no
        /// error." [sic]
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/2002/WD-DOM-Level-3-Core-20020409/core.html
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetSeverityAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMessageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage);
		
		/// <summary>
        /// do some magic to make that work?
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetRelatedExceptionAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDOMLocator GetLocationAttribute();
	}
}
