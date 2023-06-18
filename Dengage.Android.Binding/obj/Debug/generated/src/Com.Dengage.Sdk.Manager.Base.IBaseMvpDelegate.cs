using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']"
	[global::Android.Runtime.Register ("com/dengage/sdk/manager/base/BaseMvpDelegate$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class BaseMvpDelegateDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/base/BaseMvpDelegate$DefaultImpls", typeof (BaseMvpDelegateDefaultImpls));

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

		internal BaseMvpDelegateDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='_getPresenter' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("_getPresenter", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)Lcom/dengage/sdk/manager/base/BasePresenter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe global::Java.Lang.Object _getPresenter (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "_getPresenter.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)Lcom/dengage/sdk/manager/base/BasePresenter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='attach' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("attach", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe void Attach (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "attach.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='detach' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("detach", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe void Detach (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "detach.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='getMvpView' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("getMvpView", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)Lcom/dengage/sdk/manager/base/BaseView;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe global::Java.Lang.Object GetMvpView (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "getMvpView.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)Lcom/dengage/sdk/manager/base/BaseView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='onPresenterAttached' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("onPresenterAttached", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe void OnPresenterAttached (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "onPresenterAttached.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='onPresenterDetached' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("onPresenterDetached", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe void OnPresenterDetached (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "onPresenterDetached.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='providePresenter' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;']]"
		[Register ("providePresenter", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)Lcom/dengage/sdk/manager/base/BasePresenter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe global::Java.Lang.Object ProvidePresenter (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this)
		{
			const string __id = "providePresenter.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;)Lcom/dengage/sdk/manager/base/BasePresenter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (_this);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/class[@name='BaseMvpDelegate.DefaultImpls']/method[@name='setPresenter' and count(parameter)=2 and parameter[1][@type='com.dengage.sdk.manager.base.BaseMvpDelegate&lt;View, Presenter&gt;'] and parameter[2][@type='Presenter']]"
		[Register ("setPresenter", "(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;Lcom/dengage/sdk/manager/base/BasePresenter;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
		public static unsafe void SetPresenter (global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate _this, global::Java.Lang.Object presenter)
		{
			const string __id = "setPresenter.(Lcom/dengage/sdk/manager/base/BaseMvpDelegate;Lcom/dengage/sdk/manager/base/BasePresenter;)V";
			IntPtr native_presenter = JNIEnv.ToLocalJniHandle (presenter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_this == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this).Handle);
				__args [1] = new JniArgumentValue (native_presenter);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_presenter);
				global::System.GC.KeepAlive (_this);
				global::System.GC.KeepAlive (presenter);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']"
	[Register ("com/dengage/sdk/manager/base/BaseMvpDelegate", "", "Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"View extends com.dengage.sdk.manager.base.BaseView", "Presenter extends com.dengage.sdk.manager.base.BasePresenter<View>"})]
	public partial interface IBaseMvpDelegate : IJavaObject, IJavaPeerable {
		global::Java.Lang.Object MvpView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='getMvpView' and count(parameter)=0]"
			[Register ("getMvpView", "()Lcom/dengage/sdk/manager/base/BaseView;", "GetGetMvpViewHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='_getPresenter' and count(parameter)=0]"
		[Register ("_getPresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "Get_getPresenterHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		global::Java.Lang.Object _getPresenter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='attach' and count(parameter)=0]"
		[Register ("attach", "()V", "GetAttachHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void Attach ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void Detach ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='get_presenter' and count(parameter)=0]"
		[Register ("get_presenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "GetGet_presenterHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		global::Java.Lang.Object Get_presenter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='get_view' and count(parameter)=0]"
		[Register ("get_view", "()Lcom/dengage/sdk/manager/base/BaseView;", "GetGet_viewHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		global::Java.Lang.Object Get_view ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='onPresenterAttached' and count(parameter)=0]"
		[Register ("onPresenterAttached", "()V", "GetOnPresenterAttachedHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void OnPresenterAttached ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='onPresenterDetached' and count(parameter)=0]"
		[Register ("onPresenterDetached", "()V", "GetOnPresenterDetachedHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void OnPresenterDetached ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='providePresenter' and count(parameter)=0]"
		[Register ("providePresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;", "GetProvidePresenterHandler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		global::Java.Lang.Object ProvidePresenter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='setPresenter' and count(parameter)=1 and parameter[1][@type='Presenter']]"
		[Register ("setPresenter", "(Lcom/dengage/sdk/manager/base/BasePresenter;)V", "GetSetPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_Handler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void SetPresenter (global::Java.Lang.Object presenter);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='set_presenter' and count(parameter)=1 and parameter[1][@type='Presenter']]"
		[Register ("set_presenter", "(Lcom/dengage/sdk/manager/base/BasePresenter;)V", "GetSet_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_Handler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void Set_presenter (global::Java.Lang.Object value);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.base']/interface[@name='BaseMvpDelegate']/method[@name='set_view' and count(parameter)=1 and parameter[1][@type='View']]"
		[Register ("set_view", "(Lcom/dengage/sdk/manager/base/BaseView;)V", "GetSet_view_Lcom_dengage_sdk_manager_base_BaseView_Handler:Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegateInvoker, Dengage.Android.Binding")]
		void Set_view (global::Java.Lang.Object value);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/base/BaseMvpDelegate", DoNotGenerateAcw=true)]
	internal partial class IBaseMvpDelegateInvoker : global::Java.Lang.Object, IBaseMvpDelegate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/base/BaseMvpDelegate", typeof (IBaseMvpDelegateInvoker));

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

		public static IBaseMvpDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseMvpDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.base.BaseMvpDelegate'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseMvpDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MvpView);
		}
#pragma warning restore 0169

		IntPtr id_getMvpView;
		public unsafe global::Java.Lang.Object MvpView {
			get {
				if (id_getMvpView == IntPtr.Zero)
					id_getMvpView = JNIEnv.GetMethodID (class_ref, "getMvpView", "()Lcom/dengage/sdk/manager/base/BaseView;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMvpView), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this._getPresenter ());
		}
#pragma warning restore 0169

		IntPtr id__getPresenter;
		public unsafe global::Java.Lang.Object _getPresenter ()
		{
			if (id__getPresenter == IntPtr.Zero)
				id__getPresenter = JNIEnv.GetMethodID (class_ref, "_getPresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id__getPresenter), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Attach ();
		}
#pragma warning restore 0169

		IntPtr id_attach;
		public unsafe void Attach ()
		{
			if (id_attach == IntPtr.Zero)
				id_attach = JNIEnv.GetMethodID (class_ref, "attach", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attach);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		IntPtr id_detach;
		public unsafe void Detach ()
		{
			if (id_detach == IntPtr.Zero)
				id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detach);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_presenter ());
		}
#pragma warning restore 0169

		IntPtr id_get_presenter;
		public unsafe global::Java.Lang.Object Get_presenter ()
		{
			if (id_get_presenter == IntPtr.Zero)
				id_get_presenter = JNIEnv.GetMethodID (class_ref, "get_presenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_presenter), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_view ());
		}
#pragma warning restore 0169

		IntPtr id_get_view;
		public unsafe global::Java.Lang.Object Get_view ()
		{
			if (id_get_view == IntPtr.Zero)
				id_get_view = JNIEnv.GetMethodID (class_ref, "get_view", "()Lcom/dengage/sdk/manager/base/BaseView;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_view), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPresenterAttached ();
		}
#pragma warning restore 0169

		IntPtr id_onPresenterAttached;
		public unsafe void OnPresenterAttached ()
		{
			if (id_onPresenterAttached == IntPtr.Zero)
				id_onPresenterAttached = JNIEnv.GetMethodID (class_ref, "onPresenterAttached", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPresenterAttached);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPresenterDetached ();
		}
#pragma warning restore 0169

		IntPtr id_onPresenterDetached;
		public unsafe void OnPresenterDetached ()
		{
			if (id_onPresenterDetached == IntPtr.Zero)
				id_onPresenterDetached = JNIEnv.GetMethodID (class_ref, "onPresenterDetached", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPresenterDetached);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProvidePresenter ());
		}
#pragma warning restore 0169

		IntPtr id_providePresenter;
		public unsafe global::Java.Lang.Object ProvidePresenter ()
		{
			if (id_providePresenter == IntPtr.Zero)
				id_providePresenter = JNIEnv.GetMethodID (class_ref, "providePresenter", "()Lcom/dengage/sdk/manager/base/BasePresenter;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_providePresenter), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var presenter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_presenter, JniHandleOwnership.DoNotTransfer);
			__this.SetPresenter (presenter);
		}
#pragma warning restore 0169

		IntPtr id_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_;
		public unsafe void SetPresenter (global::Java.Lang.Object presenter)
		{
			if (id_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_ == IntPtr.Zero)
				id_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_ = JNIEnv.GetMethodID (class_ref, "setPresenter", "(Lcom/dengage/sdk/manager/base/BasePresenter;)V");
			IntPtr native_presenter = JNIEnv.ToLocalJniHandle (presenter);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_presenter);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPresenter_Lcom_dengage_sdk_manager_base_BasePresenter_, __args);
			JNIEnv.DeleteLocalRef (native_presenter);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set_presenter (value);
		}
#pragma warning restore 0169

		IntPtr id_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_;
		public unsafe void Set_presenter (global::Java.Lang.Object value)
		{
			if (id_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_ == IntPtr.Zero)
				id_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_ = JNIEnv.GetMethodID (class_ref, "set_presenter", "(Lcom/dengage/sdk/manager/base/BasePresenter;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_presenter_Lcom_dengage_sdk_manager_base_BasePresenter_, __args);
			JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Base.IBaseMvpDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set_view (value);
		}
#pragma warning restore 0169

		IntPtr id_set_view_Lcom_dengage_sdk_manager_base_BaseView_;
		public unsafe void Set_view (global::Java.Lang.Object value)
		{
			if (id_set_view_Lcom_dengage_sdk_manager_base_BaseView_ == IntPtr.Zero)
				id_set_view_Lcom_dengage_sdk_manager_base_BaseView_ = JNIEnv.GetMethodID (class_ref, "set_view", "(Lcom/dengage/sdk/manager/base/BaseView;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_view_Lcom_dengage_sdk_manager_base_BaseView_, __args);
			JNIEnv.DeleteLocalRef (native_value);
		}

	}
}
