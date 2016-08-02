using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']"
	[Register ("com/mikepenz/materialdrawer/model/interfaces/IDrawerItem", "", "Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "VH extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public partial interface IDrawerItem : global::Com.Mikepenz.Fastadapter.IItem {

		bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")] get;
		}

		bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")] get;
		}

		bool IsSelected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='isSelected' and count(parameter)=0]"
			[Register ("isSelected", "()Z", "GetIsSelectedHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")] get;
		}

		int LayoutRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register ("getLayoutRes", "()I", "GetGetLayoutResHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")] get;
		}

		global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")] get;
		}

		int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='VH']]"
		[Register("bindView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetBindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		void BindView<T>(T p0) where T: global::Java.Lang.Object;

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("equals", "(J)Z", "GetEquals_JHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		bool Equals (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='generateView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("generateView", "(Landroid/content/Context;)Landroid/view/View;", "GetGenerateView_Landroid_content_Context_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		global::Android.Views.View GenerateView (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='generateView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGenerateView_Landroid_content_Context_Landroid_view_ViewGroup_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		global::Android.Views.View GenerateView (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='getViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetGetViewHolder_Landroid_view_ViewGroup_Handler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		global::Java.Lang.Object GetViewHolder (global::Android.Views.ViewGroup p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='withSelectable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSelectable", "(Z)Ljava/lang/Object;", "GetWithSelectable_ZHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithSelectable (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model.interfaces']/interface[@name='IDrawerItem']/method[@name='withSetSelected' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("withSetSelected", "(Z)Ljava/lang/Object;", "GetWithSetSelected_ZHandler:Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItemInvoker, MaterialDrawer")]
		global::Java.Lang.Object WithSetSelected (bool p0);

	}

//	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/interfaces/IDrawerItem", DoNotGenerateAcw=true)]
//	internal class IDrawerItemInvoker : global::Java.Lang.Object, IDrawerItem {

//		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/interfaces/IDrawerItem");

//		protected override IntPtr ThresholdClass {
//			get { return class_ref; }
//		}

//		protected override global::System.Type ThresholdType {
//			get { return typeof (IDrawerItemInvoker); }
//		}

//		IntPtr class_ref;

//		public static IDrawerItem GetObject (IntPtr handle, JniHandleOwnership transfer)
//		{
//			return global::Java.Lang.Object.GetObject<IDrawerItem> (handle, transfer);
//		}

//		static IntPtr Validate (IntPtr handle)
//		{
//			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
//				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
//							JNIEnv.GetClassNameFromInstance (handle), "com.mikepenz.materialdrawer.model.interfaces.IDrawerItem"));
//			return handle;
//		}

//		protected override void Dispose (bool disposing)
//		{
//			if (this.class_ref != IntPtr.Zero)
//				JNIEnv.DeleteGlobalRef (this.class_ref);
//			this.class_ref = IntPtr.Zero;
//			base.Dispose (disposing);
//		}

//		public IDrawerItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
//		{
//			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
//			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
//			JNIEnv.DeleteLocalRef (local_ref);
//		}

//		static Delegate cb_isEnabled;
//#pragma warning disable 0169
//		static Delegate GetIsEnabledHandler ()
//		{
//			if (cb_isEnabled == null)
//				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
//			return cb_isEnabled;
//		}

//		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.IsEnabled;
//		}
//#pragma warning restore 0169

//		IntPtr id_isEnabled;
//		public unsafe bool IsEnabled {
//			get {
//				if (id_isEnabled == IntPtr.Zero)
//					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
//				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
//			}
//		}

//		static Delegate cb_isSelectable;
//#pragma warning disable 0169
//		static Delegate GetIsSelectableHandler ()
//		{
//			if (cb_isSelectable == null)
//				cb_isSelectable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectable);
//			return cb_isSelectable;
//		}

//		static bool n_IsSelectable (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.IsSelectable;
//		}
//#pragma warning restore 0169

//		IntPtr id_isSelectable;
//		public unsafe bool IsSelectable {
//			get {
//				if (id_isSelectable == IntPtr.Zero)
//					id_isSelectable = JNIEnv.GetMethodID (class_ref, "isSelectable", "()Z");
//				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectable);
//			}
//		}

//		static Delegate cb_isSelected;
//#pragma warning disable 0169
//		static Delegate GetIsSelectedHandler ()
//		{
//			if (cb_isSelected == null)
//				cb_isSelected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelected);
//			return cb_isSelected;
//		}

//		static bool n_IsSelected (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.IsSelected;
//		}
//#pragma warning restore 0169

//		IntPtr id_isSelected;
//		public unsafe bool IsSelected {
//			get {
//				if (id_isSelected == IntPtr.Zero)
//					id_isSelected = JNIEnv.GetMethodID (class_ref, "isSelected", "()Z");
//				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelected);
//			}
//		}

//		static Delegate cb_getLayoutRes;
//#pragma warning disable 0169
//		static Delegate GetGetLayoutResHandler ()
//		{
//			if (cb_getLayoutRes == null)
//				cb_getLayoutRes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayoutRes);
//			return cb_getLayoutRes;
//		}

//		static int n_GetLayoutRes (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.LayoutRes;
//		}
//#pragma warning restore 0169

//		IntPtr id_getLayoutRes;
//		public unsafe int LayoutRes {
//			get {
//				if (id_getLayoutRes == IntPtr.Zero)
//					id_getLayoutRes = JNIEnv.GetMethodID (class_ref, "getLayoutRes", "()I");
//				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayoutRes);
//			}
//		}

//		static Delegate cb_getTag;
//#pragma warning disable 0169
//		static Delegate GetGetTagHandler ()
//		{
//			if (cb_getTag == null)
//				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
//			return cb_getTag;
//		}

//		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return JNIEnv.ToLocalJniHandle (__this.Tag);
//		}
//#pragma warning restore 0169

//		IntPtr id_getTag;
//		public unsafe global::Java.Lang.Object Tag {
//			get {
//				if (id_getTag == IntPtr.Zero)
//					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");
//				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
//			}
//		}

//		static Delegate cb_getType;
//#pragma warning disable 0169
//		static Delegate GetGetTypeHandler ()
//		{
//			if (cb_getType == null)
//				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
//			return cb_getType;
//		}

//		static int n_GetType (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.Type;
//		}
//#pragma warning restore 0169

//		IntPtr id_getType;
//		public unsafe int Type {
//			get {
//				if (id_getType == IntPtr.Zero)
//					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
//				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
//			}
//		}

//		static Delegate cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
//#pragma warning disable 0169
//		static Delegate GetBindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
//		{
//			if (cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
//				cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_);
//			return cb_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
//		}

//		static void n_BindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
//			__this.BindView (p0);
//		}
//#pragma warning restore 0169

//		IntPtr id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
//		public unsafe void BindView (global::Java.Lang.Object p0)
//		{
//			if (id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
//				id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "bindView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
//			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (native_p0);
//			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindView_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
//			JNIEnv.DeleteLocalRef (native_p0);
//		}

//		static Delegate cb_equals_J;
//#pragma warning disable 0169
//		static Delegate GetEquals_JHandler ()
//		{
//			if (cb_equals_J == null)
//				cb_equals_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Equals_J);
//			return cb_equals_J;
//		}

//		static bool n_Equals_J (IntPtr jnienv, IntPtr native__this, long p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.Equals (p0);
//		}
//#pragma warning restore 0169

//		IntPtr id_equals_J;
//		public unsafe bool Equals (long p0)
//		{
//			if (id_equals_J == IntPtr.Zero)
//				id_equals_J = JNIEnv.GetMethodID (class_ref, "equals", "(J)Z");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_J, __args);
//		}

//		static Delegate cb_generateView_Landroid_content_Context_;
//#pragma warning disable 0169
//		static Delegate GetGenerateView_Landroid_content_Context_Handler ()
//		{
//			if (cb_generateView_Landroid_content_Context_ == null)
//				cb_generateView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateView_Landroid_content_Context_);
//			return cb_generateView_Landroid_content_Context_;
//		}

//		static IntPtr n_GenerateView_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
//			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateView (p0));
//			return __ret;
//		}
//#pragma warning restore 0169

//		IntPtr id_generateView_Landroid_content_Context_;
//		public unsafe global::Android.Views.View GenerateView (global::Android.Content.Context p0)
//		{
//			if (id_generateView_Landroid_content_Context_ == IntPtr.Zero)
//				id_generateView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "generateView", "(Landroid/content/Context;)Landroid/view/View;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateView_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
//			return __ret;
//		}

//		static Delegate cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
//#pragma warning disable 0169
//		static Delegate GetGenerateView_Landroid_content_Context_Landroid_view_ViewGroup_Handler ()
//		{
//			if (cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ == null)
//				cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateView_Landroid_content_Context_Landroid_view_ViewGroup_);
//			return cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
//		}

//		static IntPtr n_GenerateView_Landroid_content_Context_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
//			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
//			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GenerateView (p0, p1));
//			return __ret;
//		}
//#pragma warning restore 0169

//		IntPtr id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
//		public unsafe global::Android.Views.View GenerateView (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1)
//		{
//			if (id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ == IntPtr.Zero)
//				id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;");
//			JValue* __args = stackalloc JValue [2];
//			__args [0] = new JValue (p0);
//			__args [1] = new JValue (p1);
//			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
//			return __ret;
//		}

//		static Delegate cb_getViewHolder_Landroid_view_ViewGroup_;
//#pragma warning disable 0169
//		static Delegate GetGetViewHolder_Landroid_view_ViewGroup_Handler ()
//		{
//			if (cb_getViewHolder_Landroid_view_ViewGroup_ == null)
//				cb_getViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetViewHolder_Landroid_view_ViewGroup_);
//			return cb_getViewHolder_Landroid_view_ViewGroup_;
//		}

//		static IntPtr n_GetViewHolder_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
//			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetViewHolder (p0));
//			return __ret;
//		}
//#pragma warning restore 0169

//		IntPtr id_getViewHolder_Landroid_view_ViewGroup_;
//		public unsafe global::Java.Lang.Object GetViewHolder (global::Android.Views.ViewGroup p0)
//		{
//			if (id_getViewHolder_Landroid_view_ViewGroup_ == IntPtr.Zero)
//				id_getViewHolder_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewHolder_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
//			return __ret;
//		}

//		static Delegate cb_withSelectable_Z;
//#pragma warning disable 0169
//		static Delegate GetWithSelectable_ZHandler ()
//		{
//			if (cb_withSelectable_Z == null)
//				cb_withSelectable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectable_Z);
//			return cb_withSelectable_Z;
//		}

//		static IntPtr n_WithSelectable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return JNIEnv.ToLocalJniHandle (__this.WithSelectable (p0));
//		}
//#pragma warning restore 0169

//		IntPtr id_withSelectable_Z;
//		public unsafe global::Java.Lang.Object WithSelectable (bool p0)
//		{
//			if (id_withSelectable_Z == IntPtr.Zero)
//				id_withSelectable_Z = JNIEnv.GetMethodID (class_ref, "withSelectable", "(Z)Ljava/lang/Object;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSelectable_Z, __args), JniHandleOwnership.TransferLocalRef);
//		}

//		static Delegate cb_withSetSelected_Z;
//#pragma warning disable 0169
//		static Delegate GetWithSetSelected_ZHandler ()
//		{
//			if (cb_withSetSelected_Z == null)
//				cb_withSetSelected_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSetSelected_Z);
//			return cb_withSetSelected_Z;
//		}

//		static IntPtr n_WithSetSelected_Z (IntPtr jnienv, IntPtr native__this, bool p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return JNIEnv.ToLocalJniHandle (__this.WithSetSelected (p0));
//		}
//#pragma warning restore 0169

//		IntPtr id_withSetSelected_Z;
//		public unsafe global::Java.Lang.Object WithSetSelected (bool p0)
//		{
//			if (id_withSetSelected_Z == IntPtr.Zero)
//				id_withSetSelected_Z = JNIEnv.GetMethodID (class_ref, "withSetSelected", "(Z)Ljava/lang/Object;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSetSelected_Z, __args), JniHandleOwnership.TransferLocalRef);
//		}

//		static Delegate cb_equals_I;
//#pragma warning disable 0169
//		static Delegate GetEquals_IHandler ()
//		{
//			if (cb_equals_I == null)
//				cb_equals_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Equals_I);
//			return cb_equals_I;
//		}

//		static bool n_Equals_I (IntPtr jnienv, IntPtr native__this, int p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.Equals (p0);
//		}
//#pragma warning restore 0169

//		IntPtr id_equals_I;
//		public unsafe global::System.Boolean Equals (int p0)
//		{
//			if (id_equals_I == IntPtr.Zero)
//				id_equals_I = JNIEnv.GetMethodID (class_ref, "equals", "(I)Z");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_I, __args);
//		}

//		static Delegate cb_withEnabled_Z;
//#pragma warning disable 0169
//		static Delegate GetWithEnabled_ZHandler ()
//		{
//			if (cb_withEnabled_Z == null)
//				cb_withEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithEnabled_Z);
//			return cb_withEnabled_Z;
//		}

//		static IntPtr n_WithEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return JNIEnv.ToLocalJniHandle (__this.WithEnabled (p0));
//		}
//#pragma warning restore 0169

//		IntPtr id_withEnabled_Z;
//		public unsafe global::Java.Lang.Object WithEnabled (bool p0)
//		{
//			if (id_withEnabled_Z == IntPtr.Zero)
//				id_withEnabled_Z = JNIEnv.GetMethodID (class_ref, "withEnabled", "(Z)Ljava/lang/Object;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
//		}

//		static Delegate cb_withTag_Ljava_lang_Object_;
//#pragma warning disable 0169
//		static Delegate GetWithTag_Ljava_lang_Object_Handler ()
//		{
//			if (cb_withTag_Ljava_lang_Object_ == null)
//				cb_withTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTag_Ljava_lang_Object_);
//			return cb_withTag_Ljava_lang_Object_;
//		}

//		static IntPtr n_WithTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
//			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithTag (p0));
//			return __ret;
//		}
//#pragma warning restore 0169

//		IntPtr id_withTag_Ljava_lang_Object_;
//		public unsafe global::Java.Lang.Object WithTag (global::Java.Lang.Object p0)
//		{
//			if (id_withTag_Ljava_lang_Object_ == IntPtr.Zero)
//				id_withTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "withTag", "(Ljava/lang/Object;)Ljava/lang/Object;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
//			return __ret;
//		}

//		static Delegate cb_getIdentifier;
//#pragma warning disable 0169
//		static Delegate GetGetIdentifierHandler ()
//		{
//			if (cb_getIdentifier == null)
//				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIdentifier);
//			return cb_getIdentifier;
//		}

//		static long n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return __this.Identifier;
//		}
//#pragma warning restore 0169

//		IntPtr id_getIdentifier;
//		public unsafe global::System.Int64 Identifier {
//			get {
//				if (id_getIdentifier == IntPtr.Zero)
//					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()J");
//				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier);
//			}
//		}

//		static Delegate cb_withIdentifier_J;
//#pragma warning disable 0169
//		static Delegate GetWithIdentifier_JHandler ()
//		{
//			if (cb_withIdentifier_J == null)
//				cb_withIdentifier_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_WithIdentifier_J);
//			return cb_withIdentifier_J;
//		}

//		static IntPtr n_WithIdentifier_J (IntPtr jnienv, IntPtr native__this, long p0)
//		{
//			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//			return JNIEnv.ToLocalJniHandle (__this.WithIdentifier (p0));
//		}
//#pragma warning restore 0169

//		IntPtr id_withIdentifier_J;
//		public unsafe global::Java.Lang.Object WithIdentifier (long p0)
//		{
//			if (id_withIdentifier_J == IntPtr.Zero)
//				id_withIdentifier_J = JNIEnv.GetMethodID (class_ref, "withIdentifier", "(J)Ljava/lang/Object;");
//			JValue* __args = stackalloc JValue [1];
//			__args [0] = new JValue (p0);
//			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIdentifier_J, __args), JniHandleOwnership.TransferLocalRef);
//		}

//	}

}
