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

namespace Com.Dengage.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dengage.sdk.util']/class[@name='LazyFactory']"
	[global::Android.Runtime.Register ("com/dengage/sdk/util/LazyFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class LazyFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/dengage/sdk/util/LazyFactory", typeof (LazyFactory));

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

		protected LazyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dengage.sdk.util']/class[@name='LazyFactory']/constructor[@name='LazyFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LazyFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_create_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetCreate_Ljava_lang_Class_Handler ()
		{
			if (cb_create_Ljava_lang_Class_ == null)
				cb_create_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_Create_Ljava_lang_Class_));
			return cb_create_Ljava_lang_Class_;
		}

		static IntPtr n_Create_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Dengage.Sdk.Util.LazyFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (clazz));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.util']/class[@name='LazyFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("create", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetCreate_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Java.Lang.Object Create (global::Java.Lang.Class clazz)
		{
			const string __id = "create.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.dengage.sdk.util']/class[@name='LazyFactory']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("of", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Of (global::Java.Lang.Class clazz)
		{
			const string __id = "of.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

	}
}
