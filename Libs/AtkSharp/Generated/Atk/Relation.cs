// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Relation : GLib.Object {

		public Relation (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_new(IntPtr[] targets, int n_targets, int relationship);
		static d_atk_relation_new atk_relation_new = FuncLoader.LoadFunction<d_atk_relation_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_new"));

		public Relation (Atk.Object[] targets, Atk.RelationType relationship) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Relation)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			int cnt_targets = targets == null ? 0 : targets.Length;
			IntPtr[] native_targets = new IntPtr [cnt_targets];
			for (int i = 0; i < cnt_targets; i++)
				native_targets [i] = targets[i] == null ? IntPtr.Zero : targets[i].Handle;
			Raw = atk_relation_new(native_targets, (targets == null ? 0 : targets.Length), (int) relationship);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_relation_get_relation_type(IntPtr raw);
		static d_atk_relation_get_relation_type atk_relation_get_relation_type = FuncLoader.LoadFunction<d_atk_relation_get_relation_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_get_relation_type"));

		[GLib.Property ("relation_type")]
		public Atk.RelationType RelationType {
			get  {
				int raw_ret = atk_relation_get_relation_type(Handle);
				Atk.RelationType ret = (Atk.RelationType) raw_ret;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("relation_type", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_get_target(IntPtr raw);
		static d_atk_relation_get_target atk_relation_get_target = FuncLoader.LoadFunction<d_atk_relation_get_target>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_get_target"));

		public Atk.Object[] Target {
			get  {
				IntPtr raw_ret = atk_relation_get_target(Handle);
				Atk.Object[] ret = GLib.Marshaller.PtrArrayToArray<Atk.Object> (raw_ret, false, false);
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
		delegate void d_atk_relation_add_target(IntPtr raw, IntPtr target);
		static d_atk_relation_add_target atk_relation_add_target = FuncLoader.LoadFunction<d_atk_relation_add_target>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_add_target"));

		public void AddTarget(Atk.Object target) {
			atk_relation_add_target(Handle, target == null ? IntPtr.Zero : target.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_get_type();
		static d_atk_relation_get_type atk_relation_get_type = FuncLoader.LoadFunction<d_atk_relation_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_relation_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_relation_remove_target(IntPtr raw, IntPtr target);
		static d_atk_relation_remove_target atk_relation_remove_target = FuncLoader.LoadFunction<d_atk_relation_remove_target>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_remove_target"));

		public bool RemoveTarget(Atk.Object target) {
			bool raw_ret = atk_relation_remove_target(Handle, target == null ? IntPtr.Zero : target.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_relation_type_for_name(IntPtr name);
		static d_atk_relation_type_for_name atk_relation_type_for_name = FuncLoader.LoadFunction<d_atk_relation_type_for_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_type_for_name"));

		public static Atk.RelationType TypeForName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = atk_relation_type_for_name(native_name);
			Atk.RelationType ret = (Atk.RelationType) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_type_get_name(int type);
		static d_atk_relation_type_get_name atk_relation_type_get_name = FuncLoader.LoadFunction<d_atk_relation_type_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_type_get_name"));

		public static string TypeGetName(Atk.RelationType type) {
			IntPtr raw_ret = atk_relation_type_get_name((int) type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_relation_type_register(IntPtr name);
		static d_atk_relation_type_register atk_relation_type_register = FuncLoader.LoadFunction<d_atk_relation_type_register>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_type_register"));

		public static Atk.RelationType TypeRegister(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = atk_relation_type_register(native_name);
			Atk.RelationType ret = (Atk.RelationType) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("target"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // target
							, null
							, "relationship"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("relationship"
							, -1
							, (uint) sizeof(Atk.RelationType) // relationship
							, "target"
							, null
							, (long) Marshal.OffsetOf<AtkRelation_relationshipAlign>("relationship")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct AtkRelation_relationshipAlign
		{
			sbyte f1;
			private Atk.RelationType relationship;
		}


		// End of the ABI representation.

#endregion
	}
}
