using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/SwitchDrawerItem", DoNotGenerateAcw=true)]
	public partial class SwitchDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem {

//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/SwitchDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/SwitchDrawerItem$ItemFactory", ref java_class_handle);
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
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem.ItemFactory']/constructor[@name='SwitchDrawerItem.ItemFactory' and count(parameter)=0]"
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
//				global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder {

			protected ViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/SwitchDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwitchDrawerItem); }
		}

		protected SwitchDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/constructor[@name='SwitchDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SwitchDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SwitchDrawerItem)) {
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChecked;
		}
#pragma warning restore 0169

		static IntPtr id_isChecked;
		public virtual unsafe bool IsChecked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='isChecked' and count(parameter)=0]"
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
		}

		static Delegate cb_isSwitchEnabled;
#pragma warning disable 0169
		static Delegate GetIsSwitchEnabledHandler ()
		{
			if (cb_isSwitchEnabled == null)
				cb_isSwitchEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSwitchEnabled);
			return cb_isSwitchEnabled;
		}

		static bool n_IsSwitchEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSwitchEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isSwitchEnabled;
		public virtual unsafe bool IsSwitchEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='isSwitchEnabled' and count(parameter)=0]"
			[Register ("isSwitchEnabled", "()Z", "GetIsSwitchEnabledHandler")]
			get {
				if (id_isSwitchEnabled == IntPtr.Zero)
					id_isSwitchEnabled = JNIEnv.GetMethodID (class_ref, "isSwitchEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSwitchEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSwitchEnabled", "()Z"));
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCheckedChangeListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnCheckedChangeListener;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener OnCheckedChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='getOnCheckedChangeListener' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.SwitchDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_SwitchDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withCheckable_Z;
#pragma warning disable 0169
		static Delegate GetWithCheckable_ZHandler ()
		{
			if (cb_withCheckable_Z == null)
				cb_withCheckable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCheckable_Z);
			return cb_withCheckable_Z;
		}

		static IntPtr n_WithCheckable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCheckable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCheckable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='withCheckable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withCheckable", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;", "GetWithCheckable_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem WithCheckable (bool p0)
		{
			if (id_withCheckable_Z == IntPtr.Zero)
				id_withCheckable_Z = JNIEnv.GetMethodID (class_ref, "withCheckable", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCheckable_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCheckable", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithChecked (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withChecked_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='withChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withChecked", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;", "GetWithChecked_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem WithChecked (bool p0)
		{
			if (id_withChecked_Z == IntPtr.Zero)
				id_withChecked_Z = JNIEnv.GetMethodID (class_ref, "withChecked", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withChecked_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withChecked", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener p0 = (global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnCheckedChangeListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='withOnCheckedChangeListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.interfaces.OnCheckedChangeListener']]"
		[Register ("withOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;", "GetWithOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem WithOnCheckedChangeListener (global::Com.Mikepenz.Materialdrawer.Interfaces.IOnCheckedChangeListener p0)
		{
			if (id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ == IntPtr.Zero)
				id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_ = JNIEnv.GetMethodID (class_ref, "withOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnCheckedChangeListener_Lcom_mikepenz_materialdrawer_interfaces_OnCheckedChangeListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnCheckedChangeListener", "(Lcom/mikepenz/materialdrawer/interfaces/OnCheckedChangeListener;)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSwitchEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithSwitchEnabled_ZHandler ()
		{
			if (cb_withSwitchEnabled_Z == null)
				cb_withSwitchEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSwitchEnabled_Z);
			return cb_withSwitchEnabled_Z;
		}

		static IntPtr n_WithSwitchEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSwitchEnabled (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSwitchEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='SwitchDrawerItem']/method[@name='withSwitchEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSwitchEnabled", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;", "GetWithSwitchEnabled_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem WithSwitchEnabled (bool p0)
		{
			if (id_withSwitchEnabled_Z == IntPtr.Zero)
				id_withSwitchEnabled_Z = JNIEnv.GetMethodID (class_ref, "withSwitchEnabled", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSwitchEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.SwitchDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSwitchEnabled", "(Z)Lcom/mikepenz/materialdrawer/model/SwitchDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
