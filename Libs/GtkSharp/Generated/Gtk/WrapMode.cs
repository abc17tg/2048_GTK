// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.WrapModeGType))]
	public enum WrapMode {

		None,
		Char,
		Word,
		WordChar,
	}

	internal class WrapModeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_wrap_mode_get_type();
		static d_gtk_wrap_mode_get_type gtk_wrap_mode_get_type = FuncLoader.LoadFunction<d_gtk_wrap_mode_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_wrap_mode_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_wrap_mode_get_type ());
			}
		}
	}
#endregion
}
