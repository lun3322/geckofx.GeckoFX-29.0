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
// Generated by IDLImporter from file nsIGeolocationProvider.idl
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
	
	
	/// <summary>
    /// Interface provides a way for a geolocation provider to
    /// notify the system that a new location is available.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B89D7227-9F04-4236-A582-25A3F2779D72")]
	public interface nsIGeolocationUpdate
	{
		
		/// <summary>
        /// Notify the geolocation service that a new geolocation
        /// has been discovered.
        /// This must be called on the main thread
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPosition position);
	}
	
	/// <summary>
    /// Interface provides location information to the nsGeolocator
    /// via the nsIDOMGeolocationCallback interface.  After
    /// startup is called, any geo location change should call
    /// callback.update().
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("701413ED-0F51-64F7-71C7-4369D8E07D6E")]
	public interface nsIGeolocationProvider
	{
		
		/// <summary>
        /// Start up the provider.  This is called before any other
        /// method.  may be called multiple times.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Startup();
		
		/// <summary>
        /// watch
        /// When a location change is observed, notify the callback
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Watch([MarshalAs(UnmanagedType.Interface)] nsIGeolocationUpdate callback);
		
		/// <summary>
        /// shutdown
        /// Shuts down the location device.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
	}
}
