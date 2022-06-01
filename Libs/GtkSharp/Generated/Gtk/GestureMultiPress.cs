// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class GestureMultiPress : Gtk.GestureSingle {

		public GestureMultiPress (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_gesture_multi_press_new(IntPtr widget);
		static d_gtk_gesture_multi_press_new gtk_gesture_multi_press_new = FuncLoader.LoadFunction<d_gtk_gesture_multi_press_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gesture_multi_press_new"));

		public GestureMultiPress (Gtk.Widget widget) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GestureMultiPress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (widget != null) {
					names.Add ("widget");
					vals.Add (new GLib.Value (widget));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_gesture_multi_press_new(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[GLib.Signal("released")]
		public event Gtk.ReleasedHandler Released {
			add {
				this.AddSignalHandler ("released", value, typeof (Gtk.ReleasedArgs));
			}
			remove {
				this.RemoveSignalHandler ("released", value);
			}
		}

		[GLib.Signal("pressed")]
		public event Gtk.PressedHandler Pressed {
			add {
				this.AddSignalHandler ("pressed", value, typeof (Gtk.PressedArgs));
			}
			remove {
				this.RemoveSignalHandler ("pressed", value);
			}
		}

		[GLib.Signal("stopped")]
		public event System.EventHandler Stopped {
			add {
				this.AddSignalHandler ("stopped", value);
			}
			remove {
				this.RemoveSignalHandler ("stopped", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_gesture_multi_press_get_area(IntPtr raw, IntPtr rect);
		static d_gtk_gesture_multi_press_get_area gtk_gesture_multi_press_get_area = FuncLoader.LoadFunction<d_gtk_gesture_multi_press_get_area>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gesture_multi_press_get_area"));

		public bool GetArea(Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			bool raw_ret = gtk_gesture_multi_press_get_area(Handle, native_rect);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_rect);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_gesture_multi_press_get_type();
		static d_gtk_gesture_multi_press_get_type gtk_gesture_multi_press_get_type = FuncLoader.LoadFunction<d_gtk_gesture_multi_press_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gesture_multi_press_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gesture_multi_press_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gesture_multi_press_set_area(IntPtr raw, IntPtr rect);
		static d_gtk_gesture_multi_press_set_area gtk_gesture_multi_press_set_area = FuncLoader.LoadFunction<d_gtk_gesture_multi_press_set_area>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gesture_multi_press_set_area"));

		public void SetArea(Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			gtk_gesture_multi_press_set_area(Handle, native_rect);
			Marshal.FreeHGlobal (native_rect);
		}

#endregion
	}
}
