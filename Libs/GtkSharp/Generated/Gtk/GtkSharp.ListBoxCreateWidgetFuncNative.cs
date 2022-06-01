// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate IntPtr ListBoxCreateWidgetFuncNative(IntPtr item, IntPtr user_data);

	internal class ListBoxCreateWidgetFuncInvoker {

		ListBoxCreateWidgetFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ListBoxCreateWidgetFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ListBoxCreateWidgetFuncInvoker (ListBoxCreateWidgetFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ListBoxCreateWidgetFuncInvoker (ListBoxCreateWidgetFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ListBoxCreateWidgetFuncInvoker (ListBoxCreateWidgetFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.ListBoxCreateWidgetFunc Handler {
			get {
				return new Gtk.ListBoxCreateWidgetFunc(InvokeNative);
			}
		}

		Gtk.Widget InvokeNative (IntPtr item)
		{
			Gtk.Widget __result = GLib.Object.GetObject(native_cb (item, __data)) as Gtk.Widget;
			return __result;
		}
	}

	internal class ListBoxCreateWidgetFuncWrapper {

		public IntPtr NativeCallback (IntPtr item, IntPtr user_data)
		{
			try {
				Gtk.Widget __ret = managed (item);
				if (release_on_call)
					gch.Free ();
				return __ret == null ? IntPtr.Zero : __ret.Handle;
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

		internal ListBoxCreateWidgetFuncNative NativeDelegate;
		Gtk.ListBoxCreateWidgetFunc managed;

		public ListBoxCreateWidgetFuncWrapper (Gtk.ListBoxCreateWidgetFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ListBoxCreateWidgetFuncNative (NativeCallback);
		}

		public static Gtk.ListBoxCreateWidgetFunc GetManagedDelegate (ListBoxCreateWidgetFuncNative native)
		{
			if (native == null)
				return null;
			ListBoxCreateWidgetFuncWrapper wrapper = (ListBoxCreateWidgetFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
