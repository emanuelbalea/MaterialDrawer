using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='OnPostBindViewListener']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListenerInvoker")]
	public partial interface IOnPostBindViewListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='OnPostBindViewListener']/method[@name='onBindView' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='android.view.View']]"
		[Register ("onBindView", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/view/View;)V", "GetOnBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListenerInvoker, MaterialDrawer")]
		void OnBindView (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Views.View p1);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener", DoNotGenerateAcw=true)]
	internal class IOnPostBindViewListenerInvoker : global::Java.Lang.Object, IOnPostBindViewListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnPostBindViewListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnPostBindViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPostBindViewListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.OnPostBindViewListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPostBindViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_Handler ()
		{
			if (cb_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ == null)
				cb_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_);
			return cb_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_;
		}

		static void n_OnBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBindView (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_;
		public unsafe void OnBindView (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Views.View p1)
		{
			if (id_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ == IntPtr.Zero)
				id_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onBindView", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_, __args);
		}

	}

	public partial class PostBindViewEventArgs : global::System.EventArgs {

		public PostBindViewEventArgs (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Views.View p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0;
		public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P0 {
			get { return p0; }
		}

		global::Android.Views.View p1;
		public global::Android.Views.View P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListenerImplementor")]
	internal sealed partial class IOnPostBindViewListenerImplementor : global::Java.Lang.Object, IOnPostBindViewListener {

		object sender;

		public IOnPostBindViewListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PostBindViewEventArgs> Handler;
#pragma warning restore 0649

		public void OnBindView (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Views.View p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PostBindViewEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnPostBindViewListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
