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

namespace Com.Dengage.Sdk.Manager.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']"
	[global::Android.Runtime.Register ("com/dengage/sdk/manager/base/BaseMvpManager", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V extends com.dengage.sdk.manager.base.BaseView", "P extends com.dengage.sdk.manager.base.BasePresenter<V>"})]
	public abstract partial class BaseMvpManager : global::Java.Lang.Object, global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate, global::Com.Dengage.Sdk.Manager.Base.IBaseView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/base/BaseMvpManager", typeof (BaseMvpManager));

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

		protected BaseMvpManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/constructor[@name='BaseMvpManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseMvpManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getMvpView;
#pragma warning disable 0169
		static Delegate GetGetMvpViewHandler ()
		{
			if (cb_getMvpView == null)
				cb_getMvpView = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetMvpView));
			return cb_getMvpView;
		}

		static IntPtr n_GetMvpView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MvpView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object MvpView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='getMvpView' and count(parameter)=0]"
			[Register ("getMvpView", "()Lcom/dengage/sdk/manager/base/BaseView;", "GetGetMvpViewHandler")]
			get {
				const string __id = "getMvpView.()Lcom/dengage/sdk/manager/base/BaseView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected unsafe global::Java.Lang.Object Presenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='getPresenter' and count(parameter)=0]"
			[Register ("getPresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "")]
			get {
				const string __id = "getPresenter.()Lcom/dengage/sdk/manager/base/BasePresenter;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb__getPresenter;
#pragma warning disable 0169
		static Delegate Get_getPresenterHandler ()
		{
			if (cb__getPresenter == null)
				cb__getPresenter = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n__getPresenter));
			return cb__getPresenter;
		}

		static IntPtr n__getPresenter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this._getPresenter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='_getPresenter' and count(parameter)=0]"
		[Register ("_getPresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "Get_getPresenterHandler")]
		public virtual unsafe global::Java.Lang.Object _getPresenter ()
		{
			const string __id = "_getPresenter.()Lcom/dengage/sdk/manager/base/BasePresenter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_attach;
#pragma warning disable 0169
		static Delegate GetAttachHandler ()
		{
			if (cb_attach == null)
				cb_attach = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Attach));
			return cb_attach;
		}

		static void n_Attach (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Attach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='attach' and count(parameter)=0]"
		[Register ("attach", "()V", "GetAttachHandler")]
		public virtual unsafe void Attach ()
		{
			const string __id = "attach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_detach;
#pragma warning disable 0169
		static Delegate GetDetachHandler ()
		{
			if (cb_detach == null)
				cb_detach = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Detach));
			return cb_detach;
		}

		static void n_Detach (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public virtual unsafe void Detach ()
		{
			const string __id = "detach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_presenter;
#pragma warning disable 0169
		static Delegate GetGet_presenterHandler ()
		{
			if (cb_get_presenter == null)
				cb_get_presenter = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Get_presenter));
			return cb_get_presenter;
		}

		static IntPtr n_Get_presenter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_presenter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='get_presenter' and count(parameter)=0]"
		[Register ("get_presenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "GetGet_presenterHandler")]
		public virtual unsafe global::Java.Lang.Object Get_presenter ()
		{
			const string __id = "get_presenter.()Lcom/dengage/sdk/manager/base/BasePresenter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_view;
#pragma warning disable 0169
		static Delegate GetGet_viewHandler ()
		{
			if (cb_get_view == null)
				cb_get_view = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_Get_view));
			return cb_get_view;
		}

		static IntPtr n_Get_view (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_view ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='get_view' and count(parameter)=0]"
		[Register ("get_view", "()Lcom/dengage/sdk/manager/base/BaseView;", "GetGet_viewHandler")]
		public virtual unsafe global::Java.Lang.Object Get_view ()
		{
			const string __id = "get_view.()Lcom/dengage/sdk/manager/base/BaseView;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideLoading ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='hideLoading' and count(parameter)=0]"
		[Register ("hideLoading", "()V", "GetHideLoadingHandler")]
		public virtual unsafe void HideLoading ()
		{
			const string __id = "hideLoading.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "")]
		public unsafe void OnCreate ()
		{
			const string __id = "onCreate.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPresenterAttached;
#pragma warning disable 0169
		static Delegate GetOnPresenterAttachedHandler ()
		{
			if (cb_onPresenterAttached == null)
				cb_onPresenterAttached = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnPresenterAttached));
			return cb_onPresenterAttached;
		}

		static void n_OnPresenterAttached (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPresenterAttached ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='onPresenterAttached' and count(parameter)=0]"
		[Register ("onPresenterAttached", "()V", "GetOnPresenterAttachedHandler")]
		public virtual unsafe void OnPresenterAttached ()
		{
			const string __id = "onPresenterAttached.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPresenterDetached;
#pragma warning disable 0169
		static Delegate GetOnPresenterDetachedHandler ()
		{
			if (cb_onPresenterDetached == null)
				cb_onPresenterDetached = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnPresenterDetached));
			return cb_onPresenterDetached;
		}

		static void n_OnPresenterDetached (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPresenterDetached ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='onPresenterDetached' and count(parameter)=0]"
		[Register ("onPresenterDetached", "()V", "GetOnPresenterDetachedHandler")]
		public virtual unsafe void OnPresenterDetached ()
		{
			const string __id = "onPresenterDetached.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_providePresenter;
#pragma warning disable 0169
		static Delegate GetProvidePresenterHandler ()
		{
			if (cb_providePresenter == null)
				cb_providePresenter = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ProvidePresenter));
			return cb_providePresenter;
		}

		static IntPtr n_ProvidePresenter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProvidePresenter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='providePresenter' and count(parameter)=0]"
		[Register ("providePresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "GetProvidePresenterHandler")]
		public virtual unsafe global::Java.Lang.Object ProvidePresenter ()
		{
			const string __id = "providePresenter.()Lcom/dengage/sdk/manager/base/BasePresenter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_;
#pragma warning disable 0169
		static Delegate GetSetPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_Handler ()
		{
			if (cb_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_ == null)
				cb_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_));
			return cb_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_;
		}

		static void n_SetPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_presenter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var presenter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_presenter, JniHandleOwnership.DoNotTransfer);
			__this.SetPresenter (presenter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='setPresenter' and count(parameter)=1 and parameter[1][@type='P']]"
		[Register ("setPresenter", "(Lcom/dengage/sdk/manager/base/BasePresenter;)V", "GetSetPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_Handler")]
		public virtual unsafe void SetPresenter (global::Java.Lang.Object presenter)
		{
			const string __id = "setPresenter.(Lcom/dengage/sdk/manager/base/BasePresenter;)V";
			IntPtr native_presenter = JNIEnv.ToLocalJniHandle (presenter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_presenter);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_presenter);
				global::System.GC.KeepAlive (presenter);
			}
		}

		static Delegate cb_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_;
#pragma warning disable 0169
		static Delegate GetSet_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_Handler ()
		{
			if (cb_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_ == null)
				cb_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_));
			return cb_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_;
		}

		static void n_Set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set_presenter (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='set_presenter' and count(parameter)=1 and parameter[1][@type='P']]"
		[Register ("set_presenter", "(Lcom/dengage/sdk/manager/base/BasePresenter;)V", "GetSet_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_Handler")]
		public virtual unsafe void Set_presenter (global::Java.Lang.Object value)
		{
			const string __id = "set_presenter.(Lcom/dengage/sdk/manager/base/BasePresenter;)V";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

		static Delegate cb_set_view_Lcom_dengage_sdk_manager_base_BaseView_;
#pragma warning disable 0169
		static Delegate GetSet_view_Lcom_dengage_sdk_manager_base_BaseView_Handler ()
		{
			if (cb_set_view_Lcom_dengage_sdk_manager_base_BaseView_ == null)
				cb_set_view_Lcom_dengage_sdk_manager_base_BaseView_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Set_view_Lcom_dengage_sdk_manager_base_BaseView_));
			return cb_set_view_Lcom_dengage_sdk_manager_base_BaseView_;
		}

		static void n_Set_view_Lcom_dengage_sdk_manager_base_BaseView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set_view (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='set_view' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("set_view", "(Lcom/dengage/sdk/manager/base/BaseView;)V", "GetSet_view_Lcom_dengage_sdk_manager_base_BaseView_Handler")]
		public virtual unsafe void Set_view (global::Java.Lang.Object value)
		{
			const string __id = "set_view.(Lcom/dengage/sdk/manager/base/BaseView;)V";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (value);
			}
		}

		static Delegate cb_showError_Lcom_dengage_sdk_data_remote_error_DengageApiError_;
#pragma warning disable 0169
		static Delegate GetShowError_Lcom_dengage_sdk_data_remote_error_DengageApiError_Handler ()
		{
			if (cb_showError_Lcom_dengage_sdk_data_remote_error_DengageApiError_ == null)
				cb_showError_Lcom_dengage_sdk_data_remote_error_DengageApiError_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_ShowError_Lcom_dengage_sdk_data_remote_error_DengageApiError_));
			return cb_showError_Lcom_dengage_sdk_data_remote_error_DengageApiError_;
		}

		static void n_ShowError_Lcom_dengage_sdk_data_remote_error_DengageApiError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dengageApiError)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dengageApiError = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Data.Remote.Error.DengageApiError> (native_dengageApiError, JniHandleOwnership.DoNotTransfer);
			__this.ShowError (dengageApiError);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='showError' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.data.remote.error.DengageApiError']]"
		[Register ("showError", "(Lcom/dengage/sdk/data/remote/error/DengageApiError;)V", "GetShowError_Lcom_dengage_sdk_data_remote_error_DengageApiError_Handler")]
		public virtual unsafe void ShowError (global::Com.Dengage.Sdk.Data.Remote.Error.DengageApiError dengageApiError)
		{
			const string __id = "showError.(Lcom/dengage/sdk/data/remote/error/DengageApiError;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dengageApiError == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) dengageApiError).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dengageApiError);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.ShowError (error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='showError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("showError", "(Ljava/lang/Throwable;)V", "GetShowError_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void ShowError (global::Java.Lang.Throwable error)
		{
			const string __id = "showError.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (error);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.BaseMvpManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLoading ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpManager']/method[@name='showLoading' and count(parameter)=0]"
		[Register ("showLoading", "()V", "GetShowLoadingHandler")]
		public virtual unsafe void ShowLoading ()
		{
			const string __id = "showLoading.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/base/BaseMvpManager", DoNotGenerateAcw=true)]
	internal partial class BaseMvpManagerInvoker : BaseMvpManager, global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate {
		public BaseMvpManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/base/BaseMvpManager", typeof (BaseMvpManagerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}