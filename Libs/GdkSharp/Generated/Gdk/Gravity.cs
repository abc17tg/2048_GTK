// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.GravityGType))]
	public enum Gravity {

		NorthWest = 1,
		North,
		NorthEast,
		West,
		Center,
		East,
		SouthWest,
		South,
		SouthEast,
		Static,
	}

	internal class GravityGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_gravity_get_type();
		static d_gdk_gravity_get_type gdk_gravity_get_type = FuncLoader.LoadFunction<d_gdk_gravity_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_gravity_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_gravity_get_type ());
			}
		}
	}
#endregion
}
