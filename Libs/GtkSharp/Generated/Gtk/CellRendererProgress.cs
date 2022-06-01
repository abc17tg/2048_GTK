// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class CellRendererProgress : Gtk.CellRenderer, Gtk.IOrientable {

		public CellRendererProgress (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_cell_renderer_progress_new();
		static d_gtk_cell_renderer_progress_new gtk_cell_renderer_progress_new = FuncLoader.LoadFunction<d_gtk_cell_renderer_progress_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_renderer_progress_new"));

		public CellRendererProgress () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellRendererProgress)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_cell_renderer_progress_new();
		}

		[GLib.Property ("value")]
		public int Value {
			get {
				GLib.Value val = GetProperty ("value");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("value", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text")]
		public string Text {
			get {
				GLib.Value val = GetProperty ("text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pulse")]
		public int Pulse {
			get {
				GLib.Value val = GetProperty ("pulse");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("pulse", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text-xalign")]
		public float TextXAlign {
			get {
				GLib.Value val = GetProperty ("text-xalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text-xalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text-yalign")]
		public float TextYAlign {
			get {
				GLib.Value val = GetProperty ("text-yalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text-yalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("inverted")]
		public bool Inverted {
			get {
				GLib.Value val = GetProperty ("inverted");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("inverted", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.CellRenderer.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, null
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
		delegate IntPtr d_gtk_cell_renderer_progress_get_type();
		static d_gtk_cell_renderer_progress_get_type gtk_cell_renderer_progress_get_type = FuncLoader.LoadFunction<d_gtk_cell_renderer_progress_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_renderer_progress_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_cell_renderer_progress_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_orientable_get_orientation(IntPtr raw);
		static d_gtk_orientable_get_orientation gtk_orientable_get_orientation = FuncLoader.LoadFunction<d_gtk_orientable_get_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_orientable_get_orientation"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_orientable_set_orientation(IntPtr raw, int orientation);
		static d_gtk_orientable_set_orientation gtk_orientable_set_orientation = FuncLoader.LoadFunction<d_gtk_orientable_set_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_orientable_set_orientation"));

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.CellRenderer.abi_info.Fields
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
