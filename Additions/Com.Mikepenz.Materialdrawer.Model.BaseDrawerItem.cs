using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Model
{

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']"
	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/BaseDrawerItem", DoNotGenerateAcw = true)]
	[global::Java.Interop.JavaTypeParameters(new string[] { "T", "VH extends android.support.v7.widget.RecyclerView.ViewHolder" })]
	public abstract partial class BaseDrawerItem : global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.INameable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable
	{


		static IntPtr colorStateList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/field[@name='colorStateList']"
		[Register("colorStateList")]
		protected global::Android.Util.Pair ColorStateList
		{
			get
			{
				if(colorStateList_jfieldId == IntPtr.Zero)
					colorStateList_jfieldId = JNIEnv.GetFieldID(class_ref, "colorStateList", "Landroid/util/Pair;");
				IntPtr __ret = JNIEnv.GetObjectField(Handle, colorStateList_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair>(__ret, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if(colorStateList_jfieldId == IntPtr.Zero)
					colorStateList_jfieldId = JNIEnv.GetFieldID(class_ref, "colorStateList", "Landroid/util/Pair;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JNIEnv.SetField(Handle, colorStateList_jfieldId, native_value);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}

		static IntPtr iconTinted_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/field[@name='iconTinted']"
		[Register("iconTinted")]
		protected bool IconTinted
		{
			get
			{
				if(iconTinted_jfieldId == IntPtr.Zero)
					iconTinted_jfieldId = JNIEnv.GetFieldID(class_ref, "iconTinted", "Z");
				return JNIEnv.GetBooleanField(Handle, iconTinted_jfieldId);
			}
			set
			{
				if(iconTinted_jfieldId == IntPtr.Zero)
					iconTinted_jfieldId = JNIEnv.GetFieldID(class_ref, "iconTinted", "Z");
				try
				{
					JNIEnv.SetField(Handle, iconTinted_jfieldId, value);
				}
				finally
				{
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/mikepenz/materialdrawer/model/BaseDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return typeof(BaseDrawerItem); }
		}

		protected BaseDrawerItem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/constructor[@name='BaseDrawerItem' and count(parameter)=0]"
		[Register(".ctor", "()V", "")]
		public unsafe BaseDrawerItem()
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if(Handle != IntPtr.Zero)
				return;

			try
			{
				if(GetType() != typeof(BaseDrawerItem))
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

		static Delegate cb_getDisabledIconColor;
#pragma warning disable 0169
		static Delegate GetGetDisabledIconColorHandler()
		{
			if(cb_getDisabledIconColor == null)
				cb_getDisabledIconColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetDisabledIconColor);
			return cb_getDisabledIconColor;
		}

		static IntPtr n_GetDisabledIconColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.DisabledIconColor);
		}
#pragma warning restore 0169

		static IntPtr id_getDisabledIconColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder DisabledIconColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getDisabledIconColor' and count(parameter)=0]"
			[Register("getDisabledIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetDisabledIconColorHandler")]
			get
			{
				if(id_getDisabledIconColor == IntPtr.Zero)
					id_getDisabledIconColor = JNIEnv.GetMethodID(class_ref, "getDisabledIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getDisabledIconColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getDisabledIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getDisabledTextColor;
#pragma warning disable 0169
		static Delegate GetGetDisabledTextColorHandler()
		{
			if(cb_getDisabledTextColor == null)
				cb_getDisabledTextColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetDisabledTextColor);
			return cb_getDisabledTextColor;
		}

		static IntPtr n_GetDisabledTextColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.DisabledTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getDisabledTextColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder DisabledTextColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getDisabledTextColor' and count(parameter)=0]"
			[Register("getDisabledTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetDisabledTextColorHandler")]
			get
			{
				if(id_getDisabledTextColor == IntPtr.Zero)
					id_getDisabledTextColor = JNIEnv.GetMethodID(class_ref, "getDisabledTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getDisabledTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getDisabledTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler()
		{
			if(cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Icon);
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder Icon
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getIcon' and count(parameter)=0]"
			[Register("getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;", "GetGetIconHandler")]
			get
			{
				if(id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID(class_ref, "getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder>(JNIEnv.CallObjectMethod(Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getIconColor;
#pragma warning disable 0169
		static Delegate GetGetIconColorHandler()
		{
			if(cb_getIconColor == null)
				cb_getIconColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetIconColor);
			return cb_getIconColor;
		}

		static IntPtr n_GetIconColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.IconColor);
		}
#pragma warning restore 0169

		static IntPtr id_getIconColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder IconColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getIconColor' and count(parameter)=0]"
			[Register("getIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetIconColorHandler")]
			get
			{
				if(id_getIconColor == IntPtr.Zero)
					id_getIconColor = JNIEnv.GetMethodID(class_ref, "getIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getIconColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isIconTinted;
#pragma warning disable 0169
		static Delegate GetIsIconTintedHandler()
		{
			if(cb_isIconTinted == null)
				cb_isIconTinted = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>) n_IsIconTinted);
			return cb_isIconTinted;
		}

		static bool n_IsIconTinted(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIconTinted;
		}
#pragma warning restore 0169

		static IntPtr id_isIconTinted;
		public virtual unsafe bool IsIconTinted
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='isIconTinted' and count(parameter)=0]"
			[Register("isIconTinted", "()Z", "GetIsIconTintedHandler")]
			get
			{
				if(id_isIconTinted == IntPtr.Zero)
					id_isIconTinted = JNIEnv.GetMethodID(class_ref, "isIconTinted", "()Z");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallBooleanMethod(Handle, id_isIconTinted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isIconTinted", "()Z"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler()
		{
			if(cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>) n_GetLevel);
			return cb_getLevel;
		}

		static int n_GetLevel(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Level;
		}
#pragma warning restore 0169

		static IntPtr id_getLevel;
		public virtual unsafe int Level
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getLevel' and count(parameter)=0]"
			[Register("getLevel", "()I", "GetGetLevelHandler")]
			get
			{
				if(id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID(class_ref, "getLevel", "()I");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallIntMethod(Handle, id_getLevel);
					else
						return JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getLevel", "()I"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler()
		{
			if(cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.StringHolder Name
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getName' and count(parameter)=0]"
			[Register("getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;", "GetGetNameHandler")]
			get
			{
				if(id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID(class_ref, "getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder>(JNIEnv.CallObjectMethod(Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getName", "()Lcom/mikepenz/materialdrawer/holder/StringHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorHandler()
		{
			if(cb_getSelectedColor == null)
				cb_getSelectedColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedColor);
			return cb_getSelectedColor;
		}

		static IntPtr n_GetSelectedColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.SelectedColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder SelectedColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register("getSelectedColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetSelectedColorHandler")]
			get
			{
				if(id_getSelectedColor == IntPtr.Zero)
					id_getSelectedColor = JNIEnv.GetMethodID(class_ref, "getSelectedColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getSelectedColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getSelectedIcon;
#pragma warning disable 0169
		static Delegate GetGetSelectedIconHandler()
		{
			if(cb_getSelectedIcon == null)
				cb_getSelectedIcon = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedIcon);
			return cb_getSelectedIcon;
		}

		static IntPtr n_GetSelectedIcon(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.SelectedIcon);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedIcon;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder SelectedIcon
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedIcon' and count(parameter)=0]"
			[Register("getSelectedIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;", "GetGetSelectedIconHandler")]
			get
			{
				if(id_getSelectedIcon == IntPtr.Zero)
					id_getSelectedIcon = JNIEnv.GetMethodID(class_ref, "getSelectedIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder>(JNIEnv.CallObjectMethod(Handle, id_getSelectedIcon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedIcon", "()Lcom/mikepenz/materialdrawer/holder/ImageHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getSelectedIconColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedIconColorHandler()
		{
			if(cb_getSelectedIconColor == null)
				cb_getSelectedIconColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedIconColor);
			return cb_getSelectedIconColor;
		}

		static IntPtr n_GetSelectedIconColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.SelectedIconColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedIconColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder SelectedIconColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedIconColor' and count(parameter)=0]"
			[Register("getSelectedIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetSelectedIconColorHandler")]
			get
			{
				if(id_getSelectedIconColor == IntPtr.Zero)
					id_getSelectedIconColor = JNIEnv.GetMethodID(class_ref, "getSelectedIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getSelectedIconColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedIconColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getSelectedTextColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedTextColorHandler()
		{
			if(cb_getSelectedTextColor == null)
				cb_getSelectedTextColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedTextColor);
			return cb_getSelectedTextColor;
		}

		static IntPtr n_GetSelectedTextColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.SelectedTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedTextColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder SelectedTextColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedTextColor' and count(parameter)=0]"
			[Register("getSelectedTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetSelectedTextColorHandler")]
			get
			{
				if(id_getSelectedTextColor == IntPtr.Zero)
					id_getSelectedTextColor = JNIEnv.GetMethodID(class_ref, "getSelectedTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getSelectedTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler()
		{
			if(cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.TextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder TextColor
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getTextColor' and count(parameter)=0]"
			[Register("getTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;", "GetGetTextColorHandler")]
			get
			{
				if(id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID(class_ref, "getTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallObjectMethod(Handle, id_getTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ColorHolder>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getTextColor", "()Lcom/mikepenz/materialdrawer/holder/ColorHolder;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler()
		{
			if(cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Typeface);
		}
#pragma warning restore 0169

		static IntPtr id_getTypeface;
		public virtual unsafe global::Android.Graphics.Typeface Typeface
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getTypeface' and count(parameter)=0]"
			[Register("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get
			{
				if(id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID(class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface>(JNIEnv.CallObjectMethod(Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getTypeface", "()Landroid/graphics/Typeface;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getColor_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetColor_Landroid_content_Context_Handler()
		{
			if(cb_getColor_Landroid_content_Context_ == null)
				cb_getColor_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>) n_GetColor_Landroid_content_Context_);
			return cb_getColor_Landroid_content_Context_;
		}

		static int n_GetColor_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetColor(p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColor_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("getColor", "(Landroid/content/Context;)I", "GetGetColor_Landroid_content_Context_Handler")]
		protected virtual unsafe int GetColor(global::Android.Content.Context p0)
		{
			if(id_getColor_Landroid_content_Context_ == IntPtr.Zero)
				id_getColor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getColor", "(Landroid/content/Context;)I");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				int __ret;
				if(GetType() == ThresholdType)
					__ret = JNIEnv.CallIntMethod(Handle, id_getColor_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getColor", "(Landroid/content/Context;)I"), __args);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_getIconColor_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetIconColor_Landroid_content_Context_Handler()
		{
			if(cb_getIconColor_Landroid_content_Context_ == null)
				cb_getIconColor_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>) n_GetIconColor_Landroid_content_Context_);
			return cb_getIconColor_Landroid_content_Context_;
		}

		static int n_GetIconColor_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIconColor(p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIconColor_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getIconColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("getIconColor", "(Landroid/content/Context;)I", "GetGetIconColor_Landroid_content_Context_Handler")]
		public virtual unsafe int GetIconColor(global::Android.Content.Context p0)
		{
			if(id_getIconColor_Landroid_content_Context_ == IntPtr.Zero)
				id_getIconColor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getIconColor", "(Landroid/content/Context;)I");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				int __ret;
				if(GetType() == ThresholdType)
					__ret = JNIEnv.CallIntMethod(Handle, id_getIconColor_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getIconColor", "(Landroid/content/Context;)I"), __args);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_getSelectedColor_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetSelectedColor_Landroid_content_Context_Handler()
		{
			if(cb_getSelectedColor_Landroid_content_Context_ == null)
				cb_getSelectedColor_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSelectedColor_Landroid_content_Context_);
			return cb_getSelectedColor_Landroid_content_Context_;
		}

		static int n_GetSelectedColor_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSelectedColor(p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedColor_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("getSelectedColor", "(Landroid/content/Context;)I", "GetGetSelectedColor_Landroid_content_Context_Handler")]
		protected virtual unsafe int GetSelectedColor(global::Android.Content.Context p0)
		{
			if(id_getSelectedColor_Landroid_content_Context_ == IntPtr.Zero)
				id_getSelectedColor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getSelectedColor", "(Landroid/content/Context;)I");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				int __ret;
				if(GetType() == ThresholdType)
					__ret = JNIEnv.CallIntMethod(Handle, id_getSelectedColor_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedColor", "(Landroid/content/Context;)I"), __args);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_getSelectedIconColor_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetSelectedIconColor_Landroid_content_Context_Handler()
		{
			if(cb_getSelectedIconColor_Landroid_content_Context_ == null)
				cb_getSelectedIconColor_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSelectedIconColor_Landroid_content_Context_);
			return cb_getSelectedIconColor_Landroid_content_Context_;
		}

		static int n_GetSelectedIconColor_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSelectedIconColor(p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedIconColor_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedIconColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("getSelectedIconColor", "(Landroid/content/Context;)I", "GetGetSelectedIconColor_Landroid_content_Context_Handler")]
		protected virtual unsafe int GetSelectedIconColor(global::Android.Content.Context p0)
		{
			if(id_getSelectedIconColor_Landroid_content_Context_ == IntPtr.Zero)
				id_getSelectedIconColor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getSelectedIconColor", "(Landroid/content/Context;)I");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				int __ret;
				if(GetType() == ThresholdType)
					__ret = JNIEnv.CallIntMethod(Handle, id_getSelectedIconColor_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedIconColor", "(Landroid/content/Context;)I"), __args);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_getSelectedTextColor_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetSelectedTextColor_Landroid_content_Context_Handler()
		{
			if(cb_getSelectedTextColor_Landroid_content_Context_ == null)
				cb_getSelectedTextColor_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSelectedTextColor_Landroid_content_Context_);
			return cb_getSelectedTextColor_Landroid_content_Context_;
		}

		static int n_GetSelectedTextColor_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSelectedTextColor(p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedTextColor_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getSelectedTextColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("getSelectedTextColor", "(Landroid/content/Context;)I", "GetGetSelectedTextColor_Landroid_content_Context_Handler")]
		protected virtual unsafe int GetSelectedTextColor(global::Android.Content.Context p0)
		{
			if(id_getSelectedTextColor_Landroid_content_Context_ == IntPtr.Zero)
				id_getSelectedTextColor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getSelectedTextColor", "(Landroid/content/Context;)I");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				int __ret;
				if(GetType() == ThresholdType)
					__ret = JNIEnv.CallIntMethod(Handle, id_getSelectedTextColor_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSelectedTextColor", "(Landroid/content/Context;)I"), __args);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_getTextColorStateList_II;
#pragma warning disable 0169
		static Delegate GetGetTextColorStateList_IIHandler()
		{
			if(cb_getTextColorStateList_II == null)
				cb_getTextColorStateList_II = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetTextColorStateList_II);
			return cb_getTextColorStateList_II;
		}

		static IntPtr n_GetTextColorStateList_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.GetTextColorStateList(p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getTextColorStateList_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='getTextColorStateList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register("getTextColorStateList", "(II)Landroid/content/res/ColorStateList;", "GetGetTextColorStateList_IIHandler")]
		protected virtual unsafe global::Android.Content.Res.ColorStateList GetTextColorStateList(int p0, int p1)
		{
			if(id_getTextColorStateList_II == IntPtr.Zero)
				id_getTextColorStateList_II = JNIEnv.GetMethodID(class_ref, "getTextColorStateList", "(II)Landroid/content/res/ColorStateList;");
			try
			{
				JValue* __args = stackalloc JValue[ 2 ];
				__args[ 0 ] = new JValue(p0);
				__args[ 1 ] = new JValue(p1);

				if(GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList>(JNIEnv.CallObjectMethod(Handle, id_getTextColorStateList_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getTextColorStateList", "(II)Landroid/content/res/ColorStateList;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withDisabledIconColor_I;
#pragma warning disable 0169
		static Delegate GetWithDisabledIconColor_IHandler()
		{
			if(cb_withDisabledIconColor_I == null)
				cb_withDisabledIconColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDisabledIconColor_I);
			return cb_withDisabledIconColor_I;
		}

		static IntPtr n_WithDisabledIconColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDisabledIconColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDisabledIconColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withDisabledIconColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDisabledIconColor", "(I)Ljava/lang/Object;", "GetWithDisabledIconColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDisabledIconColor(int p0)
		{
			if(id_withDisabledIconColor_I == IntPtr.Zero)
				id_withDisabledIconColor_I = JNIEnv.GetMethodID(class_ref, "withDisabledIconColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDisabledIconColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDisabledIconColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withDisabledIconColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithDisabledIconColorRes_IHandler()
		{
			if(cb_withDisabledIconColorRes_I == null)
				cb_withDisabledIconColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDisabledIconColorRes_I);
			return cb_withDisabledIconColorRes_I;
		}

		static IntPtr n_WithDisabledIconColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDisabledIconColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDisabledIconColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withDisabledIconColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDisabledIconColorRes", "(I)Ljava/lang/Object;", "GetWithDisabledIconColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDisabledIconColorRes(int p0)
		{
			if(id_withDisabledIconColorRes_I == IntPtr.Zero)
				id_withDisabledIconColorRes_I = JNIEnv.GetMethodID(class_ref, "withDisabledIconColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDisabledIconColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDisabledIconColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withDisabledTextColor_I;
#pragma warning disable 0169
		static Delegate GetWithDisabledTextColor_IHandler()
		{
			if(cb_withDisabledTextColor_I == null)
				cb_withDisabledTextColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDisabledTextColor_I);
			return cb_withDisabledTextColor_I;
		}

		static IntPtr n_WithDisabledTextColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDisabledTextColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDisabledTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withDisabledTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDisabledTextColor", "(I)Ljava/lang/Object;", "GetWithDisabledTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDisabledTextColor(int p0)
		{
			if(id_withDisabledTextColor_I == IntPtr.Zero)
				id_withDisabledTextColor_I = JNIEnv.GetMethodID(class_ref, "withDisabledTextColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDisabledTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDisabledTextColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withDisabledTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithDisabledTextColorRes_IHandler()
		{
			if(cb_withDisabledTextColorRes_I == null)
				cb_withDisabledTextColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithDisabledTextColorRes_I);
			return cb_withDisabledTextColorRes_I;
		}

		static IntPtr n_WithDisabledTextColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithDisabledTextColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withDisabledTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withDisabledTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withDisabledTextColorRes", "(I)Ljava/lang/Object;", "GetWithDisabledTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithDisabledTextColorRes(int p0)
		{
			if(id_withDisabledTextColorRes_I == IntPtr.Zero)
				id_withDisabledTextColorRes_I = JNIEnv.GetMethodID(class_ref, "withDisabledTextColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withDisabledTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withDisabledTextColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if(cb_withIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_withIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Landroid_graphics_drawable_Drawable_);
			return cb_withIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithIcon(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register("withIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetWithIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Java.Lang.Object WithIcon(global::Android.Graphics.Drawables.Drawable p0)
		{
			if(id_withIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(class_ref, "withIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler()
		{
			if(cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == null)
				cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Lcom_mikepenz_iconics_typeface_IIcon_);
			return cb_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		}

		static IntPtr n_WithIcon_Lcom_mikepenz_iconics_typeface_IIcon_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Iconics.Typeface.IIcon p0 = (global::Com.Mikepenz.Iconics.Typeface.IIcon) global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithIcon(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.iconics.typeface.IIcon']]"
		[Register("withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Ljava/lang/Object;", "GetWithIcon_Lcom_mikepenz_iconics_typeface_IIcon_Handler")]
		public virtual unsafe global::Java.Lang.Object WithIcon(global::Com.Mikepenz.Iconics.Typeface.IIcon p0)
		{
			if(id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ == IntPtr.Zero)
				id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_ = JNIEnv.GetMethodID(class_ref, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIcon_Lcom_mikepenz_iconics_typeface_IIcon_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIcon", "(Lcom/mikepenz/iconics/typeface/IIcon;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
#pragma warning disable 0169
		static Delegate GetWithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler()
		{
			if(cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == null)
				cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_);
			return cb_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		}

		static IntPtr n_WithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithIcon(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.ImageHolder']]"
		[Register("withIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Ljava/lang/Object;", "GetWithIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_Handler")]
		public virtual unsafe global::Java.Lang.Object WithIcon(global::Com.Mikepenz.Materialdrawer.Holder.ImageHolder p0)
		{
			if(id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ == IntPtr.Zero)
				id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_ = JNIEnv.GetMethodID(class_ref, "withIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIcon_Lcom_mikepenz_materialdrawer_holder_ImageHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIcon", "(Lcom/mikepenz/materialdrawer/holder/ImageHolder;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withIcon_I;
#pragma warning disable 0169
		static Delegate GetWithIcon_IHandler()
		{
			if(cb_withIcon_I == null)
				cb_withIcon_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIcon_I);
			return cb_withIcon_I;
		}

		static IntPtr n_WithIcon_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIcon(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withIcon", "(I)Ljava/lang/Object;", "GetWithIcon_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithIcon(int p0)
		{
			if(id_withIcon_I == IntPtr.Zero)
				id_withIcon_I = JNIEnv.GetMethodID(class_ref, "withIcon", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIcon_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIcon", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIconColor_I;
#pragma warning disable 0169
		static Delegate GetWithIconColor_IHandler()
		{
			if(cb_withIconColor_I == null)
				cb_withIconColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIconColor_I);
			return cb_withIconColor_I;
		}

		static IntPtr n_WithIconColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIconColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIconColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withIconColor", "(I)Ljava/lang/Object;", "GetWithIconColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithIconColor(int p0)
		{
			if(id_withIconColor_I == IntPtr.Zero)
				id_withIconColor_I = JNIEnv.GetMethodID(class_ref, "withIconColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIconColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIconColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIconColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithIconColorRes_IHandler()
		{
			if(cb_withIconColorRes_I == null)
				cb_withIconColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIconColorRes_I);
			return cb_withIconColorRes_I;
		}

		static IntPtr n_WithIconColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIconColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIconColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withIconColorRes", "(I)Ljava/lang/Object;", "GetWithIconColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithIconColorRes(int p0)
		{
			if(id_withIconColorRes_I == IntPtr.Zero)
				id_withIconColorRes_I = JNIEnv.GetMethodID(class_ref, "withIconColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIconColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIconColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIconTinted_Z;
#pragma warning disable 0169
		static Delegate GetWithIconTinted_ZHandler()
		{
			if(cb_withIconTinted_Z == null)
				cb_withIconTinted_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIconTinted_Z);
			return cb_withIconTinted_Z;
		}

		static IntPtr n_WithIconTinted_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIconTinted(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconTinted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIconTinted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete(@"deprecated")]
		[Register("withIconTinted", "(Z)Ljava/lang/Object;", "GetWithIconTinted_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithIconTinted(bool p0)
		{
			if(id_withIconTinted_Z == IntPtr.Zero)
				id_withIconTinted_Z = JNIEnv.GetMethodID(class_ref, "withIconTinted", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIconTinted_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIconTinted", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIconTintingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithIconTintingEnabled_ZHandler()
		{
			if(cb_withIconTintingEnabled_Z == null)
				cb_withIconTintingEnabled_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIconTintingEnabled_Z);
			return cb_withIconTintingEnabled_Z;
		}

		static IntPtr n_WithIconTintingEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIconTintingEnabled(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIconTintingEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withIconTintingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register("withIconTintingEnabled", "(Z)Ljava/lang/Object;", "GetWithIconTintingEnabled_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithIconTintingEnabled(bool p0)
		{
			if(id_withIconTintingEnabled_Z == IntPtr.Zero)
				id_withIconTintingEnabled_Z = JNIEnv.GetMethodID(class_ref, "withIconTintingEnabled", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withIconTintingEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIconTintingEnabled", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withLevel_I;
#pragma warning disable 0169
		static Delegate GetWithLevel_IHandler()
		{
			if(cb_withLevel_I == null)
				cb_withLevel_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithLevel_I);
			return cb_withLevel_I;
		}

		static IntPtr n_WithLevel_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithLevel(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withLevel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withLevel", "(I)Ljava/lang/Object;", "GetWithLevel_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithLevel(int p0)
		{
			if(id_withLevel_I == IntPtr.Zero)
				id_withLevel_I = JNIEnv.GetMethodID(class_ref, "withLevel", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withLevel_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withLevel", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
#pragma warning disable 0169
		static Delegate GetWithName_Lcom_mikepenz_materialdrawer_holder_StringHolder_Handler()
		{
			if(cb_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_ == null)
				cb_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithName_Lcom_mikepenz_materialdrawer_holder_StringHolder_);
			return cb_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
		}

		static IntPtr n_WithName_Lcom_mikepenz_materialdrawer_holder_StringHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Holder.StringHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithName(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withName' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.holder.StringHolder']]"
		[Register("withName", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Ljava/lang/Object;", "GetWithName_Lcom_mikepenz_materialdrawer_holder_StringHolder_Handler")]
		public virtual unsafe global::Java.Lang.Object WithName(global::Com.Mikepenz.Materialdrawer.Holder.StringHolder p0)
		{
			if(id_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_ == IntPtr.Zero)
				id_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_ = JNIEnv.GetMethodID(class_ref, "withName", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withName_Lcom_mikepenz_materialdrawer_holder_StringHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withName", "(Lcom/mikepenz/materialdrawer/holder/StringHolder;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withName_I;
#pragma warning disable 0169
		static Delegate GetWithName_IHandler()
		{
			if(cb_withName_I == null)
				cb_withName_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithName_I);
			return cb_withName_I;
		}

		static IntPtr n_WithName_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithName(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withName", "(I)Ljava/lang/Object;", "GetWithName_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithName(int p0)
		{
			if(id_withName_I == IntPtr.Zero)
				id_withName_I = JNIEnv.GetMethodID(class_ref, "withName", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withName_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withName", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithName_Ljava_lang_String_Handler()
		{
			if(cb_withName_Ljava_lang_String_ == null)
				cb_withName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithName_Ljava_lang_String_);
			return cb_withName_Ljava_lang_String_;
		}

		static IntPtr n_WithName_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithName(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register("withName", "(Ljava/lang/String;)Ljava/lang/Object;", "GetWithName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object WithName(string p0)
		{
			if(id_withName_Ljava_lang_String_ == IntPtr.Zero)
				id_withName_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "withName", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString(p0);
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(native_p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withName", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		static Delegate cb_withSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedColor_IHandler()
		{
			if(cb_withSelectedColor_I == null)
				cb_withSelectedColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedColor_I);
			return cb_withSelectedColor_I;
		}

		static IntPtr n_WithSelectedColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedColor", "(I)Ljava/lang/Object;", "GetWithSelectedColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedColor(int p0)
		{
			if(id_withSelectedColor_I == IntPtr.Zero)
				id_withSelectedColor_I = JNIEnv.GetMethodID(class_ref, "withSelectedColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedColorRes_IHandler()
		{
			if(cb_withSelectedColorRes_I == null)
				cb_withSelectedColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedColorRes_I);
			return cb_withSelectedColorRes_I;
		}

		static IntPtr n_WithSelectedColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedColorRes", "(I)Ljava/lang/Object;", "GetWithSelectedColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedColorRes(int p0)
		{
			if(id_withSelectedColorRes_I == IntPtr.Zero)
				id_withSelectedColorRes_I = JNIEnv.GetMethodID(class_ref, "withSelectedColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetWithSelectedIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if(cb_withSelectedIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_withSelectedIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSelectedIcon_Landroid_graphics_drawable_Drawable_);
			return cb_withSelectedIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_WithSelectedIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithSelectedIcon(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register("withSelectedIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetWithSelectedIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedIcon(global::Android.Graphics.Drawables.Drawable p0)
		{
			if(id_withSelectedIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_withSelectedIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(class_ref, "withSelectedIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedIcon", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedIcon_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedIcon_IHandler()
		{
			if(cb_withSelectedIcon_I == null)
				cb_withSelectedIcon_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedIcon_I);
			return cb_withSelectedIcon_I;
		}

		static IntPtr n_WithSelectedIcon_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedIcon(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedIcon", "(I)Ljava/lang/Object;", "GetWithSelectedIcon_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedIcon(int p0)
		{
			if(id_withSelectedIcon_I == IntPtr.Zero)
				id_withSelectedIcon_I = JNIEnv.GetMethodID(class_ref, "withSelectedIcon", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedIcon_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedIcon", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedIconColor_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedIconColor_IHandler()
		{
			if(cb_withSelectedIconColor_I == null)
				cb_withSelectedIconColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedIconColor_I);
			return cb_withSelectedIconColor_I;
		}

		static IntPtr n_WithSelectedIconColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedIconColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedIconColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedIconColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedIconColor", "(I)Ljava/lang/Object;", "GetWithSelectedIconColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedIconColor(int p0)
		{
			if(id_withSelectedIconColor_I == IntPtr.Zero)
				id_withSelectedIconColor_I = JNIEnv.GetMethodID(class_ref, "withSelectedIconColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedIconColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedIconColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedIconColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedIconColorRes_IHandler()
		{
			if(cb_withSelectedIconColorRes_I == null)
				cb_withSelectedIconColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedIconColorRes_I);
			return cb_withSelectedIconColorRes_I;
		}

		static IntPtr n_WithSelectedIconColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedIconColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedIconColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedIconColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedIconColorRes", "(I)Ljava/lang/Object;", "GetWithSelectedIconColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedIconColorRes(int p0)
		{
			if(id_withSelectedIconColorRes_I == IntPtr.Zero)
				id_withSelectedIconColorRes_I = JNIEnv.GetMethodID(class_ref, "withSelectedIconColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedIconColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedIconColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedTextColor_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedTextColor_IHandler()
		{
			if(cb_withSelectedTextColor_I == null)
				cb_withSelectedTextColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedTextColor_I);
			return cb_withSelectedTextColor_I;
		}

		static IntPtr n_WithSelectedTextColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedTextColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedTextColor", "(I)Ljava/lang/Object;", "GetWithSelectedTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedTextColor(int p0)
		{
			if(id_withSelectedTextColor_I == IntPtr.Zero)
				id_withSelectedTextColor_I = JNIEnv.GetMethodID(class_ref, "withSelectedTextColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedTextColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectedTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithSelectedTextColorRes_IHandler()
		{
			if(cb_withSelectedTextColorRes_I == null)
				cb_withSelectedTextColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithSelectedTextColorRes_I);
			return cb_withSelectedTextColorRes_I;
		}

		static IntPtr n_WithSelectedTextColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectedTextColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectedTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withSelectedTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withSelectedTextColorRes", "(I)Ljava/lang/Object;", "GetWithSelectedTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectedTextColorRes(int p0)
		{
			if(id_withSelectedTextColorRes_I == IntPtr.Zero)
				id_withSelectedTextColorRes_I = JNIEnv.GetMethodID(class_ref, "withSelectedTextColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withSelectedTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectedTextColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withTextColor_I;
#pragma warning disable 0169
		static Delegate GetWithTextColor_IHandler()
		{
			if(cb_withTextColor_I == null)
				cb_withTextColor_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithTextColor_I);
			return cb_withTextColor_I;
		}

		static IntPtr n_WithTextColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithTextColor(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withTextColor", "(I)Ljava/lang/Object;", "GetWithTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithTextColor(int p0)
		{
			if(id_withTextColor_I == IntPtr.Zero)
				id_withTextColor_I = JNIEnv.GetMethodID(class_ref, "withTextColor", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withTextColor", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetWithTextColorRes_IHandler()
		{
			if(cb_withTextColorRes_I == null)
				cb_withTextColorRes_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>) n_WithTextColorRes_I);
			return cb_withTextColorRes_I;
		}

		static IntPtr n_WithTextColorRes_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithTextColorRes(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTextColorRes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("withTextColorRes", "(I)Ljava/lang/Object;", "GetWithTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object WithTextColorRes(int p0)
		{
			if(id_withTextColorRes_I == IntPtr.Zero)
				id_withTextColorRes_I = JNIEnv.GetMethodID(class_ref, "withTextColorRes", "(I)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withTextColorRes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withTextColorRes", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withTintSelectedIcon_Z;
#pragma warning disable 0169
		static Delegate GetWithTintSelectedIcon_ZHandler()
		{
			if(cb_withTintSelectedIcon_Z == null)
				cb_withTintSelectedIcon_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithTintSelectedIcon_Z);
			return cb_withTintSelectedIcon_Z;
		}

		static IntPtr n_WithTintSelectedIcon_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithTintSelectedIcon(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withTintSelectedIcon_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withTintSelectedIcon' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete(@"deprecated")]
		[Register("withTintSelectedIcon", "(Z)Ljava/lang/Object;", "GetWithTintSelectedIcon_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithTintSelectedIcon(bool p0)
		{
			if(id_withTintSelectedIcon_Z == IntPtr.Zero)
				id_withTintSelectedIcon_Z = JNIEnv.GetMethodID(class_ref, "withTintSelectedIcon", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withTintSelectedIcon_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withTintSelectedIcon", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetWithTypeface_Landroid_graphics_Typeface_Handler()
		{
			if(cb_withTypeface_Landroid_graphics_Typeface_ == null)
				cb_withTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTypeface_Landroid_graphics_Typeface_);
			return cb_withTypeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_WithTypeface_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.BaseDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithTypeface(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='BaseDrawerItem']/method[@name='withTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register("withTypeface", "(Landroid/graphics/Typeface;)Ljava/lang/Object;", "GetWithTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Java.Lang.Object WithTypeface(global::Android.Graphics.Typeface p0)
		{
			if(id_withTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_withTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID(class_ref, "withTypeface", "(Landroid/graphics/Typeface;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[ 1 ];
				__args[ 0 ] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(Handle, id_withTypeface_Landroid_graphics_Typeface_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withTypeface", "(Landroid/graphics/Typeface;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

	}

	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/BaseDrawerItem", DoNotGenerateAcw = true)]
	internal partial class BaseDrawerItemInvoker : BaseDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IIconable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.INameable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITypefaceable
	{

		public BaseDrawerItemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

		protected override global::System.Type ThresholdType
		{
			get { return typeof(BaseDrawerItemInvoker); }
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
