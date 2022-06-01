// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Property {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_property_change(IntPtr window, IntPtr property, IntPtr type, int format, int mode, byte[] data, int nelements);
		static d_gdk_property_change gdk_property_change = FuncLoader.LoadFunction<d_gdk_property_change>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_property_change"));

		public static void Change(Gdk.Window window, Gdk.Atom property, Gdk.Atom type, int format, Gdk.PropMode mode, byte[] data, int nelements) {
			gdk_property_change(window == null ? IntPtr.Zero : window.Handle, property == null ? IntPtr.Zero : property.Handle, type == null ? IntPtr.Zero : type.Handle, format, (int) mode, data, nelements);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_property_delete(IntPtr window, IntPtr property);
		static d_gdk_property_delete gdk_property_delete = FuncLoader.LoadFunction<d_gdk_property_delete>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_property_delete"));

		public static void Delete(Gdk.Window window, Gdk.Atom property) {
			gdk_property_delete(window == null ? IntPtr.Zero : window.Handle, property == null ? IntPtr.Zero : property.Handle);
		}

#endregion
	}
}
