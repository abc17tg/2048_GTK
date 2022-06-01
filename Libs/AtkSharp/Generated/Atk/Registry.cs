// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Registry : GLib.Object {

		public Registry (IntPtr raw) : base(raw) {}

		protected Registry() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
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
		delegate IntPtr d_atk_registry_get_factory(IntPtr raw, IntPtr type);
		static d_atk_registry_get_factory atk_registry_get_factory = FuncLoader.LoadFunction<d_atk_registry_get_factory>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_registry_get_factory"));

		public Atk.ObjectFactory GetFactory(GLib.GType type) {
			IntPtr raw_ret = atk_registry_get_factory(Handle, type.Val);
			Atk.ObjectFactory ret = GLib.Object.GetObject(raw_ret) as Atk.ObjectFactory;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_registry_get_factory_type(IntPtr raw, IntPtr type);
		static d_atk_registry_get_factory_type atk_registry_get_factory_type = FuncLoader.LoadFunction<d_atk_registry_get_factory_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_registry_get_factory_type"));

		public GLib.GType GetFactoryType(GLib.GType type) {
			IntPtr raw_ret = atk_registry_get_factory_type(Handle, type.Val);
			GLib.GType ret = new GLib.GType(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_registry_get_type();
		static d_atk_registry_get_type atk_registry_get_type = FuncLoader.LoadFunction<d_atk_registry_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_registry_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_registry_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_registry_set_factory_type(IntPtr raw, IntPtr type, IntPtr factory_type);
		static d_atk_registry_set_factory_type atk_registry_set_factory_type = FuncLoader.LoadFunction<d_atk_registry_set_factory_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_registry_set_factory_type"));

		public void SetFactoryType(GLib.GType type, GLib.GType factory_type) {
			atk_registry_set_factory_type(Handle, type.Val, factory_type.Val);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("factory_type_registry"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // factory_type_registry
							, null
							, "factory_singleton_cache"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("factory_singleton_cache"
							, -1
							, (uint) sizeof( IntPtr ) // factory_singleton_cache
							, "factory_type_registry"
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
