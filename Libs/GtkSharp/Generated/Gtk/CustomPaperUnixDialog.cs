// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class CustomPaperUnixDialog : Gtk.Dialog {

		public CustomPaperUnixDialog (IntPtr raw) : base(raw) {}

		protected CustomPaperUnixDialog() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_custom_paper_unix_dialog_get_type();
		static d_gtk_custom_paper_unix_dialog_get_type gtk_custom_paper_unix_dialog_get_type = FuncLoader.LoadFunction<d_gtk_custom_paper_unix_dialog_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_custom_paper_unix_dialog_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_custom_paper_unix_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
