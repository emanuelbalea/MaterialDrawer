using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.utils']/class[@name='BadgeDrawableBuilder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/utils/BadgeDrawableBuilder", DoNotGenerateAcw=true)]
	public partial class BadgeDrawableBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/utils/BadgeDrawableBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BadgeDrawableBuilder); }
		}

		protected BadgeDrawableBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.utils']/class[@name='BadgeDrawableBuilder']/constructor[@name='BadgeDrawableBuilder' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.BadgeStyle']]"
		[Register (".ctor", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)V", "")]
		public unsafe BadgeDrawableBuilder (global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BadgeDrawableBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_, __args);
			} finally {
			}
		}

		static Delegate cb_build_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuild_Landroid_content_Context_Handler ()
		{
			if (cb_build_Landroid_content_Context_ == null)
				cb_build_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Landroid_content_Context_);
			return cb_build_Landroid_content_Context_;
		}

		static IntPtr n_Build_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Utils.BadgeDrawableBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Utils.BadgeDrawableBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_build_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.utils']/class[@name='BadgeDrawableBuilder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("build", "(Landroid/content/Context;)Landroid/graphics/drawable/StateListDrawable;", "GetBuild_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.StateListDrawable Build (global::Android.Content.Context p0)
		{
			if (id_build_Landroid_content_Context_ == IntPtr.Zero)
				id_build_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "build", "(Landroid/content/Context;)Landroid/graphics/drawable/StateListDrawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Drawables.StateListDrawable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Landroid/content/Context;)Landroid/graphics/drawable/StateListDrawable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
