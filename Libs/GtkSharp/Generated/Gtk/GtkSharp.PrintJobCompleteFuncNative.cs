// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	internal delegate void PrintJobCompleteFuncNative(IntPtr print_job, IntPtr user_data, IntPtr error);

	internal class PrintJobCompleteFuncInvoker {

		PrintJobCompleteFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~PrintJobCompleteFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal PrintJobCompleteFuncInvoker (PrintJobCompleteFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal PrintJobCompleteFuncInvoker (PrintJobCompleteFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal PrintJobCompleteFuncInvoker (PrintJobCompleteFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.PrintJobCompleteFunc Handler {
			get {
				return new Gtk.PrintJobCompleteFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.PrintJob print_job, IntPtr user_data, IntPtr error)
		{
			native_cb (print_job == null ? IntPtr.Zero : print_job.Handle, __data, error);
		}
	}

	internal class PrintJobCompleteFuncWrapper {

		public void NativeCallback (IntPtr print_job, IntPtr user_data, IntPtr error)
		{
			try {
				managed (GLib.Object.GetObject(print_job) as Gtk.PrintJob, user_data, error);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal PrintJobCompleteFuncNative NativeDelegate;
		Gtk.PrintJobCompleteFunc managed;

		public PrintJobCompleteFuncWrapper (Gtk.PrintJobCompleteFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new PrintJobCompleteFuncNative (NativeCallback);
		}

		public static Gtk.PrintJobCompleteFunc GetManagedDelegate (PrintJobCompleteFuncNative native)
		{
			if (native == null)
				return null;
			PrintJobCompleteFuncWrapper wrapper = (PrintJobCompleteFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
