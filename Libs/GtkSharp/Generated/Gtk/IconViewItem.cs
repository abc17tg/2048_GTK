// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class IconViewItem : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_icon_view_item_activated(IntPtr icon_view, IntPtr path);
		static d_gtk_icon_view_item_activated gtk_icon_view_item_activated = FuncLoader.LoadFunction<d_gtk_icon_view_item_activated>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_icon_view_item_activated"));

		public static void Activated(Gtk.IconView icon_view, Gtk.TreePath path) {
			gtk_icon_view_item_activated(icon_view == null ? IntPtr.Zero : icon_view.Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		public IconViewItem(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}