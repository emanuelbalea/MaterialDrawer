using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model
{

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']"
	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/ContainerDrawerItem", DoNotGenerateAcw = true)]
	public partial class ContainerDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem
	{

		//		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.ItemFactory']"
		//		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/model/ContainerDrawerItem$ItemFactory", DoNotGenerateAcw=true)]
		//		public partial class ItemFactory : global::Java.Lang.Object, global::Com.Mikepenz.Materialdrawer.Model.IViewHolderFactory<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder> {

		//			internal static IntPtr java_class_handle;
		//			internal static IntPtr class_ref {
		//				get {
		//					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/model/ContainerDrawerItem$ItemFactory", ref java_class_handle);
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
		//			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.ItemFactory']/constructor[@name='ContainerDrawerItem.ItemFactory' and count(parameter)=0]"
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
		//				global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ItemFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ItemFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
		//				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
		//				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0));
		//				return __ret;
		//			}
		//#pragma warning restore 0169

		//			static IntPtr id_create_Landroid_view_View_;
		//			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.ItemFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		//			[Register ("create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder;", "GetCreate_Landroid_view_View_Handler")]
		//			public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder Create (global::Android.Views.View p0)
		//			{
		//				if (id_create_Landroid_view_View_ == IntPtr.Zero)
		//					id_create_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder;");
		//				try {
		//					JValue* __args = stackalloc JValue [1];
		//					__args [0] = new JValue (p0);

		//					global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder __ret;
		//					if (GetType () == ThresholdType)
		//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
		//					else
		//						__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
		//					return __ret;
		//				} finally {
		//				}
		//			}

		//		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.Position']"
		[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/ContainerDrawerItem$Position", DoNotGenerateAcw = true)]
		public sealed partial class Position : global::Java.Lang.Enum
		{


			static IntPtr BOTTOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.Position']/field[@name='BOTTOM']"
			[Register("BOTTOM")]
			public static global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position Bottom
			{
				get
				{
					if(BOTTOM_jfieldId == IntPtr.Zero)
						BOTTOM_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "BOTTOM", "Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, BOTTOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.Position']/field[@name='NONE']"
			[Register("NONE")]
			public static global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position None
			{
				get
				{
					if(NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "NONE", "Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.Position']/field[@name='TOP']"
			[Register("TOP")]
			public static global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position Top
			{
				get
				{
					if(TOP_jfieldId == IntPtr.Zero)
						TOP_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "TOP", "Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField(class_ref, TOP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref
			{
				get
				{
					return JNIEnv.FindClass("com/mikepenz/materialdrawer/model/ContainerDrawerItem$Position", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass
			{
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType
			{
				get { return typeof(Position); }
			}

			internal Position(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.Position']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register("valueOf", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;", "")]
			public static unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position ValueOf(string p0)
			{
				if(id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;");
				IntPtr native_p0 = JNIEnv.NewString(p0);
				try
				{
					JValue* __args = stackalloc JValue[1];
					__args[0] = new JValue(native_p0);
					global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(JNIEnv.CallStaticObjectMethod(class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.Position']/method[@name='values' and count(parameter)=0]"
			[Register("values", "()[Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;", "")]
			public static unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position[] Values()
			{
				if(id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID(class_ref, "values", "()[Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;");
				try
				{
					return (global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position[]) JNIEnv.GetArray(JNIEnv.CallStaticObjectMethod(class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof(global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position));
				}
				finally
				{
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem.ViewHolder']"
		[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder", DoNotGenerateAcw = true)]
		public partial class ViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder
		{

			protected ViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/mikepenz/materialdrawer/model/ContainerDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return typeof(ContainerDrawerItem); }
		}

		protected ContainerDrawerItem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/constructor[@name='ContainerDrawerItem' and count(parameter)=0]"
		[Register(".ctor", "()V", "")]
		public unsafe ContainerDrawerItem()
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if(( (global::Java.Lang.Object) this ).Handle != IntPtr.Zero)
				return;

			try
			{
				if(GetType() != typeof(ContainerDrawerItem))
				{
					SetHandle(
							global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance(( (global::Java.Lang.Object) this ).Handle, "()V");
					return;
				}

				if(id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID(class_ref, "<init>", "()V");
				SetHandle(
						global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(( (global::Java.Lang.Object) this ).Handle, class_ref, id_ctor);
			}
			finally
			{
			}
		}

		static Delegate cb_getFactory;
#pragma warning disable 0169
		static Delegate GetGetFactoryHandler()
		{
			if(cb_getFactory == null)
				cb_getFactory = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetFactory);
			return cb_getFactory;
		}

		static IntPtr n_GetFactory(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Factory);
		}
#pragma warning restore 0169

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
			[Register("getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;", "GetGetFactoryHandler")]
			get
			{
				if(id_getFactory == IntPtr.Zero)
					id_getFactory = JNIEnv.GetMethodID(class_ref, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler()
		{
			if(cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetHeight);
			return cb_getHeight;
		}

		static IntPtr n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Height);
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder Height
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='getHeight' and count(parameter)=0]"
			[Register("getHeight", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;", "GetGetHeightHandler")]
			get
			{
				if(id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID(class_ref, "getHeight", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getHeight), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getHeight", "()Lcom/mikepenz/materialdrawer/holder/DimenHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getLayoutRes;
#pragma warning disable 0169
		static Delegate GetGetLayoutResHandler()
		{
			if(cb_getLayoutRes == null)
				cb_getLayoutRes = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>) n_GetLayoutRes);
			return cb_getLayoutRes;
		}

		static int n_GetLayoutRes(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register("getLayoutRes", "()I", "GetGetLayoutResHandler")]
			get
			{
				if(id_getLayoutRes == IntPtr.Zero)
					id_getLayoutRes = JNIEnv.GetMethodID(class_ref, "getLayoutRes", "()I");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallIntMethod(( (global::Java.Lang.Object) this ).Handle, id_getLayoutRes);
					else
						return JNIEnv.CallNonvirtualIntMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getLayoutRes", "()I"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler()
		{
			if(cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='getType' and count(parameter)=0]"
			[Register("getType", "()I", "GetGetTypeHandler")]
			get
			{
				if(id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID(class_ref, "getType", "()I");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallIntMethod(( (global::Java.Lang.Object) this ).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getType", "()I"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler()
		{
			if(cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Android.Views.View View
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='getView' and count(parameter)=0]"
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				if(id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID(class_ref, "getView", "()Landroid/view/View;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getViewPosition;
#pragma warning disable 0169
		static Delegate GetGetViewPositionHandler()
		{
			if(cb_getViewPosition == null)
				cb_getViewPosition = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetViewPosition);
			return cb_getViewPosition;
		}

		static IntPtr n_GetViewPosition(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.ViewPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getViewPosition;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position ViewPosition
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='getViewPosition' and count(parameter)=0]"
			[Register("getViewPosition", "()Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;", "GetGetViewPositionHandler")]
			get
			{
				if(id_getViewPosition == IntPtr.Zero)
					id_getViewPosition = JNIEnv.GetMethodID(class_ref, "getViewPosition", "()Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getViewPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getViewPosition", "()Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_Handler()
		{
			if(cb_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_ == null)
				cb_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_);
			return cb_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_;
		}

		static void n_BindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView(p0);
		}
#pragma warning restore 0169
		//public virtual unsafe new void BindView(global::Java.Lang.Object p0) => BindView((global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder) p0);
		public override unsafe void BindView<T>(T p0) => BindView(p0 as global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder);

		static IntPtr id_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.ContainerDrawerItem.ViewHolder']]"
		[Register("bindView", "(Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder;)V", "GetBindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_Handler")]
		public virtual unsafe void BindView(global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.ViewHolder p0)
		{
			if(id_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_ == IntPtr.Zero)
				id_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_ = JNIEnv.GetMethodID(class_ref, "bindView", "(Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder;)V");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					JNIEnv.CallVoidMethod(( (global::Java.Lang.Object) this ).Handle, id_bindView_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "bindView", "(Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$ViewHolder;)V"), __args);
			}
			finally
			{
			}
		}

		static Delegate cb_withDivider_Z;
#pragma warning disable 0169
		static Delegate GetWithDivider_ZHandler()
		{
			if(cb_withDivider_Z == null)
				cb_withDivider_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithDivider_Z);
			return cb_withDivider_Z;
		}

		static IntPtr n_WithDivider_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDivider(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDivider_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='withDivider' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register("withDivider", "(Z)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;", "GetWithDivider_ZHandler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem WithDivider(bool p0)
		{
			if(id_withDivider_Z == IntPtr.Zero)
				id_withDivider_Z = JNIEnv.GetMethodID(class_ref, "withDivider", "(Z)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withDivider_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDivider", "(Z)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
#pragma warning disable 0169
		static Delegate GetWithHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler()
		{
			if(cb_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == null)
				cb_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_);
			return cb_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		}

		static IntPtr n_WithHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithHeight(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='withHeight' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.DimenHolder']]"
		[Register("withHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;", "GetWithHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem WithHeight(global::Com.Mikepenz.Materialdrawer.Holder.DimenHolder p0)
		{
			if(id_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ == IntPtr.Zero)
				id_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_ = JNIEnv.GetMethodID(class_ref, "withHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __ret;
				if(GetType() == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withHeight_Lcom_mikepenz_materialdrawer_holder_DimenHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withHeight", "(Lcom/mikepenz/materialdrawer/holder/DimenHolder;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetWithView_Landroid_view_View_Handler()
		{
			if(cb_withView_Landroid_view_View_ == null)
				cb_withView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithView_Landroid_view_View_);
			return cb_withView_Landroid_view_View_;
		}

		static IntPtr n_WithView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithView(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='withView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register("withView", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;", "GetWithView_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem WithView(global::Android.Views.View p0)
		{
			if(id_withView_Landroid_view_View_ == IntPtr.Zero)
				id_withView_Landroid_view_View_ = JNIEnv.GetMethodID(class_ref, "withView", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __ret;
				if(GetType() == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withView", "(Landroid/view/View;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_;
#pragma warning disable 0169
		static Delegate GetWithViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_Handler()
		{
			if(cb_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_ == null)
				cb_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_);
			return cb_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_;
		}

		static IntPtr n_WithViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithViewPosition(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='ContainerDrawerItem']/method[@name='withViewPosition' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.ContainerDrawerItem.Position']]"
		[Register("withViewPosition", "(Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;", "GetWithViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_Handler")]
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem WithViewPosition(global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem.Position p0)
		{
			if(id_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_ == IntPtr.Zero)
				id_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_ = JNIEnv.GetMethodID(class_ref, "withViewPosition", "(Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem __ret;
				if(GetType() == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withViewPosition_Lcom_mikepenz_materialdrawer_model_ContainerDrawerItem_Position_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.ContainerDrawerItem>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withViewPosition", "(Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem$Position;)Lcom/mikepenz/materialdrawer/model/ContainerDrawerItem;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

	}
}
