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

namespace Com.Dengage.Sdk.Data.Remote.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='InAppApiProvider']"
	[global::Android.Runtime.Register ("com/dengage/sdk/data/remote/api/InAppApiProvider", DoNotGenerateAcw=true)]
	public sealed partial class InAppApiProvider : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='InAppApiProvider.Companion']"
		[global::Android.Runtime.Register ("com/dengage/sdk/data/remote/api/InAppApiProvider$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/data/remote/api/InAppApiProvider$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			public unsafe global::Com.Dengage.Sdk.Data.Remote.Api.InAppApiProvider INSTANCE {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='InAppApiProvider.Companion']/method[@name='getINSTANCE' and count(parameter)=0]"
				[Register ("getINSTANCE", "()Lcom/dengage/sdk/data/remote/api/InAppApiProvider;", "")]
				get {
					const string __id = "getINSTANCE.()Lcom/dengage/sdk/data/remote/api/InAppApiProvider;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Data.Remote.Api.InAppApiProvider> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='InAppApiProvider.Companion']/method[@name='setINSTANCE' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.data.remote.api.InAppApiProvider']]"
				[Register ("setINSTANCE", "(Lcom/dengage/sdk/data/remote/api/InAppApiProvider;)V", "")]
				set {
					const string __id = "setINSTANCE.(Lcom/dengage/sdk/data/remote/api/InAppApiProvider;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/data/remote/api/InAppApiProvider", typeof (InAppApiProvider));

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

		internal InAppApiProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='InAppApiProvider']/constructor[@name='InAppApiProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InAppApiProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='InAppApiProvider']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;S&gt;']]"
		[Register ("create", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"S"})]
		public unsafe global::Java.Lang.Object Create (global::Java.Lang.Class serviceClass)
		{
			const string __id = "create.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serviceClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceClass).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (serviceClass);
			}
		}

	}
}
