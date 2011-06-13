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
// Generated by IDLImporter from file nsITypeAheadFind.idl
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
    ///nsTypeAheadFind </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0749a445-19d3-4eb9-9d66-78eca8c6f604")]
	public interface nsITypeAheadFind
	{
		
		/// <summary>
        ///Necessary initialization that can't happen in the constructor, either
        /// because function calls here may fail, or because the docShell is
        /// required. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell);
		
		/// <summary>
        ///Find aSearchString in page.  If aLinksOnly is true, only search the page's
        /// hyperlinks for the string. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Find([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchString, bool aLinksOnly);
		
		/// <summary>
        ///Find another match in the page. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint FindAgain(bool findBackwards, bool aLinksOnly);
		
		/// <summary>
        ///Change searched docShell.  This happens when e.g. we use the same
        /// nsITypeAheadFind object to search different tabs. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocShell([MarshalAs(UnmanagedType.Interface)] nsIDocShell aDocShell);
		
		/// <summary>
        ///Change the look of the the "found match" selection to aToggle, and repaint
        /// the selection. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionModeAndRepaint(short toggle);
		
		/// <summary>
        ///Collapse the "found match" selection to its start.  Because not all
        /// matches are owned by the same selection controller, this doesn't
        /// necessarily happen automatically. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CollapseSelection();
		
		/// <summary>
        ///Attributes </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSearchStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aSearchString);
		
		/// <summary>
        /// Most recent search string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCaseSensitiveAttribute();
		
		/// <summary>
        /// Most recent search string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaseSensitiveAttribute(bool aCaseSensitive);
		
		/// <summary>
        /// Searches are case sensitive
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFoundLinkAttribute();
		
		/// <summary>
        /// Most recent elem found, if a link
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFoundEditableAttribute();
		
		/// <summary>
        /// Most recent elem found, if editable
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetCurrentWindowAttribute();
	}
}
