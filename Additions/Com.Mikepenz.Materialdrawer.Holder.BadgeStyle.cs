using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/holder/BadgeStyle", DoNotGenerateAcw=true)]
	public partial class BadgeStyle : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/holder/BadgeStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BadgeStyle); }
		}

		protected BadgeStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/constructor[@name='BadgeStyle' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe BadgeStyle (int p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (BadgeStyle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/constructor[@name='BadgeStyle' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe BadgeStyle (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (BadgeStyle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/constructor[@name='BadgeStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BadgeStyle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BadgeStyle)) {
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

		static Delegate cb_getBadgeBackground;
#pragma warning disable 0169
		static Delegate GetGetBadgeBackgroundHandler ()
		{
			if (cb_getBadgeBackground == null)
				cb_getBadgeBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBadgeBackground);
			return cb_getBadgeBackground;
		}

		static IntPtr n_GetBadgeBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BadgeBackground);
		}
#pragma warning restore 0169

		static IntPtr id_getBadgeBackground;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable BadgeBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getBadgeBackground' and count(parameter)=0]"
			[Register ("getBadgeBackground", "()Landroid/graphics/drawable/Drawable;", "GetGetBadgeBackgroundHandler")]
			get {
				if (id_getBadgeBackground == IntPtr.Zero)
					id_getBadgeBackground = JNIEnv.GetMethodID (class_ref, "getBadgeBackground", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBadgeBackground), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBadgeBackground", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColor);
			return cb_getColor;
		}

		static IntPtr n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Color);
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getColorPressed;
#pragma warning disable 0169
		static Delegate GetGetColorPressedHandler ()
		{
			if (cb_getColorPressed == null)
				cb_getColorPressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorPressed);
			return cb_getColorPressed;
		}

		static IntPtr n_GetColorPressed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorPressed);
		}
#pragma warning restore 0169

		static IntPtr id_getColorPressed;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder ColorPressed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getColorPressed' and count(parameter)=0]"
			[Register ("getColorPressed", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetColorPressedHandler")]
			get {
				if (id_getColorPressed == IntPtr.Zero)
					id_getColorPressed = JNIEnv.GetMethodID (class_ref, "getColorPressed", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColorPressed), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorPressed", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCorners;
#pragma warning disable 0169
		static Delegate GetGetCornersHandler ()
		{
			if (cb_getCorners == null)
				cb_getCorners = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCorners);
			return cb_getCorners;
		}

		static IntPtr n_GetCorners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Corners);
		}
#pragma warning restore 0169

		static IntPtr id_getCorners;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder Corners {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getCorners' and count(parameter)=0]"
			[Register ("getCorners", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "GetGetCornersHandler")]
			get {
				if (id_getCorners == IntPtr.Zero)
					id_getCorners = JNIEnv.GetMethodID (class_ref, "getCorners", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCorners), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCorners", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGradientDrawable;
#pragma warning disable 0169
		static Delegate GetGetGradientDrawableHandler ()
		{
			if (cb_getGradientDrawable == null)
				cb_getGradientDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGradientDrawable);
			return cb_getGradientDrawable;
		}

		static int n_GetGradientDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GradientDrawable;
		}
#pragma warning restore 0169

		static IntPtr id_getGradientDrawable;
		public virtual unsafe int GradientDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getGradientDrawable' and count(parameter)=0]"
			[Register ("getGradientDrawable", "()I", "GetGetGradientDrawableHandler")]
			get {
				if (id_getGradientDrawable == IntPtr.Zero)
					id_getGradientDrawable = JNIEnv.GetMethodID (class_ref, "getGradientDrawable", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGradientDrawable);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGradientDrawable", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinWidth;
#pragma warning disable 0169
		static Delegate GetGetMinWidthHandler ()
		{
			if (cb_getMinWidth == null)
				cb_getMinWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinWidth);
			return cb_getMinWidth;
		}

		static IntPtr n_GetMinWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MinWidth);
		}
#pragma warning restore 0169

		static IntPtr id_getMinWidth;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder MinWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getMinWidth' and count(parameter)=0]"
			[Register ("getMinWidth", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "GetGetMinWidthHandler")]
			get {
				if (id_getMinWidth == IntPtr.Zero)
					id_getMinWidth = JNIEnv.GetMethodID (class_ref, "getMinWidth", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMinWidth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinWidth", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingLeftRight;
#pragma warning disable 0169
		static Delegate GetGetPaddingLeftRightHandler ()
		{
			if (cb_getPaddingLeftRight == null)
				cb_getPaddingLeftRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaddingLeftRight);
			return cb_getPaddingLeftRight;
		}

		static IntPtr n_GetPaddingLeftRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaddingLeftRight);
		}
#pragma warning restore 0169

		static IntPtr id_getPaddingLeftRight;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder PaddingLeftRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getPaddingLeftRight' and count(parameter)=0]"
			[Register ("getPaddingLeftRight", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "GetGetPaddingLeftRightHandler")]
			get {
				if (id_getPaddingLeftRight == IntPtr.Zero)
					id_getPaddingLeftRight = JNIEnv.GetMethodID (class_ref, "getPaddingLeftRight", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaddingLeftRight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaddingLeftRight", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingTopBottom;
#pragma warning disable 0169
		static Delegate GetGetPaddingTopBottomHandler ()
		{
			if (cb_getPaddingTopBottom == null)
				cb_getPaddingTopBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaddingTopBottom);
			return cb_getPaddingTopBottom;
		}

		static IntPtr n_GetPaddingTopBottom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaddingTopBottom);
		}
#pragma warning restore 0169

		static IntPtr id_getPaddingTopBottom;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder PaddingTopBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getPaddingTopBottom' and count(parameter)=0]"
			[Register ("getPaddingTopBottom", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "GetGetPaddingTopBottomHandler")]
			get {
				if (id_getPaddingTopBottom == IntPtr.Zero)
					id_getPaddingTopBottom = JNIEnv.GetMethodID (class_ref, "getPaddingTopBottom", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaddingTopBottom), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaddingTopBottom", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='getTextColor' and count(parameter)=0]"
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

		static Delegate cb_style_Landroid_widget_TextView_;
#pragma warning disable 0169
		static Delegate GetStyle_Landroid_widget_TextView_Handler ()
		{
			if (cb_style_Landroid_widget_TextView_ == null)
				cb_style_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Style_Landroid_widget_TextView_);
			return cb_style_Landroid_widget_TextView_;
		}

		static void n_Style_Landroid_widget_TextView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Style (p0);
		}
#pragma warning restore 0169

		static IntPtr id_style_Landroid_widget_TextView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='style' and count(parameter)=1 and parameter[1][@type='android.widget.TextView']]"
		[Register ("style", "(Landroid/widget/TextView;)V", "GetStyle_Landroid_widget_TextView_Handler")]
		public virtual unsafe void Style (global::Android.Widget.TextView p0)
		{
			if (id_style_Landroid_widget_TextView_ == IntPtr.Zero)
				id_style_Landroid_widget_TextView_ = JNIEnv.GetMethodID (class_ref, "style", "(Landroid/widget/TextView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_style_Landroid_widget_TextView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "style", "(Landroid/widget/TextView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_;
#pragma warning disable 0169
		static Delegate GetStyle_Landroid_widget_TextView_Landroid_content_res_ColorStateList_Handler ()
		{
			if (cb_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_ == null)
				cb_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_);
			return cb_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_;
		}

		static void n_Style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.ColorStateList p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Style (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='style' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='android.content.res.ColorStateList']]"
		[Register ("style", "(Landroid/widget/TextView;Landroid/content/res/ColorStateList;)V", "GetStyle_Landroid_widget_TextView_Landroid_content_res_ColorStateList_Handler")]
		public virtual unsafe void Style (global::Android.Widget.TextView p0, global::Android.Content.Res.ColorStateList p1)
		{
			if (id_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				id_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID (class_ref, "style", "(Landroid/widget/TextView;Landroid/content/res/ColorStateList;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_style_Landroid_widget_TextView_Landroid_content_res_ColorStateList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "style", "(Landroid/widget/TextView;Landroid/content/res/ColorStateList;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_withBadgeBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithBadgeBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_withBadgeBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_withBadgeBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithBadgeBackground_Landroid_graphics_drawable_Drawable_);
			return cb_withBadgeBackground_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithBadgeBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithBadgeBackground (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withBadgeBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withBadgeBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withBadgeBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithBadgeBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithBadgeBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_withBadgeBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withBadgeBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "withBadgeBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withBadgeBackground_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withBadgeBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withColor_I;
#pragma warning disable 0169
		static Delegate GetWithColor_IHandler ()
		{
			if (cb_withColor_I == null)
				cb_withColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithColor_I);
			return cb_withColor_I;
		}

		static IntPtr n_WithColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withColor", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithColor (int p0)
		{
			if (id_withColor_I == IntPtr.Zero)
				id_withColor_I = JNIEnv.GetMethodID (class_ref, "withColor", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withColor", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withColorPressed_I;
#pragma warning disable 0169
		static Delegate GetWithColorPressed_IHandler ()
		{
			if (cb_withColorPressed_I == null)
				cb_withColorPressed_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithColorPressed_I);
			return cb_withColorPressed_I;
		}

		static IntPtr n_WithColorPressed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithColorPressed (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withColorPressed_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withColorPressed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withColorPressed", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithColorPressed_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithColorPressed (int p0)
		{
			if (id_withColorPressed_I == IntPtr.Zero)
				id_withColorPressed_I = JNIEnv.GetMethodID (class_ref, "withColorPressed", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withColorPressed_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withColorPressed", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withColorPressedRes_I;
#pragma warning disable 0169
		static Delegate GetWithColorPressedRes_IHandler ()
		{
			if (cb_withColorPressedRes_I == null)
				cb_withColorPressedRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithColorPressedRes_I);
			return cb_withColorPressedRes_I;
		}

		static IntPtr n_WithColorPressedRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithColorPressedRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withColorPressedRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withColorPressedRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withColorPressedRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithColorPressedRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithColorPressedRes (int p0)
		{
			if (id_withColorPressedRes_I == IntPtr.Zero)
				id_withColorPressedRes_I = JNIEnv.GetMethodID (class_ref, "withColorPressedRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withColorPressedRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withColorPressedRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithColorRes_IHandler ()
		{
			if (cb_withColorRes_I == null)
				cb_withColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithColorRes_I);
			return cb_withColorRes_I;
		}

		static IntPtr n_WithColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithColorRes (int p0)
		{
			if (id_withColorRes_I == IntPtr.Zero)
				id_withColorRes_I = JNIEnv.GetMethodID (class_ref, "withColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCorners_I;
#pragma warning disable 0169
		static Delegate GetWithCorners_IHandler ()
		{
			if (cb_withCorners_I == null)
				cb_withCorners_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithCorners_I);
			return cb_withCorners_I;
		}

		static IntPtr n_WithCorners_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCorners (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCorners_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withCorners' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCorners", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithCorners_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithCorners (int p0)
		{
			if (id_withCorners_I == IntPtr.Zero)
				id_withCorners_I = JNIEnv.GetMethodID (class_ref, "withCorners", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCorners_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCorners", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCornersDp_I;
#pragma warning disable 0169
		static Delegate GetWithCornersDp_IHandler ()
		{
			if (cb_withCornersDp_I == null)
				cb_withCornersDp_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithCornersDp_I);
			return cb_withCornersDp_I;
		}

		static IntPtr n_WithCornersDp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCornersDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCornersDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withCornersDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withCornersDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithCornersDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithCornersDp (int p0)
		{
			if (id_withCornersDp_I == IntPtr.Zero)
				id_withCornersDp_I = JNIEnv.GetMethodID (class_ref, "withCornersDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCornersDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCornersDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withGradientDrawable_I;
#pragma warning disable 0169
		static Delegate GetWithGradientDrawable_IHandler ()
		{
			if (cb_withGradientDrawable_I == null)
				cb_withGradientDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithGradientDrawable_I);
			return cb_withGradientDrawable_I;
		}

		static IntPtr n_WithGradientDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithGradientDrawable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withGradientDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withGradientDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withGradientDrawable", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithGradientDrawable_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithGradientDrawable (int p0)
		{
			if (id_withGradientDrawable_I == IntPtr.Zero)
				id_withGradientDrawable_I = JNIEnv.GetMethodID (class_ref, "withGradientDrawable", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withGradientDrawable_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withGradientDrawable", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withMinWidth_I;
#pragma warning disable 0169
		static Delegate GetWithMinWidth_IHandler ()
		{
			if (cb_withMinWidth_I == null)
				cb_withMinWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithMinWidth_I);
			return cb_withMinWidth_I;
		}

		static IntPtr n_WithMinWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMinWidth (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withMinWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withMinWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withMinWidth", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithMinWidth_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithMinWidth (int p0)
		{
			if (id_withMinWidth_I == IntPtr.Zero)
				id_withMinWidth_I = JNIEnv.GetMethodID (class_ref, "withMinWidth", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMinWidth_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMinWidth", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPadding_I;
#pragma warning disable 0169
		static Delegate GetWithPadding_IHandler ()
		{
			if (cb_withPadding_I == null)
				cb_withPadding_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithPadding_I);
			return cb_withPadding_I;
		}

		static IntPtr n_WithPadding_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPadding (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPadding_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withPadding' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withPadding", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithPadding_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithPadding (int p0)
		{
			if (id_withPadding_I == IntPtr.Zero)
				id_withPadding_I = JNIEnv.GetMethodID (class_ref, "withPadding", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPadding_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPadding", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPaddingLeftRightDp_I;
#pragma warning disable 0169
		static Delegate GetWithPaddingLeftRightDp_IHandler ()
		{
			if (cb_withPaddingLeftRightDp_I == null)
				cb_withPaddingLeftRightDp_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithPaddingLeftRightDp_I);
			return cb_withPaddingLeftRightDp_I;
		}

		static IntPtr n_WithPaddingLeftRightDp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPaddingLeftRightDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPaddingLeftRightDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withPaddingLeftRightDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withPaddingLeftRightDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithPaddingLeftRightDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithPaddingLeftRightDp (int p0)
		{
			if (id_withPaddingLeftRightDp_I == IntPtr.Zero)
				id_withPaddingLeftRightDp_I = JNIEnv.GetMethodID (class_ref, "withPaddingLeftRightDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPaddingLeftRightDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPaddingLeftRightDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPaddingLeftRightPx_I;
#pragma warning disable 0169
		static Delegate GetWithPaddingLeftRightPx_IHandler ()
		{
			if (cb_withPaddingLeftRightPx_I == null)
				cb_withPaddingLeftRightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithPaddingLeftRightPx_I);
			return cb_withPaddingLeftRightPx_I;
		}

		static IntPtr n_WithPaddingLeftRightPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPaddingLeftRightPx (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPaddingLeftRightPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withPaddingLeftRightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withPaddingLeftRightPx", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithPaddingLeftRightPx_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithPaddingLeftRightPx (int p0)
		{
			if (id_withPaddingLeftRightPx_I == IntPtr.Zero)
				id_withPaddingLeftRightPx_I = JNIEnv.GetMethodID (class_ref, "withPaddingLeftRightPx", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPaddingLeftRightPx_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPaddingLeftRightPx", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPaddingTopBottomDp_I;
#pragma warning disable 0169
		static Delegate GetWithPaddingTopBottomDp_IHandler ()
		{
			if (cb_withPaddingTopBottomDp_I == null)
				cb_withPaddingTopBottomDp_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithPaddingTopBottomDp_I);
			return cb_withPaddingTopBottomDp_I;
		}

		static IntPtr n_WithPaddingTopBottomDp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPaddingTopBottomDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPaddingTopBottomDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withPaddingTopBottomDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withPaddingTopBottomDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithPaddingTopBottomDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithPaddingTopBottomDp (int p0)
		{
			if (id_withPaddingTopBottomDp_I == IntPtr.Zero)
				id_withPaddingTopBottomDp_I = JNIEnv.GetMethodID (class_ref, "withPaddingTopBottomDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPaddingTopBottomDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPaddingTopBottomDp", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPaddingTopBottomPx_I;
#pragma warning disable 0169
		static Delegate GetWithPaddingTopBottomPx_IHandler ()
		{
			if (cb_withPaddingTopBottomPx_I == null)
				cb_withPaddingTopBottomPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithPaddingTopBottomPx_I);
			return cb_withPaddingTopBottomPx_I;
		}

		static IntPtr n_WithPaddingTopBottomPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPaddingTopBottomPx (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPaddingTopBottomPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withPaddingTopBottomPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withPaddingTopBottomPx", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithPaddingTopBottomPx_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithPaddingTopBottomPx (int p0)
		{
			if (id_withPaddingTopBottomPx_I == IntPtr.Zero)
				id_withPaddingTopBottomPx_I = JNIEnv.GetMethodID (class_ref, "withPaddingTopBottomPx", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPaddingTopBottomPx_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPaddingTopBottomPx", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withTextColor", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithTextColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithTextColor (int p0)
		{
			if (id_withTextColor_I == IntPtr.Zero)
				id_withTextColor_I = JNIEnv.GetMethodID (class_ref, "withTextColor", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTextColor", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTextColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.holder']/class[@name='BadgeStyle']/method[@name='withTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;", "GetWithTextColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle WithTextColorRes (int p0)
		{
			if (id_withTextColorRes_I == IntPtr.Zero)
				id_withTextColorRes_I = JNIEnv.GetMethodID (class_ref, "withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.BadgeStyle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/holder/BadgeStyle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
