// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ProgressBar : Gtk.Widget, Gtk.IOrientable {

		public ProgressBar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_progress_bar_new();
		static d_gtk_progress_bar_new gtk_progress_bar_new = FuncLoader.LoadFunction<d_gtk_progress_bar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_new"));

		public ProgressBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ProgressBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_progress_bar_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_progress_bar_get_inverted(IntPtr raw);
		static d_gtk_progress_bar_get_inverted gtk_progress_bar_get_inverted = FuncLoader.LoadFunction<d_gtk_progress_bar_get_inverted>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_inverted"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_set_inverted(IntPtr raw, bool inverted);
		static d_gtk_progress_bar_set_inverted gtk_progress_bar_set_inverted = FuncLoader.LoadFunction<d_gtk_progress_bar_set_inverted>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_set_inverted"));

		[GLib.Property ("inverted")]
		public bool Inverted {
			get  {
				bool raw_ret = gtk_progress_bar_get_inverted(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_progress_bar_set_inverted(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_progress_bar_get_fraction(IntPtr raw);
		static d_gtk_progress_bar_get_fraction gtk_progress_bar_get_fraction = FuncLoader.LoadFunction<d_gtk_progress_bar_get_fraction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_fraction"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_set_fraction(IntPtr raw, double fraction);
		static d_gtk_progress_bar_set_fraction gtk_progress_bar_set_fraction = FuncLoader.LoadFunction<d_gtk_progress_bar_set_fraction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_set_fraction"));

		[GLib.Property ("fraction")]
		public double Fraction {
			get  {
				double raw_ret = gtk_progress_bar_get_fraction(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_progress_bar_set_fraction(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_gtk_progress_bar_get_pulse_step(IntPtr raw);
		static d_gtk_progress_bar_get_pulse_step gtk_progress_bar_get_pulse_step = FuncLoader.LoadFunction<d_gtk_progress_bar_get_pulse_step>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_pulse_step"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_set_pulse_step(IntPtr raw, double fraction);
		static d_gtk_progress_bar_set_pulse_step gtk_progress_bar_set_pulse_step = FuncLoader.LoadFunction<d_gtk_progress_bar_set_pulse_step>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_set_pulse_step"));

		[GLib.Property ("pulse-step")]
		public double PulseStep {
			get  {
				double raw_ret = gtk_progress_bar_get_pulse_step(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_progress_bar_set_pulse_step(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_progress_bar_get_text(IntPtr raw);
		static d_gtk_progress_bar_get_text gtk_progress_bar_get_text = FuncLoader.LoadFunction<d_gtk_progress_bar_get_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_text"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_set_text(IntPtr raw, IntPtr text);
		static d_gtk_progress_bar_set_text gtk_progress_bar_set_text = FuncLoader.LoadFunction<d_gtk_progress_bar_set_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_set_text"));

		[GLib.Property ("text")]
		public string Text {
			get  {
				IntPtr raw_ret = gtk_progress_bar_get_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_progress_bar_set_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_progress_bar_get_show_text(IntPtr raw);
		static d_gtk_progress_bar_get_show_text gtk_progress_bar_get_show_text = FuncLoader.LoadFunction<d_gtk_progress_bar_get_show_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_show_text"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_set_show_text(IntPtr raw, bool show_text);
		static d_gtk_progress_bar_set_show_text gtk_progress_bar_set_show_text = FuncLoader.LoadFunction<d_gtk_progress_bar_set_show_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_set_show_text"));

		[GLib.Property ("show-text")]
		public bool ShowText {
			get  {
				bool raw_ret = gtk_progress_bar_get_show_text(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_progress_bar_set_show_text(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_progress_bar_get_ellipsize(IntPtr raw);
		static d_gtk_progress_bar_get_ellipsize gtk_progress_bar_get_ellipsize = FuncLoader.LoadFunction<d_gtk_progress_bar_get_ellipsize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_ellipsize"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_set_ellipsize(IntPtr raw, int mode);
		static d_gtk_progress_bar_set_ellipsize gtk_progress_bar_set_ellipsize = FuncLoader.LoadFunction<d_gtk_progress_bar_set_ellipsize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_set_ellipsize"));

		[GLib.Property ("ellipsize")]
		public Pango.EllipsizeMode Ellipsize {
			get  {
				int raw_ret = gtk_progress_bar_get_ellipsize(Handle);
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) raw_ret;
				return ret;
			}
			set  {
				gtk_progress_bar_set_ellipsize(Handle, (int) value);
			}
		}

		[Obsolete]
		public int Xspacing {
			get {
				var val = (int)StyleGetProperty("xspacing");
				return val;
			}
		}

		[Obsolete]
		public int Yspacing {
			get {
				var val = (int)StyleGetProperty("yspacing");
				return val;
			}
		}

		[Obsolete]
		public int MinHorizontalBarWidth {
			get {
				var val = (int)StyleGetProperty("min-horizontal-bar-width");
				return val;
			}
		}

		[Obsolete]
		public int MinHorizontalBarHeight {
			get {
				var val = (int)StyleGetProperty("min-horizontal-bar-height");
				return val;
			}
		}

		[Obsolete]
		public int MinVerticalBarWidth {
			get {
				var val = (int)StyleGetProperty("min-vertical-bar-width");
				return val;
			}
		}

		[Obsolete]
		public int MinVerticalBarHeight {
			get {
				var val = (int)StyleGetProperty("min-vertical-bar-height");
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
							, Gtk.Widget.class_abi.Fields
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
		delegate IntPtr d_gtk_progress_bar_get_type();
		static d_gtk_progress_bar_get_type gtk_progress_bar_get_type = FuncLoader.LoadFunction<d_gtk_progress_bar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_progress_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_progress_bar_pulse(IntPtr raw);
		static d_gtk_progress_bar_pulse gtk_progress_bar_pulse = FuncLoader.LoadFunction<d_gtk_progress_bar_pulse>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_progress_bar_pulse"));

		public void Pulse() {
			gtk_progress_bar_pulse(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_orientable_get_orientation(IntPtr raw);
		static d_gtk_orientable_get_orientation gtk_orientable_get_orientation = FuncLoader.LoadFunction<d_gtk_orientable_get_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_orientable_get_orientation"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_orientable_set_orientation(IntPtr raw, int orientation);
		static d_gtk_orientable_set_orientation gtk_orientable_set_orientation = FuncLoader.LoadFunction<d_gtk_orientable_set_orientation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_orientable_set_orientation"));

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Widget.abi_info.Fields
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
