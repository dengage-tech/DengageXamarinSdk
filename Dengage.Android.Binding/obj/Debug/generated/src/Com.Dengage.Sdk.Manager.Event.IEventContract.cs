using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Event {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.Presenter']"
	[Register ("com/dengage/sdk/manager/event/EventContract$Presenter", "", "Com.Dengage.Sdk.Manager.Event.IEventContractPresenterInvoker")]
	public partial interface IEventContractPresenter : global::Com.Dengage.Sdk.Manager.Base.IBasePresenter {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.Presenter']/method[@name='sendEvent' and count(parameter)=5 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendEvent", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetSendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Dengage.Sdk.Manager.Event.IEventContractPresenterInvoker, Dengage.Android.Binding")]
		void SendEvent (global::Java.Lang.Integer p0, string integrationKey, string key, string eventTableName, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> eventDetails);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.Presenter']/method[@name='sendOpenEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("sendOpenEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)V", "GetSendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Handler:Com.Dengage.Sdk.Manager.Event.IEventContractPresenterInvoker, Dengage.Android.Binding")]
		void SendOpenEvent (string buttonId, string itemId, global::Java.Lang.Integer p2, string messageDetails, string integrationKey);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.Presenter']/method[@name='sendTransactionalOpenEvent' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendTransactionalOpenEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Dengage.Sdk.Manager.Event.IEventContractPresenterInvoker, Dengage.Android.Binding")]
		void SendTransactionalOpenEvent (string buttonId, string itemId, global::Java.Lang.Integer p2, string messageDetails, string transactionId, string integrationKey);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/event/EventContract$Presenter", DoNotGenerateAcw=true)]
	internal partial class IEventContractPresenterInvoker : global::Java.Lang.Object, IEventContractPresenter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/event/EventContract$Presenter", typeof (IEventContractPresenterInvoker));

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

		public static IEventContractPresenter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventContractPresenter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.event.EventContract.Presenter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventContractPresenterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_SendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_));
			return cb_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_SendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_integrationKey, IntPtr native_key, IntPtr native_eventTableName, IntPtr native_eventDetails)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var integrationKey = JNIEnv.GetString (native_integrationKey, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var eventTableName = JNIEnv.GetString (native_eventTableName, JniHandleOwnership.DoNotTransfer);
			var eventDetails = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_eventDetails, JniHandleOwnership.DoNotTransfer);
			__this.SendEvent (p0, integrationKey, key, eventTableName, eventDetails);
		}
#pragma warning restore 0169

		IntPtr id_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void SendEvent (global::Java.Lang.Integer p0, string integrationKey, string key, string eventTableName, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> eventDetails)
		{
			if (id_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendEvent", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_integrationKey = JNIEnv.NewString ((string)integrationKey);
			IntPtr native_key = JNIEnv.NewString ((string)key);
			IntPtr native_eventTableName = JNIEnv.NewString ((string)eventTableName);
			IntPtr native_eventDetails = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (eventDetails);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_integrationKey);
			__args [2] = new JValue (native_key);
			__args [3] = new JValue (native_eventTableName);
			__args [4] = new JValue (native_eventDetails);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendEvent_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_integrationKey);
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_eventTableName);
			JNIEnv.DeleteLocalRef (native_eventDetails);
		}

		static Delegate cb_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_SendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_));
			return cb_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonId, IntPtr native_itemId, IntPtr native_p2, IntPtr native_messageDetails, IntPtr native_integrationKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buttonId = JNIEnv.GetString (native_buttonId, JniHandleOwnership.DoNotTransfer);
			var itemId = JNIEnv.GetString (native_itemId, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
			var messageDetails = JNIEnv.GetString (native_messageDetails, JniHandleOwnership.DoNotTransfer);
			var integrationKey = JNIEnv.GetString (native_integrationKey, JniHandleOwnership.DoNotTransfer);
			__this.SendOpenEvent (buttonId, itemId, p2, messageDetails, integrationKey);
		}
#pragma warning restore 0169

		IntPtr id_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SendOpenEvent (string buttonId, string itemId, global::Java.Lang.Integer p2, string messageDetails, string integrationKey)
		{
			if (id_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendOpenEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_buttonId = JNIEnv.NewString ((string)buttonId);
			IntPtr native_itemId = JNIEnv.NewString ((string)itemId);
			IntPtr native_messageDetails = JNIEnv.NewString ((string)messageDetails);
			IntPtr native_integrationKey = JNIEnv.NewString ((string)integrationKey);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_buttonId);
			__args [1] = new JValue (native_itemId);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_messageDetails);
			__args [4] = new JValue (native_integrationKey);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_buttonId);
			JNIEnv.DeleteLocalRef (native_itemId);
			JNIEnv.DeleteLocalRef (native_messageDetails);
			JNIEnv.DeleteLocalRef (native_integrationKey);
		}

		static Delegate cb_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLL_V (n_SendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonId, IntPtr native_itemId, IntPtr native_p2, IntPtr native_messageDetails, IntPtr native_transactionId, IntPtr native_integrationKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buttonId = JNIEnv.GetString (native_buttonId, JniHandleOwnership.DoNotTransfer);
			var itemId = JNIEnv.GetString (native_itemId, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
			var messageDetails = JNIEnv.GetString (native_messageDetails, JniHandleOwnership.DoNotTransfer);
			var transactionId = JNIEnv.GetString (native_transactionId, JniHandleOwnership.DoNotTransfer);
			var integrationKey = JNIEnv.GetString (native_integrationKey, JniHandleOwnership.DoNotTransfer);
			__this.SendTransactionalOpenEvent (buttonId, itemId, p2, messageDetails, transactionId, integrationKey);
		}
#pragma warning restore 0169

		IntPtr id_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SendTransactionalOpenEvent (string buttonId, string itemId, global::Java.Lang.Integer p2, string messageDetails, string transactionId, string integrationKey)
		{
			if (id_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendTransactionalOpenEvent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_buttonId = JNIEnv.NewString ((string)buttonId);
			IntPtr native_itemId = JNIEnv.NewString ((string)itemId);
			IntPtr native_messageDetails = JNIEnv.NewString ((string)messageDetails);
			IntPtr native_transactionId = JNIEnv.NewString ((string)transactionId);
			IntPtr native_integrationKey = JNIEnv.NewString ((string)integrationKey);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_buttonId);
			__args [1] = new JValue (native_itemId);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (native_messageDetails);
			__args [4] = new JValue (native_transactionId);
			__args [5] = new JValue (native_integrationKey);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendTransactionalOpenEvent_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_buttonId);
			JNIEnv.DeleteLocalRef (native_itemId);
			JNIEnv.DeleteLocalRef (native_messageDetails);
			JNIEnv.DeleteLocalRef (native_transactionId);
			JNIEnv.DeleteLocalRef (native_integrationKey);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractPresenter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.View']"
	[Register ("com/dengage/sdk/manager/event/EventContract$View", "", "Com.Dengage.Sdk.Manager.Event.IEventContractViewInvoker")]
	public partial interface IEventContractView : global::Com.Dengage.Sdk.Manager.Base.IBaseView {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.View']/method[@name='eventSent' and count(parameter)=0]"
		[Register ("eventSent", "()V", "GetEventSentHandler:Com.Dengage.Sdk.Manager.Event.IEventContractViewInvoker, Dengage.Android.Binding")]
		void EventSent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.View']/method[@name='openEventSent' and count(parameter)=0]"
		[Register ("openEventSent", "()V", "GetOpenEventSentHandler:Com.Dengage.Sdk.Manager.Event.IEventContractViewInvoker, Dengage.Android.Binding")]
		void OpenEventSent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract.View']/method[@name='transactionalOpenEventSent' and count(parameter)=0]"
		[Register ("transactionalOpenEventSent", "()V", "GetTransactionalOpenEventSentHandler:Com.Dengage.Sdk.Manager.Event.IEventContractViewInvoker, Dengage.Android.Binding")]
		void TransactionalOpenEventSent ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/event/EventContract$View", DoNotGenerateAcw=true)]
	internal partial class IEventContractViewInvoker : global::Java.Lang.Object, IEventContractView {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/event/EventContract$View", typeof (IEventContractViewInvoker));

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

		public static IEventContractView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventContractView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.event.EventContract.View'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventContractViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_eventSent;
#pragma warning disable 0169
		static Delegate GetEventSentHandler ()
		{
			if (cb_eventSent == null)
				cb_eventSent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_EventSent));
			return cb_eventSent;
		}

		static void n_EventSent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EventSent ();
		}
#pragma warning restore 0169

		IntPtr id_eventSent;
		public unsafe void EventSent ()
		{
			if (id_eventSent == IntPtr.Zero)
				id_eventSent = JNIEnv.GetMethodID (class_ref, "eventSent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_eventSent);
		}

		static Delegate cb_openEventSent;
#pragma warning disable 0169
		static Delegate GetOpenEventSentHandler ()
		{
			if (cb_openEventSent == null)
				cb_openEventSent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OpenEventSent));
			return cb_openEventSent;
		}

		static void n_OpenEventSent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenEventSent ();
		}
#pragma warning restore 0169

		IntPtr id_openEventSent;
		public unsafe void OpenEventSent ()
		{
			if (id_openEventSent == IntPtr.Zero)
				id_openEventSent = JNIEnv.GetMethodID (class_ref, "openEventSent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openEventSent);
		}

		static Delegate cb_transactionalOpenEventSent;
#pragma warning disable 0169
		static Delegate GetTransactionalOpenEventSentHandler ()
		{
			if (cb_transactionalOpenEventSent == null)
				cb_transactionalOpenEventSent = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_TransactionalOpenEventSent));
			return cb_transactionalOpenEventSent;
		}

		static void n_TransactionalOpenEventSent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransactionalOpenEventSent ();
		}
#pragma warning restore 0169

		IntPtr id_transactionalOpenEventSent;
		public unsafe void TransactionalOpenEventSent ()
		{
			if (id_transactionalOpenEventSent == IntPtr.Zero)
				id_transactionalOpenEventSent = JNIEnv.GetMethodID (class_ref, "transactionalOpenEventSent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transactionalOpenEventSent);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Event.IEventContractView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.event']/interface[@name='EventContract']"
	[Register ("com/dengage/sdk/manager/event/EventContract", "", "Com.Dengage.Sdk.Manager.Event.IEventContractInvoker")]
	public partial interface IEventContract : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/event/EventContract", DoNotGenerateAcw=true)]
	internal partial class IEventContractInvoker : global::Java.Lang.Object, IEventContract {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/event/EventContract", typeof (IEventContractInvoker));

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

		public static IEventContract GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventContract> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.event.EventContract'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventContractInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
