// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (WebKit.NavigationTypeGType))]
	public enum NavigationType {

		LinkClicked = 0,
		FormSubmitted = 1,
		BackForward = 2,
		Reload = 3,
		FormResubmitted = 4,
		Other = 5,
	}

	internal class NavigationTypeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_navigation_type_get_type();
		static d_webkit_navigation_type_get_type webkit_navigation_type_get_type = FuncLoader.LoadFunction<d_webkit_navigation_type_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_type_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_navigation_type_get_type ());
			}
		}
	}
#endregion
}
