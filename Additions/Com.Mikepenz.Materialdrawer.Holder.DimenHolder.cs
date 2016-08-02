using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='DimenHolder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/holder/DimenHolder", DoNotGenerateAcw=true)]
	public partial class DimenHolder : global::Com.Mikepenz.Materialize.Holder.DimenHolder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/holder/DimenHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DimenHolder); }
		}

		protected DimenHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='DimenHolder']/constructor[@name='DimenHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DimenHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DimenHolder)) {
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

		static IntPtr id_fromDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='DimenHolder']/method[@name='fromDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromDp", "(I)Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "")]
		public static unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder FromDp (int p0)
		{
			if (id_fromDp_I == IntPtr.Zero)
				id_fromDp_I = JNIEnv.GetStaticMethodID (class_ref, "fromDp", "(I)Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromDp_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromPixel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='DimenHolder']/method[@name='fromPixel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromPixel", "(I)Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "")]
		public static unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder FromPixel (int p0)
		{
			if (id_fromPixel_I == IntPtr.Zero)
				id_fromPixel_I = JNIEnv.GetStaticMethodID (class_ref, "fromPixel", "(I)Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromPixel_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fromResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='DimenHolder']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "")]
		public static unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder FromResource (int p0)
		{
			if (id_fromResource_I == IntPtr.Zero)
				id_fromResource_I = JNIEnv.GetStaticMethodID (class_ref, "fromResource", "(I)Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromResource_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
