// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (WebKit.CookiePersistentStorageGType))]
	public enum CookiePersistentStorage {

		Text = 0,
		Sqlite = 1,
	}

	internal class CookiePersistentStorageGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_cookie_persistent_storage_get_type();
		static d_webkit_cookie_persistent_storage_get_type webkit_cookie_persistent_storage_get_type = FuncLoader.LoadFunction<d_webkit_cookie_persistent_storage_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_cookie_persistent_storage_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_cookie_persistent_storage_get_type ());
			}
		}
	}
#endregion
}
