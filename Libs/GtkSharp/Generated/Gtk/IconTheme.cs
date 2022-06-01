// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class IconTheme : GLib.Object {

		public IconTheme (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_new();
		static d_gtk_icon_theme_new gtk_icon_theme_new = FuncLoader.LoadFunction<d_gtk_icon_theme_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_new"));

		public IconTheme () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IconTheme)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_icon_theme_new();
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				IconTheme __obj = GLib.Object.GetObject (inst, false) as IconTheme;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.IconTheme), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = class_abi.BaseOverride<ChangedNativeDelegate>(this.LookupGType(), "changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("changed"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // changed
							, null
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "changed"
							, "_gtk_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_theme_add_builtin_icon(IntPtr icon_name, int size, IntPtr pixbuf);
		static d_gtk_icon_theme_add_builtin_icon gtk_icon_theme_add_builtin_icon = FuncLoader.LoadFunction<d_gtk_icon_theme_add_builtin_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_add_builtin_icon"));

		[Obsolete]
		public static void AddBuiltinIcon(string icon_name, int size, Gdk.Pixbuf pixbuf) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			gtk_icon_theme_add_builtin_icon(native_icon_name, size, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
			GLib.Marshaller.Free (native_icon_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_theme_add_resource_path(IntPtr raw, IntPtr path);
		static d_gtk_icon_theme_add_resource_path gtk_icon_theme_add_resource_path = FuncLoader.LoadFunction<d_gtk_icon_theme_add_resource_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_add_resource_path"));

		public void AddResourcePath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			gtk_icon_theme_add_resource_path(Handle, native_path);
			GLib.Marshaller.Free (native_path);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_theme_append_search_path(IntPtr raw, IntPtr path);
		static d_gtk_icon_theme_append_search_path gtk_icon_theme_append_search_path = FuncLoader.LoadFunction<d_gtk_icon_theme_append_search_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_append_search_path"));

		public void AppendSearchPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			gtk_icon_theme_append_search_path(Handle, native_path);
			GLib.Marshaller.Free (native_path);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_choose_icon(IntPtr raw, IntPtr[] icon_names, int size, int flags);
		static d_gtk_icon_theme_choose_icon gtk_icon_theme_choose_icon = FuncLoader.LoadFunction<d_gtk_icon_theme_choose_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_choose_icon"));

		public Gtk.IconInfo ChooseIcon(string[] icon_names, int size, Gtk.IconLookupFlags flags) {
			int cnt_icon_names = icon_names == null ? 0 : icon_names.Length;
			IntPtr[] native_icon_names = new IntPtr [cnt_icon_names + 1];
			for (int i = 0; i < cnt_icon_names; i++)
				native_icon_names [i] = GLib.Marshaller.StringToPtrGStrdup (icon_names[i]);
			native_icon_names [cnt_icon_names] = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_theme_choose_icon(Handle, native_icon_names, size, (int) flags);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret) as Gtk.IconInfo;
			for (int i = 0; i < native_icon_names.Length - 1; i++) {
				icon_names [i] = GLib.Marshaller.Utf8PtrToString (native_icon_names[i]);
				GLib.Marshaller.Free (native_icon_names[i]);
			}
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_choose_icon_for_scale(IntPtr raw, IntPtr[] icon_names, int size, int scale, int flags);
		static d_gtk_icon_theme_choose_icon_for_scale gtk_icon_theme_choose_icon_for_scale = FuncLoader.LoadFunction<d_gtk_icon_theme_choose_icon_for_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_choose_icon_for_scale"));

		public Gtk.IconInfo ChooseIconForScale(string[] icon_names, int size, int scale, Gtk.IconLookupFlags flags) {
			int cnt_icon_names = icon_names == null ? 0 : icon_names.Length;
			IntPtr[] native_icon_names = new IntPtr [cnt_icon_names];
			for (int i = 0; i < cnt_icon_names; i++)
				native_icon_names [i] = GLib.Marshaller.StringToPtrGStrdup (icon_names[i]);
			IntPtr raw_ret = gtk_icon_theme_choose_icon_for_scale(Handle, native_icon_names, size, scale, (int) flags);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret) as Gtk.IconInfo;
			for (int i = 0; i < native_icon_names.Length; i++) {
				icon_names [i] = GLib.Marshaller.Utf8PtrToString (native_icon_names[i]);
				GLib.Marshaller.Free (native_icon_names[i]);
			}
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_icon_theme_error_quark();
		static d_gtk_icon_theme_error_quark gtk_icon_theme_error_quark = FuncLoader.LoadFunction<d_gtk_icon_theme_error_quark>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_error_quark"));

		public static int ErrorQuark() {
			int raw_ret = gtk_icon_theme_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_get_default();
		static d_gtk_icon_theme_get_default gtk_icon_theme_get_default = FuncLoader.LoadFunction<d_gtk_icon_theme_get_default>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_get_default"));

		public static Gtk.IconTheme Default { 
			get {
				IntPtr raw_ret = gtk_icon_theme_get_default();
				Gtk.IconTheme ret = GLib.Object.GetObject(raw_ret) as Gtk.IconTheme;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_get_example_icon_name(IntPtr raw);
		static d_gtk_icon_theme_get_example_icon_name gtk_icon_theme_get_example_icon_name = FuncLoader.LoadFunction<d_gtk_icon_theme_get_example_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_get_example_icon_name"));

		public string ExampleIconName { 
			get {
				IntPtr raw_ret = gtk_icon_theme_get_example_icon_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_get_for_screen(IntPtr screen);
		static d_gtk_icon_theme_get_for_screen gtk_icon_theme_get_for_screen = FuncLoader.LoadFunction<d_gtk_icon_theme_get_for_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_get_for_screen"));

		public static Gtk.IconTheme GetForScreen(Gdk.Screen screen) {
			IntPtr raw_ret = gtk_icon_theme_get_for_screen(screen == null ? IntPtr.Zero : screen.Handle);
			Gtk.IconTheme ret = GLib.Object.GetObject(raw_ret) as Gtk.IconTheme;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_get_type();
		static d_gtk_icon_theme_get_type gtk_icon_theme_get_type = FuncLoader.LoadFunction<d_gtk_icon_theme_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_icon_theme_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_icon_theme_has_icon(IntPtr raw, IntPtr icon_name);
		static d_gtk_icon_theme_has_icon gtk_icon_theme_has_icon = FuncLoader.LoadFunction<d_gtk_icon_theme_has_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_has_icon"));

		public bool HasIcon(string icon_name) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			bool raw_ret = gtk_icon_theme_has_icon(Handle, native_icon_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_icon_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_list_contexts(IntPtr raw);
		static d_gtk_icon_theme_list_contexts gtk_icon_theme_list_contexts = FuncLoader.LoadFunction<d_gtk_icon_theme_list_contexts>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_list_contexts"));

		public string[] ListContexts() {
			IntPtr raw_ret = gtk_icon_theme_list_contexts(Handle);
			string[] ret = GLib.Marshaller.ListPtrToArray<string, string> (raw_ret, true, true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_load_icon(IntPtr raw, IntPtr icon_name, int size, int flags, out IntPtr error);
		static d_gtk_icon_theme_load_icon gtk_icon_theme_load_icon = FuncLoader.LoadFunction<d_gtk_icon_theme_load_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_load_icon"));

		public unsafe Gdk.Pixbuf LoadIcon(string icon_name, int size, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_theme_load_icon(Handle, native_icon_name, size, (int) flags, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret, true) as Gdk.Pixbuf;
			GLib.Marshaller.Free (native_icon_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_load_icon_for_scale(IntPtr raw, IntPtr icon_name, int size, int scale, int flags, out IntPtr error);
		static d_gtk_icon_theme_load_icon_for_scale gtk_icon_theme_load_icon_for_scale = FuncLoader.LoadFunction<d_gtk_icon_theme_load_icon_for_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_load_icon_for_scale"));

		public unsafe Gdk.Pixbuf LoadIconForScale(string icon_name, int size, int scale, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_theme_load_icon_for_scale(Handle, native_icon_name, size, scale, (int) flags, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			GLib.Marshaller.Free (native_icon_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_load_surface(IntPtr raw, IntPtr icon_name, int size, int scale, IntPtr for_window, int flags, out IntPtr error);
		static d_gtk_icon_theme_load_surface gtk_icon_theme_load_surface = FuncLoader.LoadFunction<d_gtk_icon_theme_load_surface>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_load_surface"));

		public unsafe Cairo.Surface LoadSurface(string icon_name, int size, int scale, Gdk.Window for_window, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_theme_load_surface(Handle, native_icon_name, size, scale, for_window == null ? IntPtr.Zero : for_window.Handle, (int) flags, out error);
			Cairo.Surface ret = Cairo.Surface.Lookup (raw_ret, true);
			GLib.Marshaller.Free (native_icon_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_lookup_by_gicon(IntPtr raw, IntPtr icon, int size, int flags);
		static d_gtk_icon_theme_lookup_by_gicon gtk_icon_theme_lookup_by_gicon = FuncLoader.LoadFunction<d_gtk_icon_theme_lookup_by_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_lookup_by_gicon"));

		public Gtk.IconInfo LookupIcon(GLib.IIcon icon, int size, Gtk.IconLookupFlags flags) {
			IntPtr raw_ret = gtk_icon_theme_lookup_by_gicon(Handle, icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle), size, (int) flags);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret, true) as Gtk.IconInfo;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_lookup_by_gicon_for_scale(IntPtr raw, IntPtr icon, int size, int scale, int flags);
		static d_gtk_icon_theme_lookup_by_gicon_for_scale gtk_icon_theme_lookup_by_gicon_for_scale = FuncLoader.LoadFunction<d_gtk_icon_theme_lookup_by_gicon_for_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_lookup_by_gicon_for_scale"));

		public Gtk.IconInfo LookupByGiconForScale(GLib.IIcon icon, int size, int scale, Gtk.IconLookupFlags flags) {
			IntPtr raw_ret = gtk_icon_theme_lookup_by_gicon_for_scale(Handle, icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle), size, scale, (int) flags);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret) as Gtk.IconInfo;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_lookup_icon(IntPtr raw, IntPtr icon_name, int size, int flags);
		static d_gtk_icon_theme_lookup_icon gtk_icon_theme_lookup_icon = FuncLoader.LoadFunction<d_gtk_icon_theme_lookup_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_lookup_icon"));

		public Gtk.IconInfo LookupIcon(string icon_name, int size, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr raw_ret = gtk_icon_theme_lookup_icon(Handle, native_icon_name, size, (int) flags);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret, true) as Gtk.IconInfo;
			GLib.Marshaller.Free (native_icon_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_theme_lookup_icon_for_scale(IntPtr raw, IntPtr icon_name, int size, int scale, int flags);
		static d_gtk_icon_theme_lookup_icon_for_scale gtk_icon_theme_lookup_icon_for_scale = FuncLoader.LoadFunction<d_gtk_icon_theme_lookup_icon_for_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_lookup_icon_for_scale"));

		public Gtk.IconInfo LookupIconForScale(string icon_name, int size, int scale, Gtk.IconLookupFlags flags) {
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			IntPtr raw_ret = gtk_icon_theme_lookup_icon_for_scale(Handle, native_icon_name, size, scale, (int) flags);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret) as Gtk.IconInfo;
			GLib.Marshaller.Free (native_icon_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_theme_prepend_search_path(IntPtr raw, IntPtr path);
		static d_gtk_icon_theme_prepend_search_path gtk_icon_theme_prepend_search_path = FuncLoader.LoadFunction<d_gtk_icon_theme_prepend_search_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_prepend_search_path"));

		public void PrependSearchPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			gtk_icon_theme_prepend_search_path(Handle, native_path);
			GLib.Marshaller.Free (native_path);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_icon_theme_rescan_if_needed(IntPtr raw);
		static d_gtk_icon_theme_rescan_if_needed gtk_icon_theme_rescan_if_needed = FuncLoader.LoadFunction<d_gtk_icon_theme_rescan_if_needed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_rescan_if_needed"));

		public bool RescanIfNeeded() {
			bool raw_ret = gtk_icon_theme_rescan_if_needed(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_theme_set_custom_theme(IntPtr raw, IntPtr theme_name);
		static d_gtk_icon_theme_set_custom_theme gtk_icon_theme_set_custom_theme = FuncLoader.LoadFunction<d_gtk_icon_theme_set_custom_theme>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_set_custom_theme"));

		public string CustomTheme { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_icon_theme_set_custom_theme(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_theme_set_screen(IntPtr raw, IntPtr screen);
		static d_gtk_icon_theme_set_screen gtk_icon_theme_set_screen = FuncLoader.LoadFunction<d_gtk_icon_theme_set_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_theme_set_screen"));

		public Gdk.Screen Screen { 
			set {
				gtk_icon_theme_set_screen(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // priv
							, null
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
