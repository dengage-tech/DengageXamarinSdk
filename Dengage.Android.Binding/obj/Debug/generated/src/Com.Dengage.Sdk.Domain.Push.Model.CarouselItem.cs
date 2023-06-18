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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/push/model/CarouselItem", DoNotGenerateAcw=true)]
	public sealed partial class CarouselItem : global::Java.Lang.Object, global::Java.IO.ISerializable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/push/model/CarouselItem", typeof (CarouselItem));

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

		internal CarouselItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/constructor[@name='CarouselItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CarouselItem () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/constructor[@name='CarouselItem' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CarouselItem (string id, string title, string description, string mediaUrl, string targetUrl, string type, string mediaFileLocation, string mediaFileName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString ((string)id);
			IntPtr native_title = JNIEnv.NewString ((string)title);
			IntPtr native_description = JNIEnv.NewString ((string)description);
			IntPtr native_mediaUrl = JNIEnv.NewString ((string)mediaUrl);
			IntPtr native_targetUrl = JNIEnv.NewString ((string)targetUrl);
			IntPtr native_type = JNIEnv.NewString ((string)type);
			IntPtr native_mediaFileLocation = JNIEnv.NewString ((string)mediaFileLocation);
			IntPtr native_mediaFileName = JNIEnv.NewString ((string)mediaFileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_title);
				__args [2] = new JniArgumentValue (native_description);
				__args [3] = new JniArgumentValue (native_mediaUrl);
				__args [4] = new JniArgumentValue (native_targetUrl);
				__args [5] = new JniArgumentValue (native_type);
				__args [6] = new JniArgumentValue (native_mediaFileLocation);
				__args [7] = new JniArgumentValue (native_mediaFileName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_title);
				JNIEnv.DeleteLocalRef (native_description);
				JNIEnv.DeleteLocalRef (native_mediaUrl);
				JNIEnv.DeleteLocalRef (native_targetUrl);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_mediaFileLocation);
				JNIEnv.DeleteLocalRef (native_mediaFileName);
			}
		}

		public unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string MediaFileLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getMediaFileLocation' and count(parameter)=0]"
			[Register ("getMediaFileLocation", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMediaFileLocation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='setMediaFileLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMediaFileLocation", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setMediaFileLocation.(Ljava/lang/String;)V";
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

		public unsafe string MediaFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getMediaFileName' and count(parameter)=0]"
			[Register ("getMediaFileName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMediaFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='setMediaFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMediaFileName", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setMediaFileName.(Ljava/lang/String;)V";
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

		public unsafe string MediaUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getMediaUrl' and count(parameter)=0]"
			[Register ("getMediaUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMediaUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string TargetUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getTargetUrl' and count(parameter)=0]"
			[Register ("getTargetUrl", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTargetUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setType.(Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component2' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/String;", "")]
		public unsafe string Component4 ()
		{
			const string __id = "component4.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/String;", "")]
		public unsafe string Component5 ()
		{
			const string __id = "component5.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Ljava/lang/String;", "")]
		public unsafe string Component6 ()
		{
			const string __id = "component6.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Ljava/lang/String;", "")]
		public unsafe string Component7 ()
		{
			const string __id = "component7.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Ljava/lang/String;", "")]
		public unsafe string Component8 ()
		{
			const string __id = "component8.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.push.model']/class[@name='CarouselItem']/method[@name='copy' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/dengage/sdk/domain/push/model/CarouselItem;", "")]
		public unsafe global::Com.Dengage.Sdk.Domain.Push.Model.CarouselItem Copy (string id, string title, string description, string mediaUrl, string targetUrl, string type, string mediaFileLocation, string mediaFileName)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/dengage/sdk/domain/push/model/CarouselItem;";
			IntPtr native_id = JNIEnv.NewString ((string)id);
			IntPtr native_title = JNIEnv.NewString ((string)title);
			IntPtr native_description = JNIEnv.NewString ((string)description);
			IntPtr native_mediaUrl = JNIEnv.NewString ((string)mediaUrl);
			IntPtr native_targetUrl = JNIEnv.NewString ((string)targetUrl);
			IntPtr native_type = JNIEnv.NewString ((string)type);
			IntPtr native_mediaFileLocation = JNIEnv.NewString ((string)mediaFileLocation);
			IntPtr native_mediaFileName = JNIEnv.NewString ((string)mediaFileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_title);
				__args [2] = new JniArgumentValue (native_description);
				__args [3] = new JniArgumentValue (native_mediaUrl);
				__args [4] = new JniArgumentValue (native_targetUrl);
				__args [5] = new JniArgumentValue (native_type);
				__args [6] = new JniArgumentValue (native_mediaFileLocation);
				__args [7] = new JniArgumentValue (native_mediaFileName);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.CarouselItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_title);
				JNIEnv.DeleteLocalRef (native_description);
				JNIEnv.DeleteLocalRef (native_mediaUrl);
				JNIEnv.DeleteLocalRef (native_targetUrl);
				JNIEnv.DeleteLocalRef (native_type);
				JNIEnv.DeleteLocalRef (native_mediaFileLocation);
				JNIEnv.DeleteLocalRef (native_mediaFileName);
			}
		}

	}
}