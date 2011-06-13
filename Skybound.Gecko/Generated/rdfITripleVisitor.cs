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
// Generated by IDLImporter from file rdfITripleVisitor.idl
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
    /// Interface used in RDF to enumerate triples.
    /// Also used by rdfIDataSource::getAllSubjects, then aPredicate,
    /// aObject and aTruthValue are ignored.
    ///
    /// @status PLASMA
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aafea151-c271-4505-9978-a100d292800c")]
	public interface rdfITripleVisitor
	{
		
		/// <summary>
        /// Callback function for returning query results.
        ///
        /// @param aSubject, aPredicate, aObject describe the (sub-)arc
        /// @returnCode NS_RDF_STOP_VISIT to stop iterating over the query result.
        /// Any error code will stop the iteration as well.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Visit([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aSubject, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aPredicate, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aObject, bool aTruthValue);
	}
}
