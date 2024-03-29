// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class AutomationSession : GLib.Object {

		public AutomationSession (IntPtr raw) : base(raw) {}

		protected AutomationSession() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_automation_session_get_id(IntPtr raw);
		static d_webkit_automation_session_get_id webkit_automation_session_get_id = FuncLoader.LoadFunction<d_webkit_automation_session_get_id>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_automation_session_get_id"));

		[GLib.Property ("id")]
		public string Id {
			get  {
				IntPtr raw_ret = webkit_automation_session_get_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[GLib.Signal("create-web-view")]
		public event WebKit.CreateWebViewHandler CreateWebView {
			add {
				this.AddSignalHandler ("create-web-view", value, typeof (WebKit.CreateWebViewArgs));
			}
			remove {
				this.RemoveSignalHandler ("create-web-view", value);
			}
		}

		static CreateWebViewNativeDelegate CreateWebView_cb_delegate;
		static CreateWebViewNativeDelegate CreateWebViewVMCallback {
			get {
				if (CreateWebView_cb_delegate == null)
					CreateWebView_cb_delegate = new CreateWebViewNativeDelegate (CreateWebView_cb);
				return CreateWebView_cb_delegate;
			}
		}

		static void OverrideCreateWebView (GLib.GType gtype)
		{
			OverrideCreateWebView (gtype, CreateWebViewVMCallback);
		}

		static void OverrideCreateWebView (GLib.GType gtype, CreateWebViewNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "create-web-view", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateWebViewNativeDelegate (IntPtr inst);

		static IntPtr CreateWebView_cb (IntPtr inst)
		{
			try {
				AutomationSession __obj = GLib.Object.GetObject (inst, false) as AutomationSession;
				WebKit.WebView __result;
				__result = __obj.OnCreateWebView ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(WebKit.AutomationSession), ConnectionMethod="OverrideCreateWebView")]
		protected virtual WebKit.WebView OnCreateWebView ()
		{
			return InternalCreateWebView ();
		}

		private WebKit.WebView InternalCreateWebView ()
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Object);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			WebKit.WebView result = (WebKit.WebView) ret;
			ret.Dispose ();
			return result;
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
		delegate IntPtr d_webkit_automation_session_get_type();
		static d_webkit_automation_session_get_type webkit_automation_session_get_type = FuncLoader.LoadFunction<d_webkit_automation_session_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_automation_session_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_automation_session_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_automation_session_get_application_info(IntPtr raw);
		static d_webkit_automation_session_get_application_info webkit_automation_session_get_application_info = FuncLoader.LoadFunction<d_webkit_automation_session_get_application_info>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_automation_session_get_application_info"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_automation_session_set_application_info(IntPtr raw, IntPtr value);
		static d_webkit_automation_session_set_application_info webkit_automation_session_set_application_info = FuncLoader.LoadFunction<d_webkit_automation_session_set_application_info>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_automation_session_set_application_info"));

		public WebKit.ApplicationInfo ApplicationInfo { 
			get {
				IntPtr raw_ret = webkit_automation_session_get_application_info(Handle);
				WebKit.ApplicationInfo ret = WebKit.ApplicationInfo.New (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				webkit_automation_session_set_application_info(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}


		static AutomationSession ()
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
