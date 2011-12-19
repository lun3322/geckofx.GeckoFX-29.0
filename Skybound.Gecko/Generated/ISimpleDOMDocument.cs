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
// Generated by IDLImporter from file ISimpleDOMDocument.idl
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
	
	
	/// <summary>ISimpleDOMDocument </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0D68D6D0-D93D-4d08-A30D-F00DD1F45B24")]
	public interface ISimpleDOMDocument
	{
		
		/// <summary>Gets a URL </summary>
		/// <returns>A System.String </returns>
		string URL
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Gets a Title </summary>
		/// <returns>A System.String </returns>
		string Title
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Gets a MimeType </summary>
		/// <returns>A System.String </returns>
		string MimeType
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Gets a DocType </summary>
		/// <returns>A System.String </returns>
		string DocType
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Member get_NameSpaceURIForID </summary>
		/// <param name='nameSpaceID'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.BStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string get_NameSpaceURIForID(short nameSpaceID);
		
		/// <summary>Sets a AlternateViewMediaTypes </summary>
		/// <returns>A System.String </returns>
		string AlternateViewMediaTypes
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}
	}
}
