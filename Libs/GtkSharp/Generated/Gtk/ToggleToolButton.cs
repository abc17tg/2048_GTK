// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ToggleToolButton : Gtk.ToolButton {

		public ToggleToolButton (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toggle_tool_button_new();
		static d_gtk_toggle_tool_button_new gtk_toggle_tool_button_new = FuncLoader.LoadFunction<d_gtk_toggle_tool_button_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_tool_button_new"));

		public ToggleToolButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToggleToolButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_toggle_tool_button_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_toggle_tool_button_new_from_stock(IntPtr stock_id);
		static d_gtk_toggle_tool_button_new_from_stock gtk_toggle_tool_button_new_from_stock = FuncLoader.LoadFunction<d_gtk_toggle_tool_button_new_from_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_tool_button_new_from_stock"));

		public ToggleToolButton (string stock_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToggleToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("stock_id");
				vals.Add (new GLib.Value (stock_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_toggle_tool_button_new_from_stock(native_stock_id);
			GLib.Marshaller.Free (native_stock_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_toggle_tool_button_get_active(IntPtr raw);
		static d_gtk_toggle_tool_button_get_active gtk_toggle_tool_button_get_active = FuncLoader.LoadFunction<d_gtk_toggle_tool_button_get_active>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_tool_button_get_active"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_toggle_tool_button_set_active(IntPtr raw, bool is_active);
		static d_gtk_toggle_tool_button_set_active gtk_toggle_tool_button_set_active = FuncLoader.LoadFunction<d_gtk_toggle_tool_button_set_active>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_tool_button_set_active"));

		[GLib.Property ("active")]
		public bool Active {
			get  {
				bool raw_ret = gtk_toggle_tool_button_get_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_toggle_tool_button_set_active(Handle, value);
			}
		}

		[GLib.Signal("toggled")]
		public event System.EventHandler Toggled {
			add {
				this.AddSignalHandler ("toggled", value);
			}
			remove {
				this.RemoveSignalHandler ("toggled", value);
			}
		}

		static ToggledNativeDelegate Toggled_cb_delegate;
		static ToggledNativeDelegate ToggledVMCallback {
			get {
				if (Toggled_cb_delegate == null)
					Toggled_cb_delegate = new ToggledNativeDelegate (Toggled_cb);
				return Toggled_cb_delegate;
			}
		}

		static void OverrideToggled (GLib.GType gtype)
		{
			OverrideToggled (gtype, ToggledVMCallback);
		}

		static void OverrideToggled (GLib.GType gtype, ToggledNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggled"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggledNativeDelegate (IntPtr inst);

		static void Toggled_cb (IntPtr inst)
		{
			try {
				ToggleToolButton __obj = GLib.Object.GetObject (inst, false) as ToggleToolButton;
				__obj.OnToggled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ToggleToolButton), ConnectionMethod="OverrideToggled")]
		protected virtual void OnToggled ()
		{
			InternalToggled ();
		}

		private void InternalToggled ()
		{
			ToggledNativeDelegate unmanaged = class_abi.BaseOverride<ToggledNativeDelegate>(this.LookupGType(), "toggled");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("toggled"
							, Gtk.ToolButton.class_abi.Fields
							, (uint) sizeof( IntPtr ) // toggled
							, null
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "toggled"
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
		delegate IntPtr d_gtk_toggle_tool_button_get_type();
		static d_gtk_toggle_tool_button_get_type gtk_toggle_tool_button_get_type = FuncLoader.LoadFunction<d_gtk_toggle_tool_button_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_toggle_tool_button_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_toggle_tool_button_get_type();
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
							, Gtk.ToolButton.abi_info.Fields
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
