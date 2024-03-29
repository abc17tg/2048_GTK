// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class URIRequest : GLib.Object {

		public URIRequest (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_uri_request_new(IntPtr uri);
		static d_webkit_uri_request_new webkit_uri_request_new = FuncLoader.LoadFunction<d_webkit_uri_request_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_uri_request_new"));

		public URIRequest (string uri) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (URIRequest)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("uri");
				vals.Add (new GLib.Value (uri));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			Raw = webkit_uri_request_new(native_uri);
			GLib.Marshaller.Free (native_uri);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_uri_request_get_uri(IntPtr raw);
		static d_webkit_uri_request_get_uri webkit_uri_request_get_uri = FuncLoader.LoadFunction<d_webkit_uri_request_get_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_uri_request_get_uri"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_uri_request_set_uri(IntPtr raw, IntPtr uri);
		static d_webkit_uri_request_set_uri webkit_uri_request_set_uri = FuncLoader.LoadFunction<d_webkit_uri_request_set_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_uri_request_set_uri"));

		[GLib.Property ("uri")]
		public string Uri {
			get  {
				IntPtr raw_ret = webkit_uri_request_get_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				webkit_uri_request_set_uri(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_webkit_reserved0"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _webkit_reserved0
							, null
							, "_webkit_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved1
							, "_webkit_reserved0"
							, "_webkit_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved2
							, "_webkit_reserved1"
							, "_webkit_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved3
							, "_webkit_reserved2"
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_uri_request_get_type();
		static d_webkit_uri_request_get_type webkit_uri_request_get_type = FuncLoader.LoadFunction<d_webkit_uri_request_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_uri_request_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_uri_request_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_uri_request_get_http_method(IntPtr raw);
		static d_webkit_uri_request_get_http_method webkit_uri_request_get_http_method = FuncLoader.LoadFunction<d_webkit_uri_request_get_http_method>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_uri_request_get_http_method"));

		public string HttpMethod { 
			get {
				IntPtr raw_ret = webkit_uri_request_get_http_method(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}


		static URIRequest ()
		{
			GtkSharp.WebkitGtkSharp.ObjectManager.Initialize ();
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
