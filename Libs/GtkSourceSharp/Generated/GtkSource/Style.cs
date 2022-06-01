// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Style : GLib.Object {

		public Style (IntPtr raw) : base(raw) {}

		protected Style() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("line-background")]
		public string LineBackground {
			get {
				GLib.Value val = GetProperty ("line-background");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("background")]
		public string Background {
			get {
				GLib.Value val = GetProperty ("background");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("foreground")]
		public string Foreground {
			get {
				GLib.Value val = GetProperty ("foreground");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("bold")]
		public bool Bold {
			get {
				GLib.Value val = GetProperty ("bold");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("italic")]
		public bool Italic {
			get {
				GLib.Value val = GetProperty ("italic");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("pango-underline")]
		public Pango.Underline PangoUnderline {
			get {
				GLib.Value val = GetProperty ("pango-underline");
				Pango.Underline ret = (Pango.Underline) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("strikethrough")]
		public bool Strikethrough {
			get {
				GLib.Value val = GetProperty ("strikethrough");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("scale")]
		public string Scale {
			get {
				GLib.Value val = GetProperty ("scale");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("underline-color")]
		public string UnderlineColor {
			get {
				GLib.Value val = GetProperty ("underline-color");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("line-background-set")]
		public bool LineBackgroundSet {
			get {
				GLib.Value val = GetProperty ("line-background-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("foreground-set")]
		public bool ForegroundSet {
			get {
				GLib.Value val = GetProperty ("foreground-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("background-set")]
		public bool BackgroundSet {
			get {
				GLib.Value val = GetProperty ("background-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("bold-set")]
		public bool BoldSet {
			get {
				GLib.Value val = GetProperty ("bold-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("italic-set")]
		public bool ItalicSet {
			get {
				GLib.Value val = GetProperty ("italic-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("underline-set")]
		public bool UnderlineSet {
			get {
				GLib.Value val = GetProperty ("underline-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("strikethrough-set")]
		public bool StrikethroughSet {
			get {
				GLib.Value val = GetProperty ("strikethrough-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("scale-set")]
		public bool ScaleSet {
			get {
				GLib.Value val = GetProperty ("scale-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("underline-color-set")]
		public bool UnderlineColorSet {
			get {
				GLib.Value val = GetProperty ("underline-color-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_style_apply(IntPtr raw, IntPtr tag);
		static d_gtk_source_style_apply gtk_source_style_apply = FuncLoader.LoadFunction<d_gtk_source_style_apply>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_style_apply"));

		public void Apply(Gtk.TextTag tag) {
			gtk_source_style_apply(Handle, tag == null ? IntPtr.Zero : tag.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_style_copy(IntPtr raw);
		static d_gtk_source_style_copy gtk_source_style_copy = FuncLoader.LoadFunction<d_gtk_source_style_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_style_copy"));

		public GtkSource.Style Copy() {
			IntPtr raw_ret = gtk_source_style_copy(Handle);
			GtkSource.Style ret = GLib.Object.GetObject(raw_ret, true) as GtkSource.Style;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_style_get_type();
		static d_gtk_source_style_get_type gtk_source_style_get_type = FuncLoader.LoadFunction<d_gtk_source_style_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_style_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_style_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static Style ()
		{
			GtkSharp.GtkSourceSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
