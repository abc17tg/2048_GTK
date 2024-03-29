// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ColorSelectionDialog : Gtk.Dialog {

		public ColorSelectionDialog (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_color_selection_dialog_new(IntPtr title);
		static d_gtk_color_selection_dialog_new gtk_color_selection_dialog_new = FuncLoader.LoadFunction<d_gtk_color_selection_dialog_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_color_selection_dialog_new"));

		public ColorSelectionDialog (string title) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ColorSelectionDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("title");
				vals.Add (new GLib.Value (title));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			Raw = gtk_color_selection_dialog_new(native_title);
			GLib.Marshaller.Free (native_title);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_color_selection_dialog_get_color_selection(IntPtr raw);
		static d_gtk_color_selection_dialog_get_color_selection gtk_color_selection_dialog_get_color_selection = FuncLoader.LoadFunction<d_gtk_color_selection_dialog_get_color_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_color_selection_dialog_get_color_selection"));

		[Obsolete]
		[GLib.Property ("color-selection")]
		public Gtk.ColorSelection ColorSelection {
			get  {
				IntPtr raw_ret = gtk_color_selection_dialog_get_color_selection(Handle);
				Gtk.ColorSelection ret = GLib.Object.GetObject(raw_ret) as Gtk.ColorSelection;
				return ret;
			}
		}

		[GLib.Property ("ok-button")]
		public Gtk.Button OkButton {
			get {
				GLib.Value val = GetProperty ("ok-button");
				Gtk.Button ret = (Gtk.Button) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("cancel-button")]
		public Gtk.Button CancelButton {
			get {
				GLib.Value val = GetProperty ("cancel-button");
				Gtk.Button ret = (Gtk.Button) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("help-button")]
		public Gtk.Button HelpButton {
			get {
				GLib.Value val = GetProperty ("help-button");
				Gtk.Button ret = (Gtk.Button) val;
				val.Dispose ();
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Dialog.class_abi.Fields
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
		delegate IntPtr d_gtk_color_selection_dialog_get_type();
		static d_gtk_color_selection_dialog_get_type gtk_color_selection_dialog_get_type = FuncLoader.LoadFunction<d_gtk_color_selection_dialog_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_color_selection_dialog_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_color_selection_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Dialog.abi_info.Fields
							, (uint) sizeof( IntPtr ) // priv
							, null
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
