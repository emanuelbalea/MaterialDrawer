using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Tagable']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/Tagable", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITagable : IJavaObject {

		global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Tagable']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagableInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Tagable']/method[@name='withTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("withTag", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetWithTag_Ljava_lang_Object_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithTag (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/Tagable", DoNotGenerateAcw=true)]
	internal class ITagableInvoker : global::Java.Lang.Object, ITagable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/Tagable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITagableInvoker); }
		}

		IntPtr class_ref;

		public static ITagable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITagable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.Tagable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITagableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag);
		}
#pragma warning restore 0169

		IntPtr id_getTag;
		public unsafe global::Java.Lang.Object Tag {
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_withTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWithTag_Ljava_lang_Object_Handler ()
		{
			if (cb_withTag_Ljava_lang_Object_ == null)
				cb_withTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTag_Ljava_lang_Object_);
			return cb_withTag_Ljava_lang_Object_;
		}

		static IntPtr n_WithTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withTag_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object WithTag (global::Java.Lang.Object p0)
		{
			if (id_withTag_Ljava_lang_Object_ == IntPtr.Zero)
				id_withTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "withTag", "(Ljava/lang/Object;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
