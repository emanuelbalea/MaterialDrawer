using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Iconable']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/Iconable", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IIconable : IJavaObject {

		global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Iconable']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;", "GetGetIconHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconableInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Iconable']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetWithIcon_Landroid_graphics_drawable_Drawable_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Android.Graphics.Drawables.Drawable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Iconable']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
		[Register ("withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Ljava/lang/Object;", "GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Com.Mikepenz.Iconics.Typeface.IIcon p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Iconable']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.ImageHolder']]"
		[Register ("withIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Ljava/lang/Object;", "GetWithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithIcon (global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/Iconable", DoNotGenerateAcw=true)]
	internal class IIconableInvoker : global::Java.Lang.Object, IIconable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/Iconable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIconableInvoker); }
		}

		IntPtr class_ref;

		public static IIconable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIconable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.Iconable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIconableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler ()
		{
			if (cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == null)
				cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_);
			return cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		}

		static IntPtr n_WithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		public unsafe global::Java.Lang.Object WithIcon (global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0)
		{
			if (id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == IntPtr.Zero)
				id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
