// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.ScrollDirectionGType))]
	public enum ScrollDirection {

		Up,
		Down,
		Left,
		Right,
		Smooth,
	}

	internal class ScrollDirectionGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_scroll_direction_get_type();
		static d_gdk_scroll_direction_get_type gdk_scroll_direction_get_type = FuncLoader.LoadFunction<d_gdk_scroll_direction_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_scroll_direction_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_scroll_direction_get_type ());
			}
		}
	}
#endregion
}