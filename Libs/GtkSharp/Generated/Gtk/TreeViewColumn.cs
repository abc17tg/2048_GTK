// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class TreeViewColumn : GLib.InitiallyUnowned, Gtk.ICellLayout {

		public TreeViewColumn (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_new();
		static d_gtk_tree_view_column_new gtk_tree_view_column_new = FuncLoader.LoadFunction<d_gtk_tree_view_column_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_new"));

		public TreeViewColumn () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TreeViewColumn)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_tree_view_column_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_new_with_area(IntPtr area);
		static d_gtk_tree_view_column_new_with_area gtk_tree_view_column_new_with_area = FuncLoader.LoadFunction<d_gtk_tree_view_column_new_with_area>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_new_with_area"));

		public TreeViewColumn (Gtk.CellArea area) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TreeViewColumn)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_tree_view_column_new_with_area(area == null ? IntPtr.Zero : area.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_get_visible(IntPtr raw);
		static d_gtk_tree_view_column_get_visible gtk_tree_view_column_get_visible = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_visible"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_visible(IntPtr raw, bool visible);
		static d_gtk_tree_view_column_set_visible gtk_tree_view_column_set_visible = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_visible"));

		[GLib.Property ("visible")]
		public bool Visible {
			get  {
				bool raw_ret = gtk_tree_view_column_get_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_visible(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_get_resizable(IntPtr raw);
		static d_gtk_tree_view_column_get_resizable gtk_tree_view_column_get_resizable = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_resizable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_resizable"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_resizable(IntPtr raw, bool resizable);
		static d_gtk_tree_view_column_set_resizable gtk_tree_view_column_set_resizable = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_resizable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_resizable"));

		[GLib.Property ("resizable")]
		public bool Resizable {
			get  {
				bool raw_ret = gtk_tree_view_column_get_resizable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_resizable(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_x_offset(IntPtr raw);
		static d_gtk_tree_view_column_get_x_offset gtk_tree_view_column_get_x_offset = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_x_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_x_offset"));

		[GLib.Property ("x-offset")]
		public int XOffset {
			get  {
				int raw_ret = gtk_tree_view_column_get_x_offset(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_width(IntPtr raw);
		static d_gtk_tree_view_column_get_width gtk_tree_view_column_get_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_width"));

		[GLib.Property ("width")]
		public int Width {
			get  {
				int raw_ret = gtk_tree_view_column_get_width(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_spacing(IntPtr raw);
		static d_gtk_tree_view_column_get_spacing gtk_tree_view_column_get_spacing = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_spacing>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_spacing"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_spacing(IntPtr raw, int spacing);
		static d_gtk_tree_view_column_set_spacing gtk_tree_view_column_set_spacing = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_spacing>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_spacing"));

		[GLib.Property ("spacing")]
		public int Spacing {
			get  {
				int raw_ret = gtk_tree_view_column_get_spacing(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_spacing(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_sizing(IntPtr raw);
		static d_gtk_tree_view_column_get_sizing gtk_tree_view_column_get_sizing = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_sizing>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_sizing"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_sizing(IntPtr raw, int type);
		static d_gtk_tree_view_column_set_sizing gtk_tree_view_column_set_sizing = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_sizing>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_sizing"));

		[GLib.Property ("sizing")]
		public Gtk.TreeViewColumnSizing Sizing {
			get  {
				int raw_ret = gtk_tree_view_column_get_sizing(Handle);
				Gtk.TreeViewColumnSizing ret = (Gtk.TreeViewColumnSizing) raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_sizing(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_fixed_width(IntPtr raw);
		static d_gtk_tree_view_column_get_fixed_width gtk_tree_view_column_get_fixed_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_fixed_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_fixed_width"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_fixed_width(IntPtr raw, int fixed_width);
		static d_gtk_tree_view_column_set_fixed_width gtk_tree_view_column_set_fixed_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_fixed_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_fixed_width"));

		[GLib.Property ("fixed-width")]
		public int FixedWidth {
			get  {
				int raw_ret = gtk_tree_view_column_get_fixed_width(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_fixed_width(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_min_width(IntPtr raw);
		static d_gtk_tree_view_column_get_min_width gtk_tree_view_column_get_min_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_min_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_min_width"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_min_width(IntPtr raw, int min_width);
		static d_gtk_tree_view_column_set_min_width gtk_tree_view_column_set_min_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_min_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_min_width"));

		[GLib.Property ("min-width")]
		public int MinWidth {
			get  {
				int raw_ret = gtk_tree_view_column_get_min_width(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_min_width(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_max_width(IntPtr raw);
		static d_gtk_tree_view_column_get_max_width gtk_tree_view_column_get_max_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_max_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_max_width"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_max_width(IntPtr raw, int max_width);
		static d_gtk_tree_view_column_set_max_width gtk_tree_view_column_set_max_width = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_max_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_max_width"));

		[GLib.Property ("max-width")]
		public int MaxWidth {
			get  {
				int raw_ret = gtk_tree_view_column_get_max_width(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_max_width(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_get_title(IntPtr raw);
		static d_gtk_tree_view_column_get_title gtk_tree_view_column_get_title = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_title"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_title(IntPtr raw, IntPtr title);
		static d_gtk_tree_view_column_set_title gtk_tree_view_column_set_title = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_title"));

		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_tree_view_column_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_tree_view_column_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_get_expand(IntPtr raw);
		static d_gtk_tree_view_column_get_expand gtk_tree_view_column_get_expand = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_expand>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_expand"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_expand(IntPtr raw, bool expand);
		static d_gtk_tree_view_column_set_expand gtk_tree_view_column_set_expand = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_expand>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_expand"));

		[GLib.Property ("expand")]
		public bool Expand {
			get  {
				bool raw_ret = gtk_tree_view_column_get_expand(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_expand(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_get_clickable(IntPtr raw);
		static d_gtk_tree_view_column_get_clickable gtk_tree_view_column_get_clickable = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_clickable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_clickable"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_clickable(IntPtr raw, bool clickable);
		static d_gtk_tree_view_column_set_clickable gtk_tree_view_column_set_clickable = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_clickable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_clickable"));

		[GLib.Property ("clickable")]
		public bool Clickable {
			get  {
				bool raw_ret = gtk_tree_view_column_get_clickable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_clickable(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_get_widget(IntPtr raw);
		static d_gtk_tree_view_column_get_widget gtk_tree_view_column_get_widget = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_widget"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_widget(IntPtr raw, IntPtr widget);
		static d_gtk_tree_view_column_set_widget gtk_tree_view_column_set_widget = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_widget"));

		[GLib.Property ("widget")]
		public Gtk.Widget Widget {
			get  {
				IntPtr raw_ret = gtk_tree_view_column_get_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate float d_gtk_tree_view_column_get_alignment(IntPtr raw);
		static d_gtk_tree_view_column_get_alignment gtk_tree_view_column_get_alignment = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_alignment>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_alignment"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_alignment(IntPtr raw, float xalign);
		static d_gtk_tree_view_column_set_alignment gtk_tree_view_column_set_alignment = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_alignment>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_alignment"));

		[GLib.Property ("alignment")]
		public float Alignment {
			get  {
				float raw_ret = gtk_tree_view_column_get_alignment(Handle);
				float ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_alignment(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_get_reorderable(IntPtr raw);
		static d_gtk_tree_view_column_get_reorderable gtk_tree_view_column_get_reorderable = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_reorderable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_reorderable"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_reorderable(IntPtr raw, bool reorderable);
		static d_gtk_tree_view_column_set_reorderable gtk_tree_view_column_set_reorderable = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_reorderable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_reorderable"));

		[GLib.Property ("reorderable")]
		public bool Reorderable {
			get  {
				bool raw_ret = gtk_tree_view_column_get_reorderable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_reorderable(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_get_sort_indicator(IntPtr raw);
		static d_gtk_tree_view_column_get_sort_indicator gtk_tree_view_column_get_sort_indicator = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_sort_indicator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_sort_indicator"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_sort_indicator(IntPtr raw, bool setting);
		static d_gtk_tree_view_column_set_sort_indicator gtk_tree_view_column_set_sort_indicator = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_sort_indicator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_sort_indicator"));

		[GLib.Property ("sort-indicator")]
		public bool SortIndicator {
			get  {
				bool raw_ret = gtk_tree_view_column_get_sort_indicator(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_sort_indicator(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_sort_order(IntPtr raw);
		static d_gtk_tree_view_column_get_sort_order gtk_tree_view_column_get_sort_order = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_sort_order>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_sort_order"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_sort_order(IntPtr raw, int order);
		static d_gtk_tree_view_column_set_sort_order gtk_tree_view_column_set_sort_order = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_sort_order>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_sort_order"));

		[GLib.Property ("sort-order")]
		public Gtk.SortType SortOrder {
			get  {
				int raw_ret = gtk_tree_view_column_get_sort_order(Handle);
				Gtk.SortType ret = (Gtk.SortType) raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_sort_order(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_tree_view_column_get_sort_column_id(IntPtr raw);
		static d_gtk_tree_view_column_get_sort_column_id gtk_tree_view_column_get_sort_column_id = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_sort_column_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_sort_column_id"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_sort_column_id(IntPtr raw, int sort_column_id);
		static d_gtk_tree_view_column_set_sort_column_id gtk_tree_view_column_set_sort_column_id = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_sort_column_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_sort_column_id"));

		[GLib.Property ("sort-column-id")]
		public int SortColumnId {
			get  {
				int raw_ret = gtk_tree_view_column_get_sort_column_id(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tree_view_column_set_sort_column_id(Handle, value);
			}
		}

		[GLib.Property ("cell-area")]
		public Gtk.CellArea CellArea {
			get {
				GLib.Value val = GetProperty ("cell-area");
				Gtk.CellArea ret = (Gtk.CellArea) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("clicked")]
		public event System.EventHandler Clicked {
			add {
				this.AddSignalHandler ("clicked", value);
			}
			remove {
				this.RemoveSignalHandler ("clicked", value);
			}
		}

		static ClickedNativeDelegate Clicked_cb_delegate;
		static ClickedNativeDelegate ClickedVMCallback {
			get {
				if (Clicked_cb_delegate == null)
					Clicked_cb_delegate = new ClickedNativeDelegate (Clicked_cb);
				return Clicked_cb_delegate;
			}
		}

		static void OverrideClicked (GLib.GType gtype)
		{
			OverrideClicked (gtype, ClickedVMCallback);
		}

		static void OverrideClicked (GLib.GType gtype, ClickedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("clicked"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ClickedNativeDelegate (IntPtr inst);

		static void Clicked_cb (IntPtr inst)
		{
			try {
				TreeViewColumn __obj = GLib.Object.GetObject (inst, false) as TreeViewColumn;
				__obj.OnClicked ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TreeViewColumn), ConnectionMethod="OverrideClicked")]
		protected virtual void OnClicked ()
		{
			InternalClicked ();
		}

		private void InternalClicked ()
		{
			ClickedNativeDelegate unmanaged = class_abi.BaseOverride<ClickedNativeDelegate>(this.LookupGType(), "clicked");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("clicked"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // clicked
							, null
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "clicked"
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
		delegate bool d_gtk_tree_view_column_cell_get_position(IntPtr raw, IntPtr cell_renderer, out int x_offset, out int width);
		static d_gtk_tree_view_column_cell_get_position gtk_tree_view_column_cell_get_position = FuncLoader.LoadFunction<d_gtk_tree_view_column_cell_get_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_cell_get_position"));

		public bool CellGetPosition(Gtk.CellRenderer cell_renderer, out int x_offset, out int width) {
			bool raw_ret = gtk_tree_view_column_cell_get_position(Handle, cell_renderer == null ? IntPtr.Zero : cell_renderer.Handle, out x_offset, out width);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_cell_get_size(IntPtr raw, IntPtr cell_area, out int x_offset, out int y_offset, out int width, out int height);
		static d_gtk_tree_view_column_cell_get_size gtk_tree_view_column_cell_get_size = FuncLoader.LoadFunction<d_gtk_tree_view_column_cell_get_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_cell_get_size"));

		public void CellGetSize(Gdk.Rectangle cell_area, out int x_offset, out int y_offset, out int width, out int height) {
			IntPtr native_cell_area = GLib.Marshaller.StructureToPtrAlloc (cell_area);
			gtk_tree_view_column_cell_get_size(Handle, native_cell_area, out x_offset, out y_offset, out width, out height);
			Marshal.FreeHGlobal (native_cell_area);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_view_column_cell_is_visible(IntPtr raw);
		static d_gtk_tree_view_column_cell_is_visible gtk_tree_view_column_cell_is_visible = FuncLoader.LoadFunction<d_gtk_tree_view_column_cell_is_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_cell_is_visible"));

		public bool CellIsVisible() {
			bool raw_ret = gtk_tree_view_column_cell_is_visible(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_cell_set_cell_data(IntPtr raw, IntPtr tree_model, IntPtr iter, bool is_expander, bool is_expanded);
		static d_gtk_tree_view_column_cell_set_cell_data gtk_tree_view_column_cell_set_cell_data = FuncLoader.LoadFunction<d_gtk_tree_view_column_cell_set_cell_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_cell_set_cell_data"));

		public void CellSetCellData(Gtk.ITreeModel tree_model, Gtk.TreeIter iter, bool is_expander, bool is_expanded) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_view_column_cell_set_cell_data(Handle, tree_model == null ? IntPtr.Zero : ((tree_model is GLib.Object) ? (tree_model as GLib.Object).Handle : (tree_model as Gtk.TreeModelAdapter).Handle), native_iter, is_expander, is_expanded);
			Marshal.FreeHGlobal (native_iter);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_clicked(IntPtr raw);
		static d_gtk_tree_view_column_clicked gtk_tree_view_column_clicked = FuncLoader.LoadFunction<d_gtk_tree_view_column_clicked>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_clicked"));

		public void Click() {
			gtk_tree_view_column_clicked(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_focus_cell(IntPtr raw, IntPtr cell);
		static d_gtk_tree_view_column_focus_cell gtk_tree_view_column_focus_cell = FuncLoader.LoadFunction<d_gtk_tree_view_column_focus_cell>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_focus_cell"));

		public void FocusCell(Gtk.CellRenderer cell) {
			gtk_tree_view_column_focus_cell(Handle, cell == null ? IntPtr.Zero : cell.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_get_button(IntPtr raw);
		static d_gtk_tree_view_column_get_button gtk_tree_view_column_get_button = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_button"));

		public Gtk.Widget Button { 
			get {
				IntPtr raw_ret = gtk_tree_view_column_get_button(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_get_tree_view(IntPtr raw);
		static d_gtk_tree_view_column_get_tree_view gtk_tree_view_column_get_tree_view = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_tree_view>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_tree_view"));

		public Gtk.Widget TreeView { 
			get {
				IntPtr raw_ret = gtk_tree_view_column_get_tree_view(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_view_column_get_type();
		static d_gtk_tree_view_column_get_type gtk_tree_view_column_get_type = FuncLoader.LoadFunction<d_gtk_tree_view_column_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tree_view_column_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_queue_resize(IntPtr raw);
		static d_gtk_tree_view_column_queue_resize gtk_tree_view_column_queue_resize = FuncLoader.LoadFunction<d_gtk_tree_view_column_queue_resize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_queue_resize"));

		public void QueueResize() {
			gtk_tree_view_column_queue_resize(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_view_column_set_cell_data_func(IntPtr raw, IntPtr cell_renderer, GtkSharp.TreeCellDataFuncNative func, IntPtr func_data, GLib.DestroyNotify destroy);
		static d_gtk_tree_view_column_set_cell_data_func gtk_tree_view_column_set_cell_data_func = FuncLoader.LoadFunction<d_gtk_tree_view_column_set_cell_data_func>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_view_column_set_cell_data_func"));

		public void SetCellDataFunc(Gtk.CellRenderer cell_renderer, Gtk.TreeCellDataFunc func) {
			GtkSharp.TreeCellDataFuncWrapper func_wrapper = new GtkSharp.TreeCellDataFuncWrapper (func);
			IntPtr func_data;
			GLib.DestroyNotify destroy;
			if (func == null) {
				func_data = IntPtr.Zero;
				destroy = null;
			} else {
				func_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_tree_view_column_set_cell_data_func(Handle, cell_renderer == null ? IntPtr.Zero : cell_renderer.Handle, func_wrapper.NativeDelegate, func_data, destroy);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_add_attribute(IntPtr raw, IntPtr cell, IntPtr attribute, int column);
		static d_gtk_cell_layout_add_attribute gtk_cell_layout_add_attribute = FuncLoader.LoadFunction<d_gtk_cell_layout_add_attribute>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_add_attribute"));

		public void AddAttribute(Gtk.CellRenderer cell, string attribute, int column) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			gtk_cell_layout_add_attribute(Handle, cell == null ? IntPtr.Zero : cell.Handle, native_attribute, column);
			GLib.Marshaller.Free (native_attribute);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_clear(IntPtr raw);
		static d_gtk_cell_layout_clear gtk_cell_layout_clear = FuncLoader.LoadFunction<d_gtk_cell_layout_clear>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_clear"));

		public void Clear() {
			gtk_cell_layout_clear(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_clear_attributes(IntPtr raw, IntPtr cell);
		static d_gtk_cell_layout_clear_attributes gtk_cell_layout_clear_attributes = FuncLoader.LoadFunction<d_gtk_cell_layout_clear_attributes>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_clear_attributes"));

		public void ClearAttributes(Gtk.CellRenderer cell) {
			gtk_cell_layout_clear_attributes(Handle, cell == null ? IntPtr.Zero : cell.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_cell_layout_get_area(IntPtr raw);
		static d_gtk_cell_layout_get_area gtk_cell_layout_get_area = FuncLoader.LoadFunction<d_gtk_cell_layout_get_area>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_get_area"));

		public Gtk.CellArea Area { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_area(Handle);
				Gtk.CellArea ret = GLib.Object.GetObject(raw_ret) as Gtk.CellArea;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_cell_layout_get_cells(IntPtr raw);
		static d_gtk_cell_layout_get_cells gtk_cell_layout_get_cells = FuncLoader.LoadFunction<d_gtk_cell_layout_get_cells>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_get_cells"));

		public Gtk.CellRenderer[] Cells { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_cells(Handle);
				Gtk.CellRenderer[] ret = GLib.Marshaller.ListPtrToArray<Gtk.CellRenderer, Gtk.CellRenderer> (raw_ret, true, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_pack_end(IntPtr raw, IntPtr cell, bool expand);
		static d_gtk_cell_layout_pack_end gtk_cell_layout_pack_end = FuncLoader.LoadFunction<d_gtk_cell_layout_pack_end>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_pack_end"));

		public void PackEnd(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_end(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_pack_start(IntPtr raw, IntPtr cell, bool expand);
		static d_gtk_cell_layout_pack_start gtk_cell_layout_pack_start = FuncLoader.LoadFunction<d_gtk_cell_layout_pack_start>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_pack_start"));

		public void PackStart(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_start(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_reorder(IntPtr raw, IntPtr cell, int position);
		static d_gtk_cell_layout_reorder gtk_cell_layout_reorder = FuncLoader.LoadFunction<d_gtk_cell_layout_reorder>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_reorder"));

		public void Reorder(Gtk.CellRenderer cell, int position) {
			gtk_cell_layout_reorder(Handle, cell == null ? IntPtr.Zero : cell.Handle, position);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_layout_set_cell_data_func(IntPtr raw, IntPtr cell, GtkSharp.CellLayoutDataFuncNative func, IntPtr func_data, GLib.DestroyNotify destroy);
		static d_gtk_cell_layout_set_cell_data_func gtk_cell_layout_set_cell_data_func = FuncLoader.LoadFunction<d_gtk_cell_layout_set_cell_data_func>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_layout_set_cell_data_func"));

		public void SetCellDataFunc(Gtk.CellRenderer cell, Gtk.CellLayoutDataFunc func) {
			GtkSharp.CellLayoutDataFuncWrapper func_wrapper = new GtkSharp.CellLayoutDataFuncWrapper (func);
			IntPtr func_data;
			GLib.DestroyNotify destroy;
			if (func == null) {
				func_data = IntPtr.Zero;
				destroy = null;
			} else {
				func_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_cell_layout_set_cell_data_func(Handle, cell == null ? IntPtr.Zero : cell.Handle, func_wrapper.NativeDelegate, func_data, destroy);
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
