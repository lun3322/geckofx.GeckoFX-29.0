// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: mozIStorageBaseStatement.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file mozIStorageBaseStatement.idl
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
	
	
	/// <summary>mozIStorageBaseStatement </summary>
	[ComImport()]
	[Guid("da2ec336-fbbb-4ba1-9778-8c9825980d01")]
	public interface mozIStorageBaseStatement : mozIStorageBindingParams
	{
		
		/// <summary>Member Finalize </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finalize();
		
		/// <summary>Member BindUTF8StringParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindUTF8StringParameter(System.UInt32  aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aValue);
		
		/// <summary>Member BindStringParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindStringParameter(System.UInt32  aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		/// <summary>Member BindDoubleParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindDoubleParameter(System.UInt32  aParamIndex, double aValue);
		
		/// <summary>Member BindInt32Parameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt32Parameter(System.UInt32  aParamIndex, System.Int32  aValue);
		
		/// <summary>Member BindInt64Parameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt64Parameter(System.UInt32  aParamIndex, System.Int32  aValue);
		
		/// <summary>Member BindNullParameter </summary>
		/// <param name='aParamIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindNullParameter(System.UInt32  aParamIndex);
		
		/// <summary>Member BindBlobParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aValueSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindBlobParameter(System.UInt32  aParamIndex, System.IntPtr  aValue, System.UInt32  aValueSize);
		
		/// <summary>Member BindParameters </summary>
		/// <param name='aParameters'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindParameters(mozIStorageBindingParamsArray  aParameters);
		
		/// <summary>Member NewBindingParamsArray </summary>
		/// <returns>A mozIStorageBindingParamsArray</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageBindingParamsArray NewBindingParamsArray();
		
		/// <summary>Member ExecuteAsync </summary>
		/// <param name='aCallback'> </param>
		/// <returns>A mozIStoragePendingStatement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStoragePendingStatement ExecuteAsync(mozIStorageStatementCallback  aCallback);
		
		/// <summary>Member GetStateAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetStateAttribute();
		
		/// <summary>Member EscapeStringForLIKE </summary>
		/// <param name='aValue'> </param>
		/// <param name='aEscapeChar'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString EscapeStringForLIKE([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, System.Char  aEscapeChar);
	}
}
