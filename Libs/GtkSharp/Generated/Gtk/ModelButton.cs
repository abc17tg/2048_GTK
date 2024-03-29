// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class ModelButton : Gtk.Button {

		public ModelButton (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_model_button_new();
		static d_gtk_model_button_new gtk_model_button_new = FuncLoader.LoadFunction<d_gtk_model_button_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_model_button_new"));

		public ModelButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ModelButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_model_button_new();
		}

		[GLib.Property ("role")]
		public Gtk.ButtonRole Role {
			get {
				GLib.Value val = GetProperty ("role");
				Gtk.ButtonRole ret = (Gtk.ButtonRole) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("role", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("icon")]
		public GLib.IIcon Icon {
			get {
				GLib.Value val = GetProperty ("icon");
				GLib.IIcon ret = GLib.IconAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("icon", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text")]
		public string Text {
			get {
				GLib.Value val = GetProperty ("text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("active")]
		public bool Active {
			get {
				GLib.Value val = GetProperty ("active");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("active", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("menu-name")]
		public string MenuName {
			get {
				GLib.Value val = GetProperty ("menu-name");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("menu-name", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("inverted")]
		public bool Inverted {
			get {
				GLib.Value val = GetProperty ("inverted");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("inverted", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("centered")]
		public bool Centered {
			get {
				GLib.Value val = GetProperty ("centered");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("centered", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("iconic")]
		public bool Iconic {
			get {
				GLib.Value val = GetProperty ("iconic");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("iconic", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_model_button_get_type();
		static d_gtk_model_button_get_type gtk_model_button_get_type = FuncLoader.LoadFunction<d_gtk_model_button_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_model_button_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_model_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
