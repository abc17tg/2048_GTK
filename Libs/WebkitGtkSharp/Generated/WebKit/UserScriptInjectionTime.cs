// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (WebKit.UserScriptInjectionTimeGType))]
	public enum UserScriptInjectionTime {

		Start = 0,
		End = 1,
	}

	internal class UserScriptInjectionTimeGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_script_injection_time_get_type();
		static d_webkit_user_script_injection_time_get_type webkit_user_script_injection_time_get_type = FuncLoader.LoadFunction<d_webkit_user_script_injection_time_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_script_injection_time_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_user_script_injection_time_get_type ());
			}
		}
	}
#endregion
}