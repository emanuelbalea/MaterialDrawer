using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='AbstractDrawerImageLoader']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/AbstractDrawerImageLoader", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDrawerImageLoader : global::Java.Lang.Object, global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/AbstractDrawerImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDrawerImageLoader); }
		}

		protected AbstractDrawerImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='AbstractDrawerImageLoader']/constructor[@name='AbstractDrawerImageLoader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractDrawerImageLoader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AbstractDrawerImageLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_cancel_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetCancel_Landroid_widget_ImageView_Handler ()
		{
			if (cb_cancel_Landroid_widget_ImageView_ == null)
				cb_cancel_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Cancel_Landroid_widget_ImageView_);
			return cb_cancel_Landroid_widget_ImageView_;
		}

		static void n_Cancel_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='AbstractDrawerImageLoader']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("cancel", "(Landroid/widget/ImageView;)V", "GetCancel_Landroid_widget_ImageView_Handler")]
		public virtual unsafe void Cancel (global::Android.Widget.ImageView p0)
		{
			if (id_cancel_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_cancel_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Landroid/widget/ImageView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Landroid_widget_ImageView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Landroid/widget/ImageView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_placeholder_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPlaceholder_Landroid_content_Context_Handler ()
		{
			if (cb_placeholder_Landroid_content_Context_ == null)
				cb_placeholder_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Placeholder_Landroid_content_Context_);
			return cb_placeholder_Landroid_content_Context_;
		}

		static IntPtr n_Placeholder_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Placeholder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_placeholder_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='AbstractDrawerImageLoader']/method[@name='placeholder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("placeholder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "GetPlaceholder_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable Placeholder (global::Android.Content.Context p0)
		{
			if (id_placeholder_Landroid_content_Context_ == IntPtr.Zero)
				id_placeholder_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "placeholder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Drawables.Drawable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_placeholder_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "placeholder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_placeholder_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlaceholder_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_placeholder_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_placeholder_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Placeholder_Landroid_content_Context_Ljava_lang_String_);
			return cb_placeholder_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_Placeholder_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Placeholder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_placeholder_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='AbstractDrawerImageLoader']/method[@name='placeholder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("placeholder", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "GetPlaceholder_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable Placeholder (global::Android.Content.Context p0, string p1)
		{
			if (id_placeholder_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_placeholder_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "placeholder", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Android.Graphics.Drawables.Drawable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_placeholder_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "placeholder", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSet_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == null)
				cb_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_);
			return cb_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
		}

		static void n_Set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.AbstractDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='AbstractDrawerImageLoader']/method[@name='set' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='android.graphics.drawable.Drawable']]"
		[Register ("set", "(Landroid/widget/ImageView;Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetSet_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void Set (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1, global::Android.Graphics.Drawables.Drawable p2)
		{
			if (id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "set", "(Landroid/widget/ImageView;Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Landroid/widget/ImageView;Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/AbstractDrawerImageLoader", DoNotGenerateAcw=true)]
	internal partial class AbstractDrawerImageLoaderInvoker : AbstractDrawerImageLoader {

		public AbstractDrawerImageLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDrawerImageLoaderInvoker); }
		}

	}

}
