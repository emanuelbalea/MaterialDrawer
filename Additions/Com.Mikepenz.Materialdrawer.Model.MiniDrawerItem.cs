using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/MiniDrawerItem", DoNotGenerateAcw=true)]
	public partial class MiniDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem {


		static IntPtr mCustomHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/field[@name='mCustomHeight']"
		[Register ("mCustomHeight")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder MCustomHeight {
			get {
				if (mCustomHeight_jfieldId == IntPtr.Zero)
					mCustomHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCustomHeight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCustomHeight_jfieldId == IntPtr.Zero)
					mCustomHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCustomHeight_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/MiniDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/MiniDrawerItem$ItemFactory", ref java_class_handle);
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
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem.ItemFactory']/constructor[@name='MiniDrawerItem.ItemFactory' and count(parameter)=0]"
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
//				global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem.ViewHolder']/constructor[@name='MiniDrawerItem.ViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/MiniDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiniDrawerItem); }
		}

		protected MiniDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mikepenz_materialdrawer_model_SecondaryDrawerItem_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/constructor[@name='MiniDrawerItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.SecondaryDrawerItem']]"
		[Register (".ctor", "(Lcom/mikepenz/materialdrawer/model/SecondaryDrawerItem;)V", "")]
		public unsafe MiniDrawerItem (global::Com.Mikepenz.Materialdrawer.Model.SecondaryDrawerItem p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MiniDrawerItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/materialdrawer/model/SecondaryDrawerItem;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/materialdrawer/model/SecondaryDrawerItem;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_materialdrawer_model_SecondaryDrawerItem_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_materialdrawer_model_SecondaryDrawerItem_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/materialdrawer/model/SecondaryDrawerItem;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_materialdrawer_model_SecondaryDrawerItem_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_materialdrawer_model_SecondaryDrawerItem_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/constructor[@name='MiniDrawerItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.PrimaryDrawerItem']]"
		[Register (".ctor", "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;)V", "")]
		public unsafe MiniDrawerItem (global::Com.Mikepenz.Materialdrawer.Model.PrimaryDrawerItem p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MiniDrawerItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/materialdrawer/model/PrimaryDrawerItem;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_materialdrawer_model_PrimaryDrawerItem_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/constructor[@name='MiniDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiniDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MiniDrawerItem)) {
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.MiniDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_MiniDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/MiniDrawerItem$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
#pragma warning disable 0169
		static Delegate GetWithCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler ()
		{
			if (cb_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == null)
				cb_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_);
			return cb_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		}

		static IntPtr n_WithCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCustomHeight (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='withCustomHeight' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.DimenHolder']]"
		[Register ("withCustomHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;", "GetWithCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem WithCustomHeight (global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0)
		{
			if (id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == IntPtr.Zero)
				id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNIEnv.GetMethodID (class_ref, "withCustomHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withCustomHeightDp_I;
#pragma warning disable 0169
		static Delegate GetWithCustomHeightDp_IHandler ()
		{
			if (cb_withCustomHeightDp_I == null)
				cb_withCustomHeightDp_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithCustomHeightDp_I);
			return cb_withCustomHeightDp_I;
		}

		static IntPtr n_WithCustomHeightDp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCustomHeightDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeightDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='withCustomHeightDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCustomHeightDp", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;", "GetWithCustomHeightDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem WithCustomHeightDp (int p0)
		{
			if (id_withCustomHeightDp_I == IntPtr.Zero)
				id_withCustomHeightDp_I = JNIEnv.GetMethodID (class_ref, "withCustomHeightDp", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeightDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeightDp", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCustomHeightPx_I;
#pragma warning disable 0169
		static Delegate GetWithCustomHeightPx_IHandler ()
		{
			if (cb_withCustomHeightPx_I == null)
				cb_withCustomHeightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithCustomHeightPx_I);
			return cb_withCustomHeightPx_I;
		}

		static IntPtr n_WithCustomHeightPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCustomHeightPx (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeightPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='withCustomHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCustomHeightPx", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;", "GetWithCustomHeightPx_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem WithCustomHeightPx (int p0)
		{
			if (id_withCustomHeightPx_I == IntPtr.Zero)
				id_withCustomHeightPx_I = JNIEnv.GetMethodID (class_ref, "withCustomHeightPx", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeightPx_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeightPx", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCustomHeightRes_I;
#pragma warning disable 0169
		static Delegate GetWithCustomHeightRes_IHandler ()
		{
			if (cb_withCustomHeightRes_I == null)
				cb_withCustomHeightRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithCustomHeightRes_I);
			return cb_withCustomHeightRes_I;
		}

		static IntPtr n_WithCustomHeightRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCustomHeightRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeightRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='withCustomHeightRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCustomHeightRes", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;", "GetWithCustomHeightRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem WithCustomHeightRes (int p0)
		{
			if (id_withCustomHeightRes_I == IntPtr.Zero)
				id_withCustomHeightRes_I = JNIEnv.GetMethodID (class_ref, "withCustomHeightRes", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeightRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeightRes", "(I)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withEnableSelectedBackground_Z;
#pragma warning disable 0169
		static Delegate GetWithEnableSelectedBackground_ZHandler ()
		{
			if (cb_withEnableSelectedBackground_Z == null)
				cb_withEnableSelectedBackground_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithEnableSelectedBackground_Z);
			return cb_withEnableSelectedBackground_Z;
		}

		static IntPtr n_WithEnableSelectedBackground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithEnableSelectedBackground (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withEnableSelectedBackground_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniDrawerItem']/method[@name='withEnableSelectedBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withEnableSelectedBackground", "(Z)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;", "GetWithEnableSelectedBackground_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem WithEnableSelectedBackground (bool p0)
		{
			if (id_withEnableSelectedBackground_Z == IntPtr.Zero)
				id_withEnableSelectedBackground_Z = JNIEnv.GetMethodID (class_ref, "withEnableSelectedBackground", "(Z)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEnableSelectedBackground_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEnableSelectedBackground", "(Z)Lcom/mikepenz/materialdrawer/model/MiniDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
