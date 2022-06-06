// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class FileFilter : GLib.InitiallyUnowned {

		public FileFilter (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_file_filter_new();
		static d_gtk_file_filter_new gtk_file_filter_new = FuncLoader.LoadFunction<d_gtk_file_filter_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_new"));

		public FileFilter () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FileFilter)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_file_filter_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_file_filter_new_from_gvariant(IntPtr variant);
		static d_gtk_file_filter_new_from_gvariant gtk_file_filter_new_from_gvariant = FuncLoader.LoadFunction<d_gtk_file_filter_new_from_gvariant>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_new_from_gvariant"));

		public FileFilter (GLib.Variant variant) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FileFilter)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_file_filter_new_from_gvariant(variant == null ? IntPtr.Zero : variant.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_file_filter_add_custom(IntPtr raw, int needed, GtkSharp.FileFilterFuncNative func, IntPtr data, GLib.DestroyNotify notify);
		static d_gtk_file_filter_add_custom gtk_file_filter_add_custom = FuncLoader.LoadFunction<d_gtk_file_filter_add_custom>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_add_custom"));

		public void AddCustom(Gtk.FileFilterFlags needed, Gtk.FileFilterFunc func) {
			GtkSharp.FileFilterFuncWrapper func_wrapper = new GtkSharp.FileFilterFuncWrapper (func);
			IntPtr data;
			GLib.DestroyNotify notify;
			if (func == null) {
				data = IntPtr.Zero;
				notify = null;
			} else {
				data = (IntPtr) GCHandle.Alloc (func_wrapper);
				notify = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_file_filter_add_custom(Handle, (int) needed, func_wrapper.NativeDelegate, data, notify);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_file_filter_add_mime_type(IntPtr raw, IntPtr mime_type);
		static d_gtk_file_filter_add_mime_type gtk_file_filter_add_mime_type = FuncLoader.LoadFunction<d_gtk_file_filter_add_mime_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_add_mime_type"));

		public void AddMimeType(string mime_type) {
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			gtk_file_filter_add_mime_type(Handle, native_mime_type);
			GLib.Marshaller.Free (native_mime_type);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_file_filter_add_pattern(IntPtr raw, IntPtr pattern);
		static d_gtk_file_filter_add_pattern gtk_file_filter_add_pattern = FuncLoader.LoadFunction<d_gtk_file_filter_add_pattern>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_add_pattern"));

		public void AddPattern(string pattern) {
			IntPtr native_pattern = GLib.Marshaller.StringToPtrGStrdup (pattern);
			gtk_file_filter_add_pattern(Handle, native_pattern);
			GLib.Marshaller.Free (native_pattern);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_file_filter_add_pixbuf_formats(IntPtr raw);
		static d_gtk_file_filter_add_pixbuf_formats gtk_file_filter_add_pixbuf_formats = FuncLoader.LoadFunction<d_gtk_file_filter_add_pixbuf_formats>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_add_pixbuf_formats"));

		public void AddPixbufFormats() {
			gtk_file_filter_add_pixbuf_formats(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_file_filter_filter(IntPtr raw, IntPtr filter_info);
		static d_gtk_file_filter_filter gtk_file_filter_filter = FuncLoader.LoadFunction<d_gtk_file_filter_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_filter"));

		public bool Filter(Gtk.FileFilterInfo filter_info) {
			IntPtr native_filter_info = GLib.Marshaller.StructureToPtrAlloc (filter_info);
			bool raw_ret = gtk_file_filter_filter(Handle, native_filter_info);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_filter_info);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_file_filter_get_name(IntPtr raw);
		static d_gtk_file_filter_get_name gtk_file_filter_get_name = FuncLoader.LoadFunction<d_gtk_file_filter_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_get_name"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_file_filter_set_name(IntPtr raw, IntPtr name);
		static d_gtk_file_filter_set_name gtk_file_filter_set_name = FuncLoader.LoadFunction<d_gtk_file_filter_set_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_set_name"));

		public string Name { 
			get {
				IntPtr raw_ret = gtk_file_filter_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_file_filter_set_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_file_filter_get_needed(IntPtr raw);
		static d_gtk_file_filter_get_needed gtk_file_filter_get_needed = FuncLoader.LoadFunction<d_gtk_file_filter_get_needed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_get_needed"));

		public Gtk.FileFilterFlags Needed { 
			get {
				int raw_ret = gtk_file_filter_get_needed(Handle);
				Gtk.FileFilterFlags ret = (Gtk.FileFilterFlags) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_file_filter_get_type();
		static d_gtk_file_filter_get_type gtk_file_filter_get_type = FuncLoader.LoadFunction<d_gtk_file_filter_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_file_filter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_file_filter_to_gvariant(IntPtr raw);
		static d_gtk_file_filter_to_gvariant gtk_file_filter_to_gvariant = FuncLoader.LoadFunction<d_gtk_file_filter_to_gvariant>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_file_filter_to_gvariant"));

		public GLib.Variant ToGvariant() {
			IntPtr raw_ret = gtk_file_filter_to_gvariant(Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}