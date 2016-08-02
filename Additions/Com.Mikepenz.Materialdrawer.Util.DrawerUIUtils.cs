using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/DrawerUIUtils", DoNotGenerateAcw=true)]
	public partial class DrawerUIUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/DrawerUIUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawerUIUtils); }
		}

		protected DrawerUIUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/constructor[@name='DrawerUIUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawerUIUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrawerUIUtils)) {
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

		static IntPtr id_getDrawerItemBackground_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='getDrawerItemBackground' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawerItemBackground", "(I)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetDrawerItemBackground (int p0)
		{
			if (id_getDrawerItemBackground_I == IntPtr.Zero)
				id_getDrawerItemBackground_I = JNIEnv.GetStaticMethodID (class_ref, "getDrawerItemBackground", "(I)Landroid/graphics/drawable/StateListDrawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDrawerItemBackground_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getIconStateList_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='getIconStateList' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("getIconStateList", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/StateListDrawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.StateListDrawable GetIconStateList (global::Android.Graphics.Drawables.Drawable p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_getIconStateList_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_getIconStateList_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "getIconStateList", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/StateListDrawable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Drawables.StateListDrawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIconStateList_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOptimalDrawerWidth_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='getOptimalDrawerWidth' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOptimalDrawerWidth", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetOptimalDrawerWidth (global::Android.Content.Context p0)
		{
			if (id_getOptimalDrawerWidth_Landroid_content_Context_ == IntPtr.Zero)
				id_getOptimalDrawerWidth_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getOptimalDrawerWidth", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getOptimalDrawerWidth_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPlaceHolder_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='getPlaceHolder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPlaceHolder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetPlaceHolder (global::Android.Content.Context p0)
		{
			if (id_getPlaceHolder_Landroid_content_Context_ == IntPtr.Zero)
				id_getPlaceHolder_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPlaceHolder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPlaceHolder_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTextColorStateList_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='getTextColorStateList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getTextColorStateList", "(II)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList GetTextColorStateList (int p0, int p1)
		{
			if (id_getTextColorStateList_II == IntPtr.Zero)
				id_getTextColorStateList_II = JNIEnv.GetStaticMethodID (class_ref, "getTextColorStateList", "(II)Landroid/content/res/ColorStateList;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTextColorStateList_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isSystemBarOnBottom_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='isSystemBarOnBottom' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSystemBarOnBottom", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsSystemBarOnBottom (global::Android.Content.Context p0)
		{
			if (id_isSystemBarOnBottom_Landroid_content_Context_ == IntPtr.Zero)
				id_isSystemBarOnBottom_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isSystemBarOnBottom", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSystemBarOnBottom_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setDrawerVerticalPadding_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='setDrawerVerticalPadding' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setDrawerVerticalPadding", "(Landroid/view/View;)V", "")]
		public static unsafe void SetDrawerVerticalPadding (global::Android.Views.View p0)
		{
			if (id_setDrawerVerticalPadding_Landroid_view_View_ == IntPtr.Zero)
				id_setDrawerVerticalPadding_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "setDrawerVerticalPadding", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDrawerVerticalPadding_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_setDrawerVerticalPadding_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerUIUtils']/method[@name='setDrawerVerticalPadding' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setDrawerVerticalPadding", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetDrawerVerticalPadding (global::Android.Views.View p0, int p1)
		{
			if (id_setDrawerVerticalPadding_Landroid_view_View_I == IntPtr.Zero)
				id_setDrawerVerticalPadding_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "setDrawerVerticalPadding", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDrawerVerticalPadding_Landroid_view_View_I, __args);
			} finally {
			}
		}

	}
}
