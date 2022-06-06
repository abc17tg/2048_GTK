// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.BuilderErrorGType))]
	public enum BuilderError {

		InvalidTypeFunction,
		UnhandledTag,
		MissingAttribute,
		InvalidAttribute,
		InvalidTag,
		MissingPropertyValue,
		InvalidValue,
		VersionMismatch,
		DuplicateId,
		ObjectTypeRefused,
		TemplateMismatch,
		InvalidProperty,
		InvalidSignal,
		InvalidId,
	}

	internal class BuilderErrorGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_builder_error_get_type();
		static d_gtk_builder_error_get_type gtk_builder_error_get_type = FuncLoader.LoadFunction<d_gtk_builder_error_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_builder_error_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_builder_error_get_type ());
			}
		}
	}
#endregion
}