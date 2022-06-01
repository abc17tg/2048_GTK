// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class KineticScrolling : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_kinetic_scrolling_tick(IntPtr raw, double time_delta, out double position);
		static d_gtk_kinetic_scrolling_tick gtk_kinetic_scrolling_tick = FuncLoader.LoadFunction<d_gtk_kinetic_scrolling_tick>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_kinetic_scrolling_tick"));

		public bool Tick(double time_delta, out double position) {
			bool raw_ret = gtk_kinetic_scrolling_tick(Handle, time_delta, out position);
			bool ret = raw_ret;
			return ret;
		}

		public KineticScrolling(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_kinetic_scrolling_new(double lower, double upper, double overshoot_width, double decel_friction, double overshoot_friction, double initial_position, double initial_velocity);
		static d_gtk_kinetic_scrolling_new gtk_kinetic_scrolling_new = FuncLoader.LoadFunction<d_gtk_kinetic_scrolling_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_kinetic_scrolling_new"));

		public KineticScrolling (double lower, double upper, double overshoot_width, double decel_friction, double overshoot_friction, double initial_position, double initial_velocity) 
		{
			Raw = gtk_kinetic_scrolling_new(lower, upper, overshoot_width, decel_friction, overshoot_friction, initial_position, initial_velocity);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_kinetic_scrolling_free(IntPtr raw);
		static d_gtk_kinetic_scrolling_free gtk_kinetic_scrolling_free = FuncLoader.LoadFunction<d_gtk_kinetic_scrolling_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_kinetic_scrolling_free"));

		protected override void Free (IntPtr raw)
		{
			gtk_kinetic_scrolling_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_kinetic_scrolling_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~KineticScrolling ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


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
