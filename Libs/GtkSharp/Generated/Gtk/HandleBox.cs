// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class HandleBox : Gtk.Bin {

		public HandleBox (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_handle_box_new();
		static d_gtk_handle_box_new gtk_handle_box_new = FuncLoader.LoadFunction<d_gtk_handle_box_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_new"));

		public HandleBox () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HandleBox)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_handle_box_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_handle_box_get_handle_position(IntPtr raw);
		static d_gtk_handle_box_get_handle_position gtk_handle_box_get_handle_position = FuncLoader.LoadFunction<d_gtk_handle_box_get_handle_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_get_handle_position"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_handle_box_set_handle_position(IntPtr raw, int position);
		static d_gtk_handle_box_set_handle_position gtk_handle_box_set_handle_position = FuncLoader.LoadFunction<d_gtk_handle_box_set_handle_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_set_handle_position"));

		[Obsolete]
		[GLib.Property ("handle-position")]
		public Gtk.PositionType HandlePosition {
			get  {
				int raw_ret = gtk_handle_box_get_handle_position(Handle);
				Gtk.PositionType ret = (Gtk.PositionType) raw_ret;
				return ret;
			}
			set  {
				gtk_handle_box_set_handle_position(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_handle_box_get_snap_edge(IntPtr raw);
		static d_gtk_handle_box_get_snap_edge gtk_handle_box_get_snap_edge = FuncLoader.LoadFunction<d_gtk_handle_box_get_snap_edge>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_get_snap_edge"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_handle_box_set_snap_edge(IntPtr raw, int edge);
		static d_gtk_handle_box_set_snap_edge gtk_handle_box_set_snap_edge = FuncLoader.LoadFunction<d_gtk_handle_box_set_snap_edge>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_set_snap_edge"));

		[Obsolete]
		[GLib.Property ("snap-edge")]
		public Gtk.PositionType SnapEdge {
			get  {
				int raw_ret = gtk_handle_box_get_snap_edge(Handle);
				Gtk.PositionType ret = (Gtk.PositionType) raw_ret;
				return ret;
			}
			set  {
				gtk_handle_box_set_snap_edge(Handle, (int) value);
			}
		}

		[GLib.Property ("snap-edge-set")]
		public bool SnapEdgeSet {
			get {
				GLib.Value val = GetProperty ("snap-edge-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("snap-edge-set", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("child-attached")]
		public event Gtk.ChildAttachedHandler ChildAttached {
			add {
				this.AddSignalHandler ("child-attached", value, typeof (Gtk.ChildAttachedArgs));
			}
			remove {
				this.RemoveSignalHandler ("child-attached", value);
			}
		}

		[GLib.Signal("child-detached")]
		public event Gtk.ChildDetachedHandler ChildDetached {
			add {
				this.AddSignalHandler ("child-detached", value, typeof (Gtk.ChildDetachedArgs));
			}
			remove {
				this.RemoveSignalHandler ("child-detached", value);
			}
		}

		static ChildAttachedNativeDelegate ChildAttached_cb_delegate;
		static ChildAttachedNativeDelegate ChildAttachedVMCallback {
			get {
				if (ChildAttached_cb_delegate == null)
					ChildAttached_cb_delegate = new ChildAttachedNativeDelegate (ChildAttached_cb);
				return ChildAttached_cb_delegate;
			}
		}

		static void OverrideChildAttached (GLib.GType gtype)
		{
			OverrideChildAttached (gtype, ChildAttachedVMCallback);
		}

		static void OverrideChildAttached (GLib.GType gtype, ChildAttachedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("child_attached"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChildAttachedNativeDelegate (IntPtr inst, IntPtr child);

		static void ChildAttached_cb (IntPtr inst, IntPtr child)
		{
			try {
				HandleBox __obj = GLib.Object.GetObject (inst, false) as HandleBox;
				__obj.OnChildAttached (GLib.Object.GetObject(child) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.HandleBox), ConnectionMethod="OverrideChildAttached")]
		protected virtual void OnChildAttached (Gtk.Widget child)
		{
			InternalChildAttached (child);
		}

		private void InternalChildAttached (Gtk.Widget child)
		{
			ChildAttachedNativeDelegate unmanaged = class_abi.BaseOverride<ChildAttachedNativeDelegate>(this.LookupGType(), "child_attached");
			if (unmanaged == null) return;

			unmanaged (this.Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		static ChildDetachedNativeDelegate ChildDetached_cb_delegate;
		static ChildDetachedNativeDelegate ChildDetachedVMCallback {
			get {
				if (ChildDetached_cb_delegate == null)
					ChildDetached_cb_delegate = new ChildDetachedNativeDelegate (ChildDetached_cb);
				return ChildDetached_cb_delegate;
			}
		}

		static void OverrideChildDetached (GLib.GType gtype)
		{
			OverrideChildDetached (gtype, ChildDetachedVMCallback);
		}

		static void OverrideChildDetached (GLib.GType gtype, ChildDetachedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("child_detached"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChildDetachedNativeDelegate (IntPtr inst, IntPtr child);

		static void ChildDetached_cb (IntPtr inst, IntPtr child)
		{
			try {
				HandleBox __obj = GLib.Object.GetObject (inst, false) as HandleBox;
				__obj.OnChildDetached (GLib.Object.GetObject(child) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.HandleBox), ConnectionMethod="OverrideChildDetached")]
		protected virtual void OnChildDetached (Gtk.Widget child)
		{
			InternalChildDetached (child);
		}

		private void InternalChildDetached (Gtk.Widget child)
		{
			ChildDetachedNativeDelegate unmanaged = class_abi.BaseOverride<ChildDetachedNativeDelegate>(this.LookupGType(), "child_detached");
			if (unmanaged == null) return;

			unmanaged (this.Handle, child == null ? IntPtr.Zero : child.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("child_attached"
							, Gtk.Bin.class_abi.Fields
							, (uint) sizeof( IntPtr ) // child_attached
							, null
							, "child_detached"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("child_detached"
							, -1
							, (uint) sizeof( IntPtr ) // child_detached
							, "child_attached"
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "child_detached"
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
		delegate bool d_gtk_handle_box_get_child_detached(IntPtr raw);
		static d_gtk_handle_box_get_child_detached gtk_handle_box_get_child_detached = FuncLoader.LoadFunction<d_gtk_handle_box_get_child_detached>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_get_child_detached"));

		[Obsolete]
		public bool IsChildDetached { 
			get {
				bool raw_ret = gtk_handle_box_get_child_detached(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_handle_box_get_shadow_type(IntPtr raw);
		static d_gtk_handle_box_get_shadow_type gtk_handle_box_get_shadow_type = FuncLoader.LoadFunction<d_gtk_handle_box_get_shadow_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_get_shadow_type"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_handle_box_set_shadow_type(IntPtr raw, int type);
		static d_gtk_handle_box_set_shadow_type gtk_handle_box_set_shadow_type = FuncLoader.LoadFunction<d_gtk_handle_box_set_shadow_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_set_shadow_type"));

		[Obsolete]
		public Gtk.ShadowType ShadowType { 
			get {
				int raw_ret = gtk_handle_box_get_shadow_type(Handle);
				Gtk.ShadowType ret = (Gtk.ShadowType) raw_ret;
				return ret;
			}
			set {
				gtk_handle_box_set_shadow_type(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_handle_box_get_type();
		static d_gtk_handle_box_get_type gtk_handle_box_get_type = FuncLoader.LoadFunction<d_gtk_handle_box_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_handle_box_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_handle_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Bin.abi_info.Fields
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
