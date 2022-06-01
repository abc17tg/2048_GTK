// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct WebViewSessionState : IEquatable<WebViewSessionState> {


		public static WebKit.WebViewSessionState Zero = new WebKit.WebViewSessionState ();

		public static WebKit.WebViewSessionState New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return WebKit.WebViewSessionState.Zero;
			return (WebKit.WebViewSessionState) Marshal.PtrToStructure (raw, typeof (WebKit.WebViewSessionState));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_web_view_session_state_new(IntPtr data);
		static d_webkit_web_view_session_state_new webkit_web_view_session_state_new = FuncLoader.LoadFunction<d_webkit_web_view_session_state_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_web_view_session_state_new"));

		public static WebViewSessionState New(GLib.Bytes data)
		{
			WebViewSessionState result = WebViewSessionState.New (webkit_web_view_session_state_new(data == null ? IntPtr.Zero : data.Handle));
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_web_view_session_state_get_type();
		static d_webkit_web_view_session_state_get_type webkit_web_view_session_state_get_type = FuncLoader.LoadFunction<d_webkit_web_view_session_state_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_web_view_session_state_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_web_view_session_state_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_web_view_session_state_ref(IntPtr raw);
		static d_webkit_web_view_session_state_ref webkit_web_view_session_state_ref = FuncLoader.LoadFunction<d_webkit_web_view_session_state_ref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_web_view_session_state_ref"));

		public WebKit.WebViewSessionState Ref() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.WebViewSessionState>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = webkit_web_view_session_state_ref(this_as_native);
			WebKit.WebViewSessionState ret = WebKit.WebViewSessionState.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_web_view_session_state_serialize(IntPtr raw);
		static d_webkit_web_view_session_state_serialize webkit_web_view_session_state_serialize = FuncLoader.LoadFunction<d_webkit_web_view_session_state_serialize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_web_view_session_state_serialize"));

		public GLib.Bytes Serialize() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.WebViewSessionState>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = webkit_web_view_session_state_serialize(this_as_native);
			GLib.Bytes ret = new GLib.Bytes(raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_web_view_session_state_unref(IntPtr raw);
		static d_webkit_web_view_session_state_unref webkit_web_view_session_state_unref = FuncLoader.LoadFunction<d_webkit_web_view_session_state_unref>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_web_view_session_state_unref"));

		public void Unref() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.WebViewSessionState>());
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			webkit_web_view_session_state_unref(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref WebKit.WebViewSessionState target)
		{
			target = New (native);
		}

		public bool Equals (WebViewSessionState other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is WebViewSessionState && Equals ((WebViewSessionState) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (WebKit.WebViewSessionState boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (WebKit.WebViewSessionState.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator WebKit.WebViewSessionState (GLib.Value val)
		{
			return (WebKit.WebViewSessionState) val.Val;
		}
#endregion
	}
}
