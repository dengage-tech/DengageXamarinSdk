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

namespace Com.Dengage.Sdk.Manager.Subscription {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/class[@name='SubscriptionPresenter']"
	[global::Android.Runtime.Register ("com/dengage/sdk/manager/subscription/SubscriptionPresenter", DoNotGenerateAcw=true)]
	public sealed partial class SubscriptionPresenter : global::Com.Dengage.Sdk.Manager.Base.BaseAbstractPresenter, global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/subscription/SubscriptionPresenter", typeof (SubscriptionPresenter));

		internal static new IntPtr class_ref {
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

		internal SubscriptionPresenter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/class[@name='SubscriptionPresenter']/constructor[@name='SubscriptionPresenter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubscriptionPresenter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/class[@name='SubscriptionPresenter']/method[@name='sendSubscription' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.subscription.model.Subscription']]"
		[Register ("sendSubscription", "(Lcom/dengage/sdk/domain/subscription/model/Subscription;)V", "")]
		public unsafe void SendSubscription (global::Com.Dengage.Sdk.Domain.Subscription.Model.Subscription subscription)
		{
			const string __id = "sendSubscription.(Lcom/dengage/sdk/domain/subscription/model/Subscription;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((subscription == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscription).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (subscription);
			}
		}

	}
}
