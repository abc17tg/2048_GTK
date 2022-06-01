// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class InstallMissingMediaPluginsPermissionRequest : GLib.Object, WebKit.IPermissionRequest {

		public InstallMissingMediaPluginsPermissionRequest (IntPtr raw) : base(raw) {}

		protected InstallMissingMediaPluginsPermissionRequest() : base(IntPtr.Zero)
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
		delegate IntPtr d_webkit_install_missing_media_plugins_permission_request_get_type();
		static d_webkit_install_missing_media_plugins_permission_request_get_type webkit_install_missing_media_plugins_permission_request_get_type = FuncLoader.LoadFunction<d_webkit_install_missing_media_plugins_permission_request_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_install_missing_media_plugins_permission_request_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_install_missing_media_plugins_permission_request_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_install_missing_media_plugins_permission_request_get_description(IntPtr raw);
		static d_webkit_install_missing_media_plugins_permission_request_get_description webkit_install_missing_media_plugins_permission_request_get_description = FuncLoader.LoadFunction<d_webkit_install_missing_media_plugins_permission_request_get_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_install_missing_media_plugins_permission_request_get_description"));

		public string Description { 
			get {
				IntPtr raw_ret = webkit_install_missing_media_plugins_permission_request_get_description(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_permission_request_allow(IntPtr raw);
		static d_webkit_permission_request_allow webkit_permission_request_allow = FuncLoader.LoadFunction<d_webkit_permission_request_allow>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_permission_request_allow"));

		public void Allow() {
			webkit_permission_request_allow(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_permission_request_deny(IntPtr raw);
		static d_webkit_permission_request_deny webkit_permission_request_deny = FuncLoader.LoadFunction<d_webkit_permission_request_deny>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_permission_request_deny"));

		public void Deny() {
			webkit_permission_request_deny(Handle);
		}


		static InstallMissingMediaPluginsPermissionRequest ()
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
