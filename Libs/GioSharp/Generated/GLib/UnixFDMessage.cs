// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class UnixFDMessage : GLib.SocketControlMessage {

		public UnixFDMessage (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_fd_message_new();
		static d_g_unix_fd_message_new g_unix_fd_message_new = FuncLoader.LoadFunction<d_g_unix_fd_message_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_fd_message_new"));

		public UnixFDMessage () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixFDMessage)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_unix_fd_message_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_fd_message_new_with_fd_list(IntPtr fd_list);
		static d_g_unix_fd_message_new_with_fd_list g_unix_fd_message_new_with_fd_list = FuncLoader.LoadFunction<d_g_unix_fd_message_new_with_fd_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_fd_message_new_with_fd_list"));

		public UnixFDMessage (GLib.UnixFDList fd_list) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UnixFDMessage)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (fd_list != null) {
					names.Add ("fd_list");
					vals.Add (new GLib.Value (fd_list));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_unix_fd_message_new_with_fd_list(fd_list == null ? IntPtr.Zero : fd_list.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_fd_message_get_fd_list(IntPtr raw);
		static d_g_unix_fd_message_get_fd_list g_unix_fd_message_get_fd_list = FuncLoader.LoadFunction<d_g_unix_fd_message_get_fd_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_fd_message_get_fd_list"));

		[GLib.Property ("fd-list")]
		public GLib.UnixFDList FdList {
			get  {
				IntPtr raw_ret = g_unix_fd_message_get_fd_list(Handle);
				GLib.UnixFDList ret = GLib.Object.GetObject(raw_ret) as GLib.UnixFDList;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_unix_fd_message_append_fd(IntPtr raw, int fd, out IntPtr error);
		static d_g_unix_fd_message_append_fd g_unix_fd_message_append_fd = FuncLoader.LoadFunction<d_g_unix_fd_message_append_fd>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_fd_message_append_fd"));

		public unsafe bool AppendFd(int fd) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_unix_fd_message_append_fd(Handle, fd, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_unix_fd_message_get_type();
		static d_g_unix_fd_message_get_type g_unix_fd_message_get_type = FuncLoader.LoadFunction<d_g_unix_fd_message_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_fd_message_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_fd_message_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_unix_fd_message_steal_fds(IntPtr raw, out int length);
		static d_g_unix_fd_message_steal_fds g_unix_fd_message_steal_fds = FuncLoader.LoadFunction<d_g_unix_fd_message_steal_fds>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_unix_fd_message_steal_fds"));

		public int StealFds(out int length) {
			int raw_ret = g_unix_fd_message_steal_fds(Handle, out length);
			int ret = raw_ret;
			return ret;
		}

#endregion
	}
}
