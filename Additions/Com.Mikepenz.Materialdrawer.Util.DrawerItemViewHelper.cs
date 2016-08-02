using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/DrawerItemViewHelper", DoNotGenerateAcw=true)]
	public partial class DrawerItemViewHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerItemViewHelper.OnDrawerItemClickListener']"
		[Register ("com/mikepenz/materialdrawer/util/DrawerItemViewHelper$OnDrawerItemClickListener", "", "Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper/IOnDrawerItemClickListenerInvoker")]
		public partial interface IOnDrawerItemClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/interface[@name='DrawerItemViewHelper.OnDrawerItemClickListener']/method[@name='onItemClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
			[Register ("onItemClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetOnItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler:Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper/IOnDrawerItemClickListenerInvoker, MaterialDrawer")]
			void OnItemClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p1);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/util/DrawerItemViewHelper$OnDrawerItemClickListener", DoNotGenerateAcw=true)]
		internal class IOnDrawerItemClickListenerInvoker : global::Java.Lang.Object, IOnDrawerItemClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/DrawerItemViewHelper$OnDrawerItemClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDrawerItemClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnDrawerItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDrawerItemClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.util.DrawerItemViewHelper.OnDrawerItemClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDrawerItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
			static Delegate GetOnItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
			{
				if (cb_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
					cb_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
				return cb_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			}

			static void n_OnItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper.IOnDrawerItemClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper.IOnDrawerItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnItemClick (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			public unsafe void OnItemClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p1)
			{
				if (id_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
					id_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
			}

		}

		public partial class DrawerItemClickEventArgs : global::System.EventArgs {

			public DrawerItemClickEventArgs (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p1;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/util/DrawerItemViewHelper_OnDrawerItemClickListenerImplementor")]
		internal sealed partial class IOnDrawerItemClickListenerImplementor : global::Java.Lang.Object, IOnDrawerItemClickListener {

			object sender;

			public IOnDrawerItemClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/util/DrawerItemViewHelper_OnDrawerItemClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DrawerItemClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnItemClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DrawerItemClickEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDrawerItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/util/DrawerItemViewHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawerItemViewHelper); }
		}

		protected DrawerItemViewHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']/constructor[@name='DrawerItemViewHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DrawerItemViewHelper (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrawerItemViewHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Landroid/view/View;", "GetBuildHandler")]
		public virtual unsafe global::Android.Views.View Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Landroid/view/View;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDivider_Z;
#pragma warning disable 0169
		static Delegate GetWithDivider_ZHandler ()
		{
			if (cb_withDivider_Z == null)
				cb_withDivider_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithDivider_Z);
			return cb_withDivider_Z;
		}

		static IntPtr n_WithDivider_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDivider (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDivider_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']/method[@name='withDivider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withDivider", "(Z)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;", "GetWithDivider_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper WithDivider (bool p0)
		{
			if (id_withDivider_Z == IntPtr.Zero)
				id_withDivider_Z = JNIEnv.GetMethodID (class_ref, "withDivider", "(Z)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDivider_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDivider", "(Z)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetWithDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static IntPtr n_WithDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawerItems (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']/method[@name='withDrawerItems' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem...']]"
		[Register ("withDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;", "GetWithDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper WithDrawerItems (params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0)
		{
			if (id_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "withDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_withDrawerItems_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetWithDrawerItems_Ljava_util_ArrayList_Handler ()
		{
			if (cb_withDrawerItems_Ljava_util_ArrayList_ == null)
				cb_withDrawerItems_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDrawerItems_Ljava_util_ArrayList_);
			return cb_withDrawerItems_Ljava_util_ArrayList_;
		}

		static IntPtr n_WithDrawerItems_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawerItems (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerItems_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']/method[@name='withDrawerItems' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("withDrawerItems", "(Ljava/util/ArrayList;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;", "GetWithDrawerItems_Ljava_util_ArrayList_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper WithDrawerItems (global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> p0)
		{
			if (id_withDrawerItems_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_withDrawerItems_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "withDrawerItems", "(Ljava/util/ArrayList;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerItems_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerItems", "(Ljava/util/ArrayList;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_Handler ()
		{
			if (cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_ == null)
				cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_);
			return cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_;
		}

		static IntPtr n_WithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper.IOnDrawerItemClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper.IOnDrawerItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper.IOnDrawerItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnDrawerItemClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.util']/class[@name='DrawerItemViewHelper']/method[@name='withOnDrawerItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.util.DrawerItemViewHelper.OnDrawerItemClickListener']]"
		[Register ("withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper$OnDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;", "GetWithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper WithOnDrawerItemClickListener (global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper.IOnDrawerItemClickListener p0)
		{
			if (id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_ == IntPtr.Zero)
				id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper$OnDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_util_DrawerItemViewHelper_OnDrawerItemClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Util.DrawerItemViewHelper> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper$OnDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/util/DrawerItemViewHelper;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
