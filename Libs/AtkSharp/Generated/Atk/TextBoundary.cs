// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Atk.TextBoundaryGType))]
	public enum TextBoundary {

		Char,
		WordStart,
		WordEnd,
		SentenceStart,
		SentenceEnd,
		LineStart,
		LineEnd,
	}

	internal class TextBoundaryGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_boundary_get_type();
		static d_atk_text_boundary_get_type atk_text_boundary_get_type = FuncLoader.LoadFunction<d_atk_text_boundary_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_boundary_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (atk_text_boundary_get_type ());
			}
		}
	}
#endregion
}