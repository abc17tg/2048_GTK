// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.UnixSocketAddressTypeGType))]
	public enum UnixSocketAddressType {

		Invalid,
		Anonymous,
		Path,
		Abstract,
		AbstractPadded,
	}

	internal class UnixSocketAddressTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_socket_address_type_get_type();
		static d_g_unix_socket_address_type_get_type g_unix_socket_address_type_get_type = FuncLoader.LoadFunction<d_g_unix_socket_address_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_socket_address_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_unix_socket_address_type_get_type ());
			}
		}
	}
#endregion
}