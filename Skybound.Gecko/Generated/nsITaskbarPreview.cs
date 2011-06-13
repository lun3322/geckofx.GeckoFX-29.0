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
// Generated by IDLImporter from file nsITaskbarPreview.idl
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
    /// nsITaskbarPreview
    ///
    /// Common interface for both window and tab taskbar previews. This interface
    /// cannot be instantiated directly.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("CBFDF766-D002-403B-A3D9-B091C9AD465B")]
	public interface nsITaskbarPreview
	{
		
		/// <summary>
        /// The controller for this preview. A controller is required to provide
        /// the behavior and appearance of the taskbar previews. It is responsible for
        /// determining the size and contents of the preview, which buttons are
        /// displayed and how the application responds to user actions on the preview.
        ///
        /// Neither preview makes full use of the controller. See the documentation
        /// for nsITaskbarWindowPreview and nsITaskbarTabPreview for details on which
        /// controller methods are used.
        ///
        /// The controller is not allowed to be null.
        ///
        /// @see nsITaskbarPreviewController
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITaskbarPreviewController GetControllerAttribute();
		
		/// <summary>
        /// The controller for this preview. A controller is required to provide
        /// the behavior and appearance of the taskbar previews. It is responsible for
        /// determining the size and contents of the preview, which buttons are
        /// displayed and how the application responds to user actions on the preview.
        ///
        /// Neither preview makes full use of the controller. See the documentation
        /// for nsITaskbarWindowPreview and nsITaskbarTabPreview for details on which
        /// controller methods are used.
        ///
        /// The controller is not allowed to be null.
        ///
        /// @see nsITaskbarPreviewController
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetControllerAttribute([MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewController aController);
		
		/// <summary>
        /// The tooltip displayed above the preview when the user hovers over it
        ///
        /// Default: an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>
        /// The tooltip displayed above the preview when the user hovers over it
        ///
        /// Default: an empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>
        /// Whether or not the preview is visible.
        ///
        /// Changing this option is expensive for tab previews since toggling this
        /// option will destroy/create the proxy window and its registration with the
        /// taskbar. If any step of that fails, an exception will be thrown.
        ///
        /// For window previews, this operation is very cheap.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibleAttribute();
		
		/// <summary>
        /// Whether or not the preview is visible.
        ///
        /// Changing this option is expensive for tab previews since toggling this
        /// option will destroy/create the proxy window and its registration with the
        /// taskbar. If any step of that fails, an exception will be thrown.
        ///
        /// For window previews, this operation is very cheap.
        ///
        /// Default: false
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibleAttribute(bool aVisible);
		
		/// <summary>
        /// Gets/sets whether or not the preview is marked active (selected) in the
        /// taskbar.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetActiveAttribute();
		
		/// <summary>
        /// Gets/sets whether or not the preview is marked active (selected) in the
        /// taskbar.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveAttribute(bool aActive);
		
		/// <summary>
        /// Invalidates the taskbar's cached image of this preview, forcing a redraw
        /// if necessary
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Invalidate();
	}
}
