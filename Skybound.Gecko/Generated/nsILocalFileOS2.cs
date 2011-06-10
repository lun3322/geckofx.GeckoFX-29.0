// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsILocalFileOS2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsILocalFileOS2.idl
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
	
	
	/// <summary>nsILocalFileOS2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("26de2089-239d-4697-818b-bae1fe8e8e0d")]
	public interface nsILocalFileOS2 : nsILocalFile
	{
		
		/// <summary>Member Append </summary>
		/// <param name='node'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Append([MarshalAs(UnmanagedType.LPStruct)] nsAString node);
		
		/// <summary>Member AppendNative </summary>
		/// <param name='node'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AppendNative([MarshalAs(UnmanagedType.LPStruct)] nsAString  node);
		
		/// <summary>Member Normalize </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>Member Create </summary>
		/// <param name='type'> </param>
		/// <param name='permissions'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Create(System.UInt32  type, System.UInt32  permissions);
		
		/// <summary>Member GetLeafNameAttribute </summary>
		/// <param name='aLeafName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		/// <summary>Member SetLeafNameAttribute </summary>
		/// <param name='aLeafName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		/// <summary>Member GetNativeLeafNameAttribute </summary>
		/// <param name='aNativeLeafName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aNativeLeafName);
		
		/// <summary>Member SetNativeLeafNameAttribute </summary>
		/// <param name='aNativeLeafName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aNativeLeafName);
		
		/// <summary>Member CopyTo </summary>
		/// <param name='newParentDir'> </param>
		/// <param name='newName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyTo([MarshalAs(UnmanagedType.Interface)] nsIFile  newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		/// <summary>Member CopyToNative </summary>
		/// <param name='newParentDir'> </param>
		/// <param name='newName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToNative([MarshalAs(UnmanagedType.Interface)] nsIFile  newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsAString  newName);
		
		/// <summary>Member CopyToFollowingLinks </summary>
		/// <param name='newParentDir'> </param>
		/// <param name='newName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)] nsIFile  newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		/// <summary>Member CopyToFollowingLinksNative </summary>
		/// <param name='newParentDir'> </param>
		/// <param name='newName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)] nsIFile  newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsAString  newName);
		
		/// <summary>Member MoveTo </summary>
		/// <param name='newParentDir'> </param>
		/// <param name='newName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MoveTo([MarshalAs(UnmanagedType.Interface)] nsIFile  newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		/// <summary>Member MoveToNative </summary>
		/// <param name='newParentDir'> </param>
		/// <param name='newName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MoveToNative([MarshalAs(UnmanagedType.Interface)] nsIFile  newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsAString  newName);
		
		/// <summary>Member Remove </summary>
		/// <param name='recursive'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Remove(System.Boolean  recursive);
		
		/// <summary>Member GetPermissionsAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetPermissionsAttribute();
		
		/// <summary>Member SetPermissionsAttribute </summary>
		/// <param name='aPermissions'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPermissionsAttribute(System.UInt32  aPermissions);
		
		/// <summary>Member GetPermissionsOfLinkAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetPermissionsOfLinkAttribute();
		
		/// <summary>Member SetPermissionsOfLinkAttribute </summary>
		/// <param name='aPermissionsOfLink'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPermissionsOfLinkAttribute(System.UInt32  aPermissionsOfLink);
		
		/// <summary>Member GetLastModifiedTimeAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetLastModifiedTimeAttribute();
		
		/// <summary>Member SetLastModifiedTimeAttribute </summary>
		/// <param name='aLastModifiedTime'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLastModifiedTimeAttribute(System.Int64  aLastModifiedTime);
		
		/// <summary>Member GetLastModifiedTimeOfLinkAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetLastModifiedTimeOfLinkAttribute();
		
		/// <summary>Member SetLastModifiedTimeOfLinkAttribute </summary>
		/// <param name='aLastModifiedTimeOfLink'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLastModifiedTimeOfLinkAttribute(System.Int64  aLastModifiedTimeOfLink);
		
		/// <summary>Member GetFileSizeAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetFileSizeAttribute();
		
		/// <summary>Member SetFileSizeAttribute </summary>
		/// <param name='aFileSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFileSizeAttribute(System.Int64  aFileSize);
		
		/// <summary>Member GetFileSizeOfLinkAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetFileSizeOfLinkAttribute();
		
		/// <summary>Member GetTargetAttribute </summary>
		/// <param name='aTarget'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		/// <summary>Member GetNativeTargetAttribute </summary>
		/// <param name='aNativeTarget'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativeTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aNativeTarget);
		
		/// <summary>Member GetPathAttribute </summary>
		/// <param name='aPath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPath);
		
		/// <summary>Member GetNativePathAttribute </summary>
		/// <param name='aNativePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aNativePath);
		
		/// <summary>Member Exists </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Exists();
		
		/// <summary>Member IsWritable </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsWritable();
		
		/// <summary>Member IsReadable </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsReadable();
		
		/// <summary>Member IsExecutable </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsExecutable();
		
		/// <summary>Member IsHidden </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsHidden();
		
		/// <summary>Member IsDirectory </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDirectory();
		
		/// <summary>Member IsFile </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsFile();
		
		/// <summary>Member IsSymlink </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSymlink();
		
		/// <summary>Member IsSpecial </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSpecial();
		
		/// <summary>Member CreateUnique </summary>
		/// <param name='type'> </param>
		/// <param name='permissions'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CreateUnique(System.UInt32  type, System.UInt32  permissions);
		
		/// <summary>Member Clone </summary>
		/// <returns>A nsIFile</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile Clone();
		
		/// <summary>Member Equals </summary>
		/// <param name='inFile'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIFile  inFile);
		
		/// <summary>Member Contains </summary>
		/// <param name='inFile'> </param>
		/// <param name='recur'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.Interface)] nsIFile  inFile, System.Boolean  recur);
		
		/// <summary>Member GetParentAttribute </summary>
		/// <returns>A nsIFile </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile  GetParentAttribute();
		
		/// <summary>Member GetDirectoryEntriesAttribute </summary>
		/// <returns>A nsISimpleEnumerator </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISimpleEnumerator  GetDirectoryEntriesAttribute();
		
		/// <summary>Member InitWithPath </summary>
		/// <param name='filePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitWithPath([MarshalAs(UnmanagedType.LPStruct)] nsAString filePath);
		
		/// <summary>Member InitWithNativePath </summary>
		/// <param name='filePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitWithNativePath([MarshalAs(UnmanagedType.LPStruct)] nsAString  filePath);
		
		/// <summary>Member InitWithFile </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitWithFile([MarshalAs(UnmanagedType.Interface)] nsILocalFile  aFile);
		
		/// <summary>Member GetFollowLinksAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetFollowLinksAttribute();
		
		/// <summary>Member SetFollowLinksAttribute </summary>
		/// <param name='aFollowLinks'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFollowLinksAttribute(System.Boolean  aFollowLinks);
		
		/// <summary>Member OpenNSPRFileDesc </summary>
		/// <param name='flags'> </param>
		/// <param name='mode'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr OpenNSPRFileDesc(System.Int32  flags, System.Int32  mode);
		
		/// <summary>Member OpenANSIFileDesc </summary>
		/// <param name='mode'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] System.String  mode);
		
		/// <summary>Member Load </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr Load();
		
		/// <summary>Member GetDiskSpaceAvailableAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetDiskSpaceAvailableAttribute();
		
		/// <summary>Member AppendRelativePath </summary>
		/// <param name='relativeFilePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AppendRelativePath([MarshalAs(UnmanagedType.LPStruct)] nsAString relativeFilePath);
		
		/// <summary>Member AppendRelativeNativePath </summary>
		/// <param name='relativeFilePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AppendRelativeNativePath([MarshalAs(UnmanagedType.LPStruct)] nsAString  relativeFilePath);
		
		/// <summary>Member GetPersistentDescriptorAttribute </summary>
		/// <param name='aPersistentDescriptor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPersistentDescriptor);
		
		/// <summary>Member SetPersistentDescriptorAttribute </summary>
		/// <param name='aPersistentDescriptor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPersistentDescriptor);
		
		/// <summary>Member Reveal </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Reveal();
		
		/// <summary>Member Launch </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Launch();
		
		/// <summary>Member GetRelativeDescriptor </summary>
		/// <param name='fromFile'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsILocalFile  fromFile);
		
		/// <summary>Member SetRelativeDescriptor </summary>
		/// <param name='fromFile'> </param>
		/// <param name='relativeDesc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsILocalFile  fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsAString  relativeDesc);
		
		/// <summary>Member GetFileTypes </summary>
		/// <returns>A nsIArray</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetFileTypes();
		
		/// <summary>Member SetFileTypes </summary>
		/// <param name='fileTypes'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileTypes([MarshalAs(UnmanagedType.LPStruct)] nsAString  fileTypes);
		
		/// <summary>Member IsFileType </summary>
		/// <param name='fileType'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFileType([MarshalAs(UnmanagedType.LPStruct)] nsAString  fileType);
		
		/// <summary>Member SetFileSource </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileSource([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String  aURI);
	}
}
