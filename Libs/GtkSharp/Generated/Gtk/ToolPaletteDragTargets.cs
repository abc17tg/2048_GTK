// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.ToolPaletteDragTargetsGType))]
	public enum ToolPaletteDragTargets {

		Items = 1 << 0,
		Groups = 1 << 1,
	}

	internal class ToolPaletteDragTargetsGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tool_palette_drag_targets_get_type();
		static d_gtk_tool_palette_drag_targets_get_type gtk_tool_palette_drag_targets_get_type = FuncLoader.LoadFunction<d_gtk_tool_palette_drag_targets_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tool_palette_drag_targets_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_tool_palette_drag_targets_get_type ());
			}
		}
	}
#endregion
}
