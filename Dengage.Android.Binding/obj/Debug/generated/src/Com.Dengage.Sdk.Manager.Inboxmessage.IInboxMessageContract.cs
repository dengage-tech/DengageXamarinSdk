using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Inboxmessage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.Presenter']"
	[Register ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract$Presenter", "", "Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenterInvoker")]
	public partial interface IInboxMessageContractPresenter : global::Com.Dengage.Sdk.Manager.Base.IBasePresenter {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.Presenter']/method[@name='clearInboxMessageCache' and count(parameter)=0]"
		[Register ("clearInboxMessageCache", "()V", "GetClearInboxMessageCacheHandler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void ClearInboxMessageCache ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.Presenter']/method[@name='getInboxMessages' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.dengage.sdk.callback.DengageCallback&lt;java.util.List&lt;com.dengage.sdk.domain.inboxmessage.model.InboxMessage&gt;&gt;']]"
		[Register ("getInboxMessages", "(IILcom/dengage/sdk/callback/DengageCallback;)V", "GetGetInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_Handler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void GetInboxMessages (int limit, int offset, global::Com.Dengage.Sdk.Callback.IDengageCallback dengageCallback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.Presenter']/method[@name='setInboxMessageAsClicked' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInboxMessageAsClicked", "(Ljava/lang/String;)V", "GetSetInboxMessageAsClicked_Ljava_lang_String_Handler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void SetInboxMessageAsClicked (string messageId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.Presenter']/method[@name='setInboxMessageAsDeleted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setInboxMessageAsDeleted", "(Ljava/lang/String;)V", "GetSetInboxMessageAsDeleted_Ljava_lang_String_Handler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void SetInboxMessageAsDeleted (string messageId);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract$Presenter", DoNotGenerateAcw=true)]
	internal partial class IInboxMessageContractPresenterInvoker : global::Java.Lang.Object, IInboxMessageContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract$Presenter", typeof (IInboxMessageContractPresenterInvoker));

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

		public static IInboxMessageContractPresenter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInboxMessageContractPresenter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inboxmessage.InboxMessageContract.Presenter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInboxMessageContractPresenterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clearInboxMessageCache;
#pragma warning disable 0169
		static Delegate GetClearInboxMessageCacheHandler ()
		{
			if (cb_clearInboxMessageCache == null)
				cb_clearInboxMessageCache = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ClearInboxMessageCache));
			return cb_clearInboxMessageCache;
		}

		static void n_ClearInboxMessageCache (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearInboxMessageCache ();
		}
#pragma warning restore 0169

		IntPtr id_clearInboxMessageCache;
		public unsafe void ClearInboxMessageCache ()
		{
			if (id_clearInboxMessageCache == IntPtr.Zero)
				id_clearInboxMessageCache = JNIEnv.GetMethodID (class_ref, "clearInboxMessageCache", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearInboxMessageCache);
		}

		static Delegate cb_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_;
#pragma warning disable 0169
		static Delegate GetGetInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_Handler ()
		{
			if (cb_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_ == null)
				cb_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIIL_V (n_GetInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_));
			return cb_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_;
		}

		static void n_GetInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_ (IntPtr jnienv, IntPtr native__this, int limit, int offset, IntPtr native_dengageCallback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dengageCallback = (global::Com.Dengage.Sdk.Callback.IDengageCallback)global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Callback.IDengageCallback> (native_dengageCallback, JniHandleOwnership.DoNotTransfer);
			__this.GetInboxMessages (limit, offset, dengageCallback);
		}
#pragma warning restore 0169

		IntPtr id_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_;
		public unsafe void GetInboxMessages (int limit, int offset, global::Com.Dengage.Sdk.Callback.IDengageCallback dengageCallback)
		{
			if (id_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_ == IntPtr.Zero)
				id_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_ = JNIEnv.GetMethodID (class_ref, "getInboxMessages", "(IILcom/dengage/sdk/callback/DengageCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (limit);
			__args [1] = new JValue (offset);
			__args [2] = new JValue ((dengageCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dengageCallback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getInboxMessages_IILcom_dengage_sdk_callback_DengageCallback_, __args);
		}

		static Delegate cb_setInboxMessageAsClicked_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInboxMessageAsClicked_Ljava_lang_String_Handler ()
		{
			if (cb_setInboxMessageAsClicked_Ljava_lang_String_ == null)
				cb_setInboxMessageAsClicked_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetInboxMessageAsClicked_Ljava_lang_String_));
			return cb_setInboxMessageAsClicked_Ljava_lang_String_;
		}

		static void n_SetInboxMessageAsClicked_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_messageId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var messageId = JNIEnv.GetString (native_messageId, JniHandleOwnership.DoNotTransfer);
			__this.SetInboxMessageAsClicked (messageId);
		}
#pragma warning restore 0169

		IntPtr id_setInboxMessageAsClicked_Ljava_lang_String_;
		public unsafe void SetInboxMessageAsClicked (string messageId)
		{
			if (id_setInboxMessageAsClicked_Ljava_lang_String_ == IntPtr.Zero)
				id_setInboxMessageAsClicked_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInboxMessageAsClicked", "(Ljava/lang/String;)V");
			IntPtr native_messageId = JNIEnv.NewString ((string)messageId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_messageId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInboxMessageAsClicked_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_messageId);
		}

		static Delegate cb_setInboxMessageAsDeleted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInboxMessageAsDeleted_Ljava_lang_String_Handler ()
		{
			if (cb_setInboxMessageAsDeleted_Ljava_lang_String_ == null)
				cb_setInboxMessageAsDeleted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetInboxMessageAsDeleted_Ljava_lang_String_));
			return cb_setInboxMessageAsDeleted_Ljava_lang_String_;
		}

		static void n_SetInboxMessageAsDeleted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_messageId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var messageId = JNIEnv.GetString (native_messageId, JniHandleOwnership.DoNotTransfer);
			__this.SetInboxMessageAsDeleted (messageId);
		}
#pragma warning restore 0169

		IntPtr id_setInboxMessageAsDeleted_Ljava_lang_String_;
		public unsafe void SetInboxMessageAsDeleted (string messageId)
		{
			if (id_setInboxMessageAsDeleted_Ljava_lang_String_ == IntPtr.Zero)
				id_setInboxMessageAsDeleted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInboxMessageAsDeleted", "(Ljava/lang/String;)V");
			IntPtr native_messageId = JNIEnv.NewString ((string)messageId);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_messageId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInboxMessageAsDeleted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_messageId);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.View']"
	[Register ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract$View", "", "Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractViewInvoker")]
	public partial interface IInboxMessageContractView : global::Com.Dengage.Sdk.Manager.Base.IBaseView {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.View']/method[@name='fetchedInboxMessages' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.dengage.sdk.domain.inboxmessage.model.InboxMessage&gt;']]"
		[Register ("fetchedInboxMessages", "(Ljava/util/List;)V", "GetFetchedInboxMessages_Ljava_util_List_Handler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractViewInvoker, Dengage.Android.Binding")]
		void FetchedInboxMessages (global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inboxmessage.Model.InboxMessage> inAppMessages);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.View']/method[@name='inboxMessageClicked' and count(parameter)=0]"
		[Register ("inboxMessageClicked", "()V", "GetInboxMessageClickedHandler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractViewInvoker, Dengage.Android.Binding")]
		void InboxMessageClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract.View']/method[@name='inboxMessageDeleted' and count(parameter)=0]"
		[Register ("inboxMessageDeleted", "()V", "GetInboxMessageDeletedHandler:Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractViewInvoker, Dengage.Android.Binding")]
		void InboxMessageDeleted ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract$View", DoNotGenerateAcw=true)]
	internal partial class IInboxMessageContractViewInvoker : global::Java.Lang.Object, IInboxMessageContractView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract$View", typeof (IInboxMessageContractViewInvoker));

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

		public static IInboxMessageContractView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInboxMessageContractView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inboxmessage.InboxMessageContract.View'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInboxMessageContractViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fetchedInboxMessages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetFetchedInboxMessages_Ljava_util_List_Handler ()
		{
			if (cb_fetchedInboxMessages_Ljava_util_List_ == null)
				cb_fetchedInboxMessages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_FetchedInboxMessages_Ljava_util_List_));
			return cb_fetchedInboxMessages_Ljava_util_List_;
		}

		static void n_FetchedInboxMessages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessages)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inAppMessages = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inboxmessage.Model.InboxMessage>.FromJniHandle (native_inAppMessages, JniHandleOwnership.DoNotTransfer);
			__this.FetchedInboxMessages (inAppMessages);
		}
#pragma warning restore 0169

		IntPtr id_fetchedInboxMessages_Ljava_util_List_;
		public unsafe void FetchedInboxMessages (global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inboxmessage.Model.InboxMessage> inAppMessages)
		{
			if (id_fetchedInboxMessages_Ljava_util_List_ == IntPtr.Zero)
				id_fetchedInboxMessages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "fetchedInboxMessages", "(Ljava/util/List;)V");
			IntPtr native_inAppMessages = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inboxmessage.Model.InboxMessage>.ToLocalJniHandle (inAppMessages);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_inAppMessages);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchedInboxMessages_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_inAppMessages);
		}

		static Delegate cb_inboxMessageClicked;
#pragma warning disable 0169
		static Delegate GetInboxMessageClickedHandler ()
		{
			if (cb_inboxMessageClicked == null)
				cb_inboxMessageClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_InboxMessageClicked));
			return cb_inboxMessageClicked;
		}

		static void n_InboxMessageClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InboxMessageClicked ();
		}
#pragma warning restore 0169

		IntPtr id_inboxMessageClicked;
		public unsafe void InboxMessageClicked ()
		{
			if (id_inboxMessageClicked == IntPtr.Zero)
				id_inboxMessageClicked = JNIEnv.GetMethodID (class_ref, "inboxMessageClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inboxMessageClicked);
		}

		static Delegate cb_inboxMessageDeleted;
#pragma warning disable 0169
		static Delegate GetInboxMessageDeletedHandler ()
		{
			if (cb_inboxMessageDeleted == null)
				cb_inboxMessageDeleted = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_InboxMessageDeleted));
			return cb_inboxMessageDeleted;
		}

		static void n_InboxMessageDeleted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InboxMessageDeleted ();
		}
#pragma warning restore 0169

		IntPtr id_inboxMessageDeleted;
		public unsafe void InboxMessageDeleted ()
		{
			if (id_inboxMessageDeleted == IntPtr.Zero)
				id_inboxMessageDeleted = JNIEnv.GetMethodID (class_ref, "inboxMessageDeleted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inboxMessageDeleted);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inboxmessage']/interface[@name='InboxMessageContract']"
	[Register ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract", "", "Com.Dengage.Sdk.Manager.Inboxmessage.IInboxMessageContractInvoker")]
	public partial interface IInboxMessageContract : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract", DoNotGenerateAcw=true)]
	internal partial class IInboxMessageContractInvoker : global::Java.Lang.Object, IInboxMessageContract {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inboxmessage/InboxMessageContract", typeof (IInboxMessageContractInvoker));

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

		public static IInboxMessageContract GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInboxMessageContract> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inboxmessage.InboxMessageContract'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInboxMessageContractInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
