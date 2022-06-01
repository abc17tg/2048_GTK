// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GeolocationPosition : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_geolocation_position_get_type();
		static d_webkit_geolocation_position_get_type webkit_geolocation_position_get_type = FuncLoader.LoadFunction<d_webkit_geolocation_position_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_geolocation_position_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_geolocation_position_copy(IntPtr raw);
		static d_webkit_geolocation_position_copy webkit_geolocation_position_copy = FuncLoader.LoadFunction<d_webkit_geolocation_position_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_copy"));

		public WebKit.GeolocationPosition Copy() {
			IntPtr raw_ret = webkit_geolocation_position_copy(Handle);
			WebKit.GeolocationPosition ret = raw_ret == IntPtr.Zero ? null : (WebKit.GeolocationPosition) GLib.Opaque.GetOpaque (raw_ret, typeof (WebKit.GeolocationPosition), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_geolocation_position_set_altitude(IntPtr raw, double altitude);
		static d_webkit_geolocation_position_set_altitude webkit_geolocation_position_set_altitude = FuncLoader.LoadFunction<d_webkit_geolocation_position_set_altitude>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_set_altitude"));

		public double Altitude { 
			set {
				webkit_geolocation_position_set_altitude(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_geolocation_position_set_altitude_accuracy(IntPtr raw, double altitude_accuracy);
		static d_webkit_geolocation_position_set_altitude_accuracy webkit_geolocation_position_set_altitude_accuracy = FuncLoader.LoadFunction<d_webkit_geolocation_position_set_altitude_accuracy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_set_altitude_accuracy"));

		public double AltitudeAccuracy { 
			set {
				webkit_geolocation_position_set_altitude_accuracy(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_geolocation_position_set_heading(IntPtr raw, double heading);
		static d_webkit_geolocation_position_set_heading webkit_geolocation_position_set_heading = FuncLoader.LoadFunction<d_webkit_geolocation_position_set_heading>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_set_heading"));

		public double Heading { 
			set {
				webkit_geolocation_position_set_heading(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_geolocation_position_set_speed(IntPtr raw, double speed);
		static d_webkit_geolocation_position_set_speed webkit_geolocation_position_set_speed = FuncLoader.LoadFunction<d_webkit_geolocation_position_set_speed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_set_speed"));

		public double Speed { 
			set {
				webkit_geolocation_position_set_speed(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_geolocation_position_set_timestamp(IntPtr raw, ulong timestamp);
		static d_webkit_geolocation_position_set_timestamp webkit_geolocation_position_set_timestamp = FuncLoader.LoadFunction<d_webkit_geolocation_position_set_timestamp>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_set_timestamp"));

		public ulong Timestamp { 
			set {
				webkit_geolocation_position_set_timestamp(Handle, value);
			}
		}

		public GeolocationPosition(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_geolocation_position_new(double latitude, double longitude, double accuracy);
		static d_webkit_geolocation_position_new webkit_geolocation_position_new = FuncLoader.LoadFunction<d_webkit_geolocation_position_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_new"));

		public GeolocationPosition (double latitude, double longitude, double accuracy) 
		{
			Raw = webkit_geolocation_position_new(latitude, longitude, accuracy);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_geolocation_position_free(IntPtr raw);
		static d_webkit_geolocation_position_free webkit_geolocation_position_free = FuncLoader.LoadFunction<d_webkit_geolocation_position_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_geolocation_position_free"));

		protected override void Free (IntPtr raw)
		{
			webkit_geolocation_position_free (raw);
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
				webkit_geolocation_position_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~GeolocationPosition ()
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
