// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Pointer {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_pointer_grab(IntPtr window, bool owner_events, int event_mask, IntPtr confine_to, IntPtr cursor, uint time_);
		static d_gdk_pointer_grab gdk_pointer_grab = FuncLoader.LoadFunction<d_gdk_pointer_grab>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_pointer_grab"));

		[Obsolete]
		public static Gdk.GrabStatus Grab(Gdk.Window window, bool owner_events, Gdk.EventMask event_mask, Gdk.Window confine_to, Gdk.Cursor cursor, uint time_) {
			int raw_ret = gdk_pointer_grab(window == null ? IntPtr.Zero : window.Handle, owner_events, (int) event_mask, confine_to == null ? IntPtr.Zero : confine_to.Handle, cursor == null ? IntPtr.Zero : cursor.Handle, time_);
			Gdk.GrabStatus ret = (Gdk.GrabStatus) raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gdk_pointer_is_grabbed();
		static d_gdk_pointer_is_grabbed gdk_pointer_is_grabbed = FuncLoader.LoadFunction<d_gdk_pointer_is_grabbed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_pointer_is_grabbed"));

		[Obsolete]
		public static bool IsGrabbed { 
			get {
				bool raw_ret = gdk_pointer_is_grabbed();
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_pointer_ungrab(uint time_);
		static d_gdk_pointer_ungrab gdk_pointer_ungrab = FuncLoader.LoadFunction<d_gdk_pointer_ungrab>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_pointer_ungrab"));

		[Obsolete]
		public static void Ungrab(uint time_) {
			gdk_pointer_ungrab(time_);
		}

#endregion
	}
}
