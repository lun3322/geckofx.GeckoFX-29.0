// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIXPointer.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIXPointer.idl
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
	
	
	/// <summary>nsIXPointerResult </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D3992637-F474-4b65-83ED-323FE69C60D2")]
	public interface nsIXPointerResult
	{
		
		/// <summary>Member Item </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMRange</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange Item(System.UInt32  index);
		
		/// <summary>Member GetLengthAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLengthAttribute();
	}
	
	/// <summary>nsIXPointerSchemeContext </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("781F4AA1-EBB3-4667-B1C2-2B35E94C4281")]
	public interface nsIXPointerSchemeContext
	{
		
		/// <summary>Member GetCountAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetCountAttribute();
		
		/// <summary>Member GetSchemeData </summary>
		/// <param name='index'> </param>
		/// <param name='scheme'> </param>
		/// <param name='data'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSchemeData(System.UInt32  index, [MarshalAs(UnmanagedType.LPStruct)] nsAString scheme, [MarshalAs(UnmanagedType.LPStruct)] nsAString data);
	}
	
	/// <summary>nsIXPointerSchemeProcessor </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("093D3559-B56B-44d0-8764-C25815715080")]
	public interface nsIXPointerSchemeProcessor
	{
		
		/// <summary>Member Evaluate </summary>
		/// <param name='aDocument'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aData'> </param>
		/// <returns>A nsIXPointerResult</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPointerResult Evaluate([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument  aDocument, [MarshalAs(UnmanagedType.Interface)] nsIXPointerSchemeContext  aContext, [MarshalAs(UnmanagedType.LPStruct)] nsAString aData);
	}
	
	/// <summary>nsIXPointerEvaluator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ADDD0FE5-8555-45b7-B763-97D5898CE268")]
	public interface nsIXPointerEvaluator
	{
		
		/// <summary>Member Evaluate </summary>
		/// <param name='aDocument'> </param>
		/// <param name='aExpression'> </param>
		/// <returns>A nsIXPointerResult</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPointerResult Evaluate([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument  aDocument, [MarshalAs(UnmanagedType.LPStruct)] nsAString aExpression);
	}
}