// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.MountUnmountFlagsGType))]
	public enum MountUnmountFlags {

		None,
		Force = 1 << 0,
	}

	internal class MountUnmountFlagsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_mount_unmount_flags_get_type();
		static d_g_mount_unmount_flags_get_type g_mount_unmount_flags_get_type = FuncLoader.LoadFunction<d_g_mount_unmount_flags_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_mount_unmount_flags_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_mount_unmount_flags_get_type ());
			}
		}
	}
#endregion
}