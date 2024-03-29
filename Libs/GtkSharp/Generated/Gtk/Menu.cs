// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Menu : Gtk.MenuShell {

		public Menu (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_new();
		static d_gtk_menu_new gtk_menu_new = FuncLoader.LoadFunction<d_gtk_menu_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_new"));

		public Menu () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Menu)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_menu_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_new_from_model(IntPtr model);
		static d_gtk_menu_new_from_model gtk_menu_new_from_model = FuncLoader.LoadFunction<d_gtk_menu_new_from_model>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_new_from_model"));

		public Menu (GLib.MenuModel model) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Menu)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_menu_new_from_model(model == null ? IntPtr.Zero : model.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_active(IntPtr raw);
		static d_gtk_menu_get_active gtk_menu_get_active = FuncLoader.LoadFunction<d_gtk_menu_get_active>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_active"));

		[GLib.Property ("active")]
		public Gtk.Widget Active {
			get  {
				IntPtr raw_ret = gtk_menu_get_active(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("active", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_accel_group(IntPtr raw);
		static d_gtk_menu_get_accel_group gtk_menu_get_accel_group = FuncLoader.LoadFunction<d_gtk_menu_get_accel_group>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_accel_group"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_set_accel_group(IntPtr raw, IntPtr accel_group);
		static d_gtk_menu_set_accel_group gtk_menu_set_accel_group = FuncLoader.LoadFunction<d_gtk_menu_set_accel_group>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_set_accel_group"));

		[GLib.Property ("accel-group")]
		public Gtk.AccelGroup AccelGroup {
			get  {
				IntPtr raw_ret = gtk_menu_get_accel_group(Handle);
				Gtk.AccelGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.AccelGroup;
				return ret;
			}
			set  {
				gtk_menu_set_accel_group(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_accel_path(IntPtr raw);
		static d_gtk_menu_get_accel_path gtk_menu_get_accel_path = FuncLoader.LoadFunction<d_gtk_menu_get_accel_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_accel_path"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_set_accel_path(IntPtr raw, IntPtr accel_path);
		static d_gtk_menu_set_accel_path gtk_menu_set_accel_path = FuncLoader.LoadFunction<d_gtk_menu_set_accel_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_set_accel_path"));

		[GLib.Property ("accel-path")]
		public string AccelPath {
			get  {
				IntPtr raw_ret = gtk_menu_get_accel_path(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_set_accel_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_attach_widget(IntPtr raw);
		static d_gtk_menu_get_attach_widget gtk_menu_get_attach_widget = FuncLoader.LoadFunction<d_gtk_menu_get_attach_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_attach_widget"));

		[GLib.Property ("attach-widget")]
		public Gtk.Widget AttachWidget {
			get  {
				IntPtr raw_ret = gtk_menu_get_attach_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("attach-widget", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("tearoff-title")]
		public string TearoffTitle {
			get {
				GLib.Value val = GetProperty ("tearoff-title");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("tearoff-title", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_menu_get_tearoff_state(IntPtr raw);
		static d_gtk_menu_get_tearoff_state gtk_menu_get_tearoff_state = FuncLoader.LoadFunction<d_gtk_menu_get_tearoff_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_tearoff_state"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_set_tearoff_state(IntPtr raw, bool torn_off);
		static d_gtk_menu_set_tearoff_state gtk_menu_set_tearoff_state = FuncLoader.LoadFunction<d_gtk_menu_set_tearoff_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_set_tearoff_state"));

		[Obsolete]
		[GLib.Property ("tearoff-state")]
		public bool TearoffState {
			get  {
				bool raw_ret = gtk_menu_get_tearoff_state(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_set_tearoff_state(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_menu_get_monitor(IntPtr raw);
		static d_gtk_menu_get_monitor gtk_menu_get_monitor = FuncLoader.LoadFunction<d_gtk_menu_get_monitor>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_monitor"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_set_monitor(IntPtr raw, int monitor_num);
		static d_gtk_menu_set_monitor gtk_menu_set_monitor = FuncLoader.LoadFunction<d_gtk_menu_set_monitor>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_set_monitor"));

		[GLib.Property ("monitor")]
		public int Monitor {
			get  {
				int raw_ret = gtk_menu_get_monitor(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_set_monitor(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_menu_get_reserve_toggle_size(IntPtr raw);
		static d_gtk_menu_get_reserve_toggle_size gtk_menu_get_reserve_toggle_size = FuncLoader.LoadFunction<d_gtk_menu_get_reserve_toggle_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_reserve_toggle_size"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_set_reserve_toggle_size(IntPtr raw, bool reserve_toggle_size);
		static d_gtk_menu_set_reserve_toggle_size gtk_menu_set_reserve_toggle_size = FuncLoader.LoadFunction<d_gtk_menu_set_reserve_toggle_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_set_reserve_toggle_size"));

		[GLib.Property ("reserve-toggle-size")]
		public bool ReserveToggleSize {
			get  {
				bool raw_ret = gtk_menu_get_reserve_toggle_size(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_set_reserve_toggle_size(Handle, value);
			}
		}

		[GLib.Property ("anchor-hints")]
		public Gdk.AnchorHints AnchorHints {
			get {
				GLib.Value val = GetProperty ("anchor-hints");
				Gdk.AnchorHints ret = (Gdk.AnchorHints) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("anchor-hints", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("rect-anchor-dx")]
		public int RectAnchorDx {
			get {
				GLib.Value val = GetProperty ("rect-anchor-dx");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rect-anchor-dx", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("rect-anchor-dy")]
		public int RectAnchorDy {
			get {
				GLib.Value val = GetProperty ("rect-anchor-dy");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rect-anchor-dy", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("menu-type-hint")]
		public Gdk.WindowTypeHint MenuTypeHint {
			get {
				GLib.Value val = GetProperty ("menu-type-hint");
				Gdk.WindowTypeHint ret = (Gdk.WindowTypeHint) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("menu-type-hint", val);
				val.Dispose ();
			}
		}

		[Obsolete]
		public int HorizontalPadding {
			get {
				var val = (int)StyleGetProperty("horizontal-padding");
				return val;
			}
		}

		[Obsolete]
		public int VerticalPadding {
			get {
				var val = (int)StyleGetProperty("vertical-padding");
				return val;
			}
		}

		public int VerticalOffset {
			get {
				var val = (int)StyleGetProperty("vertical-offset");
				return val;
			}
		}

		public int HorizontalOffset {
			get {
				var val = (int)StyleGetProperty("horizontal-offset");
				return val;
			}
		}

		[Obsolete]
		public bool DoubleArrows {
			get {
				var val = (bool)StyleGetProperty("double-arrows");
				return val;
			}
		}

		[Obsolete]
		public Gtk.ArrowPlacement ArrowPlacement {
			get {
				var val = (Gtk.ArrowPlacement)StyleGetProperty("arrow-placement");
				return val;
			}
		}

		[Obsolete]
		public float ArrowScaling {
			get {
				var val = (float)StyleGetProperty("arrow-scaling");
				return val;
			}
		}

		public class MenuChild : Gtk.Container.ContainerChild {
			protected internal MenuChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("left-attach")]
			public int LeftAttach {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "left-attach");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "left-attach", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("right-attach")]
			public int RightAttach {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "right-attach");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "right-attach", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("top-attach")]
			public int TopAttach {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "top-attach");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "top-attach", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("bottom-attach")]
			public int BottomAttach {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "bottom-attach");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "bottom-attach", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new MenuChild (this, child);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PoppedUpSignalDelegate (IntPtr inst, IntPtr arg0, IntPtr arg1, bool arg2, bool arg3, IntPtr gch);

		static void PoppedUpSignalCallback (IntPtr inst, IntPtr arg0, IntPtr arg1, bool arg2, bool arg3, IntPtr gch)
		{
			Gtk.PoppedUpArgs args = new Gtk.PoppedUpArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[4];
				args.Args[0] = arg0;
				args.Args[1] = arg1;
				args.Args[2] = arg2;
				args.Args[3] = arg3;
				Gtk.PoppedUpHandler handler = (Gtk.PoppedUpHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.Signal("popped-up")]
		public event Gtk.PoppedUpHandler PoppedUp {
			add {
				this.AddSignalHandler ("popped-up", value, new PoppedUpSignalDelegate(PoppedUpSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("popped-up", value);
			}
		}

		[GLib.Signal("move-scroll")]
		public event Gtk.MoveScrollHandler MoveScroll {
			add {
				this.AddSignalHandler ("move-scroll", value, typeof (Gtk.MoveScrollArgs));
			}
			remove {
				this.RemoveSignalHandler ("move-scroll", value);
			}
		}

		static MoveScrollNativeDelegate MoveScroll_cb_delegate;
		static MoveScrollNativeDelegate MoveScrollVMCallback {
			get {
				if (MoveScroll_cb_delegate == null)
					MoveScroll_cb_delegate = new MoveScrollNativeDelegate (MoveScroll_cb);
				return MoveScroll_cb_delegate;
			}
		}

		static void OverrideMoveScroll (GLib.GType gtype)
		{
			OverrideMoveScroll (gtype, MoveScrollVMCallback);
		}

		static void OverrideMoveScroll (GLib.GType gtype, MoveScrollNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "move-scroll", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MoveScrollNativeDelegate (IntPtr inst, int p0);

		static void MoveScroll_cb (IntPtr inst, int p0)
		{
			try {
				Menu __obj = GLib.Object.GetObject (inst, false) as Menu;
				__obj.OnMoveScroll ((Gtk.ScrollType) p0);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Menu), ConnectionMethod="OverrideMoveScroll")]
		protected virtual void OnMoveScroll (Gtk.ScrollType p0)
		{
			InternalMoveScroll (p0);
		}

		private void InternalMoveScroll (Gtk.ScrollType p0)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PoppedUpNativeDelegate PoppedUp_cb_delegate;
		static PoppedUpNativeDelegate PoppedUpVMCallback {
			get {
				if (PoppedUp_cb_delegate == null)
					PoppedUp_cb_delegate = new PoppedUpNativeDelegate (PoppedUp_cb);
				return PoppedUp_cb_delegate;
			}
		}

		static void OverridePoppedUp (GLib.GType gtype)
		{
			OverridePoppedUp (gtype, PoppedUpVMCallback);
		}

		static void OverridePoppedUp (GLib.GType gtype, PoppedUpNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "popped-up", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PoppedUpNativeDelegate (IntPtr inst, IntPtr p0, IntPtr p1, bool p2, bool p3);

		static void PoppedUp_cb (IntPtr inst, IntPtr p0, IntPtr p1, bool p2, bool p3)
		{
			try {
				Menu __obj = GLib.Object.GetObject (inst, false) as Menu;
				__obj.OnPoppedUp (p0, p1, p2, p3);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Menu), ConnectionMethod="OverridePoppedUp")]
		protected virtual void OnPoppedUp (IntPtr p0, IntPtr p1, bool p2, bool p3)
		{
			InternalPoppedUp (p0, p1, p2, p3);
		}

		private void InternalPoppedUp (IntPtr p0, IntPtr p1, bool p2, bool p3)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (5);
			GLib.Value[] vals = new GLib.Value [5];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (p1);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (p2);
			inst_and_params.Append (vals [3]);
			vals [4] = new GLib.Value (p3);
			inst_and_params.Append (vals [4]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.MenuShell.class_abi.Fields
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
		delegate void d_gtk_menu_attach(IntPtr raw, IntPtr child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach);
		static d_gtk_menu_attach gtk_menu_attach = FuncLoader.LoadFunction<d_gtk_menu_attach>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_attach"));

		public void Attach(Gtk.Widget child, uint left_attach, uint right_attach, uint top_attach, uint bottom_attach) {
			gtk_menu_attach(Handle, child == null ? IntPtr.Zero : child.Handle, left_attach, right_attach, top_attach, bottom_attach);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_attach_to_widget(IntPtr raw, IntPtr attach_widget, GtkSharp.MenuDetachFuncNative detacher);
		static d_gtk_menu_attach_to_widget gtk_menu_attach_to_widget = FuncLoader.LoadFunction<d_gtk_menu_attach_to_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_attach_to_widget"));

		public void AttachToWidget(Gtk.Widget attach_widget, Gtk.MenuDetachFunc detacher) {
			GtkSharp.MenuDetachFuncWrapper detacher_wrapper = new GtkSharp.MenuDetachFuncWrapper (detacher);
			detacher_wrapper.PersistUntilCalled ();
			gtk_menu_attach_to_widget(Handle, attach_widget == null ? IntPtr.Zero : attach_widget.Handle, detacher_wrapper.NativeDelegate);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_detach(IntPtr raw);
		static d_gtk_menu_detach gtk_menu_detach = FuncLoader.LoadFunction<d_gtk_menu_detach>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_detach"));

		public void Detach() {
			gtk_menu_detach(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_for_attach_widget(IntPtr widget);
		static d_gtk_menu_get_for_attach_widget gtk_menu_get_for_attach_widget = FuncLoader.LoadFunction<d_gtk_menu_get_for_attach_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_for_attach_widget"));

		public static Gtk.Widget[] GetForAttachWidget(Gtk.Widget widget) {
			IntPtr raw_ret = gtk_menu_get_for_attach_widget(widget == null ? IntPtr.Zero : widget.Handle);
			Gtk.Widget[] ret = GLib.Marshaller.ListPtrToArray<Gtk.Widget, Gtk.Widget> (raw_ret, false, false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_title(IntPtr raw);
		static d_gtk_menu_get_title gtk_menu_get_title = FuncLoader.LoadFunction<d_gtk_menu_get_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_title"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_set_title(IntPtr raw, IntPtr title);
		static d_gtk_menu_set_title gtk_menu_set_title = FuncLoader.LoadFunction<d_gtk_menu_set_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_set_title"));

		[Obsolete]
		public string Title { 
			get {
				IntPtr raw_ret = gtk_menu_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_get_type();
		static d_gtk_menu_get_type gtk_menu_get_type = FuncLoader.LoadFunction<d_gtk_menu_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_place_on_monitor(IntPtr raw, IntPtr monitor);
		static d_gtk_menu_place_on_monitor gtk_menu_place_on_monitor = FuncLoader.LoadFunction<d_gtk_menu_place_on_monitor>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_place_on_monitor"));

		public void PlaceOnMonitor(Gdk.Monitor monitor) {
			gtk_menu_place_on_monitor(Handle, monitor == null ? IntPtr.Zero : monitor.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_popdown(IntPtr raw);
		static d_gtk_menu_popdown gtk_menu_popdown = FuncLoader.LoadFunction<d_gtk_menu_popdown>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_popdown"));

		public void Popdown() {
			gtk_menu_popdown(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_popup(IntPtr raw, IntPtr parent_menu_shell, IntPtr parent_menu_item, GtkSharp.MenuPositionFuncNative func, IntPtr data, uint button, uint activate_time);
		static d_gtk_menu_popup gtk_menu_popup = FuncLoader.LoadFunction<d_gtk_menu_popup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_popup"));

		[Obsolete]
		public void Popup(Gtk.Widget parent_menu_shell, Gtk.Widget parent_menu_item, Gtk.MenuPositionFunc func, uint button, uint activate_time) {
			GtkSharp.MenuPositionFuncWrapper func_wrapper = new GtkSharp.MenuPositionFuncWrapper (func);
			func_wrapper.PersistUntilCalled ();
			gtk_menu_popup(Handle, parent_menu_shell == null ? IntPtr.Zero : parent_menu_shell.Handle, parent_menu_item == null ? IntPtr.Zero : parent_menu_item.Handle, func_wrapper.NativeDelegate, IntPtr.Zero, button, activate_time);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_popup_at_pointer(IntPtr raw, IntPtr trigger_event);
		static d_gtk_menu_popup_at_pointer gtk_menu_popup_at_pointer = FuncLoader.LoadFunction<d_gtk_menu_popup_at_pointer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_popup_at_pointer"));

		public void PopupAtPointer(Gdk.Event trigger_event) {
			gtk_menu_popup_at_pointer(Handle, trigger_event == null ? IntPtr.Zero : trigger_event.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_popup_at_rect(IntPtr raw, IntPtr rect_window, IntPtr rect, int rect_anchor, int menu_anchor, IntPtr trigger_event);
		static d_gtk_menu_popup_at_rect gtk_menu_popup_at_rect = FuncLoader.LoadFunction<d_gtk_menu_popup_at_rect>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_popup_at_rect"));

		public void PopupAtRect(Gdk.Window rect_window, Gdk.Rectangle rect, Gdk.Gravity rect_anchor, Gdk.Gravity menu_anchor, Gdk.Event trigger_event) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			gtk_menu_popup_at_rect(Handle, rect_window == null ? IntPtr.Zero : rect_window.Handle, native_rect, (int) rect_anchor, (int) menu_anchor, trigger_event == null ? IntPtr.Zero : trigger_event.Handle);
			Marshal.FreeHGlobal (native_rect);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_popup_at_widget(IntPtr raw, IntPtr widget, int widget_anchor, int menu_anchor, IntPtr trigger_event);
		static d_gtk_menu_popup_at_widget gtk_menu_popup_at_widget = FuncLoader.LoadFunction<d_gtk_menu_popup_at_widget>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_popup_at_widget"));

		public void PopupAtWidget(Gtk.Widget widget, Gdk.Gravity widget_anchor, Gdk.Gravity menu_anchor, Gdk.Event trigger_event) {
			gtk_menu_popup_at_widget(Handle, widget == null ? IntPtr.Zero : widget.Handle, (int) widget_anchor, (int) menu_anchor, trigger_event == null ? IntPtr.Zero : trigger_event.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_popup_for_device(IntPtr raw, IntPtr device, IntPtr parent_menu_shell, IntPtr parent_menu_item, GtkSharp.MenuPositionFuncNative func, IntPtr data, GLib.DestroyNotify destroy, uint button, uint activate_time);
		static d_gtk_menu_popup_for_device gtk_menu_popup_for_device = FuncLoader.LoadFunction<d_gtk_menu_popup_for_device>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_popup_for_device"));

		[Obsolete]
		public void PopupForDevice(Gdk.Device device, Gtk.Widget parent_menu_shell, Gtk.Widget parent_menu_item, Gtk.MenuPositionFunc func, GLib.DestroyNotify destroy, uint button, uint activate_time) {
			GtkSharp.MenuPositionFuncWrapper func_wrapper = new GtkSharp.MenuPositionFuncWrapper (func);
			func_wrapper.PersistUntilCalled ();
			gtk_menu_popup_for_device(Handle, device == null ? IntPtr.Zero : device.Handle, parent_menu_shell == null ? IntPtr.Zero : parent_menu_shell.Handle, parent_menu_item == null ? IntPtr.Zero : parent_menu_item.Handle, func_wrapper.NativeDelegate, IntPtr.Zero, destroy, button, activate_time);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_reorder_child(IntPtr raw, IntPtr child, int position);
		static d_gtk_menu_reorder_child gtk_menu_reorder_child = FuncLoader.LoadFunction<d_gtk_menu_reorder_child>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_reorder_child"));

		public void ReorderChild(Gtk.Widget child, int position) {
			gtk_menu_reorder_child(Handle, child == null ? IntPtr.Zero : child.Handle, position);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_reposition(IntPtr raw);
		static d_gtk_menu_reposition gtk_menu_reposition = FuncLoader.LoadFunction<d_gtk_menu_reposition>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_reposition"));

		public void Reposition() {
			gtk_menu_reposition(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.MenuShell.abi_info.Fields
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
