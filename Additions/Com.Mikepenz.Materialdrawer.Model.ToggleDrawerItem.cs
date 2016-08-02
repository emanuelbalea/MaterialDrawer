using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ToggleDrawerItem", DoNotGenerateAcw=true)]
	public partial class ToggleDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem {

//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ToggleDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ToggleDrawerItem$ItemFactory", ref java_class_handle);
//				}
//			}

//			protected override IntPtr ThresholdClass {
//				get { return class_ref; }
//			}

//			protected override global::System.Type ThresholdType {
//				get { return typeof (ItemFactory); }
//			}

//			protected ItemFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

//			static IntPtr id_ctor;
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem.ItemFactory']/constructor[@name='ToggleDrawerItem.ItemFactory' and count(parameter)=0]"
//			[Register (".ctor", "()V", "")]
//			public unsafe ItemFactory ()
//				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
//			{
//				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
//					return;

//				try {
//					if (GetType () != typeof (ItemFactory)) {
//						SetHandle (
//								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
//								JniHandleOwnership.TransferLocalRef);
//						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
//						return;
//					}

//					if (id_ctor == IntPtr.Zero)
//						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
//					SetHandle (
//							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
//							JniHandleOwnership.TransferLocalRef);
//					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
//				} finally {
//				}
//			}

//			static Delegate cb_create_Landroid_view_View_;
//#pragma warning disable 0169
//			static Delegate GetCreate_Landroid_view_View_Handler ()
//			{
//				if (cb_create_Landroid_view_View_ == null)
//					cb_create_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Landroid_view_View_);
//				return cb_create_Landroid_view_View_;
//			}

//			static IntPtr n_Create_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//			{
//				global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder {

			protected ViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ToggleDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToggleDrawerItem); }
		}

		protected ToggleDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/constructor[@name='ToggleDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ToggleDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ToggleDrawerItem)) {
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

		static Delegate cb_isChecked;
#pragma warning disable 0169
		static Delegate GetIsCheckedHandler ()
		{
			if (cb_isChecked == null)
				cb_isChecked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChecked);
			return cb_isChecked;
		}

		static bool n_IsChecked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Checked;
		}
#pragma warning restore 0169

		static Delegate cb_setChecked_Z;
#pragma warning disable 0169
		static Delegate GetSetChecked_ZHandler ()
		{
			if (cb_setChecked_Z == null)
				cb_setChecked_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetChecked_Z);
			return cb_setChecked_Z;
		}

		static void n_SetChecked_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Checked = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isChecked;
		static IntPtr id_setChecked_Z;
		public virtual unsafe bool Checked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='isChecked' and count(parameter)=0]"
			[Register ("isChecked", "()Z", "GetIsCheckedHandler")]
			get {
				if (id_isChecked == IntPtr.Zero)
					id_isChecked = JNIEnv.GetMethodID (class_ref, "isChecked", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChecked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChecked", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='setChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setChecked", "(Z)V", "GetSetChecked_ZHandler")]
			set {
				if (id_setChecked_Z == IntPtr.Zero)
					id_setChecked_Z = JNIEnv.GetMethodID (class_ref, "setChecked", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChecked_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChecked", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFactory;
#pragma warning disable 0169
		static Delegate GetGetFactoryHandler ()
		{
			if (cb_getFactory == null)
				cb_getFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFactory);
			return cb_getFactory;
		}

		static IntPtr n_GetFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
			[Register ("getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;", "GetGetFactoryHandler")]
			get {
				if (id_getFactory == IntPtr.Zero)
					id_getFactory = JNIEnv.GetMethodID (class_ref, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLayoutRes;
#pragma warning disable 0169
		static Delegate GetGetLayoutResHandler ()
		{
			if (cb_getLayoutRes == null)
				cb_getLayoutRes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayoutRes);
			return cb_getLayoutRes;
		}

		static int n_GetLayoutRes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register ("getLayoutRes", "()I", "GetGetLayoutResHandler")]
			get {
				if (id_getLayoutRes == IntPtr.Zero)
					id_getLayoutRes = JNIEnv.GetMethodID (class_ref, "getLayoutRes", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayoutRes);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayoutRes", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOnCheckedChangeListener;
#pragma warning disable 0169
		static Delegate GetGetOnCheckedChangeListenerHandler ()
		{
			if (cb_getOnCheckedChangeListener == null)
				cb_getOnCheckedChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnCheckedChangeListener);
			return cb_getOnCheckedChangeListener;
		}

		static IntPtr n_GetOnCheckedChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCheckedChangeListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_Handler ()
		{
			if (cb_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ == null)
				cb_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_);
			return cb_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
		}

		static void n_SetOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener p0 = (global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCheckedChangeListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnCheckedChangeListener;
		static IntPtr id_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener OnCheckedChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='getOnCheckedChangeListener' and count(parameter)=0]"
			[Register ("getOnCheckedChangeListener", "()Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;", "GetGetOnCheckedChangeListenerHandler")]
			get {
				if (id_getOnCheckedChangeListener == IntPtr.Zero)
					id_getOnCheckedChangeListener = JNIEnv.GetMethodID (class_ref, "getOnCheckedChangeListener", "()Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnCheckedChangeListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnCheckedChangeListener", "()Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='setOnCheckedChangeListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.interfaces.OnCheckedChangeListener']]"
			[Register ("setOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)V", "GetSetOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_Handler")]
			set {
				if (id_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ == IntPtr.Zero)
					id_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isToggleEnabled;
#pragma warning disable 0169
		static Delegate GetIsToggleEnabledHandler ()
		{
			if (cb_isToggleEnabled == null)
				cb_isToggleEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsToggleEnabled);
			return cb_isToggleEnabled;
		}

		static bool n_IsToggleEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToggleEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setToggleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetToggleEnabled_ZHandler ()
		{
			if (cb_setToggleEnabled_Z == null)
				cb_setToggleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetToggleEnabled_Z);
			return cb_setToggleEnabled_Z;
		}

		static void n_SetToggleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isToggleEnabled;
		static IntPtr id_setToggleEnabled_Z;
		public virtual unsafe bool ToggleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='isToggleEnabled' and count(parameter)=0]"
			[Register ("isToggleEnabled", "()Z", "GetIsToggleEnabledHandler")]
			get {
				if (id_isToggleEnabled == IntPtr.Zero)
					id_isToggleEnabled = JNIEnv.GetMethodID (class_ref, "isToggleEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isToggleEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isToggleEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='setToggleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setToggleEnabled", "(Z)V", "GetSetToggleEnabled_ZHandler")]
			set {
				if (id_setToggleEnabled_Z == IntPtr.Zero)
					id_setToggleEnabled_Z = JNIEnv.GetMethodID (class_ref, "setToggleEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToggleEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToggleEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.ToggleDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_ToggleDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withChecked_Z;
#pragma warning disable 0169
		static Delegate GetWithChecked_ZHandler ()
		{
			if (cb_withChecked_Z == null)
				cb_withChecked_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithChecked_Z);
			return cb_withChecked_Z;
		}

		static IntPtr n_WithChecked_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithChecked (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withChecked_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='withChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withChecked", "(Z)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;", "GetWithChecked_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem WithChecked (bool p0)
		{
			if (id_withChecked_Z == IntPtr.Zero)
				id_withChecked_Z = JNIEnv.GetMethodID (class_ref, "withChecked", "(Z)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withChecked_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withChecked", "(Z)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
#pragma warning disable 0169
		static Delegate GetWithOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_Handler ()
		{
			if (cb_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ == null)
				cb_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_);
			return cb_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
		}

		static IntPtr n_WithOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener p0 = (global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnCheckedChangeListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='withOnCheckedChangeListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.interfaces.OnCheckedChangeListener']]"
		[Register ("withOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;", "GetWithOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem WithOnCheckedChangeListener (global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener p0)
		{
			if (id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ == IntPtr.Zero)
				id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ = JNIEnv.GetMethodID (class_ref, "withOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withToggleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithToggleEnabled_ZHandler ()
		{
			if (cb_withToggleEnabled_Z == null)
				cb_withToggleEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithToggleEnabled_Z);
			return cb_withToggleEnabled_Z;
		}

		static IntPtr n_WithToggleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithToggleEnabled (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withToggleEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ToggleDrawerItem']/method[@name='withToggleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withToggleEnabled", "(Z)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;", "GetWithToggleEnabled_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem WithToggleEnabled (bool p0)
		{
			if (id_withToggleEnabled_Z == IntPtr.Zero)
				id_withToggleEnabled_Z = JNIEnv.GetMethodID (class_ref, "withToggleEnabled", "(Z)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withToggleEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ToggleDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withToggleEnabled", "(Z)Lcom/mikepenz/materialdrawer/model/ToggleDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

#region "Event implementation for Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener"
		public event EventHandler<global::Com.Mikepenz.Materialdrawer.Interfaces.CheckedChangeEventArgs> CheckedChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener, global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerImplementor>(
						ref weak_implementor___SetOnCheckedChangeListener,
						__CreateIOnCheckedChangeListenerImplementor,
						__v => OnCheckedChangeListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener, global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerImplementor>(
						ref weak_implementor___SetOnCheckedChangeListener,
						global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerImplementor.__IsEmpty,
						__v => OnCheckedChangeListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnCheckedChangeListener;

		global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerImplementor __CreateIOnCheckedChangeListenerImplementor ()
		{
			return new global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListenerImplementor (this);
		}
#endregion
	}
}
