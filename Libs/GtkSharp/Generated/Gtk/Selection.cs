// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Selection {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_selection_add_target(IntPtr widget, IntPtr selection, IntPtr target, uint info);
		static d_gtk_selection_add_target gtk_selection_add_target = FuncLoader.LoadFunction<d_gtk_selection_add_target>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_add_target"));

		public static void AddTarget(Gtk.Widget widget, Gdk.Atom selection, Gdk.Atom target, uint info) {
			gtk_selection_add_target(widget == null ? IntPtr.Zero : widget.Handle, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, info);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_selection_add_targets(IntPtr widget, IntPtr selection, IntPtr targets, uint ntargets);
		static d_gtk_selection_add_targets gtk_selection_add_targets = FuncLoader.LoadFunction<d_gtk_selection_add_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_add_targets"));

		public static void AddTargets(Gtk.Widget widget, Gdk.Atom selection, Gtk.TargetEntry targets, uint ntargets) {
			IntPtr native_targets = GLib.Marshaller.StructureToPtrAlloc (targets);
			gtk_selection_add_targets(widget == null ? IntPtr.Zero : widget.Handle, selection == null ? IntPtr.Zero : selection.Handle, native_targets, ntargets);
			Marshal.FreeHGlobal (native_targets);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_selection_clear_targets(IntPtr widget, IntPtr selection);
		static d_gtk_selection_clear_targets gtk_selection_clear_targets = FuncLoader.LoadFunction<d_gtk_selection_clear_targets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_clear_targets"));

		public static void ClearTargets(Gtk.Widget widget, Gdk.Atom selection) {
			gtk_selection_clear_targets(widget == null ? IntPtr.Zero : widget.Handle, selection == null ? IntPtr.Zero : selection.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_selection_convert(IntPtr widget, IntPtr selection, IntPtr target, uint time_);
		static d_gtk_selection_convert gtk_selection_convert = FuncLoader.LoadFunction<d_gtk_selection_convert>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_convert"));

		public static bool Convert(Gtk.Widget widget, Gdk.Atom selection, Gdk.Atom target, uint time_) {
			bool raw_ret = gtk_selection_convert(widget == null ? IntPtr.Zero : widget.Handle, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, time_);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_selection_owner_set(IntPtr widget, IntPtr selection, uint time_);
		static d_gtk_selection_owner_set gtk_selection_owner_set = FuncLoader.LoadFunction<d_gtk_selection_owner_set>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_owner_set"));

		public static bool OwnerSet(Gtk.Widget widget, Gdk.Atom selection, uint time_) {
			bool raw_ret = gtk_selection_owner_set(widget == null ? IntPtr.Zero : widget.Handle, selection == null ? IntPtr.Zero : selection.Handle, time_);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_selection_owner_set_for_display(IntPtr display, IntPtr widget, IntPtr selection, uint time_);
		static d_gtk_selection_owner_set_for_display gtk_selection_owner_set_for_display = FuncLoader.LoadFunction<d_gtk_selection_owner_set_for_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_owner_set_for_display"));

		public static bool OwnerSetForDisplay(Gdk.Display display, Gtk.Widget widget, Gdk.Atom selection, uint time_) {
			bool raw_ret = gtk_selection_owner_set_for_display(display == null ? IntPtr.Zero : display.Handle, widget == null ? IntPtr.Zero : widget.Handle, selection == null ? IntPtr.Zero : selection.Handle, time_);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_selection_remove_all(IntPtr widget);
		static d_gtk_selection_remove_all gtk_selection_remove_all = FuncLoader.LoadFunction<d_gtk_selection_remove_all>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_selection_remove_all"));

		public static void RemoveAll(Gtk.Widget widget) {
			gtk_selection_remove_all(widget == null ? IntPtr.Zero : widget.Handle);
		}

#endregion
	}
}