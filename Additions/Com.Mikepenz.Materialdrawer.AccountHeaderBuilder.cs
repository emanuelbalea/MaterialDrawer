using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/AccountHeaderBuilder", DoNotGenerateAcw=true)]
	public partial class AccountHeaderBuilder : global::Java.Lang.Object {


		static IntPtr mAccountHeader_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAccountHeader']"
		[Register ("mAccountHeader")]
		protected global::Android.Views.View MAccountHeader {
			get {
				if (mAccountHeader_jfieldId == IntPtr.Zero)
					mAccountHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeader", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountHeader_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountHeader_jfieldId == IntPtr.Zero)
					mAccountHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeader", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeader_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccountHeaderBackground_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAccountHeaderBackground']"
		[Register ("mAccountHeaderBackground")]
		protected global::Android.Widget.ImageView MAccountHeaderBackground {
			get {
				if (mAccountHeaderBackground_jfieldId == IntPtr.Zero)
					mAccountHeaderBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderBackground", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountHeaderBackground_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountHeaderBackground_jfieldId == IntPtr.Zero)
					mAccountHeaderBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderBackground", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeaderBackground_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccountHeaderContainer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAccountHeaderContainer']"
		[Register ("mAccountHeaderContainer")]
		protected global::Android.Views.View MAccountHeaderContainer {
			get {
				if (mAccountHeaderContainer_jfieldId == IntPtr.Zero)
					mAccountHeaderContainer_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderContainer", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountHeaderContainer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountHeaderContainer_jfieldId == IntPtr.Zero)
					mAccountHeaderContainer_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderContainer", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeaderContainer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccountHeaderTextSection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAccountHeaderTextSection']"
		[Register ("mAccountHeaderTextSection")]
		protected global::Android.Views.View MAccountHeaderTextSection {
			get {
				if (mAccountHeaderTextSection_jfieldId == IntPtr.Zero)
					mAccountHeaderTextSection_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderTextSection", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountHeaderTextSection_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountHeaderTextSection_jfieldId == IntPtr.Zero)
					mAccountHeaderTextSection_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderTextSection", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeaderTextSection_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccountHeaderTextSectionBackgroundResource_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAccountHeaderTextSectionBackgroundResource']"
		[Register ("mAccountHeaderTextSectionBackgroundResource")]
		protected int MAccountHeaderTextSectionBackgroundResource {
			get {
				if (mAccountHeaderTextSectionBackgroundResource_jfieldId == IntPtr.Zero)
					mAccountHeaderTextSectionBackgroundResource_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderTextSectionBackgroundResource", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mAccountHeaderTextSectionBackgroundResource_jfieldId);
			}
			set {
				if (mAccountHeaderTextSectionBackgroundResource_jfieldId == IntPtr.Zero)
					mAccountHeaderTextSectionBackgroundResource_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderTextSectionBackgroundResource", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeaderTextSectionBackgroundResource_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mAccountSwitcherArrow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAccountSwitcherArrow']"
		[Register ("mAccountSwitcherArrow")]
		protected global::Android.Widget.ImageView MAccountSwitcherArrow {
			get {
				if (mAccountSwitcherArrow_jfieldId == IntPtr.Zero)
					mAccountSwitcherArrow_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountSwitcherArrow", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountSwitcherArrow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountSwitcherArrow_jfieldId == IntPtr.Zero)
					mAccountSwitcherArrow_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountSwitcherArrow", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountSwitcherArrow_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mActivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mActivity']"
		[Register ("mActivity")]
		protected global::Android.App.Activity MActivity {
			get {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mActivity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActivity_jfieldId == IntPtr.Zero)
					mActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActivity_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAlternativeProfileHeaderSwitching_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mAlternativeProfileHeaderSwitching']"
		[Register ("mAlternativeProfileHeaderSwitching")]
		protected bool MAlternativeProfileHeaderSwitching {
			get {
				if (mAlternativeProfileHeaderSwitching_jfieldId == IntPtr.Zero)
					mAlternativeProfileHeaderSwitching_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlternativeProfileHeaderSwitching", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mAlternativeProfileHeaderSwitching_jfieldId);
			}
			set {
				if (mAlternativeProfileHeaderSwitching_jfieldId == IntPtr.Zero)
					mAlternativeProfileHeaderSwitching_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlternativeProfileHeaderSwitching", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAlternativeProfileHeaderSwitching_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCloseDrawerOnProfileListClick_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCloseDrawerOnProfileListClick']"
		[Register ("mCloseDrawerOnProfileListClick")]
		protected global::Java.Lang.Boolean MCloseDrawerOnProfileListClick {
			get {
				if (mCloseDrawerOnProfileListClick_jfieldId == IntPtr.Zero)
					mCloseDrawerOnProfileListClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mCloseDrawerOnProfileListClick", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCloseDrawerOnProfileListClick_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCloseDrawerOnProfileListClick_jfieldId == IntPtr.Zero)
					mCloseDrawerOnProfileListClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mCloseDrawerOnProfileListClick", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCloseDrawerOnProfileListClick_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCompactStyle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCompactStyle']"
		[Register ("mCompactStyle")]
		protected bool MCompactStyle {
			get {
				if (mCompactStyle_jfieldId == IntPtr.Zero)
					mCompactStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompactStyle", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mCompactStyle_jfieldId);
			}
			set {
				if (mCompactStyle_jfieldId == IntPtr.Zero)
					mCompactStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompactStyle", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCompactStyle_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCurrentHiddenInList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCurrentHiddenInList']"
		[Register ("mCurrentHiddenInList")]
		protected bool MCurrentHiddenInList {
			get {
				if (mCurrentHiddenInList_jfieldId == IntPtr.Zero)
					mCurrentHiddenInList_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentHiddenInList", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mCurrentHiddenInList_jfieldId);
			}
			set {
				if (mCurrentHiddenInList_jfieldId == IntPtr.Zero)
					mCurrentHiddenInList_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentHiddenInList", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentHiddenInList_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCurrentProfile_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCurrentProfile']"
		[Register ("mCurrentProfile")]
		protected global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile MCurrentProfile {
			get {
				if (mCurrentProfile_jfieldId == IntPtr.Zero)
					mCurrentProfile_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfile", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCurrentProfile_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCurrentProfile_jfieldId == IntPtr.Zero)
					mCurrentProfile_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfile", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentProfile_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCurrentProfileEmail_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCurrentProfileEmail']"
		[Register ("mCurrentProfileEmail")]
		protected global::Android.Widget.TextView MCurrentProfileEmail {
			get {
				if (mCurrentProfileEmail_jfieldId == IntPtr.Zero)
					mCurrentProfileEmail_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfileEmail", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCurrentProfileEmail_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCurrentProfileEmail_jfieldId == IntPtr.Zero)
					mCurrentProfileEmail_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfileEmail", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentProfileEmail_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCurrentProfileName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCurrentProfileName']"
		[Register ("mCurrentProfileName")]
		protected global::Android.Widget.TextView MCurrentProfileName {
			get {
				if (mCurrentProfileName_jfieldId == IntPtr.Zero)
					mCurrentProfileName_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfileName", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCurrentProfileName_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCurrentProfileName_jfieldId == IntPtr.Zero)
					mCurrentProfileName_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfileName", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentProfileName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCurrentProfileView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mCurrentProfileView']"
		[Register ("mCurrentProfileView")]
		protected global::Com.Mikepenz.Materialdrawer.View.BezelImageView MCurrentProfileView {
			get {
				if (mCurrentProfileView_jfieldId == IntPtr.Zero)
					mCurrentProfileView_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfileView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCurrentProfileView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCurrentProfileView_jfieldId == IntPtr.Zero)
					mCurrentProfileView_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentProfileView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentProfileView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDividerBelowHeader_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mDividerBelowHeader']"
		[Register ("mDividerBelowHeader")]
		protected bool MDividerBelowHeader {
			get {
				if (mDividerBelowHeader_jfieldId == IntPtr.Zero)
					mDividerBelowHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mDividerBelowHeader", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mDividerBelowHeader_jfieldId);
			}
			set {
				if (mDividerBelowHeader_jfieldId == IntPtr.Zero)
					mDividerBelowHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mDividerBelowHeader", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDividerBelowHeader_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mDrawer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mDrawer']"
		[Register ("mDrawer")]
		protected global::Com.Mikepenz.Materialdrawer.Drawer MDrawer {
			get {
				if (mDrawer_jfieldId == IntPtr.Zero)
					mDrawer_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawer", "Lcom/mikepenz/materialdrawer/Drawer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDrawer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDrawer_jfieldId == IntPtr.Zero)
					mDrawer_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawer", "Lcom/mikepenz/materialdrawer/Drawer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDrawer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEmailTypeface_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mEmailTypeface']"
		[Register ("mEmailTypeface")]
		protected global::Android.Graphics.Typeface MEmailTypeface {
			get {
				if (mEmailTypeface_jfieldId == IntPtr.Zero)
					mEmailTypeface_jfieldId = JNIEnv.GetFieldID (class_ref, "mEmailTypeface", "Landroid/graphics/Typeface;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEmailTypeface_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEmailTypeface_jfieldId == IntPtr.Zero)
					mEmailTypeface_jfieldId = JNIEnv.GetFieldID (class_ref, "mEmailTypeface", "Landroid/graphics/Typeface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEmailTypeface_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHeaderBackground_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mHeaderBackground']"
		[Register ("mHeaderBackground")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder MHeaderBackground {
			get {
				if (mHeaderBackground_jfieldId == IntPtr.Zero)
					mHeaderBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderBackground", "Lcom/mikepenz/materialdrawer/holder/ImageHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeaderBackground_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeaderBackground_jfieldId == IntPtr.Zero)
					mHeaderBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderBackground", "Lcom/mikepenz/materialdrawer/holder/ImageHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaderBackground_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHeaderBackgroundScaleType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mHeaderBackgroundScaleType']"
		[Register ("mHeaderBackgroundScaleType")]
		protected global::Android.Widget.ImageView.ScaleType MHeaderBackgroundScaleType {
			get {
				if (mHeaderBackgroundScaleType_jfieldId == IntPtr.Zero)
					mHeaderBackgroundScaleType_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderBackgroundScaleType", "Landroid/widget/ImageView$ScaleType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeaderBackgroundScaleType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeaderBackgroundScaleType_jfieldId == IntPtr.Zero)
					mHeaderBackgroundScaleType_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderBackgroundScaleType", "Landroid/widget/ImageView$ScaleType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaderBackgroundScaleType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mHeight']"
		[Register ("mHeight")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder MHeight {
			get {
				if (mHeight_jfieldId == IntPtr.Zero)
					mHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeight_jfieldId == IntPtr.Zero)
					mHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeight_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mNameTypeface_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mNameTypeface']"
		[Register ("mNameTypeface")]
		protected global::Android.Graphics.Typeface MNameTypeface {
			get {
				if (mNameTypeface_jfieldId == IntPtr.Zero)
					mNameTypeface_jfieldId = JNIEnv.GetFieldID (class_ref, "mNameTypeface", "Landroid/graphics/Typeface;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mNameTypeface_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNameTypeface_jfieldId == IntPtr.Zero)
					mNameTypeface_jfieldId = JNIEnv.GetFieldID (class_ref, "mNameTypeface", "Landroid/graphics/Typeface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNameTypeface_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnAccountHeaderItemLongClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnAccountHeaderItemLongClickListener']"
		[Register ("mOnAccountHeaderItemLongClickListener")]
		protected global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener MOnAccountHeaderItemLongClickListener {
			get {
				if (mOnAccountHeaderItemLongClickListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderItemLongClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderItemLongClickListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderItemLongClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnAccountHeaderItemLongClickListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderItemLongClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderItemLongClickListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderItemLongClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnAccountHeaderListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnAccountHeaderListener']"
		[Register ("mOnAccountHeaderListener")]
		protected global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener MOnAccountHeaderListener {
			get {
				if (mOnAccountHeaderListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnAccountHeaderListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnAccountHeaderProfileImageListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnAccountHeaderProfileImageListener']"
		[Register ("mOnAccountHeaderProfileImageListener")]
		protected global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener MOnAccountHeaderProfileImageListener {
			get {
				if (mOnAccountHeaderProfileImageListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderProfileImageListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderProfileImageListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderProfileImageListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnAccountHeaderProfileImageListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderProfileImageListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderProfileImageListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderProfileImageListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnAccountHeaderSelectionViewClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnAccountHeaderSelectionViewClickListener']"
		[Register ("mOnAccountHeaderSelectionViewClickListener")]
		protected global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener MOnAccountHeaderSelectionViewClickListener {
			get {
				if (mOnAccountHeaderSelectionViewClickListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderSelectionViewClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderSelectionViewClickListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderSelectionViewClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnAccountHeaderSelectionViewClickListener_jfieldId == IntPtr.Zero)
					mOnAccountHeaderSelectionViewClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnAccountHeaderSelectionViewClickListener", "Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnAccountHeaderSelectionViewClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnProfileClickDrawerCloseDelay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnProfileClickDrawerCloseDelay']"
		[Register ("mOnProfileClickDrawerCloseDelay")]
		protected int MOnProfileClickDrawerCloseDelay {
			get {
				if (mOnProfileClickDrawerCloseDelay_jfieldId == IntPtr.Zero)
					mOnProfileClickDrawerCloseDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnProfileClickDrawerCloseDelay", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mOnProfileClickDrawerCloseDelay_jfieldId);
			}
			set {
				if (mOnProfileClickDrawerCloseDelay_jfieldId == IntPtr.Zero)
					mOnProfileClickDrawerCloseDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnProfileClickDrawerCloseDelay", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnProfileClickDrawerCloseDelay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOnlyMainProfileImageVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnlyMainProfileImageVisible']"
		[Register ("mOnlyMainProfileImageVisible")]
		protected bool MOnlyMainProfileImageVisible {
			get {
				if (mOnlyMainProfileImageVisible_jfieldId == IntPtr.Zero)
					mOnlyMainProfileImageVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnlyMainProfileImageVisible", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mOnlyMainProfileImageVisible_jfieldId);
			}
			set {
				if (mOnlyMainProfileImageVisible_jfieldId == IntPtr.Zero)
					mOnlyMainProfileImageVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnlyMainProfileImageVisible", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnlyMainProfileImageVisible_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOnlySmallProfileImagesVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mOnlySmallProfileImagesVisible']"
		[Register ("mOnlySmallProfileImagesVisible")]
		protected bool MOnlySmallProfileImagesVisible {
			get {
				if (mOnlySmallProfileImagesVisible_jfieldId == IntPtr.Zero)
					mOnlySmallProfileImagesVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnlySmallProfileImagesVisible", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mOnlySmallProfileImagesVisible_jfieldId);
			}
			set {
				if (mOnlySmallProfileImagesVisible_jfieldId == IntPtr.Zero)
					mOnlySmallProfileImagesVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnlySmallProfileImagesVisible", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnlySmallProfileImagesVisible_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPaddingBelowHeader_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mPaddingBelowHeader']"
		[Register ("mPaddingBelowHeader")]
		protected bool MPaddingBelowHeader {
			get {
				if (mPaddingBelowHeader_jfieldId == IntPtr.Zero)
					mPaddingBelowHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mPaddingBelowHeader", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mPaddingBelowHeader_jfieldId);
			}
			set {
				if (mPaddingBelowHeader_jfieldId == IntPtr.Zero)
					mPaddingBelowHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mPaddingBelowHeader", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPaddingBelowHeader_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mProfileFirst_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileFirst']"
		[Register ("mProfileFirst")]
		protected global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile MProfileFirst {
			get {
				if (mProfileFirst_jfieldId == IntPtr.Zero)
					mProfileFirst_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileFirst", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfileFirst_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfileFirst_jfieldId == IntPtr.Zero)
					mProfileFirst_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileFirst", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileFirst_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProfileFirstView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileFirstView']"
		[Register ("mProfileFirstView")]
		protected global::Com.Mikepenz.Materialdrawer.View.BezelImageView MProfileFirstView {
			get {
				if (mProfileFirstView_jfieldId == IntPtr.Zero)
					mProfileFirstView_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileFirstView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfileFirstView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfileFirstView_jfieldId == IntPtr.Zero)
					mProfileFirstView_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileFirstView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileFirstView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProfileImagesClickable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileImagesClickable']"
		[Register ("mProfileImagesClickable")]
		protected bool MProfileImagesClickable {
			get {
				if (mProfileImagesClickable_jfieldId == IntPtr.Zero)
					mProfileImagesClickable_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileImagesClickable", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mProfileImagesClickable_jfieldId);
			}
			set {
				if (mProfileImagesClickable_jfieldId == IntPtr.Zero)
					mProfileImagesClickable_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileImagesClickable", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileImagesClickable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mProfileImagesVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileImagesVisible']"
		[Register ("mProfileImagesVisible")]
		protected bool MProfileImagesVisible {
			get {
				if (mProfileImagesVisible_jfieldId == IntPtr.Zero)
					mProfileImagesVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileImagesVisible", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mProfileImagesVisible_jfieldId);
			}
			set {
				if (mProfileImagesVisible_jfieldId == IntPtr.Zero)
					mProfileImagesVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileImagesVisible", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileImagesVisible_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mProfileSecond_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileSecond']"
		[Register ("mProfileSecond")]
		protected global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile MProfileSecond {
			get {
				if (mProfileSecond_jfieldId == IntPtr.Zero)
					mProfileSecond_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileSecond", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfileSecond_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfileSecond_jfieldId == IntPtr.Zero)
					mProfileSecond_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileSecond", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileSecond_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProfileSecondView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileSecondView']"
		[Register ("mProfileSecondView")]
		protected global::Com.Mikepenz.Materialdrawer.View.BezelImageView MProfileSecondView {
			get {
				if (mProfileSecondView_jfieldId == IntPtr.Zero)
					mProfileSecondView_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileSecondView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfileSecondView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfileSecondView_jfieldId == IntPtr.Zero)
					mProfileSecondView_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileSecondView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileSecondView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProfileThird_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileThird']"
		[Register ("mProfileThird")]
		protected global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile MProfileThird {
			get {
				if (mProfileThird_jfieldId == IntPtr.Zero)
					mProfileThird_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileThird", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfileThird_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfileThird_jfieldId == IntPtr.Zero)
					mProfileThird_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileThird", "Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileThird_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProfileThirdView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfileThirdView']"
		[Register ("mProfileThirdView")]
		protected global::Com.Mikepenz.Materialdrawer.View.BezelImageView MProfileThirdView {
			get {
				if (mProfileThirdView_jfieldId == IntPtr.Zero)
					mProfileThirdView_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileThirdView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfileThirdView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.View.BezelImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfileThirdView_jfieldId == IntPtr.Zero)
					mProfileThirdView_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfileThirdView", "Lcom/mikepenz/materialdrawer/view/BezelImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfileThirdView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mProfiles_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mProfiles']"
		[Register ("mProfiles")]
		protected global::System.Collections.IList MProfiles {
			get {
				if (mProfiles_jfieldId == IntPtr.Zero)
					mProfiles_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfiles", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mProfiles_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mProfiles_jfieldId == IntPtr.Zero)
					mProfiles_jfieldId = JNIEnv.GetFieldID (class_ref, "mProfiles", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mProfiles_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mResetDrawerOnProfileListClick_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mResetDrawerOnProfileListClick']"
		[Register ("mResetDrawerOnProfileListClick")]
		protected bool MResetDrawerOnProfileListClick {
			get {
				if (mResetDrawerOnProfileListClick_jfieldId == IntPtr.Zero)
					mResetDrawerOnProfileListClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mResetDrawerOnProfileListClick", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mResetDrawerOnProfileListClick_jfieldId);
			}
			set {
				if (mResetDrawerOnProfileListClick_jfieldId == IntPtr.Zero)
					mResetDrawerOnProfileListClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mResetDrawerOnProfileListClick", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mResetDrawerOnProfileListClick_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSavedInstance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSavedInstance']"
		[Register ("mSavedInstance")]
		protected global::Android.OS.Bundle MSavedInstance {
			get {
				if (mSavedInstance_jfieldId == IntPtr.Zero)
					mSavedInstance_jfieldId = JNIEnv.GetFieldID (class_ref, "mSavedInstance", "Landroid/os/Bundle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSavedInstance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSavedInstance_jfieldId == IntPtr.Zero)
					mSavedInstance_jfieldId = JNIEnv.GetFieldID (class_ref, "mSavedInstance", "Landroid/os/Bundle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSavedInstance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSelectionFirstLine_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionFirstLine']"
		[Register ("mSelectionFirstLine")]
		protected string MSelectionFirstLine {
			get {
				if (mSelectionFirstLine_jfieldId == IntPtr.Zero)
					mSelectionFirstLine_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionFirstLine", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSelectionFirstLine_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSelectionFirstLine_jfieldId == IntPtr.Zero)
					mSelectionFirstLine_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionFirstLine", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionFirstLine_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSelectionFirstLineShown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionFirstLineShown']"
		[Register ("mSelectionFirstLineShown")]
		protected bool MSelectionFirstLineShown {
			get {
				if (mSelectionFirstLineShown_jfieldId == IntPtr.Zero)
					mSelectionFirstLineShown_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionFirstLineShown", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelectionFirstLineShown_jfieldId);
			}
			set {
				if (mSelectionFirstLineShown_jfieldId == IntPtr.Zero)
					mSelectionFirstLineShown_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionFirstLineShown", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionFirstLineShown_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectionListEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionListEnabled']"
		[Register ("mSelectionListEnabled")]
		protected bool MSelectionListEnabled {
			get {
				if (mSelectionListEnabled_jfieldId == IntPtr.Zero)
					mSelectionListEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionListEnabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelectionListEnabled_jfieldId);
			}
			set {
				if (mSelectionListEnabled_jfieldId == IntPtr.Zero)
					mSelectionListEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionListEnabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionListEnabled_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectionListEnabledForSingleProfile_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionListEnabledForSingleProfile']"
		[Register ("mSelectionListEnabledForSingleProfile")]
		protected bool MSelectionListEnabledForSingleProfile {
			get {
				if (mSelectionListEnabledForSingleProfile_jfieldId == IntPtr.Zero)
					mSelectionListEnabledForSingleProfile_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionListEnabledForSingleProfile", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelectionListEnabledForSingleProfile_jfieldId);
			}
			set {
				if (mSelectionListEnabledForSingleProfile_jfieldId == IntPtr.Zero)
					mSelectionListEnabledForSingleProfile_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionListEnabledForSingleProfile", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionListEnabledForSingleProfile_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectionListShown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionListShown']"
		[Register ("mSelectionListShown")]
		protected bool MSelectionListShown {
			get {
				if (mSelectionListShown_jfieldId == IntPtr.Zero)
					mSelectionListShown_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionListShown", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelectionListShown_jfieldId);
			}
			set {
				if (mSelectionListShown_jfieldId == IntPtr.Zero)
					mSelectionListShown_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionListShown", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionListShown_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectionSecondLine_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionSecondLine']"
		[Register ("mSelectionSecondLine")]
		protected string MSelectionSecondLine {
			get {
				if (mSelectionSecondLine_jfieldId == IntPtr.Zero)
					mSelectionSecondLine_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionSecondLine", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSelectionSecondLine_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSelectionSecondLine_jfieldId == IntPtr.Zero)
					mSelectionSecondLine_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionSecondLine", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionSecondLine_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSelectionSecondLineShown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mSelectionSecondLineShown']"
		[Register ("mSelectionSecondLineShown")]
		protected bool MSelectionSecondLineShown {
			get {
				if (mSelectionSecondLineShown_jfieldId == IntPtr.Zero)
					mSelectionSecondLineShown_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionSecondLineShown", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSelectionSecondLineShown_jfieldId);
			}
			set {
				if (mSelectionSecondLineShown_jfieldId == IntPtr.Zero)
					mSelectionSecondLineShown_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectionSecondLineShown", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectionSecondLineShown_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTextColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mTextColor']"
		[Register ("mTextColor")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder MTextColor {
			get {
				if (mTextColor_jfieldId == IntPtr.Zero)
					mTextColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextColor", "Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTextColor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTextColor_jfieldId == IntPtr.Zero)
					mTextColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextColor", "Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTextColor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mThreeSmallProfileImages_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mThreeSmallProfileImages']"
		[Register ("mThreeSmallProfileImages")]
		protected bool MThreeSmallProfileImages {
			get {
				if (mThreeSmallProfileImages_jfieldId == IntPtr.Zero)
					mThreeSmallProfileImages_jfieldId = JNIEnv.GetFieldID (class_ref, "mThreeSmallProfileImages", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mThreeSmallProfileImages_jfieldId);
			}
			set {
				if (mThreeSmallProfileImages_jfieldId == IntPtr.Zero)
					mThreeSmallProfileImages_jfieldId = JNIEnv.GetFieldID (class_ref, "mThreeSmallProfileImages", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mThreeSmallProfileImages_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTranslucentStatusBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mTranslucentStatusBar']"
		[Register ("mTranslucentStatusBar")]
		protected bool MTranslucentStatusBar {
			get {
				if (mTranslucentStatusBar_jfieldId == IntPtr.Zero)
					mTranslucentStatusBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mTranslucentStatusBar", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mTranslucentStatusBar_jfieldId);
			}
			set {
				if (mTranslucentStatusBar_jfieldId == IntPtr.Zero)
					mTranslucentStatusBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mTranslucentStatusBar", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTranslucentStatusBar_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTypeface_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/field[@name='mTypeface']"
		[Register ("mTypeface")]
		protected global::Android.Graphics.Typeface MTypeface {
			get {
				if (mTypeface_jfieldId == IntPtr.Zero)
					mTypeface_jfieldId = JNIEnv.GetFieldID (class_ref, "mTypeface", "Landroid/graphics/Typeface;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTypeface_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTypeface_jfieldId == IntPtr.Zero)
					mTypeface_jfieldId = JNIEnv.GetFieldID (class_ref, "mTypeface", "Landroid/graphics/Typeface;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTypeface_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/AccountHeaderBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountHeaderBuilder); }
		}

		protected AccountHeaderBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/constructor[@name='AccountHeaderBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccountHeaderBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AccountHeaderBuilder)) {
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

		static Delegate cb_getCurrentSelection;
#pragma warning disable 0169
		static Delegate GetGetCurrentSelectionHandler ()
		{
			if (cb_getCurrentSelection == null)
				cb_getCurrentSelection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentSelection);
			return cb_getCurrentSelection;
		}

		static int n_GetCurrentSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentSelection;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSelection;
		protected virtual unsafe int CurrentSelection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='getCurrentSelection' and count(parameter)=0]"
			[Register ("getCurrentSelection", "()I", "GetGetCurrentSelectionHandler")]
			get {
				if (id_getCurrentSelection == IntPtr.Zero)
					id_getCurrentSelection = JNIEnv.GetMethodID (class_ref, "getCurrentSelection", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentSelection);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSelection", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetAddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static IntPtr n_AddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddProfiles (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='addProfiles' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile...']]"
		[Register ("addProfiles", "([Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetAddProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder AddProfiles (params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile[] p0)
		{
			if (id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
				id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "addProfiles", "([Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addProfiles_arrayLcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addProfiles", "([Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/mikepenz/materialdrawer/AccountHeader;", "GetBuildHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeader Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mikepenz/materialdrawer/AccountHeader;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mikepenz/materialdrawer/AccountHeader;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildDrawerSelectionList;
#pragma warning disable 0169
		static Delegate GetBuildDrawerSelectionListHandler ()
		{
			if (cb_buildDrawerSelectionList == null)
				cb_buildDrawerSelectionList = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BuildDrawerSelectionList);
			return cb_buildDrawerSelectionList;
		}

		static void n_BuildDrawerSelectionList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuildDrawerSelectionList ();
		}
#pragma warning restore 0169

		static IntPtr id_buildDrawerSelectionList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='buildDrawerSelectionList' and count(parameter)=0]"
		[Register ("buildDrawerSelectionList", "()V", "GetBuildDrawerSelectionListHandler")]
		protected virtual unsafe void BuildDrawerSelectionList ()
		{
			if (id_buildDrawerSelectionList == IntPtr.Zero)
				id_buildDrawerSelectionList = JNIEnv.GetMethodID (class_ref, "buildDrawerSelectionList", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_buildDrawerSelectionList);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildDrawerSelectionList", "()V"));
			} finally {
			}
		}

		static Delegate cb_buildProfiles;
#pragma warning disable 0169
		static Delegate GetBuildProfilesHandler ()
		{
			if (cb_buildProfiles == null)
				cb_buildProfiles = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BuildProfiles);
			return cb_buildProfiles;
		}

		static void n_BuildProfiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuildProfiles ();
		}
#pragma warning restore 0169

		static IntPtr id_buildProfiles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='buildProfiles' and count(parameter)=0]"
		[Register ("buildProfiles", "()V", "GetBuildProfilesHandler")]
		protected virtual unsafe void BuildProfiles ()
		{
			if (id_buildProfiles == IntPtr.Zero)
				id_buildProfiles = JNIEnv.GetMethodID (class_ref, "buildProfiles", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_buildProfiles);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildProfiles", "()V"));
			} finally {
			}
		}

		static Delegate cb_calculateProfiles;
#pragma warning disable 0169
		static Delegate GetCalculateProfilesHandler ()
		{
			if (cb_calculateProfiles == null)
				cb_calculateProfiles = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculateProfiles);
			return cb_calculateProfiles;
		}

		static void n_CalculateProfiles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateProfiles ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateProfiles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='calculateProfiles' and count(parameter)=0]"
		[Register ("calculateProfiles", "()V", "GetCalculateProfilesHandler")]
		protected virtual unsafe void CalculateProfiles ()
		{
			if (id_calculateProfiles == IntPtr.Zero)
				id_calculateProfiles = JNIEnv.GetMethodID (class_ref, "calculateProfiles", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculateProfiles);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateProfiles", "()V"));
			} finally {
			}
		}

		static Delegate cb_onProfileClick_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetOnProfileClick_Landroid_view_View_ZHandler ()
		{
			if (cb_onProfileClick_Landroid_view_View_Z == null)
				cb_onProfileClick_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnProfileClick_Landroid_view_View_Z);
			return cb_onProfileClick_Landroid_view_View_Z;
		}

		static void n_OnProfileClick_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProfileClick (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onProfileClick_Landroid_view_View_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='onProfileClick' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("onProfileClick", "(Landroid/view/View;Z)V", "GetOnProfileClick_Landroid_view_View_ZHandler")]
		protected virtual unsafe void OnProfileClick (global::Android.Views.View p0, bool p1)
		{
			if (id_onProfileClick_Landroid_view_View_Z == IntPtr.Zero)
				id_onProfileClick_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "onProfileClick", "(Landroid/view/View;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProfileClick_Landroid_view_View_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProfileClick", "(Landroid/view/View;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
#pragma warning disable 0169
		static Delegate GetSwitchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler ()
		{
			if (cb_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == null)
				cb_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SwitchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_);
			return cb_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		}

		static bool n_SwitchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SwitchProfiles (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='switchProfiles' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IProfile']]"
		[Register ("switchProfiles", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Z", "GetSwitchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_Handler")]
		protected virtual unsafe bool SwitchProfiles (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile p0)
		{
			if (id_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ == IntPtr.Zero)
				id_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_ = JNIEnv.GetMethodID (class_ref, "switchProfiles", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_switchProfiles_Lcom_mikepenz_materialdrawer_model_interfaces_IProfile_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchProfiles", "(Lcom/mikepenz/materialdrawer/model/interfaces/IProfile;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_toggleSelectionList_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetToggleSelectionList_Landroid_content_Context_Handler ()
		{
			if (cb_toggleSelectionList_Landroid_content_Context_ == null)
				cb_toggleSelectionList_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToggleSelectionList_Landroid_content_Context_);
			return cb_toggleSelectionList_Landroid_content_Context_;
		}

		static void n_ToggleSelectionList_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToggleSelectionList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toggleSelectionList_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='toggleSelectionList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("toggleSelectionList", "(Landroid/content/Context;)V", "GetToggleSelectionList_Landroid_content_Context_Handler")]
		protected virtual unsafe void ToggleSelectionList (global::Android.Content.Context p0)
		{
			if (id_toggleSelectionList_Landroid_content_Context_ == IntPtr.Zero)
				id_toggleSelectionList_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "toggleSelectionList", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggleSelectionList_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleSelectionList", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateHeaderAndList;
#pragma warning disable 0169
		static Delegate GetUpdateHeaderAndListHandler ()
		{
			if (cb_updateHeaderAndList == null)
				cb_updateHeaderAndList = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateHeaderAndList);
			return cb_updateHeaderAndList;
		}

		static void n_UpdateHeaderAndList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateHeaderAndList ();
		}
#pragma warning restore 0169

		static IntPtr id_updateHeaderAndList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='updateHeaderAndList' and count(parameter)=0]"
		[Register ("updateHeaderAndList", "()V", "GetUpdateHeaderAndListHandler")]
		protected virtual unsafe void UpdateHeaderAndList ()
		{
			if (id_updateHeaderAndList == IntPtr.Zero)
				id_updateHeaderAndList = JNIEnv.GetMethodID (class_ref, "updateHeaderAndList", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateHeaderAndList);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateHeaderAndList", "()V"));
			} finally {
			}
		}

		static Delegate cb_withAccountHeader_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWithAccountHeader_Landroid_view_View_Handler ()
		{
			if (cb_withAccountHeader_Landroid_view_View_ == null)
				cb_withAccountHeader_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAccountHeader_Landroid_view_View_);
			return cb_withAccountHeader_Landroid_view_View_;
		}

		static IntPtr n_WithAccountHeader_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAccountHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAccountHeader_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withAccountHeader' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("withAccountHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithAccountHeader_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithAccountHeader (global::Android.Views.View p0)
		{
			if (id_withAccountHeader_Landroid_view_View_ == IntPtr.Zero)
				id_withAccountHeader_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "withAccountHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAccountHeader_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccountHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withAccountHeader_I;
#pragma warning disable 0169
		static Delegate GetWithAccountHeader_IHandler ()
		{
			if (cb_withAccountHeader_I == null)
				cb_withAccountHeader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithAccountHeader_I);
			return cb_withAccountHeader_I;
		}

		static IntPtr n_WithAccountHeader_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithAccountHeader (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withAccountHeader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withAccountHeader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withAccountHeader", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithAccountHeader_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithAccountHeader (int p0)
		{
			if (id_withAccountHeader_I == IntPtr.Zero)
				id_withAccountHeader_I = JNIEnv.GetMethodID (class_ref, "withAccountHeader", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAccountHeader_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccountHeader", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetWithActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_withActivity_Landroid_app_Activity_ == null)
				cb_withActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithActivity_Landroid_app_Activity_);
			return cb_withActivity_Landroid_app_Activity_;
		}

		static IntPtr n_WithActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithActivity (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("withActivity", "(Landroid/app/Activity;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithActivity (global::Android.App.Activity p0)
		{
			if (id_withActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_withActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "withActivity", "(Landroid/app/Activity;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withActivity_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withActivity", "(Landroid/app/Activity;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withAlternativeProfileHeaderSwitching_Z;
#pragma warning disable 0169
		static Delegate GetWithAlternativeProfileHeaderSwitching_ZHandler ()
		{
			if (cb_withAlternativeProfileHeaderSwitching_Z == null)
				cb_withAlternativeProfileHeaderSwitching_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithAlternativeProfileHeaderSwitching_Z);
			return cb_withAlternativeProfileHeaderSwitching_Z;
		}

		static IntPtr n_WithAlternativeProfileHeaderSwitching_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithAlternativeProfileHeaderSwitching (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withAlternativeProfileHeaderSwitching_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withAlternativeProfileHeaderSwitching' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withAlternativeProfileHeaderSwitching", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithAlternativeProfileHeaderSwitching_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithAlternativeProfileHeaderSwitching (bool p0)
		{
			if (id_withAlternativeProfileHeaderSwitching_Z == IntPtr.Zero)
				id_withAlternativeProfileHeaderSwitching_Z = JNIEnv.GetMethodID (class_ref, "withAlternativeProfileHeaderSwitching", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAlternativeProfileHeaderSwitching_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAlternativeProfileHeaderSwitching", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCloseDrawerOnProfileListClick_Z;
#pragma warning disable 0169
		static Delegate GetWithCloseDrawerOnProfileListClick_ZHandler ()
		{
			if (cb_withCloseDrawerOnProfileListClick_Z == null)
				cb_withCloseDrawerOnProfileListClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCloseDrawerOnProfileListClick_Z);
			return cb_withCloseDrawerOnProfileListClick_Z;
		}

		static IntPtr n_WithCloseDrawerOnProfileListClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCloseDrawerOnProfileListClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCloseDrawerOnProfileListClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withCloseDrawerOnProfileListClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withCloseDrawerOnProfileListClick", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithCloseDrawerOnProfileListClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithCloseDrawerOnProfileListClick (bool p0)
		{
			if (id_withCloseDrawerOnProfileListClick_Z == IntPtr.Zero)
				id_withCloseDrawerOnProfileListClick_Z = JNIEnv.GetMethodID (class_ref, "withCloseDrawerOnProfileListClick", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCloseDrawerOnProfileListClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCloseDrawerOnProfileListClick", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCompactStyle_Z;
#pragma warning disable 0169
		static Delegate GetWithCompactStyle_ZHandler ()
		{
			if (cb_withCompactStyle_Z == null)
				cb_withCompactStyle_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCompactStyle_Z);
			return cb_withCompactStyle_Z;
		}

		static IntPtr n_WithCompactStyle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCompactStyle (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCompactStyle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withCompactStyle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withCompactStyle", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithCompactStyle_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithCompactStyle (bool p0)
		{
			if (id_withCompactStyle_Z == IntPtr.Zero)
				id_withCompactStyle_Z = JNIEnv.GetMethodID (class_ref, "withCompactStyle", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCompactStyle_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCompactStyle", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCurrentProfileHiddenInList_Z;
#pragma warning disable 0169
		static Delegate GetWithCurrentProfileHiddenInList_ZHandler ()
		{
			if (cb_withCurrentProfileHiddenInList_Z == null)
				cb_withCurrentProfileHiddenInList_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCurrentProfileHiddenInList_Z);
			return cb_withCurrentProfileHiddenInList_Z;
		}

		static IntPtr n_WithCurrentProfileHiddenInList_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCurrentProfileHiddenInList (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCurrentProfileHiddenInList_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withCurrentProfileHiddenInList' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withCurrentProfileHiddenInList", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithCurrentProfileHiddenInList_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithCurrentProfileHiddenInList (bool p0)
		{
			if (id_withCurrentProfileHiddenInList_Z == IntPtr.Zero)
				id_withCurrentProfileHiddenInList_Z = JNIEnv.GetMethodID (class_ref, "withCurrentProfileHiddenInList", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCurrentProfileHiddenInList_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCurrentProfileHiddenInList", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDividerBelowHeader_Z;
#pragma warning disable 0169
		static Delegate GetWithDividerBelowHeader_ZHandler ()
		{
			if (cb_withDividerBelowHeader_Z == null)
				cb_withDividerBelowHeader_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithDividerBelowHeader_Z);
			return cb_withDividerBelowHeader_Z;
		}

		static IntPtr n_WithDividerBelowHeader_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDividerBelowHeader (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDividerBelowHeader_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withDividerBelowHeader' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withDividerBelowHeader", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithDividerBelowHeader_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithDividerBelowHeader (bool p0)
		{
			if (id_withDividerBelowHeader_Z == IntPtr.Zero)
				id_withDividerBelowHeader_Z = JNIEnv.GetMethodID (class_ref, "withDividerBelowHeader", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDividerBelowHeader_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDividerBelowHeader", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
#pragma warning disable 0169
		static Delegate GetWithDrawer_Lcom_mikepenz_materialdrawer_Drawer_Handler ()
		{
			if (cb_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_ == null)
				cb_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDrawer_Lcom_mikepenz_materialdrawer_Drawer_);
			return cb_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
		}

		static IntPtr n_WithDrawer_Lcom_mikepenz_materialdrawer_Drawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withDrawer' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer']]"
		[Register ("withDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithDrawer_Lcom_mikepenz_materialdrawer_Drawer_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithDrawer (global::Com.Mikepenz.Materialdrawer.Drawer p0)
		{
			if (id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_ == IntPtr.Zero)
				id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_ = JNIEnv.GetMethodID (class_ref, "withDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withEmailTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetWithEmailTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_withEmailTypeface_Landroid_graphics_Typeface_ == null)
				cb_withEmailTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithEmailTypeface_Landroid_graphics_Typeface_);
			return cb_withEmailTypeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_WithEmailTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithEmailTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withEmailTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withEmailTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("withEmailTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithEmailTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithEmailTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_withEmailTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_withEmailTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "withEmailTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEmailTypeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEmailTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withHeaderBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithHeaderBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_withHeaderBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_withHeaderBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithHeaderBackground_Landroid_graphics_drawable_Drawable_);
			return cb_withHeaderBackground_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithHeaderBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithHeaderBackground (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeaderBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withHeaderBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeaderBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeaderBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_withHeaderBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withHeaderBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "withHeaderBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderBackground_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderBackground", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
#pragma warning disable 0169
		static Delegate GetWithHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler ()
		{
			if (cb_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == null)
				cb_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_);
			return cb_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		}

		static IntPtr n_WithHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithHeaderBackground (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeaderBackground' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.ImageHolder']]"
		[Register ("withHeaderBackground", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeaderBackground (global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0)
		{
			if (id_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == IntPtr.Zero)
				id_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNIEnv.GetMethodID (class_ref, "withHeaderBackground", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderBackground_Lcom_mikepenz_materialdrawer_holder_ImageHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderBackground", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withHeaderBackground_I;
#pragma warning disable 0169
		static Delegate GetWithHeaderBackground_IHandler ()
		{
			if (cb_withHeaderBackground_I == null)
				cb_withHeaderBackground_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithHeaderBackground_I);
			return cb_withHeaderBackground_I;
		}

		static IntPtr n_WithHeaderBackground_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeaderBackground (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderBackground_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeaderBackground' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withHeaderBackground", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeaderBackground_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeaderBackground (int p0)
		{
			if (id_withHeaderBackground_I == IntPtr.Zero)
				id_withHeaderBackground_I = JNIEnv.GetMethodID (class_ref, "withHeaderBackground", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderBackground_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderBackground", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_;
#pragma warning disable 0169
		static Delegate GetWithHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_Handler ()
		{
			if (cb_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_ == null)
				cb_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_);
			return cb_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_;
		}

		static IntPtr n_WithHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView.ScaleType p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithHeaderBackgroundScaleType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeaderBackgroundScaleType' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView.ScaleType']]"
		[Register ("withHeaderBackgroundScaleType", "(Landroid/widget/ImageView$ScaleType;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeaderBackgroundScaleType (global::Android.Widget.ImageView.ScaleType p0)
		{
			if (id_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_ == IntPtr.Zero)
				id_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_ = JNIEnv.GetMethodID (class_ref, "withHeaderBackgroundScaleType", "(Landroid/widget/ImageView$ScaleType;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderBackgroundScaleType_Landroid_widget_ImageView_ScaleType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderBackgroundScaleType", "(Landroid/widget/ImageView$ScaleType;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withHeightDp_I;
#pragma warning disable 0169
		static Delegate GetWithHeightDp_IHandler ()
		{
			if (cb_withHeightDp_I == null)
				cb_withHeightDp_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithHeightDp_I);
			return cb_withHeightDp_I;
		}

		static IntPtr n_WithHeightDp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeightDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeightDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeightDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withHeightDp", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeightDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeightDp (int p0)
		{
			if (id_withHeightDp_I == IntPtr.Zero)
				id_withHeightDp_I = JNIEnv.GetMethodID (class_ref, "withHeightDp", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeightDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeightDp", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHeightPx_I;
#pragma warning disable 0169
		static Delegate GetWithHeightPx_IHandler ()
		{
			if (cb_withHeightPx_I == null)
				cb_withHeightPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithHeightPx_I);
			return cb_withHeightPx_I;
		}

		static IntPtr n_WithHeightPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeightPx (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeightPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeightPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withHeightPx", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeightPx_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeightPx (int p0)
		{
			if (id_withHeightPx_I == IntPtr.Zero)
				id_withHeightPx_I = JNIEnv.GetMethodID (class_ref, "withHeightPx", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeightPx_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeightPx", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHeightRes_I;
#pragma warning disable 0169
		static Delegate GetWithHeightRes_IHandler ()
		{
			if (cb_withHeightRes_I == null)
				cb_withHeightRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithHeightRes_I);
			return cb_withHeightRes_I;
		}

		static IntPtr n_WithHeightRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeightRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeightRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withHeightRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withHeightRes", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithHeightRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithHeightRes (int p0)
		{
			if (id_withHeightRes_I == IntPtr.Zero)
				id_withHeightRes_I = JNIEnv.GetMethodID (class_ref, "withHeightRes", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeightRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeightRes", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withNameTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetWithNameTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_withNameTypeface_Landroid_graphics_Typeface_ == null)
				cb_withNameTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithNameTypeface_Landroid_graphics_Typeface_);
			return cb_withNameTypeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_WithNameTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithNameTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withNameTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withNameTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("withNameTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithNameTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithNameTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_withNameTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_withNameTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "withNameTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withNameTypeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withNameTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_Handler ()
		{
			if (cb_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_ == null)
				cb_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_);
			return cb_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_;
		}

		static IntPtr n_WithOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener p0 = (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnAccountHeaderItemLongClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnAccountHeaderItemLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderItemLongClickListener']]"
		[Register ("withOnAccountHeaderItemLongClickListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnAccountHeaderItemLongClickListener (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderItemLongClickListener p0)
		{
			if (id_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_ == IntPtr.Zero)
				id_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnAccountHeaderItemLongClickListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnAccountHeaderItemLongClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderItemLongClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnAccountHeaderItemLongClickListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderItemLongClickListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_;
#pragma warning disable 0169
		static Delegate GetWithOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_Handler ()
		{
			if (cb_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_ == null)
				cb_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_);
			return cb_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_;
		}

		static IntPtr n_WithOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener p0 = (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnAccountHeaderListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnAccountHeaderListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderListener']]"
		[Register ("withOnAccountHeaderListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnAccountHeaderListener (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderListener p0)
		{
			if (id_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_ == IntPtr.Zero)
				id_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_ = JNIEnv.GetMethodID (class_ref, "withOnAccountHeaderListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnAccountHeaderListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnAccountHeaderListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_;
#pragma warning disable 0169
		static Delegate GetWithOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_Handler ()
		{
			if (cb_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_ == null)
				cb_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_);
			return cb_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_;
		}

		static IntPtr n_WithOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener p0 = (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnAccountHeaderProfileImageListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnAccountHeaderProfileImageListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderProfileImageListener']]"
		[Register ("withOnAccountHeaderProfileImageListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnAccountHeaderProfileImageListener (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderProfileImageListener p0)
		{
			if (id_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_ == IntPtr.Zero)
				id_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_ = JNIEnv.GetMethodID (class_ref, "withOnAccountHeaderProfileImageListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnAccountHeaderProfileImageListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderProfileImageListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnAccountHeaderProfileImageListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderProfileImageListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_Handler ()
		{
			if (cb_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_ == null)
				cb_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_);
			return cb_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_;
		}

		static IntPtr n_WithOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener p0 = (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnAccountHeaderSelectionViewClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnAccountHeaderSelectionViewClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader.OnAccountHeaderSelectionViewClickListener']]"
		[Register ("withOnAccountHeaderSelectionViewClickListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnAccountHeaderSelectionViewClickListener (global::Com.Mikepenz.Materialdrawer.AccountHeader.IOnAccountHeaderSelectionViewClickListener p0)
		{
			if (id_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_ == IntPtr.Zero)
				id_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnAccountHeaderSelectionViewClickListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnAccountHeaderSelectionViewClickListener_Lcom_mikepenz_materialdrawer_AccountHeader_OnAccountHeaderSelectionViewClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnAccountHeaderSelectionViewClickListener", "(Lcom/mikepenz/materialdrawer/AccountHeader$OnAccountHeaderSelectionViewClickListener;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnProfileClickDrawerCloseDelay_I;
#pragma warning disable 0169
		static Delegate GetWithOnProfileClickDrawerCloseDelay_IHandler ()
		{
			if (cb_withOnProfileClickDrawerCloseDelay_I == null)
				cb_withOnProfileClickDrawerCloseDelay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithOnProfileClickDrawerCloseDelay_I);
			return cb_withOnProfileClickDrawerCloseDelay_I;
		}

		static IntPtr n_WithOnProfileClickDrawerCloseDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithOnProfileClickDrawerCloseDelay (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withOnProfileClickDrawerCloseDelay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnProfileClickDrawerCloseDelay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withOnProfileClickDrawerCloseDelay", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnProfileClickDrawerCloseDelay_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnProfileClickDrawerCloseDelay (int p0)
		{
			if (id_withOnProfileClickDrawerCloseDelay_I == IntPtr.Zero)
				id_withOnProfileClickDrawerCloseDelay_I = JNIEnv.GetMethodID (class_ref, "withOnProfileClickDrawerCloseDelay", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnProfileClickDrawerCloseDelay_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnProfileClickDrawerCloseDelay", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnlyMainProfileImageVisible_Z;
#pragma warning disable 0169
		static Delegate GetWithOnlyMainProfileImageVisible_ZHandler ()
		{
			if (cb_withOnlyMainProfileImageVisible_Z == null)
				cb_withOnlyMainProfileImageVisible_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithOnlyMainProfileImageVisible_Z);
			return cb_withOnlyMainProfileImageVisible_Z;
		}

		static IntPtr n_WithOnlyMainProfileImageVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithOnlyMainProfileImageVisible (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withOnlyMainProfileImageVisible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnlyMainProfileImageVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withOnlyMainProfileImageVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnlyMainProfileImageVisible_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnlyMainProfileImageVisible (bool p0)
		{
			if (id_withOnlyMainProfileImageVisible_Z == IntPtr.Zero)
				id_withOnlyMainProfileImageVisible_Z = JNIEnv.GetMethodID (class_ref, "withOnlyMainProfileImageVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnlyMainProfileImageVisible_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnlyMainProfileImageVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnlySmallProfileImagesVisible_Z;
#pragma warning disable 0169
		static Delegate GetWithOnlySmallProfileImagesVisible_ZHandler ()
		{
			if (cb_withOnlySmallProfileImagesVisible_Z == null)
				cb_withOnlySmallProfileImagesVisible_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithOnlySmallProfileImagesVisible_Z);
			return cb_withOnlySmallProfileImagesVisible_Z;
		}

		static IntPtr n_WithOnlySmallProfileImagesVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithOnlySmallProfileImagesVisible (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withOnlySmallProfileImagesVisible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withOnlySmallProfileImagesVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withOnlySmallProfileImagesVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithOnlySmallProfileImagesVisible_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithOnlySmallProfileImagesVisible (bool p0)
		{
			if (id_withOnlySmallProfileImagesVisible_Z == IntPtr.Zero)
				id_withOnlySmallProfileImagesVisible_Z = JNIEnv.GetMethodID (class_ref, "withOnlySmallProfileImagesVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnlySmallProfileImagesVisible_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnlySmallProfileImagesVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withPaddingBelowHeader_Z;
#pragma warning disable 0169
		static Delegate GetWithPaddingBelowHeader_ZHandler ()
		{
			if (cb_withPaddingBelowHeader_Z == null)
				cb_withPaddingBelowHeader_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithPaddingBelowHeader_Z);
			return cb_withPaddingBelowHeader_Z;
		}

		static IntPtr n_WithPaddingBelowHeader_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPaddingBelowHeader (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPaddingBelowHeader_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withPaddingBelowHeader' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withPaddingBelowHeader", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithPaddingBelowHeader_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithPaddingBelowHeader (bool p0)
		{
			if (id_withPaddingBelowHeader_Z == IntPtr.Zero)
				id_withPaddingBelowHeader_Z = JNIEnv.GetMethodID (class_ref, "withPaddingBelowHeader", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPaddingBelowHeader_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPaddingBelowHeader", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withProfileImagesClickable_Z;
#pragma warning disable 0169
		static Delegate GetWithProfileImagesClickable_ZHandler ()
		{
			if (cb_withProfileImagesClickable_Z == null)
				cb_withProfileImagesClickable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithProfileImagesClickable_Z);
			return cb_withProfileImagesClickable_Z;
		}

		static IntPtr n_WithProfileImagesClickable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithProfileImagesClickable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withProfileImagesClickable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withProfileImagesClickable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withProfileImagesClickable", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithProfileImagesClickable_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithProfileImagesClickable (bool p0)
		{
			if (id_withProfileImagesClickable_Z == IntPtr.Zero)
				id_withProfileImagesClickable_Z = JNIEnv.GetMethodID (class_ref, "withProfileImagesClickable", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withProfileImagesClickable_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withProfileImagesClickable", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withProfileImagesVisible_Z;
#pragma warning disable 0169
		static Delegate GetWithProfileImagesVisible_ZHandler ()
		{
			if (cb_withProfileImagesVisible_Z == null)
				cb_withProfileImagesVisible_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithProfileImagesVisible_Z);
			return cb_withProfileImagesVisible_Z;
		}

		static IntPtr n_WithProfileImagesVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithProfileImagesVisible (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withProfileImagesVisible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withProfileImagesVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withProfileImagesVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithProfileImagesVisible_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithProfileImagesVisible (bool p0)
		{
			if (id_withProfileImagesVisible_Z == IntPtr.Zero)
				id_withProfileImagesVisible_Z = JNIEnv.GetMethodID (class_ref, "withProfileImagesVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withProfileImagesVisible_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withProfileImagesVisible", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withProfiles_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithProfiles_Ljava_util_List_Handler ()
		{
			if (cb_withProfiles_Ljava_util_List_ == null)
				cb_withProfiles_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithProfiles_Ljava_util_List_);
			return cb_withProfiles_Ljava_util_List_;
		}

		static IntPtr n_WithProfiles_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithProfiles (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withProfiles_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withProfiles' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IProfile&gt;']]"
		[Register ("withProfiles", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithProfiles_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithProfiles (global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile> p0)
		{
			if (id_withProfiles_Ljava_util_List_ == IntPtr.Zero)
				id_withProfiles_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withProfiles", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IProfile>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withProfiles_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withProfiles", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withResetDrawerOnProfileListClick_Z;
#pragma warning disable 0169
		static Delegate GetWithResetDrawerOnProfileListClick_ZHandler ()
		{
			if (cb_withResetDrawerOnProfileListClick_Z == null)
				cb_withResetDrawerOnProfileListClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithResetDrawerOnProfileListClick_Z);
			return cb_withResetDrawerOnProfileListClick_Z;
		}

		static IntPtr n_WithResetDrawerOnProfileListClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithResetDrawerOnProfileListClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withResetDrawerOnProfileListClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withResetDrawerOnProfileListClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withResetDrawerOnProfileListClick", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithResetDrawerOnProfileListClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithResetDrawerOnProfileListClick (bool p0)
		{
			if (id_withResetDrawerOnProfileListClick_Z == IntPtr.Zero)
				id_withResetDrawerOnProfileListClick_Z = JNIEnv.GetMethodID (class_ref, "withResetDrawerOnProfileListClick", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withResetDrawerOnProfileListClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withResetDrawerOnProfileListClick", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSavedInstance_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetWithSavedInstance_Landroid_os_Bundle_Handler ()
		{
			if (cb_withSavedInstance_Landroid_os_Bundle_ == null)
				cb_withSavedInstance_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSavedInstance_Landroid_os_Bundle_);
			return cb_withSavedInstance_Landroid_os_Bundle_;
		}

		static IntPtr n_WithSavedInstance_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSavedInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSavedInstance_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSavedInstance' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("withSavedInstance", "(Landroid/os/Bundle;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSavedInstance_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSavedInstance (global::Android.OS.Bundle p0)
		{
			if (id_withSavedInstance_Landroid_os_Bundle_ == IntPtr.Zero)
				id_withSavedInstance_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "withSavedInstance", "(Landroid/os/Bundle;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSavedInstance_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSavedInstance", "(Landroid/os/Bundle;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSelectionFirstLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSelectionFirstLine_Ljava_lang_String_Handler ()
		{
			if (cb_withSelectionFirstLine_Ljava_lang_String_ == null)
				cb_withSelectionFirstLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSelectionFirstLine_Ljava_lang_String_);
			return cb_withSelectionFirstLine_Ljava_lang_String_;
		}

		static IntPtr n_WithSelectionFirstLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSelectionFirstLine (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionFirstLine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionFirstLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSelectionFirstLine", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionFirstLine_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionFirstLine (string p0)
		{
			if (id_withSelectionFirstLine_Ljava_lang_String_ == IntPtr.Zero)
				id_withSelectionFirstLine_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSelectionFirstLine", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionFirstLine_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionFirstLine", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withSelectionFirstLineShown_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectionFirstLineShown_ZHandler ()
		{
			if (cb_withSelectionFirstLineShown_Z == null)
				cb_withSelectionFirstLineShown_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectionFirstLineShown_Z);
			return cb_withSelectionFirstLineShown_Z;
		}

		static IntPtr n_WithSelectionFirstLineShown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectionFirstLineShown (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionFirstLineShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionFirstLineShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectionFirstLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionFirstLineShown_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionFirstLineShown (bool p0)
		{
			if (id_withSelectionFirstLineShown_Z == IntPtr.Zero)
				id_withSelectionFirstLineShown_Z = JNIEnv.GetMethodID (class_ref, "withSelectionFirstLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionFirstLineShown_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionFirstLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectionFistLineShown_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectionFistLineShown_ZHandler ()
		{
			if (cb_withSelectionFistLineShown_Z == null)
				cb_withSelectionFistLineShown_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectionFistLineShown_Z);
			return cb_withSelectionFistLineShown_Z;
		}

		static IntPtr n_WithSelectionFistLineShown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectionFistLineShown (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionFistLineShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionFistLineShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("withSelectionFistLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionFistLineShown_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionFistLineShown (bool p0)
		{
			if (id_withSelectionFistLineShown_Z == IntPtr.Zero)
				id_withSelectionFistLineShown_Z = JNIEnv.GetMethodID (class_ref, "withSelectionFistLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionFistLineShown_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionFistLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectionListEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectionListEnabled_ZHandler ()
		{
			if (cb_withSelectionListEnabled_Z == null)
				cb_withSelectionListEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectionListEnabled_Z);
			return cb_withSelectionListEnabled_Z;
		}

		static IntPtr n_WithSelectionListEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectionListEnabled (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionListEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionListEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectionListEnabled", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionListEnabled_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionListEnabled (bool p0)
		{
			if (id_withSelectionListEnabled_Z == IntPtr.Zero)
				id_withSelectionListEnabled_Z = JNIEnv.GetMethodID (class_ref, "withSelectionListEnabled", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionListEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionListEnabled", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectionListEnabledForSingleProfile_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectionListEnabledForSingleProfile_ZHandler ()
		{
			if (cb_withSelectionListEnabledForSingleProfile_Z == null)
				cb_withSelectionListEnabledForSingleProfile_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectionListEnabledForSingleProfile_Z);
			return cb_withSelectionListEnabledForSingleProfile_Z;
		}

		static IntPtr n_WithSelectionListEnabledForSingleProfile_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectionListEnabledForSingleProfile (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionListEnabledForSingleProfile_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionListEnabledForSingleProfile' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectionListEnabledForSingleProfile", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionListEnabledForSingleProfile_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionListEnabledForSingleProfile (bool p0)
		{
			if (id_withSelectionListEnabledForSingleProfile_Z == IntPtr.Zero)
				id_withSelectionListEnabledForSingleProfile_Z = JNIEnv.GetMethodID (class_ref, "withSelectionListEnabledForSingleProfile", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionListEnabledForSingleProfile_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionListEnabledForSingleProfile", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectionSecondLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSelectionSecondLine_Ljava_lang_String_Handler ()
		{
			if (cb_withSelectionSecondLine_Ljava_lang_String_ == null)
				cb_withSelectionSecondLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSelectionSecondLine_Ljava_lang_String_);
			return cb_withSelectionSecondLine_Ljava_lang_String_;
		}

		static IntPtr n_WithSelectionSecondLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSelectionSecondLine (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionSecondLine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionSecondLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSelectionSecondLine", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionSecondLine_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionSecondLine (string p0)
		{
			if (id_withSelectionSecondLine_Ljava_lang_String_ == IntPtr.Zero)
				id_withSelectionSecondLine_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSelectionSecondLine", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionSecondLine_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionSecondLine", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withSelectionSecondLineShown_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectionSecondLineShown_ZHandler ()
		{
			if (cb_withSelectionSecondLineShown_Z == null)
				cb_withSelectionSecondLineShown_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectionSecondLineShown_Z);
			return cb_withSelectionSecondLineShown_Z;
		}

		static IntPtr n_WithSelectionSecondLineShown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectionSecondLineShown (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectionSecondLineShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withSelectionSecondLineShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectionSecondLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithSelectionSecondLineShown_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithSelectionSecondLineShown (bool p0)
		{
			if (id_withSelectionSecondLineShown_Z == IntPtr.Zero)
				id_withSelectionSecondLineShown_Z = JNIEnv.GetMethodID (class_ref, "withSelectionSecondLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectionSecondLineShown_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectionSecondLineShown", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withTextColor", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithTextColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithTextColor (int p0)
		{
			if (id_withTextColor_I == IntPtr.Zero)
				id_withTextColor_I = JNIEnv.GetMethodID (class_ref, "withTextColor", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTextColor", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTextColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithTextColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithTextColorRes (int p0)
		{
			if (id_withTextColorRes_I == IntPtr.Zero)
				id_withTextColorRes_I = JNIEnv.GetMethodID (class_ref, "withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTextColorRes", "(I)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withThreeSmallProfileImages_Z;
#pragma warning disable 0169
		static Delegate GetWithThreeSmallProfileImages_ZHandler ()
		{
			if (cb_withThreeSmallProfileImages_Z == null)
				cb_withThreeSmallProfileImages_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithThreeSmallProfileImages_Z);
			return cb_withThreeSmallProfileImages_Z;
		}

		static IntPtr n_WithThreeSmallProfileImages_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithThreeSmallProfileImages (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withThreeSmallProfileImages_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withThreeSmallProfileImages' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withThreeSmallProfileImages", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithThreeSmallProfileImages_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithThreeSmallProfileImages (bool p0)
		{
			if (id_withThreeSmallProfileImages_Z == IntPtr.Zero)
				id_withThreeSmallProfileImages_Z = JNIEnv.GetMethodID (class_ref, "withThreeSmallProfileImages", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withThreeSmallProfileImages_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withThreeSmallProfileImages", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTranslucentStatusBar_Z;
#pragma warning disable 0169
		static Delegate GetWithTranslucentStatusBar_ZHandler ()
		{
			if (cb_withTranslucentStatusBar_Z == null)
				cb_withTranslucentStatusBar_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithTranslucentStatusBar_Z);
			return cb_withTranslucentStatusBar_Z;
		}

		static IntPtr n_WithTranslucentStatusBar_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTranslucentStatusBar (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTranslucentStatusBar_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withTranslucentStatusBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withTranslucentStatusBar", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithTranslucentStatusBar_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithTranslucentStatusBar (bool p0)
		{
			if (id_withTranslucentStatusBar_Z == IntPtr.Zero)
				id_withTranslucentStatusBar_Z = JNIEnv.GetMethodID (class_ref, "withTranslucentStatusBar", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTranslucentStatusBar_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTranslucentStatusBar", "(Z)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='AccountHeaderBuilder']/method[@name='withTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("withTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;", "GetWithTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder WithTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_withTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_withTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "withTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTypeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeaderBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTypeface", "(Landroid/graphics/Typeface;)Lcom/mikepenz/materialdrawer/AccountHeaderBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
