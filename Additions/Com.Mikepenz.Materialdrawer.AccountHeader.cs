using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/AccountHeader", DoNotGenerateAcw=true)]
	public partial class AccountHeader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/field[@name='BUNDLE_SELECTION_HEADER']"
		[Register ("BUNDLE_SELECTION_HEADER")]
		protected const string BundleSelectionHeader = (string) "bundle_selection_header";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/field[@name='NAVIGATION_DRAWER_ACCOUNT_ASPECT_RATIO']"
		[Register ("NAVIGATION_DRAWER_ACCOUNT_ASPECT_RATIO")]
		protected const double NavigationDrawerAccountAspectRatio = (double) 0.562500000000000;

		static IntPtr mAccountHeaderBuilder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/field[@name='mAccountHeaderBuilder']"
		[Register ("mAccountHeaderBuilder")]
		protected global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder MAccountHeaderBuilder {
			get {
				if (mAccountHeaderBuilder_jfieldId == IntPtr.Zero)
					mAccountHeaderBuilder_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderBuilder", "Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountHeaderBuilder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountHeaderBuilder_jfieldId == IntPtr.Zero)
					mAccountHeaderBuilder_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderBuilder", "Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeaderBuilder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderItemLongClickListener']"
		[Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener", "", "Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderItemLongClickListenerInvoker")]
		public partial interface IOnAccountHeaderItemLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderItemLongClickListener']/method[@name='onProfileLongClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile'] and parameter[3][@type='boolean']]"
			[Register ("onProfileLongClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z", "GetOnProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler:Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderItemLongClickListenerInvoker, MaterialDrawer")]
			bool OnProfileLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnAccountHeaderItemLongClickListenerInvoker : global::Java.Lang.Object, IOnAccountHeaderItemLongClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnAccountHeaderItemLongClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnAccountHeaderItemLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAccountHeaderItemLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderItemLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAccountHeaderItemLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
#pragma warning disable 0169
			static Delegate GetOnProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler ()
			{
				if (cb_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == null)
					cb_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_OnProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z);
				return cb_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			}

			static bool n_OnProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
			{
				global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnProfileLongClick (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			public unsafe bool OnProfileLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				if (id_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == IntPtr.Zero)
					id_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNIEnv.GetMethodID (class_ref, "onProfileLongClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onProfileLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z, __args);
				return __ret;
			}

		}

		public partial class AccountHeaderItemLongClickEventArgs : global::System.EventArgs {

			public AccountHeaderItemLongClickEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
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

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile P1 {
				get { return p1; }
			}

			bool p2;
			public bool P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderItemLongClickListenerImplementor")]
		internal sealed partial class IOnAccountHeaderItemLongClickListenerImplementor : global::Java.Lang.Object, IOnAccountHeaderItemLongClickListener {

			object sender;

			public IOnAccountHeaderItemLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderItemLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AccountHeaderItemLongClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnProfileLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new AccountHeaderItemLongClickEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnAccountHeaderItemLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderListener']"
		[Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener", "", "Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderListenerInvoker")]
		public partial interface IOnAccountHeaderListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderListener']/method[@name='onProfileChanged' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile'] and parameter[3][@type='boolean']]"
			[Register ("onProfileChanged", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z", "GetOnProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler:Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderListenerInvoker, MaterialDrawer")]
			bool OnProfileChanged (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener", DoNotGenerateAcw=true)]
		internal class IOnAccountHeaderListenerInvoker : global::Java.Lang.Object, IOnAccountHeaderListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnAccountHeaderListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnAccountHeaderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAccountHeaderListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAccountHeaderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
#pragma warning disable 0169
			static Delegate GetOnProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler ()
			{
				if (cb_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == null)
					cb_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_OnProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z);
				return cb_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			}

			static bool n_OnProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
			{
				global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnProfileChanged (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			public unsafe bool OnProfileChanged (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				if (id_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == IntPtr.Zero)
					id_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNIEnv.GetMethodID (class_ref, "onProfileChanged", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onProfileChanged_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z, __args);
				return __ret;
			}

		}

		public partial class AccountHeaderEventArgs : global::System.EventArgs {

			public AccountHeaderEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
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

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile P1 {
				get { return p1; }
			}

			bool p2;
			public bool P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderListenerImplementor")]
		internal sealed partial class IOnAccountHeaderListenerImplementor : global::Java.Lang.Object, IOnAccountHeaderListener {

			object sender;

			public IOnAccountHeaderListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AccountHeaderEventArgs> Handler;
#pragma warning restore 0649

			public bool OnProfileChanged (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new AccountHeaderEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnAccountHeaderListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderProfileImageListener']"
		[Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener", "", "Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderProfileImageListenerInvoker")]
		public partial interface IOnAccountHeaderProfileImageListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderProfileImageListener']/method[@name='onProfileImageClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile'] and parameter[3][@type='boolean']]"
			[Register ("onProfileImageClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z", "GetOnProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler:Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderProfileImageListenerInvoker, MaterialDrawer")]
			bool OnProfileImageClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderProfileImageListener']/method[@name='onProfileImageLongClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile'] and parameter[3][@type='boolean']]"
			[Register ("onProfileImageLongClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z", "GetOnProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler:Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderProfileImageListenerInvoker, MaterialDrawer")]
			bool OnProfileImageLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener", DoNotGenerateAcw=true)]
		internal class IOnAccountHeaderProfileImageListenerInvoker : global::Java.Lang.Object, IOnAccountHeaderProfileImageListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnAccountHeaderProfileImageListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnAccountHeaderProfileImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAccountHeaderProfileImageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderProfileImageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAccountHeaderProfileImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
#pragma warning disable 0169
			static Delegate GetOnProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler ()
			{
				if (cb_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == null)
					cb_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_OnProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z);
				return cb_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			}

			static bool n_OnProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
			{
				global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnProfileImageClick (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			public unsafe bool OnProfileImageClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				if (id_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == IntPtr.Zero)
					id_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNIEnv.GetMethodID (class_ref, "onProfileImageClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onProfileImageClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z, __args);
				return __ret;
			}

			static Delegate cb_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
#pragma warning disable 0169
			static Delegate GetOnProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler ()
			{
				if (cb_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == null)
					cb_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_OnProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z);
				return cb_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			}

			static bool n_OnProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
			{
				global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnProfileImageLongClick (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
			public unsafe bool OnProfileImageLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				if (id_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == IntPtr.Zero)
					id_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNIEnv.GetMethodID (class_ref, "onProfileImageLongClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onProfileImageLongClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z, __args);
				return __ret;
			}

		}

		public partial class ProfileImageClickEventArgs : global::System.EventArgs {

			public ProfileImageClickEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
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

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile P1 {
				get { return p1; }
			}

			bool p2;
			public bool P2 {
				get { return p2; }
			}
		}

		public partial class ProfileImageLongClickEventArgs : global::System.EventArgs {

			public ProfileImageLongClickEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
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

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile P1 {
				get { return p1; }
			}

			bool p2;
			public bool P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderProfileImageListenerImplementor")]
		internal sealed partial class IOnAccountHeaderProfileImageListenerImplementor : global::Java.Lang.Object, IOnAccountHeaderProfileImageListener {

			object sender;

			public IOnAccountHeaderProfileImageListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderProfileImageListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ProfileImageClickEventArgs> OnProfileImageClickHandler;
#pragma warning restore 0649

			public bool OnProfileImageClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				var __h = OnProfileImageClickHandler;
				if (__h == null)
					return false;
				var __e = new ProfileImageClickEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ProfileImageLongClickEventArgs> OnProfileImageLongClickHandler;
#pragma warning restore 0649

			public bool OnProfileImageLongClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1, bool p2)
			{
				var __h = OnProfileImageLongClickHandler;
				if (__h == null)
					return false;
				var __e = new ProfileImageLongClickEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnAccountHeaderProfileImageListenerImplementor value)
			{
				return value.OnProfileImageClickHandler == null && value.OnProfileImageLongClickHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderSelectionViewClickListener']"
		[Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener", "", "Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderSelectionViewClickListenerInvoker")]
		public partial interface IOnAccountHeaderSelectionViewClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='AccountHeader.OnAccountHeaderSelectionViewClickListener']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile']]"
			[Register ("onClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Z", "GetOnClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler:Com.Mikepenz.Materialdrawer.AccountHeader/IOnAccountHeaderSelectionViewClickListenerInvoker, MaterialDrawer")]
			bool OnClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener", DoNotGenerateAcw=true)]
		internal class IOnAccountHeaderSelectionViewClickListenerInvoker : global::Java.Lang.Object, IOnAccountHeaderSelectionViewClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnAccountHeaderSelectionViewClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnAccountHeaderSelectionViewClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAccountHeaderSelectionViewClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderSelectionViewClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAccountHeaderSelectionViewClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
			{
				if (cb_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
					cb_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
				return cb_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
			}

			static bool n_OnClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnClick (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
			public unsafe bool OnClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1)
			{
				if (id_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
				return __ret;
			}

		}

		public partial class AccountHeaderSelectionViewClickEventArgs : global::System.EventArgs {

			public AccountHeaderSelectionViewClickEventArgs (bool handled, global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
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

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderSelectionViewClickListenerImplementor")]
		internal sealed partial class IOnAccountHeaderSelectionViewClickListenerImplementor : global::Java.Lang.Object, IOnAccountHeaderSelectionViewClickListener {

			object sender;

			public IOnAccountHeaderSelectionViewClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/AccountHeader_OnAccountHeaderSelectionViewClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AccountHeaderSelectionViewClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnClick (global::Android.Views.View p0, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new AccountHeaderSelectionViewClickEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnAccountHeaderSelectionViewClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/AccountHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountHeader); }
		}

		protected AccountHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mikepenz_materialdrawer_AccountHeaderBuilder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/constructor[@name='AccountHeader' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeaderBuilder']]"
		[Register (".ctor", "(Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;)V", "")]
		protected unsafe AccountHeader (global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AccountHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_materialdrawer_AccountHeaderBuilder_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_materialdrawer_AccountHeaderBuilder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_materialdrawer_AccountHeaderBuilder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_materialdrawer_AccountHeaderBuilder_, __args);
			} finally {
			}
		}

		static Delegate cb_getAccountHeaderBuilder;
#pragma warning disable 0169
		static Delegate GetGetAccountHeaderBuilderHandler ()
		{
			if (cb_getAccountHeaderBuilder == null)
				cb_getAccountHeaderBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountHeaderBuilder);
			return cb_getAccountHeaderBuilder;
		}

		static IntPtr n_GetAccountHeaderBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountHeaderBuilder);
		}
#pragma warning restore 0169

		static IntPtr id_getAccountHeaderBuilder;
		protected virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder AccountHeaderBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='getAccountHeaderBuilder' and count(parameter)=0]"
			[Register ("getAccountHeaderBuilder", "()Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetGetAccountHeaderBuilderHandler")]
			get {
				if (id_getAccountHeaderBuilder == IntPtr.Zero)
					id_getAccountHeaderBuilder = JNIEnv.GetMethodID (class_ref, "getAccountHeaderBuilder", "()Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountHeaderBuilder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountHeaderBuilder", "()Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getActiveProfile;
#pragma warning disable 0169
		static Delegate GetGetActiveProfileHandler ()
		{
			if (cb_getActiveProfile == null)
				cb_getActiveProfile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActiveProfile);
			return cb_getActiveProfile;
		}

		static IntPtr n_GetActiveProfile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActiveProfile);
		}
#pragma warning restore 0169

		static Delegate cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetSetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static void n_SetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ActiveProfile = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getActiveProfile;
		static IntPtr id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile ActiveProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='getActiveProfile' and count(parameter)=0]"
			[Register ("getActiveProfile", "()Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;", "GetGetActiveProfileHandler")]
			get {
				if (id_getActiveProfile == IntPtr.Zero)
					id_getActiveProfile = JNIEnv.GetMethodID (class_ref, "getActiveProfile", "()Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActiveProfile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveProfile", "()Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setActiveProfile' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile']]"
			[Register ("setActiveProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V", "GetSetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
			set {
				if (id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
					id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "setActiveProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderBackgroundView;
#pragma warning disable 0169
		static Delegate GetGetHeaderBackgroundViewHandler ()
		{
			if (cb_getHeaderBackgroundView == null)
				cb_getHeaderBackgroundView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderBackgroundView);
			return cb_getHeaderBackgroundView;
		}

		static IntPtr n_GetHeaderBackgroundView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderBackgroundView);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderBackgroundView;
		public virtual unsafe global::Android.Widget.ImageView HeaderBackgroundView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='getHeaderBackgroundView' and count(parameter)=0]"
			[Register ("getHeaderBackgroundView", "()Landroid/widget/ImageView;", "GetGetHeaderBackgroundViewHandler")]
			get {
				if (id_getHeaderBackgroundView == IntPtr.Zero)
					id_getHeaderBackgroundView = JNIEnv.GetMethodID (class_ref, "getHeaderBackgroundView", "()Landroid/widget/ImageView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderBackgroundView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderBackgroundView", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSelectionListShown;
#pragma warning disable 0169
		static Delegate GetIsSelectionListShownHandler ()
		{
			if (cb_isSelectionListShown == null)
				cb_isSelectionListShown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectionListShown);
			return cb_isSelectionListShown;
		}

		static bool n_IsSelectionListShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectionListShown;
		}
#pragma warning restore 0169

		static IntPtr id_isSelectionListShown;
		public virtual unsafe bool IsSelectionListShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='isSelectionListShown' and count(parameter)=0]"
			[Register ("isSelectionListShown", "()Z", "GetIsSelectionListShownHandler")]
			get {
				if (id_isSelectionListShown == IntPtr.Zero)
					id_isSelectionListShown = JNIEnv.GetMethodID (class_ref, "isSelectionListShown", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectionListShown);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelectionListShown", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getProfiles;
#pragma warning disable 0169
		static Delegate GetGetProfilesHandler ()
		{
			if (cb_getProfiles == null)
				cb_getProfiles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfiles);
			return cb_getProfiles;
		}

		static IntPtr n_GetProfiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.ToLocalJniHandle (__this.Profiles);
		}
#pragma warning restore 0169

		static Delegate cb_setProfiles_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetProfiles_Ljava_util_List_Handler ()
		{
			if (cb_setProfiles_Ljava_util_List_ == null)
				cb_setProfiles_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProfiles_Ljava_util_List_);
			return cb_setProfiles_Ljava_util_List_;
		}

		static void n_SetProfiles_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Profiles = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProfiles;
		static IntPtr id_setProfiles_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> Profiles {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='getProfiles' and count(parameter)=0]"
			[Register ("getProfiles", "()Ljava/util/List;", "GetGetProfilesHandler")]
			get {
				if (id_getProfiles == IntPtr.Zero)
					id_getProfiles = JNIEnv.GetMethodID (class_ref, "getProfiles", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfiles), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfiles", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setProfiles' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IProfile&gt;']]"
			[Register ("setProfiles", "(Ljava/util/List;)V", "GetSetProfiles_Ljava_util_List_Handler")]
			set {
				if (id_setProfiles_Ljava_util_List_ == IntPtr.Zero)
					id_setProfiles_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setProfiles", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProfiles_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProfiles", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I;
#pragma warning disable 0169
		static Delegate GetAddProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_IHandler ()
		{
			if (cb_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I == null)
				cb_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I);
			return cb_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I;
		}

		static void n_AddProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddProfile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='addProfile' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile'] and parameter[2][@type='int']]"
		[Register ("addProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;I)V", "GetAddProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_IHandler")]
		public virtual unsafe void AddProfile (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0, int p1)
		{
			if (id_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I == IntPtr.Zero)
				id_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I = JNIEnv.GetMethodID (class_ref, "addProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetAddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static void n_AddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile));
			__this.AddProfiles (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='addProfiles' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile...']]"
		[Register ("addProfiles", "([Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V", "GetAddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
		public virtual unsafe void AddProfiles (params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile[] p0)
		{
			if (id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
				id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "addProfiles", "([Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addProfiles", "([Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetRemoveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static void n_RemoveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveProfile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='removeProfile' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile']]"
		[Register ("removeProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V", "GetRemoveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
		public virtual unsafe void RemoveProfile (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0)
		{
			if (id_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
				id_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "removeProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeProfile_I;
#pragma warning disable 0169
		static Delegate GetRemoveProfile_IHandler ()
		{
			if (cb_removeProfile_I == null)
				cb_removeProfile_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveProfile_I);
			return cb_removeProfile_I;
		}

		static void n_RemoveProfile_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveProfile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeProfile_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='removeProfile' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeProfile", "(I)V", "GetRemoveProfile_IHandler")]
		public virtual unsafe void RemoveProfile (int p0)
		{
			if (id_removeProfile_I == IntPtr.Zero)
				id_removeProfile_I = JNIEnv.GetMethodID (class_ref, "removeProfile", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeProfile_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeProfile", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeProfileByIdentifier_J;
#pragma warning disable 0169
		static Delegate GetRemoveProfileByIdentifier_JHandler ()
		{
			if (cb_removeProfileByIdentifier_J == null)
				cb_removeProfileByIdentifier_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_RemoveProfileByIdentifier_J);
			return cb_removeProfileByIdentifier_J;
		}

		static void n_RemoveProfileByIdentifier_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveProfileByIdentifier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeProfileByIdentifier_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='removeProfileByIdentifier' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("removeProfileByIdentifier", "(J)V", "GetRemoveProfileByIdentifier_JHandler")]
		public virtual unsafe void RemoveProfileByIdentifier (long p0)
		{
			if (id_removeProfileByIdentifier_J == IntPtr.Zero)
				id_removeProfileByIdentifier_J = JNIEnv.GetMethodID (class_ref, "removeProfileByIdentifier", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeProfileByIdentifier_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeProfileByIdentifier", "(J)V"), __args);
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
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SaveInstanceState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='saveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static Delegate cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
#pragma warning disable 0169
		static Delegate GetSetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler ()
		{
			if (cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == null)
				cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z);
			return cb_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
		}

		static void n_SetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveProfile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setActiveProfile' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile'] and parameter[2][@type='boolean']]"
		[Register ("setActiveProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)V", "GetSetActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ZHandler")]
		public virtual unsafe void SetActiveProfile (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0, bool p1)
		{
			if (id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z == IntPtr.Zero)
				id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z = JNIEnv.GetMethodID (class_ref, "setActiveProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setActiveProfile_J;
#pragma warning disable 0169
		static Delegate GetSetActiveProfile_JHandler ()
		{
			if (cb_setActiveProfile_J == null)
				cb_setActiveProfile_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetActiveProfile_J);
			return cb_setActiveProfile_J;
		}

		static void n_SetActiveProfile_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveProfile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActiveProfile_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setActiveProfile' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setActiveProfile", "(J)V", "GetSetActiveProfile_JHandler")]
		public virtual unsafe void SetActiveProfile (long p0)
		{
			if (id_setActiveProfile_J == IntPtr.Zero)
				id_setActiveProfile_J = JNIEnv.GetMethodID (class_ref, "setActiveProfile", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveProfile_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveProfile", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setActiveProfile_JZ;
#pragma warning disable 0169
		static Delegate GetSetActiveProfile_JZHandler ()
		{
			if (cb_setActiveProfile_JZ == null)
				cb_setActiveProfile_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_SetActiveProfile_JZ);
			return cb_setActiveProfile_JZ;
		}

		static void n_SetActiveProfile_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveProfile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setActiveProfile_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setActiveProfile' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("setActiveProfile", "(JZ)V", "GetSetActiveProfile_JZHandler")]
		public virtual unsafe void SetActiveProfile (long p0, bool p1)
		{
			if (id_setActiveProfile_JZ == IntPtr.Zero)
				id_setActiveProfile_JZ = JNIEnv.GetMethodID (class_ref, "setActiveProfile", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveProfile_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveProfile", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackground_Landroid_graphics_drawable_Drawable_);
			return cb_setBackground_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackground", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackground_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackground", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundRes_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundRes_IHandler ()
		{
			if (cb_setBackgroundRes_I == null)
				cb_setBackgroundRes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundRes_I);
			return cb_setBackgroundRes_I;
		}

		static void n_SetBackgroundRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundRes (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setBackgroundRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBackgroundRes", "(I)V", "GetSetBackgroundRes_IHandler")]
		public virtual unsafe void SetBackgroundRes (int p0)
		{
			if (id_setBackgroundRes_I == IntPtr.Zero)
				id_setBackgroundRes_I = JNIEnv.GetMethodID (class_ref, "setBackgroundRes", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgroundRes_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundRes", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
#pragma warning disable 0169
		static Delegate GetSetDrawer_Lcom_mikepenz_materialdrawer_Drawer_Handler ()
		{
			if (cb_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_ == null)
				cb_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDrawer_Lcom_mikepenz_materialdrawer_Drawer_);
			return cb_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
		}

		static void n_SetDrawer_Lcom_mikepenz_materialdrawer_Drawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setDrawer' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer']]"
		[Register ("setDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)V", "GetSetDrawer_Lcom_mikepenz_materialdrawer_Drawer_Handler")]
		public virtual unsafe void SetDrawer (global::Com.Mikepenz.Materialdrawer.Drawer p0)
		{
			if (id_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_ == IntPtr.Zero)
				id_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_ = JNIEnv.GetMethodID (class_ref, "setDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDrawer_Lcom_mikepenz_materialdrawer_Drawer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
#pragma warning disable 0169
		static Delegate GetSetHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler ()
		{
			if (cb_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == null)
				cb_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_);
			return cb_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		}

		static void n_SetHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHeaderBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setHeaderBackground' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.ImageHolder']]"
		[Register ("setHeaderBackground", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)V", "GetSetHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler")]
		public virtual unsafe void SetHeaderBackground (global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0)
		{
			if (id_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == IntPtr.Zero)
				id_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNIEnv.GetMethodID (class_ref, "setHeaderBackground", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaderBackground", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectionFirstLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSelectionFirstLine_Ljava_lang_String_Handler ()
		{
			if (cb_setSelectionFirstLine_Ljava_lang_String_ == null)
				cb_setSelectionFirstLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectionFirstLine_Ljava_lang_String_);
			return cb_setSelectionFirstLine_Ljava_lang_String_;
		}

		static void n_SetSelectionFirstLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectionFirstLine (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionFirstLine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setSelectionFirstLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSelectionFirstLine", "(Ljava/lang/String;)V", "GetSetSelectionFirstLine_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSelectionFirstLine (string p0)
		{
			if (id_setSelectionFirstLine_Ljava_lang_String_ == IntPtr.Zero)
				id_setSelectionFirstLine_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSelectionFirstLine", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionFirstLine_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionFirstLine", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSelectionFirstLineShown_Z;
#pragma warning disable 0169
		static Delegate GetSetSelectionFirstLineShown_ZHandler ()
		{
			if (cb_setSelectionFirstLineShown_Z == null)
				cb_setSelectionFirstLineShown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSelectionFirstLineShown_Z);
			return cb_setSelectionFirstLineShown_Z;
		}

		static void n_SetSelectionFirstLineShown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectionFirstLineShown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionFirstLineShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setSelectionFirstLineShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSelectionFirstLineShown", "(Z)V", "GetSetSelectionFirstLineShown_ZHandler")]
		public virtual unsafe void SetSelectionFirstLineShown (bool p0)
		{
			if (id_setSelectionFirstLineShown_Z == IntPtr.Zero)
				id_setSelectionFirstLineShown_Z = JNIEnv.GetMethodID (class_ref, "setSelectionFirstLineShown", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionFirstLineShown_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionFirstLineShown", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectionSecondLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSelectionSecondLine_Ljava_lang_String_Handler ()
		{
			if (cb_setSelectionSecondLine_Ljava_lang_String_ == null)
				cb_setSelectionSecondLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectionSecondLine_Ljava_lang_String_);
			return cb_setSelectionSecondLine_Ljava_lang_String_;
		}

		static void n_SetSelectionSecondLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectionSecondLine (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionSecondLine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setSelectionSecondLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSelectionSecondLine", "(Ljava/lang/String;)V", "GetSetSelectionSecondLine_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSelectionSecondLine (string p0)
		{
			if (id_setSelectionSecondLine_Ljava_lang_String_ == IntPtr.Zero)
				id_setSelectionSecondLine_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSelectionSecondLine", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionSecondLine_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionSecondLine", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSelectionSecondLineShown_Z;
#pragma warning disable 0169
		static Delegate GetSetSelectionSecondLineShown_ZHandler ()
		{
			if (cb_setSelectionSecondLineShown_Z == null)
				cb_setSelectionSecondLineShown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSelectionSecondLineShown_Z);
			return cb_setSelectionSecondLineShown_Z;
		}

		static void n_SetSelectionSecondLineShown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectionSecondLineShown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectionSecondLineShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='setSelectionSecondLineShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSelectionSecondLineShown", "(Z)V", "GetSetSelectionSecondLineShown_ZHandler")]
		public virtual unsafe void SetSelectionSecondLineShown (bool p0)
		{
			if (id_setSelectionSecondLineShown_Z == IntPtr.Zero)
				id_setSelectionSecondLineShown_Z = JNIEnv.GetMethodID (class_ref, "setSelectionSecondLineShown", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionSecondLineShown_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionSecondLineShown", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggleSelectionList_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetToggleSelectionList_Landroid_content_Context_Handler ()
		{
			if (cb_toggleSelectionList_Landroid_content_Context_ == null)
				cb_toggleSelectionList_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToggleSelectionList_Landroid_content_Context_);
			return cb_toggleSelectionList_Landroid_content_Context_;
		}

		static void n_ToggleSelectionList_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToggleSelectionList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toggleSelectionList_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='toggleSelectionList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("toggleSelectionList", "(Landroid/content/Context;)V", "GetToggleSelectionList_Landroid_content_Context_Handler")]
		public virtual unsafe void ToggleSelectionList (global::Android.Content.Context p0)
		{
			if (id_toggleSelectionList_Landroid_content_Context_ == IntPtr.Zero)
				id_toggleSelectionList_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "toggleSelectionList", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggleSelectionList_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleSelectionList", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetUpdateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static void n_UpdateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateProfile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='updateProfile' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile']]"
		[Register ("updateProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V", "GetUpdateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
		public virtual unsafe void UpdateProfile (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0)
		{
			if (id_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
				id_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "updateProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateProfile_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateProfile", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetUpdateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static void n_UpdateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeader __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateProfileByIdentifier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeader']/method[@name='updateProfileByIdentifier' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile']]"
		[Obsolete (@"deprecated")]
		[Register ("updateProfileByIdentifier", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V", "GetUpdateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
		public virtual unsafe void UpdateProfileByIdentifier (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0)
		{
			if (id_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
				id_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "updateProfileByIdentifier", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateProfileByIdentifier_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateProfileByIdentifier", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)V"), __args);
			} finally {
			}
		}

	}
}
