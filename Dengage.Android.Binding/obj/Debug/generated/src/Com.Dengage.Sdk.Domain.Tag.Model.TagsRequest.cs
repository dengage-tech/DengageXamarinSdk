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

namespace Com.Dengage.Sdk.Domain.Tag.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/tag/model/TagsRequest", DoNotGenerateAcw=true)]
	public sealed partial class TagsRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/tag/model/TagsRequest", typeof (TagsRequest));

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

		internal TagsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/constructor[@name='TagsRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.dengage.sdk.domain.tag.model.TagItem&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe TagsRequest (string accountName, string key, global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem> tags) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_accountName = JNIEnv.NewString ((string)accountName);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_tags = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem>.ToLocalJniHandle (tags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_accountName);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_tags);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountName);
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_tags);
				global::System.GC.KeepAlive (tags);
			}
		}

		public unsafe string AccountName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='getAccountName' and count(parameter)=0]"
			[Register ("getAccountName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAccountName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/List;", "")]
			get {
				const string __id = "getTags.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem> Component3 ()
		{
			const string __id = "component3.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagsRequest']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.dengage.sdk.domain.tag.model.TagItem&gt;']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lcom/dengage/sdk/domain/tag/model/TagsRequest;", "")]
		public unsafe global::Com.Dengage.Sdk.Domain.Tag.Model.TagsRequest Copy (string accountName, string key, global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem> tags)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lcom/dengage/sdk/domain/tag/model/TagsRequest;";
			IntPtr native_accountName = JNIEnv.NewString ((string)accountName);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_tags = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem>.ToLocalJniHandle (tags);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_accountName);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_tags);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Tag.Model.TagsRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountName);
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_tags);
				global::System.GC.KeepAlive (tags);
			}
		}

	}
}