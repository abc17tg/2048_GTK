// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate IntPtr VfsFileLookupFuncNative(IntPtr vfs, IntPtr identifier, IntPtr user_data);

	internal class VfsFileLookupFuncInvoker {

		VfsFileLookupFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~VfsFileLookupFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal VfsFileLookupFuncInvoker (VfsFileLookupFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal VfsFileLookupFuncInvoker (VfsFileLookupFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal VfsFileLookupFuncInvoker (VfsFileLookupFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.VfsFileLookupFunc Handler {
			get {
				return new GLib.VfsFileLookupFunc(InvokeNative);
			}
		}

		GLib.IFile InvokeNative (GLib.Vfs vfs, string identifier)
		{
			IntPtr native_identifier = GLib.Marshaller.StringToPtrGStrdup (identifier);
			GLib.IFile __result = GLib.FileAdapter.GetObject (native_cb (vfs == null ? IntPtr.Zero : vfs.Handle, native_identifier, __data), false);
			GLib.Marshaller.Free (native_identifier);
			return __result;
		}
	}

	internal class VfsFileLookupFuncWrapper {

		public IntPtr NativeCallback (IntPtr vfs, IntPtr identifier, IntPtr user_data)
		{
			try {
				GLib.IFile __ret = managed (GLib.Object.GetObject(vfs) as GLib.Vfs, GLib.Marshaller.Utf8PtrToString (identifier));
				if (release_on_call)
					gch.Free ();
				return __ret == null ? IntPtr.Zero : ((__ret is GLib.Object) ? (__ret as GLib.Object).Handle : (__ret as GLib.FileAdapter).Handle);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal VfsFileLookupFuncNative NativeDelegate;
		GLib.VfsFileLookupFunc managed;

		public VfsFileLookupFuncWrapper (GLib.VfsFileLookupFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new VfsFileLookupFuncNative (NativeCallback);
		}

		public static GLib.VfsFileLookupFunc GetManagedDelegate (VfsFileLookupFuncNative native)
		{
			if (native == null)
				return null;
			VfsFileLookupFuncWrapper wrapper = (VfsFileLookupFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}