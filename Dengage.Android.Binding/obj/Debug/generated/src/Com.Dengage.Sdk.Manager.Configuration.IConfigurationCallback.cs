using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Configuration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.configuration']/interface[@name='ConfigurationCallback']"
	[Register ("com/dengage/sdk/manager/configuration/ConfigurationCallback", "", "Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallbackInvoker")]
	public partial interface IConfigurationCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.configuration']/interface[@name='ConfigurationCallback']/method[@name='fetchInAppExpiredMessageIds' and count(parameter)=0]"
		[Register ("fetchInAppExpiredMessageIds", "()V", "GetFetchInAppExpiredMessageIdsHandler:Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallbackInvoker, Dengage.Android.Binding")]
		void FetchInAppExpiredMessageIds ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.configuration']/interface[@name='ConfigurationCallback']/method[@name='fetchInAppMessages' and count(parameter)=0]"
		[Register ("fetchInAppMessages", "()V", "GetFetchInAppMessagesHandler:Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallbackInvoker, Dengage.Android.Binding")]
		void FetchInAppMessages ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.configuration']/interface[@name='ConfigurationCallback']/method[@name='sendSubscription' and count(parameter)=1 and parameter[1][@type='com.dengage.sdk.domain.subscription.model.Subscription']]"
		[Register ("sendSubscription", "(Lcom/dengage/sdk/domain/subscription/model/Subscription;)V", "GetSendSubscription_Lcom_dengage_sdk_domain_subscription_model_Subscription_Handler:Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallbackInvoker, Dengage.Android.Binding")]
		void SendSubscription (global::Com.Dengage.Sdk.Domain.Subscription.Model.Subscription subscription);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.configuration']/interface[@name='ConfigurationCallback']/method[@name='startAppTracking' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.dengage.sdk.domain.configuration.model.AppTracking&gt;']]"
		[Register ("startAppTracking", "(Ljava/util/List;)V", "GetStartAppTracking_Ljava_util_List_Handler:Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallbackInvoker, Dengage.Android.Binding")]
		void StartAppTracking (global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Configuration.Model.AppTracking> appTrackings);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/configuration/ConfigurationCallback", DoNotGenerateAcw=true)]
	internal partial class IConfigurationCallbackInvoker : global::Java.Lang.Object, IConfigurationCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/configuration/ConfigurationCallback", typeof (IConfigurationCallbackInvoker));

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

		public static IConfigurationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigurationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.configuration.ConfigurationCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_fetchInAppMessages;
#pragma warning disable 0169
		static Delegate GetFetchInAppMessagesHandler ()
		{
			if (cb_fetchInAppMessages == null)
				cb_fetchInAppMessages = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FetchInAppMessages));
			return cb_fetchInAppMessages;
		}

		static void n_FetchInAppMessages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FetchInAppMessages ();
		}
#pragma warning restore 0169

		IntPtr id_fetchInAppMessages;
		public unsafe void FetchInAppMessages ()
		{
			if (id_fetchInAppMessages == IntPtr.Zero)
				id_fetchInAppMessages = JNIEnv.GetMethodID (class_ref, "fetchInAppMessages", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchInAppMessages);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_startAppTracking_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetStartAppTracking_Ljava_util_List_Handler ()
		{
			if (cb_startAppTracking_Ljava_util_List_ == null)
				cb_startAppTracking_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_StartAppTracking_Ljava_util_List_));
			return cb_startAppTracking_Ljava_util_List_;
		}

		static void n_StartAppTracking_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appTrackings)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Configuration.IConfigurationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appTrackings = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Configuration.Model.AppTracking>.FromJniHandle (native_appTrackings, JniHandleOwnership.DoNotTransfer);
			__this.StartAppTracking (appTrackings);
		}
#pragma warning restore 0169

		IntPtr id_startAppTracking_Ljava_util_List_;
		public unsafe void StartAppTracking (global::System.Collections.Generic.IList<global::Com.Dengage.Sdk.Domain.Configuration.Model.AppTracking> appTrackings)
		{
			if (id_startAppTracking_Ljava_util_List_ == IntPtr.Zero)
				id_startAppTracking_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "startAppTracking", "(Ljava/util/List;)V");
			IntPtr native_appTrackings = global::Android.Runtime.JavaList<global::Com.Dengage.Sdk.Domain.Configuration.Model.AppTracking>.ToLocalJniHandle (appTrackings);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_appTrackings);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAppTracking_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_appTrackings);
		}

	}
}
