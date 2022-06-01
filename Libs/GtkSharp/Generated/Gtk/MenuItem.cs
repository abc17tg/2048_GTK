// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class MenuItem : Gtk.Bin, Gtk.IActivatable, Gtk.IActionable {

		public MenuItem (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_item_new();
		static d_gtk_menu_item_new gtk_menu_item_new = FuncLoader.LoadFunction<d_gtk_menu_item_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_new"));

		public MenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_menu_item_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_menu_item_get_right_justified(IntPtr raw);
		static d_gtk_menu_item_get_right_justified gtk_menu_item_get_right_justified = FuncLoader.LoadFunction<d_gtk_menu_item_get_right_justified>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_right_justified"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_set_right_justified(IntPtr raw, bool right_justified);
		static d_gtk_menu_item_set_right_justified gtk_menu_item_set_right_justified = FuncLoader.LoadFunction<d_gtk_menu_item_set_right_justified>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_set_right_justified"));

		[Obsolete]
		[GLib.Property ("right-justified")]
		public bool RightJustified {
			get  {
				bool raw_ret = gtk_menu_item_get_right_justified(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_item_set_right_justified(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_item_get_submenu(IntPtr raw);
		static d_gtk_menu_item_get_submenu gtk_menu_item_get_submenu = FuncLoader.LoadFunction<d_gtk_menu_item_get_submenu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_submenu"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_set_submenu(IntPtr raw, IntPtr submenu);
		static d_gtk_menu_item_set_submenu gtk_menu_item_set_submenu = FuncLoader.LoadFunction<d_gtk_menu_item_set_submenu>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_set_submenu"));

		[GLib.Property ("submenu")]
		public Gtk.Widget Submenu {
			get  {
				IntPtr raw_ret = gtk_menu_item_get_submenu(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_menu_item_set_submenu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_item_get_accel_path(IntPtr raw);
		static d_gtk_menu_item_get_accel_path gtk_menu_item_get_accel_path = FuncLoader.LoadFunction<d_gtk_menu_item_get_accel_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_accel_path"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_set_accel_path(IntPtr raw, IntPtr accel_path);
		static d_gtk_menu_item_set_accel_path gtk_menu_item_set_accel_path = FuncLoader.LoadFunction<d_gtk_menu_item_set_accel_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_set_accel_path"));

		[GLib.Property ("accel-path")]
		public string AccelPath {
			get  {
				IntPtr raw_ret = gtk_menu_item_get_accel_path(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_item_set_accel_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_item_get_label(IntPtr raw);
		static d_gtk_menu_item_get_label gtk_menu_item_get_label = FuncLoader.LoadFunction<d_gtk_menu_item_get_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_label"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_set_label(IntPtr raw, IntPtr label);
		static d_gtk_menu_item_set_label gtk_menu_item_set_label = FuncLoader.LoadFunction<d_gtk_menu_item_set_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_set_label"));

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_menu_item_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_item_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_menu_item_get_use_underline(IntPtr raw);
		static d_gtk_menu_item_get_use_underline gtk_menu_item_get_use_underline = FuncLoader.LoadFunction<d_gtk_menu_item_get_use_underline>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_use_underline"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_set_use_underline(IntPtr raw, bool setting);
		static d_gtk_menu_item_set_use_underline gtk_menu_item_set_use_underline = FuncLoader.LoadFunction<d_gtk_menu_item_set_use_underline>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_set_use_underline"));

		[GLib.Property ("use-underline")]
		public bool UseUnderline {
			get  {
				bool raw_ret = gtk_menu_item_get_use_underline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_item_set_use_underline(Handle, value);
			}
		}

		[Obsolete]
		public Gtk.ShadowType SelectedShadowType {
			get {
				var val = (Gtk.ShadowType)StyleGetProperty("selected-shadow-type");
				return val;
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
		public int ToggleSpacing {
			get {
				var val = (int)StyleGetProperty("toggle-spacing");
				return val;
			}
		}

		[Obsolete]
		public int ArrowSpacing {
			get {
				var val = (int)StyleGetProperty("arrow-spacing");
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

		[Obsolete]
		public int WidthChars {
			get {
				var val = (int)StyleGetProperty("width-chars");
				return val;
			}
		}

		[GLib.Signal("toggle-size-allocate")]
		public event Gtk.ToggleSizeAllocatedHandler ToggleSizeAllocated {
			add {
				this.AddSignalHandler ("toggle-size-allocate", value, typeof (Gtk.ToggleSizeAllocatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("toggle-size-allocate", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleSizeRequestedSignalDelegate (IntPtr inst, out int arg0, IntPtr gch);

		static void ToggleSizeRequestedSignalCallback (IntPtr inst, out int arg0, IntPtr gch)
		{
			Gtk.ToggleSizeRequestedArgs args = new Gtk.ToggleSizeRequestedArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				Gtk.ToggleSizeRequestedHandler handler = (Gtk.ToggleSizeRequestedHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				arg0 = ((int)args.Args[0]);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Gtk.ToggleSizeRequestedHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("toggle-size-request")]
		public event Gtk.ToggleSizeRequestedHandler ToggleSizeRequested {
			add {
				this.AddSignalHandler ("toggle-size-request", value, new ToggleSizeRequestedSignalDelegate(ToggleSizeRequestedSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("toggle-size-request", value);
			}
		}

		[GLib.Signal("activate")]
		public event System.EventHandler Activated {
			add {
				this.AddSignalHandler ("activate", value);
			}
			remove {
				this.RemoveSignalHandler ("activate", value);
			}
		}

		[GLib.Signal("activate-item")]
		public event System.EventHandler ActivateItem {
			add {
				this.AddSignalHandler ("activate-item", value);
			}
			remove {
				this.RemoveSignalHandler ("activate-item", value);
			}
		}

		[GLib.Signal("select")]
		public event System.EventHandler Selected {
			add {
				this.AddSignalHandler ("select", value);
			}
			remove {
				this.RemoveSignalHandler ("select", value);
			}
		}

		[GLib.Signal("deselect")]
		public event System.EventHandler Deselected {
			add {
				this.AddSignalHandler ("deselect", value);
			}
			remove {
				this.RemoveSignalHandler ("deselect", value);
			}
		}

		static ActivatedNativeDelegate Activated_cb_delegate;
		static ActivatedNativeDelegate ActivatedVMCallback {
			get {
				if (Activated_cb_delegate == null)
					Activated_cb_delegate = new ActivatedNativeDelegate (Activated_cb);
				return Activated_cb_delegate;
			}
		}

		static void OverrideActivated (GLib.GType gtype)
		{
			OverrideActivated (gtype, ActivatedVMCallback);
		}

		static void OverrideActivated (GLib.GType gtype, ActivatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivatedNativeDelegate (IntPtr inst);

		static void Activated_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideActivated")]
		protected virtual void OnActivated ()
		{
			InternalActivated ();
		}

		private void InternalActivated ()
		{
			ActivatedNativeDelegate unmanaged = class_abi.BaseOverride<ActivatedNativeDelegate>(this.LookupGType(), "activate");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ActivateItemNativeDelegate ActivateItem_cb_delegate;
		static ActivateItemNativeDelegate ActivateItemVMCallback {
			get {
				if (ActivateItem_cb_delegate == null)
					ActivateItem_cb_delegate = new ActivateItemNativeDelegate (ActivateItem_cb);
				return ActivateItem_cb_delegate;
			}
		}

		static void OverrideActivateItem (GLib.GType gtype)
		{
			OverrideActivateItem (gtype, ActivateItemVMCallback);
		}

		static void OverrideActivateItem (GLib.GType gtype, ActivateItemNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate_item"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateItemNativeDelegate (IntPtr inst);

		static void ActivateItem_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnActivateItem ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideActivateItem")]
		protected virtual void OnActivateItem ()
		{
			InternalActivateItem ();
		}

		private void InternalActivateItem ()
		{
			ActivateItemNativeDelegate unmanaged = class_abi.BaseOverride<ActivateItemNativeDelegate>(this.LookupGType(), "activate_item");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ToggleSizeRequestedNativeDelegate ToggleSizeRequested_cb_delegate;
		static ToggleSizeRequestedNativeDelegate ToggleSizeRequestedVMCallback {
			get {
				if (ToggleSizeRequested_cb_delegate == null)
					ToggleSizeRequested_cb_delegate = new ToggleSizeRequestedNativeDelegate (ToggleSizeRequested_cb);
				return ToggleSizeRequested_cb_delegate;
			}
		}

		static void OverrideToggleSizeRequested (GLib.GType gtype)
		{
			OverrideToggleSizeRequested (gtype, ToggleSizeRequestedVMCallback);
		}

		static void OverrideToggleSizeRequested (GLib.GType gtype, ToggleSizeRequestedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggle_size_request"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleSizeRequestedNativeDelegate (IntPtr inst, out int requisition);

		static void ToggleSizeRequested_cb (IntPtr inst, out int requisition)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnToggleSizeRequested (out requisition);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideToggleSizeRequested")]
		protected virtual void OnToggleSizeRequested (out int requisition)
		{
			InternalToggleSizeRequested (out requisition);
		}

		private void InternalToggleSizeRequested (out int requisition)
		{
			ToggleSizeRequestedNativeDelegate unmanaged = class_abi.BaseOverride<ToggleSizeRequestedNativeDelegate>(this.LookupGType(), "toggle_size_request");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			unmanaged (this.Handle, out requisition);
		}

		static ToggleSizeAllocatedNativeDelegate ToggleSizeAllocated_cb_delegate;
		static ToggleSizeAllocatedNativeDelegate ToggleSizeAllocatedVMCallback {
			get {
				if (ToggleSizeAllocated_cb_delegate == null)
					ToggleSizeAllocated_cb_delegate = new ToggleSizeAllocatedNativeDelegate (ToggleSizeAllocated_cb);
				return ToggleSizeAllocated_cb_delegate;
			}
		}

		static void OverrideToggleSizeAllocated (GLib.GType gtype)
		{
			OverrideToggleSizeAllocated (gtype, ToggleSizeAllocatedVMCallback);
		}

		static void OverrideToggleSizeAllocated (GLib.GType gtype, ToggleSizeAllocatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggle_size_allocate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleSizeAllocatedNativeDelegate (IntPtr inst, int allocation);

		static void ToggleSizeAllocated_cb (IntPtr inst, int allocation)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnToggleSizeAllocated (allocation);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideToggleSizeAllocated")]
		protected virtual void OnToggleSizeAllocated (int allocation)
		{
			InternalToggleSizeAllocated (allocation);
		}

		private void InternalToggleSizeAllocated (int allocation)
		{
			ToggleSizeAllocatedNativeDelegate unmanaged = class_abi.BaseOverride<ToggleSizeAllocatedNativeDelegate>(this.LookupGType(), "toggle_size_allocate");
			if (unmanaged == null) return;

			unmanaged (this.Handle, allocation);
		}

		static SetLabelNativeDelegate SetLabel_cb_delegate;
		static SetLabelNativeDelegate SetLabelVMCallback {
			get {
				if (SetLabel_cb_delegate == null)
					SetLabel_cb_delegate = new SetLabelNativeDelegate (SetLabel_cb);
				return SetLabel_cb_delegate;
			}
		}

		static void OverrideSetLabel (GLib.GType gtype)
		{
			OverrideSetLabel (gtype, SetLabelVMCallback);
		}

		static void OverrideSetLabel (GLib.GType gtype, SetLabelNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("set_label"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetLabelNativeDelegate (IntPtr inst, IntPtr label);

		static void SetLabel_cb (IntPtr inst, IntPtr label)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnSetLabel (GLib.Marshaller.Utf8PtrToString (label));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideSetLabel")]
		protected virtual void OnSetLabel (string label)
		{
			InternalSetLabel (label);
		}

		private void InternalSetLabel (string label)
		{
			SetLabelNativeDelegate unmanaged = class_abi.BaseOverride<SetLabelNativeDelegate>(this.LookupGType(), "set_label");
			if (unmanaged == null) return;

			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			unmanaged (this.Handle, native_label);
			GLib.Marshaller.Free (native_label);
		}

		static GetLabelNativeDelegate GetLabel_cb_delegate;
		static GetLabelNativeDelegate GetLabelVMCallback {
			get {
				if (GetLabel_cb_delegate == null)
					GetLabel_cb_delegate = new GetLabelNativeDelegate (GetLabel_cb);
				return GetLabel_cb_delegate;
			}
		}

		static void OverrideGetLabel (GLib.GType gtype)
		{
			OverrideGetLabel (gtype, GetLabelVMCallback);
		}

		static void OverrideGetLabel (GLib.GType gtype, GetLabelNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_label"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetLabelNativeDelegate (IntPtr inst);

		static IntPtr GetLabel_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				string __result;
				__result = __obj.OnGetLabel ();
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideGetLabel")]
		protected virtual string OnGetLabel ()
		{
			return InternalGetLabel ();
		}

		private string InternalGetLabel ()
		{
			GetLabelNativeDelegate unmanaged = class_abi.BaseOverride<GetLabelNativeDelegate>(this.LookupGType(), "get_label");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static SelectedNativeDelegate Selected_cb_delegate;
		static SelectedNativeDelegate SelectedVMCallback {
			get {
				if (Selected_cb_delegate == null)
					Selected_cb_delegate = new SelectedNativeDelegate (Selected_cb);
				return Selected_cb_delegate;
			}
		}

		static void OverrideSelected (GLib.GType gtype)
		{
			OverrideSelected (gtype, SelectedVMCallback);
		}

		static void OverrideSelected (GLib.GType gtype, SelectedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("select"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectedNativeDelegate (IntPtr inst);

		static void Selected_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnSelected ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideSelected")]
		protected virtual void OnSelected ()
		{
			InternalSelected ();
		}

		private void InternalSelected ()
		{
			SelectedNativeDelegate unmanaged = class_abi.BaseOverride<SelectedNativeDelegate>(this.LookupGType(), "select");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DeselectedNativeDelegate Deselected_cb_delegate;
		static DeselectedNativeDelegate DeselectedVMCallback {
			get {
				if (Deselected_cb_delegate == null)
					Deselected_cb_delegate = new DeselectedNativeDelegate (Deselected_cb);
				return Deselected_cb_delegate;
			}
		}

		static void OverrideDeselected (GLib.GType gtype)
		{
			OverrideDeselected (gtype, DeselectedVMCallback);
		}

		static void OverrideDeselected (GLib.GType gtype, DeselectedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("deselect"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeselectedNativeDelegate (IntPtr inst);

		static void Deselected_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnDeselected ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideDeselected")]
		protected virtual void OnDeselected ()
		{
			InternalDeselected ();
		}

		private void InternalDeselected ()
		{
			DeselectedNativeDelegate unmanaged = class_abi.BaseOverride<DeselectedNativeDelegate>(this.LookupGType(), "deselect");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("hide_on_activate"
							, Gtk.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf<bool>() // hide_on_activate
							, null
							, "activate"
							, 1
							, 1
							),
						new GLib.AbiField("activate"
							, -1
							, (uint) sizeof( IntPtr ) // activate
							, "hide_on_activate"
							, "activate_item"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("activate_item"
							, -1
							, (uint) sizeof( IntPtr ) // activate_item
							, "activate"
							, "toggle_size_request"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("toggle_size_request"
							, -1
							, (uint) sizeof( IntPtr ) // toggle_size_request
							, "activate_item"
							, "toggle_size_allocate"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("toggle_size_allocate"
							, -1
							, (uint) sizeof( IntPtr ) // toggle_size_allocate
							, "toggle_size_request"
							, "set_label"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("set_label"
							, -1
							, (uint) sizeof( IntPtr ) // set_label
							, "toggle_size_allocate"
							, "get_label"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_label"
							, -1
							, (uint) sizeof( IntPtr ) // get_label
							, "set_label"
							, "select"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("select"
							, -1
							, (uint) sizeof( IntPtr ) // select
							, "get_label"
							, "deselect"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("deselect"
							, -1
							, (uint) sizeof( IntPtr ) // deselect
							, "select"
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "deselect"
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
		delegate void d_gtk_menu_item_activate(IntPtr raw);
		static d_gtk_menu_item_activate gtk_menu_item_activate = FuncLoader.LoadFunction<d_gtk_menu_item_activate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_activate"));

		public new void Activate() {
			gtk_menu_item_activate(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_deselect(IntPtr raw);
		static d_gtk_menu_item_deselect gtk_menu_item_deselect = FuncLoader.LoadFunction<d_gtk_menu_item_deselect>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_deselect"));

		public void Deselect() {
			gtk_menu_item_deselect(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_menu_item_get_reserve_indicator(IntPtr raw);
		static d_gtk_menu_item_get_reserve_indicator gtk_menu_item_get_reserve_indicator = FuncLoader.LoadFunction<d_gtk_menu_item_get_reserve_indicator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_reserve_indicator"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_set_reserve_indicator(IntPtr raw, bool reserve);
		static d_gtk_menu_item_set_reserve_indicator gtk_menu_item_set_reserve_indicator = FuncLoader.LoadFunction<d_gtk_menu_item_set_reserve_indicator>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_set_reserve_indicator"));

		public bool ReserveIndicator { 
			get {
				bool raw_ret = gtk_menu_item_get_reserve_indicator(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_menu_item_set_reserve_indicator(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_menu_item_get_type();
		static d_gtk_menu_item_get_type gtk_menu_item_get_type = FuncLoader.LoadFunction<d_gtk_menu_item_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_select(IntPtr raw);
		static d_gtk_menu_item_select gtk_menu_item_select = FuncLoader.LoadFunction<d_gtk_menu_item_select>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_select"));

		public void Select() {
			gtk_menu_item_select(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_toggle_size_allocate(IntPtr raw, int allocation);
		static d_gtk_menu_item_toggle_size_allocate gtk_menu_item_toggle_size_allocate = FuncLoader.LoadFunction<d_gtk_menu_item_toggle_size_allocate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_toggle_size_allocate"));

		public void ToggleSizeAllocate(int allocation) {
			gtk_menu_item_toggle_size_allocate(Handle, allocation);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_menu_item_toggle_size_request(IntPtr raw, out int requisition);
		static d_gtk_menu_item_toggle_size_request gtk_menu_item_toggle_size_request = FuncLoader.LoadFunction<d_gtk_menu_item_toggle_size_request>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_menu_item_toggle_size_request"));

		public int ToggleSizeRequest() {
			int requisition;
			gtk_menu_item_toggle_size_request(Handle, out requisition);
			return requisition;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_do_set_related_action(IntPtr raw, IntPtr action);
		static d_gtk_activatable_do_set_related_action gtk_activatable_do_set_related_action = FuncLoader.LoadFunction<d_gtk_activatable_do_set_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_do_set_related_action"));

		[Obsolete]
		public void DoSetRelatedAction(Gtk.Action action) {
			gtk_activatable_do_set_related_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_sync_action_properties(IntPtr raw, IntPtr action);
		static d_gtk_activatable_sync_action_properties gtk_activatable_sync_action_properties = FuncLoader.LoadFunction<d_gtk_activatable_sync_action_properties>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_sync_action_properties"));

		[Obsolete]
		public void SyncActionProperties(Gtk.Action action) {
			gtk_activatable_sync_action_properties(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_activatable_get_related_action(IntPtr raw);
		static d_gtk_activatable_get_related_action gtk_activatable_get_related_action = FuncLoader.LoadFunction<d_gtk_activatable_get_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_related_action"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_set_related_action(IntPtr raw, IntPtr action);
		static d_gtk_activatable_set_related_action gtk_activatable_set_related_action = FuncLoader.LoadFunction<d_gtk_activatable_set_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_set_related_action"));

		[Obsolete]
		[GLib.Property ("related-action")]
		public Gtk.Action RelatedAction {
			get  {
				IntPtr raw_ret = gtk_activatable_get_related_action(Handle);
				Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
				return ret;
			}
			set  {
				gtk_activatable_set_related_action(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_activatable_get_use_action_appearance(IntPtr raw);
		static d_gtk_activatable_get_use_action_appearance gtk_activatable_get_use_action_appearance = FuncLoader.LoadFunction<d_gtk_activatable_get_use_action_appearance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_use_action_appearance"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_set_use_action_appearance(IntPtr raw, bool use_appearance);
		static d_gtk_activatable_set_use_action_appearance gtk_activatable_set_use_action_appearance = FuncLoader.LoadFunction<d_gtk_activatable_set_use_action_appearance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_set_use_action_appearance"));

		[Obsolete]
		[GLib.Property ("use-action-appearance")]
		public bool UseActionAppearance {
			get  {
				bool raw_ret = gtk_activatable_get_use_action_appearance(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_activatable_set_use_action_appearance(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_actionable_get_action_name(IntPtr raw);
		static d_gtk_actionable_get_action_name gtk_actionable_get_action_name = FuncLoader.LoadFunction<d_gtk_actionable_get_action_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_actionable_get_action_name"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_actionable_set_action_name(IntPtr raw, IntPtr action_name);
		static d_gtk_actionable_set_action_name gtk_actionable_set_action_name = FuncLoader.LoadFunction<d_gtk_actionable_set_action_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_actionable_set_action_name"));

		public string ActionName { 
			get {
				IntPtr raw_ret = gtk_actionable_get_action_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_actionable_set_action_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_actionable_get_action_target_value(IntPtr raw);
		static d_gtk_actionable_get_action_target_value gtk_actionable_get_action_target_value = FuncLoader.LoadFunction<d_gtk_actionable_get_action_target_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_actionable_get_action_target_value"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_actionable_set_action_target_value(IntPtr raw, IntPtr target_value);
		static d_gtk_actionable_set_action_target_value gtk_actionable_set_action_target_value = FuncLoader.LoadFunction<d_gtk_actionable_set_action_target_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_actionable_set_action_target_value"));

		public GLib.Variant ActionTargetValue { 
			get {
				IntPtr raw_ret = gtk_actionable_get_action_target_value(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
			set {
				gtk_actionable_set_action_target_value(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_actionable_set_detailed_action_name(IntPtr raw, IntPtr detailed_action_name);
		static d_gtk_actionable_set_detailed_action_name gtk_actionable_set_detailed_action_name = FuncLoader.LoadFunction<d_gtk_actionable_set_detailed_action_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_actionable_set_detailed_action_name"));

		public string DetailedActionName { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_actionable_set_detailed_action_name(Handle, native_value);
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
