using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Push {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.push']/interface[@name='PushMessageCallback']"
	[Register ("com/dengage/sdk/push/PushMessageCallback", "", "Com.Dengage.Sdk.Push.IPushMessageCallbackInvoker")]
	public partial interface IPushMessageCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.push']/interface[@name='PushMessageCallback']/method[@name='dataFetched' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.push.model.Message']]"
		[Register ("dataFetched", "(Lcom/dengage/sdk/domain/push/model/Message;)V", "GetDataFetched_Lcom_dengage_sdk_domain_push_model_Message_Handler:Com.Dengage.Sdk.Push.IPushMessageCallbackInvoker, Dengage.Android.Binding")]
		void DataFetched (global::Com.Dengage.Sdk.Domain.Push.Model.Message message);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.push']/interface[@name='PushMessageCallback']/method[@name='onActionClick' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.dengage.sdk.domain.push.model.Message'] and parameter[3][@type='java.lang.String']]"
		[Register ("onActionClick", "(Landroid/content/Intent;Lcom/dengage/sdk/domain/push/model/Message;Ljava/lang/String;)V", "GetOnActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_Handler:Com.Dengage.Sdk.Push.IPushMessageCallbackInvoker, Dengage.Android.Binding")]
		void OnActionClick (global::Android.Content.Intent intent, global::Com.Dengage.Sdk.Domain.Push.Model.Message message, string clickedId);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/push/PushMessageCallback", DoNotGenerateAcw=true)]
	internal partial class IPushMessageCallbackInvoker : global::Java.Lang.Object, IPushMessageCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/push/PushMessageCallback", typeof (IPushMessageCallbackInvoker));

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

		public static IPushMessageCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushMessageCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.push.PushMessageCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushMessageCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_;
#pragma warning disable 0169
		static Delegate GetDataFetched_Lcom_dengage_sdk_domain_push_model_Message_Handler ()
		{
			if (cb_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_ == null)
				cb_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_DataFetched_Lcom_dengage_sdk_domain_push_model_Message_));
			return cb_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_;
		}

		static void n_DataFetched_Lcom_dengage_sdk_domain_push_model_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Push.IPushMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.Message> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.DataFetched (message);
		}
#pragma warning restore 0169

		IntPtr id_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_;
		public unsafe void DataFetched (global::Com.Dengage.Sdk.Domain.Push.Model.Message message)
		{
			if (id_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_ == IntPtr.Zero)
				id_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_ = JNIEnv.GetMethodID (class_ref, "dataFetched", "(Lcom/dengage/sdk/domain/push/model/Message;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dataFetched_Lcom_dengage_sdk_domain_push_model_Message_, __args);
		}

		static Delegate cb_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_Handler ()
		{
			if (cb_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_ == null)
				cb_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_OnActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_));
			return cb_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_;
		}

		static void n_OnActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_message, IntPtr native_clickedId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Push.IPushMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			var message = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Push.Model.Message> (native_message, JniHandleOwnership.DoNotTransfer);
			var clickedId = JNIEnv.GetString (native_clickedId, JniHandleOwnership.DoNotTransfer);
			__this.OnActionClick (intent, message, clickedId);
		}
#pragma warning restore 0169

		IntPtr id_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_;
		public unsafe void OnActionClick (global::Android.Content.Intent intent, global::Com.Dengage.Sdk.Domain.Push.Model.Message message, string clickedId)
		{
			if (id_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onActionClick", "(Landroid/content/Intent;Lcom/dengage/sdk/domain/push/model/Message;Ljava/lang/String;)V");
			IntPtr native_clickedId = JNIEnv.NewString ((string)clickedId);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
			__args [1] = new JValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
			__args [2] = new JValue (native_clickedId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActionClick_Landroid_content_Intent_Lcom_dengage_sdk_domain_push_model_Message_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_clickedId);
		}

	}
}
