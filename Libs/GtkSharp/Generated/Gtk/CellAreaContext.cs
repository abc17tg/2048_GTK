// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class CellAreaContext : GLib.Object {

		public CellAreaContext (IntPtr raw) : base(raw) {}

		protected CellAreaContext() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_cell_area_context_get_area(IntPtr raw);
		static d_gtk_cell_area_context_get_area gtk_cell_area_context_get_area = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_area>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_area"));

		[GLib.Property ("area")]
		public Gtk.CellArea Area {
			get  {
				IntPtr raw_ret = gtk_cell_area_context_get_area(Handle);
				Gtk.CellArea ret = GLib.Object.GetObject(raw_ret) as Gtk.CellArea;
				return ret;
			}
		}

		[GLib.Property ("minimum-width")]
		public int MinimumWidth {
			get {
				GLib.Value val = GetProperty ("minimum-width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("natural-width")]
		public int NaturalWidth {
			get {
				GLib.Value val = GetProperty ("natural-width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("minimum-height")]
		public int MinimumHeight {
			get {
				GLib.Value val = GetProperty ("minimum-height");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("natural-height")]
		public int NaturalHeight {
			get {
				GLib.Value val = GetProperty ("natural-height");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		static AllocateNativeDelegate Allocate_cb_delegate;
		static AllocateNativeDelegate AllocateVMCallback {
			get {
				if (Allocate_cb_delegate == null)
					Allocate_cb_delegate = new AllocateNativeDelegate (Allocate_cb);
				return Allocate_cb_delegate;
			}
		}

		static void OverrideAllocate (GLib.GType gtype)
		{
			OverrideAllocate (gtype, AllocateVMCallback);
		}

		static void OverrideAllocate (GLib.GType gtype, AllocateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("allocate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AllocateNativeDelegate (IntPtr inst, int width, int height);

		static void Allocate_cb (IntPtr inst, int width, int height)
		{
			try {
				CellAreaContext __obj = GLib.Object.GetObject (inst, false) as CellAreaContext;
				__obj.OnAllocate (width, height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CellAreaContext), ConnectionMethod="OverrideAllocate")]
		protected virtual void OnAllocate (int width, int height)
		{
			InternalAllocate (width, height);
		}

		private void InternalAllocate (int width, int height)
		{
			AllocateNativeDelegate unmanaged = class_abi.BaseOverride<AllocateNativeDelegate>(this.LookupGType(), "allocate");
			if (unmanaged == null) return;

			unmanaged (this.Handle, width, height);
		}

		static ResetNativeDelegate Reset_cb_delegate;
		static ResetNativeDelegate ResetVMCallback {
			get {
				if (Reset_cb_delegate == null)
					Reset_cb_delegate = new ResetNativeDelegate (Reset_cb);
				return Reset_cb_delegate;
			}
		}

		static void OverrideReset (GLib.GType gtype)
		{
			OverrideReset (gtype, ResetVMCallback);
		}

		static void OverrideReset (GLib.GType gtype, ResetNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("reset"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ResetNativeDelegate (IntPtr inst);

		static void Reset_cb (IntPtr inst)
		{
			try {
				CellAreaContext __obj = GLib.Object.GetObject (inst, false) as CellAreaContext;
				__obj.OnReset ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CellAreaContext), ConnectionMethod="OverrideReset")]
		protected virtual void OnReset ()
		{
			InternalReset ();
		}

		private void InternalReset ()
		{
			ResetNativeDelegate unmanaged = class_abi.BaseOverride<ResetNativeDelegate>(this.LookupGType(), "reset");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static GetPreferredHeightForWidthNativeDelegate GetPreferredHeightForWidth_cb_delegate;
		static GetPreferredHeightForWidthNativeDelegate GetPreferredHeightForWidthVMCallback {
			get {
				if (GetPreferredHeightForWidth_cb_delegate == null)
					GetPreferredHeightForWidth_cb_delegate = new GetPreferredHeightForWidthNativeDelegate (GetPreferredHeightForWidth_cb);
				return GetPreferredHeightForWidth_cb_delegate;
			}
		}

		static void OverrideGetPreferredHeightForWidth (GLib.GType gtype)
		{
			OverrideGetPreferredHeightForWidth (gtype, GetPreferredHeightForWidthVMCallback);
		}

		static void OverrideGetPreferredHeightForWidth (GLib.GType gtype, GetPreferredHeightForWidthNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_preferred_height_for_width"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetPreferredHeightForWidthNativeDelegate (IntPtr inst, int width, out int minimum_height, out int natural_height);

		static void GetPreferredHeightForWidth_cb (IntPtr inst, int width, out int minimum_height, out int natural_height)
		{
			try {
				CellAreaContext __obj = GLib.Object.GetObject (inst, false) as CellAreaContext;
				__obj.OnGetPreferredHeightForWidth (width, out minimum_height, out natural_height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CellAreaContext), ConnectionMethod="OverrideGetPreferredHeightForWidth")]
		protected virtual void OnGetPreferredHeightForWidth (int width, out int minimum_height, out int natural_height)
		{
			InternalGetPreferredHeightForWidth (width, out minimum_height, out natural_height);
		}

		private void InternalGetPreferredHeightForWidth (int width, out int minimum_height, out int natural_height)
		{
			GetPreferredHeightForWidthNativeDelegate unmanaged = class_abi.BaseOverride<GetPreferredHeightForWidthNativeDelegate>(this.LookupGType(), "get_preferred_height_for_width");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			unmanaged (this.Handle, width, out minimum_height, out natural_height);
		}

		static GetPreferredWidthForHeightNativeDelegate GetPreferredWidthForHeight_cb_delegate;
		static GetPreferredWidthForHeightNativeDelegate GetPreferredWidthForHeightVMCallback {
			get {
				if (GetPreferredWidthForHeight_cb_delegate == null)
					GetPreferredWidthForHeight_cb_delegate = new GetPreferredWidthForHeightNativeDelegate (GetPreferredWidthForHeight_cb);
				return GetPreferredWidthForHeight_cb_delegate;
			}
		}

		static void OverrideGetPreferredWidthForHeight (GLib.GType gtype)
		{
			OverrideGetPreferredWidthForHeight (gtype, GetPreferredWidthForHeightVMCallback);
		}

		static void OverrideGetPreferredWidthForHeight (GLib.GType gtype, GetPreferredWidthForHeightNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_preferred_width_for_height"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetPreferredWidthForHeightNativeDelegate (IntPtr inst, int height, out int minimum_width, out int natural_width);

		static void GetPreferredWidthForHeight_cb (IntPtr inst, int height, out int minimum_width, out int natural_width)
		{
			try {
				CellAreaContext __obj = GLib.Object.GetObject (inst, false) as CellAreaContext;
				__obj.OnGetPreferredWidthForHeight (height, out minimum_width, out natural_width);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CellAreaContext), ConnectionMethod="OverrideGetPreferredWidthForHeight")]
		protected virtual void OnGetPreferredWidthForHeight (int height, out int minimum_width, out int natural_width)
		{
			InternalGetPreferredWidthForHeight (height, out minimum_width, out natural_width);
		}

		private void InternalGetPreferredWidthForHeight (int height, out int minimum_width, out int natural_width)
		{
			GetPreferredWidthForHeightNativeDelegate unmanaged = class_abi.BaseOverride<GetPreferredWidthForHeightNativeDelegate>(this.LookupGType(), "get_preferred_width_for_height");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			unmanaged (this.Handle, height, out minimum_width, out natural_width);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("allocate"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // allocate
							, null
							, "reset"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("reset"
							, -1
							, (uint) sizeof( IntPtr ) // reset
							, "allocate"
							, "get_preferred_height_for_width"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_preferred_height_for_width"
							, -1
							, (uint) sizeof( IntPtr ) // get_preferred_height_for_width
							, "reset"
							, "get_preferred_width_for_height"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_preferred_width_for_height"
							, -1
							, (uint) sizeof( IntPtr ) // get_preferred_width_for_height
							, "get_preferred_height_for_width"
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "get_preferred_width_for_height"
							, "_gtk_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved4
							, "_gtk_reserved3"
							, "_gtk_reserved5"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved5"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved5
							, "_gtk_reserved4"
							, "_gtk_reserved6"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved6"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved6
							, "_gtk_reserved5"
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
		delegate void d_gtk_cell_area_context_allocate(IntPtr raw, int width, int height);
		static d_gtk_cell_area_context_allocate gtk_cell_area_context_allocate = FuncLoader.LoadFunction<d_gtk_cell_area_context_allocate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_allocate"));

		public void Allocate(int width, int height) {
			gtk_cell_area_context_allocate(Handle, width, height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_get_allocation(IntPtr raw, out int width, out int height);
		static d_gtk_cell_area_context_get_allocation gtk_cell_area_context_get_allocation = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_allocation>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_allocation"));

		public void GetAllocation(out int width, out int height) {
			gtk_cell_area_context_get_allocation(Handle, out width, out height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_get_preferred_height(IntPtr raw, out int minimum_height, out int natural_height);
		static d_gtk_cell_area_context_get_preferred_height gtk_cell_area_context_get_preferred_height = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_preferred_height>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_preferred_height"));

		public void GetPreferredHeight(out int minimum_height, out int natural_height) {
			gtk_cell_area_context_get_preferred_height(Handle, out minimum_height, out natural_height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_get_preferred_height_for_width(IntPtr raw, int width, out int minimum_height, out int natural_height);
		static d_gtk_cell_area_context_get_preferred_height_for_width gtk_cell_area_context_get_preferred_height_for_width = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_preferred_height_for_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_preferred_height_for_width"));

		public void GetPreferredHeightForWidth(int width, out int minimum_height, out int natural_height) {
			gtk_cell_area_context_get_preferred_height_for_width(Handle, width, out minimum_height, out natural_height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_get_preferred_width(IntPtr raw, out int minimum_width, out int natural_width);
		static d_gtk_cell_area_context_get_preferred_width gtk_cell_area_context_get_preferred_width = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_preferred_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_preferred_width"));

		public void GetPreferredWidth(out int minimum_width, out int natural_width) {
			gtk_cell_area_context_get_preferred_width(Handle, out minimum_width, out natural_width);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_get_preferred_width_for_height(IntPtr raw, int height, out int minimum_width, out int natural_width);
		static d_gtk_cell_area_context_get_preferred_width_for_height gtk_cell_area_context_get_preferred_width_for_height = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_preferred_width_for_height>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_preferred_width_for_height"));

		public void GetPreferredWidthForHeight(int height, out int minimum_width, out int natural_width) {
			gtk_cell_area_context_get_preferred_width_for_height(Handle, height, out minimum_width, out natural_width);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_cell_area_context_get_type();
		static d_gtk_cell_area_context_get_type gtk_cell_area_context_get_type = FuncLoader.LoadFunction<d_gtk_cell_area_context_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_cell_area_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_push_preferred_height(IntPtr raw, int minimum_height, int natural_height);
		static d_gtk_cell_area_context_push_preferred_height gtk_cell_area_context_push_preferred_height = FuncLoader.LoadFunction<d_gtk_cell_area_context_push_preferred_height>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_push_preferred_height"));

		public void PushPreferredHeight(int minimum_height, int natural_height) {
			gtk_cell_area_context_push_preferred_height(Handle, minimum_height, natural_height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_push_preferred_width(IntPtr raw, int minimum_width, int natural_width);
		static d_gtk_cell_area_context_push_preferred_width gtk_cell_area_context_push_preferred_width = FuncLoader.LoadFunction<d_gtk_cell_area_context_push_preferred_width>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_push_preferred_width"));

		public void PushPreferredWidth(int minimum_width, int natural_width) {
			gtk_cell_area_context_push_preferred_width(Handle, minimum_width, natural_width);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_area_context_reset(IntPtr raw);
		static d_gtk_cell_area_context_reset gtk_cell_area_context_reset = FuncLoader.LoadFunction<d_gtk_cell_area_context_reset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_area_context_reset"));

		public void Reset() {
			gtk_cell_area_context_reset(Handle);
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
