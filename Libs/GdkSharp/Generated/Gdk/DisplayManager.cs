// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class DisplayManager : GLib.Object {

		public DisplayManager (IntPtr raw) : base(raw) {}

		protected DisplayManager() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_display_manager_get_default_display(IntPtr raw);
		static d_gdk_display_manager_get_default_display gdk_display_manager_get_default_display = FuncLoader.LoadFunction<d_gdk_display_manager_get_default_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_display_manager_get_default_display"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_display_manager_set_default_display(IntPtr raw, IntPtr display);
		static d_gdk_display_manager_set_default_display gdk_display_manager_set_default_display = FuncLoader.LoadFunction<d_gdk_display_manager_set_default_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_display_manager_set_default_display"));

		[GLib.Property ("default-display")]
		public Gdk.Display DefaultDisplay {
			get  {
				IntPtr raw_ret = gdk_display_manager_get_default_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
			set  {
				gdk_display_manager_set_default_display(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Signal("display-opened")]
		public event Gdk.DisplayOpenedHandler DisplayOpened {
			add {
				this.AddSignalHandler ("display-opened", value, typeof (Gdk.DisplayOpenedArgs));
			}
			remove {
				this.RemoveSignalHandler ("display-opened", value);
			}
		}

		static DisplayOpenedNativeDelegate DisplayOpened_cb_delegate;
		static DisplayOpenedNativeDelegate DisplayOpenedVMCallback {
			get {
				if (DisplayOpened_cb_delegate == null)
					DisplayOpened_cb_delegate = new DisplayOpenedNativeDelegate (DisplayOpened_cb);
				return DisplayOpened_cb_delegate;
			}
		}

		static void OverrideDisplayOpened (GLib.GType gtype)
		{
			OverrideDisplayOpened (gtype, DisplayOpenedVMCallback);
		}

		static void OverrideDisplayOpened (GLib.GType gtype, DisplayOpenedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("display_opened"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DisplayOpenedNativeDelegate (IntPtr inst, IntPtr display);

		static void DisplayOpened_cb (IntPtr inst, IntPtr display)
		{
			try {
				DisplayManager __obj = GLib.Object.GetObject (inst, false) as DisplayManager;
				__obj.OnDisplayOpened (GLib.Object.GetObject(display) as Gdk.Display);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.DisplayManager), ConnectionMethod="OverrideDisplayOpened")]
		protected virtual void OnDisplayOpened (Gdk.Display display)
		{
			InternalDisplayOpened (display);
		}

		private void InternalDisplayOpened (Gdk.Display display)
		{
			DisplayOpenedNativeDelegate unmanaged = class_abi.BaseOverride<DisplayOpenedNativeDelegate>(this.LookupGType(), "display_opened");
			if (unmanaged == null) return;

			unmanaged (this.Handle, display == null ? IntPtr.Zero : display.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("display_opened"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // display_opened
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
		delegate IntPtr d_gdk_display_manager_get();
		static d_gdk_display_manager_get gdk_display_manager_get = FuncLoader.LoadFunction<d_gdk_display_manager_get>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_display_manager_get"));

		public static Gdk.DisplayManager Get() {
			IntPtr raw_ret = gdk_display_manager_get();
			Gdk.DisplayManager ret = GLib.Object.GetObject(raw_ret) as Gdk.DisplayManager;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_display_manager_get_type();
		static d_gdk_display_manager_get_type gdk_display_manager_get_type = FuncLoader.LoadFunction<d_gdk_display_manager_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_display_manager_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_display_manager_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_display_manager_open_display(IntPtr raw, IntPtr name);
		static d_gdk_display_manager_open_display gdk_display_manager_open_display = FuncLoader.LoadFunction<d_gdk_display_manager_open_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_display_manager_open_display"));

		public Gdk.Display OpenDisplay(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gdk_display_manager_open_display(Handle, native_name);
			Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
			GLib.Marshaller.Free (native_name);
			return ret;
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
