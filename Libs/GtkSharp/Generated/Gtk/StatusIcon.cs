// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class StatusIcon : GLib.Object {

		public StatusIcon (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_new();
		static d_gtk_status_icon_new gtk_status_icon_new = FuncLoader.LoadFunction<d_gtk_status_icon_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_new"));

		public StatusIcon () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StatusIcon)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_status_icon_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_new_from_file(IntPtr filename);
		static d_gtk_status_icon_new_from_file gtk_status_icon_new_from_file = FuncLoader.LoadFunction<d_gtk_status_icon_new_from_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_new_from_file"));

		public StatusIcon (string filename) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StatusIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			Raw = gtk_status_icon_new_from_file(native_filename);
			GLib.Marshaller.Free (native_filename);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_new_from_gicon(IntPtr icon);
		static d_gtk_status_icon_new_from_gicon gtk_status_icon_new_from_gicon = FuncLoader.LoadFunction<d_gtk_status_icon_new_from_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_new_from_gicon"));

		public StatusIcon (GLib.IIcon icon) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StatusIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (icon != null) {
					names.Add ("icon");
					vals.Add (new GLib.Value (icon));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_status_icon_new_from_gicon(icon == null ? IntPtr.Zero : ((icon is GLib.Object) ? (icon as GLib.Object).Handle : (icon as GLib.IconAdapter).Handle));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_new_from_icon_name(IntPtr icon_name);
		static d_gtk_status_icon_new_from_icon_name gtk_status_icon_new_from_icon_name = FuncLoader.LoadFunction<d_gtk_status_icon_new_from_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_new_from_icon_name"));

		public static StatusIcon NewFromIconName(string icon_name)
		{
			IntPtr native_icon_name = GLib.Marshaller.StringToPtrGStrdup (icon_name);
			StatusIcon result = new StatusIcon (gtk_status_icon_new_from_icon_name(native_icon_name));
			GLib.Marshaller.Free (native_icon_name);
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_new_from_pixbuf(IntPtr pixbuf);
		static d_gtk_status_icon_new_from_pixbuf gtk_status_icon_new_from_pixbuf = FuncLoader.LoadFunction<d_gtk_status_icon_new_from_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_new_from_pixbuf"));

		public StatusIcon (Gdk.Pixbuf pixbuf) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StatusIcon)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (pixbuf != null) {
					names.Add ("pixbuf");
					vals.Add (new GLib.Value (pixbuf));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_status_icon_new_from_pixbuf(pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_new_from_stock(IntPtr stock_id);
		static d_gtk_status_icon_new_from_stock gtk_status_icon_new_from_stock = FuncLoader.LoadFunction<d_gtk_status_icon_new_from_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_new_from_stock"));

		public static StatusIcon NewFromStock(string stock_id)
		{
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			StatusIcon result = new StatusIcon (gtk_status_icon_new_from_stock(native_stock_id));
			GLib.Marshaller.Free (native_stock_id);
			return result;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_pixbuf(IntPtr raw);
		static d_gtk_status_icon_get_pixbuf gtk_status_icon_get_pixbuf = FuncLoader.LoadFunction<d_gtk_status_icon_get_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_pixbuf"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_from_pixbuf(IntPtr raw, IntPtr pixbuf);
		static d_gtk_status_icon_set_from_pixbuf gtk_status_icon_set_from_pixbuf = FuncLoader.LoadFunction<d_gtk_status_icon_set_from_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_from_pixbuf"));

		[Obsolete]
		[GLib.Property ("pixbuf")]
		public Gdk.Pixbuf Pixbuf {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
			set  {
				gtk_status_icon_set_from_pixbuf(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_from_file(IntPtr raw, IntPtr filename);
		static d_gtk_status_icon_set_from_file gtk_status_icon_set_from_file = FuncLoader.LoadFunction<d_gtk_status_icon_set_from_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_from_file"));

		[Obsolete]
		[GLib.Property ("file")]
		public string File {
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_from_file(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_stock(IntPtr raw);
		static d_gtk_status_icon_get_stock gtk_status_icon_get_stock = FuncLoader.LoadFunction<d_gtk_status_icon_get_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_stock"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_from_stock(IntPtr raw, IntPtr stock_id);
		static d_gtk_status_icon_set_from_stock gtk_status_icon_set_from_stock = FuncLoader.LoadFunction<d_gtk_status_icon_set_from_stock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_from_stock"));

		[Obsolete]
		[GLib.Property ("stock")]
		public string Stock {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_stock(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_from_stock(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_icon_name(IntPtr raw);
		static d_gtk_status_icon_get_icon_name gtk_status_icon_get_icon_name = FuncLoader.LoadFunction<d_gtk_status_icon_get_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_icon_name"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_from_icon_name(IntPtr raw, IntPtr icon_name);
		static d_gtk_status_icon_set_from_icon_name gtk_status_icon_set_from_icon_name = FuncLoader.LoadFunction<d_gtk_status_icon_set_from_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_from_icon_name"));

		[Obsolete]
		[GLib.Property ("icon-name")]
		public string IconName {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_from_icon_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_gicon(IntPtr raw);
		static d_gtk_status_icon_get_gicon gtk_status_icon_get_gicon = FuncLoader.LoadFunction<d_gtk_status_icon_get_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_gicon"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_from_gicon(IntPtr raw, IntPtr icon);
		static d_gtk_status_icon_set_from_gicon gtk_status_icon_set_from_gicon = FuncLoader.LoadFunction<d_gtk_status_icon_set_from_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_from_gicon"));

		[Obsolete]
		[GLib.Property ("gicon")]
		public GLib.IIcon Icon {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_gicon(Handle);
				GLib.IIcon ret = GLib.IconAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				gtk_status_icon_set_from_gicon(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.IconAdapter).Handle));
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_status_icon_get_storage_type(IntPtr raw);
		static d_gtk_status_icon_get_storage_type gtk_status_icon_get_storage_type = FuncLoader.LoadFunction<d_gtk_status_icon_get_storage_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_storage_type"));

		[Obsolete]
		[GLib.Property ("storage-type")]
		public Gtk.ImageType StorageType {
			get  {
				int raw_ret = gtk_status_icon_get_storage_type(Handle);
				Gtk.ImageType ret = (Gtk.ImageType) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_status_icon_get_size(IntPtr raw);
		static d_gtk_status_icon_get_size gtk_status_icon_get_size = FuncLoader.LoadFunction<d_gtk_status_icon_get_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_size"));

		[Obsolete]
		[GLib.Property ("size")]
		public int Size {
			get  {
				int raw_ret = gtk_status_icon_get_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_screen(IntPtr raw);
		static d_gtk_status_icon_get_screen gtk_status_icon_get_screen = FuncLoader.LoadFunction<d_gtk_status_icon_get_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_screen"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_screen(IntPtr raw, IntPtr screen);
		static d_gtk_status_icon_set_screen gtk_status_icon_set_screen = FuncLoader.LoadFunction<d_gtk_status_icon_set_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_screen"));

		[Obsolete]
		[GLib.Property ("screen")]
		public Gdk.Screen Screen {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_screen(Handle);
				Gdk.Screen ret = GLib.Object.GetObject(raw_ret) as Gdk.Screen;
				return ret;
			}
			set  {
				gtk_status_icon_set_screen(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_status_icon_get_visible(IntPtr raw);
		static d_gtk_status_icon_get_visible gtk_status_icon_get_visible = FuncLoader.LoadFunction<d_gtk_status_icon_get_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_visible"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_visible(IntPtr raw, bool visible);
		static d_gtk_status_icon_set_visible gtk_status_icon_set_visible = FuncLoader.LoadFunction<d_gtk_status_icon_set_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_visible"));

		[Obsolete]
		[GLib.Property ("visible")]
		public bool Visible {
			get  {
				bool raw_ret = gtk_status_icon_get_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_status_icon_set_visible(Handle, value);
			}
		}

		[GLib.Property ("embedded")]
		public bool Embedded {
			get {
				GLib.Value val = GetProperty ("embedded");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get {
				GLib.Value val = GetProperty ("orientation");
				Gtk.Orientation ret = (Gtk.Orientation) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_status_icon_get_has_tooltip(IntPtr raw);
		static d_gtk_status_icon_get_has_tooltip gtk_status_icon_get_has_tooltip = FuncLoader.LoadFunction<d_gtk_status_icon_get_has_tooltip>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_has_tooltip"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_has_tooltip(IntPtr raw, bool has_tooltip);
		static d_gtk_status_icon_set_has_tooltip gtk_status_icon_set_has_tooltip = FuncLoader.LoadFunction<d_gtk_status_icon_set_has_tooltip>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_has_tooltip"));

		[Obsolete]
		[GLib.Property ("has-tooltip")]
		public bool HasTooltip {
			get  {
				bool raw_ret = gtk_status_icon_get_has_tooltip(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_status_icon_set_has_tooltip(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_tooltip_text(IntPtr raw);
		static d_gtk_status_icon_get_tooltip_text gtk_status_icon_get_tooltip_text = FuncLoader.LoadFunction<d_gtk_status_icon_get_tooltip_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_tooltip_text"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_tooltip_text(IntPtr raw, IntPtr text);
		static d_gtk_status_icon_set_tooltip_text gtk_status_icon_set_tooltip_text = FuncLoader.LoadFunction<d_gtk_status_icon_set_tooltip_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_tooltip_text"));

		[Obsolete]
		[GLib.Property ("tooltip-text")]
		public string TooltipText {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_tooltip_text(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_tooltip_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_tooltip_markup(IntPtr raw);
		static d_gtk_status_icon_get_tooltip_markup gtk_status_icon_get_tooltip_markup = FuncLoader.LoadFunction<d_gtk_status_icon_get_tooltip_markup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_tooltip_markup"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_tooltip_markup(IntPtr raw, IntPtr markup);
		static d_gtk_status_icon_set_tooltip_markup gtk_status_icon_set_tooltip_markup = FuncLoader.LoadFunction<d_gtk_status_icon_set_tooltip_markup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_tooltip_markup"));

		[Obsolete]
		[GLib.Property ("tooltip-markup")]
		public string TooltipMarkup {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_tooltip_markup(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_tooltip_markup(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_status_icon_get_title(IntPtr raw);
		static d_gtk_status_icon_get_title gtk_status_icon_get_title = FuncLoader.LoadFunction<d_gtk_status_icon_get_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_title"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_title(IntPtr raw, IntPtr title);
		static d_gtk_status_icon_set_title gtk_status_icon_set_title = FuncLoader.LoadFunction<d_gtk_status_icon_set_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_title"));

		[Obsolete]
		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_status_icon_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Signal("size-changed")]
		public event Gtk.SizeChangedHandler SizeChanged {
			add {
				this.AddSignalHandler ("size-changed", value, typeof (Gtk.SizeChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("size-changed", value);
			}
		}

		[GLib.Signal("query_tooltip")]
		public event Gtk.QueryTooltipHandler QueryTooltip {
			add {
				this.AddSignalHandler ("query_tooltip", value, typeof (Gtk.QueryTooltipArgs));
			}
			remove {
				this.RemoveSignalHandler ("query_tooltip", value);
			}
		}

		[GLib.Signal("scroll_event")]
		public event Gtk.ScrollEventHandler ScrollEvent {
			add {
				this.AddSignalHandler ("scroll_event", value, typeof (Gtk.ScrollEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("scroll_event", value);
			}
		}

		[GLib.Signal("button_release_event")]
		public event Gtk.ButtonReleaseEventHandler ButtonReleaseEvent {
			add {
				this.AddSignalHandler ("button_release_event", value, typeof (Gtk.ButtonReleaseEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("button_release_event", value);
			}
		}

		[GLib.Signal("activate")]
		public event System.EventHandler Activate {
			add {
				this.AddSignalHandler ("activate", value);
			}
			remove {
				this.RemoveSignalHandler ("activate", value);
			}
		}

		[GLib.Signal("popup-menu")]
		public event Gtk.PopupMenuHandler PopupMenu {
			add {
				this.AddSignalHandler ("popup-menu", value, typeof (Gtk.PopupMenuArgs));
			}
			remove {
				this.RemoveSignalHandler ("popup-menu", value);
			}
		}

		[GLib.Signal("button_press_event")]
		public event Gtk.ButtonPressEventHandler ButtonPressEvent {
			add {
				this.AddSignalHandler ("button_press_event", value, typeof (Gtk.ButtonPressEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("button_press_event", value);
			}
		}

		static ActivateNativeDelegate Activate_cb_delegate;
		static ActivateNativeDelegate ActivateVMCallback {
			get {
				if (Activate_cb_delegate == null)
					Activate_cb_delegate = new ActivateNativeDelegate (Activate_cb);
				return Activate_cb_delegate;
			}
		}

		static void OverrideActivate (GLib.GType gtype)
		{
			OverrideActivate (gtype, ActivateVMCallback);
		}

		static void OverrideActivate (GLib.GType gtype, ActivateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateNativeDelegate (IntPtr inst);

		static void Activate_cb (IntPtr inst)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				__obj.OnActivate ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverrideActivate")]
		protected virtual void OnActivate ()
		{
			InternalActivate ();
		}

		private void InternalActivate ()
		{
			ActivateNativeDelegate unmanaged = class_abi.BaseOverride<ActivateNativeDelegate>(this.LookupGType(), "activate");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static PopupMenuNativeDelegate PopupMenu_cb_delegate;
		static PopupMenuNativeDelegate PopupMenuVMCallback {
			get {
				if (PopupMenu_cb_delegate == null)
					PopupMenu_cb_delegate = new PopupMenuNativeDelegate (PopupMenu_cb);
				return PopupMenu_cb_delegate;
			}
		}

		static void OverridePopupMenu (GLib.GType gtype)
		{
			OverridePopupMenu (gtype, PopupMenuVMCallback);
		}

		static void OverridePopupMenu (GLib.GType gtype, PopupMenuNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("popup_menu"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PopupMenuNativeDelegate (IntPtr inst, uint button, uint activate_time);

		static void PopupMenu_cb (IntPtr inst, uint button, uint activate_time)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				__obj.OnPopupMenu (button, activate_time);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverridePopupMenu")]
		protected virtual void OnPopupMenu (uint button, uint activate_time)
		{
			InternalPopupMenu (button, activate_time);
		}

		private void InternalPopupMenu (uint button, uint activate_time)
		{
			PopupMenuNativeDelegate unmanaged = class_abi.BaseOverride<PopupMenuNativeDelegate>(this.LookupGType(), "popup_menu");
			if (unmanaged == null) return;

			unmanaged (this.Handle, button, activate_time);
		}

		static SizeChangedNativeDelegate SizeChanged_cb_delegate;
		static SizeChangedNativeDelegate SizeChangedVMCallback {
			get {
				if (SizeChanged_cb_delegate == null)
					SizeChanged_cb_delegate = new SizeChangedNativeDelegate (SizeChanged_cb);
				return SizeChanged_cb_delegate;
			}
		}

		static void OverrideSizeChanged (GLib.GType gtype)
		{
			OverrideSizeChanged (gtype, SizeChangedVMCallback);
		}

		static void OverrideSizeChanged (GLib.GType gtype, SizeChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("size_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SizeChangedNativeDelegate (IntPtr inst, int size);

		static bool SizeChanged_cb (IntPtr inst, int size)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				bool __result;
				__result = __obj.OnSizeChanged (size);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverrideSizeChanged")]
		protected virtual bool OnSizeChanged (int size)
		{
			return InternalSizeChanged (size);
		}

		private bool InternalSizeChanged (int size)
		{
			SizeChangedNativeDelegate unmanaged = class_abi.BaseOverride<SizeChangedNativeDelegate>(this.LookupGType(), "size_changed");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, size);
			return __result;
		}

		static ButtonPressEventNativeDelegate ButtonPressEvent_cb_delegate;
		static ButtonPressEventNativeDelegate ButtonPressEventVMCallback {
			get {
				if (ButtonPressEvent_cb_delegate == null)
					ButtonPressEvent_cb_delegate = new ButtonPressEventNativeDelegate (ButtonPressEvent_cb);
				return ButtonPressEvent_cb_delegate;
			}
		}

		static void OverrideButtonPressEvent (GLib.GType gtype)
		{
			OverrideButtonPressEvent (gtype, ButtonPressEventVMCallback);
		}

		static void OverrideButtonPressEvent (GLib.GType gtype, ButtonPressEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("button_press_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ButtonPressEventNativeDelegate (IntPtr inst, IntPtr evnt);

		static bool ButtonPressEvent_cb (IntPtr inst, IntPtr evnt)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				bool __result;
				__result = __obj.OnButtonPressEvent (new Gdk.EventButton(evnt));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverrideButtonPressEvent")]
		protected virtual bool OnButtonPressEvent (Gdk.EventButton evnt)
		{
			return InternalButtonPressEvent (evnt);
		}

		private bool InternalButtonPressEvent (Gdk.EventButton evnt)
		{
			ButtonPressEventNativeDelegate unmanaged = class_abi.BaseOverride<ButtonPressEventNativeDelegate>(this.LookupGType(), "button_press_event");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			return __result;
		}

		static ButtonReleaseEventNativeDelegate ButtonReleaseEvent_cb_delegate;
		static ButtonReleaseEventNativeDelegate ButtonReleaseEventVMCallback {
			get {
				if (ButtonReleaseEvent_cb_delegate == null)
					ButtonReleaseEvent_cb_delegate = new ButtonReleaseEventNativeDelegate (ButtonReleaseEvent_cb);
				return ButtonReleaseEvent_cb_delegate;
			}
		}

		static void OverrideButtonReleaseEvent (GLib.GType gtype)
		{
			OverrideButtonReleaseEvent (gtype, ButtonReleaseEventVMCallback);
		}

		static void OverrideButtonReleaseEvent (GLib.GType gtype, ButtonReleaseEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("button_release_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ButtonReleaseEventNativeDelegate (IntPtr inst, IntPtr evnt);

		static bool ButtonReleaseEvent_cb (IntPtr inst, IntPtr evnt)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				bool __result;
				__result = __obj.OnButtonReleaseEvent (new Gdk.EventButton(evnt));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverrideButtonReleaseEvent")]
		protected virtual bool OnButtonReleaseEvent (Gdk.EventButton evnt)
		{
			return InternalButtonReleaseEvent (evnt);
		}

		private bool InternalButtonReleaseEvent (Gdk.EventButton evnt)
		{
			ButtonReleaseEventNativeDelegate unmanaged = class_abi.BaseOverride<ButtonReleaseEventNativeDelegate>(this.LookupGType(), "button_release_event");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			return __result;
		}

		static ScrollEventNativeDelegate ScrollEvent_cb_delegate;
		static ScrollEventNativeDelegate ScrollEventVMCallback {
			get {
				if (ScrollEvent_cb_delegate == null)
					ScrollEvent_cb_delegate = new ScrollEventNativeDelegate (ScrollEvent_cb);
				return ScrollEvent_cb_delegate;
			}
		}

		static void OverrideScrollEvent (GLib.GType gtype)
		{
			OverrideScrollEvent (gtype, ScrollEventVMCallback);
		}

		static void OverrideScrollEvent (GLib.GType gtype, ScrollEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("scroll_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ScrollEventNativeDelegate (IntPtr inst, IntPtr evnt);

		static bool ScrollEvent_cb (IntPtr inst, IntPtr evnt)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				bool __result;
				__result = __obj.OnScrollEvent (new Gdk.EventScroll(evnt));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverrideScrollEvent")]
		protected virtual bool OnScrollEvent (Gdk.EventScroll evnt)
		{
			return InternalScrollEvent (evnt);
		}

		private bool InternalScrollEvent (Gdk.EventScroll evnt)
		{
			ScrollEventNativeDelegate unmanaged = class_abi.BaseOverride<ScrollEventNativeDelegate>(this.LookupGType(), "scroll_event");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
			return __result;
		}

		static QueryTooltipNativeDelegate QueryTooltip_cb_delegate;
		static QueryTooltipNativeDelegate QueryTooltipVMCallback {
			get {
				if (QueryTooltip_cb_delegate == null)
					QueryTooltip_cb_delegate = new QueryTooltipNativeDelegate (QueryTooltip_cb);
				return QueryTooltip_cb_delegate;
			}
		}

		static void OverrideQueryTooltip (GLib.GType gtype)
		{
			OverrideQueryTooltip (gtype, QueryTooltipVMCallback);
		}

		static void OverrideQueryTooltip (GLib.GType gtype, QueryTooltipNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("query_tooltip"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool QueryTooltipNativeDelegate (IntPtr inst, int x, int y, bool keyboard_mode, IntPtr tooltip);

		static bool QueryTooltip_cb (IntPtr inst, int x, int y, bool keyboard_mode, IntPtr tooltip)
		{
			try {
				StatusIcon __obj = GLib.Object.GetObject (inst, false) as StatusIcon;
				bool __result;
				__result = __obj.OnQueryTooltip (x, y, keyboard_mode, GLib.Object.GetObject(tooltip) as Gtk.Tooltip);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StatusIcon), ConnectionMethod="OverrideQueryTooltip")]
		protected virtual bool OnQueryTooltip (int x, int y, bool keyboard_mode, Gtk.Tooltip tooltip)
		{
			return InternalQueryTooltip (x, y, keyboard_mode, tooltip);
		}

		private bool InternalQueryTooltip (int x, int y, bool keyboard_mode, Gtk.Tooltip tooltip)
		{
			QueryTooltipNativeDelegate unmanaged = class_abi.BaseOverride<QueryTooltipNativeDelegate>(this.LookupGType(), "query_tooltip");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, x, y, keyboard_mode, tooltip == null ? IntPtr.Zero : tooltip.Handle);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("activate"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // activate
							, null
							, "popup_menu"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("popup_menu"
							, -1
							, (uint) sizeof( IntPtr ) // popup_menu
							, "activate"
							, "size_changed"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("size_changed"
							, -1
							, (uint) sizeof( IntPtr ) // size_changed
							, "popup_menu"
							, "button_press_event"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("button_press_event"
							, -1
							, (uint) sizeof( IntPtr ) // button_press_event
							, "size_changed"
							, "button_release_event"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("button_release_event"
							, -1
							, (uint) sizeof( IntPtr ) // button_release_event
							, "button_press_event"
							, "scroll_event"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("scroll_event"
							, -1
							, (uint) sizeof( IntPtr ) // scroll_event
							, "button_release_event"
							, "query_tooltip"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("query_tooltip"
							, -1
							, (uint) sizeof( IntPtr ) // query_tooltip
							, "scroll_event"
							, "__gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("__gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // __gtk_reserved1
							, "query_tooltip"
							, "__gtk_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("__gtk_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // __gtk_reserved2
							, "__gtk_reserved1"
							, "__gtk_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("__gtk_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // __gtk_reserved3
							, "__gtk_reserved2"
							, "__gtk_reserved4"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("__gtk_reserved4"
							, -1
							, (uint) sizeof( IntPtr ) // __gtk_reserved4
							, "__gtk_reserved3"
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
		delegate IntPtr d_gtk_status_icon_get_type();
		static d_gtk_status_icon_get_type gtk_status_icon_get_type = FuncLoader.LoadFunction<d_gtk_status_icon_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_status_icon_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_gtk_status_icon_get_x11_window_id(IntPtr raw);
		static d_gtk_status_icon_get_x11_window_id gtk_status_icon_get_x11_window_id = FuncLoader.LoadFunction<d_gtk_status_icon_get_x11_window_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_get_x11_window_id"));

		[Obsolete]
		public uint X11WindowId { 
			get {
				uint raw_ret = gtk_status_icon_get_x11_window_id(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_status_icon_is_embedded(IntPtr raw);
		static d_gtk_status_icon_is_embedded gtk_status_icon_is_embedded = FuncLoader.LoadFunction<d_gtk_status_icon_is_embedded>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_is_embedded"));

		[Obsolete]
		public bool IsEmbedded { 
			get {
				bool raw_ret = gtk_status_icon_is_embedded(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_position_menu(IntPtr menu, out int x, out int y, out bool push_in, IntPtr user_data);
		static d_gtk_status_icon_position_menu gtk_status_icon_position_menu = FuncLoader.LoadFunction<d_gtk_status_icon_position_menu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_position_menu"));

		[Obsolete]
		public static void PositionMenu(Gtk.Menu menu, out int x, out int y, out bool push_in, IntPtr user_data) {
			gtk_status_icon_position_menu(menu == null ? IntPtr.Zero : menu.Handle, out x, out y, out push_in, user_data);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_status_icon_set_name(IntPtr raw, IntPtr name);
		static d_gtk_status_icon_set_name gtk_status_icon_set_name = FuncLoader.LoadFunction<d_gtk_status_icon_set_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_status_icon_set_name"));

		[Obsolete]
		public string Name { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_status_icon_set_name(Handle, native_value);
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
