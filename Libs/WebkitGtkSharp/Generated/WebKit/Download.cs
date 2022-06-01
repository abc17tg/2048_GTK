// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Download : GLib.Object {

		public Download (IntPtr raw) : base(raw) {}

		protected Download() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_download_get_allow_overwrite(IntPtr raw);
		static d_webkit_download_get_allow_overwrite webkit_download_get_allow_overwrite = FuncLoader.LoadFunction<d_webkit_download_get_allow_overwrite>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_allow_overwrite"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_download_set_allow_overwrite(IntPtr raw, bool allowed);
		static d_webkit_download_set_allow_overwrite webkit_download_set_allow_overwrite = FuncLoader.LoadFunction<d_webkit_download_set_allow_overwrite>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_set_allow_overwrite"));

		[GLib.Property ("allow-overwrite")]
		public bool AllowOverwrite {
			get  {
				bool raw_ret = webkit_download_get_allow_overwrite(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				webkit_download_set_allow_overwrite(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_download_get_destination(IntPtr raw);
		static d_webkit_download_get_destination webkit_download_get_destination = FuncLoader.LoadFunction<d_webkit_download_get_destination>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_destination"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_download_set_destination(IntPtr raw, IntPtr uri);
		static d_webkit_download_set_destination webkit_download_set_destination = FuncLoader.LoadFunction<d_webkit_download_set_destination>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_set_destination"));

		[GLib.Property ("destination")]
		public string Destination {
			get  {
				IntPtr raw_ret = webkit_download_get_destination(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				webkit_download_set_destination(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_webkit_download_get_estimated_progress(IntPtr raw);
		static d_webkit_download_get_estimated_progress webkit_download_get_estimated_progress = FuncLoader.LoadFunction<d_webkit_download_get_estimated_progress>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_estimated_progress"));

		[GLib.Property ("estimated-progress")]
		public double EstimatedProgress {
			get  {
				double raw_ret = webkit_download_get_estimated_progress(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_download_get_response(IntPtr raw);
		static d_webkit_download_get_response webkit_download_get_response = FuncLoader.LoadFunction<d_webkit_download_get_response>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_response"));

		[GLib.Property ("response")]
		public WebKit.URIResponse Response {
			get  {
				IntPtr raw_ret = webkit_download_get_response(Handle);
				WebKit.URIResponse ret = GLib.Object.GetObject(raw_ret) as WebKit.URIResponse;
				return ret;
			}
		}

		[GLib.Signal("received-data")]
		public event WebKit.ReceivedDataHandler ReceivedData {
			add {
				this.AddSignalHandler ("received-data", value, typeof (WebKit.ReceivedDataArgs));
			}
			remove {
				this.RemoveSignalHandler ("received-data", value);
			}
		}

		[GLib.Signal("created-destination")]
		public event WebKit.CreatedDestinationHandler CreatedDestination {
			add {
				this.AddSignalHandler ("created-destination", value, typeof (WebKit.CreatedDestinationArgs));
			}
			remove {
				this.RemoveSignalHandler ("created-destination", value);
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

		[GLib.Signal("failed")]
		public event WebKit.FailedHandler Failed {
			add {
				this.AddSignalHandler ("failed", value, typeof (WebKit.FailedArgs));
			}
			remove {
				this.RemoveSignalHandler ("failed", value);
			}
		}

		[GLib.Signal("decide-destination")]
		public event WebKit.DecideDestinationHandler DecideDestination {
			add {
				this.AddSignalHandler ("decide-destination", value, typeof (WebKit.DecideDestinationArgs));
			}
			remove {
				this.RemoveSignalHandler ("decide-destination", value);
			}
		}

		static CreatedDestinationNativeDelegate CreatedDestination_cb_delegate;
		static CreatedDestinationNativeDelegate CreatedDestinationVMCallback {
			get {
				if (CreatedDestination_cb_delegate == null)
					CreatedDestination_cb_delegate = new CreatedDestinationNativeDelegate (CreatedDestination_cb);
				return CreatedDestination_cb_delegate;
			}
		}

		static void OverrideCreatedDestination (GLib.GType gtype)
		{
			OverrideCreatedDestination (gtype, CreatedDestinationVMCallback);
		}

		static void OverrideCreatedDestination (GLib.GType gtype, CreatedDestinationNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "created-destination", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CreatedDestinationNativeDelegate (IntPtr inst, IntPtr destination);

		static void CreatedDestination_cb (IntPtr inst, IntPtr destination)
		{
			try {
				Download __obj = GLib.Object.GetObject (inst, false) as Download;
				__obj.OnCreatedDestination (GLib.Marshaller.Utf8PtrToString (destination));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.Download), ConnectionMethod="OverrideCreatedDestination")]
		protected virtual void OnCreatedDestination (string destination)
		{
			InternalCreatedDestination (destination);
		}

		private void InternalCreatedDestination (string destination)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (destination);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
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
				Download __obj = GLib.Object.GetObject (inst, false) as Download;
				__obj.OnFailed (error);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.Download), ConnectionMethod="OverrideFailed")]
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
				Download __obj = GLib.Object.GetObject (inst, false) as Download;
				__obj.OnFinished ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.Download), ConnectionMethod="OverrideFinished")]
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

		static ReceivedDataNativeDelegate ReceivedData_cb_delegate;
		static ReceivedDataNativeDelegate ReceivedDataVMCallback {
			get {
				if (ReceivedData_cb_delegate == null)
					ReceivedData_cb_delegate = new ReceivedDataNativeDelegate (ReceivedData_cb);
				return ReceivedData_cb_delegate;
			}
		}

		static void OverrideReceivedData (GLib.GType gtype)
		{
			OverrideReceivedData (gtype, ReceivedDataVMCallback);
		}

		static void OverrideReceivedData (GLib.GType gtype, ReceivedDataNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "received-data", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReceivedDataNativeDelegate (IntPtr inst, ulong data_length);

		static void ReceivedData_cb (IntPtr inst, ulong data_length)
		{
			try {
				Download __obj = GLib.Object.GetObject (inst, false) as Download;
				__obj.OnReceivedData (data_length);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.Download), ConnectionMethod="OverrideReceivedData")]
		protected virtual void OnReceivedData (ulong data_length)
		{
			InternalReceivedData (data_length);
		}

		private void InternalReceivedData (ulong data_length)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (data_length);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static DecideDestinationNativeDelegate DecideDestination_cb_delegate;
		static DecideDestinationNativeDelegate DecideDestinationVMCallback {
			get {
				if (DecideDestination_cb_delegate == null)
					DecideDestination_cb_delegate = new DecideDestinationNativeDelegate (DecideDestination_cb);
				return DecideDestination_cb_delegate;
			}
		}

		static void OverrideDecideDestination (GLib.GType gtype)
		{
			OverrideDecideDestination (gtype, DecideDestinationVMCallback);
		}

		static void OverrideDecideDestination (GLib.GType gtype, DecideDestinationNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("decide_destination"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool DecideDestinationNativeDelegate (IntPtr inst, IntPtr suggested_filename);

		static bool DecideDestination_cb (IntPtr inst, IntPtr suggested_filename)
		{
			try {
				Download __obj = GLib.Object.GetObject (inst, false) as Download;
				bool __result;
				__result = __obj.OnDecideDestination (GLib.Marshaller.Utf8PtrToString (suggested_filename));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.Download), ConnectionMethod="OverrideDecideDestination")]
		protected virtual bool OnDecideDestination (string suggested_filename)
		{
			return InternalDecideDestination (suggested_filename);
		}

		private bool InternalDecideDestination (string suggested_filename)
		{
			DecideDestinationNativeDelegate unmanaged = class_abi.BaseOverride<DecideDestinationNativeDelegate>(this.LookupGType(), "decide_destination");
			if (unmanaged == null) return false;

			IntPtr native_suggested_filename = GLib.Marshaller.StringToPtrGStrdup (suggested_filename);
			bool __result = unmanaged (this.Handle, native_suggested_filename);
			GLib.Marshaller.Free (native_suggested_filename);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("decide_destination"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // decide_destination
							, null
							, "_webkit_reserved0"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved0"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved0
							, "decide_destination"
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
		delegate IntPtr d_webkit_download_get_type();
		static d_webkit_download_get_type webkit_download_get_type = FuncLoader.LoadFunction<d_webkit_download_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_download_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_download_cancel(IntPtr raw);
		static d_webkit_download_cancel webkit_download_cancel = FuncLoader.LoadFunction<d_webkit_download_cancel>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_cancel"));

		public void Cancel() {
			webkit_download_cancel(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate double d_webkit_download_get_elapsed_time(IntPtr raw);
		static d_webkit_download_get_elapsed_time webkit_download_get_elapsed_time = FuncLoader.LoadFunction<d_webkit_download_get_elapsed_time>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_elapsed_time"));

		public double ElapsedTime { 
			get {
				double raw_ret = webkit_download_get_elapsed_time(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ulong d_webkit_download_get_received_data_length(IntPtr raw);
		static d_webkit_download_get_received_data_length webkit_download_get_received_data_length = FuncLoader.LoadFunction<d_webkit_download_get_received_data_length>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_received_data_length"));

		public ulong ReceivedDataLength { 
			get {
				ulong raw_ret = webkit_download_get_received_data_length(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_download_get_request(IntPtr raw);
		static d_webkit_download_get_request webkit_download_get_request = FuncLoader.LoadFunction<d_webkit_download_get_request>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_request"));

		public WebKit.URIRequest Request { 
			get {
				IntPtr raw_ret = webkit_download_get_request(Handle);
				WebKit.URIRequest ret = GLib.Object.GetObject(raw_ret) as WebKit.URIRequest;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_download_get_web_view(IntPtr raw);
		static d_webkit_download_get_web_view webkit_download_get_web_view = FuncLoader.LoadFunction<d_webkit_download_get_web_view>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_download_get_web_view"));

		public WebKit.WebView WebView { 
			get {
				IntPtr raw_ret = webkit_download_get_web_view(Handle);
				WebKit.WebView ret = GLib.Object.GetObject(raw_ret) as WebKit.WebView;
				return ret;
			}
		}


		static Download ()
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
