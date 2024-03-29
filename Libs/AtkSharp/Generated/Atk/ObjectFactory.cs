// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ObjectFactory : GLib.Object {

		public ObjectFactory (IntPtr raw) : base(raw) {}

		protected ObjectFactory() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static CreateAccessibleNativeDelegate CreateAccessible_cb_delegate;
		static CreateAccessibleNativeDelegate CreateAccessibleVMCallback {
			get {
				if (CreateAccessible_cb_delegate == null)
					CreateAccessible_cb_delegate = new CreateAccessibleNativeDelegate (CreateAccessible_cb);
				return CreateAccessible_cb_delegate;
			}
		}

		public delegate Atk.Object CreateAccessibleDelegate (GLib.Object obj);
		static CreateAccessibleDelegate create_accessible_handler;

		public static CreateAccessibleDelegate CreateAccessibleHandler {
			set {
				create_accessible_handler = value;
				OverrideCreateAccessible ((GLib.GType) typeof (ObjectFactory), value == null ? null : CreateAccessibleVMCallback);
			}
		}

		static void OverrideCreateAccessible (GLib.GType gtype, CreateAccessibleNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_accessible"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateAccessibleNativeDelegate (IntPtr obj);

		static IntPtr CreateAccessible_cb (IntPtr obj)
		{
			try {
				Atk.Object __result;
				__result = create_accessible_handler (GLib.Object.GetObject (obj));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		static InvalidateNativeDelegate Invalidate_cb_delegate;
		static InvalidateNativeDelegate InvalidateVMCallback {
			get {
				if (Invalidate_cb_delegate == null)
					Invalidate_cb_delegate = new InvalidateNativeDelegate (Invalidate_cb);
				return Invalidate_cb_delegate;
			}
		}

		static void OverrideInvalidate (GLib.GType gtype)
		{
			OverrideInvalidate (gtype, InvalidateVMCallback);
		}

		static void OverrideInvalidate (GLib.GType gtype, InvalidateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("invalidate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void InvalidateNativeDelegate (IntPtr inst);

		static void Invalidate_cb (IntPtr inst)
		{
			try {
				ObjectFactory __obj = GLib.Object.GetObject (inst, false) as ObjectFactory;
				__obj.OnInvalidate ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.ObjectFactory), ConnectionMethod="OverrideInvalidate")]
		protected virtual void OnInvalidate ()
		{
			InternalInvalidate ();
		}

		private void InternalInvalidate ()
		{
			InvalidateNativeDelegate unmanaged = class_abi.BaseOverride<InvalidateNativeDelegate>(this.LookupGType(), "invalidate");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static GetAccessibleTypeNativeDelegate GetAccessibleType_cb_delegate;
		static GetAccessibleTypeNativeDelegate GetAccessibleTypeVMCallback {
			get {
				if (GetAccessibleType_cb_delegate == null)
					GetAccessibleType_cb_delegate = new GetAccessibleTypeNativeDelegate (GetAccessibleType_cb);
				return GetAccessibleType_cb_delegate;
			}
		}

		public delegate GLib.GType GetAccessibleTypeDelegate ();
		static GetAccessibleTypeDelegate get_accessible_type_handler;

		public static GetAccessibleTypeDelegate GetAccessibleTypeHandler {
			set {
				get_accessible_type_handler = value;
				OverrideGetAccessibleType ((GLib.GType) typeof (ObjectFactory), value == null ? null : GetAccessibleTypeVMCallback);
			}
		}

		static void OverrideGetAccessibleType (GLib.GType gtype, GetAccessibleTypeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_accessible_type"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetAccessibleTypeNativeDelegate ();

		static IntPtr GetAccessibleType_cb ()
		{
			try {
				GLib.GType __result;
				__result = get_accessible_type_handler ();
				return __result.Val;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("create_accessible"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // create_accessible
							, null
							, "invalidate"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("invalidate"
							, -1
							, (uint) sizeof( IntPtr ) // invalidate
							, "create_accessible"
							, "get_accessible_type"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_accessible_type"
							, -1
							, (uint) sizeof( IntPtr ) // get_accessible_type
							, "invalidate"
							, "pad1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("pad1"
							, -1
							, (uint) sizeof( IntPtr ) // pad1
							, "get_accessible_type"
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
		delegate IntPtr d_atk_object_factory_create_accessible(IntPtr raw, IntPtr obj);
		static d_atk_object_factory_create_accessible atk_object_factory_create_accessible = FuncLoader.LoadFunction<d_atk_object_factory_create_accessible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_object_factory_create_accessible"));

		public Atk.Object CreateAccessible(GLib.Object obj) {
			IntPtr raw_ret = atk_object_factory_create_accessible(Handle, obj == null ? IntPtr.Zero : obj.Handle);
			Atk.Object ret = GLib.Object.GetObject(raw_ret) as Atk.Object;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_object_factory_get_accessible_type(IntPtr raw);
		static d_atk_object_factory_get_accessible_type atk_object_factory_get_accessible_type = FuncLoader.LoadFunction<d_atk_object_factory_get_accessible_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_object_factory_get_accessible_type"));

		public GLib.GType AccessibleType { 
			get {
				IntPtr raw_ret = atk_object_factory_get_accessible_type(Handle);
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_object_factory_get_type();
		static d_atk_object_factory_get_type atk_object_factory_get_type = FuncLoader.LoadFunction<d_atk_object_factory_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_object_factory_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_object_factory_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_object_factory_invalidate(IntPtr raw);
		static d_atk_object_factory_invalidate atk_object_factory_invalidate = FuncLoader.LoadFunction<d_atk_object_factory_invalidate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_object_factory_invalidate"));

		public void Invalidate() {
			atk_object_factory_invalidate(Handle);
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
