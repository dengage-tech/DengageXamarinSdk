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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/inappmessage/model/DisplayRuleSet", DoNotGenerateAcw=true)]
	public sealed partial class DisplayRuleSet : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/inappmessage/model/DisplayRuleSet", typeof (DisplayRuleSet));

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

		internal DisplayRuleSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']/constructor[@name='DisplayRuleSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.dengage.sdk.domain.inappmessage.model.DisplayRule&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe DisplayRuleSet (string logicOperator, global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule> displayRules) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_logicOperator = JNIEnv.NewString ((string)logicOperator);
			IntPtr native_displayRules = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule>.ToLocalJniHandle (displayRules);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_logicOperator);
				__args [1] = new JniArgumentValue (native_displayRules);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_logicOperator);
				JNIEnv.DeleteLocalRef (native_displayRules);
				global::System.GC.KeepAlive (displayRules);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule> DisplayRules {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']/method[@name='getDisplayRules' and count(parameter)=0]"
			[Register ("getDisplayRules", "()Ljava/util/List;", "")]
			get {
				const string __id = "getDisplayRules.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string LogicOperator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']/method[@name='getLogicOperator' and count(parameter)=0]"
			[Register ("getLogicOperator", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLogicOperator.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule> Component2 ()
		{
			const string __id = "component2.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.inappmessage.model']/class[@name='DisplayRuleSet']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.dengage.sdk.domain.inappmessage.model.DisplayRule&gt;']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/util/List;)Lcom/dengage/sdk/domain/inappmessage/model/DisplayRuleSet;", "")]
		public unsafe global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRuleSet Copy (string logicOperator, global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule> displayRules)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/util/List;)Lcom/dengage/sdk/domain/inappmessage/model/DisplayRuleSet;";
			IntPtr native_logicOperator = JNIEnv.NewString ((string)logicOperator);
			IntPtr native_displayRules = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRule>.ToLocalJniHandle (displayRules);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_logicOperator);
				__args [1] = new JniArgumentValue (native_displayRules);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.DisplayRuleSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_logicOperator);
				JNIEnv.DeleteLocalRef (native_displayRules);
				global::System.GC.KeepAlive (displayRules);
			}
		}

	}
}