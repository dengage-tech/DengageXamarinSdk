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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='ServiceFactory']"
	[global::Android.Runtime.Register ("com/dengage/sdk/data/remote/api/ServiceFactory", DoNotGenerateAcw=true)]
	public sealed partial class ServiceFactory : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='ServiceFactory']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Dengage.Sdk.Data.Remote.Api.ServiceFactory Instance {
			get {
				const string __id = "INSTANCE.Lcom/dengage/sdk/data/remote/api/ServiceFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Data.Remote.Api.ServiceFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='ServiceFactory.WhenMappings']"
		[global::Android.Runtime.Register ("com/dengage/sdk/data/remote/api/ServiceFactory$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/data/remote/api/ServiceFactory$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/data/remote/api/ServiceFactory", typeof (ServiceFactory));

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

		internal ServiceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.data.remote.api']/class[@name='ServiceFactory']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;Service&gt;'] and parameter[2][@type='com.dengage.sdk.data.remote.api.ApiType']]"
		[Register ("of", "(Ljava/lang/Class;Lcom/dengage/sdk/data/remote/api/ApiType;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Service"})]
		public unsafe global::Java.Lang.Object Of (global::Java.Lang.Class serviceClass, global::Com.Dengage.Sdk.Data.Remote.Api.ApiType apiType)
		{
			const string __id = "of.(Ljava/lang/Class;Lcom/dengage/sdk/data/remote/api/ApiType;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((serviceClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceClass).Handle);
				__args [1] = new JniArgumentValue ((apiType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) apiType).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (serviceClass);
				global::System.GC.KeepAlive (apiType);
			}
		}

	}
}