using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/IProfile", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IProfile : global::Com.Mikepenz.Fastadapter.IIdentifyable {

		global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetEmailHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")] get;
		}

		global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;", "GetGetIconHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")] get;
		}

		bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")] get;
		}

		global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetNameHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withEmail", "(Ljava/lang/String;)Ljava/lang/Object;", "GetWithEmail_Ljava_lang_String_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithEmail (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("withIcon", "(Landroid/graphics/Bitmap;)Ljava/lang/Object;", "GetWithIcon_Landroid_graphics_Bitmap_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetWithIcon_Landroid_graphics_drawable_Drawable_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Android.Graphics.Drawables.Drawable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("withIcon", "(Landroid/net/Uri;)Ljava/lang/Object;", "GetWithIcon_Landroid_net_Uri_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
		[Register ("withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Ljava/lang/Object;", "GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Com.Mikepenz.Iconics.Typeface.IIcon p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withIcon", "(I)Ljava/lang/Object;", "GetWithIcon_IHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withIcon", "(Ljava/lang/String;)Ljava/lang/Object;", "GetWithIcon_Ljava_lang_String_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withName", "(Ljava/lang/String;)Ljava/lang/Object;", "GetWithName_Ljava_lang_String_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithName (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IProfile']/method[@name='withSelectable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectable", "(Z)Ljava/lang/Object;", "GetWithSelectable_ZHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfileInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithSelectable (bool p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/IProfile", DoNotGenerateAcw=true)]
	internal class IProfileInvoker : global::Java.Lang.Object, IProfile {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/IProfile");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IProfileInvoker); }
		}

		IntPtr class_ref;

		public static IProfile GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProfile> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.IProfile"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProfileInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Email);
		}
#pragma warning restore 0169

		IntPtr id_getEmail;
		public unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Email {
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		IntPtr id_getIcon;
		public unsafe global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder Icon {
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isSelectable;
#pragma warning disable 0169
		static Delegate GetIsSelectableHandler ()
		{
			if (cb_isSelectable == null)
				cb_isSelectable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectable);
			return cb_isSelectable;
		}

		static bool n_IsSelectable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		IntPtr id_isSelectable;
		public unsafe bool IsSelectable {
			get {
				if (id_isSelectable == IntPtr.Zero)
					id_isSelectable = JNIEnv.GetMethodID (class_ref, "isSelectable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectable);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_withEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithEmail_Ljava_lang_String_Handler ()
		{
			if (cb_withEmail_Ljava_lang_String_ == null)
				cb_withEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithEmail_Ljava_lang_String_);
			return cb_withEmail_Ljava_lang_String_;
		}

		static IntPtr n_WithEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithEmail (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withEmail_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object WithEmail (string p0)
		{
			if (id_withEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_withEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withEmail", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_withIcon_Landroid_graphics_Bitmap_ == null)
				cb_withIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_graphics_Bitmap_);
			return cb_withIcon_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_WithIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withIcon_Landroid_graphics_Bitmap_;
		public unsafe global::Java.Lang.Object WithIcon (global::Android.Graphics.Bitmap p0)
		{
			if (id_withIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/graphics/Bitmap;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_withIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_withIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_withIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_graphics_drawable_Drawable_);
			return cb_withIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withIcon_Landroid_graphics_drawable_Drawable_;
		public unsafe global::Java.Lang.Object WithIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_withIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_withIcon_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_net_Uri_Handler ()
		{
			if (cb_withIcon_Landroid_net_Uri_ == null)
				cb_withIcon_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_net_Uri_);
			return cb_withIcon_Landroid_net_Uri_;
		}

		static IntPtr n_WithIcon_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withIcon_Landroid_net_Uri_;
		public unsafe global::Java.Lang.Object WithIcon (global::Android.Net.Uri p0)
		{
			if (id_withIcon_Landroid_net_Uri_ == IntPtr.Zero)
				id_withIcon_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/net/Uri;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler ()
		{
			if (cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == null)
				cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Lcom_mikepenz_iconics_typeface_IIcon_);
			return cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		}

		static IntPtr n_WithIcon_Lcom_mikepenz_iconics_typeface_IIcon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Iconics.Typeface.IIcon p0 = (global::Com.Mikepenz.Iconics.Typeface.IIcon)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		public unsafe global::Java.Lang.Object WithIcon (global::Com.Mikepenz.Iconics.Typeface.IIcon p0)
		{
			if (id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == IntPtr.Zero)
				id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_withIcon_I;
#pragma warning disable 0169
		static Delegate GetWithIcon_IHandler ()
		{
			if (cb_withIcon_I == null)
				cb_withIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIcon_I);
			return cb_withIcon_I;
		}

		static IntPtr n_WithIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
		}
#pragma warning restore 0169

		IntPtr id_withIcon_I;
		public unsafe global::Java.Lang.Object WithIcon (int p0)
		{
			if (id_withIcon_I == IntPtr.Zero)
				id_withIcon_I = JNIEnv.GetMethodID (class_ref, "withIcon", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_withIcon_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Ljava_lang_String_Handler ()
		{
			if (cb_withIcon_Ljava_lang_String_ == null)
				cb_withIcon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Ljava_lang_String_);
			return cb_withIcon_Ljava_lang_String_;
		}

		static IntPtr n_WithIcon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withIcon_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object WithIcon (string p0)
		{
			if (id_withIcon_Ljava_lang_String_ == IntPtr.Zero)
				id_withIcon_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithName_Ljava_lang_String_Handler ()
		{
			if (cb_withName_Ljava_lang_String_ == null)
				cb_withName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithName_Ljava_lang_String_);
			return cb_withName_Ljava_lang_String_;
		}

		static IntPtr n_WithName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withName_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object WithName (string p0)
		{
			if (id_withName_Ljava_lang_String_ == IntPtr.Zero)
				id_withName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withName", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_withSelectable_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectable_ZHandler ()
		{
			if (cb_withSelectable_Z == null)
				cb_withSelectable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectable_Z);
			return cb_withSelectable_Z;
		}

		static IntPtr n_WithSelectable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectable (p0));
		}
#pragma warning restore 0169

		IntPtr id_withSelectable_Z;
		public unsafe global::Java.Lang.Object WithSelectable (bool p0)
		{
			if (id_withSelectable_Z == IntPtr.Zero)
				id_withSelectable_Z = JNIEnv.GetMethodID (class_ref, "withSelectable", "(Z)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectable_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static long n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Identifier;
		}
#pragma warning restore 0169

		IntPtr id_getIdentifier;
		public unsafe global::System.Int64 Identifier {
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier);
			}
		}

		static Delegate cb_withIdentifier_J;
#pragma warning disable 0169
		static Delegate GetWithIdentifier_JHandler ()
		{
			if (cb_withIdentifier_J == null)
				cb_withIdentifier_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WithIdentifier_J);
			return cb_withIdentifier_J;
		}

		static IntPtr n_WithIdentifier_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIdentifier (p0));
		}
#pragma warning restore 0169

		IntPtr id_withIdentifier_J;
		public unsafe global::Java.Lang.Object WithIdentifier (long p0)
		{
			if (id_withIdentifier_J == IntPtr.Zero)
				id_withIdentifier_J = JNIEnv.GetMethodID (class_ref, "withIdentifier", "(J)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIdentifier_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
