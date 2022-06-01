// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class FontSelection : Gtk.Box {

		public FontSelection (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_new();
		static d_gtk_font_selection_new gtk_font_selection_new = FuncLoader.LoadFunction<d_gtk_font_selection_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_new"));

		public FontSelection () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontSelection)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_font_selection_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_font_name(IntPtr raw);
		static d_gtk_font_selection_get_font_name gtk_font_selection_get_font_name = FuncLoader.LoadFunction<d_gtk_font_selection_get_font_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_font_name"));

		[Obsolete]
		[GLib.Property ("font-name")]
		public string FontName {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_font_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font-name", val);
				val.Dispose ();
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_preview_text(IntPtr raw);
		static d_gtk_font_selection_get_preview_text gtk_font_selection_get_preview_text = FuncLoader.LoadFunction<d_gtk_font_selection_get_preview_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_preview_text"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_font_selection_set_preview_text(IntPtr raw, IntPtr text);
		static d_gtk_font_selection_set_preview_text gtk_font_selection_set_preview_text = FuncLoader.LoadFunction<d_gtk_font_selection_set_preview_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_set_preview_text"));

		[Obsolete]
		[GLib.Property ("preview-text")]
		public string PreviewText {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_preview_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_selection_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Box.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, null
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
		delegate IntPtr d_gtk_font_selection_get_face(IntPtr raw);
		static d_gtk_font_selection_get_face gtk_font_selection_get_face = FuncLoader.LoadFunction<d_gtk_font_selection_get_face>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_face"));

		[Obsolete]
		public Pango.FontFace Face { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_face(Handle);
				Pango.FontFace ret = GLib.Object.GetObject(raw_ret) as Pango.FontFace;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_face_list(IntPtr raw);
		static d_gtk_font_selection_get_face_list gtk_font_selection_get_face_list = FuncLoader.LoadFunction<d_gtk_font_selection_get_face_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_face_list"));

		[Obsolete]
		public Gtk.Widget FaceList { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_face_list(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_family(IntPtr raw);
		static d_gtk_font_selection_get_family gtk_font_selection_get_family = FuncLoader.LoadFunction<d_gtk_font_selection_get_family>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_family"));

		[Obsolete]
		public Pango.FontFamily Family { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_family(Handle);
				Pango.FontFamily ret = GLib.Object.GetObject(raw_ret) as Pango.FontFamily;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_family_list(IntPtr raw);
		static d_gtk_font_selection_get_family_list gtk_font_selection_get_family_list = FuncLoader.LoadFunction<d_gtk_font_selection_get_family_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_family_list"));

		[Obsolete]
		public Gtk.Widget FamilyList { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_family_list(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_preview_entry(IntPtr raw);
		static d_gtk_font_selection_get_preview_entry gtk_font_selection_get_preview_entry = FuncLoader.LoadFunction<d_gtk_font_selection_get_preview_entry>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_preview_entry"));

		[Obsolete]
		public Gtk.Widget PreviewEntry { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_preview_entry(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_font_selection_get_size(IntPtr raw);
		static d_gtk_font_selection_get_size gtk_font_selection_get_size = FuncLoader.LoadFunction<d_gtk_font_selection_get_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_size"));

		[Obsolete]
		public int Size { 
			get {
				int raw_ret = gtk_font_selection_get_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_size_entry(IntPtr raw);
		static d_gtk_font_selection_get_size_entry gtk_font_selection_get_size_entry = FuncLoader.LoadFunction<d_gtk_font_selection_get_size_entry>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_size_entry"));

		[Obsolete]
		public Gtk.Widget SizeEntry { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_size_entry(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_size_list(IntPtr raw);
		static d_gtk_font_selection_get_size_list gtk_font_selection_get_size_list = FuncLoader.LoadFunction<d_gtk_font_selection_get_size_list>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_size_list"));

		[Obsolete]
		public Gtk.Widget SizeList { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_size_list(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_font_selection_get_type();
		static d_gtk_font_selection_get_type gtk_font_selection_get_type = FuncLoader.LoadFunction<d_gtk_font_selection_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_get_type"));

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_font_selection_set_font_name(IntPtr raw, IntPtr fontname);
		static d_gtk_font_selection_set_font_name gtk_font_selection_set_font_name = FuncLoader.LoadFunction<d_gtk_font_selection_set_font_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_font_selection_set_font_name"));

		[Obsolete]
		public bool SetFontName(string fontname) {
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_selection_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Box.abi_info.Fields
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
