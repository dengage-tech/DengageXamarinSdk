using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Inappmessage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.Presenter']"
	[Register ("com/dengage/sdk/manager/inappmessage/InAppMessageContract$Presenter", "", "Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenterInvoker")]
	public partial interface IInAppMessageContractPresenter : global::Com.Dengage.Sdk.Manager.Base.IBasePresenter {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.Presenter']/method[@name='fetchInAppExpiredMessageIds' and count(parameter)=0]"
		[Register ("fetchInAppExpiredMessageIds", "()V", "GetFetchInAppExpiredMessageIdsHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void FetchInAppExpiredMessageIds ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.Presenter']/method[@name='getInAppMessages' and count(parameter)=0]"
		[Register ("getInAppMessages", "()V", "GetGetInAppMessagesHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void GetInAppMessages ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.Presenter']/method[@name='setInAppMessageAsClicked' and count(parameter)=2 and parameter[1][@type='com.dengage.sdk.domain.inappmessage.model.InAppMessage'] and parameter[2][@type='java.lang.String']]"
		[Register ("setInAppMessageAsClicked", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;Ljava/lang/String;)V", "GetSetInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_Handler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void SetInAppMessageAsClicked (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage, string buttonId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.Presenter']/method[@name='setInAppMessageAsDismissed' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.inappmessage.model.InAppMessage']]"
		[Register ("setInAppMessageAsDismissed", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;)V", "GetSetInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Handler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void SetInAppMessageAsDismissed (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.Presenter']/method[@name='setInAppMessageAsDisplayed' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.inappmessage.model.InAppMessage']]"
		[Register ("setInAppMessageAsDisplayed", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;)V", "GetSetInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Handler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenterInvoker, Dengage.Android.Binding")]
		void SetInAppMessageAsDisplayed (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/InAppMessageContract$Presenter", DoNotGenerateAcw=true)]
	internal partial class IInAppMessageContractPresenterInvoker : global::Java.Lang.Object, IInAppMessageContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/InAppMessageContract$Presenter", typeof (IInAppMessageContractPresenterInvoker));

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

		public static IInAppMessageContractPresenter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppMessageContractPresenter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.InAppMessageContract.Presenter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppMessageContractPresenterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fetchInAppExpiredMessageIds;
#pragma warning disable 0169
		static Delegate GetFetchInAppExpiredMessageIdsHandler ()
		{
			if (cb_fetchInAppExpiredMessageIds == null)
				cb_fetchInAppExpiredMessageIds = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FetchInAppExpiredMessageIds));
			return cb_fetchInAppExpiredMessageIds;
		}

		static void n_FetchInAppExpiredMessageIds (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FetchInAppExpiredMessageIds ();
		}
#pragma warning restore 0169

		IntPtr id_fetchInAppExpiredMessageIds;
		public unsafe void FetchInAppExpiredMessageIds ()
		{
			if (id_fetchInAppExpiredMessageIds == IntPtr.Zero)
				id_fetchInAppExpiredMessageIds = JNIEnv.GetMethodID (class_ref, "fetchInAppExpiredMessageIds", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchInAppExpiredMessageIds);
		}

		static Delegate cb_getInAppMessages;
#pragma warning disable 0169
		static Delegate GetGetInAppMessagesHandler ()
		{
			if (cb_getInAppMessages == null)
				cb_getInAppMessages = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_GetInAppMessages));
			return cb_getInAppMessages;
		}

		static void n_GetInAppMessages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetInAppMessages ();
		}
#pragma warning restore 0169

		IntPtr id_getInAppMessages;
		public unsafe void GetInAppMessages ()
		{
			if (id_getInAppMessages == IntPtr.Zero)
				id_getInAppMessages = JNIEnv.GetMethodID (class_ref, "getInAppMessages", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getInAppMessages);
		}

		static Delegate cb_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ == null)
				cb_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_SetInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_));
			return cb_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_;
		}

		static void n_SetInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessage, IntPtr native_buttonId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inAppMessage = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> (native_inAppMessage, JniHandleOwnership.DoNotTransfer);
			var buttonId = JNIEnv.GetString (native_buttonId, JniHandleOwnership.DoNotTransfer);
			__this.SetInAppMessageAsClicked (inAppMessage, buttonId);
		}
#pragma warning restore 0169

		IntPtr id_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_;
		public unsafe void SetInAppMessageAsClicked (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage, string buttonId)
		{
			if (id_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInAppMessageAsClicked", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;Ljava/lang/String;)V");
			IntPtr native_buttonId = JNIEnv.NewString ((string)buttonId);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((inAppMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessage).Handle);
			__args [1] = new JValue (native_buttonId);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInAppMessageAsClicked_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_buttonId);
		}

		static Delegate cb_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
#pragma warning disable 0169
		static Delegate GetSetInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Handler ()
		{
			if (cb_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ == null)
				cb_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_));
			return cb_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
		}

		static void n_SetInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inAppMessage = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> (native_inAppMessage, JniHandleOwnership.DoNotTransfer);
			__this.SetInAppMessageAsDismissed (inAppMessage);
		}
#pragma warning restore 0169

		IntPtr id_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
		public unsafe void SetInAppMessageAsDismissed (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage)
		{
			if (id_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ == IntPtr.Zero)
				id_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ = JNIEnv.GetMethodID (class_ref, "setInAppMessageAsDismissed", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((inAppMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessage).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInAppMessageAsDismissed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_, __args);
		}

		static Delegate cb_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
#pragma warning disable 0169
		static Delegate GetSetInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_Handler ()
		{
			if (cb_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ == null)
				cb_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_));
			return cb_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
		}

		static void n_SetInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inAppMessage = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> (native_inAppMessage, JniHandleOwnership.DoNotTransfer);
			__this.SetInAppMessageAsDisplayed (inAppMessage);
		}
#pragma warning restore 0169

		IntPtr id_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_;
		public unsafe void SetInAppMessageAsDisplayed (global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage inAppMessage)
		{
			if (id_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ == IntPtr.Zero)
				id_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_ = JNIEnv.GetMethodID (class_ref, "setInAppMessageAsDisplayed", "(Lcom/dengage/sdk/domain/inappmessage/model/InAppMessage;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((inAppMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppMessage).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInAppMessageAsDisplayed_Lcom_dengage_sdk_domain_inappmessage_model_InAppMessage_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.View']"
	[Register ("com/dengage/sdk/manager/inappmessage/InAppMessageContract$View", "", "Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractViewInvoker")]
	public partial interface IInAppMessageContractView : global::Com.Dengage.Sdk.Manager.Base.IBaseView {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.View']/method[@name='fetchedInAppMessages' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.dengage.sdk.domain.inappmessage.model.InAppMessage&gt;'] and parameter[2][@type='boolean']]"
		[Register ("fetchedInAppMessages", "(Ljava/util/List;Z)V", "GetFetchedInAppMessages_Ljava_util_List_ZHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractViewInvoker, Dengage.Android.Binding")]
		void FetchedInAppMessages (global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> inAppMessages, bool isRealTime);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.View']/method[@name='inAppMessageSetAsClicked' and count(parameter)=0]"
		[Register ("inAppMessageSetAsClicked", "()V", "GetInAppMessageSetAsClickedHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractViewInvoker, Dengage.Android.Binding")]
		void InAppMessageSetAsClicked ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.View']/method[@name='inAppMessageSetAsDismissed' and count(parameter)=0]"
		[Register ("inAppMessageSetAsDismissed", "()V", "GetInAppMessageSetAsDismissedHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractViewInvoker, Dengage.Android.Binding")]
		void InAppMessageSetAsDismissed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract.View']/method[@name='inAppMessageSetAsDisplayed' and count(parameter)=0]"
		[Register ("inAppMessageSetAsDisplayed", "()V", "GetInAppMessageSetAsDisplayedHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractViewInvoker, Dengage.Android.Binding")]
		void InAppMessageSetAsDisplayed ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/InAppMessageContract$View", DoNotGenerateAcw=true)]
	internal partial class IInAppMessageContractViewInvoker : global::Java.Lang.Object, IInAppMessageContractView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/InAppMessageContract$View", typeof (IInAppMessageContractViewInvoker));

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

		public static IInAppMessageContractView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppMessageContractView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.InAppMessageContract.View'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppMessageContractViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_fetchedInAppMessages_Ljava_util_List_Z;
#pragma warning disable 0169
		static Delegate GetFetchedInAppMessages_Ljava_util_List_ZHandler ()
		{
			if (cb_fetchedInAppMessages_Ljava_util_List_Z == null)
				cb_fetchedInAppMessages_Ljava_util_List_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZ_V (n_FetchedInAppMessages_Ljava_util_List_Z));
			return cb_fetchedInAppMessages_Ljava_util_List_Z;
		}

		static void n_FetchedInAppMessages_Ljava_util_List_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppMessages, bool isRealTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inAppMessages = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage>.FromJniHandle (native_inAppMessages, JniHandleOwnership.DoNotTransfer);
			__this.FetchedInAppMessages (inAppMessages, isRealTime);
		}
#pragma warning restore 0169

		IntPtr id_fetchedInAppMessages_Ljava_util_List_Z;
		public unsafe void FetchedInAppMessages (global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage> inAppMessages, bool isRealTime)
		{
			if (id_fetchedInAppMessages_Ljava_util_List_Z == IntPtr.Zero)
				id_fetchedInAppMessages_Ljava_util_List_Z = JNIEnv.GetMethodID (class_ref, "fetchedInAppMessages", "(Ljava/util/List;Z)V");
			IntPtr native_inAppMessages = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Inappmessage.Model.InAppMessage>.ToLocalJniHandle (inAppMessages);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_inAppMessages);
			__args [1] = new JValue (isRealTime);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchedInAppMessages_Ljava_util_List_Z, __args);
			JNIEnv.DeleteLocalRef (native_inAppMessages);
		}

		static Delegate cb_inAppMessageSetAsClicked;
#pragma warning disable 0169
		static Delegate GetInAppMessageSetAsClickedHandler ()
		{
			if (cb_inAppMessageSetAsClicked == null)
				cb_inAppMessageSetAsClicked = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_InAppMessageSetAsClicked));
			return cb_inAppMessageSetAsClicked;
		}

		static void n_InAppMessageSetAsClicked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InAppMessageSetAsClicked ();
		}
#pragma warning restore 0169

		IntPtr id_inAppMessageSetAsClicked;
		public unsafe void InAppMessageSetAsClicked ()
		{
			if (id_inAppMessageSetAsClicked == IntPtr.Zero)
				id_inAppMessageSetAsClicked = JNIEnv.GetMethodID (class_ref, "inAppMessageSetAsClicked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageSetAsClicked);
		}

		static Delegate cb_inAppMessageSetAsDismissed;
#pragma warning disable 0169
		static Delegate GetInAppMessageSetAsDismissedHandler ()
		{
			if (cb_inAppMessageSetAsDismissed == null)
				cb_inAppMessageSetAsDismissed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_InAppMessageSetAsDismissed));
			return cb_inAppMessageSetAsDismissed;
		}

		static void n_InAppMessageSetAsDismissed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InAppMessageSetAsDismissed ();
		}
#pragma warning restore 0169

		IntPtr id_inAppMessageSetAsDismissed;
		public unsafe void InAppMessageSetAsDismissed ()
		{
			if (id_inAppMessageSetAsDismissed == IntPtr.Zero)
				id_inAppMessageSetAsDismissed = JNIEnv.GetMethodID (class_ref, "inAppMessageSetAsDismissed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageSetAsDismissed);
		}

		static Delegate cb_inAppMessageSetAsDisplayed;
#pragma warning disable 0169
		static Delegate GetInAppMessageSetAsDisplayedHandler ()
		{
			if (cb_inAppMessageSetAsDisplayed == null)
				cb_inAppMessageSetAsDisplayed = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_InAppMessageSetAsDisplayed));
			return cb_inAppMessageSetAsDisplayed;
		}

		static void n_InAppMessageSetAsDisplayed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InAppMessageSetAsDisplayed ();
		}
#pragma warning restore 0169

		IntPtr id_inAppMessageSetAsDisplayed;
		public unsafe void InAppMessageSetAsDisplayed ()
		{
			if (id_inAppMessageSetAsDisplayed == IntPtr.Zero)
				id_inAppMessageSetAsDisplayed = JNIEnv.GetMethodID (class_ref, "inAppMessageSetAsDisplayed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageSetAsDisplayed);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageContract']"
	[Register ("com/dengage/sdk/manager/inappmessage/InAppMessageContract", "", "Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageContractInvoker")]
	public partial interface IInAppMessageContract : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/InAppMessageContract", DoNotGenerateAcw=true)]
	internal partial class IInAppMessageContractInvoker : global::Java.Lang.Object, IInAppMessageContract {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/InAppMessageContract", typeof (IInAppMessageContractInvoker));

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

		public static IInAppMessageContract GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppMessageContract> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.InAppMessageContract'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppMessageContractInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
