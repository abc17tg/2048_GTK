// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class RelationSet : GLib.Object {

		public RelationSet (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_set_new();
		static d_atk_relation_set_new atk_relation_set_new = FuncLoader.LoadFunction<d_atk_relation_set_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_new"));

		public RelationSet () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RelationSet)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = atk_relation_set_new();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("pad1"
							, GLib.Object.class_abi.Fields
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
		delegate void d_atk_relation_set_add(IntPtr raw, IntPtr relation);
		static d_atk_relation_set_add atk_relation_set_add = FuncLoader.LoadFunction<d_atk_relation_set_add>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_add"));

		public void Add(Atk.Relation relation) {
			atk_relation_set_add(Handle, relation == null ? IntPtr.Zero : relation.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_relation_set_add_relation_by_type(IntPtr raw, int relationship, IntPtr target);
		static d_atk_relation_set_add_relation_by_type atk_relation_set_add_relation_by_type = FuncLoader.LoadFunction<d_atk_relation_set_add_relation_by_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_add_relation_by_type"));

		public void AddRelationByType(Atk.RelationType relationship, Atk.Object target) {
			atk_relation_set_add_relation_by_type(Handle, (int) relationship, target == null ? IntPtr.Zero : target.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_relation_set_contains(IntPtr raw, int relationship);
		static d_atk_relation_set_contains atk_relation_set_contains = FuncLoader.LoadFunction<d_atk_relation_set_contains>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_contains"));

		public bool Contains(Atk.RelationType relationship) {
			bool raw_ret = atk_relation_set_contains(Handle, (int) relationship);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_relation_set_contains_target(IntPtr raw, int relationship, IntPtr target);
		static d_atk_relation_set_contains_target atk_relation_set_contains_target = FuncLoader.LoadFunction<d_atk_relation_set_contains_target>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_contains_target"));

		public bool ContainsTarget(Atk.RelationType relationship, Atk.Object target) {
			bool raw_ret = atk_relation_set_contains_target(Handle, (int) relationship, target == null ? IntPtr.Zero : target.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_relation_set_get_n_relations(IntPtr raw);
		static d_atk_relation_set_get_n_relations atk_relation_set_get_n_relations = FuncLoader.LoadFunction<d_atk_relation_set_get_n_relations>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_get_n_relations"));

		public int NRelations { 
			get {
				int raw_ret = atk_relation_set_get_n_relations(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_set_get_relation(IntPtr raw, int i);
		static d_atk_relation_set_get_relation atk_relation_set_get_relation = FuncLoader.LoadFunction<d_atk_relation_set_get_relation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_get_relation"));

		public Atk.Relation GetRelation(int i) {
			IntPtr raw_ret = atk_relation_set_get_relation(Handle, i);
			Atk.Relation ret = GLib.Object.GetObject(raw_ret) as Atk.Relation;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_set_get_relation_by_type(IntPtr raw, int relationship);
		static d_atk_relation_set_get_relation_by_type atk_relation_set_get_relation_by_type = FuncLoader.LoadFunction<d_atk_relation_set_get_relation_by_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_get_relation_by_type"));

		public Atk.Relation GetRelationByType(Atk.RelationType relationship) {
			IntPtr raw_ret = atk_relation_set_get_relation_by_type(Handle, (int) relationship);
			Atk.Relation ret = GLib.Object.GetObject(raw_ret) as Atk.Relation;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_relation_set_get_type();
		static d_atk_relation_set_get_type atk_relation_set_get_type = FuncLoader.LoadFunction<d_atk_relation_set_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_relation_set_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_relation_set_remove(IntPtr raw, IntPtr relation);
		static d_atk_relation_set_remove atk_relation_set_remove = FuncLoader.LoadFunction<d_atk_relation_set_remove>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_relation_set_remove"));

		public void Remove(Atk.Relation relation) {
			atk_relation_set_remove(Handle, relation == null ? IntPtr.Zero : relation.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("relations"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // relations
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
