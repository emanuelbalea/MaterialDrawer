using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ColorHolder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/holder/ColorHolder", DoNotGenerateAcw=true)]
	public partial class ColorHolder : global::Com.Mikepenz.Materialize.Holder.ColorHolder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/holder/ColorHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorHolder); }
		}

		protected ColorHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ColorHolder']/constructor[@name='ColorHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ColorHolder)) {
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

		static IntPtr id_fromColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ColorHolder']/method[@name='fromColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromColor", "(I)Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "")]
		public static unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder FromColor (int p0)
		{
			if (id_fromColor_I == IntPtr.Zero)
				id_fromColor_I = JNIEnv.GetStaticMethodID (class_ref, "fromColor", "(I)Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromColor_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='ColorHolder']/method[@name='fromColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "")]
		public static unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder FromColorRes (int p0)
		{
			if (id_fromColorRes_I == IntPtr.Zero)
				id_fromColorRes_I = JNIEnv.GetStaticMethodID (class_ref, "fromColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
