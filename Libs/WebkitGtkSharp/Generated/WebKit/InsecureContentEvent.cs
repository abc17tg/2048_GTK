// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (WebKit.InsecureContentEventGType))]
	public enum InsecureContentEvent {

		Run = 0,
		Displayed = 1,
	}

	internal class InsecureContentEventGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_insecure_content_event_get_type();
		static d_webkit_insecure_content_event_get_type webkit_insecure_content_event_get_type = FuncLoader.LoadFunction<d_webkit_insecure_content_event_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_insecure_content_event_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_insecure_content_event_get_type ());
			}
		}
	}
#endregion
}
