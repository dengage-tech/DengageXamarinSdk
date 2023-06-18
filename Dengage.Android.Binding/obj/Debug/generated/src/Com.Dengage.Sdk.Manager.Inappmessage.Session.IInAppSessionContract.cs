using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Inappmessage.Session {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.Presenter']"
	[Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract$Presenter", "", "Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenterInvoker")]
	public partial interface IInAppSessionContractPresenter : global::Com.Dengage.Sdk.Manager.Base.IBasePresenter {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.Presenter']/method[@name='sendAppForegroundEvent' and count(parameter)=0]"
		[Register ("sendAppForegroundEvent", "()V", "GetSendAppForegroundEventHandler:Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenterInvoker, Dengage.Android.Binding")]
		void SendAppForegroundEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.Presenter']/method[@name='sendFirstLaunchEvent' and count(parameter)=0]"
		[Register ("sendFirstLaunchEvent", "()V", "GetSendFirstLaunchEventHandler:Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenterInvoker, Dengage.Android.Binding")]
		void SendFirstLaunchEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.Presenter']/method[@name='setLastSessionDuration' and count(parameter)=0]"
		[Register ("setLastSessionDuration", "()V", "GetSetLastSessionDurationHandler:Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenterInvoker, Dengage.Android.Binding")]
		void SetLastSessionDuration ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.Presenter']/method[@name='setLastSessionStartTime' and count(parameter)=0]"
		[Register ("setLastSessionStartTime", "()V", "GetSetLastSessionStartTimeHandler:Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenterInvoker, Dengage.Android.Binding")]
		void SetLastSessionStartTime ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.Presenter']/method[@name='setLastVisitTime' and count(parameter)=0]"
		[Register ("setLastVisitTime", "()V", "GetSetLastVisitTimeHandler:Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenterInvoker, Dengage.Android.Binding")]
		void SetLastVisitTime ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract$Presenter", DoNotGenerateAcw=true)]
	internal partial class IInAppSessionContractPresenterInvoker : global::Java.Lang.Object, IInAppSessionContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract$Presenter", typeof (IInAppSessionContractPresenterInvoker));

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

		public static IInAppSessionContractPresenter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppSessionContractPresenter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.session.InAppSessionContract.Presenter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppSessionContractPresenterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendAppForegroundEvent;
#pragma warning disable 0169
		static Delegate GetSendAppForegroundEventHandler ()
		{
			if (cb_sendAppForegroundEvent == null)
				cb_sendAppForegroundEvent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SendAppForegroundEvent));
			return cb_sendAppForegroundEvent;
		}

		static void n_SendAppForegroundEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAppForegroundEvent ();
		}
#pragma warning restore 0169

		IntPtr id_sendAppForegroundEvent;
		public unsafe void SendAppForegroundEvent ()
		{
			if (id_sendAppForegroundEvent == IntPtr.Zero)
				id_sendAppForegroundEvent = JNIEnv.GetMethodID (class_ref, "sendAppForegroundEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAppForegroundEvent);
		}

		static Delegate cb_sendFirstLaunchEvent;
#pragma warning disable 0169
		static Delegate GetSendFirstLaunchEventHandler ()
		{
			if (cb_sendFirstLaunchEvent == null)
				cb_sendFirstLaunchEvent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SendFirstLaunchEvent));
			return cb_sendFirstLaunchEvent;
		}

		static void n_SendFirstLaunchEvent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendFirstLaunchEvent ();
		}
#pragma warning restore 0169

		IntPtr id_sendFirstLaunchEvent;
		public unsafe void SendFirstLaunchEvent ()
		{
			if (id_sendFirstLaunchEvent == IntPtr.Zero)
				id_sendFirstLaunchEvent = JNIEnv.GetMethodID (class_ref, "sendFirstLaunchEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFirstLaunchEvent);
		}

		static Delegate cb_setLastSessionDuration;
#pragma warning disable 0169
		static Delegate GetSetLastSessionDurationHandler ()
		{
			if (cb_setLastSessionDuration == null)
				cb_setLastSessionDuration = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SetLastSessionDuration));
			return cb_setLastSessionDuration;
		}

		static void n_SetLastSessionDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastSessionDuration ();
		}
#pragma warning restore 0169

		IntPtr id_setLastSessionDuration;
		public unsafe void SetLastSessionDuration ()
		{
			if (id_setLastSessionDuration == IntPtr.Zero)
				id_setLastSessionDuration = JNIEnv.GetMethodID (class_ref, "setLastSessionDuration", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSessionDuration);
		}

		static Delegate cb_setLastSessionStartTime;
#pragma warning disable 0169
		static Delegate GetSetLastSessionStartTimeHandler ()
		{
			if (cb_setLastSessionStartTime == null)
				cb_setLastSessionStartTime = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SetLastSessionStartTime));
			return cb_setLastSessionStartTime;
		}

		static void n_SetLastSessionStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastSessionStartTime ();
		}
#pragma warning restore 0169

		IntPtr id_setLastSessionStartTime;
		public unsafe void SetLastSessionStartTime ()
		{
			if (id_setLastSessionStartTime == IntPtr.Zero)
				id_setLastSessionStartTime = JNIEnv.GetMethodID (class_ref, "setLastSessionStartTime", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSessionStartTime);
		}

		static Delegate cb_setLastVisitTime;
#pragma warning disable 0169
		static Delegate GetSetLastVisitTimeHandler ()
		{
			if (cb_setLastVisitTime == null)
				cb_setLastVisitTime = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SetLastVisitTime));
			return cb_setLastVisitTime;
		}

		static void n_SetLastVisitTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastVisitTime ();
		}
#pragma warning restore 0169

		IntPtr id_setLastVisitTime;
		public unsafe void SetLastVisitTime ()
		{
			if (id_setLastVisitTime == IntPtr.Zero)
				id_setLastVisitTime = JNIEnv.GetMethodID (class_ref, "setLastVisitTime", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastVisitTime);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract.View']"
	[Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract$View", "", "Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractViewInvoker")]
	public partial interface IInAppSessionContractView : global::Com.Dengage.Sdk.Manager.Base.IBaseView {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract$View", DoNotGenerateAcw=true)]
	internal partial class IInAppSessionContractViewInvoker : global::Java.Lang.Object, IInAppSessionContractView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract$View", typeof (IInAppSessionContractViewInvoker));

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

		public static IInAppSessionContractView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppSessionContractView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.session.InAppSessionContract.View'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppSessionContractViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage.session']/interface[@name='InAppSessionContract']"
	[Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract", "", "Com.Dengage.Sdk.Manager.Inappmessage.Session.IInAppSessionContractInvoker")]
	public partial interface IInAppSessionContract : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract", DoNotGenerateAcw=true)]
	internal partial class IInAppSessionContractInvoker : global::Java.Lang.Object, IInAppSessionContract {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/session/InAppSessionContract", typeof (IInAppSessionContractInvoker));

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

		public static IInAppSessionContract GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppSessionContract> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.session.InAppSessionContract'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppSessionContractInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
