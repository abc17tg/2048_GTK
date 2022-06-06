// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class NetworkService : GLib.Object, GLib.ISocketConnectable {

		public NetworkService (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_network_service_new(IntPtr service, IntPtr protocol, IntPtr domain);
		static d_g_network_service_new g_network_service_new = FuncLoader.LoadFunction<d_g_network_service_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_new"));

		public NetworkService (string service, string protocol, string domain) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NetworkService)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("service");
				vals.Add (new GLib.Value (service));
				names.Add ("protocol");
				vals.Add (new GLib.Value (protocol));
				names.Add ("domain");
				vals.Add (new GLib.Value (domain));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_service = GLib.Marshaller.StringToPtrGStrdup (service);
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			IntPtr native_domain = GLib.Marshaller.StringToPtrGStrdup (domain);
			Raw = g_network_service_new(native_service, native_protocol, native_domain);
			GLib.Marshaller.Free (native_service);
			GLib.Marshaller.Free (native_protocol);
			GLib.Marshaller.Free (native_domain);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_network_service_get_service(IntPtr raw);
		static d_g_network_service_get_service g_network_service_get_service = FuncLoader.LoadFunction<d_g_network_service_get_service>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_get_service"));

		[GLib.Property ("service")]
		public string Service {
			get  {
				IntPtr raw_ret = g_network_service_get_service(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_network_service_get_protocol(IntPtr raw);
		static d_g_network_service_get_protocol g_network_service_get_protocol = FuncLoader.LoadFunction<d_g_network_service_get_protocol>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_get_protocol"));

		[GLib.Property ("protocol")]
		public string Protocol {
			get  {
				IntPtr raw_ret = g_network_service_get_protocol(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_network_service_get_domain(IntPtr raw);
		static d_g_network_service_get_domain g_network_service_get_domain = FuncLoader.LoadFunction<d_g_network_service_get_domain>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_get_domain"));

		[GLib.Property ("domain")]
		public string Domain {
			get  {
				IntPtr raw_ret = g_network_service_get_domain(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_network_service_get_scheme(IntPtr raw);
		static d_g_network_service_get_scheme g_network_service_get_scheme = FuncLoader.LoadFunction<d_g_network_service_get_scheme>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_get_scheme"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_network_service_set_scheme(IntPtr raw, IntPtr scheme);
		static d_g_network_service_set_scheme g_network_service_set_scheme = FuncLoader.LoadFunction<d_g_network_service_set_scheme>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_set_scheme"));

		[GLib.Property ("scheme")]
		public string Scheme {
			get  {
				IntPtr raw_ret = g_network_service_get_scheme(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_network_service_set_scheme(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
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
		delegate IntPtr d_g_network_service_get_type();
		static d_g_network_service_get_type g_network_service_get_type = FuncLoader.LoadFunction<d_g_network_service_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_network_service_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_network_service_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_socket_connectable_enumerate(IntPtr raw);
		static d_g_socket_connectable_enumerate g_socket_connectable_enumerate = FuncLoader.LoadFunction<d_g_socket_connectable_enumerate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_connectable_enumerate"));

		public GLib.SocketAddressEnumerator Enumerate() {
			IntPtr raw_ret = g_socket_connectable_enumerate(Handle);
			GLib.SocketAddressEnumerator ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddressEnumerator;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_socket_connectable_proxy_enumerate(IntPtr raw);
		static d_g_socket_connectable_proxy_enumerate g_socket_connectable_proxy_enumerate = FuncLoader.LoadFunction<d_g_socket_connectable_proxy_enumerate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_connectable_proxy_enumerate"));

		public GLib.SocketAddressEnumerator ProxyEnumerate() {
			IntPtr raw_ret = g_socket_connectable_proxy_enumerate(Handle);
			GLib.SocketAddressEnumerator ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddressEnumerator;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_socket_connectable_to_string(IntPtr raw);
		static d_g_socket_connectable_to_string g_socket_connectable_to_string = FuncLoader.LoadFunction<d_g_socket_connectable_to_string>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_connectable_to_string"));

		public override string ToString() {
			IntPtr raw_ret = g_socket_connectable_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
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