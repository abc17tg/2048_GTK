// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class GObjectAccessible : Atk.Object {

		public GObjectAccessible (IntPtr raw) : base(raw) {}

		protected GObjectAccessible() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("pad1"
							, Atk.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // pad1
							, null
							, "pad2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("pad2"
							, -1
							, (uint) sizeof( IntPtr ) // pad2
							, "pad1"
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
		delegate IntPtr d_atk_gobject_accessible_for_object(IntPtr obj);
		static d_atk_gobject_accessible_for_object atk_gobject_accessible_for_object = FuncLoader.LoadFunction<d_atk_gobject_accessible_for_object>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_gobject_accessible_for_object"));

		public static Atk.Object ForObject(GLib.Object obj) {
			IntPtr raw_ret = atk_gobject_accessible_for_object(obj == null ? IntPtr.Zero : obj.Handle);
			Atk.Object ret = GLib.Object.GetObject(raw_ret) as Atk.Object;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_gobject_accessible_get_object(IntPtr raw);
		static d_atk_gobject_accessible_get_object atk_gobject_accessible_get_object = FuncLoader.LoadFunction<d_atk_gobject_accessible_get_object>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_gobject_accessible_get_object"));

		public GLib.Object Object { 
			get {
				IntPtr raw_ret = atk_gobject_accessible_get_object(Handle);
				GLib.Object ret = GLib.Object.GetObject (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_gobject_accessible_get_type();
		static d_atk_gobject_accessible_get_type atk_gobject_accessible_get_type = FuncLoader.LoadFunction<d_atk_gobject_accessible_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_gobject_accessible_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_gobject_accessible_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Atk.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
