// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class StyleContext : GLib.Object {

		public StyleContext (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_new();
		static d_gtk_style_context_new gtk_style_context_new = FuncLoader.LoadFunction<d_gtk_style_context_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_new"));

		public StyleContext () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (StyleContext)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_style_context_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_screen(IntPtr raw);
		static d_gtk_style_context_get_screen gtk_style_context_get_screen = FuncLoader.LoadFunction<d_gtk_style_context_get_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_screen"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_screen(IntPtr raw, IntPtr screen);
		static d_gtk_style_context_set_screen gtk_style_context_set_screen = FuncLoader.LoadFunction<d_gtk_style_context_set_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_screen"));

		[GLib.Property ("screen")]
		public Gdk.Screen Screen {
			get  {
				IntPtr raw_ret = gtk_style_context_get_screen(Handle);
				Gdk.Screen ret = GLib.Object.GetObject(raw_ret) as Gdk.Screen;
				return ret;
			}
			set  {
				gtk_style_context_set_screen(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("paint-clock")]
		public Gdk.FrameClock PaintClock {
			get {
				GLib.Value val = GetProperty ("paint-clock");
				Gdk.FrameClock ret = (Gdk.FrameClock) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("paint-clock", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_style_context_get_direction(IntPtr raw);
		static d_gtk_style_context_get_direction gtk_style_context_get_direction = FuncLoader.LoadFunction<d_gtk_style_context_get_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_direction"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_direction(IntPtr raw, int direction);
		static d_gtk_style_context_set_direction gtk_style_context_set_direction = FuncLoader.LoadFunction<d_gtk_style_context_set_direction>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_direction"));

		[Obsolete]
		[GLib.Property ("direction")]
		public Gtk.TextDirection Direction {
			get  {
				int raw_ret = gtk_style_context_get_direction(Handle);
				Gtk.TextDirection ret = (Gtk.TextDirection) raw_ret;
				return ret;
			}
			set  {
				gtk_style_context_set_direction(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_parent(IntPtr raw);
		static d_gtk_style_context_get_parent gtk_style_context_get_parent = FuncLoader.LoadFunction<d_gtk_style_context_get_parent>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_parent"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_parent(IntPtr raw, IntPtr parent);
		static d_gtk_style_context_set_parent gtk_style_context_set_parent = FuncLoader.LoadFunction<d_gtk_style_context_set_parent>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_parent"));

		[GLib.Property ("parent")]
		public Gtk.StyleContext Parent {
			get  {
				IntPtr raw_ret = gtk_style_context_get_parent(Handle);
				Gtk.StyleContext ret = GLib.Object.GetObject(raw_ret) as Gtk.StyleContext;
				return ret;
			}
			set  {
				gtk_style_context_set_parent(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				StyleContext __obj = GLib.Object.GetObject (inst, false) as StyleContext;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.StyleContext), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = class_abi.BaseOverride<ChangedNativeDelegate>(this.LookupGType(), "changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("changed"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // changed
							, null
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "changed"
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
		delegate void d_gtk_style_context_add_class(IntPtr raw, IntPtr class_name);
		static d_gtk_style_context_add_class gtk_style_context_add_class = FuncLoader.LoadFunction<d_gtk_style_context_add_class>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_add_class"));

		public void AddClass(string class_name) {
			IntPtr native_class_name = GLib.Marshaller.StringToPtrGStrdup (class_name);
			gtk_style_context_add_class(Handle, native_class_name);
			GLib.Marshaller.Free (native_class_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_add_provider(IntPtr raw, IntPtr provider, uint priority);
		static d_gtk_style_context_add_provider gtk_style_context_add_provider = FuncLoader.LoadFunction<d_gtk_style_context_add_provider>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_add_provider"));

		public void AddProvider(Gtk.IStyleProvider provider, uint priority) {
			gtk_style_context_add_provider(Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle), priority);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_add_provider_for_screen(IntPtr screen, IntPtr provider, uint priority);
		static d_gtk_style_context_add_provider_for_screen gtk_style_context_add_provider_for_screen = FuncLoader.LoadFunction<d_gtk_style_context_add_provider_for_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_add_provider_for_screen"));

		public static void AddProviderForScreen(Gdk.Screen screen, Gtk.IStyleProvider provider, uint priority) {
			gtk_style_context_add_provider_for_screen(screen == null ? IntPtr.Zero : screen.Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle), priority);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_add_region(IntPtr raw, IntPtr region_name, int flags);
		static d_gtk_style_context_add_region gtk_style_context_add_region = FuncLoader.LoadFunction<d_gtk_style_context_add_region>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_add_region"));

		[Obsolete]
		public void AddRegion(string region_name, Gtk.RegionFlags flags) {
			IntPtr native_region_name = GLib.Marshaller.StringToPtrGStrdup (region_name);
			gtk_style_context_add_region(Handle, native_region_name, (int) flags);
			GLib.Marshaller.Free (native_region_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_cancel_animations(IntPtr raw, IntPtr region_id);
		static d_gtk_style_context_cancel_animations gtk_style_context_cancel_animations = FuncLoader.LoadFunction<d_gtk_style_context_cancel_animations>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_cancel_animations"));

		[Obsolete]
		public void CancelAnimations(IntPtr region_id) {
			gtk_style_context_cancel_animations(Handle, region_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_background_color(IntPtr raw, int state, IntPtr color);
		static d_gtk_style_context_get_background_color gtk_style_context_get_background_color = FuncLoader.LoadFunction<d_gtk_style_context_get_background_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_background_color"));

		[Obsolete]
		public Gdk.RGBA GetBackgroundColor(Gtk.StateFlags state) {
			Gdk.RGBA color;
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf<Gdk.RGBA>());
			gtk_style_context_get_background_color(Handle, (int) state, native_color);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return color;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_border(IntPtr raw, int state, IntPtr border);
		static d_gtk_style_context_get_border gtk_style_context_get_border = FuncLoader.LoadFunction<d_gtk_style_context_get_border>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_border"));

		public Gtk.Border GetBorder(Gtk.StateFlags state) {
			Gtk.Border border;
			IntPtr native_border = Marshal.AllocHGlobal (Marshal.SizeOf<Gtk.Border>());
			gtk_style_context_get_border(Handle, (int) state, native_border);
			border = Gtk.Border.New (native_border);
			Marshal.FreeHGlobal (native_border);
			return border;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_border_color(IntPtr raw, int state, IntPtr color);
		static d_gtk_style_context_get_border_color gtk_style_context_get_border_color = FuncLoader.LoadFunction<d_gtk_style_context_get_border_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_border_color"));

		[Obsolete]
		public Gdk.RGBA GetBorderColor(Gtk.StateFlags state) {
			Gdk.RGBA color;
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf<Gdk.RGBA>());
			gtk_style_context_get_border_color(Handle, (int) state, native_color);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return color;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_color(IntPtr raw, int state, IntPtr color);
		static d_gtk_style_context_get_color gtk_style_context_get_color = FuncLoader.LoadFunction<d_gtk_style_context_get_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_color"));

		public Gdk.RGBA GetColor(Gtk.StateFlags state) {
			Gdk.RGBA color;
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf<Gdk.RGBA>());
			gtk_style_context_get_color(Handle, (int) state, native_color);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return color;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_font(IntPtr raw, int state);
		static d_gtk_style_context_get_font gtk_style_context_get_font = FuncLoader.LoadFunction<d_gtk_style_context_get_font>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_font"));

		[Obsolete]
		public Pango.FontDescription GetFont(Gtk.StateFlags state) {
			IntPtr raw_ret = gtk_style_context_get_font(Handle, (int) state);
			Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_frame_clock(IntPtr raw);
		static d_gtk_style_context_get_frame_clock gtk_style_context_get_frame_clock = FuncLoader.LoadFunction<d_gtk_style_context_get_frame_clock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_frame_clock"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_frame_clock(IntPtr raw, IntPtr frame_clock);
		static d_gtk_style_context_set_frame_clock gtk_style_context_set_frame_clock = FuncLoader.LoadFunction<d_gtk_style_context_set_frame_clock>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_frame_clock"));

		public Gdk.FrameClock FrameClock { 
			get {
				IntPtr raw_ret = gtk_style_context_get_frame_clock(Handle);
				Gdk.FrameClock ret = GLib.Object.GetObject(raw_ret) as Gdk.FrameClock;
				return ret;
			}
			set {
				gtk_style_context_set_frame_clock(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_style_context_get_junction_sides(IntPtr raw);
		static d_gtk_style_context_get_junction_sides gtk_style_context_get_junction_sides = FuncLoader.LoadFunction<d_gtk_style_context_get_junction_sides>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_junction_sides"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_junction_sides(IntPtr raw, int sides);
		static d_gtk_style_context_set_junction_sides gtk_style_context_set_junction_sides = FuncLoader.LoadFunction<d_gtk_style_context_set_junction_sides>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_junction_sides"));

		public Gtk.JunctionSides JunctionSides { 
			get {
				int raw_ret = gtk_style_context_get_junction_sides(Handle);
				Gtk.JunctionSides ret = (Gtk.JunctionSides) raw_ret;
				return ret;
			}
			set {
				gtk_style_context_set_junction_sides(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_margin(IntPtr raw, int state, IntPtr margin);
		static d_gtk_style_context_get_margin gtk_style_context_get_margin = FuncLoader.LoadFunction<d_gtk_style_context_get_margin>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_margin"));

		public Gtk.Border GetMargin(Gtk.StateFlags state) {
			Gtk.Border margin;
			IntPtr native_margin = Marshal.AllocHGlobal (Marshal.SizeOf<Gtk.Border>());
			gtk_style_context_get_margin(Handle, (int) state, native_margin);
			margin = Gtk.Border.New (native_margin);
			Marshal.FreeHGlobal (native_margin);
			return margin;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_padding(IntPtr raw, int state, IntPtr padding);
		static d_gtk_style_context_get_padding gtk_style_context_get_padding = FuncLoader.LoadFunction<d_gtk_style_context_get_padding>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_padding"));

		public Gtk.Border GetPadding(Gtk.StateFlags state) {
			Gtk.Border padding;
			IntPtr native_padding = Marshal.AllocHGlobal (Marshal.SizeOf<Gtk.Border>());
			gtk_style_context_get_padding(Handle, (int) state, native_padding);
			padding = Gtk.Border.New (native_padding);
			Marshal.FreeHGlobal (native_padding);
			return padding;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_path(IntPtr raw);
		static d_gtk_style_context_get_path gtk_style_context_get_path = FuncLoader.LoadFunction<d_gtk_style_context_get_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_path"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_path(IntPtr raw, IntPtr path);
		static d_gtk_style_context_set_path gtk_style_context_set_path = FuncLoader.LoadFunction<d_gtk_style_context_set_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_path"));

		public Gtk.WidgetPath Path { 
			get {
				IntPtr raw_ret = gtk_style_context_get_path(Handle);
				Gtk.WidgetPath ret = raw_ret == IntPtr.Zero ? null : (Gtk.WidgetPath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.WidgetPath), false);
				return ret;
			}
			set {
				gtk_style_context_set_path(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_property(IntPtr raw, IntPtr property, int state, IntPtr value);
		static d_gtk_style_context_get_property gtk_style_context_get_property = FuncLoader.LoadFunction<d_gtk_style_context_get_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_property"));

		public GLib.Value GetProperty(string property, Gtk.StateFlags state) {
			GLib.Value value;
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			IntPtr native_value = Marshal.AllocHGlobal (Marshal.SizeOf<GLib.Value>());
			gtk_style_context_get_property(Handle, native_property, (int) state, native_value);
			GLib.Marshaller.Free (native_property);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
			return value;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_style_context_get_scale(IntPtr raw);
		static d_gtk_style_context_get_scale gtk_style_context_get_scale = FuncLoader.LoadFunction<d_gtk_style_context_get_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_scale"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_scale(IntPtr raw, int scale);
		static d_gtk_style_context_set_scale gtk_style_context_set_scale = FuncLoader.LoadFunction<d_gtk_style_context_set_scale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_scale"));

		public int Scale { 
			get {
				int raw_ret = gtk_style_context_get_scale(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_style_context_set_scale(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_section(IntPtr raw, IntPtr property);
		static d_gtk_style_context_get_section gtk_style_context_get_section = FuncLoader.LoadFunction<d_gtk_style_context_get_section>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_section"));

		public Gtk.CssSection GetSection(string property) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			IntPtr raw_ret = gtk_style_context_get_section(Handle, native_property);
			Gtk.CssSection ret = raw_ret == IntPtr.Zero ? null : (Gtk.CssSection) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.CssSection), false);
			GLib.Marshaller.Free (native_property);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_style_context_get_state(IntPtr raw);
		static d_gtk_style_context_get_state gtk_style_context_get_state = FuncLoader.LoadFunction<d_gtk_style_context_get_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_state"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_state(IntPtr raw, int flags);
		static d_gtk_style_context_set_state gtk_style_context_set_state = FuncLoader.LoadFunction<d_gtk_style_context_set_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_state"));

		public Gtk.StateFlags State { 
			get {
				int raw_ret = gtk_style_context_get_state(Handle);
				Gtk.StateFlags ret = (Gtk.StateFlags) raw_ret;
				return ret;
			}
			set {
				gtk_style_context_set_state(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_get_style_property(IntPtr raw, IntPtr property_name, IntPtr value);
		static d_gtk_style_context_get_style_property gtk_style_context_get_style_property = FuncLoader.LoadFunction<d_gtk_style_context_get_style_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_style_property"));

		public GLib.Value GetStyleProperty(string property_name) {
			GLib.Value value;
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			IntPtr native_value = Marshal.AllocHGlobal (Marshal.SizeOf<GLib.Value>());
			gtk_style_context_get_style_property(Handle, native_property_name, native_value);
			GLib.Marshaller.Free (native_property_name);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
			return value;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_get_type();
		static d_gtk_style_context_get_type gtk_style_context_get_type = FuncLoader.LoadFunction<d_gtk_style_context_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_style_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_context_has_class(IntPtr raw, IntPtr class_name);
		static d_gtk_style_context_has_class gtk_style_context_has_class = FuncLoader.LoadFunction<d_gtk_style_context_has_class>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_has_class"));

		public bool HasClass(string class_name) {
			IntPtr native_class_name = GLib.Marshaller.StringToPtrGStrdup (class_name);
			bool raw_ret = gtk_style_context_has_class(Handle, native_class_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_class_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_context_has_region(IntPtr raw, IntPtr region_name, out int flags_return);
		static d_gtk_style_context_has_region gtk_style_context_has_region = FuncLoader.LoadFunction<d_gtk_style_context_has_region>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_has_region"));

		[Obsolete]
		public bool HasRegion(string region_name, out Gtk.RegionFlags flags_return) {
			IntPtr native_region_name = GLib.Marshaller.StringToPtrGStrdup (region_name);
			int native_flags_return;
			bool raw_ret = gtk_style_context_has_region(Handle, native_region_name, out native_flags_return);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_region_name);
			flags_return = (Gtk.RegionFlags) native_flags_return;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_invalidate(IntPtr raw);
		static d_gtk_style_context_invalidate gtk_style_context_invalidate = FuncLoader.LoadFunction<d_gtk_style_context_invalidate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_invalidate"));

		[Obsolete]
		public void Invalidate() {
			gtk_style_context_invalidate(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_list_classes(IntPtr raw);
		static d_gtk_style_context_list_classes gtk_style_context_list_classes = FuncLoader.LoadFunction<d_gtk_style_context_list_classes>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_list_classes"));

		public string[] ListClasses() {
			IntPtr raw_ret = gtk_style_context_list_classes(Handle);
			string[] ret = GLib.Marshaller.ListPtrToArray<string, string> (raw_ret, true, false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_list_regions(IntPtr raw);
		static d_gtk_style_context_list_regions gtk_style_context_list_regions = FuncLoader.LoadFunction<d_gtk_style_context_list_regions>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_list_regions"));

		[Obsolete]
		public string[] ListRegions() {
			IntPtr raw_ret = gtk_style_context_list_regions(Handle);
			string[] ret = GLib.Marshaller.ListPtrToArray<string, string> (raw_ret, true, false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_context_lookup_color(IntPtr raw, IntPtr color_name, IntPtr color);
		static d_gtk_style_context_lookup_color gtk_style_context_lookup_color = FuncLoader.LoadFunction<d_gtk_style_context_lookup_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_lookup_color"));

		public bool LookupColor(string color_name, out Gdk.RGBA color) {
			IntPtr native_color_name = GLib.Marshaller.StringToPtrGStrdup (color_name);
			IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf<Gdk.RGBA>());
			bool raw_ret = gtk_style_context_lookup_color(Handle, native_color_name, native_color);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_color_name);
			color = Gdk.RGBA.New (native_color);
			Marshal.FreeHGlobal (native_color);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_lookup_icon_set(IntPtr raw, IntPtr stock_id);
		static d_gtk_style_context_lookup_icon_set gtk_style_context_lookup_icon_set = FuncLoader.LoadFunction<d_gtk_style_context_lookup_icon_set>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_lookup_icon_set"));

		[Obsolete]
		public Gtk.IconSet LookupIconSet(string stock_id) {
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			IntPtr raw_ret = gtk_style_context_lookup_icon_set(Handle, native_stock_id);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), false);
			GLib.Marshaller.Free (native_stock_id);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_notify_state_change(IntPtr raw, IntPtr window, IntPtr region_id, int state, bool state_value);
		static d_gtk_style_context_notify_state_change gtk_style_context_notify_state_change = FuncLoader.LoadFunction<d_gtk_style_context_notify_state_change>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_notify_state_change"));

		[Obsolete]
		public void NotifyStateChange(Gdk.Window window, IntPtr region_id, Gtk.StateType state, bool state_value) {
			gtk_style_context_notify_state_change(Handle, window == null ? IntPtr.Zero : window.Handle, region_id, (int) state, state_value);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_pop_animatable_region(IntPtr raw);
		static d_gtk_style_context_pop_animatable_region gtk_style_context_pop_animatable_region = FuncLoader.LoadFunction<d_gtk_style_context_pop_animatable_region>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_pop_animatable_region"));

		[Obsolete]
		public void PopAnimatableRegion() {
			gtk_style_context_pop_animatable_region(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_push_animatable_region(IntPtr raw, IntPtr region_id);
		static d_gtk_style_context_push_animatable_region gtk_style_context_push_animatable_region = FuncLoader.LoadFunction<d_gtk_style_context_push_animatable_region>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_push_animatable_region"));

		[Obsolete]
		public void PushAnimatableRegion(IntPtr region_id) {
			gtk_style_context_push_animatable_region(Handle, region_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_remove_class(IntPtr raw, IntPtr class_name);
		static d_gtk_style_context_remove_class gtk_style_context_remove_class = FuncLoader.LoadFunction<d_gtk_style_context_remove_class>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_remove_class"));

		public void RemoveClass(string class_name) {
			IntPtr native_class_name = GLib.Marshaller.StringToPtrGStrdup (class_name);
			gtk_style_context_remove_class(Handle, native_class_name);
			GLib.Marshaller.Free (native_class_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_remove_provider(IntPtr raw, IntPtr provider);
		static d_gtk_style_context_remove_provider gtk_style_context_remove_provider = FuncLoader.LoadFunction<d_gtk_style_context_remove_provider>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_remove_provider"));

		public void RemoveProvider(Gtk.IStyleProvider provider) {
			gtk_style_context_remove_provider(Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_remove_provider_for_screen(IntPtr screen, IntPtr provider);
		static d_gtk_style_context_remove_provider_for_screen gtk_style_context_remove_provider_for_screen = FuncLoader.LoadFunction<d_gtk_style_context_remove_provider_for_screen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_remove_provider_for_screen"));

		public static void RemoveProviderForScreen(Gdk.Screen screen, Gtk.IStyleProvider provider) {
			gtk_style_context_remove_provider_for_screen(screen == null ? IntPtr.Zero : screen.Handle, provider == null ? IntPtr.Zero : ((provider is GLib.Object) ? (provider as GLib.Object).Handle : (provider as Gtk.StyleProviderAdapter).Handle));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_remove_region(IntPtr raw, IntPtr region_name);
		static d_gtk_style_context_remove_region gtk_style_context_remove_region = FuncLoader.LoadFunction<d_gtk_style_context_remove_region>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_remove_region"));

		[Obsolete]
		public void RemoveRegion(string region_name) {
			IntPtr native_region_name = GLib.Marshaller.StringToPtrGStrdup (region_name);
			gtk_style_context_remove_region(Handle, native_region_name);
			GLib.Marshaller.Free (native_region_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_reset_widgets(IntPtr screen);
		static d_gtk_style_context_reset_widgets gtk_style_context_reset_widgets = FuncLoader.LoadFunction<d_gtk_style_context_reset_widgets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_reset_widgets"));

		public static void ResetWidgets(Gdk.Screen screen) {
			gtk_style_context_reset_widgets(screen == null ? IntPtr.Zero : screen.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_restore(IntPtr raw);
		static d_gtk_style_context_restore gtk_style_context_restore = FuncLoader.LoadFunction<d_gtk_style_context_restore>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_restore"));

		public void Restore() {
			gtk_style_context_restore(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_save(IntPtr raw);
		static d_gtk_style_context_save gtk_style_context_save = FuncLoader.LoadFunction<d_gtk_style_context_save>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_save"));

		public void Save() {
			gtk_style_context_save(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_scroll_animations(IntPtr raw, IntPtr window, int dx, int dy);
		static d_gtk_style_context_scroll_animations gtk_style_context_scroll_animations = FuncLoader.LoadFunction<d_gtk_style_context_scroll_animations>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_scroll_animations"));

		[Obsolete]
		public void ScrollAnimations(Gdk.Window window, int dx, int dy) {
			gtk_style_context_scroll_animations(Handle, window == null ? IntPtr.Zero : window.Handle, dx, dy);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_style_context_set_background(IntPtr raw, IntPtr window);
		static d_gtk_style_context_set_background gtk_style_context_set_background = FuncLoader.LoadFunction<d_gtk_style_context_set_background>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_set_background"));

		[Obsolete]
		public Gdk.Window Background { 
			set {
				gtk_style_context_set_background(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_context_state_is_running(IntPtr raw, int state, out double progress);
		static d_gtk_style_context_state_is_running gtk_style_context_state_is_running = FuncLoader.LoadFunction<d_gtk_style_context_state_is_running>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_state_is_running"));

		[Obsolete]
		public bool StateIsRunning(Gtk.StateType state, out double progress) {
			bool raw_ret = gtk_style_context_state_is_running(Handle, (int) state, out progress);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_context_to_string(IntPtr raw, int flags);
		static d_gtk_style_context_to_string gtk_style_context_to_string = FuncLoader.LoadFunction<d_gtk_style_context_to_string>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_context_to_string"));

		public string ToString(Gtk.StyleContextPrintFlags flags) {
			IntPtr raw_ret = gtk_style_context_to_string(Handle, (int) flags);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
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
