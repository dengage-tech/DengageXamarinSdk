using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Subscription {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/interface[@name='SubscriptionContract.Presenter']"
	[Register ("com/dengage/sdk/manager/subscription/SubscriptionContract$Presenter", "", "Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenterInvoker")]
	public partial interface ISubscriptionContractPresenter : global::Com.Dengage.Sdk.Manager.Base.IBasePresenter {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/interface[@name='SubscriptionContract.Presenter']/method[@name='sendSubscription' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.subscription.model.Subscription']]"
		[Register ("sendSubscription", "(Lcom/dengage/sdk/domain/subscription/model/Subscription;)V", "GetSendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_Handler:Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenterInvoker, Dengage.Android.Binding")]
		void SendSubscription (global::Com.Dengage.Sdk.Domain.Subscription.Model.Subscription subscription);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/subscription/SubscriptionContract$Presenter", DoNotGenerateAcw=true)]
	internal partial class ISubscriptionContractPresenterInvoker : global::Java.Lang.Object, ISubscriptionContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/subscription/SubscriptionContract$Presenter", typeof (ISubscriptionContractPresenterInvoker));

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

		public static ISubscriptionContractPresenter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscriptionContractPresenter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.subscription.SubscriptionContract.Presenter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriptionContractPresenterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_;
#pragma warning disable 0169
		static Delegate GetSendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_Handler ()
		{
			if (cb_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_ == null)
				cb_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_));
			return cb_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_;
		}

		static void n_SendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subscription)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subscription = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Subscription.Model.Subscription> (native_subscription, JniHandleOwnership.DoNotTransfer);
			__this.SendSubscription (subscription);
		}
#pragma warning restore 0169

		IntPtr id_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_;
		public unsafe void SendSubscription (global::Com.Dengage.Sdk.Domain.Subscription.Model.Subscription subscription)
		{
			if (id_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_ == IntPtr.Zero)
				id_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_ = JNIEnv.GetMethodID (class_ref, "sendSubscription", "(Lcom/dengage/sdk/domain/subscription/model/Subscription;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((subscription == null) ? IntPtr.Zero : ((global::Java.Lang.Object) subscription).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/interface[@name='SubscriptionContract.View']"
	[Register ("com/dengage/sdk/manager/subscription/SubscriptionContract$View", "", "Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractViewInvoker")]
	public partial interface ISubscriptionContractView : global::Com.Dengage.Sdk.Manager.Base.IBaseView {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/interface[@name='SubscriptionContract.View']/method[@name='subscriptionSent' and count(parameter)=0]"
		[Register ("subscriptionSent", "()V", "GetSubscriptionSentHandler:Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractViewInvoker, Dengage.Android.Binding")]
		void SubscriptionSent ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/subscription/SubscriptionContract$View", DoNotGenerateAcw=true)]
	internal partial class ISubscriptionContractViewInvoker : global::Java.Lang.Object, ISubscriptionContractView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/subscription/SubscriptionContract$View", typeof (ISubscriptionContractViewInvoker));

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

		public static ISubscriptionContractView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscriptionContractView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.subscription.SubscriptionContract.View'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriptionContractViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_subscriptionSent;
#pragma warning disable 0169
		static Delegate GetSubscriptionSentHandler ()
		{
			if (cb_subscriptionSent == null)
				cb_subscriptionSent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_SubscriptionSent));
			return cb_subscriptionSent;
		}

		static void n_SubscriptionSent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubscriptionSent ();
		}
#pragma warning restore 0169

		IntPtr id_subscriptionSent;
		public unsafe void SubscriptionSent ()
		{
			if (id_subscriptionSent == IntPtr.Zero)
				id_subscriptionSent = JNIEnv.GetMethodID (class_ref, "subscriptionSent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscriptionSent);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.subscription']/interface[@name='SubscriptionContract']"
	[Register ("com/dengage/sdk/manager/subscription/SubscriptionContract", "", "Com.Dengage.Sdk.Manager.Subscription.ISubscriptionContractInvoker")]
	public partial interface ISubscriptionContract : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/subscription/SubscriptionContract", DoNotGenerateAcw=true)]
	internal partial class ISubscriptionContractInvoker : global::Java.Lang.Object, ISubscriptionContract {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/subscription/SubscriptionContract", typeof (ISubscriptionContractInvoker));

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

		public static ISubscriptionContract GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscriptionContract> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.subscription.SubscriptionContract'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriptionContractInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
