// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.PlacesOpenFlagsGType))]
	public enum PlacesOpenFlags {

		Normal = 1 << 0,
		NewTab = 1 << 1,
		NewWindow = 1 << 2,
	}

	internal class PlacesOpenFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_places_open_flags_get_type();
		static d_gtk_places_open_flags_get_type gtk_places_open_flags_get_type = FuncLoader.LoadFunction<d_gtk_places_open_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_places_open_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_places_open_flags_get_type ());
			}
		}
	}
#endregion
}