using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseViewHolder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/BaseViewHolder", DoNotGenerateAcw=true)]
	public partial class BaseViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {


		static IntPtr description_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseViewHolder']/field[@name='description']"
		[Register ("description")]
		protected global::Android.Widget.TextView Description {
			get {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, description_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, description_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr icon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseViewHolder']/field[@name='icon']"
		[Register ("icon")]
		protected global::Android.Widget.ImageView Icon {
			get {
				if (icon_jfieldId == IntPtr.Zero)
					icon_jfieldId = JNIEnv.GetFieldID (class_ref, "icon", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, icon_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (icon_jfieldId == IntPtr.Zero)
					icon_jfieldId = JNIEnv.GetFieldID (class_ref, "icon", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, icon_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseViewHolder']/field[@name='name']"
		[Register ("name")]
		protected global::Android.Widget.TextView Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr view_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseViewHolder']/field[@name='view']"
		[Register ("view")]
		protected global::Android.Views.View View {
			get {
				if (view_jfieldId == IntPtr.Zero)
					view_jfieldId = JNIEnv.GetFieldID (class_ref, "view", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, view_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (view_jfieldId == IntPtr.Zero)
					view_jfieldId = JNIEnv.GetFieldID (class_ref, "view", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, view_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/BaseViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseViewHolder); }
		}

		protected BaseViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseViewHolder']/constructor[@name='BaseViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe BaseViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BaseViewHolder)) {
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
}
