using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.callback']/interface[@name='DengageCallback']"
	[Register ("com/dengage/sdk/callback/DengageCallback", "", "Com.Dengage.Sdk.Callback.IDengageCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IDengageCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.callback']/interface[@name='DengageCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.callback.DengageError']]"
		[Register ("onError", "(Lcom/dengage/sdk/callback/DengageError;)V", "GetOnError_Lcom_dengage_sdk_callback_DengageError_Handler:Com.Dengage.Sdk.Callback.IDengageCallbackInvoker, Dengage.Android.Binding")]
		void OnError (global::Com.Dengage.Sdk.Callback.DengageError error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.callback']/interface[@name='DengageCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onResult", "(Ljava/lang/Object;)V", "GetOnResult_Ljava_lang_Object_Handler:Com.Dengage.Sdk.Callback.IDengageCallbackInvoker, Dengage.Android.Binding")]
		void OnResult (global::Java.Lang.Object result);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/callback/DengageCallback", DoNotGenerateAcw=true)]
	internal partial class IDengageCallbackInvoker : global::Java.Lang.Object, IDengageCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/callback/DengageCallback", typeof (IDengageCallbackInvoker));

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

		public static IDengageCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDengageCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.callback.DengageCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDengageCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_dengage_sdk_callback_DengageError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_dengage_sdk_callback_DengageError_Handler ()
		{
			if (cb_onError_Lcom_dengage_sdk_callback_DengageError_ == null)
				cb_onError_Lcom_dengage_sdk_callback_DengageError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnError_Lcom_dengage_sdk_callback_DengageError_));
			return cb_onError_Lcom_dengage_sdk_callback_DengageError_;
		}

		static void n_OnError_Lcom_dengage_sdk_callback_DengageError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Callback.IDengageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Callback.DengageError> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.OnError (error);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_dengage_sdk_callback_DengageError_;
		public unsafe void OnError (global::Com.Dengage.Sdk.Callback.DengageError error)
		{
			if (id_onError_Lcom_dengage_sdk_callback_DengageError_ == IntPtr.Zero)
				id_onError_Lcom_dengage_sdk_callback_DengageError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/dengage/sdk/callback/DengageError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Object) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_dengage_sdk_callback_DengageError_, __args);
		}

		static Delegate cb_onResult_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnResult_Ljava_lang_Object_Handler ()
		{
			if (cb_onResult_Ljava_lang_Object_ == null)
				cb_onResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnResult_Ljava_lang_Object_));
			return cb_onResult_Ljava_lang_Object_;
		}

		static void n_OnResult_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Callback.IDengageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (result);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Ljava_lang_Object_;
		public unsafe void OnResult (global::Java.Lang.Object result)
		{
			if (id_onResult_Ljava_lang_Object_ == IntPtr.Zero)
				id_onResult_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Ljava/lang/Object;)V");
			IntPtr native_result = JNIEnv.ToLocalJniHandle (result);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_result);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_result);
		}

	}
}
