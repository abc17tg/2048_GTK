// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class MenuToolButton : Gtk.ToolButton {

		public MenuToolButton (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_tool_button_new(IntPtr icon_widget, IntPtr label);
		static d_gtk_menu_tool_button_new gtk_menu_tool_button_new = FuncLoader.LoadFunction<d_gtk_menu_tool_button_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_new"));

		public MenuToolButton (Gtk.Widget icon_widget, string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (icon_widget != null) {
					names.Add ("icon_widget");
					vals.Add (new GLib.Value (icon_widget));
				}
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_menu_tool_button_new(icon_widget == null ? IntPtr.Zero : icon_widget.Handle, native_label);
			GLib.Marshaller.Free (native_label);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_tool_button_new_from_stock(IntPtr stock_id);
		static d_gtk_menu_tool_button_new_from_stock gtk_menu_tool_button_new_from_stock = FuncLoader.LoadFunction<d_gtk_menu_tool_button_new_from_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_new_from_stock"));

		public MenuToolButton (string stock_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("stock_id");
				vals.Add (new GLib.Value (stock_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_menu_tool_button_new_from_stock(native_stock_id);
			GLib.Marshaller.Free (native_stock_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_tool_button_get_menu(IntPtr raw);
		static d_gtk_menu_tool_button_get_menu gtk_menu_tool_button_get_menu = FuncLoader.LoadFunction<d_gtk_menu_tool_button_get_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_get_menu"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_tool_button_set_menu(IntPtr raw, IntPtr menu);
		static d_gtk_menu_tool_button_set_menu gtk_menu_tool_button_set_menu = FuncLoader.LoadFunction<d_gtk_menu_tool_button_set_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_set_menu"));

		[GLib.Property ("menu")]
		public Gtk.Widget Menu {
			get  {
				IntPtr raw_ret = gtk_menu_tool_button_get_menu(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_menu_tool_button_set_menu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("show-menu")]
		public event System.EventHandler ShowMenu {
			add {
				this.AddSignalHandler ("show-menu", value);
			}
			remove {
				this.RemoveSignalHandler ("show-menu", value);
			}
		}

		static ShowMenuNativeDelegate ShowMenu_cb_delegate;
		static ShowMenuNativeDelegate ShowMenuVMCallback {
			get {
				if (ShowMenu_cb_delegate == null)
					ShowMenu_cb_delegate = new ShowMenuNativeDelegate (ShowMenu_cb);
				return ShowMenu_cb_delegate;
			}
		}

		static void OverrideShowMenu (GLib.GType gtype)
		{
			OverrideShowMenu (gtype, ShowMenuVMCallback);
		}

		static void OverrideShowMenu (GLib.GType gtype, ShowMenuNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("show_menu"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowMenuNativeDelegate (IntPtr inst);

		static void ShowMenu_cb (IntPtr inst)
		{
			try {
				MenuToolButton __obj = GLib.Object.GetObject (inst, false) as MenuToolButton;
				__obj.OnShowMenu ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuToolButton), ConnectionMethod="OverrideShowMenu")]
		protected virtual void OnShowMenu ()
		{
			InternalShowMenu ();
		}

		private void InternalShowMenu ()
		{
			ShowMenuNativeDelegate unmanaged = class_abi.BaseOverride<ShowMenuNativeDelegate>(this.LookupGType(), "show_menu");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("show_menu"
							, Gtk.ToolButton.class_abi.Fields
							, (uint) sizeof( IntPtr ) // show_menu
							, null
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "show_menu"
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
		delegate IntPtr d_gtk_menu_tool_button_get_type();
		static d_gtk_menu_tool_button_get_type gtk_menu_tool_button_get_type = FuncLoader.LoadFunction<d_gtk_menu_tool_button_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_tool_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_tool_button_set_arrow_tooltip_markup(IntPtr raw, IntPtr markup);
		static d_gtk_menu_tool_button_set_arrow_tooltip_markup gtk_menu_tool_button_set_arrow_tooltip_markup = FuncLoader.LoadFunction<d_gtk_menu_tool_button_set_arrow_tooltip_markup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_set_arrow_tooltip_markup"));

		public string ArrowTooltipMarkup { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_tool_button_set_arrow_tooltip_markup(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_tool_button_set_arrow_tooltip_text(IntPtr raw, IntPtr text);
		static d_gtk_menu_tool_button_set_arrow_tooltip_text gtk_menu_tool_button_set_arrow_tooltip_text = FuncLoader.LoadFunction<d_gtk_menu_tool_button_set_arrow_tooltip_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_tool_button_set_arrow_tooltip_text"));

		public string ArrowTooltipText { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_tool_button_set_arrow_tooltip_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
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
