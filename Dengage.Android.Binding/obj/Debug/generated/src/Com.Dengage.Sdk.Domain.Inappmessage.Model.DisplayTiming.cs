//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Domain.Inappmessage.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayTiming']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/inappmessage/model/DisplayTiming", DoNotGenerateAcw=true)]
	public sealed partial class DisplayTiming : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/inappmessage/model/DisplayTiming", typeof (DisplayTiming));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal DisplayTiming (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayTiming']/constructor[@name='DisplayTiming' and count(parameter)=3 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)V", "")]
		public unsafe DisplayTiming (global::Java.Lang.Integer delay, global::Java.Lang.Integer showEveryXMinutes, global::Java.Lang.Integer maxShowCount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Integer;Ljava/lang/Integer;Ljava/lang/Integer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((delay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) delay).Handle);
				__args [1] = new JniArgumentValue ((showEveryXMinutes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) showEveryXMinutes).Handle);
				__args [2] = new JniArgumentValue ((maxShowCount == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxShowCount).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (delay);
				global::System.GC.KeepAlive (showEveryXMinutes);
				global::System.GC.KeepAlive (maxShowCount);
			}
		}

		public unsafe global::Java.Lang.Integer Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayTiming']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getDelay.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer MaxShowCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayTiming']/method[@name='getMaxShowCount' and count(parameter)=0]"
			[Register ("getMaxShowCount", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getMaxShowCount.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer ShowEveryXMinutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayTiming']/method[@name='getShowEveryXMinutes' and count(parameter)=0]"
			[Register ("getShowEveryXMinutes", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getShowEveryXMinutes.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
