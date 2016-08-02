using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ExpandableDrawerItem", DoNotGenerateAcw=true)]
	public partial class ExpandableDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem {


		static IntPtr arrowColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/field[@name='arrowColor']"
		[Register ("arrowColor")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder ArrowColor {
			get {
				if (arrowColor_jfieldId == IntPtr.Zero)
					arrowColor_jfieldId = JNIEnv.GetFieldID (class_ref, "arrowColor", "Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, arrowColor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (arrowColor_jfieldId == IntPtr.Zero)
					arrowColor_jfieldId = JNIEnv.GetFieldID (class_ref, "arrowColor", "Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, arrowColor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ExpandableDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ExpandableDrawerItem$ItemFactory", ref java_class_handle);
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
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem.ItemFactory']/constructor[@name='ExpandableDrawerItem.ItemFactory' and count(parameter)=0]"
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
//				global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder {


			static IntPtr arrow_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem.ViewHolder']/field[@name='arrow']"
			[Register ("arrow")]
			public global::Com.Mikepenz.Iconics.View.IconicsImageView Arrow {
				get {
					if (arrow_jfieldId == IntPtr.Zero)
						arrow_jfieldId = JNIEnv.GetFieldID (class_ref, "arrow", "Lcom/mikepenz/iconics/view/IconicsImageView;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, arrow_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.View.IconicsImageView> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (arrow_jfieldId == IntPtr.Zero)
						arrow_jfieldId = JNIEnv.GetFieldID (class_ref, "arrow", "Lcom/mikepenz/iconics/view/IconicsImageView;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, arrow_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem.ViewHolder']/constructor[@name='ExpandableDrawerItem.ViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ExpandableDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpandableDrawerItem); }
		}

		protected ExpandableDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/constructor[@name='ExpandableDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExpandableDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ExpandableDrawerItem)) {
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
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.ExpandableDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_ExpandableDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withArrowColor_I;
#pragma warning disable 0169
		static Delegate GetWithArrowColor_IHandler ()
		{
			if (cb_withArrowColor_I == null)
				cb_withArrowColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithArrowColor_I);
			return cb_withArrowColor_I;
		}

		static IntPtr n_WithArrowColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithArrowColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withArrowColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/method[@name='withArrowColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withArrowColor", "(I)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem;", "GetWithArrowColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem WithArrowColor (int p0)
		{
			if (id_withArrowColor_I == IntPtr.Zero)
				id_withArrowColor_I = JNIEnv.GetMethodID (class_ref, "withArrowColor", "(I)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withArrowColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withArrowColor", "(I)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withArrowColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithArrowColorRes_IHandler ()
		{
			if (cb_withArrowColorRes_I == null)
				cb_withArrowColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithArrowColorRes_I);
			return cb_withArrowColorRes_I;
		}

		static IntPtr n_WithArrowColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithArrowColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withArrowColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ExpandableDrawerItem']/method[@name='withArrowColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withArrowColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem;", "GetWithArrowColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem WithArrowColorRes (int p0)
		{
			if (id_withArrowColorRes_I == IntPtr.Zero)
				id_withArrowColorRes_I = JNIEnv.GetMethodID (class_ref, "withArrowColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withArrowColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ExpandableDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withArrowColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ExpandableDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
