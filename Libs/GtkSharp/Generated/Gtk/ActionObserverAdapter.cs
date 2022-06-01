// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActionObserverAdapter : GLib.GInterfaceAdapter, Gtk.IActionObserver {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkActionObserverInterface {
			public ActionAddedNativeDelegate ActionAdded;
			public ActionEnabledChangedNativeDelegate ActionEnabledChanged;
			public ActionStateChangedNativeDelegate ActionStateChanged;
			public ActionRemovedNativeDelegate ActionRemoved;
			public PrimaryAccelChangedNativeDelegate PrimaryAccelChanged;
		}

		static GtkActionObserverInterface iface;

		static ActionObserverAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ActionObserverAdapter));
			iface.ActionAdded = new ActionAddedNativeDelegate (ActionAdded_cb);
			iface.ActionEnabledChanged = new ActionEnabledChangedNativeDelegate (ActionEnabledChanged_cb);
			iface.ActionStateChanged = new ActionStateChangedNativeDelegate (ActionStateChanged_cb);
			iface.ActionRemoved = new ActionRemovedNativeDelegate (ActionRemoved_cb);
			iface.PrimaryAccelChanged = new PrimaryAccelChangedNativeDelegate (PrimaryAccelChanged_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionAddedNativeDelegate (IntPtr inst, IntPtr observable, IntPtr action_name, IntPtr parameter_type, bool enabled, IntPtr state);

		static void ActionAdded_cb (IntPtr inst, IntPtr observable, IntPtr action_name, IntPtr parameter_type, bool enabled, IntPtr state)
		{
			try {
				IActionObserverImplementor __obj = GLib.Object.GetObject (inst, false) as IActionObserverImplementor;
				__obj.ActionAdded (Gtk.ActionObservableAdapter.GetObject (observable, false), GLib.Marshaller.Utf8PtrToString (action_name), new GLib.VariantType(parameter_type), enabled, new GLib.Variant(state));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionEnabledChangedNativeDelegate (IntPtr inst, IntPtr observable, IntPtr action_name, bool enabled);

		static void ActionEnabledChanged_cb (IntPtr inst, IntPtr observable, IntPtr action_name, bool enabled)
		{
			try {
				IActionObserverImplementor __obj = GLib.Object.GetObject (inst, false) as IActionObserverImplementor;
				__obj.ActionEnabledChanged (Gtk.ActionObservableAdapter.GetObject (observable, false), GLib.Marshaller.Utf8PtrToString (action_name), enabled);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionStateChangedNativeDelegate (IntPtr inst, IntPtr observable, IntPtr action_name, IntPtr state);

		static void ActionStateChanged_cb (IntPtr inst, IntPtr observable, IntPtr action_name, IntPtr state)
		{
			try {
				IActionObserverImplementor __obj = GLib.Object.GetObject (inst, false) as IActionObserverImplementor;
				__obj.ActionStateChanged (Gtk.ActionObservableAdapter.GetObject (observable, false), GLib.Marshaller.Utf8PtrToString (action_name), new GLib.Variant(state));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionRemovedNativeDelegate (IntPtr inst, IntPtr observable, IntPtr action_name);

		static void ActionRemoved_cb (IntPtr inst, IntPtr observable, IntPtr action_name)
		{
			try {
				IActionObserverImplementor __obj = GLib.Object.GetObject (inst, false) as IActionObserverImplementor;
				__obj.ActionRemoved (Gtk.ActionObservableAdapter.GetObject (observable, false), GLib.Marshaller.Utf8PtrToString (action_name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrimaryAccelChangedNativeDelegate (IntPtr inst, IntPtr observable, IntPtr action_name, IntPtr action_and_target);

		static void PrimaryAccelChanged_cb (IntPtr inst, IntPtr observable, IntPtr action_name, IntPtr action_and_target)
		{
			try {
				IActionObserverImplementor __obj = GLib.Object.GetObject (inst, false) as IActionObserverImplementor;
				__obj.PrimaryAccelChanged (Gtk.ActionObservableAdapter.GetObject (observable, false), GLib.Marshaller.Utf8PtrToString (action_name), GLib.Marshaller.Utf8PtrToString (action_and_target));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkActionObserverInterface native_iface = (GtkActionObserverInterface) Marshal.PtrToStructure (ifaceptr, typeof (GtkActionObserverInterface));
			native_iface.ActionAdded = iface.ActionAdded;
			native_iface.ActionEnabledChanged = iface.ActionEnabledChanged;
			native_iface.ActionStateChanged = iface.ActionStateChanged;
			native_iface.ActionRemoved = iface.ActionRemoved;
			native_iface.PrimaryAccelChanged = iface.PrimaryAccelChanged;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ActionObserverAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ActionObserverAdapter (IActionObserverImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ActionObserverAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_action_observer_get_type();
		static d_gtk_action_observer_get_type gtk_action_observer_get_type = FuncLoader.LoadFunction<d_gtk_action_observer_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_observer_get_type"));

		private static GLib.GType _gtype = new GLib.GType (gtk_action_observer_get_type ());

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

		public static IActionObserver GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IActionObserver GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IActionObserverImplementor)
				return new ActionObserverAdapter (obj as IActionObserverImplementor);
			else if (obj as IActionObserver == null)
				return new ActionObserverAdapter (obj.Handle);
			else
				return obj as IActionObserver;
		}

		public IActionObserverImplementor Implementor {
			get {
				return implementor as IActionObserverImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_observer_action_added(IntPtr raw, IntPtr observable, IntPtr action_name, IntPtr parameter_type, bool enabled, IntPtr state);
		static d_gtk_action_observer_action_added gtk_action_observer_action_added = FuncLoader.LoadFunction<d_gtk_action_observer_action_added>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_observer_action_added"));

		public void ActionAdded(Gtk.IActionObservable observable, string action_name, GLib.VariantType parameter_type, bool enabled, GLib.Variant state) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_added(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, parameter_type == null ? IntPtr.Zero : parameter_type.Handle, enabled, state == null ? IntPtr.Zero : state.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_observer_action_enabled_changed(IntPtr raw, IntPtr observable, IntPtr action_name, bool enabled);
		static d_gtk_action_observer_action_enabled_changed gtk_action_observer_action_enabled_changed = FuncLoader.LoadFunction<d_gtk_action_observer_action_enabled_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_observer_action_enabled_changed"));

		public void ActionEnabledChanged(Gtk.IActionObservable observable, string action_name, bool enabled) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_enabled_changed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, enabled);
			GLib.Marshaller.Free (native_action_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_observer_action_removed(IntPtr raw, IntPtr observable, IntPtr action_name);
		static d_gtk_action_observer_action_removed gtk_action_observer_action_removed = FuncLoader.LoadFunction<d_gtk_action_observer_action_removed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_observer_action_removed"));

		public void ActionRemoved(Gtk.IActionObservable observable, string action_name) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_removed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name);
			GLib.Marshaller.Free (native_action_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_observer_action_state_changed(IntPtr raw, IntPtr observable, IntPtr action_name, IntPtr state);
		static d_gtk_action_observer_action_state_changed gtk_action_observer_action_state_changed = FuncLoader.LoadFunction<d_gtk_action_observer_action_state_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_observer_action_state_changed"));

		public void ActionStateChanged(Gtk.IActionObservable observable, string action_name, GLib.Variant state) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_action_observer_action_state_changed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, state == null ? IntPtr.Zero : state.Handle);
			GLib.Marshaller.Free (native_action_name);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_action_observer_primary_accel_changed(IntPtr raw, IntPtr observable, IntPtr action_name, IntPtr action_and_target);
		static d_gtk_action_observer_primary_accel_changed gtk_action_observer_primary_accel_changed = FuncLoader.LoadFunction<d_gtk_action_observer_primary_accel_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_action_observer_primary_accel_changed"));

		public void PrimaryAccelChanged(Gtk.IActionObservable observable, string action_name, string action_and_target) {
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			IntPtr native_action_and_target = GLib.Marshaller.StringToPtrGStrdup (action_and_target);
			gtk_action_observer_primary_accel_changed(Handle, observable == null ? IntPtr.Zero : ((observable is GLib.Object) ? (observable as GLib.Object).Handle : (observable as Gtk.ActionObservableAdapter).Handle), native_action_name, native_action_and_target);
			GLib.Marshaller.Free (native_action_name);
			GLib.Marshaller.Free (native_action_and_target);
		}

#endregion
	}
}
