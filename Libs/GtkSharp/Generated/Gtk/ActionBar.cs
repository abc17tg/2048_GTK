// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ActionBar : Gtk.Bin {

		public ActionBar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_action_bar_new();
		static d_gtk_action_bar_new gtk_action_bar_new = FuncLoader.LoadFunction<d_gtk_action_bar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_bar_new"));

		public ActionBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ActionBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_action_bar_new();
		}

		public class ActionBarChild : Gtk.Container.ContainerChild {
			protected internal ActionBarChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("pack-type")]
			public Gtk.PackType PackType {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "pack-type");
					Gtk.PackType ret = (Gtk.PackType) (Enum) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value((Enum) value);
					parent.ChildSetProperty(child, "pack-type", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("position")]
			public int Position {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "position");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "position", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new ActionBarChild (this, child);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Bin.class_abi.Fields
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
		delegate IntPtr d_gtk_action_bar_get_center_widget(IntPtr raw);
		static d_gtk_action_bar_get_center_widget gtk_action_bar_get_center_widget = FuncLoader.LoadFunction<d_gtk_action_bar_get_center_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_bar_get_center_widget"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_bar_set_center_widget(IntPtr raw, IntPtr center_widget);
		static d_gtk_action_bar_set_center_widget gtk_action_bar_set_center_widget = FuncLoader.LoadFunction<d_gtk_action_bar_set_center_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_bar_set_center_widget"));

		public Gtk.Widget CenterWidget { 
			get {
				IntPtr raw_ret = gtk_action_bar_get_center_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set {
				gtk_action_bar_set_center_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_action_bar_get_type();
		static d_gtk_action_bar_get_type gtk_action_bar_get_type = FuncLoader.LoadFunction<d_gtk_action_bar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_bar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_action_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_bar_pack_end(IntPtr raw, IntPtr child);
		static d_gtk_action_bar_pack_end gtk_action_bar_pack_end = FuncLoader.LoadFunction<d_gtk_action_bar_pack_end>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_bar_pack_end"));

		public void PackEnd(Gtk.Widget child) {
			gtk_action_bar_pack_end(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_bar_pack_start(IntPtr raw, IntPtr child);
		static d_gtk_action_bar_pack_start gtk_action_bar_pack_start = FuncLoader.LoadFunction<d_gtk_action_bar_pack_start>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_bar_pack_start"));

		public void PackStart(Gtk.Widget child) {
			gtk_action_bar_pack_start(Handle, child == null ? IntPtr.Zero : child.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Bin.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
