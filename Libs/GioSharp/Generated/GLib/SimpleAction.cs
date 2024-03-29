// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class SimpleAction : GLib.Object, GLib.IAction {

		public SimpleAction (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_action_new(IntPtr name, IntPtr parameter_type);
		static d_g_simple_action_new g_simple_action_new = FuncLoader.LoadFunction<d_g_simple_action_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_action_new"));

		public SimpleAction (string name, GLib.VariantType parameter_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SimpleAction)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				names.Add ("parameter_type");
				vals.Add (new GLib.Value (parameter_type));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = g_simple_action_new(native_name, parameter_type == null ? IntPtr.Zero : parameter_type.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_action_new_stateful(IntPtr name, IntPtr parameter_type, IntPtr state);
		static d_g_simple_action_new_stateful g_simple_action_new_stateful = FuncLoader.LoadFunction<d_g_simple_action_new_stateful>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_action_new_stateful"));

		public SimpleAction (string name, GLib.VariantType parameter_type, GLib.Variant state) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SimpleAction)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				names.Add ("parameter_type");
				vals.Add (new GLib.Value (parameter_type));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = g_simple_action_new_stateful(native_name, parameter_type == null ? IntPtr.Zero : parameter_type.Handle, state == null ? IntPtr.Zero : state.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[GLib.Property ("name")]
		public string Name {
			get {
				GLib.Value val = GetProperty ("name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("parameter-type")]
		public GLib.VariantType ParameterType {
			get {
				GLib.Value val = GetProperty ("parameter-type");
				GLib.VariantType ret = (GLib.VariantType) val;
				val.Dispose ();
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_simple_action_set_enabled(IntPtr raw, bool enabled);
		static d_g_simple_action_set_enabled g_simple_action_set_enabled = FuncLoader.LoadFunction<d_g_simple_action_set_enabled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_action_set_enabled"));

		[GLib.Property ("enabled")]
		public bool Enabled {
			get {
				GLib.Value val = GetProperty ("enabled");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set  {
				g_simple_action_set_enabled(Handle, value);
			}
		}

		[GLib.Property ("state-type")]
		public GLib.VariantType StateType {
			get {
				GLib.Value val = GetProperty ("state-type");
				GLib.VariantType ret = (GLib.VariantType) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("activate")]
		public event GLib.ActivatedHandler Activated {
			add {
				this.AddSignalHandler ("activate", value, typeof (GLib.ActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("activate", value);
			}
		}

		[GLib.Signal("change-state")]
		public event GLib.StateChangedHandler StateChanged {
			add {
				this.AddSignalHandler ("change-state", value, typeof (GLib.StateChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("change-state", value);
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
			OverrideVirtualMethod (gtype, "activate", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivatedNativeDelegate (IntPtr inst, IntPtr p0);

		static void Activated_cb (IntPtr inst, IntPtr p0)
		{
			try {
				SimpleAction __obj = GLib.Object.GetObject (inst, false) as SimpleAction;
				__obj.OnActivated (new GLib.Variant(p0));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SimpleAction), ConnectionMethod="OverrideActivated")]
		protected virtual void OnActivated (GLib.Variant p0)
		{
			InternalActivated (p0);
		}

		private void InternalActivated (GLib.Variant p0)
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

		static StateChangedNativeDelegate StateChanged_cb_delegate;
		static StateChangedNativeDelegate StateChangedVMCallback {
			get {
				if (StateChanged_cb_delegate == null)
					StateChanged_cb_delegate = new StateChangedNativeDelegate (StateChanged_cb);
				return StateChanged_cb_delegate;
			}
		}

		static void OverrideStateChanged (GLib.GType gtype)
		{
			OverrideStateChanged (gtype, StateChangedVMCallback);
		}

		static void OverrideStateChanged (GLib.GType gtype, StateChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "change-state", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StateChangedNativeDelegate (IntPtr inst, IntPtr p0);

		static void StateChanged_cb (IntPtr inst, IntPtr p0)
		{
			try {
				SimpleAction __obj = GLib.Object.GetObject (inst, false) as SimpleAction;
				__obj.OnStateChanged (new GLib.Variant(p0));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SimpleAction), ConnectionMethod="OverrideStateChanged")]
		protected virtual void OnStateChanged (GLib.Variant p0)
		{
			InternalStateChanged (p0);
		}

		private void InternalStateChanged (GLib.Variant p0)
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

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_simple_action_get_type();
		static d_g_simple_action_get_type g_simple_action_get_type = FuncLoader.LoadFunction<d_g_simple_action_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_simple_action_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_simple_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_action_activate(IntPtr raw, IntPtr parameter);
		static d_g_action_activate g_action_activate = FuncLoader.LoadFunction<d_g_action_activate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_activate"));

		public void Activate(GLib.Variant parameter) {
			g_action_activate(Handle, parameter == null ? IntPtr.Zero : parameter.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_action_change_state(IntPtr raw, IntPtr value);
		static d_g_action_change_state g_action_change_state = FuncLoader.LoadFunction<d_g_action_change_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_change_state"));

		public void ChangeState(GLib.Variant value) {
			g_action_change_state(Handle, value == null ? IntPtr.Zero : value.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_action_get_enabled(IntPtr raw);
		static d_g_action_get_enabled g_action_get_enabled = FuncLoader.LoadFunction<d_g_action_get_enabled>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_get_enabled"));

		bool GLib.IAction.Enabled { 
			get {
				bool raw_ret = g_action_get_enabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_action_get_name(IntPtr raw);
		static d_g_action_get_name g_action_get_name = FuncLoader.LoadFunction<d_g_action_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_get_name"));

		string GLib.IAction.Name { 
			get {
				IntPtr raw_ret = g_action_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_action_get_parameter_type(IntPtr raw);
		static d_g_action_get_parameter_type g_action_get_parameter_type = FuncLoader.LoadFunction<d_g_action_get_parameter_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_get_parameter_type"));

		GLib.VariantType GLib.IAction.ParameterType { 
			get {
				IntPtr raw_ret = g_action_get_parameter_type(Handle);
				GLib.VariantType ret = new GLib.VariantType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_action_get_state(IntPtr raw);
		static d_g_action_get_state g_action_get_state = FuncLoader.LoadFunction<d_g_action_get_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_get_state"));

		public GLib.Variant State { 
			get {
				IntPtr raw_ret = g_action_get_state(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_action_get_state_hint(IntPtr raw);
		static d_g_action_get_state_hint g_action_get_state_hint = FuncLoader.LoadFunction<d_g_action_get_state_hint>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_get_state_hint"));

		public GLib.Variant StateHint { 
			get {
				IntPtr raw_ret = g_action_get_state_hint(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_action_get_state_type(IntPtr raw);
		static d_g_action_get_state_type g_action_get_state_type = FuncLoader.LoadFunction<d_g_action_get_state_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_action_get_state_type"));

		GLib.VariantType GLib.IAction.StateType { 
			get {
				IntPtr raw_ret = g_action_get_state_type(Handle);
				GLib.VariantType ret = new GLib.VariantType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
