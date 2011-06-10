// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: mozIStorageStatement.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file mozIStorageStatement.idl
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
	
	
	/// <summary>mozIStorageStatement </summary>
	[ComImport()]
	[Guid("57ec7be1-36cf-4510-b938-7d1c9ee8cec5")]
	public interface mozIStorageStatement : mozIStorageBaseStatement
	{
		
		/// <summary>Member Finalize </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Finalize();
		
		/// <summary>Member BindUTF8StringParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindUTF8StringParameter(System.UInt32  aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aValue);
		
		/// <summary>Member BindStringParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindStringParameter(System.UInt32  aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		/// <summary>Member BindDoubleParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindDoubleParameter(System.UInt32  aParamIndex, double aValue);
		
		/// <summary>Member BindInt32Parameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindInt32Parameter(System.UInt32  aParamIndex, System.Int32  aValue);
		
		/// <summary>Member BindInt64Parameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindInt64Parameter(System.UInt32  aParamIndex, System.Int32  aValue);
		
		/// <summary>Member BindNullParameter </summary>
		/// <param name='aParamIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindNullParameter(System.UInt32  aParamIndex);
		
		/// <summary>Member BindBlobParameter </summary>
		/// <param name='aParamIndex'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aValueSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindBlobParameter(System.UInt32  aParamIndex, System.IntPtr  aValue, System.UInt32  aValueSize);
		
		/// <summary>Member BindParameters </summary>
		/// <param name='aParameters'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindParameters(mozIStorageBindingParamsArray  aParameters);
		
		/// <summary>Member NewBindingParamsArray </summary>
		/// <returns>A mozIStorageBindingParamsArray</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new mozIStorageBindingParamsArray NewBindingParamsArray();
		
		/// <summary>Member ExecuteAsync </summary>
		/// <param name='aCallback'> </param>
		/// <returns>A mozIStoragePendingStatement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new mozIStoragePendingStatement ExecuteAsync(mozIStorageStatementCallback  aCallback);
		
		/// <summary>Member GetStateAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetStateAttribute();
		
		/// <summary>Member EscapeStringForLIKE </summary>
		/// <param name='aValue'> </param>
		/// <param name='aEscapeChar'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString EscapeStringForLIKE([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, System.Char  aEscapeChar);
		
		/// <summary>Member Clone </summary>
		/// <returns>A mozIStorageStatement</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageStatement Clone();
		
		/// <summary>Member GetParameterCountAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetParameterCountAttribute();
		
		/// <summary>Member GetParameterName </summary>
		/// <param name='aParamIndex'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAUTF8String GetParameterName(System.UInt32  aParamIndex);
		
		/// <summary>Member GetParameterIndex </summary>
		/// <param name='aName'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetParameterIndex([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aName);
		
		/// <summary>Member GetColumnCountAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetColumnCountAttribute();
		
		/// <summary>Member GetColumnName </summary>
		/// <param name='aColumnIndex'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAUTF8String GetColumnName(System.UInt32  aColumnIndex);
		
		/// <summary>Member GetColumnIndex </summary>
		/// <param name='aName'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetColumnIndex([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aName);
		
		/// <summary>Member GetColumnDecltype </summary>
		/// <param name='aParamIndex'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAUTF8String GetColumnDecltype(System.UInt32  aParamIndex);
		
		/// <summary>Member Reset </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset();
		
		/// <summary>Member Execute </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Execute();
		
		/// <summary>Member ExecuteStep </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ExecuteStep();
		
		/// <summary>Member GetNumEntriesAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumEntriesAttribute();
		
		/// <summary>Member GetTypeOfIndex </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTypeOfIndex(System.UInt32  aIndex);
		
		/// <summary>Member GetInt32 </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt32(System.UInt32  aIndex);
		
		/// <summary>Member GetInt64 </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt64(System.UInt32  aIndex);
		
		/// <summary>Member GetDouble </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDouble(System.UInt32  aIndex);
		
		/// <summary>Member GetUTF8String </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsAUTF8String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAUTF8String GetUTF8String(System.UInt32  aIndex);
		
		/// <summary>Member GetString </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetString(System.UInt32  aIndex);
		
		/// <summary>Member GetBlob </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aDataSize'> </param>
		/// <param name='aData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBlob(System.UInt32  aIndex, out System.UInt32  aDataSize, out System.IntPtr  aData);
		
		/// <summary>Member GetIsNull </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsNull(System.UInt32  aIndex);
		
		/// <summary>Member GetSharedUTF8String </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetSharedUTF8String(System.UInt32  aIndex, out System.UInt32  aLength);
		
		/// <summary>Member GetSharedString </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSharedString(System.UInt32  aIndex, out System.UInt32  aLength);
		
		/// <summary>Member GetSharedBlob </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetSharedBlob(System.UInt32  aIndex, out System.UInt32  aLength);
	}
}
