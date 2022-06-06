// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Revealer : Gtk.Bin {

		public Revealer (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_revealer_new();
		static d_gtk_revealer_new gtk_revealer_new = FuncLoader.LoadFunction<d_gtk_revealer_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_new"));

		public Revealer () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Revealer)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_revealer_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_revealer_get_transition_type(IntPtr raw);
		static d_gtk_revealer_get_transition_type gtk_revealer_get_transition_type = FuncLoader.LoadFunction<d_gtk_revealer_get_transition_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_get_transition_type"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_revealer_set_transition_type(IntPtr raw, int transition);
		static d_gtk_revealer_set_transition_type gtk_revealer_set_transition_type = FuncLoader.LoadFunction<d_gtk_revealer_set_transition_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_set_transition_type"));

		[GLib.Property ("transition-type")]
		public Gtk.RevealerTransitionType TransitionType {
			get  {
				int raw_ret = gtk_revealer_get_transition_type(Handle);
				Gtk.RevealerTransitionType ret = (Gtk.RevealerTransitionType) raw_ret;
				return ret;
			}
			set  {
				gtk_revealer_set_transition_type(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_revealer_get_transition_duration(IntPtr raw);
		static d_gtk_revealer_get_transition_duration gtk_revealer_get_transition_duration = FuncLoader.LoadFunction<d_gtk_revealer_get_transition_duration>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_get_transition_duration"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_revealer_set_transition_duration(IntPtr raw, uint duration);
		static d_gtk_revealer_set_transition_duration gtk_revealer_set_transition_duration = FuncLoader.LoadFunction<d_gtk_revealer_set_transition_duration>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_set_transition_duration"));

		[GLib.Property ("transition-duration")]
		public uint TransitionDuration {
			get  {
				uint raw_ret = gtk_revealer_get_transition_duration(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_revealer_set_transition_duration(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_revealer_get_reveal_child(IntPtr raw);
		static d_gtk_revealer_get_reveal_child gtk_revealer_get_reveal_child = FuncLoader.LoadFunction<d_gtk_revealer_get_reveal_child>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_get_reveal_child"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_revealer_set_reveal_child(IntPtr raw, bool reveal_child);
		static d_gtk_revealer_set_reveal_child gtk_revealer_set_reveal_child = FuncLoader.LoadFunction<d_gtk_revealer_set_reveal_child>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_set_reveal_child"));

		[GLib.Property ("reveal-child")]
		public bool RevealChild {
			get  {
				bool raw_ret = gtk_revealer_get_reveal_child(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_revealer_set_reveal_child(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_revealer_get_child_revealed(IntPtr raw);
		static d_gtk_revealer_get_child_revealed gtk_revealer_get_child_revealed = FuncLoader.LoadFunction<d_gtk_revealer_get_child_revealed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_get_child_revealed"));

		[GLib.Property ("child-revealed")]
		public bool ChildRevealed {
			get  {
				bool raw_ret = gtk_revealer_get_child_revealed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gtk.Bin.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_revealer_get_type();
		static d_gtk_revealer_get_type gtk_revealer_get_type = FuncLoader.LoadFunction<d_gtk_revealer_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_revealer_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_revealer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Bin.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}