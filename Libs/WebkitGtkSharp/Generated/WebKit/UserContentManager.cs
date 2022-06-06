// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class UserContentManager : GLib.Object {

		public UserContentManager (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_manager_new();
		static d_webkit_user_content_manager_new webkit_user_content_manager_new = FuncLoader.LoadFunction<d_webkit_user_content_manager_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_new"));

		public UserContentManager () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UserContentManager)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = webkit_user_content_manager_new();
		}

		[GLib.Signal("script-message-received")]
		public event WebKit.ScriptMessageReceivedHandler ScriptMessageReceived {
			add {
				this.AddSignalHandler ("script-message-received", value, typeof (WebKit.ScriptMessageReceivedArgs));
			}
			remove {
				this.RemoveSignalHandler ("script-message-received", value);
			}
		}

		static ScriptMessageReceivedNativeDelegate ScriptMessageReceived_cb_delegate;
		static ScriptMessageReceivedNativeDelegate ScriptMessageReceivedVMCallback {
			get {
				if (ScriptMessageReceived_cb_delegate == null)
					ScriptMessageReceived_cb_delegate = new ScriptMessageReceivedNativeDelegate (ScriptMessageReceived_cb);
				return ScriptMessageReceived_cb_delegate;
			}
		}

		static void OverrideScriptMessageReceived (GLib.GType gtype)
		{
			OverrideScriptMessageReceived (gtype, ScriptMessageReceivedVMCallback);
		}

		static void OverrideScriptMessageReceived (GLib.GType gtype, ScriptMessageReceivedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "script-message-received", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ScriptMessageReceivedNativeDelegate (IntPtr inst, IntPtr js_result);

		static void ScriptMessageReceived_cb (IntPtr inst, IntPtr js_result)
		{
			try {
				UserContentManager __obj = GLib.Object.GetObject (inst, false) as UserContentManager;
				__obj.OnScriptMessageReceived (WebKit.JavascriptResult.New (js_result));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.UserContentManager), ConnectionMethod="OverrideScriptMessageReceived")]
		protected virtual void OnScriptMessageReceived (WebKit.JavascriptResult js_result)
		{
			InternalScriptMessageReceived (js_result);
		}

		private void InternalScriptMessageReceived (WebKit.JavascriptResult js_result)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (js_result);
			inst_and_params.Append (vals [1]);
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
		delegate IntPtr d_webkit_user_content_manager_get_type();
		static d_webkit_user_content_manager_get_type webkit_user_content_manager_get_type = FuncLoader.LoadFunction<d_webkit_user_content_manager_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_user_content_manager_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_add_filter(IntPtr raw, IntPtr filter);
		static d_webkit_user_content_manager_add_filter webkit_user_content_manager_add_filter = FuncLoader.LoadFunction<d_webkit_user_content_manager_add_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_add_filter"));

		public void AddFilter(WebKit.UserContentFilter filter) {
			IntPtr native_filter = GLib.Marshaller.StructureToPtrAlloc (filter);
			webkit_user_content_manager_add_filter(Handle, native_filter);
			Marshal.FreeHGlobal (native_filter);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_add_script(IntPtr raw, IntPtr script);
		static d_webkit_user_content_manager_add_script webkit_user_content_manager_add_script = FuncLoader.LoadFunction<d_webkit_user_content_manager_add_script>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_add_script"));

		public void AddScript(WebKit.UserScript script) {
			IntPtr native_script = GLib.Marshaller.StructureToPtrAlloc (script);
			webkit_user_content_manager_add_script(Handle, native_script);
			Marshal.FreeHGlobal (native_script);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_add_style_sheet(IntPtr raw, IntPtr stylesheet);
		static d_webkit_user_content_manager_add_style_sheet webkit_user_content_manager_add_style_sheet = FuncLoader.LoadFunction<d_webkit_user_content_manager_add_style_sheet>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_add_style_sheet"));

		public void AddStyleSheet(WebKit.UserStyleSheet stylesheet) {
			IntPtr native_stylesheet = GLib.Marshaller.StructureToPtrAlloc (stylesheet);
			webkit_user_content_manager_add_style_sheet(Handle, native_stylesheet);
			Marshal.FreeHGlobal (native_stylesheet);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_user_content_manager_register_script_message_handler(IntPtr raw, IntPtr name);
		static d_webkit_user_content_manager_register_script_message_handler webkit_user_content_manager_register_script_message_handler = FuncLoader.LoadFunction<d_webkit_user_content_manager_register_script_message_handler>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_register_script_message_handler"));

		public bool RegisterScriptMessageHandler(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = webkit_user_content_manager_register_script_message_handler(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_user_content_manager_register_script_message_handler_in_world(IntPtr raw, IntPtr name, IntPtr world_name);
		static d_webkit_user_content_manager_register_script_message_handler_in_world webkit_user_content_manager_register_script_message_handler_in_world = FuncLoader.LoadFunction<d_webkit_user_content_manager_register_script_message_handler_in_world>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_register_script_message_handler_in_world"));

		public bool RegisterScriptMessageHandlerInWorld(string name, string world_name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_world_name = GLib.Marshaller.StringToPtrGStrdup (world_name);
			bool raw_ret = webkit_user_content_manager_register_script_message_handler_in_world(Handle, native_name, native_world_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_world_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_all_filters(IntPtr raw);
		static d_webkit_user_content_manager_remove_all_filters webkit_user_content_manager_remove_all_filters = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_all_filters>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_all_filters"));

		public void RemoveAllFilters() {
			webkit_user_content_manager_remove_all_filters(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_all_scripts(IntPtr raw);
		static d_webkit_user_content_manager_remove_all_scripts webkit_user_content_manager_remove_all_scripts = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_all_scripts>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_all_scripts"));

		public void RemoveAllScripts() {
			webkit_user_content_manager_remove_all_scripts(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_all_style_sheets(IntPtr raw);
		static d_webkit_user_content_manager_remove_all_style_sheets webkit_user_content_manager_remove_all_style_sheets = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_all_style_sheets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_all_style_sheets"));

		public void RemoveAllStyleSheets() {
			webkit_user_content_manager_remove_all_style_sheets(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_filter(IntPtr raw, IntPtr filter);
		static d_webkit_user_content_manager_remove_filter webkit_user_content_manager_remove_filter = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_filter"));

		public void RemoveFilter(WebKit.UserContentFilter filter) {
			IntPtr native_filter = GLib.Marshaller.StructureToPtrAlloc (filter);
			webkit_user_content_manager_remove_filter(Handle, native_filter);
			Marshal.FreeHGlobal (native_filter);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_filter_by_id(IntPtr raw, IntPtr filter_id);
		static d_webkit_user_content_manager_remove_filter_by_id webkit_user_content_manager_remove_filter_by_id = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_filter_by_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_filter_by_id"));

		public void RemoveFilterById(string filter_id) {
			IntPtr native_filter_id = GLib.Marshaller.StringToPtrGStrdup (filter_id);
			webkit_user_content_manager_remove_filter_by_id(Handle, native_filter_id);
			GLib.Marshaller.Free (native_filter_id);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_script(IntPtr raw, IntPtr script);
		static d_webkit_user_content_manager_remove_script webkit_user_content_manager_remove_script = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_script>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_script"));

		public void RemoveScript(WebKit.UserScript script) {
			IntPtr native_script = GLib.Marshaller.StructureToPtrAlloc (script);
			webkit_user_content_manager_remove_script(Handle, native_script);
			Marshal.FreeHGlobal (native_script);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_remove_style_sheet(IntPtr raw, IntPtr stylesheet);
		static d_webkit_user_content_manager_remove_style_sheet webkit_user_content_manager_remove_style_sheet = FuncLoader.LoadFunction<d_webkit_user_content_manager_remove_style_sheet>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_remove_style_sheet"));

		public void RemoveStyleSheet(WebKit.UserStyleSheet stylesheet) {
			IntPtr native_stylesheet = GLib.Marshaller.StructureToPtrAlloc (stylesheet);
			webkit_user_content_manager_remove_style_sheet(Handle, native_stylesheet);
			Marshal.FreeHGlobal (native_stylesheet);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_unregister_script_message_handler(IntPtr raw, IntPtr name);
		static d_webkit_user_content_manager_unregister_script_message_handler webkit_user_content_manager_unregister_script_message_handler = FuncLoader.LoadFunction<d_webkit_user_content_manager_unregister_script_message_handler>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_unregister_script_message_handler"));

		public void UnregisterScriptMessageHandler(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			webkit_user_content_manager_unregister_script_message_handler(Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_manager_unregister_script_message_handler_in_world(IntPtr raw, IntPtr name, IntPtr world_name);
		static d_webkit_user_content_manager_unregister_script_message_handler_in_world webkit_user_content_manager_unregister_script_message_handler_in_world = FuncLoader.LoadFunction<d_webkit_user_content_manager_unregister_script_message_handler_in_world>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_manager_unregister_script_message_handler_in_world"));

		public void UnregisterScriptMessageHandlerInWorld(string name, string world_name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_world_name = GLib.Marshaller.StringToPtrGStrdup (world_name);
			webkit_user_content_manager_unregister_script_message_handler_in_world(Handle, native_name, native_world_name);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_world_name);
		}


		static UserContentManager ()
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