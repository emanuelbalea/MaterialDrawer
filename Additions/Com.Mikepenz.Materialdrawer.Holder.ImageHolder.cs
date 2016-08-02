using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/holder/ImageHolder", DoNotGenerateAcw=true)]
	public partial class ImageHolder : global::Com.Mikepenz.Materialize.Holder.ImageHolder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/holder/ImageHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageHolder); }
		}

		protected ImageHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mikepenz_iconics_typeface_IIcon_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/constructor[@name='ImageHolder' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
		[Register (".ctor", "(Lcom/mikepenz/iconics/typeface/IIcon;)V", "")]
		public unsafe ImageHolder (global::Com.Mikepenz.Iconics.Typeface.IIcon p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/iconics/typeface/IIcon;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/iconics/typeface/IIcon;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_iconics_typeface_IIcon_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_iconics_typeface_IIcon_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/iconics/typeface/IIcon;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_iconics_typeface_IIcon_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_iconics_typeface_IIcon_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/constructor[@name='ImageHolder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ImageHolder (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/constructor[@name='ImageHolder' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe ImageHolder (global::Android.Graphics.Bitmap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/constructor[@name='ImageHolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ImageHolder (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ImageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Landroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/constructor[@name='ImageHolder' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/net/Uri;)V", "")]
		public unsafe ImageHolder (global::Android.Net.Uri p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/net/Uri;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_Uri_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/constructor[@name='ImageHolder' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe ImageHolder (global::Android.Graphics.Drawables.Drawable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ImageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/drawable/Drawable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
			}
		}

		static Delegate cb_getIIcon;
#pragma warning disable 0169
		static Delegate GetGetIIconHandler ()
		{
			if (cb_getIIcon == null)
				cb_getIIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIIcon);
			return cb_getIIcon;
		}

		static IntPtr n_GetIIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IIcon);
		}
#pragma warning restore 0169

		static Delegate cb_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
#pragma warning disable 0169
		static Delegate GetSetIIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler ()
		{
			if (cb_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == null)
				cb_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIIcon_Lcom_mikepenz_iconics_typeface_IIcon_);
			return cb_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		}

		static void n_SetIIcon_Lcom_mikepenz_iconics_typeface_IIcon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Iconics.Typeface.IIcon p0 = (global::Com.Mikepenz.Iconics.Typeface.IIcon)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IIcon = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIIcon;
		static IntPtr id_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		public virtual unsafe global::Com.Mikepenz.Iconics.Typeface.IIcon IIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/method[@name='getIIcon' and count(parameter)=0]"
			[Register ("getIIcon", "()Lcom/mikepenz/iconics/typeface/IIcon;", "GetGetIIconHandler")]
			get {
				if (id_getIIcon == IntPtr.Zero)
					id_getIIcon = JNIEnv.GetMethodID (class_ref, "getIIcon", "()Lcom/mikepenz/iconics/typeface/IIcon;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIIcon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIIcon", "()Lcom/mikepenz/iconics/typeface/IIcon;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/method[@name='setIIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
			[Register ("setIIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)V", "GetSetIIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler")]
			set {
				if (id_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == IntPtr.Zero)
					id_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNIEnv.GetMethodID (class_ref, "setIIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIIcon_Lcom_mikepenz_iconics_typeface_IIcon_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_applyDecidedIconOrSetGone_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_widget_ImageView_IZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/method[@name='applyDecidedIconOrSetGone' and count(parameter)=5 and parameter[1][@type='com.mikepenz.materialdrawer.holder.ImageHolder'] and parameter[2][@type='android.widget.ImageView'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("applyDecidedIconOrSetGone", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;Landroid/widget/ImageView;IZI)V", "")]
		public static unsafe void ApplyDecidedIconOrSetGone (global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0, global::Android.Widget.ImageView p1, int p2, bool p3, int p4)
		{
			if (id_applyDecidedIconOrSetGone_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_widget_ImageView_IZI == IntPtr.Zero)
				id_applyDecidedIconOrSetGone_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_widget_ImageView_IZI = JNIEnv.GetStaticMethodID (class_ref, "applyDecidedIconOrSetGone", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;Landroid/widget/ImageView;IZI)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_applyDecidedIconOrSetGone_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_widget_ImageView_IZI, __args);
			} finally {
			}
		}

		static Delegate cb_decideIcon_Landroid_content_Context_IZI;
#pragma warning disable 0169
		static Delegate GetDecideIcon_Landroid_content_Context_IZIHandler ()
		{
			if (cb_decideIcon_Landroid_content_Context_IZI == null)
				cb_decideIcon_Landroid_content_Context_IZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, int, IntPtr>) n_DecideIcon_Landroid_content_Context_IZI);
			return cb_decideIcon_Landroid_content_Context_IZI;
		}

		static IntPtr n_DecideIcon_Landroid_content_Context_IZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2, int p3)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecideIcon (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decideIcon_Landroid_content_Context_IZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/method[@name='decideIcon' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("decideIcon", "(Landroid/content/Context;IZI)Landroid/graphics/drawable/Drawable;", "GetDecideIcon_Landroid_content_Context_IZIHandler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable DecideIcon (global::Android.Content.Context p0, int p1, bool p2, int p3)
		{
			if (id_decideIcon_Landroid_content_Context_IZI == IntPtr.Zero)
				id_decideIcon_Landroid_content_Context_IZI = JNIEnv.GetMethodID (class_ref, "decideIcon", "(Landroid/content/Context;IZI)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Android.Graphics.Drawables.Drawable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decideIcon_Landroid_content_Context_IZI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decideIcon", "(Landroid/content/Context;IZI)Landroid/graphics/drawable/Drawable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decideIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_content_Context_IZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ImageHolder']/method[@name='decideIcon' and count(parameter)=5 and parameter[1][@type='com.mikepenz.materialdrawer.holder.ImageHolder'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("decideIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;Landroid/content/Context;IZI)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable DecideIcon (global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0, global::Android.Content.Context p1, int p2, bool p3, int p4)
		{
			if (id_decideIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_content_Context_IZI == IntPtr.Zero)
				id_decideIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_content_Context_IZI = JNIEnv.GetStaticMethodID (class_ref, "decideIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;Landroid/content/Context;IZI)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decideIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Landroid_content_Context_IZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
