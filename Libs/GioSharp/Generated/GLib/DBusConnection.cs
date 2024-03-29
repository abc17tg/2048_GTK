// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DBusConnection : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_g_dbus_connection_export_action_group(IntPtr raw, IntPtr object_path, IntPtr action_group, out IntPtr error);
		static d_g_dbus_connection_export_action_group g_dbus_connection_export_action_group = FuncLoader.LoadFunction<d_g_dbus_connection_export_action_group>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_dbus_connection_export_action_group"));

		public unsafe uint ExportActionGroup(string object_path, GLib.IActionGroup action_group) {
			IntPtr native_object_path = GLib.Marshaller.StringToPtrGStrdup (object_path);
			IntPtr error = IntPtr.Zero;
			uint raw_ret = g_dbus_connection_export_action_group(Handle, native_object_path, action_group == null ? IntPtr.Zero : ((action_group is GLib.Object) ? (action_group as GLib.Object).Handle : (action_group as GLib.ActionGroupAdapter).Handle), out error);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_object_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_g_dbus_connection_export_menu_model(IntPtr raw, IntPtr object_path, IntPtr menu, out IntPtr error);
		static d_g_dbus_connection_export_menu_model g_dbus_connection_export_menu_model = FuncLoader.LoadFunction<d_g_dbus_connection_export_menu_model>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_dbus_connection_export_menu_model"));

		public unsafe uint ExportMenuModel(string object_path, GLib.MenuModel menu) {
			IntPtr native_object_path = GLib.Marshaller.StringToPtrGStrdup (object_path);
			IntPtr error = IntPtr.Zero;
			uint raw_ret = g_dbus_connection_export_menu_model(Handle, native_object_path, menu == null ? IntPtr.Zero : menu.Handle, out error);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_object_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_dbus_connection_unexport_action_group(IntPtr raw, uint export_id);
		static d_g_dbus_connection_unexport_action_group g_dbus_connection_unexport_action_group = FuncLoader.LoadFunction<d_g_dbus_connection_unexport_action_group>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_dbus_connection_unexport_action_group"));

		public void UnexportActionGroup(uint export_id) {
			g_dbus_connection_unexport_action_group(Handle, export_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_dbus_connection_unexport_menu_model(IntPtr raw, uint export_id);
		static d_g_dbus_connection_unexport_menu_model g_dbus_connection_unexport_menu_model = FuncLoader.LoadFunction<d_g_dbus_connection_unexport_menu_model>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_dbus_connection_unexport_menu_model"));

		public void UnexportMenuModel(uint export_id) {
			g_dbus_connection_unexport_menu_model(Handle, export_id);
		}

		public DBusConnection(IntPtr raw) : base(raw) {}


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
