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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='LogicOperator']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/inappmessage/model/LogicOperator", DoNotGenerateAcw=true)]
	public sealed partial class LogicOperator : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='LogicOperator']/field[@name='AND']"
		[Register ("AND")]
		public static global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator And {
			get {
				const string __id = "AND.Lcom/dengage/sdk/domain/inappmessage/model/LogicOperator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='LogicOperator']/field[@name='OR']"
		[Register ("OR")]
		public static global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator Or {
			get {
				const string __id = "OR.Lcom/dengage/sdk/domain/inappmessage/model/LogicOperator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/inappmessage/model/LogicOperator", typeof (LogicOperator));

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

		internal LogicOperator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='LogicOperator']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/dengage/sdk/domain/inappmessage/model/LogicOperator;", "")]
		public static unsafe global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator ValueOf (string value)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/dengage/sdk/domain/inappmessage/model/LogicOperator;";
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='LogicOperator']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/dengage/sdk/domain/inappmessage/model/LogicOperator;", "")]
		public static unsafe global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator[] Values ()
		{
			const string __id = "values.()[Lcom/dengage/sdk/domain/inappmessage/model/LogicOperator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.LogicOperator));
			} finally {
			}
		}

	}
}