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
// Generated by IDLImporter from file nsIChromeRegistry.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsIChromeRegistry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("249fb5ad-ae29-4e2c-a728-ba5cf464d188")]
	public interface nsIChromeRegistry
	{
		
		/// <summary>
        /// Resolve a chrome URL to an loadable URI using the information in the
        /// registry. Does not modify aChromeURL.
        ///
        /// Chrome URLs are allowed to be specified in "shorthand", leaving the
        /// "file" portion off. In that case, the URL is expanded to:
        ///
        /// chrome://package/provider/package.ext
        ///
        /// where "ext" is:
        ///
        /// "xul" for a "content" package,
        /// "css" for a "skin" package, and
        /// "dtd" for a "locale" package.
        ///
        /// @param aChromeURL the URL that is to be converted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI ConvertChromeURL([MarshalAs(UnmanagedType.Interface)] nsIURI aChromeURL);
		
		/// <summary>
        /// refresh the chrome list at runtime, looking for new packages/etc
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CheckForNewChrome();
		
		/// <summary>
        /// returns whether XPCNativeWrappers are enabled for aURI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool WrappersEnabled([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
	}
	
	/// <summary>nsIXULChromeRegistry </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c2461347-2b8f-48c7-9d59-3a61fb868828")]
	public interface nsIXULChromeRegistry : nsIChromeRegistry
	{
		
		/// <summary>
        /// Resolve a chrome URL to an loadable URI using the information in the
        /// registry. Does not modify aChromeURL.
        ///
        /// Chrome URLs are allowed to be specified in "shorthand", leaving the
        /// "file" portion off. In that case, the URL is expanded to:
        ///
        /// chrome://package/provider/package.ext
        ///
        /// where "ext" is:
        ///
        /// "xul" for a "content" package,
        /// "css" for a "skin" package, and
        /// "dtd" for a "locale" package.
        ///
        /// @param aChromeURL the URL that is to be converted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI ConvertChromeURL([MarshalAs(UnmanagedType.Interface)] nsIURI aChromeURL);
		
		/// <summary>
        /// refresh the chrome list at runtime, looking for new packages/etc
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CheckForNewChrome();
		
		/// <summary>
        /// returns whether XPCNativeWrappers are enabled for aURI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool WrappersEnabled([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        ///Should be called when locales change to reload all chrome (including XUL). </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReloadChrome();
		
		/// <summary>Member GetSelectedLocale </summary>
		/// <param name='packageName'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSelectedLocale([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase packageName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Get the direction of the locale via the intl.uidirection.<locale> pref
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsLocaleRTL([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase package);
		
		/// <summary>
        ///Should be called when skins change. Reloads only stylesheets. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RefreshSkins();
		
		/// <summary>
        /// Installable skin XBL is not always granted the same privileges as other
        /// chrome. This asks the chrome registry whether scripts are allowed to be
        /// run for a particular chrome URI. Do not pass non-chrome URIs to this
        /// method.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowScriptsForPackage([MarshalAs(UnmanagedType.Interface)] nsIURI url);
		
		/// <summary>
        /// Content should only be allowed to load chrome JS from certain packages.
        /// This method reflects the contentaccessible flag on packages.
        /// Do not pass non-chrome URIs to this method.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowContentToAccess([MarshalAs(UnmanagedType.Interface)] nsIURI url);
	}
}
