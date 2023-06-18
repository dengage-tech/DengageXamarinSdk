using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseView']"
	[Register ("com/dengage/sdk/manager/base/BaseView", "", "Com.Dengage.Sdk.Manager.Base.IBaseViewInvoker")]
	public partial interface IBaseView : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseView']/method[@name='hideLoading' and count(parameter)=0]"
		[Register ("hideLoading", "()V", "GetHideLoadingHandler:Com.Dengage.Sdk.Manager.Base.IBaseViewInvoker, Dengage.Android.Binding")]
		void HideLoading ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseView']/method[@name='showError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("showError", "(Ljava/lang/Throwable;)V", "GetShowError_Ljava_lang_Throwable_Handler:Com.Dengage.Sdk.Manager.Base.IBaseViewInvoker, Dengage.Android.Binding")]
		void ShowError (global::Java.Lang.Throwable error);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseView']/method[@name='showLoading' and count(parameter)=0]"
		[Register ("showLoading", "()V", "GetShowLoadingHandler:Com.Dengage.Sdk.Manager.Base.IBaseViewInvoker, Dengage.Android.Binding")]
		void ShowLoading ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/base/BaseView", DoNotGenerateAcw=true)]
	internal partial class IBaseViewInvoker : global::Java.Lang.Object, IBaseView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/base/BaseView", typeof (IBaseViewInvoker));

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

		public static IBaseView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.base.BaseView'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hideLoading;
#pragma warning disable 0169
		static Delegate GetHideLoadingHandler ()
		{
			if (cb_hideLoading == null)
				cb_hideLoading = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_HideLoading));
			return cb_hideLoading;
		}

		static void n_HideLoading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideLoading ();
		}
#pragma warning restore 0169

		IntPtr id_hideLoading;
		public unsafe void HideLoading ()
		{
			if (id_hideLoading == IntPtr.Zero)
				id_hideLoading = JNIEnv.GetMethodID (class_ref, "hideLoading", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideLoading);
		}

		static Delegate cb_showError_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetShowError_Ljava_lang_Throwable_Handler ()
		{
			if (cb_showError_Ljava_lang_Throwable_ == null)
				cb_showError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_ShowError_Ljava_lang_Throwable_));
			return cb_showError_Ljava_lang_Throwable_;
		}

		static void n_ShowError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.ShowError (error);
		}
#pragma warning restore 0169

		IntPtr id_showError_Ljava_lang_Throwable_;
		public unsafe void ShowError (global::Java.Lang.Throwable error)
		{
			if (id_showError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_showError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "showError", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showError_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_showLoading;
#pragma warning disable 0169
		static Delegate GetShowLoadingHandler ()
		{
			if (cb_showLoading == null)
				cb_showLoading = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ShowLoading));
			return cb_showLoading;
		}

		static void n_ShowLoading (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLoading ();
		}
#pragma warning restore 0169

		IntPtr id_showLoading;
		public unsafe void ShowLoading ()
		{
			if (id_showLoading == IntPtr.Zero)
				id_showLoading = JNIEnv.GetMethodID (class_ref, "showLoading", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showLoading);
		}

	}
}
