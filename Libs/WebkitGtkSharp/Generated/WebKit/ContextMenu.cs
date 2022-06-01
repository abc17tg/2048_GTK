// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ContextMenu : GLib.Object {

		public ContextMenu (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_new();
		static d_webkit_context_menu_new webkit_context_menu_new = FuncLoader.LoadFunction<d_webkit_context_menu_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_new"));

		public ContextMenu () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ContextMenu)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = webkit_context_menu_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_new_with_items(IntPtr items);
		static d_webkit_context_menu_new_with_items webkit_context_menu_new_with_items = FuncLoader.LoadFunction<d_webkit_context_menu_new_with_items>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_new_with_items"));

		public ContextMenu (GLib.List items) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ContextMenu)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = webkit_context_menu_new_with_items(items == null ? IntPtr.Zero : items.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_webkit_reserved0"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _webkit_reserved0
							, null
							, "_webkit_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved1
							, "_webkit_reserved0"
							, "_webkit_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved2
							, "_webkit_reserved1"
							, "_webkit_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved3
							, "_webkit_reserved2"
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
		delegate IntPtr d_webkit_context_menu_get_type();
		static d_webkit_context_menu_get_type webkit_context_menu_get_type = FuncLoader.LoadFunction<d_webkit_context_menu_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_context_menu_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_append(IntPtr raw, IntPtr item);
		static d_webkit_context_menu_append webkit_context_menu_append = FuncLoader.LoadFunction<d_webkit_context_menu_append>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_append"));

		public void Append(WebKit.ContextMenuItem item) {
			webkit_context_menu_append(Handle, item == null ? IntPtr.Zero : item.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_first(IntPtr raw);
		static d_webkit_context_menu_first webkit_context_menu_first = FuncLoader.LoadFunction<d_webkit_context_menu_first>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_first"));

		public WebKit.ContextMenuItem First() {
			IntPtr raw_ret = webkit_context_menu_first(Handle);
			WebKit.ContextMenuItem ret = GLib.Object.GetObject(raw_ret) as WebKit.ContextMenuItem;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_get_item_at_position(IntPtr raw, uint position);
		static d_webkit_context_menu_get_item_at_position webkit_context_menu_get_item_at_position = FuncLoader.LoadFunction<d_webkit_context_menu_get_item_at_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_get_item_at_position"));

		public WebKit.ContextMenuItem GetItemAtPosition(uint position) {
			IntPtr raw_ret = webkit_context_menu_get_item_at_position(Handle, position);
			WebKit.ContextMenuItem ret = GLib.Object.GetObject(raw_ret) as WebKit.ContextMenuItem;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_get_items(IntPtr raw);
		static d_webkit_context_menu_get_items webkit_context_menu_get_items = FuncLoader.LoadFunction<d_webkit_context_menu_get_items>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_get_items"));

		public WebKit.ContextMenuItem[] Items { 
			get {
				IntPtr raw_ret = webkit_context_menu_get_items(Handle);
				WebKit.ContextMenuItem[] ret = GLib.Marshaller.ListPtrToArray<WebKit.ContextMenuItem, WebKit.ContextMenuItem> (raw_ret, false, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_webkit_context_menu_get_n_items(IntPtr raw);
		static d_webkit_context_menu_get_n_items webkit_context_menu_get_n_items = FuncLoader.LoadFunction<d_webkit_context_menu_get_n_items>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_get_n_items"));

		public uint NItems { 
			get {
				uint raw_ret = webkit_context_menu_get_n_items(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_get_user_data(IntPtr raw);
		static d_webkit_context_menu_get_user_data webkit_context_menu_get_user_data = FuncLoader.LoadFunction<d_webkit_context_menu_get_user_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_get_user_data"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_set_user_data(IntPtr raw, IntPtr user_data);
		static d_webkit_context_menu_set_user_data webkit_context_menu_set_user_data = FuncLoader.LoadFunction<d_webkit_context_menu_set_user_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_set_user_data"));

		public GLib.Variant UserData { 
			get {
				IntPtr raw_ret = webkit_context_menu_get_user_data(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
			set {
				webkit_context_menu_set_user_data(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_insert(IntPtr raw, IntPtr item, int position);
		static d_webkit_context_menu_insert webkit_context_menu_insert = FuncLoader.LoadFunction<d_webkit_context_menu_insert>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_insert"));

		public void Insert(WebKit.ContextMenuItem item, int position) {
			webkit_context_menu_insert(Handle, item == null ? IntPtr.Zero : item.Handle, position);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_context_menu_last(IntPtr raw);
		static d_webkit_context_menu_last webkit_context_menu_last = FuncLoader.LoadFunction<d_webkit_context_menu_last>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_last"));

		public WebKit.ContextMenuItem Last() {
			IntPtr raw_ret = webkit_context_menu_last(Handle);
			WebKit.ContextMenuItem ret = GLib.Object.GetObject(raw_ret) as WebKit.ContextMenuItem;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_move_item(IntPtr raw, IntPtr item, int position);
		static d_webkit_context_menu_move_item webkit_context_menu_move_item = FuncLoader.LoadFunction<d_webkit_context_menu_move_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_move_item"));

		public void MoveItem(WebKit.ContextMenuItem item, int position) {
			webkit_context_menu_move_item(Handle, item == null ? IntPtr.Zero : item.Handle, position);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_prepend(IntPtr raw, IntPtr item);
		static d_webkit_context_menu_prepend webkit_context_menu_prepend = FuncLoader.LoadFunction<d_webkit_context_menu_prepend>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_prepend"));

		public void Prepend(WebKit.ContextMenuItem item) {
			webkit_context_menu_prepend(Handle, item == null ? IntPtr.Zero : item.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_remove(IntPtr raw, IntPtr item);
		static d_webkit_context_menu_remove webkit_context_menu_remove = FuncLoader.LoadFunction<d_webkit_context_menu_remove>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_remove"));

		public void Remove(WebKit.ContextMenuItem item) {
			webkit_context_menu_remove(Handle, item == null ? IntPtr.Zero : item.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_context_menu_remove_all(IntPtr raw);
		static d_webkit_context_menu_remove_all webkit_context_menu_remove_all = FuncLoader.LoadFunction<d_webkit_context_menu_remove_all>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_context_menu_remove_all"));

		public void RemoveAll() {
			webkit_context_menu_remove_all(Handle);
		}


		static ContextMenu ()
		{
			GtkSharp.WebkitGtkSharp.ObjectManager.Initialize ();
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
