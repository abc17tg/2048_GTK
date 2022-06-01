// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ButtonBox : Gtk.Box {

		public ButtonBox (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_button_box_new(int orientation);
		static d_gtk_button_box_new gtk_button_box_new = FuncLoader.LoadFunction<d_gtk_button_box_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_new"));

		public ButtonBox (Gtk.Orientation orientation) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ButtonBox)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_button_box_new((int) orientation);
		}

		[Obsolete]
		public int ChildMinWidth {
			get {
				var val = (int)StyleGetProperty("child-min-width");
				return val;
			}
		}

		[Obsolete]
		public int ChildMinHeight {
			get {
				var val = (int)StyleGetProperty("child-min-height");
				return val;
			}
		}

		[Obsolete]
		public int ChildInternalPadX {
			get {
				var val = (int)StyleGetProperty("child-internal-pad-x");
				return val;
			}
		}

		[Obsolete]
		public int ChildInternalPadY {
			get {
				var val = (int)StyleGetProperty("child-internal-pad-y");
				return val;
			}
		}

		[GLib.Property ("layout-style")]
		public Gtk.ButtonBoxStyle LayoutStyle {
			get {
				GLib.Value val = GetProperty ("layout-style");
				Gtk.ButtonBoxStyle ret = (Gtk.ButtonBoxStyle) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("layout-style", val);
				val.Dispose ();
			}
		}

		public class ButtonBoxChild : Gtk.Box.BoxChild {
			protected internal ButtonBoxChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("secondary")]
			public bool Secondary {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "secondary");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "secondary", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("non-homogeneous")]
			public bool NonHomogeneous {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "non-homogeneous");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "non-homogeneous", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new ButtonBoxChild (this, child);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Box.class_abi.Fields
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
		delegate bool d_gtk_button_box_get_child_non_homogeneous(IntPtr raw, IntPtr child);
		static d_gtk_button_box_get_child_non_homogeneous gtk_button_box_get_child_non_homogeneous = FuncLoader.LoadFunction<d_gtk_button_box_get_child_non_homogeneous>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_get_child_non_homogeneous"));

		public bool GetChildNonHomogeneous(Gtk.Widget child) {
			bool raw_ret = gtk_button_box_get_child_non_homogeneous(Handle, child == null ? IntPtr.Zero : child.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_button_box_get_child_secondary(IntPtr raw, IntPtr child);
		static d_gtk_button_box_get_child_secondary gtk_button_box_get_child_secondary = FuncLoader.LoadFunction<d_gtk_button_box_get_child_secondary>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_get_child_secondary"));

		public bool GetChildSecondary(Gtk.Widget child) {
			bool raw_ret = gtk_button_box_get_child_secondary(Handle, child == null ? IntPtr.Zero : child.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_button_box_get_layout(IntPtr raw);
		static d_gtk_button_box_get_layout gtk_button_box_get_layout = FuncLoader.LoadFunction<d_gtk_button_box_get_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_get_layout"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_button_box_set_layout(IntPtr raw, int layout_style);
		static d_gtk_button_box_set_layout gtk_button_box_set_layout = FuncLoader.LoadFunction<d_gtk_button_box_set_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_set_layout"));

		public Gtk.ButtonBoxStyle Layout { 
			get {
				int raw_ret = gtk_button_box_get_layout(Handle);
				Gtk.ButtonBoxStyle ret = (Gtk.ButtonBoxStyle) raw_ret;
				return ret;
			}
			set {
				gtk_button_box_set_layout(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_button_box_get_type();
		static d_gtk_button_box_get_type gtk_button_box_get_type = FuncLoader.LoadFunction<d_gtk_button_box_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_button_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_button_box_set_child_non_homogeneous(IntPtr raw, IntPtr child, bool non_homogeneous);
		static d_gtk_button_box_set_child_non_homogeneous gtk_button_box_set_child_non_homogeneous = FuncLoader.LoadFunction<d_gtk_button_box_set_child_non_homogeneous>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_set_child_non_homogeneous"));

		public void SetChildNonHomogeneous(Gtk.Widget child, bool non_homogeneous) {
			gtk_button_box_set_child_non_homogeneous(Handle, child == null ? IntPtr.Zero : child.Handle, non_homogeneous);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_button_box_set_child_secondary(IntPtr raw, IntPtr child, bool is_secondary);
		static d_gtk_button_box_set_child_secondary gtk_button_box_set_child_secondary = FuncLoader.LoadFunction<d_gtk_button_box_set_child_secondary>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_button_box_set_child_secondary"));

		public void SetChildSecondary(Gtk.Widget child, bool is_secondary) {
			gtk_button_box_set_child_secondary(Handle, child == null ? IntPtr.Zero : child.Handle, is_secondary);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Box.abi_info.Fields
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
