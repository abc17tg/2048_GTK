// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AsyncResultAdapter : GLib.GInterfaceAdapter, GLib.IAsyncResult {

		[StructLayout (LayoutKind.Sequential)]
		struct GAsyncResultIface {
			public GetUserDataNativeDelegate GetUserData;
			public GetSourceObjectNativeDelegate GetSourceObject;
			public IsTaggedNativeDelegate IsTagged;
		}

		static GAsyncResultIface iface;

		static AsyncResultAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (AsyncResultAdapter));
			iface.GetUserData = new GetUserDataNativeDelegate (GetUserData_cb);
			iface.GetSourceObject = new GetSourceObjectNativeDelegate (GetSourceObject_cb);
			iface.IsTagged = new IsTaggedNativeDelegate (IsTagged_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetUserDataNativeDelegate (IntPtr inst);

		static IntPtr GetUserData_cb (IntPtr inst)
		{
			try {
				IAsyncResultImplementor __obj = GLib.Object.GetObject (inst, false) as IAsyncResultImplementor;
				IntPtr __result;
				__result = __obj.UserData;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetSourceObjectNativeDelegate (IntPtr inst);

		static IntPtr GetSourceObject_cb (IntPtr inst)
		{
			try {
				IAsyncResultImplementor __obj = GLib.Object.GetObject (inst, false) as IAsyncResultImplementor;
				GLib.Object __result;
				__result = __obj.SourceObject;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsTaggedNativeDelegate (IntPtr inst, IntPtr source_tag);

		static bool IsTagged_cb (IntPtr inst, IntPtr source_tag)
		{
			try {
				IAsyncResultImplementor __obj = GLib.Object.GetObject (inst, false) as IAsyncResultImplementor;
				bool __result;
				__result = __obj.IsTagged (source_tag);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GAsyncResultIface native_iface = (GAsyncResultIface) Marshal.PtrToStructure (ifaceptr, typeof (GAsyncResultIface));
			native_iface.GetUserData = iface.GetUserData;
			native_iface.GetSourceObject = iface.GetSourceObject;
			native_iface.IsTagged = iface.IsTagged;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public AsyncResultAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public AsyncResultAdapter (IAsyncResultImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public AsyncResultAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_async_result_get_type();
		static d_g_async_result_get_type g_async_result_get_type = FuncLoader.LoadFunction<d_g_async_result_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_get_type"));

		private static GLib.GType _gtype = new GLib.GType (g_async_result_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IAsyncResult GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IAsyncResult GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IAsyncResultImplementor)
				return new AsyncResultAdapter (obj as IAsyncResultImplementor);
			else if (obj as IAsyncResult == null)
				return new AsyncResultAdapter (obj.Handle);
			else
				return obj as IAsyncResult;
		}

		public IAsyncResultImplementor Implementor {
			get {
				return implementor as IAsyncResultImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_async_result_get_source_object(IntPtr raw);
		static d_g_async_result_get_source_object g_async_result_get_source_object = FuncLoader.LoadFunction<d_g_async_result_get_source_object>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_get_source_object"));

		public GLib.Object SourceObject { 
			get {
				IntPtr raw_ret = g_async_result_get_source_object(Handle);
				GLib.Object ret = GLib.Object.GetObject (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_async_result_get_user_data(IntPtr raw);
		static d_g_async_result_get_user_data g_async_result_get_user_data = FuncLoader.LoadFunction<d_g_async_result_get_user_data>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_get_user_data"));

		public IntPtr UserData { 
			get {
				IntPtr raw_ret = g_async_result_get_user_data(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_async_result_is_tagged(IntPtr raw, IntPtr source_tag);
		static d_g_async_result_is_tagged g_async_result_is_tagged = FuncLoader.LoadFunction<d_g_async_result_is_tagged>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_is_tagged"));

		public bool IsTagged(IntPtr source_tag) {
			bool raw_ret = g_async_result_is_tagged(Handle, source_tag);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_async_result_legacy_propagate_error(IntPtr raw, out IntPtr error);
		static d_g_async_result_legacy_propagate_error g_async_result_legacy_propagate_error = FuncLoader.LoadFunction<d_g_async_result_legacy_propagate_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_async_result_legacy_propagate_error"));

		public bool LegacyPropagateError() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_async_result_legacy_propagate_error(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
