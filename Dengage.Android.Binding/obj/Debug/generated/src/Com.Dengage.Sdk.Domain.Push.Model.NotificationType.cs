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

namespace Com.Dengage.Sdk.Domain.Push.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/push/model/NotificationType", DoNotGenerateAcw=true)]
	public sealed partial class NotificationType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']/field[@name='CAROUSEL']"
		[Register ("CAROUSEL")]
		public static global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType Carousel {
			get {
				const string __id = "CAROUSEL.Lcom/dengage/sdk/domain/push/model/NotificationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']/field[@name='RICH']"
		[Register ("RICH")]
		public static global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType Rich {
			get {
				const string __id = "RICH.Lcom/dengage/sdk/domain/push/model/NotificationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType Text {
			get {
				const string __id = "TEXT.Lcom/dengage/sdk/domain/push/model/NotificationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/push/model/NotificationType", typeof (NotificationType));

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

		internal NotificationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/dengage/sdk/domain/push/model/NotificationType;", "")]
		public static unsafe global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/dengage/sdk/domain/push/model/NotificationType;";
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='NotificationType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/dengage/sdk/domain/push/model/NotificationType;", "")]
		public static unsafe global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType[] Values ()
		{
			const string __id = "values.()[Lcom/dengage/sdk/domain/push/model/NotificationType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Dengage.Sdk.Domain.Push.Model.NotificationType));
			} finally {
			}
		}

	}
}
