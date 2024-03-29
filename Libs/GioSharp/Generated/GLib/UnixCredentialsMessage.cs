// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class UnixCredentialsMessage : GLib.SocketControlMessage {

		public UnixCredentialsMessage (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_credentials_message_new();
		static d_g_unix_credentials_message_new g_unix_credentials_message_new = FuncLoader.LoadFunction<d_g_unix_credentials_message_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_credentials_message_new"));

		public UnixCredentialsMessage () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixCredentialsMessage)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_unix_credentials_message_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_credentials_message_new_with_credentials(IntPtr credentials);
		static d_g_unix_credentials_message_new_with_credentials g_unix_credentials_message_new_with_credentials = FuncLoader.LoadFunction<d_g_unix_credentials_message_new_with_credentials>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_credentials_message_new_with_credentials"));

		public UnixCredentialsMessage (GLib.Credentials credentials) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixCredentialsMessage)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (credentials != null) {
					names.Add ("credentials");
					vals.Add (new GLib.Value (credentials));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_unix_credentials_message_new_with_credentials(credentials == null ? IntPtr.Zero : credentials.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_credentials_message_get_credentials(IntPtr raw);
		static d_g_unix_credentials_message_get_credentials g_unix_credentials_message_get_credentials = FuncLoader.LoadFunction<d_g_unix_credentials_message_get_credentials>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_credentials_message_get_credentials"));

		[GLib.Property ("credentials")]
		public GLib.Credentials Credentials {
			get  {
				IntPtr raw_ret = g_unix_credentials_message_get_credentials(Handle);
				GLib.Credentials ret = GLib.Object.GetObject(raw_ret) as GLib.Credentials;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_credentials_message_get_type();
		static d_g_unix_credentials_message_get_type g_unix_credentials_message_get_type = FuncLoader.LoadFunction<d_g_unix_credentials_message_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_credentials_message_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_credentials_message_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_unix_credentials_message_is_supported();
		static d_g_unix_credentials_message_is_supported g_unix_credentials_message_is_supported = FuncLoader.LoadFunction<d_g_unix_credentials_message_is_supported>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_credentials_message_is_supported"));

		public static bool IsSupported { 
			get {
				bool raw_ret = g_unix_credentials_message_is_supported();
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
