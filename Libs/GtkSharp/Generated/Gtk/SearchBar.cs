// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class SearchBar : Gtk.Bin {

		public SearchBar (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_search_bar_new();
		static d_gtk_search_bar_new gtk_search_bar_new = FuncLoader.LoadFunction<d_gtk_search_bar_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_new"));

		public SearchBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SearchBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_search_bar_new();
		}

		[GLib.Property ("search-mode-enabled")]
		public bool SearchModeEnabled {
			get {
				GLib.Value val = GetProperty ("search-mode-enabled");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("search-mode-enabled", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_search_bar_get_show_close_button(IntPtr raw);
		static d_gtk_search_bar_get_show_close_button gtk_search_bar_get_show_close_button = FuncLoader.LoadFunction<d_gtk_search_bar_get_show_close_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_get_show_close_button"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_search_bar_set_show_close_button(IntPtr raw, bool visible);
		static d_gtk_search_bar_set_show_close_button gtk_search_bar_set_show_close_button = FuncLoader.LoadFunction<d_gtk_search_bar_set_show_close_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_set_show_close_button"));

		[GLib.Property ("show-close-button")]
		public bool ShowCloseButton {
			get  {
				bool raw_ret = gtk_search_bar_get_show_close_button(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_search_bar_set_show_close_button(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Bin.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, null
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
		delegate void d_gtk_search_bar_connect_entry(IntPtr raw, IntPtr entry);
		static d_gtk_search_bar_connect_entry gtk_search_bar_connect_entry = FuncLoader.LoadFunction<d_gtk_search_bar_connect_entry>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_connect_entry"));

		public void ConnectEntry(Gtk.Entry entry) {
			gtk_search_bar_connect_entry(Handle, entry == null ? IntPtr.Zero : entry.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_search_bar_get_search_mode(IntPtr raw);
		static d_gtk_search_bar_get_search_mode gtk_search_bar_get_search_mode = FuncLoader.LoadFunction<d_gtk_search_bar_get_search_mode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_get_search_mode"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_search_bar_set_search_mode(IntPtr raw, bool search_mode);
		static d_gtk_search_bar_set_search_mode gtk_search_bar_set_search_mode = FuncLoader.LoadFunction<d_gtk_search_bar_set_search_mode>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_set_search_mode"));

		public bool SearchMode { 
			get {
				bool raw_ret = gtk_search_bar_get_search_mode(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_search_bar_set_search_mode(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_search_bar_get_type();
		static d_gtk_search_bar_get_type gtk_search_bar_get_type = FuncLoader.LoadFunction<d_gtk_search_bar_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_search_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_search_bar_handle_event(IntPtr raw, IntPtr evnt);
		static d_gtk_search_bar_handle_event gtk_search_bar_handle_event = FuncLoader.LoadFunction<d_gtk_search_bar_handle_event>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_search_bar_handle_event"));

		public bool HandleEvent(Gdk.Event evnt) {
			bool raw_ret = gtk_search_bar_handle_event(Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Bin.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
