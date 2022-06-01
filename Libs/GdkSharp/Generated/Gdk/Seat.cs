// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Seat : GLib.Object {

		public Seat (IntPtr raw) : base(raw) {}

		protected Seat() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static DeviceAddedNativeDelegate DeviceAdded_cb_delegate;
		static DeviceAddedNativeDelegate DeviceAddedVMCallback {
			get {
				if (DeviceAdded_cb_delegate == null)
					DeviceAdded_cb_delegate = new DeviceAddedNativeDelegate (DeviceAdded_cb);
				return DeviceAdded_cb_delegate;
			}
		}

		static void OverrideDeviceAdded (GLib.GType gtype)
		{
			OverrideDeviceAdded (gtype, DeviceAddedVMCallback);
		}

		static void OverrideDeviceAdded (GLib.GType gtype, DeviceAddedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("device_added"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeviceAddedNativeDelegate (IntPtr inst, IntPtr device);

		static void DeviceAdded_cb (IntPtr inst, IntPtr device)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnDeviceAdded (GLib.Object.GetObject(device) as Gdk.Device);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideDeviceAdded")]
		protected virtual void OnDeviceAdded (Gdk.Device device)
		{
			InternalDeviceAdded (device);
		}

		private void InternalDeviceAdded (Gdk.Device device)
		{
			DeviceAddedNativeDelegate unmanaged = class_abi.BaseOverride<DeviceAddedNativeDelegate>(this.LookupGType(), "device_added");
			if (unmanaged == null) return;

			unmanaged (this.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		static DeviceRemovedNativeDelegate DeviceRemoved_cb_delegate;
		static DeviceRemovedNativeDelegate DeviceRemovedVMCallback {
			get {
				if (DeviceRemoved_cb_delegate == null)
					DeviceRemoved_cb_delegate = new DeviceRemovedNativeDelegate (DeviceRemoved_cb);
				return DeviceRemoved_cb_delegate;
			}
		}

		static void OverrideDeviceRemoved (GLib.GType gtype)
		{
			OverrideDeviceRemoved (gtype, DeviceRemovedVMCallback);
		}

		static void OverrideDeviceRemoved (GLib.GType gtype, DeviceRemovedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("device_removed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeviceRemovedNativeDelegate (IntPtr inst, IntPtr device);

		static void DeviceRemoved_cb (IntPtr inst, IntPtr device)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnDeviceRemoved (GLib.Object.GetObject(device) as Gdk.Device);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideDeviceRemoved")]
		protected virtual void OnDeviceRemoved (Gdk.Device device)
		{
			InternalDeviceRemoved (device);
		}

		private void InternalDeviceRemoved (Gdk.Device device)
		{
			DeviceRemovedNativeDelegate unmanaged = class_abi.BaseOverride<DeviceRemovedNativeDelegate>(this.LookupGType(), "device_removed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		static DeviceChangedNativeDelegate DeviceChanged_cb_delegate;
		static DeviceChangedNativeDelegate DeviceChangedVMCallback {
			get {
				if (DeviceChanged_cb_delegate == null)
					DeviceChanged_cb_delegate = new DeviceChangedNativeDelegate (DeviceChanged_cb);
				return DeviceChanged_cb_delegate;
			}
		}

		static void OverrideDeviceChanged (GLib.GType gtype)
		{
			OverrideDeviceChanged (gtype, DeviceChangedVMCallback);
		}

		static void OverrideDeviceChanged (GLib.GType gtype, DeviceChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("device_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeviceChangedNativeDelegate (IntPtr inst, IntPtr device);

		static void DeviceChanged_cb (IntPtr inst, IntPtr device)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnDeviceChanged (GLib.Object.GetObject(device) as Gdk.Device);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideDeviceChanged")]
		protected virtual void OnDeviceChanged (Gdk.Device device)
		{
			InternalDeviceChanged (device);
		}

		private void InternalDeviceChanged (Gdk.Device device)
		{
			DeviceChangedNativeDelegate unmanaged = class_abi.BaseOverride<DeviceChangedNativeDelegate>(this.LookupGType(), "device_changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		static GetCapabilitiesNativeDelegate GetCapabilities_cb_delegate;
		static GetCapabilitiesNativeDelegate GetCapabilitiesVMCallback {
			get {
				if (GetCapabilities_cb_delegate == null)
					GetCapabilities_cb_delegate = new GetCapabilitiesNativeDelegate (GetCapabilities_cb);
				return GetCapabilities_cb_delegate;
			}
		}

		static void OverrideGetCapabilities (GLib.GType gtype)
		{
			OverrideGetCapabilities (gtype, GetCapabilitiesVMCallback);
		}

		static void OverrideGetCapabilities (GLib.GType gtype, GetCapabilitiesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_capabilities"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetCapabilitiesNativeDelegate (IntPtr inst);

		static int GetCapabilities_cb (IntPtr inst)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.SeatCapabilities __result;
				__result = __obj.OnGetCapabilities ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetCapabilities")]
		protected virtual Gdk.SeatCapabilities OnGetCapabilities ()
		{
			return InternalGetCapabilities ();
		}

		private Gdk.SeatCapabilities InternalGetCapabilities ()
		{
			GetCapabilitiesNativeDelegate unmanaged = class_abi.BaseOverride<GetCapabilitiesNativeDelegate>(this.LookupGType(), "get_capabilities");
			if (unmanaged == null) return (Gdk.SeatCapabilities) 0;

			int __result = unmanaged (this.Handle);
			return (Gdk.SeatCapabilities) __result;
		}

		static GrabNativeDelegate Grab_cb_delegate;
		static GrabNativeDelegate GrabVMCallback {
			get {
				if (Grab_cb_delegate == null)
					Grab_cb_delegate = new GrabNativeDelegate (Grab_cb);
				return Grab_cb_delegate;
			}
		}

		static void OverrideGrab (GLib.GType gtype)
		{
			OverrideGrab (gtype, GrabVMCallback);
		}

		static void OverrideGrab (GLib.GType gtype, GrabNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("grab"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GrabNativeDelegate (IntPtr inst, IntPtr window, int capabilities, bool owner_events, IntPtr cursor, IntPtr evnt, GdkSharp.SeatGrabPrepareFuncNative prepare_func, IntPtr prepare_func_data);

		static int Grab_cb (IntPtr inst, IntPtr window, int capabilities, bool owner_events, IntPtr cursor, IntPtr evnt, GdkSharp.SeatGrabPrepareFuncNative prepare_func, IntPtr prepare_func_data)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.GrabStatus __result;
				GdkSharp.SeatGrabPrepareFuncInvoker prepare_func_invoker = new GdkSharp.SeatGrabPrepareFuncInvoker (prepare_func, prepare_func_data);
				__result = __obj.OnGrab (GLib.Object.GetObject(window) as Gdk.Window, (Gdk.SeatCapabilities) capabilities, owner_events, GLib.Object.GetObject(cursor) as Gdk.Cursor, Gdk.Event.GetEvent (evnt), prepare_func_invoker.Handler);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGrab")]
		protected virtual Gdk.GrabStatus OnGrab (Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, Gdk.Event evnt, Gdk.SeatGrabPrepareFunc prepare_func)
		{
			return InternalGrab (window, capabilities, owner_events, cursor, evnt, prepare_func);
		}

		private Gdk.GrabStatus InternalGrab (Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, Gdk.Event evnt, Gdk.SeatGrabPrepareFunc prepare_func)
		{
			GrabNativeDelegate unmanaged = class_abi.BaseOverride<GrabNativeDelegate>(this.LookupGType(), "grab");
			if (unmanaged == null) return (Gdk.GrabStatus) 0;

			GdkSharp.SeatGrabPrepareFuncWrapper prepare_func_wrapper = new GdkSharp.SeatGrabPrepareFuncWrapper (prepare_func);
			int __result = unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, (int) capabilities, owner_events, cursor == null ? IntPtr.Zero : cursor.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, prepare_func_wrapper.NativeDelegate, IntPtr.Zero);
			return (Gdk.GrabStatus) __result;
		}

		static UngrabNativeDelegate Ungrab_cb_delegate;
		static UngrabNativeDelegate UngrabVMCallback {
			get {
				if (Ungrab_cb_delegate == null)
					Ungrab_cb_delegate = new UngrabNativeDelegate (Ungrab_cb);
				return Ungrab_cb_delegate;
			}
		}

		static void OverrideUngrab (GLib.GType gtype)
		{
			OverrideUngrab (gtype, UngrabVMCallback);
		}

		static void OverrideUngrab (GLib.GType gtype, UngrabNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("ungrab"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UngrabNativeDelegate (IntPtr inst);

		static void Ungrab_cb (IntPtr inst)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnUngrab ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideUngrab")]
		protected virtual void OnUngrab ()
		{
			InternalUngrab ();
		}

		private void InternalUngrab ()
		{
			UngrabNativeDelegate unmanaged = class_abi.BaseOverride<UngrabNativeDelegate>(this.LookupGType(), "ungrab");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static GetMasterNativeDelegate GetMaster_cb_delegate;
		static GetMasterNativeDelegate GetMasterVMCallback {
			get {
				if (GetMaster_cb_delegate == null)
					GetMaster_cb_delegate = new GetMasterNativeDelegate (GetMaster_cb);
				return GetMaster_cb_delegate;
			}
		}

		static void OverrideGetMaster (GLib.GType gtype)
		{
			OverrideGetMaster (gtype, GetMasterVMCallback);
		}

		static void OverrideGetMaster (GLib.GType gtype, GetMasterNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_master"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetMasterNativeDelegate (IntPtr inst, int capability);

		static IntPtr GetMaster_cb (IntPtr inst, int capability)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.Device __result;
				__result = __obj.OnGetMaster ((Gdk.SeatCapabilities) capability);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetMaster")]
		protected virtual Gdk.Device OnGetMaster (Gdk.SeatCapabilities capability)
		{
			return InternalGetMaster (capability);
		}

		private Gdk.Device InternalGetMaster (Gdk.SeatCapabilities capability)
		{
			GetMasterNativeDelegate unmanaged = class_abi.BaseOverride<GetMasterNativeDelegate>(this.LookupGType(), "get_master");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, (int) capability);
			return GLib.Object.GetObject(__result) as Gdk.Device;
		}

		static GetSlavesNativeDelegate GetSlaves_cb_delegate;
		static GetSlavesNativeDelegate GetSlavesVMCallback {
			get {
				if (GetSlaves_cb_delegate == null)
					GetSlaves_cb_delegate = new GetSlavesNativeDelegate (GetSlaves_cb);
				return GetSlaves_cb_delegate;
			}
		}

		static void OverrideGetSlaves (GLib.GType gtype)
		{
			OverrideGetSlaves (gtype, GetSlavesVMCallback);
		}

		static void OverrideGetSlaves (GLib.GType gtype, GetSlavesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_slaves"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetSlavesNativeDelegate (IntPtr inst, int capabilities);

		static IntPtr GetSlaves_cb (IntPtr inst, int capabilities)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.Device[] __result;
				__result = __obj.OnGetSlaves ((Gdk.SeatCapabilities) capabilities);
				return new GLib.List(__result, typeof (Gdk.Device), true, false) == null ? IntPtr.Zero : new GLib.List(__result, typeof (Gdk.Device), true, false).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetSlaves")]
		protected virtual Gdk.Device[] OnGetSlaves (Gdk.SeatCapabilities capabilities)
		{
			return InternalGetSlaves (capabilities);
		}

		private Gdk.Device[] InternalGetSlaves (Gdk.SeatCapabilities capabilities)
		{
			GetSlavesNativeDelegate unmanaged = class_abi.BaseOverride<GetSlavesNativeDelegate>(this.LookupGType(), "get_slaves");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, (int) capabilities);
			return GLib.Marshaller.ListPtrToArray<Gdk.Device, Gdk.Device> (__result, true, false);
		}

		static GetToolNativeDelegate GetTool_cb_delegate;
		static GetToolNativeDelegate GetToolVMCallback {
			get {
				if (GetTool_cb_delegate == null)
					GetTool_cb_delegate = new GetToolNativeDelegate (GetTool_cb);
				return GetTool_cb_delegate;
			}
		}

		static void OverrideGetTool (GLib.GType gtype)
		{
			OverrideGetTool (gtype, GetToolVMCallback);
		}

		static void OverrideGetTool (GLib.GType gtype, GetToolNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_tool"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetToolNativeDelegate (IntPtr inst, ulong serial);

		static IntPtr GetTool_cb (IntPtr inst, ulong serial)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.DeviceTool __result;
				__result = __obj.OnGetTool (serial);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetTool")]
		protected virtual Gdk.DeviceTool OnGetTool (ulong serial)
		{
			return InternalGetTool (serial);
		}

		private Gdk.DeviceTool InternalGetTool (ulong serial)
		{
			GetToolNativeDelegate unmanaged = class_abi.BaseOverride<GetToolNativeDelegate>(this.LookupGType(), "get_tool");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, serial);
			return GLib.Object.GetObject(__result) as Gdk.DeviceTool;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("device_added"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // device_added
							, null
							, "device_removed"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("device_removed"
							, -1
							, (uint) sizeof( IntPtr ) // device_removed
							, "device_added"
							, "device_changed"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("device_changed"
							, -1
							, (uint) sizeof( IntPtr ) // device_changed
							, "device_removed"
							, "get_capabilities"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_capabilities"
							, -1
							, (uint) sizeof( IntPtr ) // get_capabilities
							, "device_changed"
							, "grab"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("grab"
							, -1
							, (uint) sizeof( IntPtr ) // grab
							, "get_capabilities"
							, "ungrab"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("ungrab"
							, -1
							, (uint) sizeof( IntPtr ) // ungrab
							, "grab"
							, "get_master"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_master"
							, -1
							, (uint) sizeof( IntPtr ) // get_master
							, "ungrab"
							, "get_slaves"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_slaves"
							, -1
							, (uint) sizeof( IntPtr ) // get_slaves
							, "get_master"
							, "get_tool"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("get_tool"
							, -1
							, (uint) sizeof( IntPtr ) // get_tool
							, "get_slaves"
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
		delegate int d_gdk_seat_get_capabilities(IntPtr raw);
		static d_gdk_seat_get_capabilities gdk_seat_get_capabilities = FuncLoader.LoadFunction<d_gdk_seat_get_capabilities>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_get_capabilities"));

		public Gdk.SeatCapabilities Capabilities { 
			get {
				int raw_ret = gdk_seat_get_capabilities(Handle);
				Gdk.SeatCapabilities ret = (Gdk.SeatCapabilities) raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_seat_get_display(IntPtr raw);
		static d_gdk_seat_get_display gdk_seat_get_display = FuncLoader.LoadFunction<d_gdk_seat_get_display>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_get_display"));

		public Gdk.Display Display { 
			get {
				IntPtr raw_ret = gdk_seat_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_seat_get_keyboard(IntPtr raw);
		static d_gdk_seat_get_keyboard gdk_seat_get_keyboard = FuncLoader.LoadFunction<d_gdk_seat_get_keyboard>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_get_keyboard"));

		public Gdk.Device Keyboard { 
			get {
				IntPtr raw_ret = gdk_seat_get_keyboard(Handle);
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_seat_get_pointer(IntPtr raw);
		static d_gdk_seat_get_pointer gdk_seat_get_pointer = FuncLoader.LoadFunction<d_gdk_seat_get_pointer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_get_pointer"));

		public Gdk.Device Pointer { 
			get {
				IntPtr raw_ret = gdk_seat_get_pointer(Handle);
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_seat_get_slaves(IntPtr raw, int capabilities);
		static d_gdk_seat_get_slaves gdk_seat_get_slaves = FuncLoader.LoadFunction<d_gdk_seat_get_slaves>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_get_slaves"));

		public Gdk.Device[] GetSlaves(Gdk.SeatCapabilities capabilities) {
			IntPtr raw_ret = gdk_seat_get_slaves(Handle, (int) capabilities);
			Gdk.Device[] ret = GLib.Marshaller.ListPtrToArray<Gdk.Device, Gdk.Device> (raw_ret, true, false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_seat_get_type();
		static d_gdk_seat_get_type gdk_seat_get_type = FuncLoader.LoadFunction<d_gdk_seat_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_seat_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gdk_seat_grab(IntPtr raw, IntPtr window, int capabilities, bool owner_events, IntPtr cursor, IntPtr evnt, GdkSharp.SeatGrabPrepareFuncNative prepare_func, IntPtr prepare_func_data);
		static d_gdk_seat_grab gdk_seat_grab = FuncLoader.LoadFunction<d_gdk_seat_grab>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_grab"));

		public Gdk.GrabStatus Grab(Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, Gdk.Event evnt, Gdk.SeatGrabPrepareFunc prepare_func) {
			GdkSharp.SeatGrabPrepareFuncWrapper prepare_func_wrapper = new GdkSharp.SeatGrabPrepareFuncWrapper (prepare_func);
			int raw_ret = gdk_seat_grab(Handle, window == null ? IntPtr.Zero : window.Handle, (int) capabilities, owner_events, cursor == null ? IntPtr.Zero : cursor.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, prepare_func_wrapper.NativeDelegate, IntPtr.Zero);
			Gdk.GrabStatus ret = (Gdk.GrabStatus) raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_seat_ungrab(IntPtr raw);
		static d_gdk_seat_ungrab gdk_seat_ungrab = FuncLoader.LoadFunction<d_gdk_seat_ungrab>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_seat_ungrab"));

		public void Ungrab() {
			gdk_seat_ungrab(Handle);
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
