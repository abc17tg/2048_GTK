// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.TargetFlagsGType))]
	public enum TargetFlags {

		App = 1 << 0,
		Widget = 1 << 1,
		OtherApp = 1 << 2,
		OtherWidget = 1 << 3,
	}

	internal class TargetFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_target_flags_get_type();
		static d_gtk_target_flags_get_type gtk_target_flags_get_type = FuncLoader.LoadFunction<d_gtk_target_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_target_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_target_flags_get_type ());
			}
		}
	}
#endregion
}
