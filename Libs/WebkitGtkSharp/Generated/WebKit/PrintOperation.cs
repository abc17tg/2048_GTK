// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class PrintOperation : GLib.Object {

		public PrintOperation (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_print_operation_new(IntPtr web_view);
		static d_webkit_print_operation_new webkit_print_operation_new = FuncLoader.LoadFunction<d_webkit_print_operation_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_new"));

		public PrintOperation (WebKit.WebView web_view) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PrintOperation)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (web_view != null) {
					names.Add ("web_view");
					vals.Add (new GLib.Value (web_view));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = webkit_print_operation_new(web_view == null ? IntPtr.Zero : web_view.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_print_operation_get_page_setup(IntPtr raw);
		static d_webkit_print_operation_get_page_setup webkit_print_operation_get_page_setup = FuncLoader.LoadFunction<d_webkit_print_operation_get_page_setup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_get_page_setup"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_print_operation_set_page_setup(IntPtr raw, IntPtr page_setup);
		static d_webkit_print_operation_set_page_setup webkit_print_operation_set_page_setup = FuncLoader.LoadFunction<d_webkit_print_operation_set_page_setup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_set_page_setup"));

		[GLib.Property ("page-setup")]
		public Gtk.PageSetup PageSetup {
			get  {
				IntPtr raw_ret = webkit_print_operation_get_page_setup(Handle);
				Gtk.PageSetup ret = GLib.Object.GetObject(raw_ret) as Gtk.PageSetup;
				return ret;
			}
			set  {
				webkit_print_operation_set_page_setup(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_print_operation_get_print_settings(IntPtr raw);
		static d_webkit_print_operation_get_print_settings webkit_print_operation_get_print_settings = FuncLoader.LoadFunction<d_webkit_print_operation_get_print_settings>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_get_print_settings"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_print_operation_set_print_settings(IntPtr raw, IntPtr print_settings);
		static d_webkit_print_operation_set_print_settings webkit_print_operation_set_print_settings = FuncLoader.LoadFunction<d_webkit_print_operation_set_print_settings>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_set_print_settings"));

		[GLib.Property ("print-settings")]
		public Gtk.PrintSettings PrintSettings {
			get  {
				IntPtr raw_ret = webkit_print_operation_get_print_settings(Handle);
				Gtk.PrintSettings ret = GLib.Object.GetObject(raw_ret) as Gtk.PrintSettings;
				return ret;
			}
			set  {
				webkit_print_operation_set_print_settings(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("web-view")]
		public WebKit.WebView WebView {
			get {
				GLib.Value val = GetProperty ("web-view");
				WebKit.WebView ret = (WebKit.WebView) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("finished")]
		public event System.EventHandler Finished {
			add {
				this.AddSignalHandler ("finished", value);
			}
			remove {
				this.RemoveSignalHandler ("finished", value);
			}
		}

		[GLib.Signal("create-custom-widget")]
		public event WebKit.CreateCustomWidgetHandler CreateCustomWidget {
			add {
				this.AddSignalHandler ("create-custom-widget", value, typeof (WebKit.CreateCustomWidgetArgs));
			}
			remove {
				this.RemoveSignalHandler ("create-custom-widget", value);
			}
		}

		[GLib.Signal("failed")]
		public event WebKit.FailedHandler Failed {
			add {
				this.AddSignalHandler ("failed", value, typeof (WebKit.FailedArgs));
			}
			remove {
				this.RemoveSignalHandler ("failed", value);
			}
		}

		static CreateCustomWidgetNativeDelegate CreateCustomWidget_cb_delegate;
		static CreateCustomWidgetNativeDelegate CreateCustomWidgetVMCallback {
			get {
				if (CreateCustomWidget_cb_delegate == null)
					CreateCustomWidget_cb_delegate = new CreateCustomWidgetNativeDelegate (CreateCustomWidget_cb);
				return CreateCustomWidget_cb_delegate;
			}
		}

		static void OverrideCreateCustomWidget (GLib.GType gtype)
		{
			OverrideCreateCustomWidget (gtype, CreateCustomWidgetVMCallback);
		}

		static void OverrideCreateCustomWidget (GLib.GType gtype, CreateCustomWidgetNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "create-custom-widget", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateCustomWidgetNativeDelegate (IntPtr inst);

		static IntPtr CreateCustomWidget_cb (IntPtr inst)
		{
			try {
				PrintOperation __obj = GLib.Object.GetObject (inst, false) as PrintOperation;
				WebKit.PrintCustomWidget __result;
				__result = __obj.OnCreateCustomWidget ();
				return __result == null ? IntPtr.Zero : __result.OwnedHandle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.PrintOperation), ConnectionMethod="OverrideCreateCustomWidget")]
		protected virtual WebKit.PrintCustomWidget OnCreateCustomWidget ()
		{
			return InternalCreateCustomWidget ();
		}

		private WebKit.PrintCustomWidget InternalCreateCustomWidget ()
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Object);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			WebKit.PrintCustomWidget result = (WebKit.PrintCustomWidget) ret;
			ret.Dispose ();
			return result;
		}

		static FailedNativeDelegate Failed_cb_delegate;
		static FailedNativeDelegate FailedVMCallback {
			get {
				if (Failed_cb_delegate == null)
					Failed_cb_delegate = new FailedNativeDelegate (Failed_cb);
				return Failed_cb_delegate;
			}
		}

		static void OverrideFailed (GLib.GType gtype)
		{
			OverrideFailed (gtype, FailedVMCallback);
		}

		static void OverrideFailed (GLib.GType gtype, FailedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "failed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FailedNativeDelegate (IntPtr inst, IntPtr error);

		static void Failed_cb (IntPtr inst, IntPtr error)
		{
			try {
				PrintOperation __obj = GLib.Object.GetObject (inst, false) as PrintOperation;
				__obj.OnFailed (error);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.PrintOperation), ConnectionMethod="OverrideFailed")]
		protected virtual void OnFailed (IntPtr error)
		{
			InternalFailed (error);
		}

		private void InternalFailed (IntPtr error)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (error);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static FinishedNativeDelegate Finished_cb_delegate;
		static FinishedNativeDelegate FinishedVMCallback {
			get {
				if (Finished_cb_delegate == null)
					Finished_cb_delegate = new FinishedNativeDelegate (Finished_cb);
				return Finished_cb_delegate;
			}
		}

		static void OverrideFinished (GLib.GType gtype)
		{
			OverrideFinished (gtype, FinishedVMCallback);
		}

		static void OverrideFinished (GLib.GType gtype, FinishedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "finished", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FinishedNativeDelegate (IntPtr inst);

		static void Finished_cb (IntPtr inst)
		{
			try {
				PrintOperation __obj = GLib.Object.GetObject (inst, false) as PrintOperation;
				__obj.OnFinished ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.PrintOperation), ConnectionMethod="OverrideFinished")]
		protected virtual void OnFinished ()
		{
			InternalFinished ();
		}

		private void InternalFinished ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
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
		delegate IntPtr d_webkit_print_operation_get_type();
		static d_webkit_print_operation_get_type webkit_print_operation_get_type = FuncLoader.LoadFunction<d_webkit_print_operation_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_print_operation_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_print_operation_print(IntPtr raw);
		static d_webkit_print_operation_print webkit_print_operation_print = FuncLoader.LoadFunction<d_webkit_print_operation_print>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_print"));

		public void Print() {
			webkit_print_operation_print(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_webkit_print_operation_run_dialog(IntPtr raw, IntPtr parent);
		static d_webkit_print_operation_run_dialog webkit_print_operation_run_dialog = FuncLoader.LoadFunction<d_webkit_print_operation_run_dialog>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_print_operation_run_dialog"));

		public WebKit.PrintOperationResponse RunDialog(Gtk.Window parent) {
			int raw_ret = webkit_print_operation_run_dialog(Handle, parent == null ? IntPtr.Zero : parent.Handle);
			WebKit.PrintOperationResponse ret = (WebKit.PrintOperationResponse) raw_ret;
			return ret;
		}

		public WebKit.PrintOperationResponse RunDialog() {
			return RunDialog (null);
		}


		static PrintOperation ()
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