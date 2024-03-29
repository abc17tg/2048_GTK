// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Gutter : GLib.Object {

		public Gutter (IntPtr raw) : base(raw) {}

		protected Gutter() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_gutter_get_view(IntPtr raw);
		static d_gtk_source_gutter_get_view gtk_source_gutter_get_view = FuncLoader.LoadFunction<d_gtk_source_gutter_get_view>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_get_view"));

		[GLib.Property ("view")]
		public GtkSource.SourceView View {
			get  {
				IntPtr raw_ret = gtk_source_gutter_get_view(Handle);
				GtkSource.SourceView ret = GLib.Object.GetObject(raw_ret) as GtkSource.SourceView;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_source_gutter_get_window_type(IntPtr raw);
		static d_gtk_source_gutter_get_window_type gtk_source_gutter_get_window_type = FuncLoader.LoadFunction<d_gtk_source_gutter_get_window_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_get_window_type"));

		[GLib.Property ("window_type")]
		public Gtk.TextWindowType WindowType {
			get  {
				int raw_ret = gtk_source_gutter_get_window_type(Handle);
				Gtk.TextWindowType ret = (Gtk.TextWindowType) raw_ret;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("padding"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) * 10 // padding
							, null
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
		delegate IntPtr d_gtk_source_gutter_get_renderer_at_pos(IntPtr raw, int x, int y);
		static d_gtk_source_gutter_get_renderer_at_pos gtk_source_gutter_get_renderer_at_pos = FuncLoader.LoadFunction<d_gtk_source_gutter_get_renderer_at_pos>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_get_renderer_at_pos"));

		public GtkSource.GutterRenderer GetRendererAtPos(int x, int y) {
			IntPtr raw_ret = gtk_source_gutter_get_renderer_at_pos(Handle, x, y);
			GtkSource.GutterRenderer ret = GLib.Object.GetObject(raw_ret) as GtkSource.GutterRenderer;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_gutter_get_type();
		static d_gtk_source_gutter_get_type gtk_source_gutter_get_type = FuncLoader.LoadFunction<d_gtk_source_gutter_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_gutter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_gutter_insert(IntPtr raw, IntPtr renderer, int position);
		static d_gtk_source_gutter_insert gtk_source_gutter_insert = FuncLoader.LoadFunction<d_gtk_source_gutter_insert>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_insert"));

		public bool Insert(GtkSource.GutterRenderer renderer, int position) {
			bool raw_ret = gtk_source_gutter_insert(Handle, renderer == null ? IntPtr.Zero : renderer.Handle, position);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_gutter_queue_draw(IntPtr raw);
		static d_gtk_source_gutter_queue_draw gtk_source_gutter_queue_draw = FuncLoader.LoadFunction<d_gtk_source_gutter_queue_draw>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_queue_draw"));

		public void QueueDraw() {
			gtk_source_gutter_queue_draw(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_gutter_remove(IntPtr raw, IntPtr renderer);
		static d_gtk_source_gutter_remove gtk_source_gutter_remove = FuncLoader.LoadFunction<d_gtk_source_gutter_remove>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_remove"));

		public void Remove(GtkSource.GutterRenderer renderer) {
			gtk_source_gutter_remove(Handle, renderer == null ? IntPtr.Zero : renderer.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_gutter_reorder(IntPtr raw, IntPtr renderer, int position);
		static d_gtk_source_gutter_reorder gtk_source_gutter_reorder = FuncLoader.LoadFunction<d_gtk_source_gutter_reorder>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_reorder"));

		public void Reorder(GtkSource.GutterRenderer renderer, int position) {
			gtk_source_gutter_reorder(Handle, renderer == null ? IntPtr.Zero : renderer.Handle, position);
		}


		static Gutter ()
		{
			GtkSharp.GtkSourceSharp.ObjectManager.Initialize ();
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
