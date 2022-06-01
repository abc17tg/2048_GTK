// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Fontset : GLib.Object {

		public Fontset (IntPtr raw) : base(raw) {}

		protected Fontset() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_fontset_foreach(IntPtr raw, PangoSharp.FontsetForeachFuncNative func, IntPtr data);
		static d_pango_fontset_foreach pango_fontset_foreach = FuncLoader.LoadFunction<d_pango_fontset_foreach>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_fontset_foreach"));

		public void Foreach(Pango.FontsetForeachFunc func) {
			PangoSharp.FontsetForeachFuncWrapper func_wrapper = new PangoSharp.FontsetForeachFuncWrapper (func);
			pango_fontset_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_fontset_get_font(IntPtr raw, uint wc);
		static d_pango_fontset_get_font pango_fontset_get_font = FuncLoader.LoadFunction<d_pango_fontset_get_font>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_fontset_get_font"));

		public Pango.Font GetFont(uint wc) {
			IntPtr raw_ret = pango_fontset_get_font(Handle, wc);
			Pango.Font ret = GLib.Object.GetObject(raw_ret) as Pango.Font;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_fontset_get_metrics(IntPtr raw);
		static d_pango_fontset_get_metrics pango_fontset_get_metrics = FuncLoader.LoadFunction<d_pango_fontset_get_metrics>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_fontset_get_metrics"));

		public Pango.FontMetrics Metrics { 
			get {
				IntPtr raw_ret = pango_fontset_get_metrics(Handle);
				Pango.FontMetrics ret = raw_ret == IntPtr.Zero ? null : (Pango.FontMetrics) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontMetrics), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_fontset_get_type();
		static d_pango_fontset_get_type pango_fontset_get_type = FuncLoader.LoadFunction<d_pango_fontset_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_fontset_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_fontset_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
