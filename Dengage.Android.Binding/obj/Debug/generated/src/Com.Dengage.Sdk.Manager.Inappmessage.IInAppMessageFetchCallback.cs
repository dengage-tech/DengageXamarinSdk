using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Manager.Inappmessage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageFetchCallback']"
	[Register ("com/dengage/sdk/manager/inappmessage/InAppMessageFetchCallback", "", "Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageFetchCallbackInvoker")]
	public partial interface IInAppMessageFetchCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.manager.inappmessage']/interface[@name='InAppMessageFetchCallback']/method[@name='inAppMessageFetched' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("inAppMessageFetched", "(Z)V", "GetInAppMessageFetched_ZHandler:Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageFetchCallbackInvoker, Dengage.Android.Binding")]
		void InAppMessageFetched (bool realTime);

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/manager/inappmessage/InAppMessageFetchCallback", DoNotGenerateAcw=true)]
	internal partial class IInAppMessageFetchCallbackInvoker : global::Java.Lang.Object, IInAppMessageFetchCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/manager/inappmessage/InAppMessageFetchCallback", typeof (IInAppMessageFetchCallbackInvoker));

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

		public static IInAppMessageFetchCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppMessageFetchCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.manager.inappmessage.InAppMessageFetchCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppMessageFetchCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_inAppMessageFetched_Z;
#pragma warning disable 0169
		static Delegate GetInAppMessageFetched_ZHandler ()
		{
			if (cb_inAppMessageFetched_Z == null)
				cb_inAppMessageFetched_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_InAppMessageFetched_Z));
			return cb_inAppMessageFetched_Z;
		}

		static void n_InAppMessageFetched_Z (IntPtr jnienv, IntPtr native__this, bool realTime)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Manager.Inappmessage.IInAppMessageFetchCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InAppMessageFetched (realTime);
		}
#pragma warning restore 0169

		IntPtr id_inAppMessageFetched_Z;
		public unsafe void InAppMessageFetched (bool realTime)
		{
			if (id_inAppMessageFetched_Z == IntPtr.Zero)
				id_inAppMessageFetched_Z = JNIEnv.GetMethodID (class_ref, "inAppMessageFetched", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (realTime);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppMessageFetched_Z, __args);
		}

	}
}
