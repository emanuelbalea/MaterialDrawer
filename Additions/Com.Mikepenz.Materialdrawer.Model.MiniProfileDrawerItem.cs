using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/MiniProfileDrawerItem", DoNotGenerateAcw=true)]
	public partial class MiniProfileDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile {


		static IntPtr customHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/field[@name='customHeight']"
		[Register ("customHeight")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder CustomHeight {
			get {
				if (customHeight_jfieldId == IntPtr.Zero)
					customHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "customHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, customHeight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (customHeight_jfieldId == IntPtr.Zero)
					customHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "customHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, customHeight_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ItemFactory", ref java_class_handle);
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
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem.ItemFactory']/constructor[@name='MiniProfileDrawerItem.ItemFactory' and count(parameter)=0]"
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
//				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem.ViewHolder']/constructor[@name='MiniProfileDrawerItem.ViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/MiniProfileDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiniProfileDrawerItem); }
		}

		protected MiniProfileDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/constructor[@name='MiniProfileDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiniProfileDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MiniProfileDrawerItem)) {
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

		static IntPtr id_ctor_Lcom_mikepenz_materialdrawer_model_ProfileDrawerItem_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/constructor[@name='MiniProfileDrawerItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.ProfileDrawerItem']]"
		[Register (".ctor", "(Lcom/mikepenz/materialdrawer/model/ProfileDrawerItem;)V", "")]
		public unsafe MiniProfileDrawerItem (global::Com.Mikepenz.Materialdrawer.Model.ProfileDrawerItem p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MiniProfileDrawerItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/materialdrawer/model/ProfileDrawerItem;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/materialdrawer/model/ProfileDrawerItem;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_materialdrawer_model_ProfileDrawerItem_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_materialdrawer_model_ProfileDrawerItem_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/materialdrawer/model/ProfileDrawerItem;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_materialdrawer_model_ProfileDrawerItem_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_materialdrawer_model_ProfileDrawerItem_, __args);
			} finally {
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
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

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.MiniProfileDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_MiniProfileDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem$ViewHolder;)V"), __args);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCustomHeight (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withCustomHeight' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.DimenHolder']]"
		[Register ("withCustomHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithCustomHeight (global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0)
		{
			if (id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == IntPtr.Zero)
				id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNIEnv.GetMethodID (class_ref, "withCustomHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCustomHeightDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeightDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withCustomHeightDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCustomHeightDp", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithCustomHeightDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithCustomHeightDp (int p0)
		{
			if (id_withCustomHeightDp_I == IntPtr.Zero)
				id_withCustomHeightDp_I = JNIEnv.GetMethodID (class_ref, "withCustomHeightDp", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeightDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeightDp", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCustomHeightPx (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeightPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withCustomHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCustomHeightPx", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithCustomHeightPx_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithCustomHeightPx (int p0)
		{
			if (id_withCustomHeightPx_I == IntPtr.Zero)
				id_withCustomHeightPx_I = JNIEnv.GetMethodID (class_ref, "withCustomHeightPx", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeightPx_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeightPx", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCustomHeightRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCustomHeightRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withCustomHeightRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCustomHeightRes", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithCustomHeightRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithCustomHeightRes (int p0)
		{
			if (id_withCustomHeightRes_I == IntPtr.Zero)
				id_withCustomHeightRes_I = JNIEnv.GetMethodID (class_ref, "withCustomHeightRes", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomHeightRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomHeightRes", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithEmail_Ljava_lang_String_Handler ()
		{
			if (cb_withEmail_Ljava_lang_String_ == null)
				cb_withEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithEmail_Ljava_lang_String_);
			return cb_withEmail_Ljava_lang_String_;
		}

		static IntPtr n_WithEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithEmail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withEmail", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithEmail_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithEmail (string p0)
		{
			if (id_withEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_withEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withEmail", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEmail", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_withIcon_Landroid_graphics_Bitmap_ == null)
				cb_withIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_graphics_Bitmap_);
			return cb_withIcon_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_WithIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("withIcon", "(Landroid/graphics/Bitmap;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithIcon_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithIcon (global::Android.Graphics.Bitmap p0)
		{
			if (id_withIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/graphics/Bitmap;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Landroid/graphics/Bitmap;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_withIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_withIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_graphics_drawable_Drawable_);
			return cb_withIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_withIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withIcon_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_net_Uri_Handler ()
		{
			if (cb_withIcon_Landroid_net_Uri_ == null)
				cb_withIcon_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_net_Uri_);
			return cb_withIcon_Landroid_net_Uri_;
		}

		static IntPtr n_WithIcon_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("withIcon", "(Landroid/net/Uri;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithIcon_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithIcon (global::Android.Net.Uri p0)
		{
			if (id_withIcon_Landroid_net_Uri_ == IntPtr.Zero)
				id_withIcon_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/net/Uri;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Landroid/net/Uri;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler ()
		{
			if (cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == null)
				cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Lcom_mikepenz_iconics_typeface_IIcon_);
			return cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		}

		static IntPtr n_WithIcon_Lcom_mikepenz_iconics_typeface_IIcon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Iconics.Typeface.IIcon p0 = (global::Com.Mikepenz.Iconics.Typeface.IIcon)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
		[Register ("withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithIcon (global::Com.Mikepenz.Iconics.Typeface.IIcon p0)
		{
			if (id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == IntPtr.Zero)
				id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withIcon_I;
#pragma warning disable 0169
		static Delegate GetWithIcon_IHandler ()
		{
			if (cb_withIcon_I == null)
				cb_withIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIcon_I);
			return cb_withIcon_I;
		}

		static IntPtr n_WithIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withIcon", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithIcon_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithIcon (int p0)
		{
			if (id_withIcon_I == IntPtr.Zero)
				id_withIcon_I = JNIEnv.GetMethodID (class_ref, "withIcon", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(I)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withIcon_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Ljava_lang_String_Handler ()
		{
			if (cb_withIcon_Ljava_lang_String_ == null)
				cb_withIcon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Ljava_lang_String_);
			return cb_withIcon_Ljava_lang_String_;
		}

		static IntPtr n_WithIcon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withIcon", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithIcon_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithIcon (string p0)
		{
			if (id_withIcon_Ljava_lang_String_ == IntPtr.Zero)
				id_withIcon_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithName_Ljava_lang_String_Handler ()
		{
			if (cb_withName_Ljava_lang_String_ == null)
				cb_withName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithName_Ljava_lang_String_);
			return cb_withName_Ljava_lang_String_;
		}

		static IntPtr n_WithName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='MiniProfileDrawerItem']/method[@name='withName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withName", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;", "GetWithName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem WithName (string p0)
		{
			if (id_withName_Ljava_lang_String_ == IntPtr.Zero)
				id_withName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withName", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.MiniProfileDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withName", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/MiniProfileDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithEmail (string p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithEmail (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithIcon (global::Android.Graphics.Bitmap p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithIcon (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithIcon (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithIcon (global::Android.Net.Uri p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithIcon (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithIcon (global::Com.Mikepenz.Iconics.Typeface.IIcon p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithIcon (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithIcon (int p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithIcon (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithIcon (string p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithIcon (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithName (string p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithName (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile.WithSelectable (bool p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithSelectable (p0));
		}

	}
}
