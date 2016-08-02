using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/view/BezelImageView", DoNotGenerateAcw=true)]
	public partial class BezelImageView : global::Android.Widget.ImageView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView.CustomOutline']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/view/BezelImageView$CustomOutline", DoNotGenerateAcw=true)]
		public partial class CustomOutline : global::Android.Views.ViewOutlineProvider {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/view/BezelImageView$CustomOutline", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CustomOutline); }
			}

			protected CustomOutline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getOutline_Landroid_view_View_Landroid_graphics_Outline_;
#pragma warning disable 0169
			static Delegate GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler ()
			{
				if (cb_getOutline_Landroid_view_View_Landroid_graphics_Outline_ == null)
					cb_getOutline_Landroid_view_View_Landroid_graphics_Outline_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOutline_Landroid_view_View_Landroid_graphics_Outline_);
				return cb_getOutline_Landroid_view_View_Landroid_graphics_Outline_;
			}

			static void n_GetOutline_Landroid_view_View_Landroid_graphics_Outline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mikepenz.Materialdrawer.View.BezelImageView.CustomOutline __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView.CustomOutline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Outline p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Outline> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.GetOutline (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_getOutline_Landroid_view_View_Landroid_graphics_Outline_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView.CustomOutline']/method[@name='getOutline' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Outline']]"
			[Register ("getOutline", "(Landroid/view/View;Landroid/graphics/Outline;)V", "GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler")]
			public override unsafe void GetOutline (global::Android.Views.View p0, global::Android.Graphics.Outline p1)
			{
				if (id_getOutline_Landroid_view_View_Landroid_graphics_Outline_ == IntPtr.Zero)
					id_getOutline_Landroid_view_View_Landroid_graphics_Outline_ = JNIEnv.GetMethodID (class_ref, "getOutline", "(Landroid/view/View;Landroid/graphics/Outline;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getOutline_Landroid_view_View_Landroid_graphics_Outline_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutline", "(Landroid/view/View;Landroid/graphics/Outline;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/view/BezelImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BezelImageView); }
		}

		protected BezelImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView']/constructor[@name='BezelImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BezelImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BezelImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView']/constructor[@name='BezelImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BezelImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BezelImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView']/constructor[@name='BezelImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BezelImageView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BezelImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_disableTouchFeedback_Z;
#pragma warning disable 0169
		static Delegate GetDisableTouchFeedback_ZHandler ()
		{
			if (cb_disableTouchFeedback_Z == null)
				cb_disableTouchFeedback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DisableTouchFeedback_Z);
			return cb_disableTouchFeedback_Z;
		}

		static void n_DisableTouchFeedback_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.View.BezelImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableTouchFeedback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disableTouchFeedback_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView']/method[@name='disableTouchFeedback' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableTouchFeedback", "(Z)V", "GetDisableTouchFeedback_ZHandler")]
		public virtual unsafe void DisableTouchFeedback (bool p0)
		{
			if (id_disableTouchFeedback_Z == IntPtr.Zero)
				id_disableTouchFeedback_Z = JNIEnv.GetMethodID (class_ref, "disableTouchFeedback", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableTouchFeedback_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableTouchFeedback", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectorColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectorColor_IHandler ()
		{
			if (cb_setSelectorColor_I == null)
				cb_setSelectorColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectorColor_I);
			return cb_setSelectorColor_I;
		}

		static void n_SetSelectorColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.View.BezelImageView __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectorColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectorColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.view']/class[@name='BezelImageView']/method[@name='setSelectorColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectorColor", "(I)V", "GetSetSelectorColor_IHandler")]
		public virtual unsafe void SetSelectorColor (int p0)
		{
			if (id_setSelectorColor_I == IntPtr.Zero)
				id_setSelectorColor_I = JNIEnv.GetMethodID (class_ref, "setSelectorColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectorColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectorColor", "(I)V"), __args);
			} finally {
			}
		}

	}
}
