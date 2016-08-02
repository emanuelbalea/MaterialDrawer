using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/MiniDrawer", DoNotGenerateAcw=true)]
	public partial class MiniDrawer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/field[@name='ITEM']"
		[Register ("ITEM")]
		public const int Item = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/field[@name='PROFILE']"
		[Register ("PROFILE")]
		public const int Profile = (int) 1;

		static IntPtr mAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/field[@name='mAdapter']"
		[Register ("mAdapter")]
		protected global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter MAdapter {
			get {
				if (mAdapter_jfieldId == IntPtr.Zero)
					mAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdapter", "Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.FastItemAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdapter_jfieldId == IntPtr.Zero)
					mAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdapter", "Lcom/mikepenz/fastadapter/adapters/FastItemAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPositionBasedStateManagement_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/field[@name='mPositionBasedStateManagement']"
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
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='MiniDrawer.OnMiniDrawerItemClickListener']"
		[Register ("com/mikepenz/materialdrawer/MiniDrawer$OnMiniDrawerItemClickListener", "", "Com.Mikepenz.Materialdrawer.MiniDrawer/IOnMiniDrawerItemClickListenerInvoker")]
		public partial interface IOnMiniDrawerItemClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/interface[@name='MiniDrawer.OnMiniDrawerItemClickListener']/method[@name='onItemClick' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[4][@type='int']]"
			[Register ("onItemClick", "(Landroid/view/View;ILcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)Z", "GetOnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler:Com.Mikepenz.Materialdrawer.MiniDrawer/IOnMiniDrawerItemClickListenerInvoker, MaterialDrawer")]
			bool OnItemClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2, int p3);

		}

		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/MiniDrawer$OnMiniDrawerItemClickListener", DoNotGenerateAcw=true)]
		internal class IOnMiniDrawerItemClickListenerInvoker : global::Java.Lang.Object, IOnMiniDrawerItemClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/MiniDrawer$OnMiniDrawerItemClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMiniDrawerItemClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMiniDrawerItemClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMiniDrawerItemClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.MiniDrawer.OnMiniDrawerItemClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMiniDrawerItemClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
#pragma warning disable 0169
			static Delegate GetOnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_IHandler ()
			{
				if (cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == null)
					cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, bool>) n_OnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I);
				return cb_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
			}

			static bool n_OnItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
			{
				global::Com.Mikepenz.Materialdrawer.MiniDrawer.IOnMiniDrawerItemClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer.IOnMiniDrawerItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnItemClick (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I;
			public unsafe bool OnItemClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2, int p3)
			{
				if (id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I == IntPtr.Zero)
					id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Landroid/view/View;ILcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;I)Z");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_Landroid_view_View_ILcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_I, __args);
				return __ret;
			}

		}

		public partial class MiniDrawerItemClickEventArgs : global::System.EventArgs {

			public MiniDrawerItemClickEventArgs (bool handled, global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2, int p3)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2;
			public global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mikepenz/materialdrawer/MiniDrawer_OnMiniDrawerItemClickListenerImplementor")]
		internal sealed partial class IOnMiniDrawerItemClickListenerImplementor : global::Java.Lang.Object, IOnMiniDrawerItemClickListener {

			object sender;

			public IOnMiniDrawerItemClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mikepenz/materialdrawer/MiniDrawer_OnMiniDrawerItemClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MiniDrawerItemClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnItemClick (global::Android.Views.View p0, int p1, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p2, int p3)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MiniDrawerItemClickEventArgs (true, p0, p1, p2, p3);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMiniDrawerItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/MiniDrawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiniDrawer); }
		}

		protected MiniDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/constructor[@name='MiniDrawer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiniDrawer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MiniDrawer)) {
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

		static Delegate cb_getAccountHeader;
#pragma warning disable 0169
		static Delegate GetGetAccountHeaderHandler ()
		{
			if (cb_getAccountHeader == null)
				cb_getAccountHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountHeader);
			return cb_getAccountHeader;
		}

		static IntPtr n_GetAccountHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountHeader);
		}
#pragma warning restore 0169

		static IntPtr id_getAccountHeader;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.AccountHeader AccountHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getAccountHeader' and count(parameter)=0]"
			[Register ("getAccountHeader", "()Lcom/mikepenz/materialdrawer/AccountHeader;", "GetGetAccountHeaderHandler")]
			get {
				if (id_getAccountHeader == IntPtr.Zero)
					id_getAccountHeader = JNIEnv.GetMethodID (class_ref, "getAccountHeader", "()Lcom/mikepenz/materialdrawer/AccountHeader;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountHeader", "()Lcom/mikepenz/materialdrawer/AccountHeader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static IntPtr id_getAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getAdapter' and count(parameter)=0]"
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

		static Delegate cb_getCrossFader;
#pragma warning disable 0169
		static Delegate GetGetCrossFaderHandler ()
		{
			if (cb_getCrossFader == null)
				cb_getCrossFader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCrossFader);
			return cb_getCrossFader;
		}

		static IntPtr n_GetCrossFader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CrossFader);
		}
#pragma warning restore 0169

		static IntPtr id_getCrossFader;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader CrossFader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getCrossFader' and count(parameter)=0]"
			[Register ("getCrossFader", "()Lcom/mikepenz/materialdrawer/interfaces/ICrossfader;", "GetGetCrossFaderHandler")]
			get {
				if (id_getCrossFader == IntPtr.Zero)
					id_getCrossFader = JNIEnv.GetMethodID (class_ref, "getCrossFader", "()Lcom/mikepenz/materialdrawer/interfaces/ICrossfader;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCrossFader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCrossFader", "()Lcom/mikepenz/materialdrawer/interfaces/ICrossfader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDrawer;
#pragma warning disable 0169
		static Delegate GetGetDrawerHandler ()
		{
			if (cb_getDrawer == null)
				cb_getDrawer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawer);
			return cb_getDrawer;
		}

		static IntPtr n_GetDrawer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drawer);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawer;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer Drawer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getDrawer' and count(parameter)=0]"
			[Register ("getDrawer", "()Lcom/mikepenz/materialdrawer/Drawer;", "GetGetDrawerHandler")]
			get {
				if (id_getDrawer == IntPtr.Zero)
					id_getDrawer = JNIEnv.GetMethodID (class_ref, "getDrawer", "()Lcom/mikepenz/materialdrawer/Drawer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawer", "()Lcom/mikepenz/materialdrawer/Drawer;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ItemAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getItemAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter ItemAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getItemAdapter' and count(parameter)=0]"
			[Register ("getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;", "GetGetItemAdapterHandler")]
			get {
				if (id_getItemAdapter == IntPtr.Zero)
					id_getItemAdapter = JNIEnv.GetMethodID (class_ref, "getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.ItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/ItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnMiniDrawerItemLongClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnMiniDrawerItemLongClickListenerHandler ()
		{
			if (cb_getOnMiniDrawerItemLongClickListener == null)
				cb_getOnMiniDrawerItemLongClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnMiniDrawerItemLongClickListener);
			return cb_getOnMiniDrawerItemLongClickListener;
		}

		static IntPtr n_GetOnMiniDrawerItemLongClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnMiniDrawerItemLongClickListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnMiniDrawerItemLongClickListener;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener OnMiniDrawerItemLongClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getOnMiniDrawerItemLongClickListener' and count(parameter)=0]"
			[Register ("getOnMiniDrawerItemLongClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;", "GetGetOnMiniDrawerItemLongClickListenerHandler")]
			get {
				if (id_getOnMiniDrawerItemLongClickListener == IntPtr.Zero)
					id_getOnMiniDrawerItemLongClickListener = JNIEnv.GetMethodID (class_ref, "getOnMiniDrawerItemLongClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMiniDrawerItemLongClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnMiniDrawerItemLongClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnMiniDrawerItemOnClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnMiniDrawerItemOnClickListenerHandler ()
		{
			if (cb_getOnMiniDrawerItemOnClickListener == null)
				cb_getOnMiniDrawerItemOnClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnMiniDrawerItemOnClickListener);
			return cb_getOnMiniDrawerItemOnClickListener;
		}

		static IntPtr n_GetOnMiniDrawerItemOnClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnMiniDrawerItemOnClickListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnMiniDrawerItemOnClickListener;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener OnMiniDrawerItemOnClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getOnMiniDrawerItemOnClickListener' and count(parameter)=0]"
			[Register ("getOnMiniDrawerItemOnClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;", "GetGetOnMiniDrawerItemOnClickListenerHandler")]
			get {
				if (id_getOnMiniDrawerItemOnClickListener == IntPtr.Zero)
					id_getOnMiniDrawerItemOnClickListener = JNIEnv.GetMethodID (class_ref, "getOnMiniDrawerItemOnClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnMiniDrawerItemOnClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnMiniDrawerItemOnClickListener", "()Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRecyclerView;
#pragma warning disable 0169
		static Delegate GetGetRecyclerViewHandler ()
		{
			if (cb_getRecyclerView == null)
				cb_getRecyclerView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecyclerView);
			return cb_getRecyclerView;
		}

		static IntPtr n_GetRecyclerView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecyclerView);
		}
#pragma warning restore 0169

		static IntPtr id_getRecyclerView;
		public virtual unsafe global::Android.Support.V7.Widget.RecyclerView RecyclerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getRecyclerView' and count(parameter)=0]"
			[Register ("getRecyclerView", "()Landroid/support/v7/widget/RecyclerView;", "GetGetRecyclerViewHandler")]
			get {
				if (id_getRecyclerView == IntPtr.Zero)
					id_getRecyclerView = JNIEnv.GetMethodID (class_ref, "getRecyclerView", "()Landroid/support/v7/widget/RecyclerView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRecyclerView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecyclerView", "()Landroid/support/v7/widget/RecyclerView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_build_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuild_Landroid_content_Context_Handler ()
		{
			if (cb_build_Landroid_content_Context_ == null)
				cb_build_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Landroid_content_Context_);
			return cb_build_Landroid_content_Context_;
		}

		static IntPtr n_Build_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_build_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("build", "(Landroid/content/Context;)Landroid/view/View;", "GetBuild_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Views.View Build (global::Android.Content.Context p0)
		{
			if (id_build_Landroid_content_Context_ == IntPtr.Zero)
				id_build_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "build", "(Landroid/content/Context;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.View __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Landroid/content/Context;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createItems;
#pragma warning disable 0169
		static Delegate GetCreateItemsHandler ()
		{
			if (cb_createItems == null)
				cb_createItems = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateItems);
			return cb_createItems;
		}

		static void n_CreateItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateItems ();
		}
#pragma warning restore 0169

		static IntPtr id_createItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='createItems' and count(parameter)=0]"
		[Register ("createItems", "()V", "GetCreateItemsHandler")]
		public virtual unsafe void CreateItems ()
		{
			if (id_createItems == IntPtr.Zero)
				id_createItems = JNIEnv.GetMethodID (class_ref, "createItems", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createItems);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createItems", "()V"));
			} finally {
			}
		}

		static Delegate cb_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetGenerateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static IntPtr n_GenerateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateMiniDrawerItem (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='generateMiniDrawerItem' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("generateMiniDrawerItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;", "GetGenerateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem GenerateMiniDrawerItem (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "generateMiniDrawerItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateMiniDrawerItem_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateMiniDrawerItem", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetGetMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static int n_GetMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMiniDrawerType (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='getMiniDrawerType' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("getMiniDrawerType", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I", "GetGetMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe int GetMiniDrawerType (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "getMiniDrawerType", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMiniDrawerType_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiniDrawerType", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetOnItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler ()
		{
			if (cb_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static bool n_OnItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnItemClick (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='onItemClick' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem']]"
		[Register ("onItemClick", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z", "GetOnItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe bool OnItemClick (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0)
		{
			if (id_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemClick", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onProfileClick;
#pragma warning disable 0169
		static Delegate GetOnProfileClickHandler ()
		{
			if (cb_onProfileClick == null)
				cb_onProfileClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnProfileClick);
			return cb_onProfileClick;
		}

		static void n_OnProfileClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnProfileClick ();
		}
#pragma warning restore 0169

		static IntPtr id_onProfileClick;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='onProfileClick' and count(parameter)=0]"
		[Register ("onProfileClick", "()V", "GetOnProfileClickHandler")]
		public virtual unsafe void OnProfileClick ()
		{
			if (id_onProfileClick == IntPtr.Zero)
				id_onProfileClick = JNIEnv.GetMethodID (class_ref, "onProfileClick", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProfileClick);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProfileClick", "()V"));
			} finally {
			}
		}

		static Delegate cb_setSelection_J;
#pragma warning disable 0169
		static Delegate GetSetSelection_JHandler ()
		{
			if (cb_setSelection_J == null)
				cb_setSelection_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSelection_J);
			return cb_setSelection_J;
		}

		static void n_SetSelection_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setSelection", "(J)V", "GetSetSelection_JHandler")]
		public virtual unsafe void SetSelection (long p0)
		{
			if (id_setSelection_J == IntPtr.Zero)
				id_setSelection_J = JNIEnv.GetMethodID (class_ref, "setSelection", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateItem_J;
#pragma warning disable 0169
		static Delegate GetUpdateItem_JHandler ()
		{
			if (cb_updateItem_J == null)
				cb_updateItem_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_UpdateItem_J);
			return cb_updateItem_J;
		}

		static void n_UpdateItem_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateItem_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='updateItem' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("updateItem", "(J)V", "GetUpdateItem_JHandler")]
		public virtual unsafe void UpdateItem (long p0)
		{
			if (id_updateItem_J == IntPtr.Zero)
				id_updateItem_J = JNIEnv.GetMethodID (class_ref, "updateItem", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateItem_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateItem", "(J)V"), __args);
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
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.AccountHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.AccountHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithAccountHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withAccountHeader' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.AccountHeader']]"
		[Register ("withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithAccountHeader (global::Com.Mikepenz.Materialdrawer.AccountHeader p0)
		{
			if (id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ == IntPtr.Zero)
				id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_ = JNIEnv.GetMethodID (class_ref, "withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.MiniDrawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withAccountHeader_Lcom_mikepenz_materialdrawer_AccountHeader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withAccountHeader", "(Lcom/mikepenz/materialdrawer/AccountHeader;)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_;
#pragma warning disable 0169
		static Delegate GetWithCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_Handler ()
		{
			if (cb_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_ == null)
				cb_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_);
			return cb_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_;
		}

		static IntPtr n_WithCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader p0 = (global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCrossFader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withCrossFader' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.interfaces.ICrossfader']]"
		[Register ("withCrossFader", "(Lcom/mikepenz/materialdrawer/interfaces/ICrossfader;)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithCrossFader (global::Com.Mikepenz.Materialdrawer.Interfaces.ICrossfader p0)
		{
			if (id_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_ == IntPtr.Zero)
				id_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_ = JNIEnv.GetMethodID (class_ref, "withCrossFader", "(Lcom/mikepenz/materialdrawer/interfaces/ICrossfader;)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.MiniDrawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCrossFader_Lcom_mikepenz_materialdrawer_interfaces_ICrossfader_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCrossFader", "(Lcom/mikepenz/materialdrawer/interfaces/ICrossfader;)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithDrawer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withDrawer' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer']]"
		[Register ("withDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithDrawer_Lcom_mikepenz_materialdrawer_Drawer_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithDrawer (global::Com.Mikepenz.Materialdrawer.Drawer p0)
		{
			if (id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_ == IntPtr.Zero)
				id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_ = JNIEnv.GetMethodID (class_ref, "withDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.MiniDrawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withDrawer_Lcom_mikepenz_materialdrawer_Drawer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withDrawer", "(Lcom/mikepenz/materialdrawer/Drawer;)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withEnableProfileClick_Z;
#pragma warning disable 0169
		static Delegate GetWithEnableProfileClick_ZHandler ()
		{
			if (cb_withEnableProfileClick_Z == null)
				cb_withEnableProfileClick_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithEnableProfileClick_Z);
			return cb_withEnableProfileClick_Z;
		}

		static IntPtr n_WithEnableProfileClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithEnableProfileClick (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withEnableProfileClick_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withEnableProfileClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withEnableProfileClick", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithEnableProfileClick_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithEnableProfileClick (bool p0)
		{
			if (id_withEnableProfileClick_Z == IntPtr.Zero)
				id_withEnableProfileClick_Z = JNIEnv.GetMethodID (class_ref, "withEnableProfileClick", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEnableProfileClick_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEnableProfileClick", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withEnableSelectedMiniDrawerItemBackground_Z;
#pragma warning disable 0169
		static Delegate GetWithEnableSelectedMiniDrawerItemBackground_ZHandler ()
		{
			if (cb_withEnableSelectedMiniDrawerItemBackground_Z == null)
				cb_withEnableSelectedMiniDrawerItemBackground_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithEnableSelectedMiniDrawerItemBackground_Z);
			return cb_withEnableSelectedMiniDrawerItemBackground_Z;
		}

		static IntPtr n_WithEnableSelectedMiniDrawerItemBackground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithEnableSelectedMiniDrawerItemBackground (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withEnableSelectedMiniDrawerItemBackground_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withEnableSelectedMiniDrawerItemBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withEnableSelectedMiniDrawerItemBackground", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithEnableSelectedMiniDrawerItemBackground_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithEnableSelectedMiniDrawerItemBackground (bool p0)
		{
			if (id_withEnableSelectedMiniDrawerItemBackground_Z == IntPtr.Zero)
				id_withEnableSelectedMiniDrawerItemBackground_Z = JNIEnv.GetMethodID (class_ref, "withEnableSelectedMiniDrawerItemBackground", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEnableSelectedMiniDrawerItemBackground_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withEnableSelectedMiniDrawerItemBackground", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withInRTL_Z;
#pragma warning disable 0169
		static Delegate GetWithInRTL_ZHandler ()
		{
			if (cb_withInRTL_Z == null)
				cb_withInRTL_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithInRTL_Z);
			return cb_withInRTL_Z;
		}

		static IntPtr n_WithInRTL_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithInRTL (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withInRTL_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withInRTL' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withInRTL", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithInRTL_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithInRTL (bool p0)
		{
			if (id_withInRTL_Z == IntPtr.Zero)
				id_withInRTL_Z = JNIEnv.GetMethodID (class_ref, "withInRTL", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withInRTL_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withInRTL", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withIncludeSecondaryDrawerItems_Z;
#pragma warning disable 0169
		static Delegate GetWithIncludeSecondaryDrawerItems_ZHandler ()
		{
			if (cb_withIncludeSecondaryDrawerItems_Z == null)
				cb_withIncludeSecondaryDrawerItems_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIncludeSecondaryDrawerItems_Z);
			return cb_withIncludeSecondaryDrawerItems_Z;
		}

		static IntPtr n_WithIncludeSecondaryDrawerItems_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIncludeSecondaryDrawerItems (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIncludeSecondaryDrawerItems_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withIncludeSecondaryDrawerItems' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withIncludeSecondaryDrawerItems", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithIncludeSecondaryDrawerItems_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithIncludeSecondaryDrawerItems (bool p0)
		{
			if (id_withIncludeSecondaryDrawerItems_Z == IntPtr.Zero)
				id_withIncludeSecondaryDrawerItems_Z = JNIEnv.GetMethodID (class_ref, "withIncludeSecondaryDrawerItems", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIncludeSecondaryDrawerItems_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIncludeSecondaryDrawerItems", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithInnerShadow (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withInnerShadow_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withInnerShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withInnerShadow", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithInnerShadow_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithInnerShadow (bool p0)
		{
			if (id_withInnerShadow_Z == IntPtr.Zero)
				id_withInnerShadow_Z = JNIEnv.GetMethodID (class_ref, "withInnerShadow", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withInnerShadow_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withInnerShadow", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_Handler ()
		{
			if (cb_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_ == null)
				cb_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_);
			return cb_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_;
		}

		static IntPtr n_WithOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.MiniDrawer.IOnMiniDrawerItemClickListener p0 = (global::Com.Mikepenz.Materialdrawer.MiniDrawer.IOnMiniDrawerItemClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer.IOnMiniDrawerItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnMiniDrawerItemClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withOnMiniDrawerItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.MiniDrawer.OnMiniDrawerItemClickListener']]"
		[Register ("withOnMiniDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/MiniDrawer$OnMiniDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithOnMiniDrawerItemClickListener (global::Com.Mikepenz.Materialdrawer.MiniDrawer.IOnMiniDrawerItemClickListener p0)
		{
			if (id_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_ == IntPtr.Zero)
				id_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnMiniDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/MiniDrawer$OnMiniDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.MiniDrawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnMiniDrawerItemClickListener_Lcom_mikepenz_materialdrawer_MiniDrawer_OnMiniDrawerItemClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnMiniDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/MiniDrawer$OnMiniDrawerItemClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_Handler ()
		{
			if (cb_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ == null)
				cb_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_);
			return cb_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
		}

		static IntPtr n_WithOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnMiniDrawerItemLongClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withOnMiniDrawerItemLongClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnLongClickListener&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("withOnMiniDrawerItemLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithOnMiniDrawerItemLongClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnLongClickListener p0)
		{
			if (id_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ == IntPtr.Zero)
				id_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnMiniDrawerItemLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.MiniDrawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnMiniDrawerItemLongClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnLongClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnMiniDrawerItemLongClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnLongClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler ()
		{
			if (cb_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == null)
				cb_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_);
			return cb_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		}

		static IntPtr n_WithOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0 = (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener)global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithOnMiniDrawerItemOnClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withOnMiniDrawerItemOnClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.FastAdapter.OnClickListener&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register ("withOnMiniDrawerItemOnClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithOnMiniDrawerItemOnClickListener (global::Com.Mikepenz.Fastadapter.FastAdapter.IOnClickListener p0)
		{
			if (id_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ == IntPtr.Zero)
				id_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "withOnMiniDrawerItemOnClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mikepenz.Materialdrawer.MiniDrawer __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withOnMiniDrawerItemOnClickListener_Lcom_mikepenz_fastadapter_FastAdapter_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withOnMiniDrawerItemOnClickListener", "(Lcom/mikepenz/fastadapter/FastAdapter$OnClickListener;)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Mikepenz.Materialdrawer.MiniDrawer __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithPositionBasedStateManagement (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withPositionBasedStateManagement_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer']/class[@name='MiniDrawer']/method[@name='withPositionBasedStateManagement' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withPositionBasedStateManagement", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;", "GetWithPositionBasedStateManagement_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.MiniDrawer WithPositionBasedStateManagement (bool p0)
		{
			if (id_withPositionBasedStateManagement_Z == IntPtr.Zero)
				id_withPositionBasedStateManagement_Z = JNIEnv.GetMethodID (class_ref, "withPositionBasedStateManagement", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withPositionBasedStateManagement_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.MiniDrawer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withPositionBasedStateManagement", "(Z)Lcom/mikepenz/materialdrawer/MiniDrawer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
