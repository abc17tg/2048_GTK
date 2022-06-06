// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ThemedIcon : GLib.Object, GLib.IIcon {

		public ThemedIcon (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_themed_icon_new(IntPtr iconname);
		static d_g_themed_icon_new g_themed_icon_new = FuncLoader.LoadFunction<d_g_themed_icon_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_new"));

		public ThemedIcon (string iconname) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ThemedIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_iconname = GLib.Marshaller.StringToPtrGStrdup (iconname);
			Raw = g_themed_icon_new(native_iconname);
			GLib.Marshaller.Free (native_iconname);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_themed_icon_new_from_names(IntPtr iconnames, int len);
		static d_g_themed_icon_new_from_names g_themed_icon_new_from_names = FuncLoader.LoadFunction<d_g_themed_icon_new_from_names>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_new_from_names"));

		public static ThemedIcon NewFromNames(string iconnames)
		{
			ThemedIcon result = new ThemedIcon (g_themed_icon_new_from_names(GLib.Marshaller.StringToPtrGStrdup(iconnames), System.Text.Encoding.UTF8.GetByteCount (iconnames)));
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_themed_icon_new_with_default_fallbacks(IntPtr iconname);
		static d_g_themed_icon_new_with_default_fallbacks g_themed_icon_new_with_default_fallbacks = FuncLoader.LoadFunction<d_g_themed_icon_new_with_default_fallbacks>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_new_with_default_fallbacks"));

		public static ThemedIcon NewWithDefaultFallbacks(string iconname)
		{
			IntPtr native_iconname = GLib.Marshaller.StringToPtrGStrdup (iconname);
			ThemedIcon result = new ThemedIcon (g_themed_icon_new_with_default_fallbacks(native_iconname));
			GLib.Marshaller.Free (native_iconname);
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_themed_icon_get_names(IntPtr raw);
		static d_g_themed_icon_get_names g_themed_icon_get_names = FuncLoader.LoadFunction<d_g_themed_icon_get_names>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_get_names"));

		[GLib.Property ("names")]
		public string[] Names {
			get  {
				IntPtr raw_ret = g_themed_icon_get_names(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[GLib.Property ("use-default-fallbacks")]
		public bool UseDefaultFallbacks {
			get {
				GLib.Value val = GetProperty ("use-default-fallbacks");
				bool ret = (bool) val;
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
		delegate void d_g_themed_icon_append_name(IntPtr raw, IntPtr iconname);
		static d_g_themed_icon_append_name g_themed_icon_append_name = FuncLoader.LoadFunction<d_g_themed_icon_append_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_append_name"));

		public void AppendName(string iconname) {
			IntPtr native_iconname = GLib.Marshaller.StringToPtrGStrdup (iconname);
			g_themed_icon_append_name(Handle, native_iconname);
			GLib.Marshaller.Free (native_iconname);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_themed_icon_get_type();
		static d_g_themed_icon_get_type g_themed_icon_get_type = FuncLoader.LoadFunction<d_g_themed_icon_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_themed_icon_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_themed_icon_prepend_name(IntPtr raw, IntPtr iconname);
		static d_g_themed_icon_prepend_name g_themed_icon_prepend_name = FuncLoader.LoadFunction<d_g_themed_icon_prepend_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_themed_icon_prepend_name"));

		public void PrependName(string iconname) {
			IntPtr native_iconname = GLib.Marshaller.StringToPtrGStrdup (iconname);
			g_themed_icon_prepend_name(Handle, native_iconname);
			GLib.Marshaller.Free (native_iconname);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_icon_equal(IntPtr raw, IntPtr icon2);
		static d_g_icon_equal g_icon_equal = FuncLoader.LoadFunction<d_g_icon_equal>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_icon_equal"));

		public bool Equal(GLib.IIcon icon2) {
			bool raw_ret = g_icon_equal(Handle, icon2 == null ? IntPtr.Zero : ((icon2 is GLib.Object) ? (icon2 as GLib.Object).Handle : (icon2 as GLib.IconAdapter).Handle));
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_icon_serialize(IntPtr raw);
		static d_g_icon_serialize g_icon_serialize = FuncLoader.LoadFunction<d_g_icon_serialize>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_icon_serialize"));

		public GLib.Variant Serialize() {
			IntPtr raw_ret = g_icon_serialize(Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_icon_to_string(IntPtr raw);
		static d_g_icon_to_string g_icon_to_string = FuncLoader.LoadFunction<d_g_icon_to_string>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_icon_to_string"));

		public override string ToString() {
			IntPtr raw_ret = g_icon_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
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