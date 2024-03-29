// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Application : GLib.Application {

		public Application (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_new(IntPtr application_id, int flags);
		static d_gtk_application_new gtk_application_new = FuncLoader.LoadFunction<d_gtk_application_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_new"));

		public Application (string application_id, GLib.ApplicationFlags flags) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Application)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("application_id");
				vals.Add (new GLib.Value (application_id));
				names.Add ("flags");
				vals.Add (new GLib.Value (flags));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_application_id = GLib.Marshaller.StringToPtrGStrdup (application_id);
			Raw = gtk_application_new(native_application_id, (int) flags);
			GLib.Marshaller.Free (native_application_id);
		}

		[GLib.Property ("register-session")]
		public bool RegisterSession {
			get {
				GLib.Value val = GetProperty ("register-session");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("register-session", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_app_menu(IntPtr raw);
		static d_gtk_application_get_app_menu gtk_application_get_app_menu = FuncLoader.LoadFunction<d_gtk_application_get_app_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_app_menu"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_set_app_menu(IntPtr raw, IntPtr app_menu);
		static d_gtk_application_set_app_menu gtk_application_set_app_menu = FuncLoader.LoadFunction<d_gtk_application_set_app_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_set_app_menu"));

		[GLib.Property ("app-menu")]
		public GLib.MenuModel AppMenu {
			get  {
				IntPtr raw_ret = gtk_application_get_app_menu(Handle);
				GLib.MenuModel ret = GLib.Object.GetObject(raw_ret) as GLib.MenuModel;
				return ret;
			}
			set  {
				gtk_application_set_app_menu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_menubar(IntPtr raw);
		static d_gtk_application_get_menubar gtk_application_get_menubar = FuncLoader.LoadFunction<d_gtk_application_get_menubar>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_menubar"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_set_menubar(IntPtr raw, IntPtr menubar);
		static d_gtk_application_set_menubar gtk_application_set_menubar = FuncLoader.LoadFunction<d_gtk_application_set_menubar>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_set_menubar"));

		[GLib.Property ("menubar")]
		public GLib.MenuModel Menubar {
			get  {
				IntPtr raw_ret = gtk_application_get_menubar(Handle);
				GLib.MenuModel ret = GLib.Object.GetObject(raw_ret) as GLib.MenuModel;
				return ret;
			}
			set  {
				gtk_application_set_menubar(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_active_window(IntPtr raw);
		static d_gtk_application_get_active_window gtk_application_get_active_window = FuncLoader.LoadFunction<d_gtk_application_get_active_window>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_active_window"));

		[GLib.Property ("active-window")]
		public Gtk.Window ActiveWindow {
			get  {
				IntPtr raw_ret = gtk_application_get_active_window(Handle);
				Gtk.Window ret = GLib.Object.GetObject(raw_ret) as Gtk.Window;
				return ret;
			}
		}

		[GLib.Signal("window-removed")]
		public event Gtk.WindowRemovedHandler WindowRemoved {
			add {
				this.AddSignalHandler ("window-removed", value, typeof (Gtk.WindowRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("window-removed", value);
			}
		}

		[GLib.Signal("window-added")]
		public event Gtk.WindowAddedHandler WindowAdded {
			add {
				this.AddSignalHandler ("window-added", value, typeof (Gtk.WindowAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("window-added", value);
			}
		}

		static WindowAddedNativeDelegate WindowAdded_cb_delegate;
		static WindowAddedNativeDelegate WindowAddedVMCallback {
			get {
				if (WindowAdded_cb_delegate == null)
					WindowAdded_cb_delegate = new WindowAddedNativeDelegate (WindowAdded_cb);
				return WindowAdded_cb_delegate;
			}
		}

		static void OverrideWindowAdded (GLib.GType gtype)
		{
			OverrideWindowAdded (gtype, WindowAddedVMCallback);
		}

		static void OverrideWindowAdded (GLib.GType gtype, WindowAddedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("window_added"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WindowAddedNativeDelegate (IntPtr inst, IntPtr window);

		static void WindowAdded_cb (IntPtr inst, IntPtr window)
		{
			try {
				Application __obj = GLib.Object.GetObject (inst, false) as Application;
				__obj.OnWindowAdded (GLib.Object.GetObject(window) as Gtk.Window);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Application), ConnectionMethod="OverrideWindowAdded")]
		protected virtual void OnWindowAdded (Gtk.Window window)
		{
			InternalWindowAdded (window);
		}

		private void InternalWindowAdded (Gtk.Window window)
		{
			WindowAddedNativeDelegate unmanaged = class_abi.BaseOverride<WindowAddedNativeDelegate>(this.LookupGType(), "window_added");
			if (unmanaged == null) return;

			unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle);
		}

		static WindowRemovedNativeDelegate WindowRemoved_cb_delegate;
		static WindowRemovedNativeDelegate WindowRemovedVMCallback {
			get {
				if (WindowRemoved_cb_delegate == null)
					WindowRemoved_cb_delegate = new WindowRemovedNativeDelegate (WindowRemoved_cb);
				return WindowRemoved_cb_delegate;
			}
		}

		static void OverrideWindowRemoved (GLib.GType gtype)
		{
			OverrideWindowRemoved (gtype, WindowRemovedVMCallback);
		}

		static void OverrideWindowRemoved (GLib.GType gtype, WindowRemovedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("window_removed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WindowRemovedNativeDelegate (IntPtr inst, IntPtr window);

		static void WindowRemoved_cb (IntPtr inst, IntPtr window)
		{
			try {
				Application __obj = GLib.Object.GetObject (inst, false) as Application;
				__obj.OnWindowRemoved (GLib.Object.GetObject(window) as Gtk.Window);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Application), ConnectionMethod="OverrideWindowRemoved")]
		protected virtual void OnWindowRemoved (Gtk.Window window)
		{
			InternalWindowRemoved (window);
		}

		private void InternalWindowRemoved (Gtk.Window window)
		{
			WindowRemovedNativeDelegate unmanaged = class_abi.BaseOverride<WindowRemovedNativeDelegate>(this.LookupGType(), "window_removed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("window_added"
							, GLib.Application.class_abi.Fields
							, (uint) sizeof( IntPtr ) // window_added
							, null
							, "window_removed"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("window_removed"
							, -1
							, (uint) sizeof( IntPtr ) // window_removed
							, "window_added"
							, "padding"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) sizeof( IntPtr ) * 12 // padding
							, "window_removed"
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
		delegate void d_gtk_application_add_accelerator(IntPtr raw, IntPtr accelerator, IntPtr action_name, IntPtr parameter);
		static d_gtk_application_add_accelerator gtk_application_add_accelerator = FuncLoader.LoadFunction<d_gtk_application_add_accelerator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_add_accelerator"));

		[Obsolete]
		public void AddAccelerator(string accelerator, string action_name, GLib.Variant parameter) {
			IntPtr native_accelerator = GLib.Marshaller.StringToPtrGStrdup (accelerator);
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_application_add_accelerator(Handle, native_accelerator, native_action_name, parameter == null ? IntPtr.Zero : parameter.Handle);
			GLib.Marshaller.Free (native_accelerator);
			GLib.Marshaller.Free (native_action_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_add_window(IntPtr raw, IntPtr window);
		static d_gtk_application_add_window gtk_application_add_window = FuncLoader.LoadFunction<d_gtk_application_add_window>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_add_window"));

		public void AddWindow(Gtk.Window window) {
			gtk_application_add_window(Handle, window == null ? IntPtr.Zero : window.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_accels_for_action(IntPtr raw, IntPtr detailed_action_name);
		static d_gtk_application_get_accels_for_action gtk_application_get_accels_for_action = FuncLoader.LoadFunction<d_gtk_application_get_accels_for_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_accels_for_action"));

		public string[] GetAccelsForAction(string detailed_action_name) {
			IntPtr native_detailed_action_name = GLib.Marshaller.StringToPtrGStrdup (detailed_action_name);
			IntPtr raw_ret = gtk_application_get_accels_for_action(Handle, native_detailed_action_name);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			GLib.Marshaller.Free (native_detailed_action_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_actions_for_accel(IntPtr raw, IntPtr accel);
		static d_gtk_application_get_actions_for_accel gtk_application_get_actions_for_accel = FuncLoader.LoadFunction<d_gtk_application_get_actions_for_accel>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_actions_for_accel"));

		public string[] GetActionsForAccel(string accel) {
			IntPtr native_accel = GLib.Marshaller.StringToPtrGStrdup (accel);
			IntPtr raw_ret = gtk_application_get_actions_for_accel(Handle, native_accel);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			GLib.Marshaller.Free (native_accel);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_menu_by_id(IntPtr raw, IntPtr id);
		static d_gtk_application_get_menu_by_id gtk_application_get_menu_by_id = FuncLoader.LoadFunction<d_gtk_application_get_menu_by_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_menu_by_id"));

		public GLib.Menu GetMenuById(string id) {
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			IntPtr raw_ret = gtk_application_get_menu_by_id(Handle, native_id);
			GLib.Menu ret = GLib.Object.GetObject(raw_ret) as GLib.Menu;
			GLib.Marshaller.Free (native_id);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_type();
		static d_gtk_application_get_type gtk_application_get_type = FuncLoader.LoadFunction<d_gtk_application_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_application_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_window_by_id(IntPtr raw, uint id);
		static d_gtk_application_get_window_by_id gtk_application_get_window_by_id = FuncLoader.LoadFunction<d_gtk_application_get_window_by_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_window_by_id"));

		public Gtk.Window GetWindowById(uint id) {
			IntPtr raw_ret = gtk_application_get_window_by_id(Handle, id);
			Gtk.Window ret = GLib.Object.GetObject(raw_ret) as Gtk.Window;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_get_windows(IntPtr raw);
		static d_gtk_application_get_windows gtk_application_get_windows = FuncLoader.LoadFunction<d_gtk_application_get_windows>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_get_windows"));

		public Gtk.Window[] Windows { 
			get {
				IntPtr raw_ret = gtk_application_get_windows(Handle);
				Gtk.Window[] ret = GLib.Marshaller.ListPtrToArray<Gtk.Window, Gtk.Window> (raw_ret, false, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_application_inhibit(IntPtr raw, IntPtr window, int flags, IntPtr reason);
		static d_gtk_application_inhibit gtk_application_inhibit = FuncLoader.LoadFunction<d_gtk_application_inhibit>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_inhibit"));

		public uint Inhibit(Gtk.Window window, Gtk.ApplicationInhibitFlags flags, string reason) {
			IntPtr native_reason = GLib.Marshaller.StringToPtrGStrdup (reason);
			uint raw_ret = gtk_application_inhibit(Handle, window == null ? IntPtr.Zero : window.Handle, (int) flags, native_reason);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_reason);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_application_is_inhibited(IntPtr raw, int flags);
		static d_gtk_application_is_inhibited gtk_application_is_inhibited = FuncLoader.LoadFunction<d_gtk_application_is_inhibited>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_is_inhibited"));

		public bool IsInhibited(Gtk.ApplicationInhibitFlags flags) {
			bool raw_ret = gtk_application_is_inhibited(Handle, (int) flags);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_application_list_action_descriptions(IntPtr raw);
		static d_gtk_application_list_action_descriptions gtk_application_list_action_descriptions = FuncLoader.LoadFunction<d_gtk_application_list_action_descriptions>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_list_action_descriptions"));

		public string ListActionDescriptions() {
			IntPtr raw_ret = gtk_application_list_action_descriptions(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_application_prefers_app_menu(IntPtr raw);
		static d_gtk_application_prefers_app_menu gtk_application_prefers_app_menu = FuncLoader.LoadFunction<d_gtk_application_prefers_app_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_prefers_app_menu"));

		public bool PrefersAppMenu() {
			bool raw_ret = gtk_application_prefers_app_menu(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_remove_accelerator(IntPtr raw, IntPtr action_name, IntPtr parameter);
		static d_gtk_application_remove_accelerator gtk_application_remove_accelerator = FuncLoader.LoadFunction<d_gtk_application_remove_accelerator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_remove_accelerator"));

		[Obsolete]
		public void RemoveAccelerator(string action_name, GLib.Variant parameter) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_application_remove_accelerator(Handle, native_action_name, parameter == null ? IntPtr.Zero : parameter.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_remove_window(IntPtr raw, IntPtr window);
		static d_gtk_application_remove_window gtk_application_remove_window = FuncLoader.LoadFunction<d_gtk_application_remove_window>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_remove_window"));

		public void RemoveWindow(Gtk.Window window) {
			gtk_application_remove_window(Handle, window == null ? IntPtr.Zero : window.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_set_accels_for_action(IntPtr raw, IntPtr detailed_action_name, IntPtr[] accels);
		static d_gtk_application_set_accels_for_action gtk_application_set_accels_for_action = FuncLoader.LoadFunction<d_gtk_application_set_accels_for_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_set_accels_for_action"));

		public void SetAccelsForAction(string detailed_action_name, string[] accels) {
			IntPtr native_detailed_action_name = GLib.Marshaller.StringToPtrGStrdup (detailed_action_name);
			int cnt_accels = accels == null ? 0 : accels.Length;
			IntPtr[] native_accels = new IntPtr [cnt_accels + 1];
			for (int i = 0; i < cnt_accels; i++)
				native_accels [i] = GLib.Marshaller.StringToPtrGStrdup (accels[i]);
			native_accels [cnt_accels] = IntPtr.Zero;
			gtk_application_set_accels_for_action(Handle, native_detailed_action_name, native_accels);
			GLib.Marshaller.Free (native_detailed_action_name);
			for (int i = 0; i < native_accels.Length - 1; i++) {
				accels [i] = GLib.Marshaller.Utf8PtrToString (native_accels[i]);
				GLib.Marshaller.Free (native_accels[i]);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_application_uninhibit(IntPtr raw, uint cookie);
		static d_gtk_application_uninhibit gtk_application_uninhibit = FuncLoader.LoadFunction<d_gtk_application_uninhibit>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_application_uninhibit"));

		public void Uninhibit(uint cookie) {
			gtk_application_uninhibit(Handle, cookie);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Application.abi_info.Fields
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
