// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ApplicationInfo : IEquatable<ApplicationInfo> {


		public static WebKit.ApplicationInfo Zero = new WebKit.ApplicationInfo ();

		public static WebKit.ApplicationInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return WebKit.ApplicationInfo.Zero;
			return (WebKit.ApplicationInfo) Marshal.PtrToStructure (raw, typeof (WebKit.ApplicationInfo));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_application_info_new();
		static d_webkit_application_info_new webkit_application_info_new = FuncLoader.LoadFunction<d_webkit_application_info_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_new"));

		public static ApplicationInfo New()
		{
			ApplicationInfo result = ApplicationInfo.New (webkit_application_info_new());
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_application_info_get_type();
		static d_webkit_application_info_get_type webkit_application_info_get_type = FuncLoader.LoadFunction<d_webkit_application_info_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_application_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_application_info_get_name(IntPtr raw);
		static d_webkit_application_info_get_name webkit_application_info_get_name = FuncLoader.LoadFunction<d_webkit_application_info_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_get_name"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_application_info_set_name(IntPtr raw, IntPtr name);
		static d_webkit_application_info_set_name webkit_application_info_set_name = FuncLoader.LoadFunction<d_webkit_application_info_set_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_set_name"));

		public string Name { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.ApplicationInfo>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = webkit_application_info_get_name(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.ApplicationInfo>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				webkit_application_info_set_name(this_as_native, native_value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_application_info_get_version(IntPtr raw, out ulong major, out ulong minor, out ulong micro);
		static d_webkit_application_info_get_version webkit_application_info_get_version = FuncLoader.LoadFunction<d_webkit_application_info_get_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_get_version"));

		public void GetVersion(out ulong major, out ulong minor, out ulong micro) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.ApplicationInfo>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			webkit_application_info_get_version(this_as_native, out major, out minor, out micro);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_application_info_ref(IntPtr raw);
		static d_webkit_application_info_ref webkit_application_info_ref = FuncLoader.LoadFunction<d_webkit_application_info_ref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_ref"));

		public WebKit.ApplicationInfo Ref() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.ApplicationInfo>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = webkit_application_info_ref(this_as_native);
			WebKit.ApplicationInfo ret = WebKit.ApplicationInfo.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_application_info_set_version(IntPtr raw, ulong major, ulong minor, ulong micro);
		static d_webkit_application_info_set_version webkit_application_info_set_version = FuncLoader.LoadFunction<d_webkit_application_info_set_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_set_version"));

		public void SetVersion(ulong major, ulong minor, ulong micro) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.ApplicationInfo>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			webkit_application_info_set_version(this_as_native, major, minor, micro);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_application_info_unref(IntPtr raw);
		static d_webkit_application_info_unref webkit_application_info_unref = FuncLoader.LoadFunction<d_webkit_application_info_unref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_application_info_unref"));

		public void Unref() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.ApplicationInfo>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			webkit_application_info_unref(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref WebKit.ApplicationInfo target)
		{
			target = New (native);
		}

		public bool Equals (ApplicationInfo other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is ApplicationInfo && Equals ((ApplicationInfo) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (WebKit.ApplicationInfo boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (WebKit.ApplicationInfo.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator WebKit.ApplicationInfo (GLib.Value val)
		{
			return (WebKit.ApplicationInfo) val.Val;
		}
#endregion
	}
}