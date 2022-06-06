// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Grab {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_grab_add(IntPtr widget);
		static d_gtk_grab_add gtk_grab_add = FuncLoader.LoadFunction<d_gtk_grab_add>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_grab_add"));

		public static void Add(Gtk.Widget widget) {
			gtk_grab_add(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_grab_get_current();
		static d_gtk_grab_get_current gtk_grab_get_current = FuncLoader.LoadFunction<d_gtk_grab_get_current>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_grab_get_current"));

		public static Gtk.Widget Current { 
			get {
				IntPtr raw_ret = gtk_grab_get_current();
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_grab_remove(IntPtr widget);
		static d_gtk_grab_remove gtk_grab_remove = FuncLoader.LoadFunction<d_gtk_grab_remove>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_grab_remove"));

		public static void Remove(Gtk.Widget widget) {
			gtk_grab_remove(widget == null ? IntPtr.Zero : widget.Handle);
		}

#endregion
	}
}