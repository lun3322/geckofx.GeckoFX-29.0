// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMSVGViewSpec.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMSVGViewSpec.idl
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
	
	
	/// <summary>nsIDOMSVGViewSpec </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ede34b03-57b6-45bf-a259-3550b5697286")]
	public interface nsIDOMSVGViewSpec : nsIDOMSVGZoomAndPan
	{
		
		/// <summary>Member GetZoomAndPanAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetZoomAndPanAttribute();
		
		/// <summary>Member SetZoomAndPanAttribute </summary>
		/// <param name='aZoomAndPan'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetZoomAndPanAttribute(ushort aZoomAndPan);
		
		/// <summary>Member GetTransformAttribute </summary>
		/// <returns>A nsIDOMSVGTransformList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGTransformList  GetTransformAttribute();
		
		/// <summary>Member GetViewTargetAttribute </summary>
		/// <returns>A nsIDOMSVGElement </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMSVGElement  GetViewTargetAttribute();
		
		/// <summary>Member GetViewBoxStringAttribute </summary>
		/// <param name='aViewBoxString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetViewBoxStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aViewBoxString);
		
		/// <summary>Member GetPreserveAspectRatioStringAttribute </summary>
		/// <param name='aPreserveAspectRatioString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPreserveAspectRatioStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPreserveAspectRatioString);
		
		/// <summary>Member GetTransformStringAttribute </summary>
		/// <param name='aTransformString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTransformStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTransformString);
		
		/// <summary>Member GetViewTargetStringAttribute </summary>
		/// <param name='aViewTargetString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetViewTargetStringAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aViewTargetString);
	}
}