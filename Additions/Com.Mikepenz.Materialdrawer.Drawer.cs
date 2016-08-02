using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/Drawer", DoNotGenerateAcw=true)]
	public partial class Drawer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='BUNDLE_DRAWER_CONTENT_SWITCHED']"
		[Register ("BUNDLE_DRAWER_CONTENT_SWITCHED")]
		protected const string BundleDrawerContentSwitched = (string) "bundle_drawer_content_switched";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='BUNDLE_DRAWER_CONTENT_SWITCHED_APPENDED']"
		[Register ("BUNDLE_DRAWER_CONTENT_SWITCHED_APPENDED")]
		protected const string BundleDrawerContentSwitchedAppended = (string) "bundle_drawer_content_switched_appended";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='BUNDLE_SELECTION']"
		[Register ("BUNDLE_SELECTION")]
		protected const string BundleSelection = (string) "_selection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='BUNDLE_SELECTION_APPENDED']"
		[Register ("BUNDLE_SELECTION_APPENDED")]
		protected const string BundleSelectionAppended = (string) "_selection_appended";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='BUNDLE_STICKY_FOOTER_SELECTION']"
		[Register ("BUNDLE_STICKY_FOOTER_SELECTION")]
		protected const string BundleStickyFooterSelection = (string) "bundle_sticky_footer_selection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='BUNDLE_STICKY_FOOTER_SELECTION_APPENDED']"
		[Register ("BUNDLE_STICKY_FOOTER_SELECTION_APPENDED")]
		protected const string BundleStickyFooterSelectionAppended = (string) "bundle_sticky_footer_selection_appended";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='PREF_USER_LEARNED_DRAWER']"
		[Register ("PREF_USER_LEARNED_DRAWER")]
		protected const string PrefUserLearnedDrawer = (string) "navigation_drawer_learned";

		static IntPtr mDrawerBuilder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/field[@name='mDrawerBuilder']"
		[Register ("mDrawerBuilder")]
		protected global::Com.Mikepenz.Materialdrawer.DrawerBuilder MDrawerBuilder {
			get {
				if (mDrawerBuilder_jfieldId == IntPtr.Zero)
					mDrawerBuilder_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerBuilder", "Lcom/mikepenz/materialdrawer/DrawerBuilder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDrawerBuilder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDrawerBuilder_jfieldId == IntPtr.Zero)
					mDrawerBuilder_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerBuilder", "Lcom/mikepenz/materialdrawer/DrawerBuilder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDrawerBuilder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemClickListener']"
		[Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener", "", "Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemClickListenerInvoker")]
		public partial interface IOnDrawerItemClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemClickListener']/method[@name='onItemClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
			[Register ("onItemClick", "(Landroid/view/View;ILcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z", "GetOnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemClickListenerInvoker, MaterialDrawer")]
			bool OnItemClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener", DoNotGenerateAcw=true)]
		internal class IOnDrawerItemClickListenerInvoker : global::Java.Lang.Object, IOnDrawerItemClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.Drawer.OnDrawerItemClickListener"));
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

			static Delegate cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
			static Delegate GetOnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
			{
				if (cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
					cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
				return cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			}

			static bool n_OnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnItemClick (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			public unsafe bool OnItemClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2)
			{
				if (id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
					id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Landroid/view/View;ILcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				return __ret;
			}

		}

		public partial class DrawerItemClickEventArgs : global::System.EventArgs {

			public DrawerItemClickEventArgs (bool handled, global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerItemClickListenerImplementor")]
		internal sealed partial class IOnDrawerItemClickListenerImplementor : global::Java.Lang.Object, IOnDrawerItemClickListener {

			object sender;

			public IOnDrawerItemClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerItemClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DrawerItemClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnItemClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new DrawerItemClickEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnDrawerItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemLongClickListener']"
		[Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener", "", "Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemLongClickListenerInvoker")]
		public partial interface IOnDrawerItemLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemLongClickListener']/method[@name='onItemLongClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
			[Register ("onItemLongClick", "(Landroid/view/View;ILcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z", "GetOnItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemLongClickListenerInvoker, MaterialDrawer")]
			bool OnItemLongClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnDrawerItemLongClickListenerInvoker : global::Java.Lang.Object, IOnDrawerItemLongClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDrawerItemLongClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnDrawerItemLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDrawerItemLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.Drawer.OnDrawerItemLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDrawerItemLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
			static Delegate GetOnItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
			{
				if (cb_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
					cb_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
				return cb_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			}

			static bool n_OnItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnItemLongClick (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			public unsafe bool OnItemLongClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2)
			{
				if (id_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
					id_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "onItemLongClick", "(Landroid/view/View;ILcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onItemLongClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				return __ret;
			}

		}

		public partial class DrawerItemLongClickEventArgs : global::System.EventArgs {

			public DrawerItemLongClickEventArgs (bool handled, global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerItemLongClickListenerImplementor")]
		internal sealed partial class IOnDrawerItemLongClickListenerImplementor : global::Java.Lang.Object, IOnDrawerItemLongClickListener {

			object sender;

			public IOnDrawerItemLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerItemLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DrawerItemLongClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnItemLongClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new DrawerItemLongClickEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnDrawerItemLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemSelectedListener']"
		[Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemSelectedListener", "", "Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemSelectedListenerInvoker")]
		public partial interface IOnDrawerItemSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemSelectedListener']/method[@name='onItemSelected' and count(parameter)=5 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
			[Register ("onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJLcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemSelectedListenerInvoker, MaterialDrawer")]
			void OnItemSelected (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p4);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerItemSelectedListener']/method[@name='onNothingSelected' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;']]"
			[Register ("onNothingSelected", "(Landroid/widget/AdapterView;)V", "GetOnNothingSelected_Landroid_widget_AdapterView_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerItemSelectedListenerInvoker, MaterialDrawer")]
			void OnNothingSelected (global::Android.Widget.AdapterView p0);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnDrawerItemSelectedListenerInvoker : global::Java.Lang.Object, IOnDrawerItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/Drawer$OnDrawerItemSelectedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDrawerItemSelectedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnDrawerItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDrawerItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.Drawer.OnDrawerItemSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDrawerItemSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
			static Delegate GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
			{
				if (cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
					cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long, IntPtr>) n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
				return cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			}

			static void n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3, IntPtr native_p4)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p4 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.OnItemSelected (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
			public unsafe void OnItemSelected (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p4)
			{
				if (id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
					id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJLcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
			}

			static Delegate cb_onNothingSelected_Landroid_widget_AdapterView_;
#pragma warning disable 0169
			static Delegate GetOnNothingSelected_Landroid_widget_AdapterView_Handler ()
			{
				if (cb_onNothingSelected_Landroid_widget_AdapterView_ == null)
					cb_onNothingSelected_Landroid_widget_AdapterView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNothingSelected_Landroid_widget_AdapterView_);
				return cb_onNothingSelected_Landroid_widget_AdapterView_;
			}

			static void n_OnNothingSelected_Landroid_widget_AdapterView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNothingSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNothingSelected_Landroid_widget_AdapterView_;
			public unsafe void OnNothingSelected (global::Android.Widget.AdapterView p0)
			{
				if (id_onNothingSelected_Landroid_widget_AdapterView_ == IntPtr.Zero)
					id_onNothingSelected_Landroid_widget_AdapterView_ = JNIEnv.GetMethodID (class_ref, "onNothingSelected", "(Landroid/widget/AdapterView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNothingSelected_Landroid_widget_AdapterView_, __args);
			}

		}

		public partial class ItemSelectedEventArgs : global::System.EventArgs {

			public ItemSelectedEventArgs (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			global::Android.Widget.AdapterView p0;
			public global::Android.Widget.AdapterView P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			long p3;
			public long P3 {
				get { return p3; }
			}

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p4;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P4 {
				get { return p4; }
			}
		}

		public partial class NothingSelectedEventArgs : global::System.EventArgs {

			public NothingSelectedEventArgs (global::Android.Widget.AdapterView p0)
			{
				this.p0 = p0;
			}

			global::Android.Widget.AdapterView p0;
			public global::Android.Widget.AdapterView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerItemSelectedListenerImplementor")]
		internal sealed partial class IOnDrawerItemSelectedListenerImplementor : global::Java.Lang.Object, IOnDrawerItemSelectedListener {

			object sender;

			public IOnDrawerItemSelectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerItemSelectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ItemSelectedEventArgs> OnItemSelectedHandler;
#pragma warning restore 0649

			public void OnItemSelected (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p4)
			{
				var __h = OnItemSelectedHandler;
				if (__h != null)
					__h (sender, new ItemSelectedEventArgs (p0, p1, p2, p3, p4));
			}
#pragma warning disable 0649
			public EventHandler<NothingSelectedEventArgs> OnNothingSelectedHandler;
#pragma warning restore 0649

			public void OnNothingSelected (global::Android.Widget.AdapterView p0)
			{
				var __h = OnNothingSelectedHandler;
				if (__h != null)
					__h (sender, new NothingSelectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnDrawerItemSelectedListenerImplementor value)
			{
				return value.OnItemSelectedHandler == null && value.OnNothingSelectedHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerListener']"
		[Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerListener", "", "Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerListenerInvoker")]
		public partial interface IOnDrawerListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerListener']/method[@name='onDrawerClosed' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onDrawerClosed", "(Landroid/view/View;)V", "GetOnDrawerClosed_Landroid_view_View_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerListenerInvoker, MaterialDrawer")]
			void OnDrawerClosed (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerListener']/method[@name='onDrawerOpened' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onDrawerOpened", "(Landroid/view/View;)V", "GetOnDrawerOpened_Landroid_view_View_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerListenerInvoker, MaterialDrawer")]
			void OnDrawerOpened (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerListener']/method[@name='onDrawerSlide' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
			[Register ("onDrawerSlide", "(Landroid/view/View;F)V", "GetOnDrawerSlide_Landroid_view_View_FHandler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerListenerInvoker, MaterialDrawer")]
			void OnDrawerSlide (global::Android.Views.View p0, float p1);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerListener", DoNotGenerateAcw=true)]
		internal class IOnDrawerListenerInvoker : global::Java.Lang.Object, IOnDrawerListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/Drawer$OnDrawerListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDrawerListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnDrawerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDrawerListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.Drawer.OnDrawerListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDrawerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDrawerClosed_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnDrawerClosed_Landroid_view_View_Handler ()
			{
				if (cb_onDrawerClosed_Landroid_view_View_ == null)
					cb_onDrawerClosed_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawerClosed_Landroid_view_View_);
				return cb_onDrawerClosed_Landroid_view_View_;
			}

			static void n_OnDrawerClosed_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDrawerClosed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDrawerClosed_Landroid_view_View_;
			public unsafe void OnDrawerClosed (global::Android.Views.View p0)
			{
				if (id_onDrawerClosed_Landroid_view_View_ == IntPtr.Zero)
					id_onDrawerClosed_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onDrawerClosed", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawerClosed_Landroid_view_View_, __args);
			}

			static Delegate cb_onDrawerOpened_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnDrawerOpened_Landroid_view_View_Handler ()
			{
				if (cb_onDrawerOpened_Landroid_view_View_ == null)
					cb_onDrawerOpened_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawerOpened_Landroid_view_View_);
				return cb_onDrawerOpened_Landroid_view_View_;
			}

			static void n_OnDrawerOpened_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDrawerOpened (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDrawerOpened_Landroid_view_View_;
			public unsafe void OnDrawerOpened (global::Android.Views.View p0)
			{
				if (id_onDrawerOpened_Landroid_view_View_ == IntPtr.Zero)
					id_onDrawerOpened_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onDrawerOpened", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawerOpened_Landroid_view_View_, __args);
			}

			static Delegate cb_onDrawerSlide_Landroid_view_View_F;
#pragma warning disable 0169
			static Delegate GetOnDrawerSlide_Landroid_view_View_FHandler ()
			{
				if (cb_onDrawerSlide_Landroid_view_View_F == null)
					cb_onDrawerSlide_Landroid_view_View_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_OnDrawerSlide_Landroid_view_View_F);
				return cb_onDrawerSlide_Landroid_view_View_F;
			}

			static void n_OnDrawerSlide_Landroid_view_View_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDrawerSlide (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDrawerSlide_Landroid_view_View_F;
			public unsafe void OnDrawerSlide (global::Android.Views.View p0, float p1)
			{
				if (id_onDrawerSlide_Landroid_view_View_F == IntPtr.Zero)
					id_onDrawerSlide_Landroid_view_View_F = JNIEnv.GetMethodID (class_ref, "onDrawerSlide", "(Landroid/view/View;F)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawerSlide_Landroid_view_View_F, __args);
			}

		}

		public partial class DrawerClosedEventArgs : global::System.EventArgs {

			public DrawerClosedEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		public partial class DrawerOpenedEventArgs : global::System.EventArgs {

			public DrawerOpenedEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		public partial class DrawerSlideEventArgs : global::System.EventArgs {

			public DrawerSlideEventArgs (global::Android.Views.View p0, float p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerListenerImplementor")]
		internal sealed partial class IOnDrawerListenerImplementor : global::Java.Lang.Object, IOnDrawerListener {

			object sender;

			public IOnDrawerListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DrawerClosedEventArgs> OnDrawerClosedHandler;
#pragma warning restore 0649

			public void OnDrawerClosed (global::Android.Views.View p0)
			{
				var __h = OnDrawerClosedHandler;
				if (__h != null)
					__h (sender, new DrawerClosedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<DrawerOpenedEventArgs> OnDrawerOpenedHandler;
#pragma warning restore 0649

			public void OnDrawerOpened (global::Android.Views.View p0)
			{
				var __h = OnDrawerOpenedHandler;
				if (__h != null)
					__h (sender, new DrawerOpenedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<DrawerSlideEventArgs> OnDrawerSlideHandler;
#pragma warning restore 0649

			public void OnDrawerSlide (global::Android.Views.View p0, float p1)
			{
				var __h = OnDrawerSlideHandler;
				if (__h != null)
					__h (sender, new DrawerSlideEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDrawerListenerImplementor value)
			{
				return value.OnDrawerClosedHandler == null && value.OnDrawerOpenedHandler == null && value.OnDrawerSlideHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerNavigationListener']"
		[Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener", "", "Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerNavigationListenerInvoker")]
		public partial interface IOnDrawerNavigationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='Drawer.OnDrawerNavigationListener']/method[@name='onNavigationClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onNavigationClickListener", "(Landroid/view/View;)Z", "GetOnNavigationClickListener_Landroid_view_View_Handler:Com.Mikepenz.Materialdrawer.Drawer/IOnDrawerNavigationListenerInvoker, MaterialDrawer")]
			bool OnNavigationClickListener (global::Android.Views.View p0);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener", DoNotGenerateAcw=true)]
		internal class IOnDrawerNavigationListenerInvoker : global::Java.Lang.Object, IOnDrawerNavigationListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDrawerNavigationListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnDrawerNavigationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDrawerNavigationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.Drawer.OnDrawerNavigationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDrawerNavigationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onNavigationClickListener_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnNavigationClickListener_Landroid_view_View_Handler ()
			{
				if (cb_onNavigationClickListener_Landroid_view_View_ == null)
					cb_onNavigationClickListener_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnNavigationClickListener_Landroid_view_View_);
				return cb_onNavigationClickListener_Landroid_view_View_;
			}

			static bool n_OnNavigationClickListener_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnNavigationClickListener (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onNavigationClickListener_Landroid_view_View_;
			public unsafe bool OnNavigationClickListener (global::Android.Views.View p0)
			{
				if (id_onNavigationClickListener_Landroid_view_View_ == IntPtr.Zero)
					id_onNavigationClickListener_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onNavigationClickListener", "(Landroid/view/View;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onNavigationClickListener_Landroid_view_View_, __args);
				return __ret;
			}

		}

		public partial class DrawerNavigationEventArgs : global::System.EventArgs {

			public DrawerNavigationEventArgs (bool handled, global::Android.Views.View p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerNavigationListenerImplementor")]
		internal sealed partial class IOnDrawerNavigationListenerImplementor : global::Java.Lang.Object, IOnDrawerNavigationListener {

			object sender;

			public IOnDrawerNavigationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/Drawer_OnDrawerNavigationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DrawerNavigationEventArgs> Handler;
#pragma warning restore 0649

			public bool OnNavigationClickListener (global::Android.Views.View p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new DrawerNavigationEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnDrawerNavigationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/Drawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Drawer); }
		}

		protected Drawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mikepenz_materialdrawer_DrawerBuilder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/constructor[@name='Drawer' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.DrawerBuilder']]"
		[Register (".ctor", "(Lcom/mikepenz/materialdrawer/DrawerBuilder;)V", "")]
		protected unsafe Drawer (global::Com.Mikepenz.Materialdrawer.DrawerBuilder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Drawer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/materialdrawer/DrawerBuilder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/materialdrawer/DrawerBuilder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_materialdrawer_DrawerBuilder_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_materialdrawer_DrawerBuilder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/materialdrawer/DrawerBuilder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_materialdrawer_DrawerBuilder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_materialdrawer_DrawerBuilder_, __args);
			} finally {
			}
		}

		static Delegate cb_getActionBarDrawerToggle;
#pragma warning disable 0169
		static Delegate GetGetActionBarDrawerToggleHandler ()
		{
			if (cb_getActionBarDrawerToggle == null)
				cb_getActionBarDrawerToggle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionBarDrawerToggle);
			return cb_getActionBarDrawerToggle;
		}

		static IntPtr n_GetActionBarDrawerToggle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionBarDrawerToggle);
		}
#pragma warning restore 0169

		static Delegate cb_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_;
#pragma warning disable 0169
		static Delegate GetSetActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_Handler ()
		{
			if (cb_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ == null)
				cb_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_);
			return cb_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_;
		}

		static void n_SetActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBarDrawerToggle p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBarDrawerToggle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActionBarDrawerToggle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActionBarDrawerToggle;
		static IntPtr id_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_;
		public virtual unsafe global::Android.Support.V7.App.ActionBarDrawerToggle ActionBarDrawerToggle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getActionBarDrawerToggle' and count(parameter)=0]"
			[Register ("getActionBarDrawerToggle", "()Landroid/support/v7/app/ActionBarDrawerToggle;", "GetGetActionBarDrawerToggleHandler")]
			get {
				if (id_getActionBarDrawerToggle == IntPtr.Zero)
					id_getActionBarDrawerToggle = JNIEnv.GetMethodID (class_ref, "getActionBarDrawerToggle", "()Landroid/support/v7/app/ActionBarDrawerToggle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBarDrawerToggle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActionBarDrawerToggle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBarDrawerToggle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionBarDrawerToggle", "()Landroid/support/v7/app/ActionBarDrawerToggle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setActionBarDrawerToggle' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBarDrawerToggle']]"
			[Register ("setActionBarDrawerToggle", "(Landroid/support/v7/app/ActionBarDrawerToggle;)V", "GetSetActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_Handler")]
			set {
				if (id_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ == IntPtr.Zero)
					id_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ = JNIEnv.GetMethodID (class_ref, "setActionBarDrawerToggle", "(Landroid/support/v7/app/ActionBarDrawerToggle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionBarDrawerToggle", "(Landroid/support/v7/app/ActionBarDrawerToggle;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler ()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;", "GetGetAdapterHandler")]
			get {
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID (class_ref, "getAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		public virtual unsafe global::Android.Widget.FrameLayout Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Landroid/widget/FrameLayout;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Landroid/widget/FrameLayout;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Landroid/widget/FrameLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentSelectedPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentSelectedPositionHandler ()
		{
			if (cb_getCurrentSelectedPosition == null)
				cb_getCurrentSelectedPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentSelectedPosition);
			return cb_getCurrentSelectedPosition;
		}

		static int n_GetCurrentSelectedPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSelectedPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSelectedPosition;
		public virtual unsafe int CurrentSelectedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getCurrentSelectedPosition' and count(parameter)=0]"
			[Register ("getCurrentSelectedPosition", "()I", "GetGetCurrentSelectedPositionHandler")]
			get {
				if (id_getCurrentSelectedPosition == IntPtr.Zero)
					id_getCurrentSelectedPosition = JNIEnv.GetMethodID (class_ref, "getCurrentSelectedPosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentSelectedPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSelectedPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentSelection;
#pragma warning disable 0169
		static Delegate GetGetCurrentSelectionHandler ()
		{
			if (cb_getCurrentSelection == null)
				cb_getCurrentSelection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentSelection);
			return cb_getCurrentSelection;
		}

		static long n_GetCurrentSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSelection;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSelection;
		public virtual unsafe long CurrentSelection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getCurrentSelection' and count(parameter)=0]"
			[Register ("getCurrentSelection", "()J", "GetGetCurrentSelectionHandler")]
			get {
				if (id_getCurrentSelection == IntPtr.Zero)
					id_getCurrentSelection = JNIEnv.GetMethodID (class_ref, "getCurrentSelection", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentSelection);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSelection", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentStickyFooterSelectedPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentStickyFooterSelectedPositionHandler ()
		{
			if (cb_getCurrentStickyFooterSelectedPosition == null)
				cb_getCurrentStickyFooterSelectedPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentStickyFooterSelectedPosition);
			return cb_getCurrentStickyFooterSelectedPosition;
		}

		static int n_GetCurrentStickyFooterSelectedPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentStickyFooterSelectedPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentStickyFooterSelectedPosition;
		public virtual unsafe int CurrentStickyFooterSelectedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getCurrentStickyFooterSelectedPosition' and count(parameter)=0]"
			[Register ("getCurrentStickyFooterSelectedPosition", "()I", "GetGetCurrentStickyFooterSelectedPositionHandler")]
			get {
				if (id_getCurrentStickyFooterSelectedPosition == IntPtr.Zero)
					id_getCurrentStickyFooterSelectedPosition = JNIEnv.GetMethodID (class_ref, "getCurrentStickyFooterSelectedPosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentStickyFooterSelectedPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentStickyFooterSelectedPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDrawerBuilder;
#pragma warning disable 0169
		static Delegate GetGetDrawerBuilderHandler ()
		{
			if (cb_getDrawerBuilder == null)
				cb_getDrawerBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawerBuilder);
			return cb_getDrawerBuilder;
		}

		static IntPtr n_GetDrawerBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DrawerBuilder);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawerBuilder;
		protected virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder DrawerBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getDrawerBuilder' and count(parameter)=0]"
			[Register ("getDrawerBuilder", "()Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetGetDrawerBuilderHandler")]
			get {
				if (id_getDrawerBuilder == IntPtr.Zero)
					id_getDrawerBuilder = JNIEnv.GetMethodID (class_ref, "getDrawerBuilder", "()Lcom/mikepenz/materialdrawer/DrawerBuilder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerBuilder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawerBuilder", "()Lcom/mikepenz/materialdrawer/DrawerBuilder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDrawerItems;
#pragma warning disable 0169
		static Delegate GetGetDrawerItemsHandler ()
		{
			if (cb_getDrawerItems == null)
				cb_getDrawerItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawerItems);
			return cb_getDrawerItems;
		}

		static IntPtr n_GetDrawerItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (__this.DrawerItems);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawerItems;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> DrawerItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getDrawerItems' and count(parameter)=0]"
			[Register ("getDrawerItems", "()Ljava/util/List;", "GetGetDrawerItemsHandler")]
			get {
				if (id_getDrawerItems == IntPtr.Zero)
					id_getDrawerItems = JNIEnv.GetMethodID (class_ref, "getDrawerItems", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawerItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDrawerLayout;
#pragma warning disable 0169
		static Delegate GetGetDrawerLayoutHandler ()
		{
			if (cb_getDrawerLayout == null)
				cb_getDrawerLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawerLayout);
			return cb_getDrawerLayout;
		}

		static IntPtr n_GetDrawerLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DrawerLayout);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawerLayout;
		public virtual unsafe global::Android.Support.V4.Widget.DrawerLayout DrawerLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getDrawerLayout' and count(parameter)=0]"
			[Register ("getDrawerLayout", "()Landroid/support/v4/widget/DrawerLayout;", "GetGetDrawerLayoutHandler")]
			get {
				if (id_getDrawerLayout == IntPtr.Zero)
					id_getDrawerLayout = JNIEnv.GetMethodID (class_ref, "getDrawerLayout", "()Landroid/support/v4/widget/DrawerLayout;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.Widget.DrawerLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V4.Widget.DrawerLayout> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawerLayout", "()Landroid/support/v4/widget/DrawerLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFooter;
#pragma warning disable 0169
		static Delegate GetGetFooterHandler ()
		{
			if (cb_getFooter == null)
				cb_getFooter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFooter);
			return cb_getFooter;
		}

		static IntPtr n_GetFooter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Footer);
		}
#pragma warning restore 0169

		static IntPtr id_getFooter;
		public virtual unsafe global::Android.Views.View Footer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getFooter' and count(parameter)=0]"
			[Register ("getFooter", "()Landroid/view/View;", "GetGetFooterHandler")]
			get {
				if (id_getFooter == IntPtr.Zero)
					id_getFooter = JNIEnv.GetMethodID (class_ref, "getFooter", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFooter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooter", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterAdapter;
#pragma warning disable 0169
		static Delegate GetGetFooterAdapterHandler ()
		{
			if (cb_getFooterAdapter == null)
				cb_getFooterAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFooterAdapter);
			return cb_getFooterAdapter;
		}

		static IntPtr n_GetFooterAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FooterAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getFooterAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.FooterAdapter FooterAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getFooterAdapter' and count(parameter)=0]"
			[Register ("getFooterAdapter", "()Lcom/mikepenz/fastadapter/adapters/FooterAdapter;", "GetGetFooterAdapterHandler")]
			get {
				if (id_getFooterAdapter == IntPtr.Zero)
					id_getFooterAdapter = JNIEnv.GetMethodID (class_ref, "getFooterAdapter", "()Lcom/mikepenz/fastadapter/adapters/FooterAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FooterAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFooterAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FooterAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterAdapter", "()Lcom/mikepenz/fastadapter/adapters/FooterAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static Delegate cb_setHeader_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Landroid_view_View_Handler ()
		{
			if (cb_setHeader_Landroid_view_View_ == null)
				cb_setHeader_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeader_Landroid_view_View_);
			return cb_setHeader_Landroid_view_View_;
		}

		static void n_SetHeader_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Header = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		static IntPtr id_setHeader_Landroid_view_View_;
		public virtual unsafe global::Android.Views.View Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Landroid/view/View;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setHeader' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setHeader", "(Landroid/view/View;)V", "GetSetHeader_Landroid_view_View_Handler")]
			set {
				if (id_setHeader_Landroid_view_View_ == IntPtr.Zero)
					id_setHeader_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderAdapter;
#pragma warning disable 0169
		static Delegate GetGetHeaderAdapterHandler ()
		{
			if (cb_getHeaderAdapter == null)
				cb_getHeaderAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderAdapter);
			return cb_getHeaderAdapter;
		}

		static IntPtr n_GetHeaderAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.HeaderAdapter HeaderAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getHeaderAdapter' and count(parameter)=0]"
			[Register ("getHeaderAdapter", "()Lcom/mikepenz/fastadapter/adapters/HeaderAdapter;", "GetGetHeaderAdapterHandler")]
			get {
				if (id_getHeaderAdapter == IntPtr.Zero)
					id_getHeaderAdapter = JNIEnv.GetMethodID (class_ref, "getHeaderAdapter", "()Lcom/mikepenz/fastadapter/adapters/HeaderAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.HeaderAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.HeaderAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderAdapter", "()Lcom/mikepenz/fastadapter/adapters/HeaderAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawerOpen;
#pragma warning disable 0169
		static Delegate GetIsDrawerOpenHandler ()
		{
			if (cb_isDrawerOpen == null)
				cb_isDrawerOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawerOpen);
			return cb_isDrawerOpen;
		}

		static bool n_IsDrawerOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawerOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isDrawerOpen;
		public virtual unsafe bool IsDrawerOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='isDrawerOpen' and count(parameter)=0]"
			[Register ("isDrawerOpen", "()Z", "GetIsDrawerOpenHandler")]
			get {
				if (id_isDrawerOpen == IntPtr.Zero)
					id_isDrawerOpen = JNIEnv.GetMethodID (class_ref, "isDrawerOpen", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawerOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrawerOpen", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getItemAdapter;
#pragma warning disable 0169
		static Delegate GetGetItemAdapterHandler ()
		{
			if (cb_getItemAdapter == null)
				cb_getItemAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItemAdapter);
			return cb_getItemAdapter;
		}

		static IntPtr n_GetItemAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getItemAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter ItemAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getItemAdapter' and count(parameter)=0]"
			[Register ("getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetGetItemAdapterHandler")]
			get {
				if (id_getItemAdapter == IntPtr.Zero)
					id_getItemAdapter = JNIEnv.GetMethodID (class_ref, "getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaterialize;
#pragma warning disable 0169
		static Delegate GetGetMaterializeHandler ()
		{
			if (cb_getMaterialize == null)
				cb_getMaterialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaterialize);
			return cb_getMaterialize;
		}

		static IntPtr n_GetMaterialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Materialize);
		}
#pragma warning restore 0169

		static IntPtr id_getMaterialize;
		public virtual unsafe global::Com.Mikepenz.Materialize.Materialize Materialize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getMaterialize' and count(parameter)=0]"
			[Register ("getMaterialize", "()Lcom/mikepenz/materialize/Materialize;", "GetGetMaterializeHandler")]
			get {
				if (id_getMaterialize == IntPtr.Zero)
					id_getMaterialize = JNIEnv.GetMethodID (class_ref, "getMaterialize", "()Lcom/mikepenz/materialize/Materialize;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialize.Materialize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaterialize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialize.Materialize> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaterialize", "()Lcom/mikepenz/materialize/Materialize;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMiniDrawer;
#pragma warning disable 0169
		static Delegate GetGetMiniDrawerHandler ()
		{
			if (cb_getMiniDrawer == null)
				cb_getMiniDrawer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiniDrawer);
			return cb_getMiniDrawer;
		}

		static IntPtr n_GetMiniDrawer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MiniDrawer);
		}
#pragma warning restore 0169

		static IntPtr id_getMiniDrawer;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer MiniDrawer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getMiniDrawer' and count(parameter)=0]"
			[Register ("getMiniDrawer", "()Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetGetMiniDrawerHandler")]
			get {
				if (id_getMiniDrawer == IntPtr.Zero)
					id_getMiniDrawer = JNIEnv.GetMethodID (class_ref, "getMiniDrawer", "()Lcom/mikepenz/materialdrawer/MiniDrawer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiniDrawer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiniDrawer", "()Lcom/mikepenz/materialdrawer/MiniDrawer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnDrawerItemClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnDrawerItemClickListenerHandler ()
		{
			if (cb_getOnDrawerItemClickListener == null)
				cb_getOnDrawerItemClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDrawerItemClickListener);
			return cb_getOnDrawerItemClickListener;
		}

		static IntPtr n_GetOnDrawerItemClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDrawerItemClickListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Handler ()
		{
			if (cb_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ == null)
				cb_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_);
			return cb_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
		}

		static void n_SetOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawerItemClickListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnDrawerItemClickListener;
		static IntPtr id_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener OnDrawerItemClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getOnDrawerItemClickListener' and count(parameter)=0]"
			[Register ("getOnDrawerItemClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;", "GetGetOnDrawerItemClickListenerHandler")]
			get {
				if (id_getOnDrawerItemClickListener == IntPtr.Zero)
					id_getOnDrawerItemClickListener = JNIEnv.GetMethodID (class_ref, "getOnDrawerItemClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnDrawerItemClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnDrawerItemClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setOnDrawerItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemClickListener']]"
			[Register ("setOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)V", "GetSetOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Handler")]
			set {
				if (id_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ == IntPtr.Zero)
					id_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnDrawerItemLongClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnDrawerItemLongClickListenerHandler ()
		{
			if (cb_getOnDrawerItemLongClickListener == null)
				cb_getOnDrawerItemLongClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDrawerItemLongClickListener);
			return cb_getOnDrawerItemLongClickListener;
		}

		static IntPtr n_GetOnDrawerItemLongClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDrawerItemLongClickListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Handler ()
		{
			if (cb_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ == null)
				cb_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_);
			return cb_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_;
		}

		static void n_SetOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawerItemLongClickListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnDrawerItemLongClickListener;
		static IntPtr id_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener OnDrawerItemLongClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getOnDrawerItemLongClickListener' and count(parameter)=0]"
			[Register ("getOnDrawerItemLongClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;", "GetGetOnDrawerItemLongClickListenerHandler")]
			get {
				if (id_getOnDrawerItemLongClickListener == IntPtr.Zero)
					id_getOnDrawerItemLongClickListener = JNIEnv.GetMethodID (class_ref, "getOnDrawerItemLongClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnDrawerItemLongClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnDrawerItemLongClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setOnDrawerItemLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemLongClickListener']]"
			[Register ("setOnDrawerItemLongClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;)V", "GetSetOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Handler")]
			set {
				if (id_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ == IntPtr.Zero)
					id_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnDrawerItemLongClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDrawerItemLongClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnDrawerNavigationListener;
#pragma warning disable 0169
		static Delegate GetGetOnDrawerNavigationListenerHandler ()
		{
			if (cb_getOnDrawerNavigationListener == null)
				cb_getOnDrawerNavigationListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDrawerNavigationListener);
			return cb_getOnDrawerNavigationListener;
		}

		static IntPtr n_GetOnDrawerNavigationListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDrawerNavigationListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_Handler ()
		{
			if (cb_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ == null)
				cb_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_);
			return cb_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_;
		}

		static void n_SetOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawerNavigationListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnDrawerNavigationListener;
		static IntPtr id_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener OnDrawerNavigationListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getOnDrawerNavigationListener' and count(parameter)=0]"
			[Register ("getOnDrawerNavigationListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;", "GetGetOnDrawerNavigationListenerHandler")]
			get {
				if (id_getOnDrawerNavigationListener == IntPtr.Zero)
					id_getOnDrawerNavigationListener = JNIEnv.GetMethodID (class_ref, "getOnDrawerNavigationListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnDrawerNavigationListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnDrawerNavigationListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setOnDrawerNavigationListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerNavigationListener']]"
			[Register ("setOnDrawerNavigationListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;)V", "GetSetOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_Handler")]
			set {
				if (id_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ == IntPtr.Zero)
					id_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ = JNIEnv.GetMethodID (class_ref, "setOnDrawerNavigationListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDrawerNavigationListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOriginalDrawerItems;
#pragma warning disable 0169
		static Delegate GetGetOriginalDrawerItemsHandler ()
		{
			if (cb_getOriginalDrawerItems == null)
				cb_getOriginalDrawerItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginalDrawerItems);
			return cb_getOriginalDrawerItems;
		}

		static IntPtr n_GetOriginalDrawerItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (__this.OriginalDrawerItems);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalDrawerItems;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> OriginalDrawerItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getOriginalDrawerItems' and count(parameter)=0]"
			[Register ("getOriginalDrawerItems", "()Ljava/util/List;", "GetGetOriginalDrawerItemsHandler")]
			get {
				if (id_getOriginalDrawerItems == IntPtr.Zero)
					id_getOriginalDrawerItems = JNIEnv.GetMethodID (class_ref, "getOriginalDrawerItems", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalDrawerItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalDrawerItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRecyclerView;
#pragma warning disable 0169
		static Delegate GetGetRecyclerViewHandler ()
		{
			if (cb_getRecyclerView == null)
				cb_getRecyclerView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecyclerView);
			return cb_getRecyclerView;
		}

		static IntPtr n_GetRecyclerView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecyclerView);
		}
#pragma warning restore 0169

		static IntPtr id_getRecyclerView;
		public virtual unsafe global::Android.Support.V7.Widget.RecyclerView RecyclerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getRecyclerView' and count(parameter)=0]"
			[Register ("getRecyclerView", "()Landroid/support/v7/widget/RecyclerView;", "GetGetRecyclerViewHandler")]
			get {
				if (id_getRecyclerView == IntPtr.Zero)
					id_getRecyclerView = JNIEnv.GetMethodID (class_ref, "getRecyclerView", "()Landroid/support/v7/widget/RecyclerView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRecyclerView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecyclerView", "()Landroid/support/v7/widget/RecyclerView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSlider;
#pragma warning disable 0169
		static Delegate GetGetSliderHandler ()
		{
			if (cb_getSlider == null)
				cb_getSlider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSlider);
			return cb_getSlider;
		}

		static IntPtr n_GetSlider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Slider);
		}
#pragma warning restore 0169

		static IntPtr id_getSlider;
		public virtual unsafe global::Com.Mikepenz.Materialize.View.ScrimInsetsRelativeLayout Slider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getSlider' and count(parameter)=0]"
			[Register ("getSlider", "()Lcom/mikepenz/materialize/view/ScrimInsetsRelativeLayout;", "GetGetSliderHandler")]
			get {
				if (id_getSlider == IntPtr.Zero)
					id_getSlider = JNIEnv.GetMethodID (class_ref, "getSlider", "()Lcom/mikepenz/materialize/view/ScrimInsetsRelativeLayout;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialize.View.ScrimInsetsRelativeLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSlider), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialize.View.ScrimInsetsRelativeLayout> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSlider", "()Lcom/mikepenz/materialize/view/ScrimInsetsRelativeLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStickyFooter;
#pragma warning disable 0169
		static Delegate GetGetStickyFooterHandler ()
		{
			if (cb_getStickyFooter == null)
				cb_getStickyFooter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStickyFooter);
			return cb_getStickyFooter;
		}

		static IntPtr n_GetStickyFooter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StickyFooter);
		}
#pragma warning restore 0169

		static IntPtr id_getStickyFooter;
		public virtual unsafe global::Android.Views.View StickyFooter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getStickyFooter' and count(parameter)=0]"
			[Register ("getStickyFooter", "()Landroid/view/View;", "GetGetStickyFooterHandler")]
			get {
				if (id_getStickyFooter == IntPtr.Zero)
					id_getStickyFooter = JNIEnv.GetMethodID (class_ref, "getStickyFooter", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStickyFooter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStickyFooter", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStickyHeader;
#pragma warning disable 0169
		static Delegate GetGetStickyHeaderHandler ()
		{
			if (cb_getStickyHeader == null)
				cb_getStickyHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStickyHeader);
			return cb_getStickyHeader;
		}

		static IntPtr n_GetStickyHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StickyHeader);
		}
#pragma warning restore 0169

		static IntPtr id_getStickyHeader;
		public virtual unsafe global::Android.Views.View StickyHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getStickyHeader' and count(parameter)=0]"
			[Register ("getStickyHeader", "()Landroid/view/View;", "GetGetStickyHeaderHandler")]
			get {
				if (id_getStickyHeader == IntPtr.Zero)
					id_getStickyHeader = JNIEnv.GetMethodID (class_ref, "getStickyHeader", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStickyHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStickyHeader", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetAddItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static void n_AddItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='addItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("addItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetAddItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe void AddItem (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "addItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetAddItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
		{
			if (cb_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
				cb_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
			return cb_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		}

		static void n_AddItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddItemAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='addItemAtPosition' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='int']]"
		[Register ("addItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V", "GetAddItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler")]
		public virtual unsafe void AddItemAtPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, int p1)
		{
			if (id_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
				id_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "addItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetAddItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static void n_AddItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem));
			__this.AddItems (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='addItems' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem...']]"
		[Register ("addItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetAddItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe void AddItems (params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0)
		{
			if (id_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "addItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetAddItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static void n_AddItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem));
			__this.AddItemsAtPosition (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='addItemsAtPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem...']]"
		[Register ("addItemsAtPosition", "(I[Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetAddItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe void AddItemsAtPosition (int p0, params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p1)
		{
			if (id_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "addItemsAtPosition", "(I[Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addItemsAtPosition_IarrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItemsAtPosition", "(I[Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetAddStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static void n_AddStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddStickyFooterItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='addStickyFooterItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("addStickyFooterItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetAddStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe void AddStickyFooterItem (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "addStickyFooterItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addStickyFooterItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetAddStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
		{
			if (cb_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
				cb_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
			return cb_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		}

		static void n_AddStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddStickyFooterItemAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='addStickyFooterItemAtPosition' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='int']]"
		[Register ("addStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V", "GetAddStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler")]
		public virtual unsafe void AddStickyFooterItemAtPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, int p1)
		{
			if (id_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
				id_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "addStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_closeDrawer;
#pragma warning disable 0169
		static Delegate GetCloseDrawerHandler ()
		{
			if (cb_closeDrawer == null)
				cb_closeDrawer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseDrawer);
			return cb_closeDrawer;
		}

		static void n_CloseDrawer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseDrawer ();
		}
#pragma warning restore 0169

		static IntPtr id_closeDrawer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='closeDrawer' and count(parameter)=0]"
		[Register ("closeDrawer", "()V", "GetCloseDrawerHandler")]
		public virtual unsafe void CloseDrawer ()
		{
			if (id_closeDrawer == IntPtr.Zero)
				id_closeDrawer = JNIEnv.GetMethodID (class_ref, "closeDrawer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeDrawer);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeDrawer", "()V"));
			} finally {
			}
		}

		static Delegate cb_deselect;
#pragma warning disable 0169
		static Delegate GetDeselectHandler ()
		{
			if (cb_deselect == null)
				cb_deselect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Deselect);
			return cb_deselect;
		}

		static void n_Deselect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deselect ();
		}
#pragma warning restore 0169

		static IntPtr id_deselect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='deselect' and count(parameter)=0]"
		[Register ("deselect", "()V", "GetDeselectHandler")]
		public virtual unsafe void Deselect ()
		{
			if (id_deselect == IntPtr.Zero)
				id_deselect = JNIEnv.GetMethodID (class_ref, "deselect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselect", "()V"));
			} finally {
			}
		}

		static Delegate cb_deselect_J;
#pragma warning disable 0169
		static Delegate GetDeselect_JHandler ()
		{
			if (cb_deselect_J == null)
				cb_deselect_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Deselect_J);
			return cb_deselect_J;
		}

		static void n_Deselect_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deselect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deselect_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='deselect' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("deselect", "(J)V", "GetDeselect_JHandler")]
		public virtual unsafe void Deselect (long p0)
		{
			if (id_deselect_J == IntPtr.Zero)
				id_deselect_J = JNIEnv.GetMethodID (class_ref, "deselect", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselect_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselect", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDrawerItem_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetDrawerItem_Ljava_lang_Object_Handler ()
		{
			if (cb_getDrawerItem_Ljava_lang_Object_ == null)
				cb_getDrawerItem_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDrawerItem_Ljava_lang_Object_);
			return cb_getDrawerItem_Ljava_lang_Object_;
		}

		static IntPtr n_GetDrawerItem_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawerItem (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDrawerItem_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getDrawerItem' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getDrawerItem", "(Ljava/lang/Object;)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;", "GetGetDrawerItem_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem GetDrawerItem (global::Java.Lang.Object p0)
		{
			if (id_getDrawerItem_Ljava_lang_Object_ == IntPtr.Zero)
				id_getDrawerItem_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getDrawerItem", "(Ljava/lang/Object;)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerItem_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawerItem", "(Ljava/lang/Object;)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getDrawerItem_J;
#pragma warning disable 0169
		static Delegate GetGetDrawerItem_JHandler ()
		{
			if (cb_getDrawerItem_J == null)
				cb_getDrawerItem_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetDrawerItem_J);
			return cb_getDrawerItem_J;
		}

		static IntPtr n_GetDrawerItem_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawerItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDrawerItem_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getDrawerItem' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDrawerItem", "(J)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;", "GetGetDrawerItem_JHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem GetDrawerItem (long p0)
		{
			if (id_getDrawerItem_J == IntPtr.Zero)
				id_getDrawerItem_J = JNIEnv.GetMethodID (class_ref, "getDrawerItem", "(J)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerItem_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawerItem", "(J)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetGetPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static int n_GetPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("getPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I", "GetGetPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe int GetPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "getPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPosition_J;
#pragma warning disable 0169
		static Delegate GetGetPosition_JHandler ()
		{
			if (cb_getPosition_J == null)
				cb_getPosition_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_GetPosition_J);
			return cb_getPosition_J;
		}

		static int n_GetPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPosition_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getPosition", "(J)I", "GetGetPosition_JHandler")]
		public virtual unsafe int GetPosition (long p0)
		{
			if (id_getPosition_J == IntPtr.Zero)
				id_getPosition_J = JNIEnv.GetMethodID (class_ref, "getPosition", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosition_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "(J)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetGetStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static int n_GetStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetStickyFooterPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getStickyFooterPosition' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("getStickyFooterPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I", "GetGetStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe int GetStickyFooterPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "getStickyFooterPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStickyFooterPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStickyFooterPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getStickyFooterPosition_J;
#pragma warning disable 0169
		static Delegate GetGetStickyFooterPosition_JHandler ()
		{
			if (cb_getStickyFooterPosition_J == null)
				cb_getStickyFooterPosition_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_GetStickyFooterPosition_J);
			return cb_getStickyFooterPosition_J;
		}

		static int n_GetStickyFooterPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStickyFooterPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getStickyFooterPosition_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='getStickyFooterPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getStickyFooterPosition", "(J)I", "GetGetStickyFooterPosition_JHandler")]
		public virtual unsafe int GetStickyFooterPosition (long p0)
		{
			if (id_getStickyFooterPosition_J == IntPtr.Zero)
				id_getStickyFooterPosition_J = JNIEnv.GetMethodID (class_ref, "getStickyFooterPosition", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStickyFooterPosition_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStickyFooterPosition", "(J)I"), __args);
			} finally {
			}
		}

		static Delegate cb_openDrawer;
#pragma warning disable 0169
		static Delegate GetOpenDrawerHandler ()
		{
			if (cb_openDrawer == null)
				cb_openDrawer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OpenDrawer);
			return cb_openDrawer;
		}

		static void n_OpenDrawer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenDrawer ();
		}
#pragma warning restore 0169

		static IntPtr id_openDrawer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='openDrawer' and count(parameter)=0]"
		[Register ("openDrawer", "()V", "GetOpenDrawerHandler")]
		public virtual unsafe void OpenDrawer ()
		{
			if (id_openDrawer == IntPtr.Zero)
				id_openDrawer = JNIEnv.GetMethodID (class_ref, "openDrawer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openDrawer);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDrawer", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllItems;
#pragma warning disable 0169
		static Delegate GetRemoveAllItemsHandler ()
		{
			if (cb_removeAllItems == null)
				cb_removeAllItems = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllItems);
			return cb_removeAllItems;
		}

		static void n_RemoveAllItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllItems ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeAllItems' and count(parameter)=0]"
		[Register ("removeAllItems", "()V", "GetRemoveAllItemsHandler")]
		public virtual unsafe void RemoveAllItems ()
		{
			if (id_removeAllItems == IntPtr.Zero)
				id_removeAllItems = JNIEnv.GetMethodID (class_ref, "removeAllItems", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllItems);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllItems", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllStickyFooterItems;
#pragma warning disable 0169
		static Delegate GetRemoveAllStickyFooterItemsHandler ()
		{
			if (cb_removeAllStickyFooterItems == null)
				cb_removeAllStickyFooterItems = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllStickyFooterItems);
			return cb_removeAllStickyFooterItems;
		}

		static void n_RemoveAllStickyFooterItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllStickyFooterItems ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllStickyFooterItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeAllStickyFooterItems' and count(parameter)=0]"
		[Register ("removeAllStickyFooterItems", "()V", "GetRemoveAllStickyFooterItemsHandler")]
		public virtual unsafe void RemoveAllStickyFooterItems ()
		{
			if (id_removeAllStickyFooterItems == IntPtr.Zero)
				id_removeAllStickyFooterItems = JNIEnv.GetMethodID (class_ref, "removeAllStickyFooterItems", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllStickyFooterItems);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllStickyFooterItems", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeHeader;
#pragma warning disable 0169
		static Delegate GetRemoveHeaderHandler ()
		{
			if (cb_removeHeader == null)
				cb_removeHeader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveHeader);
			return cb_removeHeader;
		}

		static void n_RemoveHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHeader ();
		}
#pragma warning restore 0169

		static IntPtr id_removeHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeHeader' and count(parameter)=0]"
		[Register ("removeHeader", "()V", "GetRemoveHeaderHandler")]
		public virtual unsafe void RemoveHeader ()
		{
			if (id_removeHeader == IntPtr.Zero)
				id_removeHeader = JNIEnv.GetMethodID (class_ref, "removeHeader", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeHeader);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeader", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeItem_J;
#pragma warning disable 0169
		static Delegate GetRemoveItem_JHandler ()
		{
			if (cb_removeItem_J == null)
				cb_removeItem_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_RemoveItem_J);
			return cb_removeItem_J;
		}

		static void n_RemoveItem_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeItem_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeItem' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("removeItem", "(J)V", "GetRemoveItem_JHandler")]
		public virtual unsafe void RemoveItem (long p0)
		{
			if (id_removeItem_J == IntPtr.Zero)
				id_removeItem_J = JNIEnv.GetMethodID (class_ref, "removeItem", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeItem_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItem", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeItemByPosition_I;
#pragma warning disable 0169
		static Delegate GetRemoveItemByPosition_IHandler ()
		{
			if (cb_removeItemByPosition_I == null)
				cb_removeItemByPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveItemByPosition_I);
			return cb_removeItemByPosition_I;
		}

		static void n_RemoveItemByPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveItemByPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeItemByPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeItemByPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeItemByPosition", "(I)V", "GetRemoveItemByPosition_IHandler")]
		public virtual unsafe void RemoveItemByPosition (int p0)
		{
			if (id_removeItemByPosition_I == IntPtr.Zero)
				id_removeItemByPosition_I = JNIEnv.GetMethodID (class_ref, "removeItemByPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeItemByPosition_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItemByPosition", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeItems_arrayJ;
#pragma warning disable 0169
		static Delegate GetRemoveItems_arrayJHandler ()
		{
			if (cb_removeItems_arrayJ == null)
				cb_removeItems_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveItems_arrayJ);
			return cb_removeItems_arrayJ;
		}

		static void n_RemoveItems_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			long[] p0 = (long[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.RemoveItems (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeItems_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeItems' and count(parameter)=1 and parameter[1][@type='long...']]"
		[Register ("removeItems", "([J)V", "GetRemoveItems_arrayJHandler")]
		public virtual unsafe void RemoveItems (params  long[] p0)
		{
			if (id_removeItems_arrayJ == IntPtr.Zero)
				id_removeItems_arrayJ = JNIEnv.GetMethodID (class_ref, "removeItems", "([J)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeItems_arrayJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItems", "([J)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_removeStickyFooterItemAtPosition_I;
#pragma warning disable 0169
		static Delegate GetRemoveStickyFooterItemAtPosition_IHandler ()
		{
			if (cb_removeStickyFooterItemAtPosition_I == null)
				cb_removeStickyFooterItemAtPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveStickyFooterItemAtPosition_I);
			return cb_removeStickyFooterItemAtPosition_I;
		}

		static void n_RemoveStickyFooterItemAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStickyFooterItemAtPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeStickyFooterItemAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='removeStickyFooterItemAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeStickyFooterItemAtPosition", "(I)V", "GetRemoveStickyFooterItemAtPosition_IHandler")]
		public virtual unsafe void RemoveStickyFooterItemAtPosition (int p0)
		{
			if (id_removeStickyFooterItemAtPosition_I == IntPtr.Zero)
				id_removeStickyFooterItemAtPosition_I = JNIEnv.GetMethodID (class_ref, "removeStickyFooterItemAtPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeStickyFooterItemAtPosition_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeStickyFooterItemAtPosition", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_resetDrawerContent;
#pragma warning disable 0169
		static Delegate GetResetDrawerContentHandler ()
		{
			if (cb_resetDrawerContent == null)
				cb_resetDrawerContent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetDrawerContent);
			return cb_resetDrawerContent;
		}

		static void n_ResetDrawerContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetDrawerContent ();
		}
#pragma warning restore 0169

		static IntPtr id_resetDrawerContent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='resetDrawerContent' and count(parameter)=0]"
		[Register ("resetDrawerContent", "()V", "GetResetDrawerContentHandler")]
		public virtual unsafe void ResetDrawerContent ()
		{
			if (id_resetDrawerContent == IntPtr.Zero)
				id_resetDrawerContent = JNIEnv.GetMethodID (class_ref, "resetDrawerContent", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetDrawerContent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetDrawerContent", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveInstanceState_Landroid_os_Bundle_ == null)
				cb_saveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveInstanceState_Landroid_os_Bundle_);
			return cb_saveInstanceState_Landroid_os_Bundle_;
		}

		static IntPtr n_SaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SaveInstanceState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='saveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveInstanceState", "(Landroid/os/Bundle;)Landroid/os/Bundle;", "GetSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Android.OS.Bundle SaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_saveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "saveInstanceState", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.Bundle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveInstanceState_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveInstanceState", "(Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setFullscreen_Z;
#pragma warning disable 0169
		static Delegate GetSetFullscreen_ZHandler ()
		{
			if (cb_setFullscreen_Z == null)
				cb_setFullscreen_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFullscreen_Z);
			return cb_setFullscreen_Z;
		}

		static void n_SetFullscreen_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFullscreen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFullscreen_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setFullscreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFullscreen", "(Z)V", "GetSetFullscreen_ZHandler")]
		public virtual unsafe void SetFullscreen (bool p0)
		{
			if (id_setFullscreen_Z == IntPtr.Zero)
				id_setFullscreen_Z = JNIEnv.GetMethodID (class_ref, "setFullscreen", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFullscreen_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullscreen", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHeader_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetSetHeader_Landroid_view_View_ZHandler ()
		{
			if (cb_setHeader_Landroid_view_View_Z == null)
				cb_setHeader_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetHeader_Landroid_view_View_Z);
			return cb_setHeader_Landroid_view_View_Z;
		}

		static void n_SetHeader_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Landroid_view_View_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("setHeader", "(Landroid/view/View;Z)V", "GetSetHeader_Landroid_view_View_ZHandler")]
		public virtual unsafe void SetHeader (global::Android.Views.View p0, bool p1)
		{
			if (id_setHeader_Landroid_view_View_Z == IntPtr.Zero)
				id_setHeader_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "setHeader", "(Landroid/view/View;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Landroid_view_View_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Landroid/view/View;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHeader_Landroid_view_View_ZZ;
#pragma warning disable 0169
		static Delegate GetSetHeader_Landroid_view_View_ZZHandler ()
		{
			if (cb_setHeader_Landroid_view_View_ZZ == null)
				cb_setHeader_Landroid_view_View_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_SetHeader_Landroid_view_View_ZZ);
			return cb_setHeader_Landroid_view_View_ZZ;
		}

		static void n_SetHeader_Landroid_view_View_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Landroid_view_View_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setHeader' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("setHeader", "(Landroid/view/View;ZZ)V", "GetSetHeader_Landroid_view_View_ZZHandler")]
		public virtual unsafe void SetHeader (global::Android.Views.View p0, bool p1, bool p2)
		{
			if (id_setHeader_Landroid_view_View_ZZ == IntPtr.Zero)
				id_setHeader_Landroid_view_View_ZZ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Landroid/view/View;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Landroid_view_View_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Landroid/view/View;ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_Handler ()
		{
			if (cb_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_ == null)
				cb_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_SetHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_);
			return cb_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_;
		}

		static void n_SetHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2, IntPtr native_p3)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p3 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setHeader' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='com.mikepenz.materialdrawer.holder.DimenHolder']]"
		[Register ("setHeader", "(Landroid/view/View;ZZLcom/mikepenz/materialdrawer/holder/DimenHolder;)V", "GetSetHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_Handler")]
		public virtual unsafe void SetHeader (global::Android.Views.View p0, bool p1, bool p2, global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p3)
		{
			if (id_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_ == IntPtr.Zero)
				id_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Landroid/view/View;ZZLcom/mikepenz/materialdrawer/holder/DimenHolder;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Landroid_view_View_ZZLcom_mikepenz_materialdrawer_holder_DimenHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Landroid/view/View;ZZLcom/mikepenz/materialdrawer/holder/DimenHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetSetItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
		{
			if (cb_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
				cb_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
			return cb_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		}

		static void n_SetItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetItemAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setItemAtPosition' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='int']]"
		[Register ("setItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V", "GetSetItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler")]
		public virtual unsafe void SetItemAtPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, int p1)
		{
			if (id_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
				id_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "setItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetItems_Ljava_util_List_Handler ()
		{
			if (cb_setItems_Ljava_util_List_ == null)
				cb_setItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetItems_Ljava_util_List_);
			return cb_setItems_Ljava_util_List_;
		}

		static void n_SetItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetItems (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setItems_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setItems' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("setItems", "(Ljava/util/List;)V", "GetSetItems_Ljava_util_List_Handler")]
		public virtual unsafe void SetItems (global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> p0)
		{
			if (id_setItems_Ljava_util_List_ == IntPtr.Zero)
				id_setItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setItems", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItems_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItems", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetSetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static bool n_SetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSelection (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("setSelection", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z", "GetSetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe bool SetSelection (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "setSelection", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z;
#pragma warning disable 0169
		static Delegate GetSetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ZHandler ()
		{
			if (cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z == null)
				cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_SetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z);
			return cb_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z;
		}

		static bool n_SetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSelection (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setSelection' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='boolean']]"
		[Register ("setSelection", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Z)Z", "GetSetSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ZHandler")]
		public virtual unsafe bool SetSelection (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, bool p1)
		{
			if (id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z == IntPtr.Zero)
				id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z = JNIEnv.GetMethodID (class_ref, "setSelection", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Z)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setSelection_J;
#pragma warning disable 0169
		static Delegate GetSetSelection_JHandler ()
		{
			if (cb_setSelection_J == null)
				cb_setSelection_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SetSelection_J);
			return cb_setSelection_J;
		}

		static bool n_SetSelection_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSelection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setSelection", "(J)Z", "GetSetSelection_JHandler")]
		public virtual unsafe bool SetSelection (long p0)
		{
			if (id_setSelection_J == IntPtr.Zero)
				id_setSelection_J = JNIEnv.GetMethodID (class_ref, "setSelection", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelection_JZ;
#pragma warning disable 0169
		static Delegate GetSetSelection_JZHandler ()
		{
			if (cb_setSelection_JZ == null)
				cb_setSelection_JZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool, bool>) n_SetSelection_JZ);
			return cb_setSelection_JZ;
		}

		static bool n_SetSelection_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSelection (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setSelection' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setSelection", "(JZ)Z", "GetSetSelection_JZHandler")]
		public virtual unsafe bool SetSelection (long p0, bool p1)
		{
			if (id_setSelection_JZ == IntPtr.Zero)
				id_setSelection_JZ = JNIEnv.GetMethodID (class_ref, "setSelection", "(JZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_JZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(JZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectionAtPosition_I;
#pragma warning disable 0169
		static Delegate GetSetSelectionAtPosition_IHandler ()
		{
			if (cb_setSelectionAtPosition_I == null)
				cb_setSelectionAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetSelectionAtPosition_I);
			return cb_setSelectionAtPosition_I;
		}

		static bool n_SetSelectionAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSelectionAtPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setSelectionAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectionAtPosition", "(I)Z", "GetSetSelectionAtPosition_IHandler")]
		public virtual unsafe bool SetSelectionAtPosition (int p0)
		{
			if (id_setSelectionAtPosition_I == IntPtr.Zero)
				id_setSelectionAtPosition_I = JNIEnv.GetMethodID (class_ref, "setSelectionAtPosition", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionAtPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionAtPosition", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectionAtPosition_IZ;
#pragma warning disable 0169
		static Delegate GetSetSelectionAtPosition_IZHandler ()
		{
			if (cb_setSelectionAtPosition_IZ == null)
				cb_setSelectionAtPosition_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool>) n_SetSelectionAtPosition_IZ);
			return cb_setSelectionAtPosition_IZ;
		}

		static bool n_SetSelectionAtPosition_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetSelectionAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionAtPosition_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setSelectionAtPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setSelectionAtPosition", "(IZ)Z", "GetSetSelectionAtPosition_IZHandler")]
		public virtual unsafe bool SetSelectionAtPosition (int p0, bool p1)
		{
			if (id_setSelectionAtPosition_IZ == IntPtr.Zero)
				id_setSelectionAtPosition_IZ = JNIEnv.GetMethodID (class_ref, "setSelectionAtPosition", "(IZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionAtPosition_IZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionAtPosition", "(IZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetSetStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
		{
			if (cb_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
				cb_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
			return cb_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		}

		static void n_SetStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStickyFooterItemAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setStickyFooterItemAtPosition' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='int']]"
		[Register ("setStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V", "GetSetStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler")]
		public virtual unsafe void SetStickyFooterItemAtPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, int p1)
		{
			if (id_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
				id_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "setStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStickyFooterSelection_JZ;
#pragma warning disable 0169
		static Delegate GetSetStickyFooterSelection_JZHandler ()
		{
			if (cb_setStickyFooterSelection_JZ == null)
				cb_setStickyFooterSelection_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_SetStickyFooterSelection_JZ);
			return cb_setStickyFooterSelection_JZ;
		}

		static void n_SetStickyFooterSelection_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStickyFooterSelection (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setStickyFooterSelection_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setStickyFooterSelection' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setStickyFooterSelection", "(JZ)V", "GetSetStickyFooterSelection_JZHandler")]
		public virtual unsafe void SetStickyFooterSelection (long p0, bool p1)
		{
			if (id_setStickyFooterSelection_JZ == IntPtr.Zero)
				id_setStickyFooterSelection_JZ = JNIEnv.GetMethodID (class_ref, "setStickyFooterSelection", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStickyFooterSelection_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStickyFooterSelection", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStickyFooterSelectionAtPosition_I;
#pragma warning disable 0169
		static Delegate GetSetStickyFooterSelectionAtPosition_IHandler ()
		{
			if (cb_setStickyFooterSelectionAtPosition_I == null)
				cb_setStickyFooterSelectionAtPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStickyFooterSelectionAtPosition_I);
			return cb_setStickyFooterSelectionAtPosition_I;
		}

		static void n_SetStickyFooterSelectionAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStickyFooterSelectionAtPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStickyFooterSelectionAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setStickyFooterSelectionAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStickyFooterSelectionAtPosition", "(I)V", "GetSetStickyFooterSelectionAtPosition_IHandler")]
		public virtual unsafe void SetStickyFooterSelectionAtPosition (int p0)
		{
			if (id_setStickyFooterSelectionAtPosition_I == IntPtr.Zero)
				id_setStickyFooterSelectionAtPosition_I = JNIEnv.GetMethodID (class_ref, "setStickyFooterSelectionAtPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStickyFooterSelectionAtPosition_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStickyFooterSelectionAtPosition", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStickyFooterSelectionAtPosition_IZ;
#pragma warning disable 0169
		static Delegate GetSetStickyFooterSelectionAtPosition_IZHandler ()
		{
			if (cb_setStickyFooterSelectionAtPosition_IZ == null)
				cb_setStickyFooterSelectionAtPosition_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetStickyFooterSelectionAtPosition_IZ);
			return cb_setStickyFooterSelectionAtPosition_IZ;
		}

		static void n_SetStickyFooterSelectionAtPosition_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStickyFooterSelectionAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setStickyFooterSelectionAtPosition_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setStickyFooterSelectionAtPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setStickyFooterSelectionAtPosition", "(IZ)V", "GetSetStickyFooterSelectionAtPosition_IZHandler")]
		public virtual unsafe void SetStickyFooterSelectionAtPosition (int p0, bool p1)
		{
			if (id_setStickyFooterSelectionAtPosition_IZ == IntPtr.Zero)
				id_setStickyFooterSelectionAtPosition_IZ = JNIEnv.GetMethodID (class_ref, "setStickyFooterSelectionAtPosition", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStickyFooterSelectionAtPosition_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStickyFooterSelectionAtPosition", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_;
#pragma warning disable 0169
		static Delegate GetSetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Handler ()
		{
			if (cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ == null)
				cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_);
			return cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_;
		}

		static void n_SetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.Toolbar p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.Toolbar> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetToolbar (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setToolbar' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.support.v7.widget.Toolbar']]"
		[Register ("setToolbar", "(Landroid/app/Activity;Landroid/support/v7/widget/Toolbar;)V", "GetSetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Handler")]
		public virtual unsafe void SetToolbar (global::Android.App.Activity p0, global::Android.Support.V7.Widget.Toolbar p1)
		{
			if (id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ == IntPtr.Zero)
				id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ = JNIEnv.GetMethodID (class_ref, "setToolbar", "(Landroid/app/Activity;Landroid/support/v7/widget/Toolbar;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToolbar", "(Landroid/app/Activity;Landroid/support/v7/widget/Toolbar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z;
#pragma warning disable 0169
		static Delegate GetSetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ZHandler ()
		{
			if (cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z == null)
				cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z);
			return cb_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z;
		}

		static void n_SetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.Toolbar p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.Toolbar> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetToolbar (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='setToolbar' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.support.v7.widget.Toolbar'] and parameter[3][@type='boolean']]"
		[Register ("setToolbar", "(Landroid/app/Activity;Landroid/support/v7/widget/Toolbar;Z)V", "GetSetToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_ZHandler")]
		public virtual unsafe void SetToolbar (global::Android.App.Activity p0, global::Android.Support.V7.Widget.Toolbar p1, bool p2)
		{
			if (id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z == IntPtr.Zero)
				id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z = JNIEnv.GetMethodID (class_ref, "setToolbar", "(Landroid/app/Activity;Landroid/support/v7/widget/Toolbar;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToolbar_Landroid_app_Activity_Landroid_support_v7_widget_Toolbar_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToolbar", "(Landroid/app/Activity;Landroid/support/v7/widget/Toolbar;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I;
#pragma warning disable 0169
		static Delegate GetSwitchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_IHandler ()
		{
			if (cb_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I == null)
				cb_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SwitchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I);
			return cb_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I;
		}

		static void n_SwitchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener p1 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SwitchDrawerContent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='switchDrawerContent' and count(parameter)=4 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemClickListener'] and parameter[2][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemLongClickListener'] and parameter[3][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;'] and parameter[4][@type='int']]"
		[Register ("switchDrawerContent", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;Ljava/util/List;I)V", "GetSwitchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_IHandler")]
		public virtual unsafe void SwitchDrawerContent (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener p1, global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> p2, int p3)
		{
			if (id_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I == IntPtr.Zero)
				id_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I = JNIEnv.GetMethodID (class_ref, "switchDrawerContent", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;Ljava/util/List;I)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_switchDrawerContent_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Ljava_util_List_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchDrawerContent", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;Ljava/util/List;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_switchedDrawerContent;
#pragma warning disable 0169
		static Delegate GetSwitchedDrawerContentHandler ()
		{
			if (cb_switchedDrawerContent == null)
				cb_switchedDrawerContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SwitchedDrawerContent);
			return cb_switchedDrawerContent;
		}

		static bool n_SwitchedDrawerContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwitchedDrawerContent ();
		}
#pragma warning restore 0169

		static IntPtr id_switchedDrawerContent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='switchedDrawerContent' and count(parameter)=0]"
		[Register ("switchedDrawerContent", "()Z", "GetSwitchedDrawerContentHandler")]
		public virtual unsafe bool SwitchedDrawerContent ()
		{
			if (id_switchedDrawerContent == IntPtr.Zero)
				id_switchedDrawerContent = JNIEnv.GetMethodID (class_ref, "switchedDrawerContent", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_switchedDrawerContent);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchedDrawerContent", "()Z"));
			} finally {
			}
		}

		static Delegate cb_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_;
#pragma warning disable 0169
		static Delegate GetUpdateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_Handler ()
		{
			if (cb_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_ == null)
				cb_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_);
			return cb_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_;
		}

		static void n_UpdateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBadge (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateBadge' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.mikepenz.materialdrawer.holder.StringHolder']]"
		[Register ("updateBadge", "(JLcom/mikepenz/materialdrawer/holder/StringHolder;)V", "GetUpdateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_Handler")]
		public virtual unsafe void UpdateBadge (long p0, global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p1)
		{
			if (id_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_ == IntPtr.Zero)
				id_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_ = JNIEnv.GetMethodID (class_ref, "updateBadge", "(JLcom/mikepenz/materialdrawer/holder/StringHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBadge_JLcom_mikepenz_materialdrawer_holder_StringHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateBadge", "(JLcom/mikepenz/materialdrawer/holder/StringHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_;
#pragma warning disable 0169
		static Delegate GetUpdateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_Handler ()
		{
			if (cb_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_ == null)
				cb_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_);
			return cb_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_;
		}

		static void n_UpdateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateIcon (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateIcon' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.mikepenz.materialdrawer.holder.ImageHolder']]"
		[Register ("updateIcon", "(JLcom/mikepenz/materialdrawer/holder/ImageHolder;)V", "GetUpdateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_Handler")]
		public virtual unsafe void UpdateIcon (long p0, global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p1)
		{
			if (id_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_ == IntPtr.Zero)
				id_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNIEnv.GetMethodID (class_ref, "updateIcon", "(JLcom/mikepenz/materialdrawer/holder/ImageHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateIcon_JLcom_mikepenz_materialdrawer_holder_ImageHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateIcon", "(JLcom/mikepenz/materialdrawer/holder/ImageHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetUpdateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static void n_UpdateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("updateItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetUpdateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe void UpdateItem (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "updateItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetUpdateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
		{
			if (cb_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
				cb_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_UpdateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
			return cb_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		}

		static void n_UpdateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateItemAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateItemAtPosition' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='int']]"
		[Register ("updateItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V", "GetUpdateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler")]
		public virtual unsafe void UpdateItemAtPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, int p1)
		{
			if (id_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
				id_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "updateItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_;
#pragma warning disable 0169
		static Delegate GetUpdateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_Handler ()
		{
			if (cb_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_ == null)
				cb_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_);
			return cb_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_;
		}

		static void n_UpdateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateName (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateName' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.mikepenz.materialdrawer.holder.StringHolder']]"
		[Register ("updateName", "(JLcom/mikepenz/materialdrawer/holder/StringHolder;)V", "GetUpdateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_Handler")]
		public virtual unsafe void UpdateName (long p0, global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p1)
		{
			if (id_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_ == IntPtr.Zero)
				id_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_ = JNIEnv.GetMethodID (class_ref, "updateName", "(JLcom/mikepenz/materialdrawer/holder/StringHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateName_JLcom_mikepenz_materialdrawer_holder_StringHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateName", "(JLcom/mikepenz/materialdrawer/holder/StringHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetUpdateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static void n_UpdateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStickyFooterItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateStickyFooterItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("updateStickyFooterItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V", "GetUpdateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe void UpdateStickyFooterItem (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "updateStickyFooterItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStickyFooterItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStickyFooterItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetUpdateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
		{
			if (cb_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
				cb_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_UpdateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
			return cb_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		}

		static void n_UpdateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStickyFooterItemAtPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='Drawer']/method[@name='updateStickyFooterItemAtPosition' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='int']]"
		[Register ("updateStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V", "GetUpdateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler")]
		public virtual unsafe void UpdateStickyFooterItemAtPosition (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, int p1)
		{
			if (id_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
				id_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "updateStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStickyFooterItemAtPosition_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStickyFooterItemAtPosition", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener"
		public event EventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.DrawerItemClickEventArgs> DrawerItemClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListenerImplementor>(
						ref weak_implementor___SetOnDrawerItemClickListener,
						__CreateIOnDrawerItemClickListenerImplementor,
						__v => OnDrawerItemClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListenerImplementor>(
						ref weak_implementor___SetOnDrawerItemClickListener,
						global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListenerImplementor.__IsEmpty,
						__v => OnDrawerItemClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDrawerItemClickListener;

		global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListenerImplementor __CreateIOnDrawerItemClickListenerImplementor ()
		{
			return new global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener"
		public event EventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.DrawerItemLongClickEventArgs> DrawerItemLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListenerImplementor>(
						ref weak_implementor___SetOnDrawerItemLongClickListener,
						__CreateIOnDrawerItemLongClickListenerImplementor,
						__v => OnDrawerItemLongClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListenerImplementor>(
						ref weak_implementor___SetOnDrawerItemLongClickListener,
						global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListenerImplementor.__IsEmpty,
						__v => OnDrawerItemLongClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDrawerItemLongClickListener;

		global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListenerImplementor __CreateIOnDrawerItemLongClickListenerImplementor ()
		{
			return new global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener"
		public event EventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.DrawerNavigationEventArgs> DrawerNavigation {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListenerImplementor>(
						ref weak_implementor___SetOnDrawerNavigationListener,
						__CreateIOnDrawerNavigationListenerImplementor,
						__v => OnDrawerNavigationListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener, global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListenerImplementor>(
						ref weak_implementor___SetOnDrawerNavigationListener,
						global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListenerImplementor.__IsEmpty,
						__v => OnDrawerNavigationListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDrawerNavigationListener;

		global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListenerImplementor __CreateIOnDrawerNavigationListenerImplementor ()
		{
			return new global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListenerImplementor (this);
		}
#endregion
	}
}
