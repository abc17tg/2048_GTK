// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Socket : Atk.Object, Atk.IComponent {

		public Socket (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_socket_new();
		static d_atk_socket_new atk_socket_new = FuncLoader.LoadFunction<d_atk_socket_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_socket_new"));

		public Socket () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Socket)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = atk_socket_new();
		}

		static EmbedNativeDelegate Embed_cb_delegate;
		static EmbedNativeDelegate EmbedVMCallback {
			get {
				if (Embed_cb_delegate == null)
					Embed_cb_delegate = new EmbedNativeDelegate (Embed_cb);
				return Embed_cb_delegate;
			}
		}

		static void OverrideEmbed (GLib.GType gtype)
		{
			OverrideEmbed (gtype, EmbedVMCallback);
		}

		static void OverrideEmbed (GLib.GType gtype, EmbedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("embed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EmbedNativeDelegate (IntPtr inst, IntPtr plug_id);

		static void Embed_cb (IntPtr inst, IntPtr plug_id)
		{
			try {
				Socket __obj = GLib.Object.GetObject (inst, false) as Socket;
				__obj.OnEmbed (GLib.Marshaller.PtrToStringGFree(plug_id));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Socket), ConnectionMethod="OverrideEmbed")]
		protected virtual void OnEmbed (string plug_id)
		{
			InternalEmbed (plug_id);
		}

		private void InternalEmbed (string plug_id)
		{
			EmbedNativeDelegate unmanaged = class_abi.BaseOverride<EmbedNativeDelegate>(this.LookupGType(), "embed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, GLib.Marshaller.StringToPtrGStrdup(plug_id));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("embed"
							, Atk.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // embed
							, null
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
		delegate void d_atk_socket_embed(IntPtr raw, IntPtr plug_id);
		static d_atk_socket_embed atk_socket_embed = FuncLoader.LoadFunction<d_atk_socket_embed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_socket_embed"));

		public void Embed(string plug_id) {
			atk_socket_embed(Handle, GLib.Marshaller.StringToPtrGStrdup(plug_id));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_socket_get_type();
		static d_atk_socket_get_type atk_socket_get_type = FuncLoader.LoadFunction<d_atk_socket_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_socket_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_socket_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_socket_is_occupied(IntPtr raw);
		static d_atk_socket_is_occupied atk_socket_is_occupied = FuncLoader.LoadFunction<d_atk_socket_is_occupied>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_socket_is_occupied"));

		public bool IsOccupied { 
			get {
				bool raw_ret = atk_socket_is_occupied(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_atk_component_add_focus_handler(IntPtr raw, AtkSharp.FocusHandlerNative handler);
		static d_atk_component_add_focus_handler atk_component_add_focus_handler = FuncLoader.LoadFunction<d_atk_component_add_focus_handler>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_add_focus_handler"));

		[Obsolete]
		public uint AddFocusHandler(Atk.FocusHandler handler) {
			AtkSharp.FocusHandlerWrapper handler_wrapper = new AtkSharp.FocusHandlerWrapper (handler);
			uint raw_ret = atk_component_add_focus_handler(Handle, handler_wrapper.NativeDelegate);
			uint ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_component_contains(IntPtr raw, int x, int y, int coord_type);
		static d_atk_component_contains atk_component_contains = FuncLoader.LoadFunction<d_atk_component_contains>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_contains"));

		public bool Contains(int x, int y, Atk.CoordType coord_type) {
			bool raw_ret = atk_component_contains(Handle, x, y, (int) coord_type);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_atk_component_get_alpha(IntPtr raw);
		static d_atk_component_get_alpha atk_component_get_alpha = FuncLoader.LoadFunction<d_atk_component_get_alpha>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_get_alpha"));

		public double Alpha { 
			get {
				double raw_ret = atk_component_get_alpha(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_component_get_extents(IntPtr raw, out int x, out int y, out int width, out int height, int coord_type);
		static d_atk_component_get_extents atk_component_get_extents = FuncLoader.LoadFunction<d_atk_component_get_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_get_extents"));

		public void GetExtents(out int x, out int y, out int width, out int height, Atk.CoordType coord_type) {
			atk_component_get_extents(Handle, out x, out y, out width, out height, (int) coord_type);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_component_get_layer(IntPtr raw);
		static d_atk_component_get_layer atk_component_get_layer = FuncLoader.LoadFunction<d_atk_component_get_layer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_get_layer"));

		public Atk.Layer Layer { 
			get {
				int raw_ret = atk_component_get_layer(Handle);
				Atk.Layer ret = (Atk.Layer) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_component_get_mdi_zorder(IntPtr raw);
		static d_atk_component_get_mdi_zorder atk_component_get_mdi_zorder = FuncLoader.LoadFunction<d_atk_component_get_mdi_zorder>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_get_mdi_zorder"));

		public int MdiZorder { 
			get {
				int raw_ret = atk_component_get_mdi_zorder(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_component_get_position(IntPtr raw, out int x, out int y, int coord_type);
		static d_atk_component_get_position atk_component_get_position = FuncLoader.LoadFunction<d_atk_component_get_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_get_position"));

		[Obsolete]
		public void GetPosition(out int x, out int y, Atk.CoordType coord_type) {
			atk_component_get_position(Handle, out x, out y, (int) coord_type);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_component_get_size(IntPtr raw, out int width, out int height);
		static d_atk_component_get_size atk_component_get_size = FuncLoader.LoadFunction<d_atk_component_get_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_get_size"));

		[Obsolete]
		public void GetSize(out int width, out int height) {
			atk_component_get_size(Handle, out width, out height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_component_grab_focus(IntPtr raw);
		static d_atk_component_grab_focus atk_component_grab_focus = FuncLoader.LoadFunction<d_atk_component_grab_focus>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_grab_focus"));

		public bool GrabFocus() {
			bool raw_ret = atk_component_grab_focus(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_component_ref_accessible_at_point(IntPtr raw, int x, int y, int coord_type);
		static d_atk_component_ref_accessible_at_point atk_component_ref_accessible_at_point = FuncLoader.LoadFunction<d_atk_component_ref_accessible_at_point>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_ref_accessible_at_point"));

		public Atk.Object RefAccessibleAtPoint(int x, int y, Atk.CoordType coord_type) {
			IntPtr raw_ret = atk_component_ref_accessible_at_point(Handle, x, y, (int) coord_type);
			Atk.Object ret = GLib.Object.GetObject(raw_ret, true) as Atk.Object;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_component_remove_focus_handler(IntPtr raw, uint handler_id);
		static d_atk_component_remove_focus_handler atk_component_remove_focus_handler = FuncLoader.LoadFunction<d_atk_component_remove_focus_handler>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_remove_focus_handler"));

		[Obsolete]
		public void RemoveFocusHandler(uint handler_id) {
			atk_component_remove_focus_handler(Handle, handler_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_component_set_extents(IntPtr raw, int x, int y, int width, int height, int coord_type);
		static d_atk_component_set_extents atk_component_set_extents = FuncLoader.LoadFunction<d_atk_component_set_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_set_extents"));

		public bool SetExtents(int x, int y, int width, int height, Atk.CoordType coord_type) {
			bool raw_ret = atk_component_set_extents(Handle, x, y, width, height, (int) coord_type);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_component_set_position(IntPtr raw, int x, int y, int coord_type);
		static d_atk_component_set_position atk_component_set_position = FuncLoader.LoadFunction<d_atk_component_set_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_set_position"));

		public bool SetPosition(int x, int y, Atk.CoordType coord_type) {
			bool raw_ret = atk_component_set_position(Handle, x, y, (int) coord_type);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_component_set_size(IntPtr raw, int width, int height);
		static d_atk_component_set_size atk_component_set_size = FuncLoader.LoadFunction<d_atk_component_set_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_component_set_size"));

		public bool SetSize(int width, int height) {
			bool raw_ret = atk_component_set_size(Handle, width, height);
			bool ret = raw_ret;
			return ret;
		}

		[GLib.Signal("bounds_changed")]
		public event Atk.BoundsChangedHandler BoundsChanged {
			add {
				this.AddSignalHandler ("bounds_changed", value, typeof (Atk.BoundsChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("bounds_changed", value);
			}
		}

		static BoundsChangedNativeDelegate BoundsChanged_cb_delegate;
		static BoundsChangedNativeDelegate BoundsChangedVMCallback {
			get {
				if (BoundsChanged_cb_delegate == null)
					BoundsChanged_cb_delegate = new BoundsChangedNativeDelegate (BoundsChanged_cb);
				return BoundsChanged_cb_delegate;
			}
		}

		static void OverrideBoundsChanged (GLib.GType gtype)
		{
			OverrideBoundsChanged (gtype, BoundsChangedVMCallback);
		}

		static void OverrideBoundsChanged (GLib.GType gtype, BoundsChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "bounds_changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void BoundsChangedNativeDelegate (IntPtr inst, IntPtr bounds);

		static void BoundsChanged_cb (IntPtr inst, IntPtr bounds)
		{
			try {
				Atk.Socket __obj = GLib.Object.GetObject (inst, false) as Atk.Socket;
				__obj.OnBoundsChanged (Atk.Rectangle.New (bounds));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Socket), ConnectionMethod="OverrideBoundsChanged")]
		protected virtual void OnBoundsChanged (Atk.Rectangle bounds)
		{
			InternalBoundsChanged (bounds);
		}

		private void InternalBoundsChanged (Atk.Rectangle bounds)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (bounds);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("embedded_plug_id"
							, Atk.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // embedded_plug_id
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
