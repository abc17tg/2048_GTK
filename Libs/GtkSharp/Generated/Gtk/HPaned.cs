// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class HPaned : Gtk.Paned {

		public HPaned (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_hpaned_new();
		static d_gtk_hpaned_new gtk_hpaned_new = FuncLoader.LoadFunction<d_gtk_hpaned_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_hpaned_new"));

		public HPaned () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HPaned)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_hpaned_new();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gtk.Paned.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_hpaned_get_type();
		static d_gtk_hpaned_get_type gtk_hpaned_get_type = FuncLoader.LoadFunction<d_gtk_hpaned_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_hpaned_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_hpaned_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Paned.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}