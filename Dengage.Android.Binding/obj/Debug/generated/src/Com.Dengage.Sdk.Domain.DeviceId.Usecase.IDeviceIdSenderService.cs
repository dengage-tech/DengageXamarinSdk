using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Domain.DeviceId.Usecase {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.domain.deviceId.usecase']/interface[@name='DeviceIdSenderService']"
	[Register ("com/dengage/sdk/domain/deviceId/usecase/DeviceIdSenderService", "", "Com.Dengage.Sdk.Domain.DeviceId.Usecase.IDeviceIdSenderServiceInvoker")]
	public partial interface IDeviceIdSenderService : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/domain/deviceId/usecase/DeviceIdSenderService", DoNotGenerateAcw=true)]
	internal partial class IDeviceIdSenderServiceInvoker : global::Java.Lang.Object, IDeviceIdSenderService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/deviceId/usecase/DeviceIdSenderService", typeof (IDeviceIdSenderServiceInvoker));

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

		public static IDeviceIdSenderService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceIdSenderService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.domain.deviceId.usecase.DeviceIdSenderService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceIdSenderServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
