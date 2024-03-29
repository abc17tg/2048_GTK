// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class TcpWrapperConnection : GLib.TcpConnection {

		public TcpWrapperConnection (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tcp_wrapper_connection_new(IntPtr base_io_stream, IntPtr socket);
		static d_g_tcp_wrapper_connection_new g_tcp_wrapper_connection_new = FuncLoader.LoadFunction<d_g_tcp_wrapper_connection_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tcp_wrapper_connection_new"));

		public TcpWrapperConnection (GLib.IOStream base_io_stream, GLib.Socket socket) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TcpWrapperConnection)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (base_io_stream != null) {
					names.Add ("base_io_stream");
					vals.Add (new GLib.Value (base_io_stream));
				}
				if (socket != null) {
					names.Add ("socket");
					vals.Add (new GLib.Value (socket));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_tcp_wrapper_connection_new(base_io_stream == null ? IntPtr.Zero : base_io_stream.Handle, socket == null ? IntPtr.Zero : socket.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tcp_wrapper_connection_get_base_io_stream(IntPtr raw);
		static d_g_tcp_wrapper_connection_get_base_io_stream g_tcp_wrapper_connection_get_base_io_stream = FuncLoader.LoadFunction<d_g_tcp_wrapper_connection_get_base_io_stream>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tcp_wrapper_connection_get_base_io_stream"));

		[GLib.Property ("base-io-stream")]
		public GLib.IOStream BaseIoStream {
			get  {
				IntPtr raw_ret = g_tcp_wrapper_connection_get_base_io_stream(Handle);
				GLib.IOStream ret = GLib.Object.GetObject(raw_ret) as GLib.IOStream;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.TcpConnection.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tcp_wrapper_connection_get_type();
		static d_g_tcp_wrapper_connection_get_type g_tcp_wrapper_connection_get_type = FuncLoader.LoadFunction<d_g_tcp_wrapper_connection_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tcp_wrapper_connection_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_tcp_wrapper_connection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.TcpConnection.abi_info.Fields
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
