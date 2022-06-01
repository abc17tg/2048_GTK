// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class CellRendererText : Gtk.CellRenderer {

		public CellRendererText (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_cell_renderer_text_new();
		static d_gtk_cell_renderer_text_new gtk_cell_renderer_text_new = FuncLoader.LoadFunction<d_gtk_cell_renderer_text_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_renderer_text_new"));

		public CellRendererText () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellRendererText)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_cell_renderer_text_new();
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

		[GLib.Property ("markup")]
		public string Markup {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("markup", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("attributes")]
		public Pango.AttrList Attributes {
			get {
				GLib.Value val = GetProperty ("attributes");
				Pango.AttrList ret = (Pango.AttrList) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "PangoAttrList");
				SetProperty("attributes", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("single-paragraph-mode")]
		public bool SingleParagraphMode {
			get {
				GLib.Value val = GetProperty ("single-paragraph-mode");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("single-paragraph-mode", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background")]
		public string Background {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background-gdk")]
		public Gdk.Color BackgroundGdk {
			get {
				GLib.Value val = GetProperty ("background-gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("background-gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background-rgba")]
		public Gdk.RGBA BackgroundRgba {
			get {
				GLib.Value val = GetProperty ("background-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground")]
		public string Foreground {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("foreground", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground-gdk")]
		public Gdk.Color ForegroundGdk {
			get {
				GLib.Value val = GetProperty ("foreground-gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("foreground-gdk", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("foreground-rgba")]
		public Gdk.RGBA ForegroundRgba {
			get {
				GLib.Value val = GetProperty ("foreground-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("foreground-rgba", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("editable")]
		public bool Editable {
			get {
				GLib.Value val = GetProperty ("editable");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("editable", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font")]
		public string Font {
			get {
				GLib.Value val = GetProperty ("font");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("font-desc")]
		public Pango.FontDescription FontDesc {
			get {
				GLib.Value val = GetProperty ("font-desc");
				Pango.FontDescription ret = (Pango.FontDescription) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value, "PangoFontDescription");
				SetProperty("font-desc", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("family")]
		public string Family {
			get {
				GLib.Value val = GetProperty ("family");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("family", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("style")]
		public Pango.Style Style {
			get {
				GLib.Value val = GetProperty ("style");
				Pango.Style ret = (Pango.Style) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("style", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("variant")]
		public Pango.Variant Variant {
			get {
				GLib.Value val = GetProperty ("variant");
				Pango.Variant ret = (Pango.Variant) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("variant", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("weight")]
		public int Weight {
			get {
				GLib.Value val = GetProperty ("weight");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("weight", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("stretch")]
		public Pango.Stretch Stretch {
			get {
				GLib.Value val = GetProperty ("stretch");
				Pango.Stretch ret = (Pango.Stretch) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("stretch", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size")]
		public int Size {
			get {
				GLib.Value val = GetProperty ("size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("size-points")]
		public double SizePoints {
			get {
				GLib.Value val = GetProperty ("size-points");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("size-points", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("scale")]
		public double Scale {
			get {
				GLib.Value val = GetProperty ("scale");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("scale", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("rise")]
		public int Rise {
			get {
				GLib.Value val = GetProperty ("rise");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("rise", val);
				val.Dispose ();
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
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("strikethrough", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("underline")]
		public Pango.Underline Underline {
			get {
				GLib.Value val = GetProperty ("underline");
				Pango.Underline ret = (Pango.Underline) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("underline", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("language")]
		public string Language {
			get {
				GLib.Value val = GetProperty ("language");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("language", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("ellipsize")]
		public Pango.EllipsizeMode Ellipsize {
			get {
				GLib.Value val = GetProperty ("ellipsize");
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("ellipsize", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("width-chars")]
		public int WidthChars {
			get {
				GLib.Value val = GetProperty ("width-chars");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("width-chars", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("max-width-chars")]
		public int MaxWidthChars {
			get {
				GLib.Value val = GetProperty ("max-width-chars");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("max-width-chars", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("wrap-mode")]
		public Pango.WrapMode WrapMode {
			get {
				GLib.Value val = GetProperty ("wrap-mode");
				Pango.WrapMode ret = (Pango.WrapMode) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("wrap-mode", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("wrap-width")]
		public int WrapWidth {
			get {
				GLib.Value val = GetProperty ("wrap-width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("wrap-width", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("alignment")]
		public Pango.Alignment Alignment {
			get {
				GLib.Value val = GetProperty ("alignment");
				Pango.Alignment ret = (Pango.Alignment) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("alignment", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("placeholder-text")]
		public string PlaceholderText {
			get {
				GLib.Value val = GetProperty ("placeholder-text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("placeholder-text", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("edited")]
		public event Gtk.EditedHandler Edited {
			add {
				this.AddSignalHandler ("edited", value, typeof (Gtk.EditedArgs));
			}
			remove {
				this.RemoveSignalHandler ("edited", value);
			}
		}

		static EditedNativeDelegate Edited_cb_delegate;
		static EditedNativeDelegate EditedVMCallback {
			get {
				if (Edited_cb_delegate == null)
					Edited_cb_delegate = new EditedNativeDelegate (Edited_cb);
				return Edited_cb_delegate;
			}
		}

		static void OverrideEdited (GLib.GType gtype)
		{
			OverrideEdited (gtype, EditedVMCallback);
		}

		static void OverrideEdited (GLib.GType gtype, EditedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("edited"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EditedNativeDelegate (IntPtr inst, IntPtr path, IntPtr new_text);

		static void Edited_cb (IntPtr inst, IntPtr path, IntPtr new_text)
		{
			try {
				CellRendererText __obj = GLib.Object.GetObject (inst, false) as CellRendererText;
				__obj.OnEdited (GLib.Marshaller.Utf8PtrToString (path), GLib.Marshaller.Utf8PtrToString (new_text));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CellRendererText), ConnectionMethod="OverrideEdited")]
		protected virtual void OnEdited (string path, string new_text)
		{
			InternalEdited (path, new_text);
		}

		private void InternalEdited (string path, string new_text)
		{
			EditedNativeDelegate unmanaged = class_abi.BaseOverride<EditedNativeDelegate>(this.LookupGType(), "edited");
			if (unmanaged == null) return;

			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr native_new_text = GLib.Marshaller.StringToPtrGStrdup (new_text);
			unmanaged (this.Handle, native_path, native_new_text);
			GLib.Marshaller.Free (native_path);
			GLib.Marshaller.Free (native_new_text);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("edited"
							, Gtk.CellRenderer.class_abi.Fields
							, (uint) sizeof( IntPtr ) // edited
							, null
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "edited"
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
		delegate IntPtr d_gtk_cell_renderer_text_get_type();
		static d_gtk_cell_renderer_text_get_type gtk_cell_renderer_text_get_type = FuncLoader.LoadFunction<d_gtk_cell_renderer_text_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_renderer_text_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_cell_renderer_text_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_cell_renderer_text_set_fixed_height_from_font(IntPtr raw, int number_of_rows);
		static d_gtk_cell_renderer_text_set_fixed_height_from_font gtk_cell_renderer_text_set_fixed_height_from_font = FuncLoader.LoadFunction<d_gtk_cell_renderer_text_set_fixed_height_from_font>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_cell_renderer_text_set_fixed_height_from_font"));

		public int FixedHeightFromFont { 
			set {
				gtk_cell_renderer_text_set_fixed_height_from_font(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.CellRenderer.abi_info.Fields
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
