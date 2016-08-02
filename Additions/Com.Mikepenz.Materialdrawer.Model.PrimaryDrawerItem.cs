using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/PrimaryDrawerItem", DoNotGenerateAcw=true)]
	public partial class PrimaryDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable {


		static IntPtr mBadge_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/field[@name='mBadge']"
		[Register ("mBadge")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.StringHolder MBadge {
			get {
				if (mBadge_jfieldId == IntPtr.Zero)
					mBadge_jfieldId = JNIEnv.GetFieldID (class_ref, "mBadge", "Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBadge_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBadge_jfieldId == IntPtr.Zero)
					mBadge_jfieldId = JNIEnv.GetFieldID (class_ref, "mBadge", "Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBadge_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mBadgeStyle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/field[@name='mBadgeStyle']"
		[Register ("mBadgeStyle")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle MBadgeStyle {
			get {
				if (mBadgeStyle_jfieldId == IntPtr.Zero)
					mBadgeStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mBadgeStyle", "Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBadgeStyle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBadgeStyle_jfieldId == IntPtr.Zero)
					mBadgeStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mBadgeStyle", "Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBadgeStyle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/PrimaryDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/PrimaryDrawerItem$ItemFactory", ref java_class_handle);
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
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem.ItemFactory']/constructor[@name='PrimaryDrawerItem.ItemFactory' and count(parameter)=0]"
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
//				global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ViewHolder); }
			}

			protected ViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem.ViewHolder']/constructor[@name='PrimaryDrawerItem.ViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe ViewHolder (global::Android.Views.View p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ViewHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/PrimaryDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrimaryDrawerItem); }
		}

		protected PrimaryDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/constructor[@name='PrimaryDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrimaryDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PrimaryDrawerItem)) {
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

		static Delegate cb_getBadge;
#pragma warning disable 0169
		static Delegate GetGetBadgeHandler ()
		{
			if (cb_getBadge == null)
				cb_getBadge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBadge);
			return cb_getBadge;
		}

		static IntPtr n_GetBadge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Badge);
		}
#pragma warning restore 0169

		static IntPtr id_getBadge;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Badge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='getBadge' and count(parameter)=0]"
			[Register ("getBadge", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetBadgeHandler")]
			get {
				if (id_getBadge == IntPtr.Zero)
					id_getBadge = JNIEnv.GetMethodID (class_ref, "getBadge", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBadge), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBadge", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBadgeStyle;
#pragma warning disable 0169
		static Delegate GetGetBadgeStyleHandler ()
		{
			if (cb_getBadgeStyle == null)
				cb_getBadgeStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBadgeStyle);
			return cb_getBadgeStyle;
		}

		static IntPtr n_GetBadgeStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BadgeStyle);
		}
#pragma warning restore 0169

		static IntPtr id_getBadgeStyle;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle BadgeStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='getBadgeStyle' and count(parameter)=0]"
			[Register ("getBadgeStyle", "()Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetGetBadgeStyleHandler")]
			get {
				if (id_getBadgeStyle == IntPtr.Zero)
					id_getBadgeStyle = JNIEnv.GetMethodID (class_ref, "getBadgeStyle", "()Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBadgeStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBadgeStyle", "()Lcom/mikepenz/materialdrawer/holder/BadgeStyle;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.PrimaryDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
#pragma warning disable 0169
		static Delegate GetWithBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_Handler ()
		{
			if (cb_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ == null)
				cb_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_);
			return cb_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
		}

		static IntPtr n_WithBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadge (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='withBadge' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.StringHolder']]"
		[Register ("withBadge", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;", "GetWithBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_Handler")]
		public virtual unsafe global::Java.Lang.Object WithBadge (global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p0)
		{
			if (id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ == IntPtr.Zero)
				id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ = JNIEnv.GetMethodID (class_ref, "withBadge", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBadge", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withBadge_I;
#pragma warning disable 0169
		static Delegate GetWithBadge_IHandler ()
		{
			if (cb_withBadge_I == null)
				cb_withBadge_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithBadge_I);
			return cb_withBadge_I;
		}

		static IntPtr n_WithBadge_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithBadge (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withBadge_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='withBadge' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withBadge", "(I)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;", "GetWithBadge_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithBadge (int p0)
		{
			if (id_withBadge_I == IntPtr.Zero)
				id_withBadge_I = JNIEnv.GetMethodID (class_ref, "withBadge", "(I)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadge_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBadge", "(I)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withBadge_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithBadge_Ljava_lang_String_Handler ()
		{
			if (cb_withBadge_Ljava_lang_String_ == null)
				cb_withBadge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBadge_Ljava_lang_String_);
			return cb_withBadge_Ljava_lang_String_;
		}

		static IntPtr n_WithBadge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadge (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withBadge_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='withBadge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withBadge", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;", "GetWithBadge_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object WithBadge (string p0)
		{
			if (id_withBadge_Ljava_lang_String_ == IntPtr.Zero)
				id_withBadge_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withBadge", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadge_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBadge", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_;
#pragma warning disable 0169
		static Delegate GetWithBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_Handler ()
		{
			if (cb_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ == null)
				cb_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_);
			return cb_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_;
		}

		static IntPtr n_WithBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadgeStyle (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='PrimaryDrawerItem']/method[@name='withBadgeStyle' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.BadgeStyle']]"
		[Register ("withBadgeStyle", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;", "GetWithBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem WithBadgeStyle (global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0)
		{
			if (id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ == IntPtr.Zero)
				id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ = JNIEnv.GetMethodID (class_ref, "withBadgeStyle", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBadgeStyle", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable.WithBadgeStyle (global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithBadgeStyle (p0));
		}

	}
}
