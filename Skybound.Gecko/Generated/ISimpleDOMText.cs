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
// Generated by IDLImporter from file ISimpleDOMText.idl
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
	
	
	/// <summary>ISimpleDOMText </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4e747be5-2052-4265-8af0-8ecad7aad1c0")]
	public interface ISimpleDOMText
	{
		
		/// <summary>
        /// Includes whitespace in DOM
        /// </summary>
		string DomText
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Member Get_clippedSubstringBounds </summary>
		/// <param name='startIndex'> </param>
		/// <param name='endIndex'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Get_clippedSubstringBounds(uint startIndex, uint endIndex, ref int x, ref int y, ref int width, ref int height);
		
		/// <summary>Member Get_unclippedSubstringBounds </summary>
		/// <param name='startIndex'> </param>
		/// <param name='endIndex'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='width'> </param>
		/// <param name='height'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Get_unclippedSubstringBounds(uint startIndex, uint endIndex, ref int x, ref int y, ref int width, ref int height);
		
		/// <summary>Member ScrollToSubstring </summary>
		/// <param name='startIndex'> </param>
		/// <param name='endIndex'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ScrollToSubstring(uint startIndex, uint endIndex);
		
		/// <summary>Gets a FontFamily </summary>
		/// <returns>A System.String </returns>
		string FontFamily
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
	}
}
