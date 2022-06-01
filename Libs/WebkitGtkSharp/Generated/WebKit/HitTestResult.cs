// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class HitTestResult : GLib.Object {

		public HitTestResult (IntPtr raw) : base(raw) {}

		protected HitTestResult() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_webkit_hit_test_result_get_context(IntPtr raw);
		static d_webkit_hit_test_result_get_context webkit_hit_test_result_get_context = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_context"));

		[GLib.Property ("context")]
		public uint Context {
			get  {
				uint raw_ret = webkit_hit_test_result_get_context(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_hit_test_result_get_image_uri(IntPtr raw);
		static d_webkit_hit_test_result_get_image_uri webkit_hit_test_result_get_image_uri = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_image_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_image_uri"));

		[GLib.Property ("image-uri")]
		public string ImageUri {
			get  {
				IntPtr raw_ret = webkit_hit_test_result_get_image_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_hit_test_result_get_link_label(IntPtr raw);
		static d_webkit_hit_test_result_get_link_label webkit_hit_test_result_get_link_label = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_link_label>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_link_label"));

		[GLib.Property ("link-label")]
		public string LinkLabel {
			get  {
				IntPtr raw_ret = webkit_hit_test_result_get_link_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_hit_test_result_get_link_title(IntPtr raw);
		static d_webkit_hit_test_result_get_link_title webkit_hit_test_result_get_link_title = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_link_title>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_link_title"));

		[GLib.Property ("link-title")]
		public string LinkTitle {
			get  {
				IntPtr raw_ret = webkit_hit_test_result_get_link_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_hit_test_result_get_link_uri(IntPtr raw);
		static d_webkit_hit_test_result_get_link_uri webkit_hit_test_result_get_link_uri = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_link_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_link_uri"));

		[GLib.Property ("link-uri")]
		public string LinkUri {
			get  {
				IntPtr raw_ret = webkit_hit_test_result_get_link_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_hit_test_result_get_media_uri(IntPtr raw);
		static d_webkit_hit_test_result_get_media_uri webkit_hit_test_result_get_media_uri = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_media_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_media_uri"));

		[GLib.Property ("media-uri")]
		public string MediaUri {
			get  {
				IntPtr raw_ret = webkit_hit_test_result_get_media_uri(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
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
		delegate IntPtr d_webkit_hit_test_result_get_type();
		static d_webkit_hit_test_result_get_type webkit_hit_test_result_get_type = FuncLoader.LoadFunction<d_webkit_hit_test_result_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_hit_test_result_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_hit_test_result_context_is_editable(IntPtr raw);
		static d_webkit_hit_test_result_context_is_editable webkit_hit_test_result_context_is_editable = FuncLoader.LoadFunction<d_webkit_hit_test_result_context_is_editable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_context_is_editable"));

		public bool ContextIsEditable() {
			bool raw_ret = webkit_hit_test_result_context_is_editable(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_hit_test_result_context_is_image(IntPtr raw);
		static d_webkit_hit_test_result_context_is_image webkit_hit_test_result_context_is_image = FuncLoader.LoadFunction<d_webkit_hit_test_result_context_is_image>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_context_is_image"));

		public bool ContextIsImage() {
			bool raw_ret = webkit_hit_test_result_context_is_image(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_hit_test_result_context_is_link(IntPtr raw);
		static d_webkit_hit_test_result_context_is_link webkit_hit_test_result_context_is_link = FuncLoader.LoadFunction<d_webkit_hit_test_result_context_is_link>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_context_is_link"));

		public bool ContextIsLink() {
			bool raw_ret = webkit_hit_test_result_context_is_link(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_hit_test_result_context_is_media(IntPtr raw);
		static d_webkit_hit_test_result_context_is_media webkit_hit_test_result_context_is_media = FuncLoader.LoadFunction<d_webkit_hit_test_result_context_is_media>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_context_is_media"));

		public bool ContextIsMedia() {
			bool raw_ret = webkit_hit_test_result_context_is_media(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_hit_test_result_context_is_scrollbar(IntPtr raw);
		static d_webkit_hit_test_result_context_is_scrollbar webkit_hit_test_result_context_is_scrollbar = FuncLoader.LoadFunction<d_webkit_hit_test_result_context_is_scrollbar>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_context_is_scrollbar"));

		public bool ContextIsScrollbar() {
			bool raw_ret = webkit_hit_test_result_context_is_scrollbar(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_hit_test_result_context_is_selection(IntPtr raw);
		static d_webkit_hit_test_result_context_is_selection webkit_hit_test_result_context_is_selection = FuncLoader.LoadFunction<d_webkit_hit_test_result_context_is_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_hit_test_result_context_is_selection"));

		public bool ContextIsSelection() {
			bool raw_ret = webkit_hit_test_result_context_is_selection(Handle);
			bool ret = raw_ret;
			return ret;
		}


		static HitTestResult ()
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
