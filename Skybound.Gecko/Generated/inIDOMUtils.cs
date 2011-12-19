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
// Generated by IDLImporter from file inIDOMUtils.idl
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
	
	
	/// <summary>inIDOMUtils </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("70205D9E-EFD7-4658-8E9E-690400B57FD0")]
	public interface inIDOMUtils
	{
		
		/// <summary>
        /// CSS utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupportsArray GetCSSStyleRules([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPseudo);
		
		/// <summary>Member GetRuleLine </summary>
		/// <param name='aRule'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetRuleLine([MarshalAs(UnmanagedType.Interface)] nsIDOMCSSStyleRule aRule);
		
		/// <summary>
        /// DOM Node utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsIgnorableWhitespace([MarshalAs(UnmanagedType.Interface)] nsIDOMCharacterData aDataNode);
		
		/// <summary>
        /// whether we are showing anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetParentForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.Bool)] bool aShowingAnonymousContent);
		
		/// <summary>Member GetChildrenForNode </summary>
		/// <param name='aNode'> </param>
		/// <param name='aShowingAnonymousContent'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildrenForNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.Bool)] bool aShowingAnonymousContent);
		
		/// <summary>
        /// XBL utilities
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetBindingURLs([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// content state utilities
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>Member SetContentState </summary>
		/// <param name='aElement'> </param>
		/// <param name='aState'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentState([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, uint aState);
		
		/// <summary>Member GetUsedFontFaces </summary>
		/// <param name='aRange'> </param>
		/// <returns>A nsIDOMFontFaceList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFontFaceList GetUsedFontFaces([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);
	}
}
