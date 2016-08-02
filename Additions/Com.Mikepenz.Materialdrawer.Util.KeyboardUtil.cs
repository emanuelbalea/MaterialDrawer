using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='KeyboardUtil']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/KeyboardUtil", DoNotGenerateAcw=true)]
	public partial class KeyboardUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/KeyboardUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyboardUtil); }
		}

		protected KeyboardUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='KeyboardUtil']/constructor[@name='KeyboardUtil' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/view/View;)V", "")]
		public unsafe KeyboardUtil (global::Android.App.Activity p0, global::Android.Views.View p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (KeyboardUtil)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Util.KeyboardUtil __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.KeyboardUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='KeyboardUtil']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public virtual unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
			} finally {
			}
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Util.KeyboardUtil __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.KeyboardUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='KeyboardUtil']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler")]
		public virtual unsafe void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "()V"));
			} finally {
			}
		}

		static IntPtr id_hideKeyboard_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='KeyboardUtil']/method[@name='hideKeyboard' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hideKeyboard", "(Landroid/app/Activity;)V", "")]
		public static unsafe void HideKeyboard (global::Android.App.Activity p0)
		{
			if (id_hideKeyboard_Landroid_app_Activity_ == IntPtr.Zero)
				id_hideKeyboard_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "hideKeyboard", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hideKeyboard_Landroid_app_Activity_, __args);
			} finally {
			}
		}

	}
}
