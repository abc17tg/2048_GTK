// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Error {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_error_trap_pop_ignored();
		static d_gdk_error_trap_pop_ignored gdk_error_trap_pop_ignored = FuncLoader.LoadFunction<d_gdk_error_trap_pop_ignored>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_error_trap_pop_ignored"));

		public static void TrapPopIgnored() {
			gdk_error_trap_pop_ignored();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_error_trap_push();
		static d_gdk_error_trap_push gdk_error_trap_push = FuncLoader.LoadFunction<d_gdk_error_trap_push>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_error_trap_push"));

		public static void TrapPush() {
			gdk_error_trap_push();
		}

#endregion
	}
}