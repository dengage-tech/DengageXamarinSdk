using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BasePresenter']"
	[Register ("com/dengage/sdk/manager/base/BasePresenter", "", "Com.Dengage.Sdk.Manager.Base.IBasePresenterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView"})]
	public partial interface IBasePresenter : IJavaObject, IJavaPeerable {
		bool IsViewAttached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BasePresenter']/method[@name='isViewAttached' and count(parameter)=0]"
			[Register ("isViewAttached", "()Z", "GetIsViewAttachedHandler:Com.Dengage.Sdk.Manager.Base.IBasePresenterInvoker, Dengage.Android.Binding")]
			get; 
		}

		global::Java.Lang.Object View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BasePresenter']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Lcom/dengage/sdk/manager/base/BaseView;", "GetGetViewHandler:Com.Dengage.Sdk.Manager.Base.IBasePresenterInvoker, Dengage.Android.Binding")]
			get; 
		}

		global::Java.Lang.Object ViewIfIsAttached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BasePresenter']/method[@name='getViewIfIsAttached' and count(parameter)=0]"
			[Register ("getViewIfIsAttached", "()Lcom/dengage/sdk/manager/base/BaseView;", "GetGetViewIfIsAttachedHandler:Com.Dengage.Sdk.Manager.Base.IBasePresenterInvoker, Dengage.Android.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BasePresenter']/method[@name='attachView' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseView']]"
		[Register ("attachView", "(Lcom/dengage/sdk/manager/base/BaseView;)V", "GetAttachView_Lcom_dengage_sdk_manager_base_BaseView_Handler:Com.Dengage.Sdk.Manager.Base.IBasePresenterInvoker, Dengage.Android.Binding")]
		void AttachView (global::Com.Dengage.Sdk.Manager.Base.IBaseView view);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BasePresenter']/method[@name='detachView' and count(parameter)=0]"
		[Register ("detachView", "()V", "GetDetachViewHandler:Com.Dengage.Sdk.Manager.Base.IBasePresenterInvoker, Dengage.Android.Binding")]
		void DetachView ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/base/BasePresenter", DoNotGenerateAcw=true)]
	internal partial class IBasePresenterInvoker : global::Java.Lang.Object, IBasePresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/base/BasePresenter", typeof (IBasePresenterInvoker));

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

		public static IBasePresenter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBasePresenter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.base.BasePresenter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBasePresenterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isViewAttached;
#pragma warning disable 0169
		static Delegate GetIsViewAttachedHandler ()
		{
			if (cb_isViewAttached == null)
				cb_isViewAttached = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsViewAttached));
			return cb_isViewAttached;
		}

		static bool n_IsViewAttached (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBasePresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsViewAttached;
		}
#pragma warning restore 0169

		IntPtr id_isViewAttached;
		public unsafe bool IsViewAttached {
			get {
				if (id_isViewAttached == IntPtr.Zero)
					id_isViewAttached = JNIEnv.GetMethodID (class_ref, "isViewAttached", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewAttached);
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetView));
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBasePresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		IntPtr id_getView;
		public unsafe global::Java.Lang.Object View {
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Lcom/dengage/sdk/manager/base/BaseView;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getViewIfIsAttached;
#pragma warning disable 0169
		static Delegate GetGetViewIfIsAttachedHandler ()
		{
			if (cb_getViewIfIsAttached == null)
				cb_getViewIfIsAttached = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetViewIfIsAttached));
			return cb_getViewIfIsAttached;
		}

		static IntPtr n_GetViewIfIsAttached (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBasePresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewIfIsAttached);
		}
#pragma warning restore 0169

		IntPtr id_getViewIfIsAttached;
		public unsafe global::Java.Lang.Object ViewIfIsAttached {
			get {
				if (id_getViewIfIsAttached == IntPtr.Zero)
					id_getViewIfIsAttached = JNIEnv.GetMethodID (class_ref, "getViewIfIsAttached", "()Lcom/dengage/sdk/manager/base/BaseView;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewIfIsAttached), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_attachView_Lcom_dengage_sdk_manager_base_BaseView_;
#pragma warning disable 0169
		static Delegate GetAttachView_Lcom_dengage_sdk_manager_base_BaseView_Handler ()
		{
			if (cb_attachView_Lcom_dengage_sdk_manager_base_BaseView_ == null)
				cb_attachView_Lcom_dengage_sdk_manager_base_BaseView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AttachView_Lcom_dengage_sdk_manager_base_BaseView_));
			return cb_attachView_Lcom_dengage_sdk_manager_base_BaseView_;
		}

		static void n_AttachView_Lcom_dengage_sdk_manager_base_BaseView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBasePresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = (global::Com.Dengage.Sdk.Manager.Base.IBaseView)global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.AttachView (view);
		}
#pragma warning restore 0169

		IntPtr id_attachView_Lcom_dengage_sdk_manager_base_BaseView_;
		public unsafe void AttachView (global::Com.Dengage.Sdk.Manager.Base.IBaseView view)
		{
			if (id_attachView_Lcom_dengage_sdk_manager_base_BaseView_ == IntPtr.Zero)
				id_attachView_Lcom_dengage_sdk_manager_base_BaseView_ = JNIEnv.GetMethodID (class_ref, "attachView", "(Lcom/dengage/sdk/manager/base/BaseView;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachView_Lcom_dengage_sdk_manager_base_BaseView_, __args);
		}

		static Delegate cb_detachView;
#pragma warning disable 0169
		static Delegate GetDetachViewHandler ()
		{
			if (cb_detachView == null)
				cb_detachView = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DetachView));
			return cb_detachView;
		}

		static void n_DetachView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBasePresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DetachView ();
		}
#pragma warning restore 0169

		IntPtr id_detachView;
		public unsafe void DetachView ()
		{
			if (id_detachView == IntPtr.Zero)
				id_detachView = JNIEnv.GetMethodID (class_ref, "detachView", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detachView);
		}

	}
}
