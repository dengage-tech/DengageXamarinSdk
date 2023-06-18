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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/tag/model/TagItem", DoNotGenerateAcw=true)]
	public sealed partial class TagItem : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/tag/model/TagItem", typeof (TagItem));

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

		internal TagItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/constructor[@name='TagItem' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe TagItem (string tag, string value) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString ((string)tag);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/constructor[@name='TagItem' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Date']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/lang/String;Ljava/util/Date;)V", "")]
		public unsafe TagItem (string tag, string value, global::Java.Util.Date changeTime, string changeValue, global::Java.Util.Date removeTime) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/lang/String;Ljava/util/Date;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString ((string)tag);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			IntPtr native_changeValue = JNIEnv.NewString ((string)changeValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_value);
				__args [2] = new JniArgumentValue ((changeTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) changeTime).Handle);
				__args [3] = new JniArgumentValue (native_changeValue);
				__args [4] = new JniArgumentValue ((removeTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) removeTime).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_value);
				JNIEnv.DeleteLocalRef (native_changeValue);
				global::System.GC.KeepAlive (changeTime);
				global::System.GC.KeepAlive (removeTime);
			}
		}

		public unsafe string ChangeTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='getChangeTime' and count(parameter)=0]"
			[Register ("getChangeTime", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getChangeTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='setChangeTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChangeTime", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setChangeTime.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string ChangeValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='getChangeValue' and count(parameter)=0]"
			[Register ("getChangeValue", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getChangeValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='setChangeValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChangeValue", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setChangeValue.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string RemoveTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='getRemoveTime' and count(parameter)=0]"
			[Register ("getRemoveTime", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRemoveTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='setRemoveTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRemoveTime", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setRemoveTime.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='component2' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.tag.model']/class[@name='TagItem']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;)Lcom/dengage/sdk/domain/tag/model/TagItem;", "")]
		public unsafe global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem Copy (string tag, string value)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;)Lcom/dengage/sdk/domain/tag/model/TagItem;";
			IntPtr native_tag = JNIEnv.NewString ((string)tag);
			IntPtr native_value = JNIEnv.NewString ((string)value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Tag.Model.TagItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
