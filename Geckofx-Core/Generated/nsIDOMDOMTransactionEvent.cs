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
// Generated by IDLImporter from file nsIDOMDOMTransactionEvent.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f57f7c46-d420-4f32-a61b-0eb585d30ee1")]
	public interface nsIDOMDOMTransactionEvent : nsIDOMEvent
	{
		
		/// <summary>
        /// The name of the event (case-insensitive). The name must be an XML
        /// name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// Used to indicate the EventTarget to which the event was originally
        /// dispatched.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTargetAttribute();
		
		/// <summary>
        /// Used to indicate the EventTarget whose EventListeners are currently
        /// being processed. This is particularly useful during capturing and
        /// bubbling.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTargetAttribute();
		
		/// <summary>
        /// Used to indicate which phase of event flow is currently being
        /// evaluated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhaseAttribute();
		
		/// <summary>
        /// Used to indicate whether or not an event is a bubbling event. If the
        /// event can bubble the value is true, else the value is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubblesAttribute();
		
		/// <summary>
        /// Used to indicate whether or not an event can have its default action
        /// prevented. If the default action can be prevented the value is true,
        /// else the value is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelableAttribute();
		
		/// <summary>
        /// Used to specify the time (in milliseconds relative to the epoch) at
        /// which the event was created. Due to the fact that some systems may
        /// not provide this information the value of timeStamp may be not
        /// available for all events. When not available, a value of 0 will be
        /// returned. Examples of epoch time are the time of the system start or
        /// 0:0:0 UTC 1st January 1970.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetTimeStampAttribute();
		
		/// <summary>
        /// The stopPropagation method is used prevent further propagation of an
        /// event during event flow. If this method is called by any
        /// EventListener the event will cease propagating through the tree. The
        /// event will complete dispatch to all listeners on the current
        /// EventTarget before event flow stops. This method may be used during
        /// any stage of event flow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		/// <summary>
        /// If an event is cancelable, the preventDefault method is used to
        /// signify that the event is to be canceled, meaning any default action
        /// normally taken by the implementation as a result of the event will
        /// not occur. If, during any stage of event flow, the preventDefault
        /// method is called the event is canceled. Any default action associated
        /// with the event will not occur. Calling this method for a
        /// non-cancelable event has no effect. Once preventDefault has been
        /// called it will remain in effect throughout the remainder of the
        /// event's propagation. This method may be used during any stage of
        /// event flow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		/// <summary>
        /// The initEvent method is used to initialize the value of an Event
        /// created through the DocumentEvent interface. This method may only be
        /// called before the Event has been dispatched via the dispatchEvent
        /// method, though it may be called multiple times during that phase if
        /// necessary. If called multiple times the final invocation takes
        /// precedence. If called from a subclass of Event interface only the
        /// values specified in the initEvent method are modified, all other
        /// attributes are left unchanged.
        ///
        /// @param   eventTypeArg Specifies the event type. This type may be
        /// any event type currently defined in this
        /// specification or a new event type.. The string
        /// must be an XML name.
        /// Any new event type must not begin with any
        /// upper, lower, or mixed case version of the
        /// string "DOM". This prefix is reserved for
        /// future DOM event sets. It is also strongly
        /// recommended that third parties adding their
        /// own events use their own prefix to avoid
        /// confusion and lessen the probability of
        /// conflicts with other new events.
        /// @param   canBubbleArg Specifies whether or not the event can bubble.
        /// @param   cancelableArg Specifies whether or not the event's default
        /// action can be prevented.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase eventTypeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool cancelableArg);
		
		/// <summary>
        /// Used to indicate whether preventDefault() has been called for this event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetDefaultPreventedAttribute();
		
		/// <summary>
        /// Prevents other event listeners from being triggered and,
        /// unlike Event.stopPropagation() its effect is immediate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopImmediatePropagation();
		
		/// <summary>
        ///The original target of the event, before any retargetings. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetOriginalTargetAttribute();
		
		/// <summary>
        /// The explicit original target of the event.  If the event was retargeted
        /// for some reason other than an anonymous boundary crossing, this will be set
        /// to the target before the retargeting occurs.  For example, mouse events
        /// are retargeted to their parent node when they happen over text nodes (bug
        /// 185889), and in that case .target will show the parent and
        /// .explicitOriginalTarget will show the text node.
        /// .explicitOriginalTarget differs from .originalTarget in that it will never
        /// contain anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetExplicitOriginalTargetAttribute();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::defaultPrevented.
        /// To be removed in bug 691151.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetPreventDefault();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsTrustedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DuplicatePrivateData();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTarget([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aTarget);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDispatchStopped();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetInternalNSEvent();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTrusted([MarshalAs(UnmanagedType.U1)] bool aTrusted);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Serialize(System.IntPtr aMsg, [MarshalAs(UnmanagedType.U1)] bool aSerializeInterfaceType);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Deserialize(System.IntPtr aMsg, ref System.IntPtr aIter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOwner(nsIDOMEventTarget aOwner);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr InternalDOMEvent();
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetTransactionsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitDOMTransactionEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase typeArg, [MarshalAs(UnmanagedType.U1)] bool canBubbleArg, [MarshalAs(UnmanagedType.U1)] bool canCancelArg, [MarshalAs(UnmanagedType.Interface)] nsIVariant transactions);
	}
}
