// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class PropertyAction : GLib.Object, GLib.IAction {

		public PropertyAction (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_property_action_new(IntPtr name, IntPtr objekt, IntPtr property_name);
		static d_g_property_action_new g_property_action_new = FuncLoader.LoadFunction<d_g_property_action_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_property_action_new"));

		public PropertyAction (string name, IntPtr objekt, string property_name) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PropertyAction)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("name");
				vals.Add (new GLib.Value (name));
				names.Add ("objekt");
				vals.Add (new GLib.Value (objekt));
				names.Add ("property_name");
				vals.Add (new GLib.Value (property_name));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			Raw = g_property_action_new(native_name, objekt, native_property_name);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_property_name);
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

		[GLib.Property ("enabled")]
		public bool Enabled {
			get {
				GLib.Value val = GetProperty ("enabled");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
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

		[GLib.Property ("invert-boolean")]
		public bool InvertBoolean {
			get {
				GLib.Value val = GetProperty ("invert-boolean");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_property_action_get_type();
		static d_g_property_action_get_type g_property_action_get_type = FuncLoader.LoadFunction<d_g_property_action_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_property_action_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_property_action_get_type();
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
