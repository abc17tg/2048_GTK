// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate IntPtr TranslateFuncNative(IntPtr path, IntPtr func_data);

	internal class TranslateFuncInvoker {

		TranslateFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TranslateFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TranslateFuncInvoker (TranslateFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TranslateFuncInvoker (TranslateFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TranslateFuncInvoker (TranslateFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.TranslateFunc Handler {
			get {
				return new Gtk.TranslateFunc(InvokeNative);
			}
		}

		string InvokeNative (string path)
		{
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			string __result = GLib.Marshaller.PtrToStringGFree(native_cb (native_path, __data));
			GLib.Marshaller.Free (native_path);
			return __result;
		}
	}

	internal class TranslateFuncWrapper {

		public IntPtr NativeCallback (IntPtr path, IntPtr func_data)
		{
			try {
				string __ret = managed (GLib.Marshaller.Utf8PtrToString (path));
				if (release_on_call)
					gch.Free ();
				return GLib.Marshaller.StringToPtrGStrdup(__ret);
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

		internal TranslateFuncNative NativeDelegate;
		Gtk.TranslateFunc managed;

		public TranslateFuncWrapper (Gtk.TranslateFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TranslateFuncNative (NativeCallback);
		}

		public static Gtk.TranslateFunc GetManagedDelegate (TranslateFuncNative native)
		{
			if (native == null)
				return null;
			TranslateFuncWrapper wrapper = (TranslateFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
