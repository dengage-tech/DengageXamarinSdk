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

namespace Com.Dengage.Sdk.Manager.Inappmessage.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']"
	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionPresenter", DoNotGenerateAcw=true)]
	public sealed partial class InAppSessionPresenter : global::Com.Dengage.Sdk.Manager.Base.BaseAbstractPresenter, global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/session/InAppSessionPresenter", typeof (InAppSessionPresenter));

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

		internal InAppSessionPresenter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']/constructor[@name='InAppSessionPresenter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InAppSessionPresenter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']/method[@name='sendAppForegroundEvent' and count(parameter)=0]"
		[Register ("sendAppForegroundEvent", "()V", "")]
		public unsafe void SendAppForegroundEvent ()
		{
			const string __id = "sendAppForegroundEvent.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']/method[@name='sendFirstLaunchEvent' and count(parameter)=0]"
		[Register ("sendFirstLaunchEvent", "()V", "")]
		public unsafe void SendFirstLaunchEvent ()
		{
			const string __id = "sendFirstLaunchEvent.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']/method[@name='setLastSessionDuration' and count(parameter)=0]"
		[Register ("setLastSessionDuration", "()V", "")]
		public unsafe void SetLastSessionDuration ()
		{
			const string __id = "setLastSessionDuration.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']/method[@name='setLastSessionStartTime' and count(parameter)=0]"
		[Register ("setLastSessionStartTime", "()V", "")]
		public unsafe void SetLastSessionStartTime ()
		{
			const string __id = "setLastSessionStartTime.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/class[@name='InAppSessionPresenter']/method[@name='setLastVisitTime' and count(parameter)=0]"
		[Register ("setLastVisitTime", "()V", "")]
		public unsafe void SetLastVisitTime ()
		{
			const string __id = "setLastVisitTime.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}