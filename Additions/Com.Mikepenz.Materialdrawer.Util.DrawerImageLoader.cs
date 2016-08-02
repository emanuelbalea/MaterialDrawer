using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/DrawerImageLoader", DoNotGenerateAcw=true)]
	public partial class DrawerImageLoader : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerImageLoader.IDrawerImageLoader']"
		[Register ("com/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader", "", "Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader/IDrawerImageLoaderInvoker")]
		public partial interface IDrawerImageLoader : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerImageLoader.IDrawerImageLoader']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
			[Register ("cancel", "(Landroid/widget/ImageView;)V", "GetCancel_Landroid_widget_ImageView_Handler:Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader/IDrawerImageLoaderInvoker, MaterialDrawer")]
			void Cancel (global::Android.Widget.ImageView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerImageLoader.IDrawerImageLoader']/method[@name='placeholder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("placeholder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "GetPlaceholder_Landroid_content_Context_Handler:Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader/IDrawerImageLoaderInvoker, MaterialDrawer")]
			global::Android.Graphics.Drawables.Drawable Placeholder (global::Android.Content.Context p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerImageLoader.IDrawerImageLoader']/method[@name='placeholder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
			[Register ("placeholder", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "GetPlaceholder_Landroid_content_Context_Ljava_lang_String_Handler:Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader/IDrawerImageLoaderInvoker, MaterialDrawer")]
			global::Android.Graphics.Drawables.Drawable Placeholder (global::Android.Content.Context p0, string p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerImageLoader.IDrawerImageLoader']/method[@name='set' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='android.graphics.drawable.Drawable']]"
			[Register ("set", "(Landroid/widget/ImageView;Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V", "GetSet_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler:Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader/IDrawerImageLoaderInvoker, MaterialDrawer")]
			void Set (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1, global::Android.Graphics.Drawables.Drawable p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader", DoNotGenerateAcw=true)]
		internal class IDrawerImageLoaderInvoker : global::Java.Lang.Object, IDrawerImageLoader {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDrawerImageLoaderInvoker); }
			}

			IntPtr class_ref;

			public static IDrawerImageLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDrawerImageLoader> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.util.DrawerImageLoader.IDrawerImageLoader"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDrawerImageLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Cancel (p0);
			}
#pragma warning restore 0169

			IntPtr id_cancel_Landroid_widget_ImageView_;
			public unsafe void Cancel (global::Android.Widget.ImageView p0)
			{
				if (id_cancel_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_cancel_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Landroid/widget/ImageView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Landroid_widget_ImageView_, __args);
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
				global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Placeholder (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_placeholder_Landroid_content_Context_;
			public unsafe global::Android.Graphics.Drawables.Drawable Placeholder (global::Android.Content.Context p0)
			{
				if (id_placeholder_Landroid_content_Context_ == IntPtr.Zero)
					id_placeholder_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "placeholder", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_placeholder_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
				global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Placeholder (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_placeholder_Landroid_content_Context_Ljava_lang_String_;
			public unsafe global::Android.Graphics.Drawables.Drawable Placeholder (global::Android.Content.Context p0, string p1)
			{
				if (id_placeholder_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_placeholder_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "placeholder", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_placeholder_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
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
				global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Set (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_;
			public unsafe void Set (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1, global::Android.Graphics.Drawables.Drawable p2)
			{
				if (id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "set", "(Landroid/widget/ImageView;Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Landroid_widget_ImageView_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader.Tags']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/DrawerImageLoader$Tags", DoNotGenerateAcw=true)]
		public sealed partial class Tags : global::Java.Lang.Enum {


			static IntPtr ACCOUNT_HEADER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader.Tags']/field[@name='ACCOUNT_HEADER']"
			[Register ("ACCOUNT_HEADER")]
			public static global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags AccountHeader {
				get {
					if (ACCOUNT_HEADER_jfieldId == IntPtr.Zero)
						ACCOUNT_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCOUNT_HEADER", "Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCOUNT_HEADER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PROFILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader.Tags']/field[@name='PROFILE']"
			[Register ("PROFILE")]
			public static global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags Profile {
				get {
					if (PROFILE_jfieldId == IntPtr.Zero)
						PROFILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROFILE", "Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROFILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PROFILE_DRAWER_ITEM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader.Tags']/field[@name='PROFILE_DRAWER_ITEM']"
			[Register ("PROFILE_DRAWER_ITEM")]
			public static global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags ProfileDrawerItem {
				get {
					if (PROFILE_DRAWER_ITEM_jfieldId == IntPtr.Zero)
						PROFILE_DRAWER_ITEM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROFILE_DRAWER_ITEM", "Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROFILE_DRAWER_ITEM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/DrawerImageLoader$Tags", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tags); }
			}

			internal Tags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader.Tags']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;", "")]
			public static unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader.Tags']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;", "")]
			public static unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$Tags;");
				try {
					return (global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.Tags));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/DrawerImageLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawerImageLoader); }
		}

		protected DrawerImageLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getImageLoader;
#pragma warning disable 0169
		static Delegate GetGetImageLoaderHandler ()
		{
			if (cb_getImageLoader == null)
				cb_getImageLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageLoader);
			return cb_getImageLoader;
		}

		static IntPtr n_GetImageLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageLoader);
		}
#pragma warning restore 0169

		static Delegate cb_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_;
#pragma warning disable 0169
		static Delegate GetSetImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_Handler ()
		{
			if (cb_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ == null)
				cb_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_);
			return cb_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_;
		}

		static void n_SetImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader p0 = (global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageLoader = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageLoader;
		static IntPtr id_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader ImageLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='getImageLoader' and count(parameter)=0]"
			[Register ("getImageLoader", "()Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;", "GetGetImageLoaderHandler")]
			get {
				if (id_getImageLoader == IntPtr.Zero)
					id_getImageLoader = JNIEnv.GetMethodID (class_ref, "getImageLoader", "()Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageLoader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageLoader", "()Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='setImageLoader' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.util.DrawerImageLoader.IDrawerImageLoader']]"
			[Register ("setImageLoader", "(Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;)V", "GetSetImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_Handler")]
			set {
				if (id_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ == IntPtr.Zero)
					id_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ = JNIEnv.GetMethodID (class_ref, "setImageLoader", "(Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageLoader_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageLoader", "(Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelImage_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetCancelImage_Landroid_widget_ImageView_Handler ()
		{
			if (cb_cancelImage_Landroid_widget_ImageView_ == null)
				cb_cancelImage_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelImage_Landroid_widget_ImageView_);
			return cb_cancelImage_Landroid_widget_ImageView_;
		}

		static void n_CancelImage_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelImage_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='cancelImage' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("cancelImage", "(Landroid/widget/ImageView;)V", "GetCancelImage_Landroid_widget_ImageView_Handler")]
		public virtual unsafe void CancelImage (global::Android.Widget.ImageView p0)
		{
			if (id_cancelImage_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_cancelImage_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "cancelImage", "(Landroid/widget/ImageView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelImage_Landroid_widget_ImageView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelImage", "(Landroid/widget/ImageView;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_init_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.util.DrawerImageLoader.IDrawerImageLoader']]"
		[Register ("init", "(Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;", "")]
		public static unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader Init (global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader.IDrawerImageLoader p0)
		{
			if (id_init_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ == IntPtr.Zero)
				id_init_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Lcom/mikepenz/materialdrawer/util/DrawerImageLoader$IDrawerImageLoader;)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_init_Lcom_mikepenz_materialdrawer_util_DrawerImageLoader_IDrawerImageLoader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_Handler ()
		{
			if (cb_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_ == null)
				cb_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_);
			return cb_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_;
		}

		static bool n_SetImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='setImage' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String']]"
		[Register ("setImage", "(Landroid/widget/ImageView;Landroid/net/Uri;Ljava/lang/String;)Z", "GetSetImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetImage (global::Android.Widget.ImageView p0, global::Android.Net.Uri p1, string p2)
		{
			if (id_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/widget/ImageView;Landroid/net/Uri;Ljava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Landroid_widget_ImageView_Landroid_net_Uri_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Landroid/widget/ImageView;Landroid/net/Uri;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_withHandleAllUris_Z;
#pragma warning disable 0169
		static Delegate GetWithHandleAllUris_ZHandler ()
		{
			if (cb_withHandleAllUris_Z == null)
				cb_withHandleAllUris_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithHandleAllUris_Z);
			return cb_withHandleAllUris_Z;
		}

		static IntPtr n_WithHandleAllUris_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHandleAllUris (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHandleAllUris_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerImageLoader']/method[@name='withHandleAllUris' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withHandleAllUris", "(Z)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;", "GetWithHandleAllUris_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader WithHandleAllUris (bool p0)
		{
			if (id_withHandleAllUris_Z == IntPtr.Zero)
				id_withHandleAllUris_Z = JNIEnv.GetMethodID (class_ref, "withHandleAllUris", "(Z)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHandleAllUris_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerImageLoader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHandleAllUris", "(Z)Lcom/mikepenz/materialdrawer/util/DrawerImageLoader;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
