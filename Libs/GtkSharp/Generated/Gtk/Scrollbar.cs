// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Scrollbar : Gtk.Range {

		public Scrollbar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_scrollbar_new(int orientation, IntPtr adjustment);
		static d_gtk_scrollbar_new gtk_scrollbar_new = FuncLoader.LoadFunction<d_gtk_scrollbar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_scrollbar_new"));

		public Scrollbar (Gtk.Orientation orientation, Gtk.Adjustment adjustment) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Scrollbar)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("adjustment");
				vals.Add (new GLib.Value (adjustment));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_scrollbar_new((int) orientation, adjustment == null ? IntPtr.Zero : adjustment.Handle);
		}

		[Obsolete]
		public int MinSliderLength {
			get {
				var val = (int)StyleGetProperty("min-slider-length");
				return val;
			}
		}

		public bool FixedSliderLength {
			get {
				var val = (bool)StyleGetProperty("fixed-slider-length");
				return val;
			}
		}

		public bool HasBackwardStepper {
			get {
				var val = (bool)StyleGetProperty("has-backward-stepper");
				return val;
			}
		}

		public bool HasForwardStepper {
			get {
				var val = (bool)StyleGetProperty("has-forward-stepper");
				return val;
			}
		}

		public bool HasSecondaryBackwardStepper {
			get {
				var val = (bool)StyleGetProperty("has-secondary-backward-stepper");
				return val;
			}
		}

		public bool HasSecondaryForwardStepper {
			get {
				var val = (bool)StyleGetProperty("has-secondary-forward-stepper");
				return val;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Range.class_abi.Fields
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
		delegate IntPtr d_gtk_scrollbar_get_type();
		static d_gtk_scrollbar_get_type gtk_scrollbar_get_type = FuncLoader.LoadFunction<d_gtk_scrollbar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_scrollbar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_scrollbar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Range.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}