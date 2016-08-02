using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Materialdrawer.Icons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']"
	[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/icons/MaterialDrawerFont", DoNotGenerateAcw=true)]
	public partial class MaterialDrawerFont : global::Java.Lang.Object, global::Com.Mikepenz.Iconics.Typeface.ITypeface {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']"
		[global::Android.Runtime.Register ("com/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon", DoNotGenerateAcw=true)]
		public sealed partial class Icon : global::Java.Lang.Enum, global::Com.Mikepenz.Iconics.Typeface.IIcon {


			static IntPtr mdf_arrow_drop_down_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/field[@name='mdf_arrow_drop_down']"
			[Register ("mdf_arrow_drop_down")]
			public static global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon MdfArrowDropDown {
				get {
					if (mdf_arrow_drop_down_jfieldId == IntPtr.Zero)
						mdf_arrow_drop_down_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mdf_arrow_drop_down", "Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mdf_arrow_drop_down_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr mdf_arrow_drop_up_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/field[@name='mdf_arrow_drop_up']"
			[Register ("mdf_arrow_drop_up")]
			public static global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon MdfArrowDropUp {
				get {
					if (mdf_arrow_drop_up_jfieldId == IntPtr.Zero)
						mdf_arrow_drop_up_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mdf_arrow_drop_up", "Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mdf_arrow_drop_up_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr mdf_expand_less_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/field[@name='mdf_expand_less']"
			[Register ("mdf_expand_less")]
			public static global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon MdfExpandLess {
				get {
					if (mdf_expand_less_jfieldId == IntPtr.Zero)
						mdf_expand_less_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mdf_expand_less", "Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mdf_expand_less_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr mdf_expand_more_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/field[@name='mdf_expand_more']"
			[Register ("mdf_expand_more")]
			public static global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon MdfExpandMore {
				get {
					if (mdf_expand_more_jfieldId == IntPtr.Zero)
						mdf_expand_more_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mdf_expand_more", "Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mdf_expand_more_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr mdf_person_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/field[@name='mdf_person']"
			[Register ("mdf_person")]
			public static global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon MdfPerson {
				get {
					if (mdf_person_jfieldId == IntPtr.Zero)
						mdf_person_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mdf_person", "Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mdf_person_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Icon); }
			}

			internal Icon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCharacter;
			public unsafe char Character {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/method[@name='getCharacter' and count(parameter)=0]"
				[Register ("getCharacter", "()C", "GetGetCharacterHandler")]
				get {
					if (id_getCharacter == IntPtr.Zero)
						id_getCharacter = JNIEnv.GetMethodID (class_ref, "getCharacter", "()C");
					try {
						return JNIEnv.CallCharMethod (((global::Java.Lang.Object) this).Handle, id_getCharacter);
					} finally {
					}
				}
			}

			static IntPtr id_getFormattedName;
			public unsafe string FormattedName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/method[@name='getFormattedName' and count(parameter)=0]"
				[Register ("getFormattedName", "()Ljava/lang/String;", "GetGetFormattedNameHandler")]
				get {
					if (id_getFormattedName == IntPtr.Zero)
						id_getFormattedName = JNIEnv.GetMethodID (class_ref, "getFormattedName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getName;
			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getTypeface;
			public unsafe global::Com.Mikepenz.Iconics.Typeface.ITypeface Typeface {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/method[@name='getTypeface' and count(parameter)=0]"
				[Register ("getTypeface", "()Lcom/mikepenz/iconics/typeface/ITypeface;", "GetGetTypefaceHandler")]
				get {
					if (id_getTypeface == IntPtr.Zero)
						id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Lcom/mikepenz/iconics/typeface/ITypeface;");
					try {
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.ITypeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;", "")]
			public static unsafe global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont.Icon']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;", "")]
			public static unsafe global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mikepenz/materialdrawer/icons/MaterialDrawerFont$Icon;");
				try {
					return (global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont.Icon));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/materialdrawer/icons/MaterialDrawerFont", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaterialDrawerFont); }
		}

		protected MaterialDrawerFont (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/constructor[@name='MaterialDrawerFont' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MaterialDrawerFont ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MaterialDrawerFont)) {
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

		static Delegate cb_getAuthor;
#pragma warning disable 0169
		static Delegate GetGetAuthorHandler ()
		{
			if (cb_getAuthor == null)
				cb_getAuthor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthor);
			return cb_getAuthor;
		}

		static IntPtr n_GetAuthor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Author);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthor;
		public virtual unsafe string Author {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getAuthor' and count(parameter)=0]"
			[Register ("getAuthor", "()Ljava/lang/String;", "GetGetAuthorHandler")]
			get {
				if (id_getAuthor == IntPtr.Zero)
					id_getAuthor = JNIEnv.GetMethodID (class_ref, "getAuthor", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCharacters;
#pragma warning disable 0169
		static Delegate GetGetCharactersHandler ()
		{
			if (cb_getCharacters == null)
				cb_getCharacters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharacters);
			return cb_getCharacters;
		}

		static IntPtr n_GetCharacters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Character>.ToLocalJniHandle (__this.Characters);
		}
#pragma warning restore 0169

		static IntPtr id_getCharacters;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Character> Characters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getCharacters' and count(parameter)=0]"
			[Register ("getCharacters", "()Ljava/util/HashMap;", "GetGetCharactersHandler")]
			get {
				if (id_getCharacters == IntPtr.Zero)
					id_getCharacters = JNIEnv.GetMethodID (class_ref, "getCharacters", "()Ljava/util/HashMap;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Character>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharacters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Character>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharacters", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFontName;
#pragma warning disable 0169
		static Delegate GetGetFontNameHandler ()
		{
			if (cb_getFontName == null)
				cb_getFontName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFontName);
			return cb_getFontName;
		}

		static IntPtr n_GetFontName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FontName);
		}
#pragma warning restore 0169

		static IntPtr id_getFontName;
		public virtual unsafe string FontName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getFontName' and count(parameter)=0]"
			[Register ("getFontName", "()Ljava/lang/String;", "GetGetFontNameHandler")]
			get {
				if (id_getFontName == IntPtr.Zero)
					id_getFontName = JNIEnv.GetMethodID (class_ref, "getFontName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFontName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFontName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIconCount;
#pragma warning disable 0169
		static Delegate GetGetIconCountHandler ()
		{
			if (cb_getIconCount == null)
				cb_getIconCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIconCount);
			return cb_getIconCount;
		}

		static int n_GetIconCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IconCount;
		}
#pragma warning restore 0169

		static IntPtr id_getIconCount;
		public virtual unsafe int IconCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getIconCount' and count(parameter)=0]"
			[Register ("getIconCount", "()I", "GetGetIconCountHandler")]
			get {
				if (id_getIconCount == IntPtr.Zero)
					id_getIconCount = JNIEnv.GetMethodID (class_ref, "getIconCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIconCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIconCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIcons;
#pragma warning disable 0169
		static Delegate GetGetIconsHandler ()
		{
			if (cb_getIcons == null)
				cb_getIcons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcons);
			return cb_getIcons;
		}

		static IntPtr n_GetIcons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (__this.Icons);
		}
#pragma warning restore 0169

		static IntPtr id_getIcons;
		public virtual unsafe global::System.Collections.Generic.ICollection<string> Icons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getIcons' and count(parameter)=0]"
			[Register ("getIcons", "()Ljava/util/Collection;", "GetGetIconsHandler")]
			get {
				if (id_getIcons == IntPtr.Zero)
					id_getIcons = JNIEnv.GetMethodID (class_ref, "getIcons", "()Ljava/util/Collection;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcons", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLicense;
#pragma warning disable 0169
		static Delegate GetGetLicenseHandler ()
		{
			if (cb_getLicense == null)
				cb_getLicense = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLicense);
			return cb_getLicense;
		}

		static IntPtr n_GetLicense (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.License);
		}
#pragma warning restore 0169

		static IntPtr id_getLicense;
		public virtual unsafe string License {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getLicense' and count(parameter)=0]"
			[Register ("getLicense", "()Ljava/lang/String;", "GetGetLicenseHandler")]
			get {
				if (id_getLicense == IntPtr.Zero)
					id_getLicense = JNIEnv.GetMethodID (class_ref, "getLicense", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLicense), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLicense", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLicenseUrl;
#pragma warning disable 0169
		static Delegate GetGetLicenseUrlHandler ()
		{
			if (cb_getLicenseUrl == null)
				cb_getLicenseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLicenseUrl);
			return cb_getLicenseUrl;
		}

		static IntPtr n_GetLicenseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LicenseUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getLicenseUrl;
		public virtual unsafe string LicenseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getLicenseUrl' and count(parameter)=0]"
			[Register ("getLicenseUrl", "()Ljava/lang/String;", "GetGetLicenseUrlHandler")]
			get {
				if (id_getLicenseUrl == IntPtr.Zero)
					id_getLicenseUrl = JNIEnv.GetMethodID (class_ref, "getLicenseUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLicenseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLicenseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMappingPrefix;
#pragma warning disable 0169
		static Delegate GetGetMappingPrefixHandler ()
		{
			if (cb_getMappingPrefix == null)
				cb_getMappingPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMappingPrefix);
			return cb_getMappingPrefix;
		}

		static IntPtr n_GetMappingPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MappingPrefix);
		}
#pragma warning restore 0169

		static IntPtr id_getMappingPrefix;
		public virtual unsafe string MappingPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getMappingPrefix' and count(parameter)=0]"
			[Register ("getMappingPrefix", "()Ljava/lang/String;", "GetGetMappingPrefixHandler")]
			get {
				if (id_getMappingPrefix == IntPtr.Zero)
					id_getMappingPrefix = JNIEnv.GetMethodID (class_ref, "getMappingPrefix", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMappingPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMappingPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIcon_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetIcon_Ljava_lang_String_Handler ()
		{
			if (cb_getIcon_Ljava_lang_String_ == null)
				cb_getIcon_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIcon_Ljava_lang_String_);
			return cb_getIcon_Ljava_lang_String_;
		}

		static IntPtr n_GetIcon_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIcon_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getIcon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIcon", "(Ljava/lang/String;)Lcom/mikepenz/iconics/typeface/IIcon;", "GetGetIcon_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Mikepenz.Iconics.Typeface.IIcon GetIcon (string p0)
		{
			if (id_getIcon_Ljava_lang_String_ == IntPtr.Zero)
				id_getIcon_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getIcon", "(Ljava/lang/String;)Lcom/mikepenz/iconics/typeface/IIcon;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Iconics.Typeface.IIcon __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIcon_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Iconics.Typeface.IIcon> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "(Ljava/lang/String;)Lcom/mikepenz/iconics/typeface/IIcon;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTypeface_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetTypeface_Landroid_content_Context_Handler ()
		{
			if (cb_getTypeface_Landroid_content_Context_ == null)
				cb_getTypeface_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTypeface_Landroid_content_Context_);
			return cb_getTypeface_Landroid_content_Context_;
		}

		static IntPtr n_GetTypeface_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Materialdrawer.Icons.MaterialDrawerFont> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTypeface (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTypeface_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.materialdrawer.icons']/class[@name='MaterialDrawerFont']/method[@name='getTypeface' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getTypeface", "(Landroid/content/Context;)Landroid/graphics/Typeface;", "GetGetTypeface_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Graphics.Typeface GetTypeface (global::Android.Content.Context p0)
		{
			if (id_getTypeface_Landroid_content_Context_ == IntPtr.Zero)
				id_getTypeface_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getTypeface", "(Landroid/content/Context;)Landroid/graphics/Typeface;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Typeface __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeface", "(Landroid/content/Context;)Landroid/graphics/Typeface;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
