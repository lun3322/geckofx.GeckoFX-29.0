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
// Generated by IDLImporter from file nsIWinAppHelper.idl
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
    /// A scriptable interface used on Windows only to do some work from
    /// a special process that gets created with elevated privileges.
    ///
    /// @status UNSTABLE - This interface is not frozen and will probably change in
    /// future releases.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dc263ca8-b257-47eb-b5b7-339d9e0b90f7")]
	public interface nsIWinAppHelper
	{
		
		/// <summary>
        /// A scriptable interface used on Windows only to do some work from
        /// a special process that gets created with elevated privileges.
        ///
        /// @status UNSTABLE - This interface is not frozen and will probably change in
        /// future releases.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUserCanElevateAttribute();
	}
}
