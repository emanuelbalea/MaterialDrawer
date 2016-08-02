using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='ColorfulBadgeable']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/ColorfulBadgeable", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IColorfulBadgeable : global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IBadgeable {

		global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle BadgeStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='ColorfulBadgeable']/method[@name='getBadgeStyle' and count(parameter)=0]"
			[Register ("getBadgeStyle", "()Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetGetBadgeStyleHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeableInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='ColorfulBadgeable']/method[@name='withBadgeStyle' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.BadgeStyle']]"
		[Register ("withBadgeStyle", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)Ljava/lang/Object;", "GetWithBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeableInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithBadgeStyle (global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0);

	}

	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/ColorfulBadgeable", DoNotGenerateAcw=true)]
	internal class IColorfulBadgeableInvoker : global::Java.Lang.Object, IColorfulBadgeable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/ColorfulBadgeable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IColorfulBadgeableInvoker); }
		}

		IntPtr class_ref;

		public static IColorfulBadgeable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IColorfulBadgeable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.ColorfulBadgeable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IColorfulBadgeableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BadgeStyle);
		}
#pragma warning restore 0169

		IntPtr id_getBadgeStyle;
		public unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle BadgeStyle {
			get {
				if (id_getBadgeStyle == IntPtr.Zero)
					id_getBadgeStyle = JNIEnv.GetMethodID (class_ref, "getBadgeStyle", "()Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBadgeStyle), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadgeStyle (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_;
		public unsafe global::Java.Lang.Object WithBadgeStyle (global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle p0)
		{
			if (id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ == IntPtr.Zero)
				id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_ = JNIEnv.GetMethodID (class_ref, "withBadgeStyle", "(Lcom/mikepenz/materialdrawer/holder/BadgeStyle;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadgeStyle_Lcom_mikepenz_materialdrawer_holder_BadgeStyle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Badge);
		}
#pragma warning restore 0169

		IntPtr id_getBadge;
		public unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Badge {
			get {
				if (id_getBadge == IntPtr.Zero)
					id_getBadge = JNIEnv.GetMethodID (class_ref, "getBadge", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBadge), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadge (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
		public unsafe global::Java.Lang.Object WithBadge (global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p0)
		{
			if (id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ == IntPtr.Zero)
				id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_ = JNIEnv.GetMethodID (class_ref, "withBadge", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadge_Lcom_mikepenz_materialdrawer_holder_StringHolder_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithBadge (p0));
		}
#pragma warning restore 0169

		IntPtr id_withBadge_I;
		public unsafe global::Java.Lang.Object WithBadge (int p0)
		{
			if (id_withBadge_I == IntPtr.Zero)
				id_withBadge_I = JNIEnv.GetMethodID (class_ref, "withBadge", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadge_I, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IColorfulBadgeable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadge (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_withBadge_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object WithBadge (string p0)
		{
			if (id_withBadge_Ljava_lang_String_ == IntPtr.Zero)
				id_withBadge_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withBadge", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadge_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
