// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct MimeInfo : IEquatable<MimeInfo> {


		public static WebKit.MimeInfo Zero = new WebKit.MimeInfo ();

		public static WebKit.MimeInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return WebKit.MimeInfo.Zero;
			return (WebKit.MimeInfo) Marshal.PtrToStructure (raw, typeof (WebKit.MimeInfo));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_mime_info_get_type();
		static d_webkit_mime_info_get_type webkit_mime_info_get_type = FuncLoader.LoadFunction<d_webkit_mime_info_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_mime_info_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_mime_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_mime_info_get_description(IntPtr raw);
		static d_webkit_mime_info_get_description webkit_mime_info_get_description = FuncLoader.LoadFunction<d_webkit_mime_info_get_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_mime_info_get_description"));

		[Obsolete]
		public string Description { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.MimeInfo>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = webkit_mime_info_get_description(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_mime_info_get_mime_type(IntPtr raw);
		static d_webkit_mime_info_get_mime_type webkit_mime_info_get_mime_type = FuncLoader.LoadFunction<d_webkit_mime_info_get_mime_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_mime_info_get_mime_type"));

		[Obsolete]
		public string MimeType { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.MimeInfo>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = webkit_mime_info_get_mime_type(this_as_native);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_mime_info_ref(IntPtr raw);
		static d_webkit_mime_info_ref webkit_mime_info_ref = FuncLoader.LoadFunction<d_webkit_mime_info_ref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_mime_info_ref"));

		[Obsolete]
		public WebKit.MimeInfo Ref() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.MimeInfo>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = webkit_mime_info_ref(this_as_native);
			WebKit.MimeInfo ret = WebKit.MimeInfo.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_mime_info_unref(IntPtr raw);
		static d_webkit_mime_info_unref webkit_mime_info_unref = FuncLoader.LoadFunction<d_webkit_mime_info_unref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_mime_info_unref"));

		[Obsolete]
		public void Unref() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.MimeInfo>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			webkit_mime_info_unref(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref WebKit.MimeInfo target)
		{
			target = New (native);
		}

		public bool Equals (MimeInfo other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is MimeInfo && Equals ((MimeInfo) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (WebKit.MimeInfo boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (WebKit.MimeInfo.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator WebKit.MimeInfo (GLib.Value val)
		{
			return (WebKit.MimeInfo) val.Val;
		}
#endregion
	}
}