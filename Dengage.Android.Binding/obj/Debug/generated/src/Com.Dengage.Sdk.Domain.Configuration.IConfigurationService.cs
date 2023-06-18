using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Domain.Configuration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.domain.configuration']/interface[@name='ConfigurationService']"
	[Register ("com/dengage/sdk/domain/configuration/ConfigurationService", "", "Com.Dengage.Sdk.Domain.Configuration.IConfigurationServiceInvoker")]
	public partial interface IConfigurationService : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("com/dengage/sdk/domain/configuration/ConfigurationService", DoNotGenerateAcw=true)]
	internal partial class IConfigurationServiceInvoker : global::Java.Lang.Object, IConfigurationService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/configuration/ConfigurationService", typeof (IConfigurationServiceInvoker));

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

		public static IConfigurationService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigurationService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.domain.configuration.ConfigurationService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
