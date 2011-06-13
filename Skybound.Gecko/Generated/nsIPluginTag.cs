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
// Generated by IDLImporter from file nsIPluginTag.idl
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
	
	
	/// <summary>nsIPluginTag </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("88e03453-a773-47ba-9d84-14f672ac99e2")]
	public interface nsIPluginTag
	{
		
		/// <summary>Member GetDescriptionAttribute </summary>
		/// <param name='aDescription'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aDescription);
		
		/// <summary>Member GetFilenameAttribute </summary>
		/// <param name='aFilename'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFilenameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aFilename);
		
		/// <summary>Member GetFullpathAttribute </summary>
		/// <param name='aFullpath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFullpathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aFullpath);
		
		/// <summary>Member GetVersionAttribute </summary>
		/// <param name='aVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aVersion);
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>Member GetDisabledAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabledAttribute();
		
		/// <summary>Member SetDisabledAttribute </summary>
		/// <param name='aDisabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabledAttribute(bool aDisabled);
		
		/// <summary>Member GetBlocklistedAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBlocklistedAttribute();
		
		/// <summary>Member SetBlocklistedAttribute </summary>
		/// <param name='aBlocklisted'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBlocklistedAttribute(bool aBlocklisted);
	}
}
