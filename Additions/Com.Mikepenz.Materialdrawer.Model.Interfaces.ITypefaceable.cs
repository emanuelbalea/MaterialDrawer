using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Typefaceable']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/Typefaceable", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITypefaceable : IJavaObject {

		global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Typefaceable']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceableInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Typefaceable']/method[@name='withTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("withTypeface", "(Landroid/graphics/Typeface;)Ljava/lang/Object;", "GetWithTypeface_Landroid_graphics_Typeface_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithTypeface (global::Android.Graphics.Typeface p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/Typefaceable", DoNotGenerateAcw=true)]
	internal class ITypefaceableInvoker : global::Java.Lang.Object, ITypefaceable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/Typefaceable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITypefaceableInvoker); }
		}

		IntPtr class_ref;

		public static ITypefaceable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypefaceable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.Typefaceable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypefaceableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		IntPtr id_getTypeface;
		public unsafe global::Android.Graphics.Typeface Typeface {
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_withTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetWithTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_withTypeface_Landroid_graphics_Typeface_ == null)
				cb_withTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTypeface_Landroid_graphics_Typeface_);
			return cb_withTypeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_WithTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withTypeface_Landroid_graphics_Typeface_;
		public unsafe global::Java.Lang.Object WithTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_withTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_withTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "withTypeface", "(Landroid/graphics/Typeface;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTypeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
