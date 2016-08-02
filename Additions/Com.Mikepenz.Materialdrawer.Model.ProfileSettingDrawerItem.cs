using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ProfileSettingDrawerItem", DoNotGenerateAcw=true)]
	public partial class ProfileSettingDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable {

//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem.ItemFactory']"
//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory {

//			internal static IntPtr java_class_handle;
//			internal static IntPtr class_ref {
//				get {
//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ItemFactory", ref java_class_handle);
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
//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem.ItemFactory']/constructor[@name='ProfileSettingDrawerItem.ItemFactory' and count(parameter)=0]"
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
//				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
//				return __ret;
//			}
//#pragma warning restore 0169

//			static IntPtr id_create_Landroid_view_View_;
//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder Create (global::Android.Views.View p0)
//			{
//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder;");
//				try {
//					JValue* __args = stackalloc JValue [1];
//					__args [0] = new JValue (p0);

//					global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder __ret;
//					if (GetType () == ThresholdType)
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
//					else
//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
//					return __ret;
//				} finally {
//				}
//			}

//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			protected ViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ProfileSettingDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfileSettingDrawerItem); }
		}

		protected ProfileSettingDrawerItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/constructor[@name='ProfileSettingDrawerItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProfileSettingDrawerItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ProfileSettingDrawerItem)) {
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Email);
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getEmail' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getIcon' and count(parameter)=0]"
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

		static Delegate cb_getIconColor;
#pragma warning disable 0169
		static Delegate GetGetIconColorHandler ()
		{
			if (cb_getIconColor == null)
				cb_getIconColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconColor);
			return cb_getIconColor;
		}

		static IntPtr n_GetIconColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconColor);
		}
#pragma warning restore 0169

		static IntPtr id_getIconColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder IconColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getIconColor' and count(parameter)=0]"
			[Register ("getIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetIconColorHandler")]
			get {
				if (id_getIconColor == IntPtr.Zero)
					id_getIconColor = JNIEnv.GetMethodID (class_ref, "getIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIconTinted;
#pragma warning disable 0169
		static Delegate GetIsIconTintedHandler ()
		{
			if (cb_isIconTinted == null)
				cb_isIconTinted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIconTinted);
			return cb_isIconTinted;
		}

		static bool n_IsIconTinted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconTinted;
		}
#pragma warning restore 0169

		static Delegate cb_setIconTinted_Z;
#pragma warning disable 0169
		static Delegate GetSetIconTinted_ZHandler ()
		{
			if (cb_setIconTinted_Z == null)
				cb_setIconTinted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIconTinted_Z);
			return cb_setIconTinted_Z;
		}

		static void n_SetIconTinted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IconTinted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isIconTinted;
		static IntPtr id_setIconTinted_Z;
		public virtual unsafe bool IconTinted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='isIconTinted' and count(parameter)=0]"
			[Register ("isIconTinted", "()Z", "GetIsIconTintedHandler")]
			get {
				if (id_isIconTinted == IntPtr.Zero)
					id_isIconTinted = JNIEnv.GetMethodID (class_ref, "isIconTinted", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIconTinted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIconTinted", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='setIconTinted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIconTinted", "(Z)V", "GetSetIconTinted_ZHandler")]
			set {
				if (id_setIconTinted_Z == IntPtr.Zero)
					id_setIconTinted_Z = JNIEnv.GetMethodID (class_ref, "setIconTinted", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconTinted_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconTinted", "(Z)V"), __args);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorHandler ()
		{
			if (cb_getSelectedColor == null)
				cb_getSelectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedColor);
			return cb_getSelectedColor;
		}

		static IntPtr n_GetSelectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register ("getSelectedColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetSelectedColorHandler")]
			get {
				if (id_getSelectedColor == IntPtr.Zero)
					id_getSelectedColor = JNIEnv.GetMethodID (class_ref, "getSelectedColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		static IntPtr id_getTypeface;
		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeface", "()Landroid/graphics/Typeface;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_Handler ()
		{
			if (cb_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView (p0);
		}
#pragma warning restore 0169
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder);
		
		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.ProfileSettingDrawerItem.ViewHolder']]"
		[Register ("bindView", "(Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView (global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem.ViewHolder p0)
		{
			if (id_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_ProfileSettingDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDescription (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDescription (string p0)
		{
			if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithDescription_Ljava_lang_String_Handler ()
		{
			if (cb_withDescription_Ljava_lang_String_ == null)
				cb_withDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDescription_Ljava_lang_String_);
			return cb_withDescription_Ljava_lang_String_;
		}

		static IntPtr n_WithDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDescription (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withDescription", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithDescription_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithDescription (string p0)
		{
			if (id_withDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_withDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withDescription", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDescription_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDescription", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithEmail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withEmail", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithEmail_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithEmail (string p0)
		{
			if (id_withEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_withEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withEmail", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEmail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEmail", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("withIcon", "(Landroid/graphics/Bitmap;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIcon_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIcon (global::Android.Graphics.Bitmap p0)
		{
			if (id_withIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/graphics/Bitmap;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Landroid/graphics/Bitmap;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_withIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("withIcon", "(Landroid/net/Uri;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIcon_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIcon (global::Android.Net.Uri p0)
		{
			if (id_withIcon_Landroid_net_Uri_ == IntPtr.Zero)
				id_withIcon_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Landroid/net/Uri;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Landroid/net/Uri;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Iconics.Typeface.IIcon p0 = (global::Com.Mikepenz.Iconics.Typeface.IIcon)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
		[Register ("withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIcon (global::Com.Mikepenz.Iconics.Typeface.IIcon p0)
		{
			if (id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == IntPtr.Zero)
				id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withIcon", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIcon_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIcon (int p0)
		{
			if (id_withIcon_I == IntPtr.Zero)
				id_withIcon_I = JNIEnv.GetMethodID (class_ref, "withIcon", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withIcon", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIcon_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIcon (string p0)
		{
			if (id_withIcon_Ljava_lang_String_ == IntPtr.Zero)
				id_withIcon_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withIcon", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withIconColor_I;
#pragma warning disable 0169
		static Delegate GetWithIconColor_IHandler ()
		{
			if (cb_withIconColor_I == null)
				cb_withIconColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIconColor_I);
			return cb_withIconColor_I;
		}

		static IntPtr n_WithIconColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIconColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIconColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withIconColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIconColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIconColor (int p0)
		{
			if (id_withIconColor_I == IntPtr.Zero)
				id_withIconColor_I = JNIEnv.GetMethodID (class_ref, "withIconColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIconColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIconColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withIconColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithIconColorRes_IHandler ()
		{
			if (cb_withIconColorRes_I == null)
				cb_withIconColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIconColorRes_I);
			return cb_withIconColorRes_I;
		}

		static IntPtr n_WithIconColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIconColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIconColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withIconColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIconColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIconColorRes (int p0)
		{
			if (id_withIconColorRes_I == IntPtr.Zero)
				id_withIconColorRes_I = JNIEnv.GetMethodID (class_ref, "withIconColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIconColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIconColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withIconTinted_Z;
#pragma warning disable 0169
		static Delegate GetWithIconTinted_ZHandler ()
		{
			if (cb_withIconTinted_Z == null)
				cb_withIconTinted_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIconTinted_Z);
			return cb_withIconTinted_Z;
		}

		static IntPtr n_WithIconTinted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIconTinted (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconTinted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withIconTinted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withIconTinted", "(Z)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithIconTinted_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithIconTinted (bool p0)
		{
			if (id_withIconTinted_Z == IntPtr.Zero)
				id_withIconTinted_Z = JNIEnv.GetMethodID (class_ref, "withIconTinted", "(Z)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIconTinted_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIconTinted", "(Z)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withName", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithName (string p0)
		{
			if (id_withName_Ljava_lang_String_ == IntPtr.Zero)
				id_withName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withName", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withName", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedColor_IHandler ()
		{
			if (cb_withSelectedColor_I == null)
				cb_withSelectedColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedColor_I);
			return cb_withSelectedColor_I;
		}

		static IntPtr n_WithSelectedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectedColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSelectedColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithSelectedColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithSelectedColor (int p0)
		{
			if (id_withSelectedColor_I == IntPtr.Zero)
				id_withSelectedColor_I = JNIEnv.GetMethodID (class_ref, "withSelectedColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectedColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectedColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectedColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedColorRes_IHandler ()
		{
			if (cb_withSelectedColorRes_I == null)
				cb_withSelectedColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedColorRes_I);
			return cb_withSelectedColorRes_I;
		}

		static IntPtr n_WithSelectedColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectedColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withSelectedColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSelectedColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithSelectedColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithSelectedColorRes (int p0)
		{
			if (id_withSelectedColorRes_I == IntPtr.Zero)
				id_withSelectedColorRes_I = JNIEnv.GetMethodID (class_ref, "withSelectedColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectedColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectedColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTextColor_I;
#pragma warning disable 0169
		static Delegate GetWithTextColor_IHandler ()
		{
			if (cb_withTextColor_I == null)
				cb_withTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithTextColor_I);
			return cb_withTextColor_I;
		}

		static IntPtr n_WithTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withTextColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithTextColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithTextColor (int p0)
		{
			if (id_withTextColor_I == IntPtr.Zero)
				id_withTextColor_I = JNIEnv.GetMethodID (class_ref, "withTextColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTextColor", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithTextColorRes_IHandler ()
		{
			if (cb_withTextColorRes_I == null)
				cb_withTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithTextColorRes_I);
			return cb_withTextColorRes_I;
		}

		static IntPtr n_WithTextColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTextColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithTextColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithTextColorRes (int p0)
		{
			if (id_withTextColorRes_I == IntPtr.Zero)
				id_withTextColorRes_I = JNIEnv.GetMethodID (class_ref, "withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetWithTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_withTypeface_Landroid_graphics_Typeface_ == null)
				cb_withTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTypeface_Landroid_graphics_Typeface_);
			return cb_withTypeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_WithTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ProfileSettingDrawerItem']/method[@name='withTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("withTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;", "GetWithTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem WithTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_withTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_withTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "withTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTypeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ProfileSettingDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/model/ProfileSettingDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable.WithTag (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithTag (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable
		global::Java.Lang.Object global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable.WithTypeface (global::Android.Graphics.Typeface p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(WithTypeface (p0));
		}

	}
}
