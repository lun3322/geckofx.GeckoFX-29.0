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
// Generated by IDLImporter from file nsPILoadGroupInternal.idl
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
    /// Dumping ground for load group experimental work.
    /// This interface will never be frozen.  If you are
    /// using any feature exposed by this interface, be aware that this interface
    /// will change and you will be broken.  You have been warned.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6ef2f8ac-9584-48f3-957a-0c94fff0c8c7")]
	public interface nsPILoadGroupInternal
	{
		
		/// <summary>
        /// Called when the load group has loaded main page and
        /// subresources. (i.e.essentially DOMComplete)
        ///
        /// @param aDefaultChanel
        /// The request channel for the base apge
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEndPageLoad([MarshalAs(UnmanagedType.Interface)] nsIChannel aDefaultChannel);
	}
}
