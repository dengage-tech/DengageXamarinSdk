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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/inappmessage/model/VisitCount", DoNotGenerateAcw=true)]
	public sealed partial class VisitCount : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/inappmessage/model/VisitCount", typeof (VisitCount));

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

		internal VisitCount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']/constructor[@name='VisitCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe VisitCount (int count, int timeAmount) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (timeAmount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TimeAmount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']/method[@name='getTimeAmount' and count(parameter)=0]"
			[Register ("getTimeAmount", "()I", "")]
			get {
				const string __id = "getTimeAmount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()I", "")]
		public unsafe int Component1 ()
		{
			const string __id = "component1.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()I", "")]
		public unsafe int Component2 ()
		{
			const string __id = "component2.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='VisitCount']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("copy", "(II)Lcom/dengage/sdk/domain/inappmessage/model/VisitCount;", "")]
		public unsafe global::Com.Dengage.Sdk.Domain.Inappmessage.Model.VisitCount Copy (int count, int timeAmount)
		{
			const string __id = "copy.(II)Lcom/dengage/sdk/domain/inappmessage/model/VisitCount;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (timeAmount);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.VisitCount> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}