// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (WebKit.AutomationBrowsingContextPresentationGType))]
	public enum AutomationBrowsingContextPresentation {

		Window = 0,
		Tab = 1,
	}

	internal class AutomationBrowsingContextPresentationGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_automation_browsing_context_presentation_get_type();
		static d_webkit_automation_browsing_context_presentation_get_type webkit_automation_browsing_context_presentation_get_type = FuncLoader.LoadFunction<d_webkit_automation_browsing_context_presentation_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_automation_browsing_context_presentation_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_automation_browsing_context_presentation_get_type ());
			}
		}
	}
#endregion
}
