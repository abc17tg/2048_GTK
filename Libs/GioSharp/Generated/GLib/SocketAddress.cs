// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class SocketAddress : GLib.Object {

		public SocketAddress (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_socket_address_new_from_native(IntPtr native, UIntPtr len);
		static d_g_socket_address_new_from_native g_socket_address_new_from_native = FuncLoader.LoadFunction<d_g_socket_address_new_from_native>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_address_new_from_native"));

		public SocketAddress (IntPtr native, ulong len) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SocketAddress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_socket_address_new_from_native(native, new UIntPtr (len));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_socket_address_get_family(IntPtr raw);
		static d_g_socket_address_get_family g_socket_address_get_family = FuncLoader.LoadFunction<d_g_socket_address_get_family>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_address_get_family"));

		[GLib.Property ("family")]
		public GLib.SocketFamily Family {
			get  {
				int raw_ret = g_socket_address_get_family(Handle);
				GLib.SocketFamily ret = (GLib.SocketFamily) raw_ret;
				return ret;
			}
		}

		static GetFamilyNativeDelegate GetFamily_cb_delegate;
		static GetFamilyNativeDelegate GetFamilyVMCallback {
			get {
				if (GetFamily_cb_delegate == null)
					GetFamily_cb_delegate = new GetFamilyNativeDelegate (GetFamily_cb);
				return GetFamily_cb_delegate;
			}
		}

		static void OverrideGetFamily (GLib.GType gtype)
		{
			OverrideGetFamily (gtype, GetFamilyVMCallback);
		}

		static void OverrideGetFamily (GLib.GType gtype, GetFamilyNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_family"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetFamilyNativeDelegate (IntPtr inst);

		static int GetFamily_cb (IntPtr inst)
		{
			try {
				SocketAddress __obj = GLib.Object.GetObject (inst, false) as SocketAddress;
				GLib.SocketFamily __result;
				__result = __obj.OnGetFamily ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketAddress), ConnectionMethod="OverrideGetFamily")]
		protected virtual GLib.SocketFamily OnGetFamily ()
		{
			return InternalGetFamily ();
		}

		private GLib.SocketFamily InternalGetFamily ()
		{
			GetFamilyNativeDelegate unmanaged = class_abi.BaseOverride<GetFamilyNativeDelegate>(this.LookupGType(), "get_family");
			if (unmanaged == null) return (GLib.SocketFamily) 0;

			int __result = unmanaged (this.Handle);
			return (GLib.SocketFamily) __result;
		}

		static GetNativeSizeNativeDelegate GetNativeSize_cb_delegate;
		static GetNativeSizeNativeDelegate GetNativeSizeVMCallback {
			get {
				if (GetNativeSize_cb_delegate == null)
					GetNativeSize_cb_delegate = new GetNativeSizeNativeDelegate (GetNativeSize_cb);
				return GetNativeSize_cb_delegate;
			}
		}

		static void OverrideGetNativeSize (GLib.GType gtype)
		{
			OverrideGetNativeSize (gtype, GetNativeSizeVMCallback);
		}

		static void OverrideGetNativeSize (GLib.GType gtype, GetNativeSizeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_native_size"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetNativeSizeNativeDelegate (IntPtr inst);

		static IntPtr GetNativeSize_cb (IntPtr inst)
		{
			try {
				SocketAddress __obj = GLib.Object.GetObject (inst, false) as SocketAddress;
				long __result;
				__result = __obj.OnGetNativeSize ();
				return new IntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketAddress), ConnectionMethod="OverrideGetNativeSize")]
		protected virtual long OnGetNativeSize ()
		{
			return InternalGetNativeSize ();
		}

		private long InternalGetNativeSize ()
		{
			GetNativeSizeNativeDelegate unmanaged = class_abi.BaseOverride<GetNativeSizeNativeDelegate>(this.LookupGType(), "get_native_size");
			if (unmanaged == null) return 0L;

			IntPtr __result = unmanaged (this.Handle);
			return (long) __result;
		}

		static ToNativeNativeDelegate ToNative_cb_delegate;
		static ToNativeNativeDelegate ToNativeVMCallback {
			get {
				if (ToNative_cb_delegate == null)
					ToNative_cb_delegate = new ToNativeNativeDelegate (ToNative_cb);
				return ToNative_cb_delegate;
			}
		}

		static void OverrideToNative (GLib.GType gtype)
		{
			OverrideToNative (gtype, ToNativeVMCallback);
		}

		static void OverrideToNative (GLib.GType gtype, ToNativeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("to_native"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ToNativeNativeDelegate (IntPtr inst, IntPtr dest, UIntPtr destlen, out IntPtr error);

		static bool ToNative_cb (IntPtr inst, IntPtr dest, UIntPtr destlen, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				SocketAddress __obj = GLib.Object.GetObject (inst, false) as SocketAddress;
				bool __result;
				__result = __obj.OnToNative (dest, (ulong) destlen);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketAddress), ConnectionMethod="OverrideToNative")]
		protected virtual bool OnToNative (IntPtr dest, ulong destlen)
		{
			return InternalToNative (dest, destlen);
		}

		private bool InternalToNative (IntPtr dest, ulong destlen)
		{
			ToNativeNativeDelegate unmanaged = class_abi.BaseOverride<ToNativeNativeDelegate>(this.LookupGType(), "to_native");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, dest, new UIntPtr (destlen), out error);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_family"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // get_family
							, null
							, "get_native_size"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_native_size"
							, -1
							, (uint) sizeof( IntPtr ) // get_native_size
							, "get_family"
							, "to_native"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("to_native"
							, -1
							, (uint) sizeof( IntPtr ) // to_native
							, "get_native_size"
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
		delegate IntPtr d_g_socket_address_get_native_size(IntPtr raw);
		static d_g_socket_address_get_native_size g_socket_address_get_native_size = FuncLoader.LoadFunction<d_g_socket_address_get_native_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_address_get_native_size"));

		public long NativeSize { 
			get {
				IntPtr raw_ret = g_socket_address_get_native_size(Handle);
				long ret = (long) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_socket_address_get_type();
		static d_g_socket_address_get_type g_socket_address_get_type = FuncLoader.LoadFunction<d_g_socket_address_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_address_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_socket_address_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_socket_address_to_native(IntPtr raw, IntPtr dest, UIntPtr destlen, out IntPtr error);
		static d_g_socket_address_to_native g_socket_address_to_native = FuncLoader.LoadFunction<d_g_socket_address_to_native>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_socket_address_to_native"));

		public unsafe bool ToNative(IntPtr dest, ulong destlen) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_socket_address_to_native(Handle, dest, new UIntPtr (destlen), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
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
