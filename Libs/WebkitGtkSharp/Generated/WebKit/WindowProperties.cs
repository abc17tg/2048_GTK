// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class WindowProperties : GLib.Object {

		public WindowProperties (IntPtr raw) : base(raw) {}

		protected WindowProperties() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_fullscreen(IntPtr raw);
		static d_webkit_window_properties_get_fullscreen webkit_window_properties_get_fullscreen = FuncLoader.LoadFunction<d_webkit_window_properties_get_fullscreen>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_fullscreen"));

		[GLib.Property ("fullscreen")]
		public bool Fullscreen {
			get  {
				bool raw_ret = webkit_window_properties_get_fullscreen(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_window_properties_get_geometry(IntPtr raw, IntPtr geometry);
		static d_webkit_window_properties_get_geometry webkit_window_properties_get_geometry = FuncLoader.LoadFunction<d_webkit_window_properties_get_geometry>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_geometry"));

		[GLib.Property ("geometry")]
		public Gdk.Rectangle Geometry {
			get  {
				Gdk.Rectangle geometry;
				IntPtr native_geometry = Marshal.AllocHGlobal (Marshal.SizeOf<Gdk.Rectangle>());
				webkit_window_properties_get_geometry(Handle, native_geometry);
				geometry = (Gdk.Rectangle) Marshal.PtrToStructure (native_geometry, typeof (Gdk.Rectangle));
				Marshal.FreeHGlobal (native_geometry);
				return geometry;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_locationbar_visible(IntPtr raw);
		static d_webkit_window_properties_get_locationbar_visible webkit_window_properties_get_locationbar_visible = FuncLoader.LoadFunction<d_webkit_window_properties_get_locationbar_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_locationbar_visible"));

		[GLib.Property ("locationbar-visible")]
		public bool LocationbarVisible {
			get  {
				bool raw_ret = webkit_window_properties_get_locationbar_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_menubar_visible(IntPtr raw);
		static d_webkit_window_properties_get_menubar_visible webkit_window_properties_get_menubar_visible = FuncLoader.LoadFunction<d_webkit_window_properties_get_menubar_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_menubar_visible"));

		[GLib.Property ("menubar-visible")]
		public bool MenubarVisible {
			get  {
				bool raw_ret = webkit_window_properties_get_menubar_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_resizable(IntPtr raw);
		static d_webkit_window_properties_get_resizable webkit_window_properties_get_resizable = FuncLoader.LoadFunction<d_webkit_window_properties_get_resizable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_resizable"));

		[GLib.Property ("resizable")]
		public bool Resizable {
			get  {
				bool raw_ret = webkit_window_properties_get_resizable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_scrollbars_visible(IntPtr raw);
		static d_webkit_window_properties_get_scrollbars_visible webkit_window_properties_get_scrollbars_visible = FuncLoader.LoadFunction<d_webkit_window_properties_get_scrollbars_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_scrollbars_visible"));

		[GLib.Property ("scrollbars-visible")]
		public bool ScrollbarsVisible {
			get  {
				bool raw_ret = webkit_window_properties_get_scrollbars_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_statusbar_visible(IntPtr raw);
		static d_webkit_window_properties_get_statusbar_visible webkit_window_properties_get_statusbar_visible = FuncLoader.LoadFunction<d_webkit_window_properties_get_statusbar_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_statusbar_visible"));

		[GLib.Property ("statusbar-visible")]
		public bool StatusbarVisible {
			get  {
				bool raw_ret = webkit_window_properties_get_statusbar_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_window_properties_get_toolbar_visible(IntPtr raw);
		static d_webkit_window_properties_get_toolbar_visible webkit_window_properties_get_toolbar_visible = FuncLoader.LoadFunction<d_webkit_window_properties_get_toolbar_visible>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_toolbar_visible"));

		[GLib.Property ("toolbar-visible")]
		public bool ToolbarVisible {
			get  {
				bool raw_ret = webkit_window_properties_get_toolbar_visible(Handle);
				bool ret = raw_ret;
				return ret;
			}
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
		delegate IntPtr d_webkit_window_properties_get_type();
		static d_webkit_window_properties_get_type webkit_window_properties_get_type = FuncLoader.LoadFunction<d_webkit_window_properties_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_window_properties_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_window_properties_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static WindowProperties ()
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
