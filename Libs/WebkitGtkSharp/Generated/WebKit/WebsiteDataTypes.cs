// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (WebKit.WebsiteDataTypesGType))]
	public enum WebsiteDataTypes {

		MemoryCache = 1,
		DiskCache = 2,
		OfflineApplicationCache = 4,
		SessionStorage = 8,
		LocalStorage = 16,
		WebsqlDatabases = 32,
		IndexeddbDatabases = 64,
		PluginData = 128,
		Cookies = 256,
		DeviceIdHashSalt = 512,
		HstsCache = 1024,
		Itp = 2048,
		ServiceWorkerRegistrations = 4096,
		DomCache = 8192,
		All = 16383,
	}

	internal class WebsiteDataTypesGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_website_data_types_get_type();
		static d_webkit_website_data_types_get_type webkit_website_data_types_get_type = FuncLoader.LoadFunction<d_webkit_website_data_types_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_website_data_types_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_website_data_types_get_type ());
			}
		}
	}
#endregion
}
