// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Socks5Proxy : GLib.Object, GLib.IProxy {

		public Socks5Proxy (IntPtr raw) : base(raw) {}

		protected Socks5Proxy() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_proxy_connect(IntPtr raw, IntPtr connection, IntPtr proxy_address, IntPtr cancellable, out IntPtr error);
		static d_g_proxy_connect g_proxy_connect = FuncLoader.LoadFunction<d_g_proxy_connect>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_proxy_connect"));

		public GLib.IOStream Connect(GLib.IOStream connection, GLib.ProxyAddress proxy_address, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_proxy_connect(Handle, connection == null ? IntPtr.Zero : connection.Handle, proxy_address == null ? IntPtr.Zero : proxy_address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.IOStream ret = GLib.Object.GetObject(raw_ret) as GLib.IOStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_proxy_connect_async(IntPtr raw, IntPtr connection, IntPtr proxy_address, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_proxy_connect_async g_proxy_connect_async = FuncLoader.LoadFunction<d_g_proxy_connect_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_proxy_connect_async"));

		public void ConnectAsync(GLib.IOStream connection, GLib.ProxyAddress proxy_address, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_proxy_connect_async(Handle, connection == null ? IntPtr.Zero : connection.Handle, proxy_address == null ? IntPtr.Zero : proxy_address.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_proxy_connect_finish(IntPtr raw, IntPtr result, out IntPtr error);
		static d_g_proxy_connect_finish g_proxy_connect_finish = FuncLoader.LoadFunction<d_g_proxy_connect_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_proxy_connect_finish"));

		public GLib.IOStream ConnectFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_proxy_connect_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.IOStream ret = GLib.Object.GetObject(raw_ret) as GLib.IOStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_proxy_supports_hostname(IntPtr raw);
		static d_g_proxy_supports_hostname g_proxy_supports_hostname = FuncLoader.LoadFunction<d_g_proxy_supports_hostname>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_proxy_supports_hostname"));

		public bool SupportsHostname() {
			bool raw_ret = g_proxy_supports_hostname(Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
