// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SrvTarget : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_srv_target_copy(IntPtr raw);
		static d_g_srv_target_copy g_srv_target_copy = FuncLoader.LoadFunction<d_g_srv_target_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_copy"));

		public GLib.SrvTarget Copy() {
			IntPtr raw_ret = g_srv_target_copy(Handle);
			GLib.SrvTarget ret = raw_ret == IntPtr.Zero ? null : (GLib.SrvTarget) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.SrvTarget), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_srv_target_get_hostname(IntPtr raw);
		static d_g_srv_target_get_hostname g_srv_target_get_hostname = FuncLoader.LoadFunction<d_g_srv_target_get_hostname>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_get_hostname"));

		public string Hostname { 
			get {
				IntPtr raw_ret = g_srv_target_get_hostname(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ushort d_g_srv_target_get_port(IntPtr raw);
		static d_g_srv_target_get_port g_srv_target_get_port = FuncLoader.LoadFunction<d_g_srv_target_get_port>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_get_port"));

		public ushort Port { 
			get {
				ushort raw_ret = g_srv_target_get_port(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ushort d_g_srv_target_get_priority(IntPtr raw);
		static d_g_srv_target_get_priority g_srv_target_get_priority = FuncLoader.LoadFunction<d_g_srv_target_get_priority>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_get_priority"));

		public ushort Priority { 
			get {
				ushort raw_ret = g_srv_target_get_priority(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_srv_target_get_type();
		static d_g_srv_target_get_type g_srv_target_get_type = FuncLoader.LoadFunction<d_g_srv_target_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_srv_target_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ushort d_g_srv_target_get_weight(IntPtr raw);
		static d_g_srv_target_get_weight g_srv_target_get_weight = FuncLoader.LoadFunction<d_g_srv_target_get_weight>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_get_weight"));

		public ushort Weight { 
			get {
				ushort raw_ret = g_srv_target_get_weight(Handle);
				ushort ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_srv_target_list_sort(IntPtr targets);
		static d_g_srv_target_list_sort g_srv_target_list_sort = FuncLoader.LoadFunction<d_g_srv_target_list_sort>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_list_sort"));

		public static GLib.SrvTarget[] ListSort(GLib.List targets) {
			IntPtr raw_ret = g_srv_target_list_sort(targets == null ? IntPtr.Zero : targets.Handle);
			GLib.SrvTarget[] ret = GLib.Marshaller.ListPtrToArray<GLib.SrvTarget, GLib.SrvTarget> (raw_ret, false, false);
			return ret;
		}

		public SrvTarget(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_srv_target_new(IntPtr hostname, ushort port, ushort priority, ushort weight);
		static d_g_srv_target_new g_srv_target_new = FuncLoader.LoadFunction<d_g_srv_target_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_new"));

		public SrvTarget (string hostname, ushort port, ushort priority, ushort weight) 
		{
			IntPtr native_hostname = GLib.Marshaller.StringToPtrGStrdup (hostname);
			Raw = g_srv_target_new(native_hostname, port, priority, weight);
			GLib.Marshaller.Free (native_hostname);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_srv_target_free(IntPtr raw);
		static d_g_srv_target_free g_srv_target_free = FuncLoader.LoadFunction<d_g_srv_target_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_srv_target_free"));

		protected override void Free (IntPtr raw)
		{
			g_srv_target_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				g_srv_target_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~SrvTarget ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
