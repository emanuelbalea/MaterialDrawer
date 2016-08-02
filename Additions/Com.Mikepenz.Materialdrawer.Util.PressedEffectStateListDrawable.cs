using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='PressedEffectStateListDrawable']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/PressedEffectStateListDrawable", DoNotGenerateAcw=true)]
	public partial class PressedEffectStateListDrawable : global::Android.Graphics.Drawables.StateListDrawable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/PressedEffectStateListDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PressedEffectStateListDrawable); }
		}

		protected PressedEffectStateListDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='PressedEffectStateListDrawable']/constructor[@name='PressedEffectStateListDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;II)V", "")]
		public unsafe PressedEffectStateListDrawable (global::Android.Graphics.Drawables.Drawable p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (PressedEffectStateListDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/drawable/Drawable;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_drawable_Drawable_II == IntPtr.Zero)
					id_ctor_Landroid_graphics_drawable_Drawable_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_II, __args);
			} finally {
			}
		}

	}
}
