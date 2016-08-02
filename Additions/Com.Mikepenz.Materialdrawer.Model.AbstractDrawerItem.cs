using System;
using System.Collections.Generic;
using Android.Runtime;
using System.Linq;

namespace Com.Mikepenz.Materialdrawer.Model
{
	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']"
	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/AbstractDrawerItem", DoNotGenerateAcw = true)]
	[global::Java.Interop.JavaTypeParameters(new string[] { "T", "VH extends android.support.v7.widget.RecyclerView.ViewHolder" })]
	public abstract partial class AbstractDrawerItem : global::Java.Lang.Object, global::Com.Mikepenz.Fastadapter.IExpandable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable
	{


		static IntPtr mEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mEnabled']"
		[Register("mEnabled")]
		protected bool MEnabled
		{
			get
			{
				if(mEnabled_jfieldId == IntPtr.Zero)
					mEnabled_jfieldId = JNIEnv.GetFieldID(class_ref, "mEnabled", "Z");
				return JNIEnv.GetBooleanField(( (global::Java.Lang.Object) this ).Handle, mEnabled_jfieldId);
			}
			set
			{
				if(mEnabled_jfieldId == IntPtr.Zero)
					mEnabled_jfieldId = JNIEnv.GetFieldID(class_ref, "mEnabled", "Z");
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mEnabled_jfieldId, value);
				}
				finally
				{
				}
			}
		}

		static IntPtr mIdentifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mIdentifier']"
		[Register("mIdentifier")]
		protected long MIdentifier
		{
			get
			{
				if(mIdentifier_jfieldId == IntPtr.Zero)
					mIdentifier_jfieldId = JNIEnv.GetFieldID(class_ref, "mIdentifier", "J");
				return JNIEnv.GetLongField(( (global::Java.Lang.Object) this ).Handle, mIdentifier_jfieldId);
			}
			set
			{
				if(mIdentifier_jfieldId == IntPtr.Zero)
					mIdentifier_jfieldId = JNIEnv.GetFieldID(class_ref, "mIdentifier", "J");
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mIdentifier_jfieldId, value);
				}
				finally
				{
				}
			}
		}

		static IntPtr mOnDrawerItemClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mOnDrawerItemClickListener']"
		[Register("mOnDrawerItemClickListener")]
		public global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener MOnDrawerItemClickListener
		{
			get
			{
				if(mOnDrawerItemClickListener_jfieldId == IntPtr.Zero)
					mOnDrawerItemClickListener_jfieldId = JNIEnv.GetFieldID(class_ref, "mOnDrawerItemClickListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField(( (global::Java.Lang.Object) this ).Handle, mOnDrawerItemClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener>(__ret, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if(mOnDrawerItemClickListener_jfieldId == IntPtr.Zero)
					mOnDrawerItemClickListener_jfieldId = JNIEnv.GetFieldID(class_ref, "mOnDrawerItemClickListener", "Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mOnDrawerItemClickListener_jfieldId, native_value);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}

		static IntPtr mOnPostBindViewListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mOnPostBindViewListener']"
		[Register("mOnPostBindViewListener")]
		protected global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener MOnPostBindViewListener
		{
			get
			{
				if(mOnPostBindViewListener_jfieldId == IntPtr.Zero)
					mOnPostBindViewListener_jfieldId = JNIEnv.GetFieldID(class_ref, "mOnPostBindViewListener", "Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;");
				IntPtr __ret = JNIEnv.GetObjectField(( (global::Java.Lang.Object) this ).Handle, mOnPostBindViewListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener>(__ret, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if(mOnPostBindViewListener_jfieldId == IntPtr.Zero)
					mOnPostBindViewListener_jfieldId = JNIEnv.GetFieldID(class_ref, "mOnPostBindViewListener", "Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mOnPostBindViewListener_jfieldId, native_value);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}

		static IntPtr mSelectable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mSelectable']"
		[Register("mSelectable")]
		protected bool MSelectable
		{
			get
			{
				if(mSelectable_jfieldId == IntPtr.Zero)
					mSelectable_jfieldId = JNIEnv.GetFieldID(class_ref, "mSelectable", "Z");
				return JNIEnv.GetBooleanField(( (global::Java.Lang.Object) this ).Handle, mSelectable_jfieldId);
			}
			set
			{
				if(mSelectable_jfieldId == IntPtr.Zero)
					mSelectable_jfieldId = JNIEnv.GetFieldID(class_ref, "mSelectable", "Z");
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mSelectable_jfieldId, value);
				}
				finally
				{
				}
			}
		}

		static IntPtr mSelected_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mSelected']"
		[Register("mSelected")]
		protected bool MSelected
		{
			get
			{
				if(mSelected_jfieldId == IntPtr.Zero)
					mSelected_jfieldId = JNIEnv.GetFieldID(class_ref, "mSelected", "Z");
				return JNIEnv.GetBooleanField(( (global::Java.Lang.Object) this ).Handle, mSelected_jfieldId);
			}
			set
			{
				if(mSelected_jfieldId == IntPtr.Zero)
					mSelected_jfieldId = JNIEnv.GetFieldID(class_ref, "mSelected", "Z");
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mSelected_jfieldId, value);
				}
				finally
				{
				}
			}
		}

		static IntPtr mSubItems_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mSubItems']"
		[Register("mSubItems")]
		protected global::System.Collections.IList MSubItems
		{
			get
			{
				if(mSubItems_jfieldId == IntPtr.Zero)
					mSubItems_jfieldId = JNIEnv.GetFieldID(class_ref, "mSubItems", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField(( (global::Java.Lang.Object) this ).Handle, mSubItems_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle(__ret, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if(mSubItems_jfieldId == IntPtr.Zero)
					mSubItems_jfieldId = JNIEnv.GetFieldID(class_ref, "mSubItems", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle(value);
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mSubItems_jfieldId, native_value);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}

		static IntPtr mTag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/field[@name='mTag']"
		[Register("mTag")]
		protected global::Java.Lang.Object MTag
		{
			get
			{
				if(mTag_jfieldId == IntPtr.Zero)
					mTag_jfieldId = JNIEnv.GetFieldID(class_ref, "mTag", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField(( (global::Java.Lang.Object) this ).Handle, mTag_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__ret, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if(mTag_jfieldId == IntPtr.Zero)
					mTag_jfieldId = JNIEnv.GetFieldID(class_ref, "mTag", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JNIEnv.SetField(( (global::Java.Lang.Object) this ).Handle, mTag_jfieldId, native_value);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/mikepenz/materialdrawer/model/AbstractDrawerItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return typeof(AbstractDrawerItem); }
		}

		protected AbstractDrawerItem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/constructor[@name='AbstractDrawerItem' and count(parameter)=0]"
		[Register(".ctor", "()V", "")]
		public unsafe AbstractDrawerItem()
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if(( (global::Java.Lang.Object) this ).Handle != IntPtr.Zero)
				return;

			try
			{
				if(GetType() != typeof(AbstractDrawerItem))
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
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Factory);
		}
#pragma warning restore 0169

		public abstract global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory Factory
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getFactory' and count(parameter)=0]"
			[Register("getFactory", "()Lcom/mikepenz/fastadapter/utils/ViewHolderFactory;", "GetGetFactoryHandler")]
			get;
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler()
		{
			if(cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static long n_GetIdentifier(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Identifier;
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		public virtual unsafe long Identifier
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register("getIdentifier", "()J", "GetGetIdentifierHandler")]
			get
			{
				if(id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID(class_ref, "getIdentifier", "()J");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallLongMethod(( (global::Java.Lang.Object) this ).Handle, id_getIdentifier);
					else
						return JNIEnv.CallNonvirtualLongMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getIdentifier", "()J"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isAutoExpanding;
#pragma warning disable 0169
		static Delegate GetIsAutoExpandingHandler()
		{
			if(cb_isAutoExpanding == null)
				cb_isAutoExpanding = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>) n_IsAutoExpanding);
			return cb_isAutoExpanding;
		}

		static bool n_IsAutoExpanding(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoExpanding;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoExpanding;
		public virtual unsafe bool IsAutoExpanding
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='isAutoExpanding' and count(parameter)=0]"
			[Register("isAutoExpanding", "()Z", "GetIsAutoExpandingHandler")]
			get
			{
				if(id_isAutoExpanding == IntPtr.Zero)
					id_isAutoExpanding = JNIEnv.GetMethodID(class_ref, "isAutoExpanding", "()Z");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_isAutoExpanding);
					else
						return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isAutoExpanding", "()Z"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler()
		{
			if(cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		public virtual unsafe bool IsEnabled
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='isEnabled' and count(parameter)=0]"
			[Register("isEnabled", "()Z", "GetIsEnabledHandler")]
			get
			{
				if(id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID(class_ref, "isEnabled", "()Z");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_isEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isEnabled", "()Z"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isExpanded;
#pragma warning disable 0169
		static Delegate GetIsExpandedHandler()
		{
			if(cb_isExpanded == null)
				cb_isExpanded = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>) n_IsExpanded);
			return cb_isExpanded;
		}

		static bool n_IsExpanded(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpanded;
		}
#pragma warning restore 0169

		static IntPtr id_isExpanded;
		public virtual unsafe bool IsExpanded
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='isExpanded' and count(parameter)=0]"
			[Register("isExpanded", "()Z", "GetIsExpandedHandler")]
			get
			{
				if(id_isExpanded == IntPtr.Zero)
					id_isExpanded = JNIEnv.GetMethodID(class_ref, "isExpanded", "()Z");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_isExpanded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isExpanded", "()Z"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isSelectable;
#pragma warning disable 0169
		static Delegate GetIsSelectableHandler()
		{
			if(cb_isSelectable == null)
				cb_isSelectable = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>) n_IsSelectable);
			return cb_isSelectable;
		}

		static bool n_IsSelectable(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		static IntPtr id_isSelectable;
		public virtual unsafe bool IsSelectable
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='isSelectable' and count(parameter)=0]"
			[Register("isSelectable", "()Z", "GetIsSelectableHandler")]
			get
			{
				if(id_isSelectable == IntPtr.Zero)
					id_isSelectable = JNIEnv.GetMethodID(class_ref, "isSelectable", "()Z");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_isSelectable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isSelectable", "()Z"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_isSelected;
#pragma warning disable 0169
		static Delegate GetIsSelectedHandler()
		{
			if(cb_isSelected == null)
				cb_isSelected = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>) n_IsSelected);
			return cb_isSelected;
		}

		static bool n_IsSelected(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelected;
		}
#pragma warning restore 0169

		static IntPtr id_isSelected;
		public virtual unsafe bool IsSelected
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='isSelected' and count(parameter)=0]"
			[Register("isSelected", "()Z", "GetIsSelectedHandler")]
			get
			{
				if(id_isSelected == IntPtr.Zero)
					id_isSelected = JNIEnv.GetMethodID(class_ref, "isSelected", "()Z");
				try
				{

					if(GetType() == ThresholdType)
						return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_isSelected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "isSelected", "()Z"));
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getOnDrawerItemClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnDrawerItemClickListenerHandler()
		{
			if(cb_getOnDrawerItemClickListener == null)
				cb_getOnDrawerItemClickListener = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDrawerItemClickListener);
			return cb_getOnDrawerItemClickListener;
		}

		static IntPtr n_GetOnDrawerItemClickListener(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.OnDrawerItemClickListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnDrawerItemClickListener;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener OnDrawerItemClickListener
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getOnDrawerItemClickListener' and count(parameter)=0]"
			[Register("getOnDrawerItemClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;", "GetGetOnDrawerItemClickListenerHandler")]
			get
			{
				if(id_getOnDrawerItemClickListener == IntPtr.Zero)
					id_getOnDrawerItemClickListener = JNIEnv.GetMethodID(class_ref, "getOnDrawerItemClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getOnDrawerItemClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getOnDrawerItemClickListener", "()Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getOnPostBindViewListener;
#pragma warning disable 0169
		static Delegate GetGetOnPostBindViewListenerHandler()
		{
			if(cb_getOnPostBindViewListener == null)
				cb_getOnPostBindViewListener = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetOnPostBindViewListener);
			return cb_getOnPostBindViewListener;
		}

		static IntPtr n_GetOnPostBindViewListener(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.OnPostBindViewListener);
		}
#pragma warning restore 0169

		static IntPtr id_getOnPostBindViewListener;
		public virtual unsafe global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener OnPostBindViewListener
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getOnPostBindViewListener' and count(parameter)=0]"
			[Register("getOnPostBindViewListener", "()Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;", "GetGetOnPostBindViewListenerHandler")]
			get
			{
				if(id_getOnPostBindViewListener == IntPtr.Zero)
					id_getOnPostBindViewListener = JNIEnv.GetMethodID(class_ref, "getOnPostBindViewListener", "()Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getOnPostBindViewListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getOnPostBindViewListener", "()Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getSubItems;
#pragma warning disable 0169
		static Delegate GetGetSubItemsHandler()
		{
			if(cb_getSubItems == null)
				cb_getSubItems = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetSubItems);
			return cb_getSubItems;
		}

		static IntPtr n_GetSubItems(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle(__this.SubItems);
		}
#pragma warning restore 0169

		static IntPtr id_getSubItems;
		public virtual unsafe global::System.Collections.IList SubItems => (System.Collections.IList) DrawerSubItems;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> DrawerSubItems
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getSubItems' and count(parameter)=0]"
			[Register("getSubItems", "()Ljava/util/List;", "GetGetSubItemsHandler")]
			get
			{
				if(id_getSubItems == IntPtr.Zero)
					id_getSubItems = JNIEnv.GetMethodID(class_ref, "getSubItems", "()Ljava/util/List;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getSubItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getSubItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler()
		{
			if(cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe global::Java.Lang.Object Tag
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getTag' and count(parameter)=0]"
			[Register("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get
			{
				if(id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID(class_ref, "getTag", "()Ljava/lang/Object;");
				try
				{

					if(GetType() == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getTag", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static Delegate cb_equals_I;
#pragma warning disable 0169
		static Delegate GetEquals_IHandler()
		{
			if(cb_equals_I == null)
				cb_equals_I = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, bool>) n_Equals_I);
			return cb_equals_I;
		}

		static bool n_Equals_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Equals(p0);
		}
#pragma warning restore 0169

		static IntPtr id_equals_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("equals", "(I)Z", "GetEquals_IHandler")]
		public virtual unsafe bool Equals(int p0)
		{
			if(id_equals_I == IntPtr.Zero)
				id_equals_I = JNIEnv.GetMethodID(class_ref, "equals", "(I)Z");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_equals_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "equals", "(I)Z"), __args);
			}
			finally
			{
			}
		}

		static Delegate cb_equals_J;
#pragma warning disable 0169
		static Delegate GetEquals_JHandler()
		{
			if(cb_equals_J == null)
				cb_equals_J = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long, bool>) n_Equals_J);
			return cb_equals_J;
		}

		static bool n_Equals_J(IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Equals(p0);
		}
#pragma warning restore 0169

		static IntPtr id_equals_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register("equals", "(J)Z", "GetEquals_JHandler")]
		public virtual unsafe bool Equals(long p0)
		{
			if(id_equals_J == IntPtr.Zero)
				id_equals_J = JNIEnv.GetMethodID(class_ref, "equals", "(J)Z");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return JNIEnv.CallBooleanMethod(( (global::Java.Lang.Object) this ).Handle, id_equals_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "equals", "(J)Z"), __args);
			}
			finally
			{
			}
		}

		static Delegate cb_generateView_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGenerateView_Landroid_content_Context_Handler()
		{
			if(cb_generateView_Landroid_content_Context_ == null)
				cb_generateView_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateView_Landroid_content_Context_);
			return cb_generateView_Landroid_content_Context_;
		}

		static IntPtr n_GenerateView_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GenerateView(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateView_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='generateView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("generateView", "(Landroid/content/Context;)Landroid/view/View;", "GetGenerateView_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Views.View GenerateView(global::Android.Content.Context p0)
		{
			if(id_generateView_Landroid_content_Context_ == IntPtr.Zero)
				id_generateView_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "generateView", "(Landroid/content/Context;)Landroid/view/View;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Android.Views.View __ret;
				if(GetType() == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_generateView_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "generateView", "(Landroid/content/Context;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGenerateView_Landroid_content_Context_Landroid_view_ViewGroup_Handler()
		{
			if(cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ == null)
				cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateView_Landroid_content_Context_Landroid_view_ViewGroup_);
			return cb_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GenerateView_Landroid_content_Context_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GenerateView(p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='generateView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register("generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGenerateView_Landroid_content_Context_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Android.Views.View GenerateView(global::Android.Content.Context p0, global::Android.Views.ViewGroup p1)
		{
			if(id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID(class_ref, "generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;");
			try
			{
				JValue* __args = stackalloc JValue[2];
				__args[0] = new JValue(p0);
				__args[1] = new JValue(p1);

				global::Android.Views.View __ret;
				if(GetType() == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_generateView_Landroid_content_Context_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "generateView", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_getViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetViewHolder_Landroid_view_ViewGroup_Handler()
		{
			if(cb_getViewHolder_Landroid_view_ViewGroup_ == null)
				cb_getViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetViewHolder_Landroid_view_ViewGroup_);
			return cb_getViewHolder_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetViewHolder_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetViewHolder(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getViewHolder_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register("getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetGetViewHolder_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Java.Lang.Object GetViewHolder(global::Android.Views.ViewGroup p0)
		{
			if(id_getViewHolder_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getViewHolder_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID(class_ref, "getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getViewHolder_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_Handler()
		{
			if(cb_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ == null)
				cb_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_);
			return cb_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_;
		}

		static void n_OnPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem) global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>(native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPostBindView(p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='onPostBindView' and count(parameter)=2 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem'] and parameter[2][@type='android.view.View']]"
		[Register("onPostBindView", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/view/View;)V", "GetOnPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_Handler")]
		public virtual unsafe void OnPostBindView(global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem p0, global::Android.Views.View p1)
		{
			if(id_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ == IntPtr.Zero)
				id_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_ = JNIEnv.GetMethodID(class_ref, "onPostBindView", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/view/View;)V");
			try
			{
				JValue* __args = stackalloc JValue[2];
				__args[0] = new JValue(p0);
				__args[1] = new JValue(p1);

				if(GetType() == ThresholdType)
					JNIEnv.CallVoidMethod(( (global::Java.Lang.Object) this ).Handle, id_onPostBindView_Lcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "onPostBindView", "(Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;Landroid/view/View;)V"), __args);
			}
			finally
			{
			}
		}

		static Delegate cb_withEnabled_Z;
#pragma warning disable 0169
		static Delegate GetWithEnabled_ZHandler()
		{
			if(cb_withEnabled_Z == null)
				cb_withEnabled_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithEnabled_Z);
			return cb_withEnabled_Z;
		}

		static IntPtr n_WithEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithEnabled(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register("withEnabled", "(Z)Ljava/lang/Object;", "GetWithEnabled_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithEnabled(bool p0)
		{
			if(id_withEnabled_Z == IntPtr.Zero)
				id_withEnabled_Z = JNIEnv.GetMethodID(class_ref, "withEnabled", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withEnabled", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIdentifier_J;
#pragma warning disable 0169
		static Delegate GetWithIdentifier_JHandler()
		{
			if(cb_withIdentifier_J == null)
				cb_withIdentifier_J = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long, IntPtr>) n_WithIdentifier_J);
			return cb_withIdentifier_J;
		}

		static IntPtr n_WithIdentifier_J(IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIdentifier(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIdentifier_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withIdentifier' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register("withIdentifier", "(J)Ljava/lang/Object;", "GetWithIdentifier_JHandler")]
		public virtual unsafe global::Java.Lang.Object WithIdentifier(long p0)
		{
			if(id_withIdentifier_J == IntPtr.Zero)
				id_withIdentifier_J = JNIEnv.GetMethodID(class_ref, "withIdentifier", "(J)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withIdentifier_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIdentifier", "(J)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withIsExpanded_Z;
#pragma warning disable 0169
		static Delegate GetWithIsExpanded_ZHandler()
		{
			if(cb_withIsExpanded_Z == null)
				cb_withIsExpanded_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithIsExpanded_Z);
			return cb_withIsExpanded_Z;
		}

		static IntPtr n_WithIsExpanded_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithIsExpanded(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIsExpanded_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withIsExpanded' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register("withIsExpanded", "(Z)Ljava/lang/Object;", "GetWithIsExpanded_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithIsExpanded(bool p0)
		{
			if(id_withIsExpanded_Z == IntPtr.Zero)
				id_withIsExpanded_Z = JNIEnv.GetMethodID(class_ref, "withIsExpanded", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withIsExpanded_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withIsExpanded", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
#pragma warning disable 0169
		static Delegate GetWithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Handler()
		{
			if(cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ == null)
				cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_);
			return cb_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
		}

		static IntPtr n_WithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0 = (global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener) global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithOnDrawerItemClickListener(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withOnDrawerItemClickListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.Drawer.OnDrawerItemClickListener']]"
		[Register("withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)Ljava/lang/Object;", "GetWithOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_Handler")]
		public virtual unsafe global::Java.Lang.Object WithOnDrawerItemClickListener(global::Com.Mikepenz.Materialdrawer.Drawer.IOnDrawerItemClickListener p0)
		{
			if(id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ == IntPtr.Zero)
				id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_ = JNIEnv.GetMethodID(class_ref, "withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withOnDrawerItemClickListener_Lcom_mikepenz_materialdrawer_Drawer_OnDrawerItemClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withOnDrawerItemClickListener", "(Lcom/mikepenz/materialdrawer/Drawer$OnDrawerItemClickListener;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_;
#pragma warning disable 0169
		static Delegate GetWithPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_Handler()
		{
			if(cb_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_ == null)
				cb_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_);
			return cb_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_;
		}

		static IntPtr n_WithPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener) global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithPostOnBindViewListener(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withPostOnBindViewListener' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.OnPostBindViewListener']]"
		[Register("withPostOnBindViewListener", "(Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;)Ljava/lang/Object;", "GetWithPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_Handler")]
		public virtual unsafe global::Java.Lang.Object WithPostOnBindViewListener(global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IOnPostBindViewListener p0)
		{
			if(id_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_ == IntPtr.Zero)
				id_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_ = JNIEnv.GetMethodID(class_ref, "withPostOnBindViewListener", "(Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withPostOnBindViewListener_Lcom_mikepenz_materialdrawer_model_interfaces_OnPostBindViewListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withPostOnBindViewListener", "(Lcom/mikepenz/materialdrawer/model/interfaces/OnPostBindViewListener;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withSelectable_Z;
#pragma warning disable 0169
		static Delegate GetWithSelectable_ZHandler()
		{
			if(cb_withSelectable_Z == null)
				cb_withSelectable_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSelectable_Z);
			return cb_withSelectable_Z;
		}

		static IntPtr n_WithSelectable_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSelectable(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSelectable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withSelectable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register("withSelectable", "(Z)Ljava/lang/Object;", "GetWithSelectable_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithSelectable(bool p0)
		{
			if(id_withSelectable_Z == IntPtr.Zero)
				id_withSelectable_Z = JNIEnv.GetMethodID(class_ref, "withSelectable", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withSelectable_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSelectable", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSetSelected_Z;
#pragma warning disable 0169
		static Delegate GetWithSetSelected_ZHandler()
		{
			if(cb_withSetSelected_Z == null)
				cb_withSetSelected_Z = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool, IntPtr>) n_WithSetSelected_Z);
			return cb_withSetSelected_Z;
		}

		static IntPtr n_WithSetSelected_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.WithSetSelected(p0));
		}
#pragma warning restore 0169

		static IntPtr id_withSetSelected_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withSetSelected' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register("withSetSelected", "(Z)Ljava/lang/Object;", "GetWithSetSelected_ZHandler")]
		public virtual unsafe global::Java.Lang.Object WithSetSelected(bool p0)
		{
			if(id_withSetSelected_Z == IntPtr.Zero)
				id_withSetSelected_Z = JNIEnv.GetMethodID(class_ref, "withSetSelected", "(Z)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				if(GetType() == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withSetSelected_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSetSelected", "(Z)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

		static Delegate cb_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
#pragma warning disable 0169
		static Delegate GetWithSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler()
		{
			if(cb_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == null)
				cb_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_);
			return cb_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		}

		static IntPtr n_WithSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0 = (global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[]) JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem));
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithSubItems(p0));
			if(p0 != null)
				JNIEnv.CopyArray(p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withSubItems' and count(parameter)=1 and parameter[1][@type='com.mikepenz.materialdrawer.model.interfaces.IDrawerItem...']]"
		[Register("withSubItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Ljava/lang/Object;", "GetWithSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_Handler")]
		public virtual unsafe global::Java.Lang.Object WithSubItems(params global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem[] p0)
		{
			if(id_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ == IntPtr.Zero)
				id_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_ = JNIEnv.GetMethodID(class_ref, "withSubItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray(p0);
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(native_p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withSubItems_arrayLcom_mikepenz_materialdrawer_model_interfaces_IDrawerItem_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSubItems", "([Lcom/mikepenz/materialdrawer/model/interfaces/IDrawerItem;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				if(p0 != null)
				{
					JNIEnv.CopyArray(native_p0, p0);
					JNIEnv.DeleteLocalRef(native_p0);
				}
			}
		}

		static Delegate cb_withSubItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetWithSubItems_Ljava_util_List_Handler()
		{
			if(cb_withSubItems_Ljava_util_List_ == null)
				cb_withSubItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSubItems_Ljava_util_List_);
			return cb_withSubItems_Ljava_util_List_;
		}

		static IntPtr n_WithSubItems_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithSubItems(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSubItems_Ljava_util_List_;
		public virtual unsafe global::Java.Lang.Object WithSubItems(global::System.Collections.IList p0)
		{
			global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> subItems = p0.OfType<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>().ToList();
			return WithSubItems(subItems);
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withSubItems' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mikepenz.materialdrawer.model.interfaces.IDrawerItem&gt;']]"
		[Register("withSubItems", "(Ljava/util/List;)Ljava/lang/Object;", "GetWithSubItems_Ljava_util_List_Handler")]
		public virtual unsafe global::Java.Lang.Object WithSubItems(global::System.Collections.Generic.IList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem> p0)
		{
			if(id_withSubItems_Ljava_util_List_ == IntPtr.Zero)
				id_withSubItems_Ljava_util_List_ = JNIEnv.GetMethodID(class_ref, "withSubItems", "(Ljava/util/List;)Ljava/lang/Object;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem>.ToLocalJniHandle(p0);
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(native_p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withSubItems_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withSubItems", "(Ljava/util/List;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

		static Delegate cb_withTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWithTag_Ljava_lang_Object_Handler()
		{
			if(cb_withTag_Ljava_lang_Object_ == null)
				cb_withTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithTag_Ljava_lang_Object_);
			return cb_withTag_Ljava_lang_Object_;
		}

		static IntPtr n_WithTag_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithTag(p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withTag_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='withTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register("withTag", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetWithTag_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object WithTag(global::Java.Lang.Object p0)
		{
			if(id_withTag_Ljava_lang_Object_ == IntPtr.Zero)
				id_withTag_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "withTag", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);

				global::Java.Lang.Object __ret;
				if(GetType() == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallNonvirtualObjectMethod(( (global::Java.Lang.Object) this ).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "withTag", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}

		static Delegate cb_withSubItems_LSystem_Collections_IList_;
#pragma warning disable 0169
		static Delegate GetWithSubItems_LSystem_Collections_IList_Handler()
		{
			if(cb_withSubItems_LSystem_Collections_IList_ == null)
				cb_withSubItems_LSystem_Collections_IList_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSubItems_LSystem_Collections_IList_);
			return cb_withSubItems_LSystem_Collections_IList_;
		}

		static IntPtr n_WithSubItems_LSystem_Collections_IList_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.WithSubItems(p0));
			return __ret;
		}
#pragma warning restore 0169

		//// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='withSubItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		//[Register ("withSubItems", "(LSystem/Collections/IList;)Ljava/lang/Object;", "GetWithSubItems_LSystem_Collections_IList_Handler")]
		//public abstract global::Java.Lang.Object WithSubItems (global::System.Collections.IList p0);

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
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LayoutRes;
		}
#pragma warning restore 0169

		public abstract int LayoutRes
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getLayoutRes' and count(parameter)=0]"
			[Register("getLayoutRes", "()I", "GetGetLayoutResHandler")]
			get;
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
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.model']/class[@name='AbstractDrawerItem']/method[@name='getType' and count(parameter)=0]"
			[Register("getType", "()I", "GetGetTypeHandler")]
			get;
		}

		static Delegate cb_bindView_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetBindView_Ljava_lang_Object_Handler()
		{
			if(cb_bindView_Ljava_lang_Object_ == null)
				cb_bindView_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>) n_BindView_Ljava_lang_Object_);
			return cb_bindView_Ljava_lang_Object_;
		}

		static void n_BindView_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Model.AbstractDrawerItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindView(p0);
		}
#pragma warning restore 0169

		//// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IItem']/method[@name='bindView' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		//[Register("bindView", "(Ljava/lang/Object;)V", "GetBindView_Ljava_lang_Object_Handler")]
		public abstract void BindView<T>(T p0) where T:global::Java.Lang.Object;
		public unsafe void BindView(global::Java.Lang.Object p0) => BindView<global::Java.Lang.Object>(p0);
	}

	[global::Android.Runtime.Register("com/mikepenz/materialdrawer/model/AbstractDrawerItem", DoNotGenerateAcw = true)]
	internal partial class AbstractDrawerItemInvoker : AbstractDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.IDrawerItem, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ISelectable, global::Com.Mikepenz.Materialdrawer.Model.Interfaces.ITagable
	{

		public AbstractDrawerItemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

		protected override global::System.Type ThresholdType
		{
			get { return typeof(AbstractDrawerItemInvoker); }
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
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Utils.IViewHolderFactory>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_getFactory), JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		static IntPtr id_withSubItems_LSystem_Collections_IList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter']/interface[@name='IExpandable']/method[@name='withSubItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register("withSubItems", "(LSystem/Collections/IList;)Ljava/lang/Object;", "GetWithSubItems_LSystem_Collections_IList_Handler")]
		public override unsafe global::Java.Lang.Object WithSubItems(global::System.Collections.IList p0)
		{
			if(id_withSubItems_LSystem_Collections_IList_ == IntPtr.Zero)
				id_withSubItems_LSystem_Collections_IList_ = JNIEnv.GetMethodID(class_ref, "withSubItems", "(LSystem/Collections/IList;)Ljava/lang/Object;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle(p0);
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(( (global::Java.Lang.Object) this ).Handle, id_withSubItems_LSystem_Collections_IList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
			}
		}

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
					return JNIEnv.CallIntMethod(( (global::Java.Lang.Object) this ).Handle, id_getLayoutRes);
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
					return JNIEnv.CallIntMethod(( (global::Java.Lang.Object) this ).Handle, id_getType);
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
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(p0);
				JNIEnv.CallVoidMethod(( (global::Java.Lang.Object) this ).Handle, id_bindView_Ljava_lang_Object_, __args);
			}
			finally
			{
			}
		}

	}

}
