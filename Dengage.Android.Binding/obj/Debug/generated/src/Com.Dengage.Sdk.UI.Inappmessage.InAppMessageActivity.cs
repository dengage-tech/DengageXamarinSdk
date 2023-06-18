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

namespace Com.Dengage.Sdk.UI.Inappmessage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity']"
	[global::Android.Runtime.Register ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity", DoNotGenerateAcw=true)]
	public sealed partial class InAppMessageActivity : global::Android.App.Activity, global::Android.Views.View.IOnClickListener {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity']/field[@name='EXTRA_IN_APP_MESSAGE']"
		[Register ("EXTRA_IN_APP_MESSAGE")]
		public const string ExtraInAppMessage = (string) "EXTRA_IN_APP_MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity']/field[@name='RESULT_CODE']"
		[Register ("RESULT_CODE")]
		public const string ResultCode = (string) "RESULT_CODE";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity.Companion']"
		[global::Android.Runtime.Register ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity$Companion", typeof (Companion));

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

			public unsafe global::Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity.IInAppMessageCallback InAppMessageCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity.Companion']/method[@name='getInAppMessageCallback' and count(parameter)=0]"
				[Register ("getInAppMessageCallback", "()Lcom/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback;", "")]
				get {
					const string __id = "getInAppMessageCallback.()Lcom/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity.IInAppMessageCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity.Companion']/method[@name='setInAppMessageCallback' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.ui.inappmessage.InAppMessageActivity.InAppMessageCallback']]"
				[Register ("setInAppMessageCallback", "(Lcom/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback;)V", "")]
				set {
					const string __id = "setInAppMessageCallback.(Lcom/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity.Companion']/method[@name='newIntent' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.dengage.sdk.domain.inappmessage.model.InAppMessage'] and parameter[3][@type='int']]"
			[Register ("newIntent", "(Landroid/app/Activity;Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;I)Landroid/content/Intent;", "")]
			public unsafe global::Android.Content.Intent NewIntent (global::Android.App.Activity activity, global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage, int resultCode)
			{
				const string __id = "newIntent.(Landroid/app/Activity;Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;I)Landroid/content/Intent;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
					__args [1] = new JniArgumentValue ((inAppMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessage).Handle);
					__args [2] = new JniArgumentValue (resultCode);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (activity);
					global::System.GC.KeepAlive (inAppMessage);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/interface[@name='InAppMessageActivity.InAppMessageCallback']"
		[Register ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback", "", "Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity/IInAppMessageCallbackInvoker")]
		public partial interface IInAppMessageCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/interface[@name='InAppMessageActivity.InAppMessageCallback']/method[@name='inAppMessageClicked' and count(parameter)=2 and parameter[1][@type='com.dengage.sdk.domain.inappmessage.model.InAppMessage'] and parameter[2][@type='java.lang.String']]"
			[Register ("inAppMessageClicked", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;Ljava/lang/String;)V", "GetInAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_Handler:Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity/IInAppMessageCallbackInvoker, Dengage.Android.Binding")]
			void InAppMessageClicked (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage, string buttonId);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/interface[@name='InAppMessageActivity.InAppMessageCallback']/method[@name='inAppMessageDismissed' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.inappmessage.model.InAppMessage']]"
			[Register ("inAppMessageDismissed", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;)V", "GetInAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Handler:Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity/IInAppMessageCallbackInvoker, Dengage.Android.Binding")]
			void InAppMessageDismissed (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/interface[@name='InAppMessageActivity.InAppMessageCallback']/method[@name='sendTags' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("sendTags", "(Ljava/lang/String;)V", "GetSendTags_Ljava_lang_String_Handler:Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity/IInAppMessageCallbackInvoker, Dengage.Android.Binding")]
			void SendTags (string tags);

		}

		[global::Android.Runtime.Register ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback", DoNotGenerateAcw=true)]
		internal partial class IInAppMessageCallbackInvoker : global::Java.Lang.Object, IInAppMessageCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity$InAppMessageCallback", typeof (IInAppMessageCallbackInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IInAppMessageCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInAppMessageCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.ui.inappmessage.InAppMessageActivity.InAppMessageCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInAppMessageCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_Handler ()
			{
				if (cb_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ == null)
					cb_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_InAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_));
				return cb_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_;
			}

			static void n_InAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessage, IntPtr native_buttonId)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity.IInAppMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var inAppMessage = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> (native_inAppMessage, JniHandleOwnership.DoNotTransfer);
				var buttonId = JNIEnv.GetString (native_buttonId, JniHandleOwnership.DoNotTransfer);
				__this.InAppMessageClicked (inAppMessage, buttonId);
			}
#pragma warning restore 0169

			IntPtr id_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_;
			public unsafe void InAppMessageClicked (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage, string buttonId)
			{
				if (id_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "inAppMessageClicked", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;Ljava/lang/String;)V");
				IntPtr native_buttonId = JNIEnv.NewString ((string)buttonId);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((inAppMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessage).Handle);
				__args [1] = new JValue (native_buttonId);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_buttonId);
			}

			static Delegate cb_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
#pragma warning disable 0169
			static Delegate GetInAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Handler ()
			{
				if (cb_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ == null)
					cb_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_InAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_));
				return cb_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
			}

			static void n_InAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessage)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity.IInAppMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var inAppMessage = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> (native_inAppMessage, JniHandleOwnership.DoNotTransfer);
				__this.InAppMessageDismissed (inAppMessage);
			}
#pragma warning restore 0169

			IntPtr id_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
			public unsafe void InAppMessageDismissed (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage)
			{
				if (id_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ == IntPtr.Zero)
					id_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ = JNIEnv.GetMethodID (class_ref, "inAppMessageDismissed", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((inAppMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessage).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_, __args);
			}

			static Delegate cb_sendTags_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSendTags_Ljava_lang_String_Handler ()
			{
				if (cb_sendTags_Ljava_lang_String_ == null)
					cb_sendTags_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SendTags_Ljava_lang_String_));
				return cb_sendTags_Ljava_lang_String_;
			}

			static void n_SendTags_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tags)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.UI.Inappmessage.InAppMessageActivity.IInAppMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tags = JNIEnv.GetString (native_tags, JniHandleOwnership.DoNotTransfer);
				__this.SendTags (tags);
			}
#pragma warning restore 0169

			IntPtr id_sendTags_Ljava_lang_String_;
			public unsafe void SendTags (string tags)
			{
				if (id_sendTags_Ljava_lang_String_ == IntPtr.Zero)
					id_sendTags_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendTags", "(Ljava/lang/String;)V");
				IntPtr native_tags = JNIEnv.NewString ((string)tags);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_tags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendTags_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_tags);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/ui/inappmessage/InAppMessageActivity", typeof (InAppMessageActivity));

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

		internal InAppMessageActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity']/constructor[@name='InAppMessageActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InAppMessageActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.ui.inappmessage']/class[@name='InAppMessageActivity']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "")]
		public unsafe void OnClick (global::Android.Views.View v)
		{
			const string __id = "onClick.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (v);
			}
		}

	}
}