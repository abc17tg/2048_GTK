// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ShortcutsGroup : Gtk.Box {

		public ShortcutsGroup (IntPtr raw) : base(raw) {}

		protected ShortcutsGroup() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("title")]
		public string Title {
			get {
				GLib.Value val = GetProperty ("title");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("title", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("view")]
		public string View {
			get {
				GLib.Value val = GetProperty ("view");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("view", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("accel-size-group")]
		public Gtk.SizeGroup AccelSizeGroup {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("accel-size-group", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("title-size-group")]
		public Gtk.SizeGroup TitleSizeGroup {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("title-size-group", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("height")]
		public uint Height {
			get {
				GLib.Value val = GetProperty ("height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gtk.Box.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_shortcuts_group_get_type();
		static d_gtk_shortcuts_group_get_type gtk_shortcuts_group_get_type = FuncLoader.LoadFunction<d_gtk_shortcuts_group_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_shortcuts_group_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_shortcuts_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Box.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
