using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Dengage.Sdk.Domain.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.domain.base']/class[@name='UseCaseRunner.DefaultImpls']"
	[global::Android.Runtime.Register ("com/dengage/sdk/domain/base/UseCaseRunner$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class UseCaseRunnerDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/base/UseCaseRunner$DefaultImpls", typeof (UseCaseRunnerDefaultImpls));

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

		internal UseCaseRunnerDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.dengage.sdk.domain.base']/interface[@name='UseCaseRunner']"
	[Register ("com/dengage/sdk/domain/base/UseCaseRunner", "", "Com.Dengage.Sdk.Domain.Base.IUseCaseRunnerInvoker")]
	public partial interface IUseCaseRunner : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.domain.base']/interface[@name='UseCaseRunner']/method[@name='cancelUseCases' and count(parameter)=0]"
		[Register ("cancelUseCases", "()V", "GetCancelUseCasesHandler:Com.Dengage.Sdk.Domain.Base.IUseCaseRunnerInvoker, Dengage.Android.Binding")]
		void CancelUseCases ();

	}

	[global::Android.Runtime.Register ("com/dengage/sdk/domain/base/UseCaseRunner", DoNotGenerateAcw=true)]
	internal partial class IUseCaseRunnerInvoker : global::Java.Lang.Object, IUseCaseRunner {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/domain/base/UseCaseRunner", typeof (IUseCaseRunnerInvoker));

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

		public static IUseCaseRunner GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUseCaseRunner> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.dengage.sdk.domain.base.UseCaseRunner'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUseCaseRunnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelUseCases;
#pragma warning disable 0169
		static Delegate GetCancelUseCasesHandler ()
		{
			if (cb_cancelUseCases == null)
				cb_cancelUseCases = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_CancelUseCases));
			return cb_cancelUseCases;
		}

		static void n_CancelUseCases (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Domain.Base.IUseCaseRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelUseCases ();
		}
#pragma warning restore 0169

		IntPtr id_cancelUseCases;
		public unsafe void CancelUseCases ()
		{
			if (id_cancelUseCases == IntPtr.Zero)
				id_cancelUseCases = JNIEnv.GetMethodID (class_ref, "cancelUseCases", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelUseCases);
		}

	}
}
