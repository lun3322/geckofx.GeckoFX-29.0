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
// Generated by IDLImporter from file nsIWindowCreator2.idl
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
    /// nsIWindowCreator2 is an extension of nsIWindowCreator which allows
    /// additional information about the context of the window creation to
    /// be passed.
    ///
    /// @see nsIWindowCreator
    /// @see nsIWindowWatcher
    ///
    /// @status
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f673ec81-a4b0-11d6-964b-eb5a2bf216fc")]
	public interface nsIWindowCreator2 : nsIWindowCreator
	{
		
		/// <summary>
        ///Create a new window. Gecko will/may call this method, if made
        ///      available to it, to create new windows.
        ///      @param parent parent window, if any. null if not. the newly created
        ///                    window should be made a child/dependent window of
        ///                    the parent, if any (and if the concept applies
        ///                    to the underlying OS).
        ///      @param chromeFlags chrome features from nsIWebBrowserChrome
        ///      @return the new window
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags);
		
		/// <summary>
        ///Create a new window. Gecko will/may call this method, if made
        ///      available to it, to create new windows.
        ///      @param parent Parent window, if any. Null if not. The newly created
        ///                    window should be made a child/dependent window of
        ///                    the parent, if any (and if the concept applies
        ///                    to the underlying OS).
        ///      @param chromeFlags Chrome features from nsIWebBrowserChrome
        ///      @param contextFlags Flags about the context of the window being created.
        ///      @param uri The URL for which this window is intended. It can be null
        ///                 or zero-length. The implementation of this interface
        ///                 may use the URL to help determine what sort of window
        ///                 to open or whether to cancel window creation. It will not
        ///                 load the URL.
        ///      @param cancel Return |true| to reject window creation. If true the
        ///                    implementation has determined the window should not
        ///                    be created at all. The caller should not default
        ///                    to any possible backup scheme for creating the window.
        ///      @return the new window. Will be null if canceled or an error occurred.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome CreateChromeWindow2([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags, uint contextFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI uri, out bool cancel);
	}
}
