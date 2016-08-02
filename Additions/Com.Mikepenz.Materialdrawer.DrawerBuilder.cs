using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/DrawerBuilder", DoNotGenerateAcw=true)]
	public partial class DrawerBuilder : global::Java.Lang.Object {


		static IntPtr mAccountHeader_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mAccountHeader']"
		[Register ("mAccountHeader")]
		protected global::Com.Mikepenz.Materialdrawer.AccountHeader MAccountHeader {
			get {
				if (mAccountHeader_jfieldId == IntPtr.Zero)
					mAccountHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeader", "Lcom/mikepenz/materialdrawer/AccountHeader;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountHeader_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountHeader_jfieldId == IntPtr.Zero)
					mAccountHeader_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeader", "Lcom/mikepenz/materialdrawer/AccountHeader;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeader_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccountHeaderSticky_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mAccountHeaderSticky']"
		[Register ("mAccountHeaderSticky")]
		protected bool MAccountHeaderSticky {
			get {
				if (mAccountHeaderSticky_jfieldId == IntPtr.Zero)
					mAccountHeaderSticky_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderSticky", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mAccountHeaderSticky_jfieldId);
			}
			set {
				if (mAccountHeaderSticky_jfieldId == IntPtr.Zero)
					mAccountHeaderSticky_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountHeaderSticky", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountHeaderSticky_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mActionBarDrawerToggle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mActionBarDrawerToggle']"
		[Register ("mActionBarDrawerToggle")]
		protected global::Android.Support.V7.App.ActionBarDrawerToggle MActionBarDrawerToggle {
			get {
				if (mActionBarDrawerToggle_jfieldId == IntPtr.Zero)
					mActionBarDrawerToggle_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionBarDrawerToggle", "Landroid/support/v7/app/ActionBarDrawerToggle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mActionBarDrawerToggle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBarDrawerToggle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActionBarDrawerToggle_jfieldId == IntPtr.Zero)
					mActionBarDrawerToggle_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionBarDrawerToggle", "Landroid/support/v7/app/ActionBarDrawerToggle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActionBarDrawerToggle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mActionBarDrawerToggleEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mActionBarDrawerToggleEnabled']"
		[Register ("mActionBarDrawerToggleEnabled")]
		protected bool MActionBarDrawerToggleEnabled {
			get {
				if (mActionBarDrawerToggleEnabled_jfieldId == IntPtr.Zero)
					mActionBarDrawerToggleEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionBarDrawerToggleEnabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mActionBarDrawerToggleEnabled_jfieldId);
			}
			set {
				if (mActionBarDrawerToggleEnabled_jfieldId == IntPtr.Zero)
					mActionBarDrawerToggleEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionBarDrawerToggleEnabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActionBarDrawerToggleEnabled_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mActivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mActivity']"
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

		static IntPtr mAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mAdapter']"
		[Register ("mAdapter")]
		protected global::Com.Mikepenz.Fastadapter.FastAdapter MAdapter {
			get {
				if (mAdapter_jfieldId == IntPtr.Zero)
					mAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdapter", "Lcom/mikepenz/fastadapter/FastAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdapter_jfieldId == IntPtr.Zero)
					mAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdapter", "Lcom/mikepenz/fastadapter/FastAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAdapterWrapper_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mAdapterWrapper']"
		[Register ("mAdapterWrapper")]
		protected global::Android.Support.V7.Widget.RecyclerView.Adapter MAdapterWrapper {
			get {
				if (mAdapterWrapper_jfieldId == IntPtr.Zero)
					mAdapterWrapper_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdapterWrapper", "Landroid/support/v7/widget/RecyclerView$Adapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAdapterWrapper_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.Adapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdapterWrapper_jfieldId == IntPtr.Zero)
					mAdapterWrapper_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdapterWrapper", "Landroid/support/v7/widget/RecyclerView$Adapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAdapterWrapper_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAnimateActionBarDrawerToggle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mAnimateActionBarDrawerToggle']"
		[Register ("mAnimateActionBarDrawerToggle")]
		protected bool MAnimateActionBarDrawerToggle {
			get {
				if (mAnimateActionBarDrawerToggle_jfieldId == IntPtr.Zero)
					mAnimateActionBarDrawerToggle_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnimateActionBarDrawerToggle", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mAnimateActionBarDrawerToggle_jfieldId);
			}
			set {
				if (mAnimateActionBarDrawerToggle_jfieldId == IntPtr.Zero)
					mAnimateActionBarDrawerToggle_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnimateActionBarDrawerToggle", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAnimateActionBarDrawerToggle_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mAppended_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mAppended']"
		[Register ("mAppended")]
		protected bool MAppended {
			get {
				if (mAppended_jfieldId == IntPtr.Zero)
					mAppended_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppended", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mAppended_jfieldId);
			}
			set {
				if (mAppended_jfieldId == IntPtr.Zero)
					mAppended_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppended", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAppended_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCloseOnClick_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mCloseOnClick']"
		[Register ("mCloseOnClick")]
		protected bool MCloseOnClick {
			get {
				if (mCloseOnClick_jfieldId == IntPtr.Zero)
					mCloseOnClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mCloseOnClick", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mCloseOnClick_jfieldId);
			}
			set {
				if (mCloseOnClick_jfieldId == IntPtr.Zero)
					mCloseOnClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mCloseOnClick", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCloseOnClick_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCurrentStickyFooterSelection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mCurrentStickyFooterSelection']"
		[Register ("mCurrentStickyFooterSelection")]
		protected int MCurrentStickyFooterSelection {
			get {
				if (mCurrentStickyFooterSelection_jfieldId == IntPtr.Zero)
					mCurrentStickyFooterSelection_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentStickyFooterSelection", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCurrentStickyFooterSelection_jfieldId);
			}
			set {
				if (mCurrentStickyFooterSelection_jfieldId == IntPtr.Zero)
					mCurrentStickyFooterSelection_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentStickyFooterSelection", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentStickyFooterSelection_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCustomView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mCustomView']"
		[Register ("mCustomView")]
		protected global::Android.Views.View MCustomView {
			get {
				if (mCustomView_jfieldId == IntPtr.Zero)
					mCustomView_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCustomView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCustomView_jfieldId == IntPtr.Zero)
					mCustomView_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCustomView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDelayDrawerClickEvent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mDelayDrawerClickEvent']"
		[Register ("mDelayDrawerClickEvent")]
		protected int MDelayDrawerClickEvent {
			get {
				if (mDelayDrawerClickEvent_jfieldId == IntPtr.Zero)
					mDelayDrawerClickEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "mDelayDrawerClickEvent", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mDelayDrawerClickEvent_jfieldId);
			}
			set {
				if (mDelayDrawerClickEvent_jfieldId == IntPtr.Zero)
					mDelayDrawerClickEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "mDelayDrawerClickEvent", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDelayDrawerClickEvent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mDelayOnDrawerClose_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mDelayOnDrawerClose']"
		[Register ("mDelayOnDrawerClose")]
		protected int MDelayOnDrawerClose {
			get {
				if (mDelayOnDrawerClose_jfieldId == IntPtr.Zero)
					mDelayOnDrawerClose_jfieldId = JNIEnv.GetFieldID (class_ref, "mDelayOnDrawerClose", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mDelayOnDrawerClose_jfieldId);
			}
			set {
				if (mDelayOnDrawerClose_jfieldId == IntPtr.Zero)
					mDelayOnDrawerClose_jfieldId = JNIEnv.GetFieldID (class_ref, "mDelayOnDrawerClose", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDelayOnDrawerClose_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mDisplayBelowStatusBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mDisplayBelowStatusBar']"
		[Register ("mDisplayBelowStatusBar")]
		protected global::Java.Lang.Boolean MDisplayBelowStatusBar {
			get {
				if (mDisplayBelowStatusBar_jfieldId == IntPtr.Zero)
					mDisplayBelowStatusBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mDisplayBelowStatusBar", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDisplayBelowStatusBar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDisplayBelowStatusBar_jfieldId == IntPtr.Zero)
					mDisplayBelowStatusBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mDisplayBelowStatusBar", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDisplayBelowStatusBar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDrawerGravity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mDrawerGravity']"
		[Register ("mDrawerGravity")]
		protected global::Java.Lang.Integer MDrawerGravity {
			get {
				if (mDrawerGravity_jfieldId == IntPtr.Zero)
					mDrawerGravity_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerGravity", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDrawerGravity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDrawerGravity_jfieldId == IntPtr.Zero)
					mDrawerGravity_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerGravity", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDrawerGravity_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDrawerLayout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mDrawerLayout']"
		[Register ("mDrawerLayout")]
		protected global::Android.Support.V4.Widget.DrawerLayout MDrawerLayout {
			get {
				if (mDrawerLayout_jfieldId == IntPtr.Zero)
					mDrawerLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerLayout", "Landroid/support/v4/widget/DrawerLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDrawerLayout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V4.Widget.DrawerLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDrawerLayout_jfieldId == IntPtr.Zero)
					mDrawerLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerLayout", "Landroid/support/v4/widget/DrawerLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDrawerLayout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDrawerWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mDrawerWidth']"
		[Register ("mDrawerWidth")]
		protected int MDrawerWidth {
			get {
				if (mDrawerWidth_jfieldId == IntPtr.Zero)
					mDrawerWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mDrawerWidth_jfieldId);
			}
			set {
				if (mDrawerWidth_jfieldId == IntPtr.Zero)
					mDrawerWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawerWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDrawerWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFireInitialOnClick_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mFireInitialOnClick']"
		[Register ("mFireInitialOnClick")]
		protected bool MFireInitialOnClick {
			get {
				if (mFireInitialOnClick_jfieldId == IntPtr.Zero)
					mFireInitialOnClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mFireInitialOnClick", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mFireInitialOnClick_jfieldId);
			}
			set {
				if (mFireInitialOnClick_jfieldId == IntPtr.Zero)
					mFireInitialOnClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mFireInitialOnClick", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFireInitialOnClick_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFooterAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mFooterAdapter']"
		[Register ("mFooterAdapter")]
		protected global::Com.Mikepenz.Fastadapter.Adapters.FooterAdapter MFooterAdapter {
			get {
				if (mFooterAdapter_jfieldId == IntPtr.Zero)
					mFooterAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterAdapter", "Lcom/mikepenz/fastadapter/adapters/FooterAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFooterAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FooterAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFooterAdapter_jfieldId == IntPtr.Zero)
					mFooterAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterAdapter", "Lcom/mikepenz/fastadapter/adapters/FooterAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFooterAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFooterClickable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mFooterClickable']"
		[Register ("mFooterClickable")]
		protected bool MFooterClickable {
			get {
				if (mFooterClickable_jfieldId == IntPtr.Zero)
					mFooterClickable_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterClickable", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mFooterClickable_jfieldId);
			}
			set {
				if (mFooterClickable_jfieldId == IntPtr.Zero)
					mFooterClickable_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterClickable", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFooterClickable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFooterDivider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mFooterDivider']"
		[Register ("mFooterDivider")]
		protected bool MFooterDivider {
			get {
				if (mFooterDivider_jfieldId == IntPtr.Zero)
					mFooterDivider_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterDivider", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mFooterDivider_jfieldId);
			}
			set {
				if (mFooterDivider_jfieldId == IntPtr.Zero)
					mFooterDivider_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterDivider", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFooterDivider_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFooterView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mFooterView']"
		[Register ("mFooterView")]
		protected global::Android.Views.View MFooterView {
			get {
				if (mFooterView_jfieldId == IntPtr.Zero)
					mFooterView_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFooterView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFooterView_jfieldId == IntPtr.Zero)
					mFooterView_jfieldId = JNIEnv.GetFieldID (class_ref, "mFooterView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFooterView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFullscreen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mFullscreen']"
		[Register ("mFullscreen")]
		protected bool MFullscreen {
			get {
				if (mFullscreen_jfieldId == IntPtr.Zero)
					mFullscreen_jfieldId = JNIEnv.GetFieldID (class_ref, "mFullscreen", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mFullscreen_jfieldId);
			}
			set {
				if (mFullscreen_jfieldId == IntPtr.Zero)
					mFullscreen_jfieldId = JNIEnv.GetFieldID (class_ref, "mFullscreen", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFullscreen_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mGenerateMiniDrawer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mGenerateMiniDrawer']"
		[Register ("mGenerateMiniDrawer")]
		protected bool MGenerateMiniDrawer {
			get {
				if (mGenerateMiniDrawer_jfieldId == IntPtr.Zero)
					mGenerateMiniDrawer_jfieldId = JNIEnv.GetFieldID (class_ref, "mGenerateMiniDrawer", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mGenerateMiniDrawer_jfieldId);
			}
			set {
				if (mGenerateMiniDrawer_jfieldId == IntPtr.Zero)
					mGenerateMiniDrawer_jfieldId = JNIEnv.GetFieldID (class_ref, "mGenerateMiniDrawer", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGenerateMiniDrawer_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHasStableIds_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mHasStableIds']"
		[Register ("mHasStableIds")]
		protected bool MHasStableIds {
			get {
				if (mHasStableIds_jfieldId == IntPtr.Zero)
					mHasStableIds_jfieldId = JNIEnv.GetFieldID (class_ref, "mHasStableIds", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mHasStableIds_jfieldId);
			}
			set {
				if (mHasStableIds_jfieldId == IntPtr.Zero)
					mHasStableIds_jfieldId = JNIEnv.GetFieldID (class_ref, "mHasStableIds", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHasStableIds_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHeaderAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mHeaderAdapter']"
		[Register ("mHeaderAdapter")]
		protected global::Com.Mikepenz.Fastadapter.Adapters.HeaderAdapter MHeaderAdapter {
			get {
				if (mHeaderAdapter_jfieldId == IntPtr.Zero)
					mHeaderAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderAdapter", "Lcom/mikepenz/fastadapter/adapters/HeaderAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeaderAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.HeaderAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeaderAdapter_jfieldId == IntPtr.Zero)
					mHeaderAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderAdapter", "Lcom/mikepenz/fastadapter/adapters/HeaderAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaderAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHeaderDivider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mHeaderDivider']"
		[Register ("mHeaderDivider")]
		protected bool MHeaderDivider {
			get {
				if (mHeaderDivider_jfieldId == IntPtr.Zero)
					mHeaderDivider_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderDivider", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mHeaderDivider_jfieldId);
			}
			set {
				if (mHeaderDivider_jfieldId == IntPtr.Zero)
					mHeaderDivider_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderDivider", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaderDivider_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHeaderPadding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mHeaderPadding']"
		[Register ("mHeaderPadding")]
		protected bool MHeaderPadding {
			get {
				if (mHeaderPadding_jfieldId == IntPtr.Zero)
					mHeaderPadding_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderPadding", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mHeaderPadding_jfieldId);
			}
			set {
				if (mHeaderPadding_jfieldId == IntPtr.Zero)
					mHeaderPadding_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderPadding", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaderPadding_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHeaderView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mHeaderView']"
		[Register ("mHeaderView")]
		protected global::Android.Views.View MHeaderView {
			get {
				if (mHeaderView_jfieldId == IntPtr.Zero)
					mHeaderView_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeaderView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeaderView_jfieldId == IntPtr.Zero)
					mHeaderView_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaderView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaderView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHeiderHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mHeiderHeight']"
		[Register ("mHeiderHeight")]
		protected global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder MHeiderHeight {
			get {
				if (mHeiderHeight_jfieldId == IntPtr.Zero)
					mHeiderHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeiderHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeiderHeight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeiderHeight_jfieldId == IntPtr.Zero)
					mHeiderHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeiderHeight", "Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeiderHeight_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mItemAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mItemAdapter']"
		[Register ("mItemAdapter")]
		protected global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter MItemAdapter {
			get {
				if (mItemAdapter_jfieldId == IntPtr.Zero)
					mItemAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemAdapter", "Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mItemAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItemAdapter_jfieldId == IntPtr.Zero)
					mItemAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemAdapter", "Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mItemAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mItemAnimator_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mItemAnimator']"
		[Register ("mItemAnimator")]
		protected global::Android.Support.V7.Widget.RecyclerView.ItemAnimator MItemAnimator {
			get {
				if (mItemAnimator_jfieldId == IntPtr.Zero)
					mItemAnimator_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemAnimator", "Landroid/support/v7/widget/RecyclerView$ItemAnimator;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mItemAnimator_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ItemAnimator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItemAnimator_jfieldId == IntPtr.Zero)
					mItemAnimator_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemAnimator", "Landroid/support/v7/widget/RecyclerView$ItemAnimator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mItemAnimator_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLayoutManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mLayoutManager']"
		[Register ("mLayoutManager")]
		protected global::Android.Support.V7.Widget.RecyclerView.LayoutManager MLayoutManager {
			get {
				if (mLayoutManager_jfieldId == IntPtr.Zero)
					mLayoutManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mLayoutManager", "Landroid/support/v7/widget/RecyclerView$LayoutManager;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mLayoutManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.LayoutManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLayoutManager_jfieldId == IntPtr.Zero)
					mLayoutManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mLayoutManager", "Landroid/support/v7/widget/RecyclerView$LayoutManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLayoutManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMaterialize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mMaterialize']"
		[Register ("mMaterialize")]
		protected global::Com.Mikepenz.Materialize.Materialize MMaterialize {
			get {
				if (mMaterialize_jfieldId == IntPtr.Zero)
					mMaterialize_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaterialize", "Lcom/mikepenz/materialize/Materialize;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMaterialize_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialize.Materialize> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMaterialize_jfieldId == IntPtr.Zero)
					mMaterialize_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaterialize", "Lcom/mikepenz/materialize/Materialize;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaterialize_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMiniDrawer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mMiniDrawer']"
		[Register ("mMiniDrawer")]
		protected global::Com.Mikepenz.Materialdrawer.MiniDrawer MMiniDrawer {
			get {
				if (mMiniDrawer_jfieldId == IntPtr.Zero)
					mMiniDrawer_jfieldId = JNIEnv.GetFieldID (class_ref, "mMiniDrawer", "Lcom/mikepenz/materialdrawer/MiniDrawer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMiniDrawer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMiniDrawer_jfieldId == IntPtr.Zero)
					mMiniDrawer_jfieldId = JNIEnv.GetFieldID (class_ref, "mMiniDrawer", "Lcom/mikepenz/materialdrawer/MiniDrawer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMiniDrawer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMultiSelect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mMultiSelect']"
		[Register ("mMultiSelect")]
		protected bool MMultiSelect {
			get {
				if (mMultiSelect_jfieldId == IntPtr.Zero)
					mMultiSelect_jfieldId = JNIEnv.GetFieldID (class_ref, "mMultiSelect", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mMultiSelect_jfieldId);
			}
			set {
				if (mMultiSelect_jfieldId == IntPtr.Zero)
					mMultiSelect_jfieldId = JNIEnv.GetFieldID (class_ref, "mMultiSelect", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMultiSelect_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOnDrawerItemClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mOnDrawerItemClickListener']"
		[Register ("mOnDrawerItemClickListener")]
		protected global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener MOnDrawerItemClickListener {
			get {
				if (mOnDrawerItemClickListener_jfieldId == IntPtr.Zero)
					mOnDrawerItemClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerItemClickListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnDrawerItemClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnDrawerItemClickListener_jfieldId == IntPtr.Zero)
					mOnDrawerItemClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerItemClickListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnDrawerItemClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnDrawerItemLongClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mOnDrawerItemLongClickListener']"
		[Register ("mOnDrawerItemLongClickListener")]
		protected global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener MOnDrawerItemLongClickListener {
			get {
				if (mOnDrawerItemLongClickListener_jfieldId == IntPtr.Zero)
					mOnDrawerItemLongClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerItemLongClickListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnDrawerItemLongClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnDrawerItemLongClickListener_jfieldId == IntPtr.Zero)
					mOnDrawerItemLongClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerItemLongClickListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnDrawerItemLongClickListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnDrawerListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mOnDrawerListener']"
		[Register ("mOnDrawerListener")]
		protected global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener MOnDrawerListener {
			get {
				if (mOnDrawerListener_jfieldId == IntPtr.Zero)
					mOnDrawerListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnDrawerListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnDrawerListener_jfieldId == IntPtr.Zero)
					mOnDrawerListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnDrawerListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOnDrawerNavigationListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mOnDrawerNavigationListener']"
		[Register ("mOnDrawerNavigationListener")]
		protected global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener MOnDrawerNavigationListener {
			get {
				if (mOnDrawerNavigationListener_jfieldId == IntPtr.Zero)
					mOnDrawerNavigationListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerNavigationListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOnDrawerNavigationListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnDrawerNavigationListener_jfieldId == IntPtr.Zero)
					mOnDrawerNavigationListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDrawerNavigationListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOnDrawerNavigationListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPositionBasedStateManagement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mPositionBasedStateManagement']"
		[Register ("mPositionBasedStateManagement")]
		protected bool MPositionBasedStateManagement {
			get {
				if (mPositionBasedStateManagement_jfieldId == IntPtr.Zero)
					mPositionBasedStateManagement_jfieldId = JNIEnv.GetFieldID (class_ref, "mPositionBasedStateManagement", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mPositionBasedStateManagement_jfieldId);
			}
			set {
				if (mPositionBasedStateManagement_jfieldId == IntPtr.Zero)
					mPositionBasedStateManagement_jfieldId = JNIEnv.GetFieldID (class_ref, "mPositionBasedStateManagement", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPositionBasedStateManagement_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mRecyclerView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mRecyclerView']"
		[Register ("mRecyclerView")]
		protected global::Android.Support.V7.Widget.RecyclerView MRecyclerView {
			get {
				if (mRecyclerView_jfieldId == IntPtr.Zero)
					mRecyclerView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecyclerView", "Landroid/support/v7/widget/RecyclerView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRecyclerView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRecyclerView_jfieldId == IntPtr.Zero)
					mRecyclerView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecyclerView", "Landroid/support/v7/widget/RecyclerView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRecyclerView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRootView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mRootView']"
		[Register ("mRootView")]
		protected global::Android.Views.ViewGroup MRootView {
			get {
				if (mRootView_jfieldId == IntPtr.Zero)
					mRootView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRootView", "Landroid/view/ViewGroup;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRootView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRootView_jfieldId == IntPtr.Zero)
					mRootView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRootView", "Landroid/view/ViewGroup;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRootView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSavedInstance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSavedInstance']"
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

		static IntPtr mScrollToTopAfterClick_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mScrollToTopAfterClick']"
		[Register ("mScrollToTopAfterClick")]
		protected bool MScrollToTopAfterClick {
			get {
				if (mScrollToTopAfterClick_jfieldId == IntPtr.Zero)
					mScrollToTopAfterClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollToTopAfterClick", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mScrollToTopAfterClick_jfieldId);
			}
			set {
				if (mScrollToTopAfterClick_jfieldId == IntPtr.Zero)
					mScrollToTopAfterClick_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollToTopAfterClick", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mScrollToTopAfterClick_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectedItemIdentifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSelectedItemIdentifier']"
		[Register ("mSelectedItemIdentifier")]
		protected long MSelectedItemIdentifier {
			get {
				if (mSelectedItemIdentifier_jfieldId == IntPtr.Zero)
					mSelectedItemIdentifier_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectedItemIdentifier", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mSelectedItemIdentifier_jfieldId);
			}
			set {
				if (mSelectedItemIdentifier_jfieldId == IntPtr.Zero)
					mSelectedItemIdentifier_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectedItemIdentifier", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectedItemIdentifier_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectedItemPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSelectedItemPosition']"
		[Register ("mSelectedItemPosition")]
		protected int MSelectedItemPosition {
			get {
				if (mSelectedItemPosition_jfieldId == IntPtr.Zero)
					mSelectedItemPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectedItemPosition", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mSelectedItemPosition_jfieldId);
			}
			set {
				if (mSelectedItemPosition_jfieldId == IntPtr.Zero)
					mSelectedItemPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectedItemPosition", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectedItemPosition_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mShowDrawerOnFirstLaunch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mShowDrawerOnFirstLaunch']"
		[Register ("mShowDrawerOnFirstLaunch")]
		protected bool MShowDrawerOnFirstLaunch {
			get {
				if (mShowDrawerOnFirstLaunch_jfieldId == IntPtr.Zero)
					mShowDrawerOnFirstLaunch_jfieldId = JNIEnv.GetFieldID (class_ref, "mShowDrawerOnFirstLaunch", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mShowDrawerOnFirstLaunch_jfieldId);
			}
			set {
				if (mShowDrawerOnFirstLaunch_jfieldId == IntPtr.Zero)
					mShowDrawerOnFirstLaunch_jfieldId = JNIEnv.GetFieldID (class_ref, "mShowDrawerOnFirstLaunch", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mShowDrawerOnFirstLaunch_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSliderBackgroundColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSliderBackgroundColor']"
		[Register ("mSliderBackgroundColor")]
		protected int MSliderBackgroundColor {
			get {
				if (mSliderBackgroundColor_jfieldId == IntPtr.Zero)
					mSliderBackgroundColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundColor", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundColor_jfieldId);
			}
			set {
				if (mSliderBackgroundColor_jfieldId == IntPtr.Zero)
					mSliderBackgroundColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundColor", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSliderBackgroundColorRes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSliderBackgroundColorRes']"
		[Register ("mSliderBackgroundColorRes")]
		protected int MSliderBackgroundColorRes {
			get {
				if (mSliderBackgroundColorRes_jfieldId == IntPtr.Zero)
					mSliderBackgroundColorRes_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundColorRes", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundColorRes_jfieldId);
			}
			set {
				if (mSliderBackgroundColorRes_jfieldId == IntPtr.Zero)
					mSliderBackgroundColorRes_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundColorRes", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundColorRes_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSliderBackgroundDrawable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSliderBackgroundDrawable']"
		[Register ("mSliderBackgroundDrawable")]
		protected global::Android.Graphics.Drawables.Drawable MSliderBackgroundDrawable {
			get {
				if (mSliderBackgroundDrawable_jfieldId == IntPtr.Zero)
					mSliderBackgroundDrawable_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundDrawable", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundDrawable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSliderBackgroundDrawable_jfieldId == IntPtr.Zero)
					mSliderBackgroundDrawable_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundDrawable", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundDrawable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSliderBackgroundDrawableRes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSliderBackgroundDrawableRes']"
		[Register ("mSliderBackgroundDrawableRes")]
		protected int MSliderBackgroundDrawableRes {
			get {
				if (mSliderBackgroundDrawableRes_jfieldId == IntPtr.Zero)
					mSliderBackgroundDrawableRes_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundDrawableRes", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundDrawableRes_jfieldId);
			}
			set {
				if (mSliderBackgroundDrawableRes_jfieldId == IntPtr.Zero)
					mSliderBackgroundDrawableRes_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderBackgroundDrawableRes", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSliderBackgroundDrawableRes_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSliderLayout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSliderLayout']"
		[Register ("mSliderLayout")]
		protected global::Com.Mikepenz.Materialize.View.ScrimInsetsRelativeLayout MSliderLayout {
			get {
				if (mSliderLayout_jfieldId == IntPtr.Zero)
					mSliderLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderLayout", "Lcom/mikepenz/materialize/view/ScrimInsetsRelativeLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSliderLayout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialize.View.ScrimInsetsRelativeLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSliderLayout_jfieldId == IntPtr.Zero)
					mSliderLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mSliderLayout", "Lcom/mikepenz/materialize/view/ScrimInsetsRelativeLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSliderLayout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStickyDrawerItems_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyDrawerItems']"
		[Register ("mStickyDrawerItems")]
		protected global::System.Collections.IList MStickyDrawerItems {
			get {
				if (mStickyDrawerItems_jfieldId == IntPtr.Zero)
					mStickyDrawerItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyDrawerItems", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStickyDrawerItems_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStickyDrawerItems_jfieldId == IntPtr.Zero)
					mStickyDrawerItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyDrawerItems", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyDrawerItems_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStickyFooterDivider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyFooterDivider']"
		[Register ("mStickyFooterDivider")]
		protected bool MStickyFooterDivider {
			get {
				if (mStickyFooterDivider_jfieldId == IntPtr.Zero)
					mStickyFooterDivider_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterDivider", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mStickyFooterDivider_jfieldId);
			}
			set {
				if (mStickyFooterDivider_jfieldId == IntPtr.Zero)
					mStickyFooterDivider_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterDivider", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyFooterDivider_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mStickyFooterShadow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyFooterShadow']"
		[Register ("mStickyFooterShadow")]
		protected bool MStickyFooterShadow {
			get {
				if (mStickyFooterShadow_jfieldId == IntPtr.Zero)
					mStickyFooterShadow_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterShadow", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mStickyFooterShadow_jfieldId);
			}
			set {
				if (mStickyFooterShadow_jfieldId == IntPtr.Zero)
					mStickyFooterShadow_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterShadow", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyFooterShadow_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mStickyFooterShadowView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyFooterShadowView']"
		[Register ("mStickyFooterShadowView")]
		protected global::Android.Views.View MStickyFooterShadowView {
			get {
				if (mStickyFooterShadowView_jfieldId == IntPtr.Zero)
					mStickyFooterShadowView_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterShadowView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStickyFooterShadowView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStickyFooterShadowView_jfieldId == IntPtr.Zero)
					mStickyFooterShadowView_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterShadowView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyFooterShadowView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStickyFooterView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyFooterView']"
		[Register ("mStickyFooterView")]
		protected global::Android.Views.ViewGroup MStickyFooterView {
			get {
				if (mStickyFooterView_jfieldId == IntPtr.Zero)
					mStickyFooterView_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterView", "Landroid/view/ViewGroup;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStickyFooterView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStickyFooterView_jfieldId == IntPtr.Zero)
					mStickyFooterView_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyFooterView", "Landroid/view/ViewGroup;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyFooterView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStickyHeaderShadow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyHeaderShadow']"
		[Register ("mStickyHeaderShadow")]
		protected bool MStickyHeaderShadow {
			get {
				if (mStickyHeaderShadow_jfieldId == IntPtr.Zero)
					mStickyHeaderShadow_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyHeaderShadow", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mStickyHeaderShadow_jfieldId);
			}
			set {
				if (mStickyHeaderShadow_jfieldId == IntPtr.Zero)
					mStickyHeaderShadow_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyHeaderShadow", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyHeaderShadow_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mStickyHeaderView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mStickyHeaderView']"
		[Register ("mStickyHeaderView")]
		protected global::Android.Views.View MStickyHeaderView {
			get {
				if (mStickyHeaderView_jfieldId == IntPtr.Zero)
					mStickyHeaderView_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyHeaderView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStickyHeaderView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStickyHeaderView_jfieldId == IntPtr.Zero)
					mStickyHeaderView_jfieldId = JNIEnv.GetFieldID (class_ref, "mStickyHeaderView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStickyHeaderView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSystemUIHidden_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mSystemUIHidden']"
		[Register ("mSystemUIHidden")]
		protected bool MSystemUIHidden {
			get {
				if (mSystemUIHidden_jfieldId == IntPtr.Zero)
					mSystemUIHidden_jfieldId = JNIEnv.GetFieldID (class_ref, "mSystemUIHidden", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mSystemUIHidden_jfieldId);
			}
			set {
				if (mSystemUIHidden_jfieldId == IntPtr.Zero)
					mSystemUIHidden_jfieldId = JNIEnv.GetFieldID (class_ref, "mSystemUIHidden", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSystemUIHidden_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mToolbar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mToolbar']"
		[Register ("mToolbar")]
		protected global::Android.Support.V7.Widget.Toolbar MToolbar {
			get {
				if (mToolbar_jfieldId == IntPtr.Zero)
					mToolbar_jfieldId = JNIEnv.GetFieldID (class_ref, "mToolbar", "Landroid/support/v7/widget/Toolbar;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mToolbar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.Toolbar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mToolbar_jfieldId == IntPtr.Zero)
					mToolbar_jfieldId = JNIEnv.GetFieldID (class_ref, "mToolbar", "Landroid/support/v7/widget/Toolbar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mToolbar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTranslucentNavigationBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mTranslucentNavigationBar']"
		[Register ("mTranslucentNavigationBar")]
		protected bool MTranslucentNavigationBar {
			get {
				if (mTranslucentNavigationBar_jfieldId == IntPtr.Zero)
					mTranslucentNavigationBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mTranslucentNavigationBar", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mTranslucentNavigationBar_jfieldId);
			}
			set {
				if (mTranslucentNavigationBar_jfieldId == IntPtr.Zero)
					mTranslucentNavigationBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mTranslucentNavigationBar", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTranslucentNavigationBar_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTranslucentNavigationBarProgrammatically_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mTranslucentNavigationBarProgrammatically']"
		[Register ("mTranslucentNavigationBarProgrammatically")]
		protected bool MTranslucentNavigationBarProgrammatically {
			get {
				if (mTranslucentNavigationBarProgrammatically_jfieldId == IntPtr.Zero)
					mTranslucentNavigationBarProgrammatically_jfieldId = JNIEnv.GetFieldID (class_ref, "mTranslucentNavigationBarProgrammatically", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mTranslucentNavigationBarProgrammatically_jfieldId);
			}
			set {
				if (mTranslucentNavigationBarProgrammatically_jfieldId == IntPtr.Zero)
					mTranslucentNavigationBarProgrammatically_jfieldId = JNIEnv.GetFieldID (class_ref, "mTranslucentNavigationBarProgrammatically", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTranslucentNavigationBarProgrammatically_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTranslucentStatusBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mTranslucentStatusBar']"
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

		static IntPtr mUsed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/field[@name='mUsed']"
		[Register ("mUsed")]
		protected bool MUsed {
			get {
				if (mUsed_jfieldId == IntPtr.Zero)
					mUsed_jfieldId = JNIEnv.GetFieldID (class_ref, "mUsed", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mUsed_jfieldId);
			}
			set {
				if (mUsed_jfieldId == IntPtr.Zero)
					mUsed_jfieldId = JNIEnv.GetFieldID (class_ref, "mUsed", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUsed_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/DrawerBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawerBuilder); }
		}

		protected DrawerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/constructor[@name='DrawerBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawerBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrawerBuilder)) {
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

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/constructor[@name='DrawerBuilder' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe DrawerBuilder (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrawerBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler ()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		protected virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;", "GetGetAdapterHandler")]
			get {
				if (id_getAdapter == IntPtr.Zero)
					id_getAdapter = JNIEnv.GetMethodID (class_ref, "getAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdapter", "()Lcom/mikepenz/fastadapter/FastAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFooterAdapter;
#pragma warning disable 0169
		static Delegate GetGetFooterAdapterHandler ()
		{
			if (cb_getFooterAdapter == null)
				cb_getFooterAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFooterAdapter);
			return cb_getFooterAdapter;
		}

		static IntPtr n_GetFooterAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FooterAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getFooterAdapter;
		protected virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter FooterAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='getFooterAdapter' and count(parameter)=0]"
			[Register ("getFooterAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;", "GetGetFooterAdapterHandler")]
			get {
				if (id_getFooterAdapter == IntPtr.Zero)
					id_getFooterAdapter = JNIEnv.GetMethodID (class_ref, "getFooterAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFooterAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderAdapter;
#pragma warning disable 0169
		static Delegate GetGetHeaderAdapterHandler ()
		{
			if (cb_getHeaderAdapter == null)
				cb_getHeaderAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaderAdapter);
			return cb_getHeaderAdapter;
		}

		static IntPtr n_GetHeaderAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderAdapter;
		protected virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter HeaderAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='getHeaderAdapter' and count(parameter)=0]"
			[Register ("getHeaderAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;", "GetGetHeaderAdapterHandler")]
			get {
				if (id_getHeaderAdapter == IntPtr.Zero)
					id_getHeaderAdapter = JNIEnv.GetMethodID (class_ref, "getHeaderAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItemAdapter;
#pragma warning disable 0169
		static Delegate GetGetItemAdapterHandler ()
		{
			if (cb_getItemAdapter == null)
				cb_getItemAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItemAdapter);
			return cb_getItemAdapter;
		}

		static IntPtr n_GetItemAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getItemAdapter;
		protected virtual unsafe global::Com.Mikepenz.Fastadapter.IItemAdapter ItemAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='getItemAdapter' and count(parameter)=0]"
			[Register ("getItemAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;", "GetGetItemAdapterHandler")]
			get {
				if (id_getItemAdapter == IntPtr.Zero)
					id_getItemAdapter = JNIEnv.GetMethodID (class_ref, "getItemAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.IItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAdapter", "()Lcom/mikepenz/fastadapter/IItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetAddDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static IntPtr n_AddDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDrawerItems (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='addDrawerItems' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem...']]"
		[Register ("addDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetAddDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder AddDrawerItems (params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0)
		{
			if (id_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "addDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetAddStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static IntPtr n_AddStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddStickyDrawerItems (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='addStickyDrawerItems' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem...']]"
		[Register ("addStickyDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetAddStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder AddStickyDrawerItems (params global:: Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0)
		{
			if (id_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "addStickyDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addStickyDrawerItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addStickyDrawerItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_append_Lcom_mikepenz_materialdrawer_Drawer_;
#pragma warning disable 0169
		static Delegate GetAppend_Lcom_mikepenz_materialdrawer_Drawer_Handler ()
		{
			if (cb_append_Lcom_mikepenz_materialdrawer_Drawer_ == null)
				cb_append_Lcom_mikepenz_materialdrawer_Drawer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Append_Lcom_mikepenz_materialdrawer_Drawer_);
			return cb_append_Lcom_mikepenz_materialdrawer_Drawer_;
		}

		static IntPtr n_Append_Lcom_mikepenz_materialdrawer_Drawer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Append (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_append_Lcom_mikepenz_materialdrawer_Drawer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='append' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer']]"
		[Register ("append", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/Drawer;", "GetAppend_Lcom_mikepenz_materialdrawer_Drawer_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer Append (global::Com.Mikepenz.Materialdrawer.Drawer p0)
		{
			if (id_append_Lcom_mikepenz_materialdrawer_Drawer_ == IntPtr.Zero)
				id_append_Lcom_mikepenz_materialdrawer_Drawer_ = JNIEnv.GetMethodID (class_ref, "append", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/Drawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Drawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_append_Lcom_mikepenz_materialdrawer_Drawer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "append", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/Drawer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/mikepenz/materialdrawer/Drawer;", "GetBuildHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mikepenz/materialdrawer/Drawer;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mikepenz/materialdrawer/Drawer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildForFragment;
#pragma warning disable 0169
		static Delegate GetBuildForFragmentHandler ()
		{
			if (cb_buildForFragment == null)
				cb_buildForFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildForFragment);
			return cb_buildForFragment;
		}

		static IntPtr n_BuildForFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildForFragment ());
		}
#pragma warning restore 0169

		static IntPtr id_buildForFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='buildForFragment' and count(parameter)=0]"
		[Register ("buildForFragment", "()Lcom/mikepenz/materialdrawer/Drawer;", "GetBuildForFragmentHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer BuildForFragment ()
		{
			if (id_buildForFragment == IntPtr.Zero)
				id_buildForFragment = JNIEnv.GetMethodID (class_ref, "buildForFragment", "()Lcom/mikepenz/materialdrawer/Drawer;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildForFragment), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildForFragment", "()Lcom/mikepenz/materialdrawer/Drawer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_buildView;
#pragma warning disable 0169
		static Delegate GetBuildViewHandler ()
		{
			if (cb_buildView == null)
				cb_buildView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildView);
			return cb_buildView;
		}

		static IntPtr n_BuildView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BuildView ());
		}
#pragma warning restore 0169

		static IntPtr id_buildView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='buildView' and count(parameter)=0]"
		[Register ("buildView", "()Lcom/mikepenz/materialdrawer/Drawer;", "GetBuildViewHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer BuildView ()
		{
			if (id_buildView == IntPtr.Zero)
				id_buildView = JNIEnv.GetMethodID (class_ref, "buildView", "()Lcom/mikepenz/materialdrawer/Drawer;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildView", "()Lcom/mikepenz/materialdrawer/Drawer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_checkDrawerItem_IZ;
#pragma warning disable 0169
		static Delegate GetCheckDrawerItem_IZHandler ()
		{
			if (cb_checkDrawerItem_IZ == null)
				cb_checkDrawerItem_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool>) n_CheckDrawerItem_IZ);
			return cb_checkDrawerItem_IZ;
		}

		static bool n_CheckDrawerItem_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckDrawerItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_checkDrawerItem_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='checkDrawerItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("checkDrawerItem", "(IZ)Z", "GetCheckDrawerItem_IZHandler")]
		protected virtual unsafe bool CheckDrawerItem (int p0, bool p1)
		{
			if (id_checkDrawerItem_IZ == IntPtr.Zero)
				id_checkDrawerItem_IZ = JNIEnv.GetMethodID (class_ref, "checkDrawerItem", "(IZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkDrawerItem_IZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkDrawerItem", "(IZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_closeDrawerDelayed;
#pragma warning disable 0169
		static Delegate GetCloseDrawerDelayedHandler ()
		{
			if (cb_closeDrawerDelayed == null)
				cb_closeDrawerDelayed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseDrawerDelayed);
			return cb_closeDrawerDelayed;
		}

		static void n_CloseDrawerDelayed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseDrawerDelayed ();
		}
#pragma warning restore 0169

		static IntPtr id_closeDrawerDelayed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='closeDrawerDelayed' and count(parameter)=0]"
		[Register ("closeDrawerDelayed", "()V", "GetCloseDrawerDelayedHandler")]
		protected virtual unsafe void CloseDrawerDelayed ()
		{
			if (id_closeDrawerDelayed == IntPtr.Zero)
				id_closeDrawerDelayed = JNIEnv.GetMethodID (class_ref, "closeDrawerDelayed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeDrawerDelayed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeDrawerDelayed", "()V"));
			} finally {
			}
		}

		static Delegate cb_getDrawerItem_I;
#pragma warning disable 0169
		static Delegate GetGetDrawerItem_IHandler ()
		{
			if (cb_getDrawerItem_I == null)
				cb_getDrawerItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDrawerItem_I);
			return cb_getDrawerItem_I;
		}

		static IntPtr n_GetDrawerItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawerItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDrawerItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='getDrawerItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawerItem", "(I)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;", "GetGetDrawerItem_IHandler")]
		protected virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem GetDrawerItem (int p0)
		{
			if (id_getDrawerItem_I == IntPtr.Zero)
				id_getDrawerItem_I = JNIEnv.GetMethodID (class_ref, "getDrawerItem", "(I)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawerItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawerItem", "(I)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_handleDrawerNavigation_Landroid_app_Activity_Z;
#pragma warning disable 0169
		static Delegate GetHandleDrawerNavigation_Landroid_app_Activity_ZHandler ()
		{
			if (cb_handleDrawerNavigation_Landroid_app_Activity_Z == null)
				cb_handleDrawerNavigation_Landroid_app_Activity_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_HandleDrawerNavigation_Landroid_app_Activity_Z);
			return cb_handleDrawerNavigation_Landroid_app_Activity_Z;
		}

		static void n_HandleDrawerNavigation_Landroid_app_Activity_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleDrawerNavigation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleDrawerNavigation_Landroid_app_Activity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='handleDrawerNavigation' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("handleDrawerNavigation", "(Landroid/app/Activity;Z)V", "GetHandleDrawerNavigation_Landroid_app_Activity_ZHandler")]
		protected virtual unsafe void HandleDrawerNavigation (global::Android.App.Activity p0, bool p1)
		{
			if (id_handleDrawerNavigation_Landroid_app_Activity_Z == IntPtr.Zero)
				id_handleDrawerNavigation_Landroid_app_Activity_Z = JNIEnv.GetMethodID (class_ref, "handleDrawerNavigation", "(Landroid/app/Activity;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleDrawerNavigation_Landroid_app_Activity_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDrawerNavigation", "(Landroid/app/Activity;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_inflateMenu_I;
#pragma warning disable 0169
		static Delegate GetInflateMenu_IHandler ()
		{
			if (cb_inflateMenu_I == null)
				cb_inflateMenu_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InflateMenu_I);
			return cb_inflateMenu_I;
		}

		static IntPtr n_InflateMenu_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InflateMenu (p0));
		}
#pragma warning restore 0169

		static IntPtr id_inflateMenu_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='inflateMenu' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("inflateMenu", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetInflateMenu_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder InflateMenu (int p0)
		{
			if (id_inflateMenu_I == IntPtr.Zero)
				id_inflateMenu_I = JNIEnv.GetMethodID (class_ref, "inflateMenu", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inflateMenu_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inflateMenu", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_resetStickyFooterSelection;
#pragma warning disable 0169
		static Delegate GetResetStickyFooterSelectionHandler ()
		{
			if (cb_resetStickyFooterSelection == null)
				cb_resetStickyFooterSelection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetStickyFooterSelection);
			return cb_resetStickyFooterSelection;
		}

		static void n_ResetStickyFooterSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetStickyFooterSelection ();
		}
#pragma warning restore 0169

		static IntPtr id_resetStickyFooterSelection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='resetStickyFooterSelection' and count(parameter)=0]"
		[Register ("resetStickyFooterSelection", "()V", "GetResetStickyFooterSelectionHandler")]
		protected virtual unsafe void ResetStickyFooterSelection ()
		{
			if (id_resetStickyFooterSelection == IntPtr.Zero)
				id_resetStickyFooterSelection = JNIEnv.GetMethodID (class_ref, "resetStickyFooterSelection", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetStickyFooterSelection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetStickyFooterSelection", "()V"));
			} finally {
			}
		}

		static Delegate cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_;
#pragma warning disable 0169
		static Delegate GetWithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Handler ()
		{
			if (cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ == null)
				cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_);
			return cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_;
		}

		static IntPtr n_WithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAccountHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withAccountHeader' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader']]"
		[Register ("withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithAccountHeader (global::Com.Mikepenz.Materialdrawer.AccountHeader p0)
		{
			if (id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ == IntPtr.Zero)
				id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ = JNIEnv.GetMethodID (class_ref, "withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z;
#pragma warning disable 0169
		static Delegate GetWithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ZHandler ()
		{
			if (cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z == null)
				cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_WithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z);
			return cb_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z;
		}

		static IntPtr n_WithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAccountHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withAccountHeader' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader'] and parameter[2][@type='boolean']]"
		[Register ("withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithAccountHeader (global::Com.Mikepenz.Materialdrawer.AccountHeader p0, bool p1)
		{
			if (id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z == IntPtr.Zero)
				id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z = JNIEnv.GetMethodID (class_ref, "withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_;
#pragma warning disable 0169
		static Delegate GetWithActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_Handler ()
		{
			if (cb_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ == null)
				cb_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_);
			return cb_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_;
		}

		static IntPtr n_WithActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBarDrawerToggle p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBarDrawerToggle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithActionBarDrawerToggle (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withActionBarDrawerToggle' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBarDrawerToggle']]"
		[Register ("withActionBarDrawerToggle", "(Landroid/support/v7/app/ActionBarDrawerToggle;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithActionBarDrawerToggle (global::Android.Support.V7.App.ActionBarDrawerToggle p0)
		{
			if (id_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ == IntPtr.Zero)
				id_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_ = JNIEnv.GetMethodID (class_ref, "withActionBarDrawerToggle", "(Landroid/support/v7/app/ActionBarDrawerToggle;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withActionBarDrawerToggle_Landroid_support_v7_app_ActionBarDrawerToggle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withActionBarDrawerToggle", "(Landroid/support/v7/app/ActionBarDrawerToggle;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withActionBarDrawerToggle_Z;
#pragma warning disable 0169
		static Delegate GetWithActionBarDrawerToggle_ZHandler ()
		{
			if (cb_withActionBarDrawerToggle_Z == null)
				cb_withActionBarDrawerToggle_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithActionBarDrawerToggle_Z);
			return cb_withActionBarDrawerToggle_Z;
		}

		static IntPtr n_WithActionBarDrawerToggle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithActionBarDrawerToggle (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withActionBarDrawerToggle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withActionBarDrawerToggle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withActionBarDrawerToggle", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithActionBarDrawerToggle_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithActionBarDrawerToggle (bool p0)
		{
			if (id_withActionBarDrawerToggle_Z == IntPtr.Zero)
				id_withActionBarDrawerToggle_Z = JNIEnv.GetMethodID (class_ref, "withActionBarDrawerToggle", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withActionBarDrawerToggle_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withActionBarDrawerToggle", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withActionBarDrawerToggleAnimated_Z;
#pragma warning disable 0169
		static Delegate GetWithActionBarDrawerToggleAnimated_ZHandler ()
		{
			if (cb_withActionBarDrawerToggleAnimated_Z == null)
				cb_withActionBarDrawerToggleAnimated_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithActionBarDrawerToggleAnimated_Z);
			return cb_withActionBarDrawerToggleAnimated_Z;
		}

		static IntPtr n_WithActionBarDrawerToggleAnimated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithActionBarDrawerToggleAnimated (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withActionBarDrawerToggleAnimated_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withActionBarDrawerToggleAnimated' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withActionBarDrawerToggleAnimated", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithActionBarDrawerToggleAnimated_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithActionBarDrawerToggleAnimated (bool p0)
		{
			if (id_withActionBarDrawerToggleAnimated_Z == IntPtr.Zero)
				id_withActionBarDrawerToggleAnimated_Z = JNIEnv.GetMethodID (class_ref, "withActionBarDrawerToggleAnimated", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withActionBarDrawerToggleAnimated_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withActionBarDrawerToggleAnimated", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithActivity (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("withActivity", "(Landroid/app/Activity;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithActivity (global::Android.App.Activity p0)
		{
			if (id_withActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_withActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "withActivity", "(Landroid/app/Activity;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withActivity_Landroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withActivity", "(Landroid/app/Activity;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_;
#pragma warning disable 0169
		static Delegate GetWithAdapter_Lcom_mikepenz_fastadapter_FastAdapter_Handler ()
		{
			if (cb_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_ == null)
				cb_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdapter_Lcom_mikepenz_fastadapter_FastAdapter_);
			return cb_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_;
		}

		static IntPtr n_WithAdapter_Lcom_mikepenz_fastadapter_FastAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdapter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withAdapter' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("withAdapter", "(Lcom/mikepenz/fastadapter/FastAdapter;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithAdapter_Lcom_mikepenz_fastadapter_FastAdapter_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithAdapter (global::Com.Mikepenz.Fastadapter.FastAdapter p0)
		{
			if (id_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_ == IntPtr.Zero)
				id_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_ = JNIEnv.GetMethodID (class_ref, "withAdapter", "(Lcom/mikepenz/fastadapter/FastAdapter;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAdapter_Lcom_mikepenz_fastadapter_FastAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdapter", "(Lcom/mikepenz/fastadapter/FastAdapter;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_;
#pragma warning disable 0169
		static Delegate GetWithAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_Handler ()
		{
			if (cb_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_ == null)
				cb_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_);
			return cb_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_;
		}

		static IntPtr n_WithAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.Adapter p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.Adapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAdapterWrapper (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withAdapterWrapper' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.Adapter']]"
		[Register ("withAdapterWrapper", "(Landroid/support/v7/widget/RecyclerView$Adapter;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithAdapterWrapper (global::Android.Support.V7.Widget.RecyclerView.Adapter p0)
		{
			if (id_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_ == IntPtr.Zero)
				id_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_ = JNIEnv.GetMethodID (class_ref, "withAdapterWrapper", "(Landroid/support/v7/widget/RecyclerView$Adapter;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAdapterWrapper_Landroid_support_v7_widget_RecyclerView_Adapter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAdapterWrapper", "(Landroid/support/v7/widget/RecyclerView$Adapter;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withCloseOnClick_Z;
#pragma warning disable 0169
		static Delegate GetWithCloseOnClick_ZHandler ()
		{
			if (cb_withCloseOnClick_Z == null)
				cb_withCloseOnClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithCloseOnClick_Z);
			return cb_withCloseOnClick_Z;
		}

		static IntPtr n_WithCloseOnClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithCloseOnClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withCloseOnClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withCloseOnClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withCloseOnClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithCloseOnClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithCloseOnClick (bool p0)
		{
			if (id_withCloseOnClick_Z == IntPtr.Zero)
				id_withCloseOnClick_Z = JNIEnv.GetMethodID (class_ref, "withCloseOnClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCloseOnClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCloseOnClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withCustomView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWithCustomView_Landroid_view_View_Handler ()
		{
			if (cb_withCustomView_Landroid_view_View_ == null)
				cb_withCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithCustomView_Landroid_view_View_);
			return cb_withCustomView_Landroid_view_View_;
		}

		static IntPtr n_WithCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCustomView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withCustomView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("withCustomView", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithCustomView_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithCustomView (global::Android.Views.View p0)
		{
			if (id_withCustomView_Landroid_view_View_ == IntPtr.Zero)
				id_withCustomView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "withCustomView", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCustomView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCustomView", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withDelayDrawerClickEvent_I;
#pragma warning disable 0169
		static Delegate GetWithDelayDrawerClickEvent_IHandler ()
		{
			if (cb_withDelayDrawerClickEvent_I == null)
				cb_withDelayDrawerClickEvent_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDelayDrawerClickEvent_I);
			return cb_withDelayDrawerClickEvent_I;
		}

		static IntPtr n_WithDelayDrawerClickEvent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDelayDrawerClickEvent (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDelayDrawerClickEvent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDelayDrawerClickEvent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDelayDrawerClickEvent", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDelayDrawerClickEvent_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDelayDrawerClickEvent (int p0)
		{
			if (id_withDelayDrawerClickEvent_I == IntPtr.Zero)
				id_withDelayDrawerClickEvent_I = JNIEnv.GetMethodID (class_ref, "withDelayDrawerClickEvent", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDelayDrawerClickEvent_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDelayDrawerClickEvent", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDelayOnDrawerClose_I;
#pragma warning disable 0169
		static Delegate GetWithDelayOnDrawerClose_IHandler ()
		{
			if (cb_withDelayOnDrawerClose_I == null)
				cb_withDelayOnDrawerClose_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDelayOnDrawerClose_I);
			return cb_withDelayOnDrawerClose_I;
		}

		static IntPtr n_WithDelayOnDrawerClose_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDelayOnDrawerClose (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDelayOnDrawerClose_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDelayOnDrawerClose' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDelayOnDrawerClose", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDelayOnDrawerClose_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDelayOnDrawerClose (int p0)
		{
			if (id_withDelayOnDrawerClose_I == IntPtr.Zero)
				id_withDelayOnDrawerClose_I = JNIEnv.GetMethodID (class_ref, "withDelayOnDrawerClose", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDelayOnDrawerClose_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDelayOnDrawerClose", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDisplayBelowStatusBar_Z;
#pragma warning disable 0169
		static Delegate GetWithDisplayBelowStatusBar_ZHandler ()
		{
			if (cb_withDisplayBelowStatusBar_Z == null)
				cb_withDisplayBelowStatusBar_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithDisplayBelowStatusBar_Z);
			return cb_withDisplayBelowStatusBar_Z;
		}

		static IntPtr n_WithDisplayBelowStatusBar_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDisplayBelowStatusBar (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDisplayBelowStatusBar_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDisplayBelowStatusBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withDisplayBelowStatusBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDisplayBelowStatusBar_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDisplayBelowStatusBar (bool p0)
		{
			if (id_withDisplayBelowStatusBar_Z == IntPtr.Zero)
				id_withDisplayBelowStatusBar_Z = JNIEnv.GetMethodID (class_ref, "withDisplayBelowStatusBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDisplayBelowStatusBar_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDisplayBelowStatusBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawerGravity_I;
#pragma warning disable 0169
		static Delegate GetWithDrawerGravity_IHandler ()
		{
			if (cb_withDrawerGravity_I == null)
				cb_withDrawerGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDrawerGravity_I);
			return cb_withDrawerGravity_I;
		}

		static IntPtr n_WithDrawerGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDrawerGravity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDrawerGravity", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerGravity_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerGravity (int p0)
		{
			if (id_withDrawerGravity_I == IntPtr.Zero)
				id_withDrawerGravity_I = JNIEnv.GetMethodID (class_ref, "withDrawerGravity", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerGravity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerGravity", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawerItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithDrawerItems_Ljava_util_List_Handler ()
		{
			if (cb_withDrawerItems_Ljava_util_List_ == null)
				cb_withDrawerItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDrawerItems_Ljava_util_List_);
			return cb_withDrawerItems_Ljava_util_List_;
		}

		static IntPtr n_WithDrawerItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawerItems (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerItems_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerItems' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("withDrawerItems", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerItems_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerItems (global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> p0)
		{
			if (id_withDrawerItems_Ljava_util_List_ == IntPtr.Zero)
				id_withDrawerItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withDrawerItems", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerItems_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerItems", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_;
#pragma warning disable 0169
		static Delegate GetWithDrawerLayout_Landroid_support_v4_widget_DrawerLayout_Handler ()
		{
			if (cb_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_ == null)
				cb_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDrawerLayout_Landroid_support_v4_widget_DrawerLayout_);
			return cb_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_;
		}

		static IntPtr n_WithDrawerLayout_Landroid_support_v4_widget_DrawerLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.Widget.DrawerLayout p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Widget.DrawerLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawerLayout (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerLayout' and count(parameter)=1 and parameter[1][@type='android.support.v4.widget.DrawerLayout']]"
		[Register ("withDrawerLayout", "(Landroid/support/v4/widget/DrawerLayout;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerLayout_Landroid_support_v4_widget_DrawerLayout_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerLayout (global::Android.Support.V4.Widget.DrawerLayout p0)
		{
			if (id_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_ == IntPtr.Zero)
				id_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_ = JNIEnv.GetMethodID (class_ref, "withDrawerLayout", "(Landroid/support/v4/widget/DrawerLayout;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerLayout_Landroid_support_v4_widget_DrawerLayout_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerLayout", "(Landroid/support/v4/widget/DrawerLayout;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withDrawerLayout_I;
#pragma warning disable 0169
		static Delegate GetWithDrawerLayout_IHandler ()
		{
			if (cb_withDrawerLayout_I == null)
				cb_withDrawerLayout_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDrawerLayout_I);
			return cb_withDrawerLayout_I;
		}

		static IntPtr n_WithDrawerLayout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDrawerLayout (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerLayout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerLayout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDrawerLayout", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerLayout_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerLayout (int p0)
		{
			if (id_withDrawerLayout_I == IntPtr.Zero)
				id_withDrawerLayout_I = JNIEnv.GetMethodID (class_ref, "withDrawerLayout", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerLayout_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerLayout", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawerWidthDp_I;
#pragma warning disable 0169
		static Delegate GetWithDrawerWidthDp_IHandler ()
		{
			if (cb_withDrawerWidthDp_I == null)
				cb_withDrawerWidthDp_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDrawerWidthDp_I);
			return cb_withDrawerWidthDp_I;
		}

		static IntPtr n_WithDrawerWidthDp_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDrawerWidthDp (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerWidthDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerWidthDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDrawerWidthDp", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerWidthDp_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerWidthDp (int p0)
		{
			if (id_withDrawerWidthDp_I == IntPtr.Zero)
				id_withDrawerWidthDp_I = JNIEnv.GetMethodID (class_ref, "withDrawerWidthDp", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerWidthDp_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerWidthDp", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawerWidthPx_I;
#pragma warning disable 0169
		static Delegate GetWithDrawerWidthPx_IHandler ()
		{
			if (cb_withDrawerWidthPx_I == null)
				cb_withDrawerWidthPx_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDrawerWidthPx_I);
			return cb_withDrawerWidthPx_I;
		}

		static IntPtr n_WithDrawerWidthPx_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDrawerWidthPx (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerWidthPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerWidthPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDrawerWidthPx", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerWidthPx_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerWidthPx (int p0)
		{
			if (id_withDrawerWidthPx_I == IntPtr.Zero)
				id_withDrawerWidthPx_I = JNIEnv.GetMethodID (class_ref, "withDrawerWidthPx", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerWidthPx_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerWidthPx", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withDrawerWidthRes_I;
#pragma warning disable 0169
		static Delegate GetWithDrawerWidthRes_IHandler ()
		{
			if (cb_withDrawerWidthRes_I == null)
				cb_withDrawerWidthRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDrawerWidthRes_I);
			return cb_withDrawerWidthRes_I;
		}

		static IntPtr n_WithDrawerWidthRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithDrawerWidthRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDrawerWidthRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withDrawerWidthRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withDrawerWidthRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithDrawerWidthRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithDrawerWidthRes (int p0)
		{
			if (id_withDrawerWidthRes_I == IntPtr.Zero)
				id_withDrawerWidthRes_I = JNIEnv.GetMethodID (class_ref, "withDrawerWidthRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawerWidthRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawerWidthRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFireOnInitialOnClick_Z;
#pragma warning disable 0169
		static Delegate GetWithFireOnInitialOnClick_ZHandler ()
		{
			if (cb_withFireOnInitialOnClick_Z == null)
				cb_withFireOnInitialOnClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithFireOnInitialOnClick_Z);
			return cb_withFireOnInitialOnClick_Z;
		}

		static IntPtr n_WithFireOnInitialOnClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithFireOnInitialOnClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withFireOnInitialOnClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withFireOnInitialOnClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withFireOnInitialOnClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithFireOnInitialOnClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithFireOnInitialOnClick (bool p0)
		{
			if (id_withFireOnInitialOnClick_Z == IntPtr.Zero)
				id_withFireOnInitialOnClick_Z = JNIEnv.GetMethodID (class_ref, "withFireOnInitialOnClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFireOnInitialOnClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFireOnInitialOnClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFooter_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWithFooter_Landroid_view_View_Handler ()
		{
			if (cb_withFooter_Landroid_view_View_ == null)
				cb_withFooter_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFooter_Landroid_view_View_);
			return cb_withFooter_Landroid_view_View_;
		}

		static IntPtr n_WithFooter_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFooter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFooter_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withFooter' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("withFooter", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithFooter_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithFooter (global::Android.Views.View p0)
		{
			if (id_withFooter_Landroid_view_View_ == IntPtr.Zero)
				id_withFooter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "withFooter", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFooter_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFooter", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withFooter_I;
#pragma warning disable 0169
		static Delegate GetWithFooter_IHandler ()
		{
			if (cb_withFooter_I == null)
				cb_withFooter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithFooter_I);
			return cb_withFooter_I;
		}

		static IntPtr n_WithFooter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithFooter (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withFooter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withFooter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withFooter", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithFooter_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithFooter (int p0)
		{
			if (id_withFooter_I == IntPtr.Zero)
				id_withFooter_I = JNIEnv.GetMethodID (class_ref, "withFooter", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFooter_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFooter", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFooterClickable_Z;
#pragma warning disable 0169
		static Delegate GetWithFooterClickable_ZHandler ()
		{
			if (cb_withFooterClickable_Z == null)
				cb_withFooterClickable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithFooterClickable_Z);
			return cb_withFooterClickable_Z;
		}

		static IntPtr n_WithFooterClickable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithFooterClickable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withFooterClickable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withFooterClickable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withFooterClickable", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithFooterClickable_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithFooterClickable (bool p0)
		{
			if (id_withFooterClickable_Z == IntPtr.Zero)
				id_withFooterClickable_Z = JNIEnv.GetMethodID (class_ref, "withFooterClickable", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFooterClickable_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFooterClickable", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFooterDivider_Z;
#pragma warning disable 0169
		static Delegate GetWithFooterDivider_ZHandler ()
		{
			if (cb_withFooterDivider_Z == null)
				cb_withFooterDivider_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithFooterDivider_Z);
			return cb_withFooterDivider_Z;
		}

		static IntPtr n_WithFooterDivider_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithFooterDivider (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withFooterDivider_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withFooterDivider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withFooterDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithFooterDivider_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithFooterDivider (bool p0)
		{
			if (id_withFooterDivider_Z == IntPtr.Zero)
				id_withFooterDivider_Z = JNIEnv.GetMethodID (class_ref, "withFooterDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFooterDivider_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFooterDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withFullscreen_Z;
#pragma warning disable 0169
		static Delegate GetWithFullscreen_ZHandler ()
		{
			if (cb_withFullscreen_Z == null)
				cb_withFullscreen_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithFullscreen_Z);
			return cb_withFullscreen_Z;
		}

		static IntPtr n_WithFullscreen_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithFullscreen (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withFullscreen_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withFullscreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withFullscreen", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithFullscreen_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithFullscreen (bool p0)
		{
			if (id_withFullscreen_Z == IntPtr.Zero)
				id_withFullscreen_Z = JNIEnv.GetMethodID (class_ref, "withFullscreen", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFullscreen_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFullscreen", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withGenerateMiniDrawer_Z;
#pragma warning disable 0169
		static Delegate GetWithGenerateMiniDrawer_ZHandler ()
		{
			if (cb_withGenerateMiniDrawer_Z == null)
				cb_withGenerateMiniDrawer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithGenerateMiniDrawer_Z);
			return cb_withGenerateMiniDrawer_Z;
		}

		static IntPtr n_WithGenerateMiniDrawer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithGenerateMiniDrawer (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withGenerateMiniDrawer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withGenerateMiniDrawer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withGenerateMiniDrawer", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithGenerateMiniDrawer_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithGenerateMiniDrawer (bool p0)
		{
			if (id_withGenerateMiniDrawer_Z == IntPtr.Zero)
				id_withGenerateMiniDrawer_Z = JNIEnv.GetMethodID (class_ref, "withGenerateMiniDrawer", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withGenerateMiniDrawer_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withGenerateMiniDrawer", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHasStableIds_Z;
#pragma warning disable 0169
		static Delegate GetWithHasStableIds_ZHandler ()
		{
			if (cb_withHasStableIds_Z == null)
				cb_withHasStableIds_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithHasStableIds_Z);
			return cb_withHasStableIds_Z;
		}

		static IntPtr n_WithHasStableIds_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHasStableIds (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHasStableIds_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withHasStableIds' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withHasStableIds", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithHasStableIds_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithHasStableIds (bool p0)
		{
			if (id_withHasStableIds_Z == IntPtr.Zero)
				id_withHasStableIds_Z = JNIEnv.GetMethodID (class_ref, "withHasStableIds", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHasStableIds_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHasStableIds", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHeader_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWithHeader_Landroid_view_View_Handler ()
		{
			if (cb_withHeader_Landroid_view_View_ == null)
				cb_withHeader_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithHeader_Landroid_view_View_);
			return cb_withHeader_Landroid_view_View_;
		}

		static IntPtr n_WithHeader_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withHeader_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withHeader' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("withHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithHeader_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithHeader (global::Android.Views.View p0)
		{
			if (id_withHeader_Landroid_view_View_ == IntPtr.Zero)
				id_withHeader_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "withHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeader_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withHeader_I;
#pragma warning disable 0169
		static Delegate GetWithHeader_IHandler ()
		{
			if (cb_withHeader_I == null)
				cb_withHeader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithHeader_I);
			return cb_withHeader_I;
		}

		static IntPtr n_WithHeader_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeader (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withHeader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withHeader", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithHeader_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithHeader (int p0)
		{
			if (id_withHeader_I == IntPtr.Zero)
				id_withHeader_I = JNIEnv.GetMethodID (class_ref, "withHeader", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeader_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeader", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHeaderDivider_Z;
#pragma warning disable 0169
		static Delegate GetWithHeaderDivider_ZHandler ()
		{
			if (cb_withHeaderDivider_Z == null)
				cb_withHeaderDivider_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithHeaderDivider_Z);
			return cb_withHeaderDivider_Z;
		}

		static IntPtr n_WithHeaderDivider_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeaderDivider (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderDivider_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withHeaderDivider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withHeaderDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithHeaderDivider_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithHeaderDivider (bool p0)
		{
			if (id_withHeaderDivider_Z == IntPtr.Zero)
				id_withHeaderDivider_Z = JNIEnv.GetMethodID (class_ref, "withHeaderDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderDivider_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
#pragma warning disable 0169
		static Delegate GetWithHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler ()
		{
			if (cb_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == null)
				cb_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_);
			return cb_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		}

		static IntPtr n_WithHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithHeaderHeight (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withHeaderHeight' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.DimenHolder']]"
		[Register ("withHeaderHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithHeaderHeight (global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0)
		{
			if (id_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == IntPtr.Zero)
				id_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNIEnv.GetMethodID (class_ref, "withHeaderHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withHeaderPadding_Z;
#pragma warning disable 0169
		static Delegate GetWithHeaderPadding_ZHandler ()
		{
			if (cb_withHeaderPadding_Z == null)
				cb_withHeaderPadding_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithHeaderPadding_Z);
			return cb_withHeaderPadding_Z;
		}

		static IntPtr n_WithHeaderPadding_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithHeaderPadding (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withHeaderPadding_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withHeaderPadding' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withHeaderPadding", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithHeaderPadding_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithHeaderPadding (bool p0)
		{
			if (id_withHeaderPadding_Z == IntPtr.Zero)
				id_withHeaderPadding_Z = JNIEnv.GetMethodID (class_ref, "withHeaderPadding", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withHeaderPadding_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withHeaderPadding", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withInnerShadow_Z;
#pragma warning disable 0169
		static Delegate GetWithInnerShadow_ZHandler ()
		{
			if (cb_withInnerShadow_Z == null)
				cb_withInnerShadow_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithInnerShadow_Z);
			return cb_withInnerShadow_Z;
		}

		static IntPtr n_WithInnerShadow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithInnerShadow (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withInnerShadow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withInnerShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withInnerShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithInnerShadow_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithInnerShadow (bool p0)
		{
			if (id_withInnerShadow_Z == IntPtr.Zero)
				id_withInnerShadow_Z = JNIEnv.GetMethodID (class_ref, "withInnerShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withInnerShadow_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withInnerShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_;
#pragma warning disable 0169
		static Delegate GetWithItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_Handler ()
		{
			if (cb_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_ == null)
				cb_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_);
			return cb_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_;
		}

		static IntPtr n_WithItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ItemAnimator p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ItemAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithItemAnimator (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withItemAnimator' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ItemAnimator']]"
		[Register ("withItemAnimator", "(Landroid/support/v7/widget/RecyclerView$ItemAnimator;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithItemAnimator (global::Android.Support.V7.Widget.RecyclerView.ItemAnimator p0)
		{
			if (id_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_ == IntPtr.Zero)
				id_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_ = JNIEnv.GetMethodID (class_ref, "withItemAnimator", "(Landroid/support/v7/widget/RecyclerView$ItemAnimator;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withItemAnimator_Landroid_support_v7_widget_RecyclerView_ItemAnimator_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withItemAnimator", "(Landroid/support/v7/widget/RecyclerView$ItemAnimator;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMultiSelect_Z;
#pragma warning disable 0169
		static Delegate GetWithMultiSelect_ZHandler ()
		{
			if (cb_withMultiSelect_Z == null)
				cb_withMultiSelect_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithMultiSelect_Z);
			return cb_withMultiSelect_Z;
		}

		static IntPtr n_WithMultiSelect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithMultiSelect (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withMultiSelect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withMultiSelect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withMultiSelect", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithMultiSelect_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithMultiSelect (bool p0)
		{
			if (id_withMultiSelect_Z == IntPtr.Zero)
				id_withMultiSelect_Z = JNIEnv.GetMethodID (class_ref, "withMultiSelect", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMultiSelect_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMultiSelect", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Handler ()
		{
			if (cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ == null)
				cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_);
			return cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
		}

		static IntPtr n_WithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnDrawerItemClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withOnDrawerItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemClickListener']]"
		[Register ("withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithOnDrawerItemClickListener (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0)
		{
			if (id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ == IntPtr.Zero)
				id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Handler ()
		{
			if (cb_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ == null)
				cb_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_);
			return cb_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_;
		}

		static IntPtr n_WithOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnDrawerItemLongClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withOnDrawerItemLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemLongClickListener']]"
		[Register ("withOnDrawerItemLongClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithOnDrawerItemLongClickListener (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemLongClickListener p0)
		{
			if (id_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ == IntPtr.Zero)
				id_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnDrawerItemLongClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnDrawerItemLongClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemLongClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnDrawerItemLongClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemLongClickListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_;
#pragma warning disable 0169
		static Delegate GetWithOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_Handler ()
		{
			if (cb_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_ == null)
				cb_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_);
			return cb_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_;
		}

		static IntPtr n_WithOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnDrawerListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withOnDrawerListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerListener']]"
		[Register ("withOnDrawerListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithOnDrawerListener (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerListener p0)
		{
			if (id_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_ == IntPtr.Zero)
				id_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_ = JNIEnv.GetMethodID (class_ref, "withOnDrawerListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnDrawerListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnDrawerListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_;
#pragma warning disable 0169
		static Delegate GetWithOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_Handler ()
		{
			if (cb_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ == null)
				cb_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_);
			return cb_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_;
		}

		static IntPtr n_WithOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnDrawerNavigationListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withOnDrawerNavigationListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerNavigationListener']]"
		[Register ("withOnDrawerNavigationListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithOnDrawerNavigationListener (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerNavigationListener p0)
		{
			if (id_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ == IntPtr.Zero)
				id_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_ = JNIEnv.GetMethodID (class_ref, "withOnDrawerNavigationListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnDrawerNavigationListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerNavigationListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnDrawerNavigationListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerNavigationListener;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withPositionBasedStateManagement_Z;
#pragma warning disable 0169
		static Delegate GetWithPositionBasedStateManagement_ZHandler ()
		{
			if (cb_withPositionBasedStateManagement_Z == null)
				cb_withPositionBasedStateManagement_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithPositionBasedStateManagement_Z);
			return cb_withPositionBasedStateManagement_Z;
		}

		static IntPtr n_WithPositionBasedStateManagement_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPositionBasedStateManagement (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPositionBasedStateManagement_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withPositionBasedStateManagement' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withPositionBasedStateManagement", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithPositionBasedStateManagement_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithPositionBasedStateManagement (bool p0)
		{
			if (id_withPositionBasedStateManagement_Z == IntPtr.Zero)
				id_withPositionBasedStateManagement_Z = JNIEnv.GetMethodID (class_ref, "withPositionBasedStateManagement", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPositionBasedStateManagement_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPositionBasedStateManagement", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withRecyclerView_Landroid_support_v7_widget_RecyclerView_;
#pragma warning disable 0169
		static Delegate GetWithRecyclerView_Landroid_support_v7_widget_RecyclerView_Handler ()
		{
			if (cb_withRecyclerView_Landroid_support_v7_widget_RecyclerView_ == null)
				cb_withRecyclerView_Landroid_support_v7_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRecyclerView_Landroid_support_v7_widget_RecyclerView_);
			return cb_withRecyclerView_Landroid_support_v7_widget_RecyclerView_;
		}

		static IntPtr n_WithRecyclerView_Landroid_support_v7_widget_RecyclerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRecyclerView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withRecyclerView_Landroid_support_v7_widget_RecyclerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withRecyclerView' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register ("withRecyclerView", "(Landroid/support/v7/widget/RecyclerView;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithRecyclerView_Landroid_support_v7_widget_RecyclerView_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithRecyclerView (global::Android.Support.V7.Widget.RecyclerView p0)
		{
			if (id_withRecyclerView_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
				id_withRecyclerView_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetMethodID (class_ref, "withRecyclerView", "(Landroid/support/v7/widget/RecyclerView;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withRecyclerView_Landroid_support_v7_widget_RecyclerView_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRecyclerView", "(Landroid/support/v7/widget/RecyclerView;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withRootView_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetWithRootView_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_withRootView_Landroid_view_ViewGroup_ == null)
				cb_withRootView_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithRootView_Landroid_view_ViewGroup_);
			return cb_withRootView_Landroid_view_ViewGroup_;
		}

		static IntPtr n_WithRootView_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRootView (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withRootView_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withRootView' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("withRootView", "(Landroid/view/ViewGroup;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithRootView_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithRootView (global::Android.Views.ViewGroup p0)
		{
			if (id_withRootView_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_withRootView_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "withRootView", "(Landroid/view/ViewGroup;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withRootView_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRootView", "(Landroid/view/ViewGroup;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withRootView_I;
#pragma warning disable 0169
		static Delegate GetWithRootView_IHandler ()
		{
			if (cb_withRootView_I == null)
				cb_withRootView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithRootView_I);
			return cb_withRootView_I;
		}

		static IntPtr n_WithRootView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithRootView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withRootView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withRootView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withRootView", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithRootView_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithRootView (int p0)
		{
			if (id_withRootView_I == IntPtr.Zero)
				id_withRootView_I = JNIEnv.GetMethodID (class_ref, "withRootView", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withRootView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withRootView", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSavedInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSavedInstance_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSavedInstance' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("withSavedInstance", "(Landroid/os/Bundle;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSavedInstance_Landroid_os_Bundle_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSavedInstance (global::Android.OS.Bundle p0)
		{
			if (id_withSavedInstance_Landroid_os_Bundle_ == IntPtr.Zero)
				id_withSavedInstance_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "withSavedInstance", "(Landroid/os/Bundle;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSavedInstance_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSavedInstance", "(Landroid/os/Bundle;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withScrollToTopAfterClick_Z;
#pragma warning disable 0169
		static Delegate GetWithScrollToTopAfterClick_ZHandler ()
		{
			if (cb_withScrollToTopAfterClick_Z == null)
				cb_withScrollToTopAfterClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithScrollToTopAfterClick_Z);
			return cb_withScrollToTopAfterClick_Z;
		}

		static IntPtr n_WithScrollToTopAfterClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithScrollToTopAfterClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withScrollToTopAfterClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withScrollToTopAfterClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withScrollToTopAfterClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithScrollToTopAfterClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithScrollToTopAfterClick (bool p0)
		{
			if (id_withScrollToTopAfterClick_Z == IntPtr.Zero)
				id_withScrollToTopAfterClick_Z = JNIEnv.GetMethodID (class_ref, "withScrollToTopAfterClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withScrollToTopAfterClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withScrollToTopAfterClick", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectedItem_J;
#pragma warning disable 0169
		static Delegate GetWithSelectedItem_JHandler ()
		{
			if (cb_withSelectedItem_J == null)
				cb_withSelectedItem_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WithSelectedItem_J);
			return cb_withSelectedItem_J;
		}

		static IntPtr n_WithSelectedItem_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectedItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedItem_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSelectedItem' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("withSelectedItem", "(J)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSelectedItem_JHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSelectedItem (long p0)
		{
			if (id_withSelectedItem_J == IntPtr.Zero)
				id_withSelectedItem_J = JNIEnv.GetMethodID (class_ref, "withSelectedItem", "(J)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectedItem_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectedItem", "(J)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSelectedItemByPosition_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedItemByPosition_IHandler ()
		{
			if (cb_withSelectedItemByPosition_I == null)
				cb_withSelectedItemByPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedItemByPosition_I);
			return cb_withSelectedItemByPosition_I;
		}

		static IntPtr n_WithSelectedItemByPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSelectedItemByPosition (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedItemByPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSelectedItemByPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSelectedItemByPosition", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSelectedItemByPosition_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSelectedItemByPosition (int p0)
		{
			if (id_withSelectedItemByPosition_I == IntPtr.Zero)
				id_withSelectedItemByPosition_I = JNIEnv.GetMethodID (class_ref, "withSelectedItemByPosition", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectedItemByPosition_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSelectedItemByPosition", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withShowDrawerOnFirstLaunch_Z;
#pragma warning disable 0169
		static Delegate GetWithShowDrawerOnFirstLaunch_ZHandler ()
		{
			if (cb_withShowDrawerOnFirstLaunch_Z == null)
				cb_withShowDrawerOnFirstLaunch_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithShowDrawerOnFirstLaunch_Z);
			return cb_withShowDrawerOnFirstLaunch_Z;
		}

		static IntPtr n_WithShowDrawerOnFirstLaunch_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithShowDrawerOnFirstLaunch (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withShowDrawerOnFirstLaunch_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withShowDrawerOnFirstLaunch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withShowDrawerOnFirstLaunch", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithShowDrawerOnFirstLaunch_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithShowDrawerOnFirstLaunch (bool p0)
		{
			if (id_withShowDrawerOnFirstLaunch_Z == IntPtr.Zero)
				id_withShowDrawerOnFirstLaunch_Z = JNIEnv.GetMethodID (class_ref, "withShowDrawerOnFirstLaunch", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withShowDrawerOnFirstLaunch_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withShowDrawerOnFirstLaunch", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSliderBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetWithSliderBackgroundColor_IHandler ()
		{
			if (cb_withSliderBackgroundColor_I == null)
				cb_withSliderBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSliderBackgroundColor_I);
			return cb_withSliderBackgroundColor_I;
		}

		static IntPtr n_WithSliderBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSliderBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSliderBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSliderBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSliderBackgroundColor", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSliderBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSliderBackgroundColor (int p0)
		{
			if (id_withSliderBackgroundColor_I == IntPtr.Zero)
				id_withSliderBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "withSliderBackgroundColor", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSliderBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSliderBackgroundColor", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSliderBackgroundColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithSliderBackgroundColorRes_IHandler ()
		{
			if (cb_withSliderBackgroundColorRes_I == null)
				cb_withSliderBackgroundColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSliderBackgroundColorRes_I);
			return cb_withSliderBackgroundColorRes_I;
		}

		static IntPtr n_WithSliderBackgroundColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSliderBackgroundColorRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSliderBackgroundColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSliderBackgroundColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSliderBackgroundColorRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSliderBackgroundColorRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSliderBackgroundColorRes (int p0)
		{
			if (id_withSliderBackgroundColorRes_I == IntPtr.Zero)
				id_withSliderBackgroundColorRes_I = JNIEnv.GetMethodID (class_ref, "withSliderBackgroundColorRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSliderBackgroundColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSliderBackgroundColorRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSliderBackgroundDrawable (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSliderBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("withSliderBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSliderBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "withSliderBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSliderBackgroundDrawable_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSliderBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSliderBackgroundDrawableRes_I;
#pragma warning disable 0169
		static Delegate GetWithSliderBackgroundDrawableRes_IHandler ()
		{
			if (cb_withSliderBackgroundDrawableRes_I == null)
				cb_withSliderBackgroundDrawableRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSliderBackgroundDrawableRes_I);
			return cb_withSliderBackgroundDrawableRes_I;
		}

		static IntPtr n_WithSliderBackgroundDrawableRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSliderBackgroundDrawableRes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSliderBackgroundDrawableRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSliderBackgroundDrawableRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withSliderBackgroundDrawableRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSliderBackgroundDrawableRes_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSliderBackgroundDrawableRes (int p0)
		{
			if (id_withSliderBackgroundDrawableRes_I == IntPtr.Zero)
				id_withSliderBackgroundDrawableRes_I = JNIEnv.GetMethodID (class_ref, "withSliderBackgroundDrawableRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSliderBackgroundDrawableRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSliderBackgroundDrawableRes", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withStickyDrawerItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithStickyDrawerItems_Ljava_util_List_Handler ()
		{
			if (cb_withStickyDrawerItems_Ljava_util_List_ == null)
				cb_withStickyDrawerItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStickyDrawerItems_Ljava_util_List_);
			return cb_withStickyDrawerItems_Ljava_util_List_;
		}

		static IntPtr n_WithStickyDrawerItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStickyDrawerItems (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withStickyDrawerItems_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyDrawerItems' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("withStickyDrawerItems", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyDrawerItems_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyDrawerItems (global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> p0)
		{
			if (id_withStickyDrawerItems_Ljava_util_List_ == IntPtr.Zero)
				id_withStickyDrawerItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "withStickyDrawerItems", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyDrawerItems_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyDrawerItems", "(Ljava/util/List;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withStickyFooter_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetWithStickyFooter_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_withStickyFooter_Landroid_view_ViewGroup_ == null)
				cb_withStickyFooter_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStickyFooter_Landroid_view_ViewGroup_);
			return cb_withStickyFooter_Landroid_view_ViewGroup_;
		}

		static IntPtr n_WithStickyFooter_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStickyFooter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withStickyFooter_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyFooter' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("withStickyFooter", "(Landroid/view/ViewGroup;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyFooter_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyFooter (global::Android.Views.ViewGroup p0)
		{
			if (id_withStickyFooter_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_withStickyFooter_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "withStickyFooter", "(Landroid/view/ViewGroup;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyFooter_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyFooter", "(Landroid/view/ViewGroup;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withStickyFooter_I;
#pragma warning disable 0169
		static Delegate GetWithStickyFooter_IHandler ()
		{
			if (cb_withStickyFooter_I == null)
				cb_withStickyFooter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithStickyFooter_I);
			return cb_withStickyFooter_I;
		}

		static IntPtr n_WithStickyFooter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithStickyFooter (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withStickyFooter_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyFooter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withStickyFooter", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyFooter_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyFooter (int p0)
		{
			if (id_withStickyFooter_I == IntPtr.Zero)
				id_withStickyFooter_I = JNIEnv.GetMethodID (class_ref, "withStickyFooter", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyFooter_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyFooter", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withStickyFooterDivider_Z;
#pragma warning disable 0169
		static Delegate GetWithStickyFooterDivider_ZHandler ()
		{
			if (cb_withStickyFooterDivider_Z == null)
				cb_withStickyFooterDivider_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithStickyFooterDivider_Z);
			return cb_withStickyFooterDivider_Z;
		}

		static IntPtr n_WithStickyFooterDivider_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithStickyFooterDivider (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withStickyFooterDivider_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyFooterDivider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withStickyFooterDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyFooterDivider_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyFooterDivider (bool p0)
		{
			if (id_withStickyFooterDivider_Z == IntPtr.Zero)
				id_withStickyFooterDivider_Z = JNIEnv.GetMethodID (class_ref, "withStickyFooterDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyFooterDivider_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyFooterDivider", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withStickyFooterShadow_Z;
#pragma warning disable 0169
		static Delegate GetWithStickyFooterShadow_ZHandler ()
		{
			if (cb_withStickyFooterShadow_Z == null)
				cb_withStickyFooterShadow_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithStickyFooterShadow_Z);
			return cb_withStickyFooterShadow_Z;
		}

		static IntPtr n_WithStickyFooterShadow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithStickyFooterShadow (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withStickyFooterShadow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyFooterShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withStickyFooterShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyFooterShadow_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyFooterShadow (bool p0)
		{
			if (id_withStickyFooterShadow_Z == IntPtr.Zero)
				id_withStickyFooterShadow_Z = JNIEnv.GetMethodID (class_ref, "withStickyFooterShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyFooterShadow_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyFooterShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withStickyHeader_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWithStickyHeader_Landroid_view_View_Handler ()
		{
			if (cb_withStickyHeader_Landroid_view_View_ == null)
				cb_withStickyHeader_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithStickyHeader_Landroid_view_View_);
			return cb_withStickyHeader_Landroid_view_View_;
		}

		static IntPtr n_WithStickyHeader_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithStickyHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withStickyHeader_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyHeader' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("withStickyHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyHeader_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyHeader (global::Android.Views.View p0)
		{
			if (id_withStickyHeader_Landroid_view_View_ == IntPtr.Zero)
				id_withStickyHeader_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "withStickyHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyHeader_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyHeader", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withStickyHeader_I;
#pragma warning disable 0169
		static Delegate GetWithStickyHeader_IHandler ()
		{
			if (cb_withStickyHeader_I == null)
				cb_withStickyHeader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithStickyHeader_I);
			return cb_withStickyHeader_I;
		}

		static IntPtr n_WithStickyHeader_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithStickyHeader (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withStickyHeader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyHeader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withStickyHeader", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyHeader_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyHeader (int p0)
		{
			if (id_withStickyHeader_I == IntPtr.Zero)
				id_withStickyHeader_I = JNIEnv.GetMethodID (class_ref, "withStickyHeader", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyHeader_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyHeader", "(I)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withStickyHeaderShadow_Z;
#pragma warning disable 0169
		static Delegate GetWithStickyHeaderShadow_ZHandler ()
		{
			if (cb_withStickyHeaderShadow_Z == null)
				cb_withStickyHeaderShadow_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithStickyHeaderShadow_Z);
			return cb_withStickyHeaderShadow_Z;
		}

		static IntPtr n_WithStickyHeaderShadow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithStickyHeaderShadow (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withStickyHeaderShadow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withStickyHeaderShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withStickyHeaderShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithStickyHeaderShadow_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithStickyHeaderShadow (bool p0)
		{
			if (id_withStickyHeaderShadow_Z == IntPtr.Zero)
				id_withStickyHeaderShadow_Z = JNIEnv.GetMethodID (class_ref, "withStickyHeaderShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withStickyHeaderShadow_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withStickyHeaderShadow", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withSystemUIHidden_Z;
#pragma warning disable 0169
		static Delegate GetWithSystemUIHidden_ZHandler ()
		{
			if (cb_withSystemUIHidden_Z == null)
				cb_withSystemUIHidden_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSystemUIHidden_Z);
			return cb_withSystemUIHidden_Z;
		}

		static IntPtr n_WithSystemUIHidden_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithSystemUIHidden (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSystemUIHidden_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withSystemUIHidden' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSystemUIHidden", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithSystemUIHidden_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithSystemUIHidden (bool p0)
		{
			if (id_withSystemUIHidden_Z == IntPtr.Zero)
				id_withSystemUIHidden_Z = JNIEnv.GetMethodID (class_ref, "withSystemUIHidden", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSystemUIHidden_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSystemUIHidden", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withToolbar_Landroid_support_v7_widget_Toolbar_;
#pragma warning disable 0169
		static Delegate GetWithToolbar_Landroid_support_v7_widget_Toolbar_Handler ()
		{
			if (cb_withToolbar_Landroid_support_v7_widget_Toolbar_ == null)
				cb_withToolbar_Landroid_support_v7_widget_Toolbar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithToolbar_Landroid_support_v7_widget_Toolbar_);
			return cb_withToolbar_Landroid_support_v7_widget_Toolbar_;
		}

		static IntPtr n_WithToolbar_Landroid_support_v7_widget_Toolbar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.Toolbar p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.Toolbar> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithToolbar (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withToolbar_Landroid_support_v7_widget_Toolbar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withToolbar' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.Toolbar']]"
		[Register ("withToolbar", "(Landroid/support/v7/widget/Toolbar;)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithToolbar_Landroid_support_v7_widget_Toolbar_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithToolbar (global::Android.Support.V7.Widget.Toolbar p0)
		{
			if (id_withToolbar_Landroid_support_v7_widget_Toolbar_ == IntPtr.Zero)
				id_withToolbar_Landroid_support_v7_widget_Toolbar_ = JNIEnv.GetMethodID (class_ref, "withToolbar", "(Landroid/support/v7/widget/Toolbar;)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.DrawerBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withToolbar_Landroid_support_v7_widget_Toolbar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withToolbar", "(Landroid/support/v7/widget/Toolbar;)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withTranslucentNavigationBar_Z;
#pragma warning disable 0169
		static Delegate GetWithTranslucentNavigationBar_ZHandler ()
		{
			if (cb_withTranslucentNavigationBar_Z == null)
				cb_withTranslucentNavigationBar_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithTranslucentNavigationBar_Z);
			return cb_withTranslucentNavigationBar_Z;
		}

		static IntPtr n_WithTranslucentNavigationBar_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTranslucentNavigationBar (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTranslucentNavigationBar_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withTranslucentNavigationBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withTranslucentNavigationBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithTranslucentNavigationBar_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithTranslucentNavigationBar (bool p0)
		{
			if (id_withTranslucentNavigationBar_Z == IntPtr.Zero)
				id_withTranslucentNavigationBar_Z = JNIEnv.GetMethodID (class_ref, "withTranslucentNavigationBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTranslucentNavigationBar_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTranslucentNavigationBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withTranslucentNavigationBarProgrammatically_Z;
#pragma warning disable 0169
		static Delegate GetWithTranslucentNavigationBarProgrammatically_ZHandler ()
		{
			if (cb_withTranslucentNavigationBarProgrammatically_Z == null)
				cb_withTranslucentNavigationBarProgrammatically_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithTranslucentNavigationBarProgrammatically_Z);
			return cb_withTranslucentNavigationBarProgrammatically_Z;
		}

		static IntPtr n_WithTranslucentNavigationBarProgrammatically_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTranslucentNavigationBarProgrammatically (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTranslucentNavigationBarProgrammatically_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withTranslucentNavigationBarProgrammatically' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withTranslucentNavigationBarProgrammatically", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithTranslucentNavigationBarProgrammatically_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithTranslucentNavigationBarProgrammatically (bool p0)
		{
			if (id_withTranslucentNavigationBarProgrammatically_Z == IntPtr.Zero)
				id_withTranslucentNavigationBarProgrammatically_Z = JNIEnv.GetMethodID (class_ref, "withTranslucentNavigationBarProgrammatically", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTranslucentNavigationBarProgrammatically_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTranslucentNavigationBarProgrammatically", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.DrawerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithTranslucentStatusBar (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTranslucentStatusBar_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='DrawerBuilder']/method[@name='withTranslucentStatusBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withTranslucentStatusBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;", "GetWithTranslucentStatusBar_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.DrawerBuilder WithTranslucentStatusBar (bool p0)
		{
			if (id_withTranslucentStatusBar_Z == IntPtr.Zero)
				id_withTranslucentStatusBar_Z = JNIEnv.GetMethodID (class_ref, "withTranslucentStatusBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTranslucentStatusBar_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.DrawerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withTranslucentStatusBar", "(Z)Lcom/mikepenz/materialdrawer/DrawerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
