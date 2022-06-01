// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class LoadableIconAdapter : GLib.GInterfaceAdapter, GLib.ILoadableIcon {

		[StructLayout (LayoutKind.Sequential)]
		struct GLoadableIconIface {
			public LoadNativeDelegate Load;
			public LoadAsyncNativeDelegate LoadAsync;
			public LoadFinishNativeDelegate LoadFinish;
		}

		static GLoadableIconIface iface;

		static LoadableIconAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (LoadableIconAdapter));
			iface.Load = new LoadNativeDelegate (Load_cb);
			iface.LoadAsync = new LoadAsyncNativeDelegate (LoadAsync_cb);
			iface.LoadFinish = new LoadFinishNativeDelegate (LoadFinish_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LoadNativeDelegate (IntPtr inst, int size, IntPtr type, IntPtr cancellable, out IntPtr error);

		static IntPtr Load_cb (IntPtr inst, int size, IntPtr type, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				ILoadableIconImplementor __obj = GLib.Object.GetObject (inst, false) as ILoadableIconImplementor;
				GLib.InputStream __result;
				__result = __obj.Load (size, GLib.Marshaller.PtrToStringGFree(type), GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LoadAsyncNativeDelegate (IntPtr inst, int size, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void LoadAsync_cb (IntPtr inst, int size, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				ILoadableIconImplementor __obj = GLib.Object.GetObject (inst, false) as ILoadableIconImplementor;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.LoadAsync (size, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr LoadFinishNativeDelegate (IntPtr inst, IntPtr res, IntPtr type, out IntPtr error);

		static IntPtr LoadFinish_cb (IntPtr inst, IntPtr res, IntPtr type, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				ILoadableIconImplementor __obj = GLib.Object.GetObject (inst, false) as ILoadableIconImplementor;
				GLib.InputStream __result;
				__result = __obj.LoadFinish (GLib.AsyncResultAdapter.GetObject (res, false), GLib.Marshaller.PtrToStringGFree(type));
				return __result == null ? IntPtr.Zero : __result.Handle;
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
			GLoadableIconIface native_iface = (GLoadableIconIface) Marshal.PtrToStructure (ifaceptr, typeof (GLoadableIconIface));
			native_iface.Load = iface.Load;
			native_iface.LoadAsync = iface.LoadAsync;
			native_iface.LoadFinish = iface.LoadFinish;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public LoadableIconAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public LoadableIconAdapter (ILoadableIconImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public LoadableIconAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_loadable_icon_get_type();
		static d_g_loadable_icon_get_type g_loadable_icon_get_type = FuncLoader.LoadFunction<d_g_loadable_icon_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_loadable_icon_get_type"));

		private static GLib.GType _gtype = new GLib.GType (g_loadable_icon_get_type ());

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

		public static ILoadableIcon GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ILoadableIcon GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ILoadableIconImplementor)
				return new LoadableIconAdapter (obj as ILoadableIconImplementor);
			else if (obj as ILoadableIcon == null)
				return new LoadableIconAdapter (obj.Handle);
			else
				return obj as ILoadableIcon;
		}

		public ILoadableIconImplementor Implementor {
			get {
				return implementor as ILoadableIconImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_loadable_icon_load(IntPtr raw, int size, IntPtr type, IntPtr cancellable, out IntPtr error);
		static d_g_loadable_icon_load g_loadable_icon_load = FuncLoader.LoadFunction<d_g_loadable_icon_load>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_loadable_icon_load"));

		public GLib.InputStream Load(int size, string type, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_loadable_icon_load(Handle, size, GLib.Marshaller.StringToPtrGStrdup(type), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_loadable_icon_load_async(IntPtr raw, int size, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_loadable_icon_load_async g_loadable_icon_load_async = FuncLoader.LoadFunction<d_g_loadable_icon_load_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_loadable_icon_load_async"));

		public void LoadAsync(int size, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_loadable_icon_load_async(Handle, size, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_loadable_icon_load_finish(IntPtr raw, IntPtr res, IntPtr type, out IntPtr error);
		static d_g_loadable_icon_load_finish g_loadable_icon_load_finish = FuncLoader.LoadFunction<d_g_loadable_icon_load_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_loadable_icon_load_finish"));

		public GLib.InputStream LoadFinish(GLib.IAsyncResult res, string type) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_loadable_icon_load_finish(Handle, res == null ? IntPtr.Zero : ((res is GLib.Object) ? (res as GLib.Object).Handle : (res as GLib.AsyncResultAdapter).Handle), GLib.Marshaller.StringToPtrGStrdup(type), out error);
			GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
