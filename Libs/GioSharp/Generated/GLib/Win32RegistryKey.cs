// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Win32RegistryKey : GLib.Object, GLib.IInitable {

		public Win32RegistryKey (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_win32_registry_key_new(IntPtr path, out IntPtr error);
		static d_g_win32_registry_key_new g_win32_registry_key_new = FuncLoader.LoadFunction<d_g_win32_registry_key_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_new"));

		public unsafe Win32RegistryKey (string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Win32RegistryKey)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("path");
				vals.Add (new GLib.Value (path));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			Raw = g_win32_registry_key_new(native_path, out error);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_win32_registry_key_get_path(IntPtr raw);
		static d_g_win32_registry_key_get_path g_win32_registry_key_get_path = FuncLoader.LoadFunction<d_g_win32_registry_key_get_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_get_path"));

		[GLib.Property ("path")]
		public string Path {
			get  {
				IntPtr raw_ret = g_win32_registry_key_get_path(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[GLib.Property ("path-utf16")]
		public IntPtr PathUtf16 {
			get {
				GLib.Value val = GetProperty ("path-utf16");
				IntPtr ret = (IntPtr) val;
				val.Dispose ();
				return ret;
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
		delegate void d_g_win32_registry_key_erase_change_indicator(IntPtr raw);
		static d_g_win32_registry_key_erase_change_indicator g_win32_registry_key_erase_change_indicator = FuncLoader.LoadFunction<d_g_win32_registry_key_erase_change_indicator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_erase_change_indicator"));

		public void EraseChangeIndicator() {
			g_win32_registry_key_erase_change_indicator(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_win32_registry_key_get_child(IntPtr raw, IntPtr subkey, out IntPtr error);
		static d_g_win32_registry_key_get_child g_win32_registry_key_get_child = FuncLoader.LoadFunction<d_g_win32_registry_key_get_child>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_get_child"));

		public unsafe GLib.Win32RegistryKey GetChild(string subkey) {
			IntPtr native_subkey = GLib.Marshaller.StringToPtrGStrdup (subkey);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_win32_registry_key_get_child(Handle, native_subkey, out error);
			GLib.Win32RegistryKey ret = GLib.Object.GetObject(raw_ret) as GLib.Win32RegistryKey;
			GLib.Marshaller.Free (native_subkey);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_win32_registry_key_get_type();
		static d_g_win32_registry_key_get_type g_win32_registry_key_get_type = FuncLoader.LoadFunction<d_g_win32_registry_key_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_win32_registry_key_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_win32_registry_key_get_value(IntPtr raw, bool auto_expand, IntPtr value_name, out int value_type, IntPtr value_data, out UIntPtr value_data_size, out IntPtr error);
		static d_g_win32_registry_key_get_value g_win32_registry_key_get_value = FuncLoader.LoadFunction<d_g_win32_registry_key_get_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_get_value"));

		public unsafe bool GetValue(bool auto_expand, string value_name, out GLib.Win32RegistryValueType value_type, IntPtr value_data, out ulong value_data_size) {
			IntPtr native_value_name = GLib.Marshaller.StringToPtrGStrdup (value_name);
			int native_value_type;
			UIntPtr native_value_data_size;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_win32_registry_key_get_value(Handle, auto_expand, native_value_name, out native_value_type, value_data, out native_value_data_size, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_value_name);
			value_type = (GLib.Win32RegistryValueType) native_value_type;
			value_data_size = (ulong) native_value_data_size;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_win32_registry_key_has_changed(IntPtr raw);
		static d_g_win32_registry_key_has_changed g_win32_registry_key_has_changed = FuncLoader.LoadFunction<d_g_win32_registry_key_has_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_has_changed"));

		public bool HasChanged { 
			get {
				bool raw_ret = g_win32_registry_key_has_changed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_win32_registry_key_watch(IntPtr raw, bool watch_children, int watch_flags, GLibSharp.Win32RegistryKeyWatchCallbackFuncNative cb, IntPtr user_data, out IntPtr error);
		static d_g_win32_registry_key_watch g_win32_registry_key_watch = FuncLoader.LoadFunction<d_g_win32_registry_key_watch>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_win32_registry_key_watch"));

		public unsafe bool Watch(bool watch_children, GLib.Win32RegistryKeyWatcherFlags watch_flags, GLib.Win32RegistryKeyWatchCallbackFunc cb) {
			GLibSharp.Win32RegistryKeyWatchCallbackFuncWrapper cb_wrapper = new GLibSharp.Win32RegistryKeyWatchCallbackFuncWrapper (cb);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_win32_registry_key_watch(Handle, watch_children, (int) watch_flags, cb_wrapper.NativeDelegate, IntPtr.Zero, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_initable_init(IntPtr raw, IntPtr cancellable, out IntPtr error);
		static d_g_initable_init g_initable_init = FuncLoader.LoadFunction<d_g_initable_init>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_initable_init"));

		public bool Init(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_initable_init(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
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
