using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.interfaces']/interface[@name='OnCheckedChangeListener']"
	[Register ("com/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener", "", "Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerInvoker")]
	public partial interface IOnCheckedChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.interfaces']/interface[@name='OnCheckedChangeListener']/method[@name='onCheckedChanged' and count(parameter)=3 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='android.widget.CompoundButton'] and parameter[3][@type='boolean']]"
		[Register ("onCheckedChanged", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/widget/CompoundButton;Z)V", "GetOnCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_ZHandler:Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerInvoker, MaterialDrawer")]
		void OnCheckedChanged (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Widget.CompoundButton p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener", DoNotGenerateAcw=true)]
	internal class IOnCheckedChangeListenerInvoker : global::Java.Lang.Object, IOnCheckedChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnCheckedChangeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnCheckedChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCheckedChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.interfaces.OnCheckedChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCheckedChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z;
#pragma warning disable 0169
		static Delegate GetOnCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_ZHandler ()
		{
			if (cb_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z == null)
				cb_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z);
			return cb_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z;
		}

		static void n_OnCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.CompoundButton p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.CompoundButton> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCheckedChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z;
		public unsafe void OnCheckedChanged (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Widget.CompoundButton p1, bool p2)
		{
			if (id_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z == IntPtr.Zero)
				id_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z = JNIEnv.GetMethodID (class_ref, "onCheckedChanged", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/widget/CompoundButton;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCheckedChanged_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_widget_CompoundButton_Z, __args);
		}

	}

	public partial class CheckedChangeEventArgs : global::System.EventArgs {

		public CheckedChangeEventArgs (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Widget.CompoundButton p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0;
		public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P0 {
			get { return p0; }
		}

		global::Android.Widget.CompoundButton p1;
		public global::Android.Widget.CompoundButton P1 {
			get { return p1; }
		}

		bool p2;
		public bool P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/interfaces/OnCheckedChangeListenerImplementor")]
	internal sealed partial class IOnCheckedChangeListenerImplementor : global::Java.Lang.Object, IOnCheckedChangeListener {

		object sender;

		public IOnCheckedChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/interfaces/OnCheckedChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CheckedChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnCheckedChanged (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Widget.CompoundButton p1, bool p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CheckedChangeEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IOnCheckedChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
