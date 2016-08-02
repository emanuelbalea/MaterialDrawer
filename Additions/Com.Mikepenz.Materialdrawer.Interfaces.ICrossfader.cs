using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.interfaces']/interface[@name='ICrossfader']"
	[Register ("com/mikepenz/materialdrawer/interfaces/ICrossfader", "", "Com.Mikepenz.Materialdrawer.Interfaces.ICrossfaderInvoker")]
	public partial interface ICrossfader : IJavaObject {

		bool IsCrossfaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.interfaces']/interface[@name='ICrossfader']/method[@name='isCrossfaded' and count(parameter)=0]"
			[Register ("isCrossfaded", "()Z", "GetIsCrossfadedHandler:Com.Mikepenz.Materialdrawer.Interfaces.ICrossfaderInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.interfaces']/interface[@name='ICrossfader']/method[@name='crossfade' and count(parameter)=0]"
		[Register ("crossfade", "()V", "GetCrossfadeHandler:Com.Mikepenz.Materialdrawer.Interfaces.ICrossfaderInvoker, MaterialDrawer")]
		void Crossfade ();

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/interfaces/ICrossfader", DoNotGenerateAcw=true)]
	internal class ICrossfaderInvoker : global::Java.Lang.Object, ICrossfader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/interfaces/ICrossfader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICrossfaderInvoker); }
		}

		IntPtr class_ref;

		public static ICrossfader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICrossfader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.interfaces.ICrossfader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICrossfaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCrossfaded;
#pragma warning disable 0169
		static Delegate GetIsCrossfadedHandler ()
		{
			if (cb_isCrossfaded == null)
				cb_isCrossfaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCrossfaded);
			return cb_isCrossfaded;
		}

		static bool n_IsCrossfaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCrossfaded;
		}
#pragma warning restore 0169

		IntPtr id_isCrossfaded;
		public unsafe bool IsCrossfaded {
			get {
				if (id_isCrossfaded == IntPtr.Zero)
					id_isCrossfaded = JNIEnv.GetMethodID (class_ref, "isCrossfaded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCrossfaded);
			}
		}

		static Delegate cb_crossfade;
#pragma warning disable 0169
		static Delegate GetCrossfadeHandler ()
		{
			if (cb_crossfade == null)
				cb_crossfade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Crossfade);
			return cb_crossfade;
		}

		static void n_Crossfade (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Crossfade ();
		}
#pragma warning restore 0169

		IntPtr id_crossfade;
		public unsafe void Crossfade ()
		{
			if (id_crossfade == IntPtr.Zero)
				id_crossfade = JNIEnv.GetMethodID (class_ref, "crossfade", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_crossfade);
		}

	}

}
