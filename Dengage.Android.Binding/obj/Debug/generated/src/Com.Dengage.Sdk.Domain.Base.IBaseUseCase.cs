using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Domain.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.base']/class[@name='BaseUseCase.DefaultImpls']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/base/BaseUseCase$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class BaseUseCaseDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/base/BaseUseCase$DefaultImpls", typeof (BaseUseCaseDefaultImpls));

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

		internal BaseUseCaseDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.domain.base']/interface[@name='BaseUseCase']"
	[Register ("com/dengage/sdk/domain/base/BaseUseCase", "", "Com.Dengage.Sdk.Domain.Base.IBaseUseCaseInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "Params"})]
	public partial interface IBaseUseCase : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.base']/interface[@name='BaseUseCase']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Dengage.Sdk.Domain.Base.IBaseUseCaseInvoker, Dengage.Android.Binding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.base']/interface[@name='BaseUseCase']/method[@name='execute' and count(parameter)=3 and parameter[1][@type='com.dengage.sdk.domain.base.UseCaseRunner'] and parameter[2][@type='com.dengage.sdk.domain.base.Callback&lt;T&gt;'] and parameter[3][@type='Params']]"
		[Register ("execute", "(Lcom/dengage/sdk/domain/base/UseCaseRunner;Lcom/dengage/sdk/domain/base/Callback;Ljava/lang/Object;)V", "GetExecute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_Handler:Com.Dengage.Sdk.Domain.Base.IBaseUseCaseInvoker, Dengage.Android.Binding")]
		void Execute (global::Com.Dengage.Sdk.Domain.Base.IUseCaseRunner useCaseRunner, global::Com.Dengage.Sdk.Domain.Base.Callback @callback, global::Java.Lang.Object @params);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/domain/base/BaseUseCase", DoNotGenerateAcw=true)]
	internal partial class IBaseUseCaseInvoker : global::Java.Lang.Object, IBaseUseCase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/base/BaseUseCase", typeof (IBaseUseCaseInvoker));

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

		public static IBaseUseCase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseUseCase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.domain.base.BaseUseCase'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseUseCaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Cancel));
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Base.IBaseUseCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_Handler ()
		{
			if (cb_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_ == null)
				cb_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_Execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_));
			return cb_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_;
		}

		static void n_Execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_useCaseRunner, IntPtr native__callback, IntPtr native__params)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Base.IBaseUseCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var useCaseRunner = (global::Com.Dengage.Sdk.Domain.Base.IUseCaseRunner)global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Base.IUseCaseRunner> (native_useCaseRunner, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Base.Callback> (native__callback, JniHandleOwnership.DoNotTransfer);
			var @params = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__params, JniHandleOwnership.DoNotTransfer);
			__this.Execute (useCaseRunner, @callback, @params);
		}
#pragma warning restore 0169

		IntPtr id_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_;
		public unsafe void Execute (global::Com.Dengage.Sdk.Domain.Base.IUseCaseRunner useCaseRunner, global::Com.Dengage.Sdk.Domain.Base.Callback @callback, global::Java.Lang.Object @params)
		{
			if (id_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_ == IntPtr.Zero)
				id_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/dengage/sdk/domain/base/UseCaseRunner;Lcom/dengage/sdk/domain/base/Callback;Ljava/lang/Object;)V");
			IntPtr native__params = JNIEnv.ToLocalJniHandle (@params);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((useCaseRunner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) useCaseRunner).Handle);
			__args [1] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			__args [2] = new JValue (native__params);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_dengage_sdk_domain_base_UseCaseRunner_Lcom_dengage_sdk_domain_base_Callback_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native__params);
		}

	}
}
