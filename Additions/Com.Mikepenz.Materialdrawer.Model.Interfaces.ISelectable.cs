using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Selectable']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/Selectable", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ISelectable : IJavaObject {

		bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Selectable']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectableInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='Selectable']/method[@name='withSelectable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectable", "(Z)Ljava/lang/Object;", "GetWithSelectable_ZHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithSelectable (bool p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/Selectable", DoNotGenerateAcw=true)]
	internal class ISelectableInvoker : global::Java.Lang.Object, ISelectable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/Selectable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISelectableInvoker); }
		}

		IntPtr class_ref;

		public static ISelectable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISelectable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.Selectable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISelectableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
