// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class AppLaunchContext : GLib.AppLaunchContext {

		public AppLaunchContext (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_app_launch_context_new();
		static d_gdk_app_launch_context_new gdk_app_launch_context_new = FuncLoader.LoadFunction<d_gdk_app_launch_context_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_new"));

		public AppLaunchContext () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppLaunchContext)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gdk_app_launch_context_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_app_launch_context_set_display(IntPtr raw, IntPtr display);
		static d_gdk_app_launch_context_set_display gdk_app_launch_context_set_display = FuncLoader.LoadFunction<d_gdk_app_launch_context_set_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_set_display"));

		[Obsolete]
		[GLib.Property ("display")]
		public Gdk.Display Display {
			get {
				GLib.Value val = GetProperty ("display");
				Gdk.Display ret = (Gdk.Display) val;
				val.Dispose ();
				return ret;
			}
			set  {
				gdk_app_launch_context_set_display(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_app_launch_context_get_type();
		static d_gdk_app_launch_context_get_type gdk_app_launch_context_get_type = FuncLoader.LoadFunction<d_gdk_app_launch_context_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_app_launch_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_app_launch_context_set_desktop(IntPtr raw, int desktop);
		static d_gdk_app_launch_context_set_desktop gdk_app_launch_context_set_desktop = FuncLoader.LoadFunction<d_gdk_app_launch_context_set_desktop>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_set_desktop"));

		public int Desktop { 
			set {
				gdk_app_launch_context_set_desktop(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_app_launch_context_set_icon(IntPtr raw, IntPtr icon);
		static d_gdk_app_launch_context_set_icon gdk_app_launch_context_set_icon = FuncLoader.LoadFunction<d_gdk_app_launch_context_set_icon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_set_icon"));

		public GLib.IIcon Icon { 
			set {
				gdk_app_launch_context_set_icon(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.IconAdapter).Handle));
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_app_launch_context_set_icon_name(IntPtr raw, IntPtr icon_name);
		static d_gdk_app_launch_context_set_icon_name gdk_app_launch_context_set_icon_name = FuncLoader.LoadFunction<d_gdk_app_launch_context_set_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_set_icon_name"));

		public string IconName { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gdk_app_launch_context_set_icon_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_app_launch_context_set_screen(IntPtr raw, IntPtr screen);
		static d_gdk_app_launch_context_set_screen gdk_app_launch_context_set_screen = FuncLoader.LoadFunction<d_gdk_app_launch_context_set_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_set_screen"));

		public Gdk.Screen Screen { 
			set {
				gdk_app_launch_context_set_screen(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_app_launch_context_set_timestamp(IntPtr raw, uint timestamp);
		static d_gdk_app_launch_context_set_timestamp gdk_app_launch_context_set_timestamp = FuncLoader.LoadFunction<d_gdk_app_launch_context_set_timestamp>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_app_launch_context_set_timestamp"));

		public uint Timestamp { 
			set {
				gdk_app_launch_context_set_timestamp(Handle, value);
			}
		}

#endregion
	}
}
