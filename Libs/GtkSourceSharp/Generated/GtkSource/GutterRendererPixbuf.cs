// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class GutterRendererPixbuf : GtkSource.GutterRenderer {

		public GutterRendererPixbuf (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_gutter_renderer_pixbuf_new();
		static d_gtk_source_gutter_renderer_pixbuf_new gtk_source_gutter_renderer_pixbuf_new = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_new"));

		public GutterRendererPixbuf () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GutterRendererPixbuf)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_source_gutter_renderer_pixbuf_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_gutter_renderer_pixbuf_get_pixbuf(IntPtr raw);
		static d_gtk_source_gutter_renderer_pixbuf_get_pixbuf gtk_source_gutter_renderer_pixbuf_get_pixbuf = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_get_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_get_pixbuf"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_gutter_renderer_pixbuf_set_pixbuf(IntPtr raw, IntPtr pixbuf);
		static d_gtk_source_gutter_renderer_pixbuf_set_pixbuf gtk_source_gutter_renderer_pixbuf_set_pixbuf = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_set_pixbuf>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_set_pixbuf"));

		[GLib.Property ("pixbuf")]
		public Gdk.Pixbuf Pixbuf {
			get  {
				IntPtr raw_ret = gtk_source_gutter_renderer_pixbuf_get_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
			set  {
				gtk_source_gutter_renderer_pixbuf_set_pixbuf(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_gutter_renderer_pixbuf_get_icon_name(IntPtr raw);
		static d_gtk_source_gutter_renderer_pixbuf_get_icon_name gtk_source_gutter_renderer_pixbuf_get_icon_name = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_get_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_get_icon_name"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_gutter_renderer_pixbuf_set_icon_name(IntPtr raw, IntPtr icon_name);
		static d_gtk_source_gutter_renderer_pixbuf_set_icon_name gtk_source_gutter_renderer_pixbuf_set_icon_name = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_set_icon_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_set_icon_name"));

		[GLib.Property ("icon-name")]
		public string IconName {
			get  {
				IntPtr raw_ret = gtk_source_gutter_renderer_pixbuf_get_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_source_gutter_renderer_pixbuf_set_icon_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_gutter_renderer_pixbuf_get_gicon(IntPtr raw);
		static d_gtk_source_gutter_renderer_pixbuf_get_gicon gtk_source_gutter_renderer_pixbuf_get_gicon = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_get_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_get_gicon"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_gutter_renderer_pixbuf_set_gicon(IntPtr raw, IntPtr icon);
		static d_gtk_source_gutter_renderer_pixbuf_set_gicon gtk_source_gutter_renderer_pixbuf_set_gicon = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_set_gicon>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_set_gicon"));

		[GLib.Property ("gicon")]
		public GLib.IIcon Gicon {
			get  {
				IntPtr raw_ret = gtk_source_gutter_renderer_pixbuf_get_gicon(Handle);
				GLib.IIcon ret = GLib.IconAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				gtk_source_gutter_renderer_pixbuf_set_gicon(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.IconAdapter).Handle));
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("padding"
							, GtkSource.GutterRenderer.class_abi.Fields
							, (uint) sizeof( IntPtr ) * 10 // padding
							, null
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
		delegate IntPtr d_gtk_source_gutter_renderer_pixbuf_get_type();
		static d_gtk_source_gutter_renderer_pixbuf_get_type gtk_source_gutter_renderer_pixbuf_get_type = FuncLoader.LoadFunction<d_gtk_source_gutter_renderer_pixbuf_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_gutter_renderer_pixbuf_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_gutter_renderer_pixbuf_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static GutterRendererPixbuf ()
		{
			GtkSharp.GtkSourceSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GtkSource.GutterRenderer.abi_info.Fields
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
