// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class IconInfo : GLib.Object {

		public IconInfo (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_new_for_pixbuf(IntPtr icon_theme, IntPtr pixbuf);
		static d_gtk_icon_info_new_for_pixbuf gtk_icon_info_new_for_pixbuf = FuncLoader.LoadFunction<d_gtk_icon_info_new_for_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_new_for_pixbuf"));

		public IconInfo (Gtk.IconTheme icon_theme, Gdk.Pixbuf pixbuf) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IconInfo)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_icon_info_new_for_pixbuf(icon_theme == null ? IntPtr.Zero : icon_theme.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
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
		delegate IntPtr d_gtk_icon_info_copy(IntPtr raw);
		static d_gtk_icon_info_copy gtk_icon_info_copy = FuncLoader.LoadFunction<d_gtk_icon_info_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_copy"));

		[Obsolete]
		public Gtk.IconInfo Copy() {
			IntPtr raw_ret = gtk_icon_info_copy(Handle);
			Gtk.IconInfo ret = GLib.Object.GetObject(raw_ret, true) as Gtk.IconInfo;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_info_free(IntPtr raw);
		static d_gtk_icon_info_free gtk_icon_info_free = FuncLoader.LoadFunction<d_gtk_icon_info_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_free"));

		[Obsolete]
		public void Free() {
			gtk_icon_info_free(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_icon_info_get_attach_points(IntPtr raw, IntPtr points, out int n_points);
		static d_gtk_icon_info_get_attach_points gtk_icon_info_get_attach_points = FuncLoader.LoadFunction<d_gtk_icon_info_get_attach_points>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_attach_points"));

		[Obsolete]
		public bool GetAttachPoints(Gdk.Point points, out int n_points) {
			IntPtr native_points = GLib.Marshaller.StructureToPtrAlloc (points);
			bool raw_ret = gtk_icon_info_get_attach_points(Handle, native_points, out n_points);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_points);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_icon_info_get_base_scale(IntPtr raw);
		static d_gtk_icon_info_get_base_scale gtk_icon_info_get_base_scale = FuncLoader.LoadFunction<d_gtk_icon_info_get_base_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_base_scale"));

		public int BaseScale { 
			get {
				int raw_ret = gtk_icon_info_get_base_scale(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_icon_info_get_base_size(IntPtr raw);
		static d_gtk_icon_info_get_base_size gtk_icon_info_get_base_size = FuncLoader.LoadFunction<d_gtk_icon_info_get_base_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_base_size"));

		public int BaseSize { 
			get {
				int raw_ret = gtk_icon_info_get_base_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_get_builtin_pixbuf(IntPtr raw);
		static d_gtk_icon_info_get_builtin_pixbuf gtk_icon_info_get_builtin_pixbuf = FuncLoader.LoadFunction<d_gtk_icon_info_get_builtin_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_builtin_pixbuf"));

		[Obsolete]
		public Gdk.Pixbuf BuiltinPixbuf { 
			get {
				IntPtr raw_ret = gtk_icon_info_get_builtin_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_get_display_name(IntPtr raw);
		static d_gtk_icon_info_get_display_name gtk_icon_info_get_display_name = FuncLoader.LoadFunction<d_gtk_icon_info_get_display_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_display_name"));

		[Obsolete]
		public string DisplayName { 
			get {
				IntPtr raw_ret = gtk_icon_info_get_display_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_icon_info_get_embedded_rect(IntPtr raw, IntPtr rectangle);
		static d_gtk_icon_info_get_embedded_rect gtk_icon_info_get_embedded_rect = FuncLoader.LoadFunction<d_gtk_icon_info_get_embedded_rect>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_embedded_rect"));

		[Obsolete]
		public bool GetEmbeddedRect(Gdk.Rectangle rectangle) {
			IntPtr native_rectangle = GLib.Marshaller.StructureToPtrAlloc (rectangle);
			bool raw_ret = gtk_icon_info_get_embedded_rect(Handle, native_rectangle);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_rectangle);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_get_filename(IntPtr raw);
		static d_gtk_icon_info_get_filename gtk_icon_info_get_filename = FuncLoader.LoadFunction<d_gtk_icon_info_get_filename>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_filename"));

		public string Filename { 
			get {
				IntPtr raw_ret = gtk_icon_info_get_filename(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_get_type();
		static d_gtk_icon_info_get_type gtk_icon_info_get_type = FuncLoader.LoadFunction<d_gtk_icon_info_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_icon_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_icon_info_is_symbolic(IntPtr raw);
		static d_gtk_icon_info_is_symbolic gtk_icon_info_is_symbolic = FuncLoader.LoadFunction<d_gtk_icon_info_is_symbolic>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_is_symbolic"));

		public bool IsSymbolic { 
			get {
				bool raw_ret = gtk_icon_info_is_symbolic(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_icon(IntPtr raw, out IntPtr error);
		static d_gtk_icon_info_load_icon gtk_icon_info_load_icon = FuncLoader.LoadFunction<d_gtk_icon_info_load_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_icon"));

		public unsafe Gdk.Pixbuf LoadIcon() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_icon(Handle, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_info_load_icon_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_gtk_icon_info_load_icon_async gtk_icon_info_load_icon_async = FuncLoader.LoadFunction<d_gtk_icon_info_load_icon_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_icon_async"));

		public void LoadIconAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			gtk_icon_info_load_icon_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_icon_finish(IntPtr raw, IntPtr res, out IntPtr error);
		static d_gtk_icon_info_load_icon_finish gtk_icon_info_load_icon_finish = FuncLoader.LoadFunction<d_gtk_icon_info_load_icon_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_icon_finish"));

		public unsafe Gdk.Pixbuf LoadIconFinish(GLib.IAsyncResult res) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_icon_finish(Handle, res == null ? IntPtr.Zero : ((res is GLib.Object) ? (res as GLib.Object).Handle : (res as GLib.AsyncResultAdapter).Handle), out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_surface(IntPtr raw, IntPtr for_window, out IntPtr error);
		static d_gtk_icon_info_load_surface gtk_icon_info_load_surface = FuncLoader.LoadFunction<d_gtk_icon_info_load_surface>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_surface"));

		public unsafe Cairo.Surface LoadSurface(Gdk.Window for_window) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_surface(Handle, for_window == null ? IntPtr.Zero : for_window.Handle, out error);
			Cairo.Surface ret = Cairo.Surface.Lookup (raw_ret, true);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_symbolic(IntPtr raw, IntPtr fg, IntPtr success_color, IntPtr warning_color, IntPtr error_color, out bool was_symbolic, out IntPtr error);
		static d_gtk_icon_info_load_symbolic gtk_icon_info_load_symbolic = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic"));

		public unsafe Gdk.Pixbuf LoadSymbolic(Gdk.RGBA fg, Gdk.RGBA success_color, Gdk.RGBA warning_color, Gdk.RGBA error_color, out bool was_symbolic) {
			IntPtr native_fg = GLib.Marshaller.StructureToPtrAlloc (fg);
			IntPtr native_success_color = GLib.Marshaller.StructureToPtrAlloc (success_color);
			IntPtr native_warning_color = GLib.Marshaller.StructureToPtrAlloc (warning_color);
			IntPtr native_error_color = GLib.Marshaller.StructureToPtrAlloc (error_color);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_symbolic(Handle, native_fg, native_success_color, native_warning_color, native_error_color, out was_symbolic, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			Marshal.FreeHGlobal (native_fg);
			Marshal.FreeHGlobal (native_success_color);
			Marshal.FreeHGlobal (native_warning_color);
			Marshal.FreeHGlobal (native_error_color);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_info_load_symbolic_async(IntPtr raw, IntPtr fg, IntPtr success_color, IntPtr warning_color, IntPtr error_color, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_gtk_icon_info_load_symbolic_async gtk_icon_info_load_symbolic_async = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic_async"));

		public void LoadSymbolicAsync(Gdk.RGBA fg, Gdk.RGBA success_color, Gdk.RGBA warning_color, Gdk.RGBA error_color, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_fg = GLib.Marshaller.StructureToPtrAlloc (fg);
			IntPtr native_success_color = GLib.Marshaller.StructureToPtrAlloc (success_color);
			IntPtr native_warning_color = GLib.Marshaller.StructureToPtrAlloc (warning_color);
			IntPtr native_error_color = GLib.Marshaller.StructureToPtrAlloc (error_color);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			gtk_icon_info_load_symbolic_async(Handle, native_fg, native_success_color, native_warning_color, native_error_color, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			Marshal.FreeHGlobal (native_fg);
			Marshal.FreeHGlobal (native_success_color);
			Marshal.FreeHGlobal (native_warning_color);
			Marshal.FreeHGlobal (native_error_color);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_symbolic_finish(IntPtr raw, IntPtr res, out bool was_symbolic, out IntPtr error);
		static d_gtk_icon_info_load_symbolic_finish gtk_icon_info_load_symbolic_finish = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic_finish"));

		public unsafe Gdk.Pixbuf LoadSymbolicFinish(GLib.IAsyncResult res, out bool was_symbolic) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_symbolic_finish(Handle, res == null ? IntPtr.Zero : ((res is GLib.Object) ? (res as GLib.Object).Handle : (res as GLib.AsyncResultAdapter).Handle), out was_symbolic, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_symbolic_for_context(IntPtr raw, IntPtr context, out bool was_symbolic, out IntPtr error);
		static d_gtk_icon_info_load_symbolic_for_context gtk_icon_info_load_symbolic_for_context = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic_for_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic_for_context"));

		public unsafe Gdk.Pixbuf LoadSymbolicForContext(Gtk.StyleContext context, out bool was_symbolic) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_symbolic_for_context(Handle, context == null ? IntPtr.Zero : context.Handle, out was_symbolic, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_info_load_symbolic_for_context_async(IntPtr raw, IntPtr context, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_gtk_icon_info_load_symbolic_for_context_async gtk_icon_info_load_symbolic_for_context_async = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic_for_context_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic_for_context_async"));

		public void LoadSymbolicForContextAsync(Gtk.StyleContext context, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			gtk_icon_info_load_symbolic_for_context_async(Handle, context == null ? IntPtr.Zero : context.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_symbolic_for_context_finish(IntPtr raw, IntPtr res, out bool was_symbolic, out IntPtr error);
		static d_gtk_icon_info_load_symbolic_for_context_finish gtk_icon_info_load_symbolic_for_context_finish = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic_for_context_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic_for_context_finish"));

		public unsafe Gdk.Pixbuf LoadSymbolicForContextFinish(GLib.IAsyncResult res, out bool was_symbolic) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_symbolic_for_context_finish(Handle, res == null ? IntPtr.Zero : ((res is GLib.Object) ? (res as GLib.Object).Handle : (res as GLib.AsyncResultAdapter).Handle), out was_symbolic, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_icon_info_load_symbolic_for_style(IntPtr raw, IntPtr style, int state, out bool was_symbolic, out IntPtr error);
		static d_gtk_icon_info_load_symbolic_for_style gtk_icon_info_load_symbolic_for_style = FuncLoader.LoadFunction<d_gtk_icon_info_load_symbolic_for_style>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_load_symbolic_for_style"));

		[Obsolete]
		public unsafe Gdk.Pixbuf LoadSymbolicForStyle(Gtk.Style style, Gtk.StateType state, out bool was_symbolic) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_symbolic_for_style(Handle, style == null ? IntPtr.Zero : style.Handle, (int) state, out was_symbolic, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_info_set_raw_coordinates(IntPtr raw, bool raw_coordinates);
		static d_gtk_icon_info_set_raw_coordinates gtk_icon_info_set_raw_coordinates = FuncLoader.LoadFunction<d_gtk_icon_info_set_raw_coordinates>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_info_set_raw_coordinates"));

		[Obsolete]
		public bool RawCoordinates { 
			set {
				gtk_icon_info_set_raw_coordinates(Handle, value);
			}
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
