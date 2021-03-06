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
// Generated by IDLImporter from file nsIScrollable.idl
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
    /// The nsIScrollable is an interface that can be implemented by a control that
    /// supports scrolling.  This is a generic interface without concern for the
    /// type of content that may be inside.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3507fc93-313e-4a4c-8ca8-4d0ea0f97315")]
	public interface nsIScrollable
	{
		
		/// <summary>
        /// Get or set the default scrollbar state for all documents in
        /// this shell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDefaultScrollbarPreferences(int scrollOrientation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDefaultScrollbarPreferences(int scrollOrientation, int scrollbarPref);
		
		/// <summary>
        /// Get information about whether the vertical and horizontal scrollbars are
        /// currently visible.  If you are only interested in one of the visibility
        /// settings pass nullptr in for the one you aren't interested in.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScrollbarVisibility([MarshalAs(UnmanagedType.U1)] ref bool verticalVisible, [MarshalAs(UnmanagedType.U1)] ref bool horizontalVisible);
	}
	
	/// <summary>nsIScrollableConsts </summary>
	public class nsIScrollableConsts
	{
		
		// <summary>
        // Constants declaring the two scroll orientations a scrollbar can be in.
        // ScrollOrientation_X - Horizontal scrolling.  When passing this
        // in to a method you are requesting or setting data for the
        // horizontal scrollbar.
        // ScrollOrientation_Y - Vertical scrolling.  When passing this
        // in to a method you are requesting or setting data for the
        // vertical scrollbar.
        // </summary>
		public const long ScrollOrientation_X = 1;
		
		// 
		public const long ScrollOrientation_Y = 2;
		
		// <summary>
        // Constants declaring the states of the scrollbars.
        // ScrollPref_Auto - bars visible only when needed.
        // ScrollPref_Never - bars never visible, even when scrolling still possible.
        // ScrollPref_Always - bars always visible, even when scrolling is not possible
        // </summary>
		public const long Scrollbar_Auto = 1;
		
		// 
		public const long Scrollbar_Never = 2;
		
		// 
		public const long Scrollbar_Always = 3;
	}
}
