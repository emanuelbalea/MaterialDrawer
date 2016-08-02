using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model
{

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']"
	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/BasePrimaryDrawerItem", DoNotGenerateAcw = true)]
	[global::Java.Interop.JavaTypeParameters(new string[] { "T", "VH extends com.mikepenz.materialdrawer.model.BaseViewHolder" })]
	public abstract partial class BasePrimaryDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem
	{

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/mikepenz/materialdrawer/model/BasePrimaryDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return typeof(BasePrimaryDrawerItem); }
		}

		protected BasePrimaryDrawerItem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/constructor[@name='BasePrimaryDrawerItem' and count(parameter)=0]"
		[Register(".ctor", "()V", "")]
		public unsafe BasePrimaryDrawerItem()
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if(Handle != IntPtr.Zero)
				return;

			try
			{
				if(GetType() != typeof(BasePrimaryDrawerItem))
				{
					SetHandle(
							global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance(Handle, "()V");
					return;
				}

				if(id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID(class_ref, "<init>", "()V");
				SetHandle(
						global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(Handle, class_ref, id_ctor);
			}
			finally
			{
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler()
		{
			if(cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Description
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='getDescription' and count(parameter)=0]"
			[Register("getDescription", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetDescriptionHandler")]
			get
			{
				if(id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID(class_ref, "getDescription", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder>(JNIEnv.CallObjectMethod(Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getDescription", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getDescriptionTextColor;
#pragma warning disable 0169
		static Delegate GetGetDescriptionTextColorHandler()
		{
			if(cb_getDescriptionTextColor == null)
				cb_getDescriptionTextColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetDescriptionTextColor);
			return cb_getDescriptionTextColor;
		}

		static IntPtr n_GetDescriptionTextColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.DescriptionTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getDescriptionTextColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder DescriptionTextColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='getDescriptionTextColor' and count(parameter)=0]"
			[Register("getDescriptionTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetDescriptionTextColorHandler")]
			get
			{
				if(id_getDescriptionTextColor == IntPtr.Zero)
					id_getDescriptionTextColor = JNIEnv.GetMethodID(class_ref, "getDescriptionTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getDescriptionTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getDescriptionTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetBindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_Handler()
		{
			if(cb_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_ == null)
				cb_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>) n_BindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_);
			return cb_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_;
		}

		static void n_BindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindViewHelper(p0);
		}
#pragma warning restore 0169

		static IntPtr id_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='bindViewHelper' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.BaseViewHolder']]"
		[Register("bindViewHelper", "(Lcom/mikepenz/materialdrawer/model/BaseViewHolder;)V", "GetBindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_Handler")]
		protected virtual unsafe void BindViewHelper(global::Com.Mikepenz.Materialdrawer.Model.BaseViewHolder p0)
		{
			if(id_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_ == IntPtr.Zero)
				id_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_ = JNIEnv.GetMethodID(class_ref, "bindViewHelper", "(Lcom/mikepenz/materialdrawer/model/BaseViewHolder;)V");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					JNIEnv.CallVoidMethod(Handle, id_bindViewHelper_Lcom_mikepenz_materialdrawer_model_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "bindViewHelper", "(Lcom/mikepenz/materialdrawer/model/BaseViewHolder;)V"), __args);
			}
			finally
			{
			}
		}

		static Delegate cb_withDescription_I;
#pragma warning disable 0169
		static Delegate GetWithDescription_IHandler()
		{
			if(cb_withDescription_I == null)
				cb_withDescription_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDescription_I);
			return cb_withDescription_I;
		}

		static IntPtr n_WithDescription_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDescription(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDescription_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='withDescription' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDescription", "(I)Ljava/lang/Object;", "GetWithDescription_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDescription(int p0)
		{
			if(id_withDescription_I == IntPtr.Zero)
				id_withDescription_I = JNIEnv.GetMethodID(class_ref, "withDescription", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDescription_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDescription", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithDescription_Ljava_lang_String_Handler()
		{
			if(cb_withDescription_Ljava_lang_String_ == null)
				cb_withDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithDescription_Ljava_lang_String_);
			return cb_withDescription_Ljava_lang_String_;
		}

		static IntPtr n_WithDescription_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithDescription(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='withDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register("withDescription", "(Ljava/lang/String;)Ljava/lang/Object;", "GetWithDescription_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object WithDescription(string p0)
		{
			if(id_withDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_withDescription_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "withDescription", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString(p0);
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(native_p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDescription_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDescription", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		static Delegate cb_withDescriptionTextColor_I;
#pragma warning disable 0169
		static Delegate GetWithDescriptionTextColor_IHandler()
		{
			if(cb_withDescriptionTextColor_I == null)
				cb_withDescriptionTextColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDescriptionTextColor_I);
			return cb_withDescriptionTextColor_I;
		}

		static IntPtr n_WithDescriptionTextColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDescriptionTextColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDescriptionTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='withDescriptionTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDescriptionTextColor", "(I)Ljava/lang/Object;", "GetWithDescriptionTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDescriptionTextColor(int p0)
		{
			if(id_withDescriptionTextColor_I == IntPtr.Zero)
				id_withDescriptionTextColor_I = JNIEnv.GetMethodID(class_ref, "withDescriptionTextColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDescriptionTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDescriptionTextColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withDescriptionTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithDescriptionTextColorRes_IHandler()
		{
			if(cb_withDescriptionTextColorRes_I == null)
				cb_withDescriptionTextColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDescriptionTextColorRes_I);
			return cb_withDescriptionTextColorRes_I;
		}

		static IntPtr n_WithDescriptionTextColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BasePrimaryDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDescriptionTextColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDescriptionTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BasePrimaryDrawerItem']/method[@name='withDescriptionTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDescriptionTextColorRes", "(I)Ljava/lang/Object;", "GetWithDescriptionTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDescriptionTextColorRes(int p0)
		{
			if(id_withDescriptionTextColorRes_I == IntPtr.Zero)
				id_withDescriptionTextColorRes_I = JNIEnv.GetMethodID(class_ref, "withDescriptionTextColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDescriptionTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDescriptionTextColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

	}

	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/BasePrimaryDrawerItem", DoNotGenerateAcw = true)]
	internal partial class BasePrimaryDrawerItemInvoker : BasePrimaryDrawerItem
	{

		public BasePrimaryDrawerItemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

		protected override global::System.Type ThresholdType
		{
			get { return typeof(BasePrimaryDrawerItemInvoker); }
		}

		static IntPtr id_getFactory;
		public override unsafe global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
			[Register("getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;", "GetGetFactoryHandler")]
			get
			{
				if(id_getFactory == IntPtr.Zero)
					id_getFactory = JNIEnv.GetMethodID(class_ref, "getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;");
				try
				{
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory>(JNIEnv.CallObjectMethod(Handle, id_getFactory), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		//static IntPtr id_withSubItems_LSystem_Collections_IList_;
		//// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='withSubItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		//[Register ("withSubItems", "(LSystem/Collections/IList;)Ljava/lang/Object;", "GetWithSubItems_LSystem_Collections_IList_Handler")]
		//public override unsafe global::Java.Lang.Object WithSubItems (global::System.Collections.IList p0)
		//{
		//	if (id_withSubItems_LSystem_Collections_IList_ == IntPtr.Zero)
		//		id_withSubItems_LSystem_Collections_IList_ = JNIEnv.GetMethodID (class_ref, "withSubItems", "(LSystem/Collections/IList;)Ljava/lang/Object;");
		//	IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
		//	try {
		//		JValue* __args = stackalloc JValue [1];
		//		__args [0] = new JValue (native_p0);
		//		global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_withSubItems_LSystem_Collections_IList_, __args), JniHandleOwnership.TransferLocalRef);
		//		return __ret;
		//	} finally {
		//		JNIEnv.DeleteLocalRef (native_p0);
		//	}
		//}

		static IntPtr id_getLayoutRes;
		public override unsafe int LayoutRes
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register("getLayoutRes", "()I", "GetGetLayoutResHandler")]
			get
			{
				if(id_getLayoutRes == IntPtr.Zero)
					id_getLayoutRes = JNIEnv.GetMethodID(class_ref, "getLayoutRes", "()I");
				try
				{
					return JNIEnv.CallIntMethod(Handle, id_getLayoutRes);
				}
				finally
				{
				}
			}
		}

		static IntPtr id_getType;
		public override unsafe int Type
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getType' and count(parameter)=0]"
			[Register("getType", "()I", "GetGetTypeHandler")]
			get
			{
				if(id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID(class_ref, "getType", "()I");
				try
				{
					return JNIEnv.CallIntMethod(Handle, id_getType);
				}
				finally
				{
				}
			}
		}

		static IntPtr id_bindView_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register("bindView", "(Ljava/lang/Object;)V", "GetBindView_Ljava_lang_Object_Handler")]
		public override unsafe void BindView<T>(T p0)
		{
			if(id_bindView_Ljava_lang_Object_ == IntPtr.Zero)
				id_bindView_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "bindView", "(Ljava/lang/Object;)V");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);
				JNIEnv.CallVoidMethod(Handle, id_bindView_Ljava_lang_Object_, __args);
			}
			finally
			{
			}
		}

	}

}
