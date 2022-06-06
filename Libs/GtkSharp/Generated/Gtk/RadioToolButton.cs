// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class RadioToolButton : Gtk.ToggleToolButton {

		public RadioToolButton (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_radio_tool_button_new_from_widget(IntPtr group);
		static d_gtk_radio_tool_button_new_from_widget gtk_radio_tool_button_new_from_widget = FuncLoader.LoadFunction<d_gtk_radio_tool_button_new_from_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_tool_button_new_from_widget"));

		public RadioToolButton (Gtk.RadioToolButton group) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RadioToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_radio_tool_button_new_from_widget(group == null ? IntPtr.Zero : group.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_radio_tool_button_new_with_stock_from_widget(IntPtr group, IntPtr stock_id);
		static d_gtk_radio_tool_button_new_with_stock_from_widget gtk_radio_tool_button_new_with_stock_from_widget = FuncLoader.LoadFunction<d_gtk_radio_tool_button_new_with_stock_from_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_tool_button_new_with_stock_from_widget"));

		public RadioToolButton (Gtk.RadioToolButton group, string stock_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RadioToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (group != null) {
					names.Add ("stock_id");
					vals.Add (new GLib.Value (stock_id));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_radio_tool_button_new_with_stock_from_widget(group == null ? IntPtr.Zero : group.Handle, native_stock_id);
			GLib.Marshaller.Free (native_stock_id);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.ToggleToolButton.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_radio_tool_button_get_type();
		static d_gtk_radio_tool_button_get_type gtk_radio_tool_button_get_type = FuncLoader.LoadFunction<d_gtk_radio_tool_button_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_radio_tool_button_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_radio_tool_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.ToggleToolButton.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}