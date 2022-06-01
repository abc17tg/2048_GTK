// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class SecurityManager : GLib.Object {

		public SecurityManager (IntPtr raw) : base(raw) {}

		protected SecurityManager() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
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
		delegate IntPtr d_webkit_security_manager_get_type();
		static d_webkit_security_manager_get_type webkit_security_manager_get_type = FuncLoader.LoadFunction<d_webkit_security_manager_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_security_manager_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_security_manager_register_uri_scheme_as_cors_enabled(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_register_uri_scheme_as_cors_enabled webkit_security_manager_register_uri_scheme_as_cors_enabled = FuncLoader.LoadFunction<d_webkit_security_manager_register_uri_scheme_as_cors_enabled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_register_uri_scheme_as_cors_enabled"));

		public void RegisterUriSchemeAsCorsEnabled(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			webkit_security_manager_register_uri_scheme_as_cors_enabled(Handle, native_scheme);
			GLib.Marshaller.Free (native_scheme);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_security_manager_register_uri_scheme_as_display_isolated(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_register_uri_scheme_as_display_isolated webkit_security_manager_register_uri_scheme_as_display_isolated = FuncLoader.LoadFunction<d_webkit_security_manager_register_uri_scheme_as_display_isolated>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_register_uri_scheme_as_display_isolated"));

		public void RegisterUriSchemeAsDisplayIsolated(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			webkit_security_manager_register_uri_scheme_as_display_isolated(Handle, native_scheme);
			GLib.Marshaller.Free (native_scheme);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_security_manager_register_uri_scheme_as_empty_document(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_register_uri_scheme_as_empty_document webkit_security_manager_register_uri_scheme_as_empty_document = FuncLoader.LoadFunction<d_webkit_security_manager_register_uri_scheme_as_empty_document>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_register_uri_scheme_as_empty_document"));

		public void RegisterUriSchemeAsEmptyDocument(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			webkit_security_manager_register_uri_scheme_as_empty_document(Handle, native_scheme);
			GLib.Marshaller.Free (native_scheme);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_security_manager_register_uri_scheme_as_local(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_register_uri_scheme_as_local webkit_security_manager_register_uri_scheme_as_local = FuncLoader.LoadFunction<d_webkit_security_manager_register_uri_scheme_as_local>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_register_uri_scheme_as_local"));

		public void RegisterUriSchemeAsLocal(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			webkit_security_manager_register_uri_scheme_as_local(Handle, native_scheme);
			GLib.Marshaller.Free (native_scheme);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_security_manager_register_uri_scheme_as_no_access(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_register_uri_scheme_as_no_access webkit_security_manager_register_uri_scheme_as_no_access = FuncLoader.LoadFunction<d_webkit_security_manager_register_uri_scheme_as_no_access>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_register_uri_scheme_as_no_access"));

		public void RegisterUriSchemeAsNoAccess(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			webkit_security_manager_register_uri_scheme_as_no_access(Handle, native_scheme);
			GLib.Marshaller.Free (native_scheme);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_security_manager_register_uri_scheme_as_secure(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_register_uri_scheme_as_secure webkit_security_manager_register_uri_scheme_as_secure = FuncLoader.LoadFunction<d_webkit_security_manager_register_uri_scheme_as_secure>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_register_uri_scheme_as_secure"));

		public void RegisterUriSchemeAsSecure(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			webkit_security_manager_register_uri_scheme_as_secure(Handle, native_scheme);
			GLib.Marshaller.Free (native_scheme);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_security_manager_uri_scheme_is_cors_enabled(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_uri_scheme_is_cors_enabled webkit_security_manager_uri_scheme_is_cors_enabled = FuncLoader.LoadFunction<d_webkit_security_manager_uri_scheme_is_cors_enabled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_uri_scheme_is_cors_enabled"));

		public bool UriSchemeIsCorsEnabled(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = webkit_security_manager_uri_scheme_is_cors_enabled(Handle, native_scheme);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_security_manager_uri_scheme_is_display_isolated(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_uri_scheme_is_display_isolated webkit_security_manager_uri_scheme_is_display_isolated = FuncLoader.LoadFunction<d_webkit_security_manager_uri_scheme_is_display_isolated>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_uri_scheme_is_display_isolated"));

		public bool UriSchemeIsDisplayIsolated(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = webkit_security_manager_uri_scheme_is_display_isolated(Handle, native_scheme);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_security_manager_uri_scheme_is_empty_document(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_uri_scheme_is_empty_document webkit_security_manager_uri_scheme_is_empty_document = FuncLoader.LoadFunction<d_webkit_security_manager_uri_scheme_is_empty_document>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_uri_scheme_is_empty_document"));

		public bool UriSchemeIsEmptyDocument(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = webkit_security_manager_uri_scheme_is_empty_document(Handle, native_scheme);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_security_manager_uri_scheme_is_local(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_uri_scheme_is_local webkit_security_manager_uri_scheme_is_local = FuncLoader.LoadFunction<d_webkit_security_manager_uri_scheme_is_local>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_uri_scheme_is_local"));

		public bool UriSchemeIsLocal(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = webkit_security_manager_uri_scheme_is_local(Handle, native_scheme);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_security_manager_uri_scheme_is_no_access(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_uri_scheme_is_no_access webkit_security_manager_uri_scheme_is_no_access = FuncLoader.LoadFunction<d_webkit_security_manager_uri_scheme_is_no_access>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_uri_scheme_is_no_access"));

		public bool UriSchemeIsNoAccess(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = webkit_security_manager_uri_scheme_is_no_access(Handle, native_scheme);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_security_manager_uri_scheme_is_secure(IntPtr raw, IntPtr scheme);
		static d_webkit_security_manager_uri_scheme_is_secure webkit_security_manager_uri_scheme_is_secure = FuncLoader.LoadFunction<d_webkit_security_manager_uri_scheme_is_secure>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_security_manager_uri_scheme_is_secure"));

		public bool UriSchemeIsSecure(string scheme) {
			IntPtr native_scheme = GLib.Marshaller.StringToPtrGStrdup (scheme);
			bool raw_ret = webkit_security_manager_uri_scheme_is_secure(Handle, native_scheme);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_scheme);
			return ret;
		}


		static SecurityManager ()
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
