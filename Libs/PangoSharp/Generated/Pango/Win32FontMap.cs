// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Win32FontMap : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_win32_font_map_for_display();
		static d_pango_win32_font_map_for_display pango_win32_font_map_for_display = FuncLoader.LoadFunction<d_pango_win32_font_map_for_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_win32_font_map_for_display"));

		public static Pango.FontMap ForDisplay() {
			IntPtr raw_ret = pango_win32_font_map_for_display();
			Pango.FontMap ret = GLib.Object.GetObject(raw_ret) as Pango.FontMap;
			return ret;
		}

		public Win32FontMap(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}