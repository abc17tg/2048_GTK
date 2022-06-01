// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class UndoManagerAdapter : GLib.GInterfaceAdapter, GtkSource.IUndoManager {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkSourceUndoManagerIface {
			public CanUndoNativeDelegate CanUndo;
			public CanRedoNativeDelegate CanRedo;
			public UndoNativeDelegate Undo;
			public RedoNativeDelegate Redo;
			public BeginNotUndoableActionNativeDelegate BeginNotUndoableAction;
			public EndNotUndoableActionNativeDelegate EndNotUndoableAction;
			IntPtr EmitCanUndoChanged;
			IntPtr EmitCanRedoChanged;
		}

		static GtkSourceUndoManagerIface iface;

		static UndoManagerAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (UndoManagerAdapter));
			iface.CanUndo = new CanUndoNativeDelegate (CanUndo_cb);
			iface.CanRedo = new CanRedoNativeDelegate (CanRedo_cb);
			iface.Undo = new UndoNativeDelegate (Undo_cb);
			iface.Redo = new RedoNativeDelegate (Redo_cb);
			iface.BeginNotUndoableAction = new BeginNotUndoableActionNativeDelegate (BeginNotUndoableAction_cb);
			iface.EndNotUndoableAction = new EndNotUndoableActionNativeDelegate (EndNotUndoableAction_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CanUndoNativeDelegate (IntPtr inst);

		static bool CanUndo_cb (IntPtr inst)
		{
			try {
				IUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as IUndoManagerImplementor;
				bool __result;
				__result = __obj.CanUndo ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CanRedoNativeDelegate (IntPtr inst);

		static bool CanRedo_cb (IntPtr inst)
		{
			try {
				IUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as IUndoManagerImplementor;
				bool __result;
				__result = __obj.CanRedo ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UndoNativeDelegate (IntPtr inst);

		static void Undo_cb (IntPtr inst)
		{
			try {
				IUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as IUndoManagerImplementor;
				__obj.Undo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RedoNativeDelegate (IntPtr inst);

		static void Redo_cb (IntPtr inst)
		{
			try {
				IUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as IUndoManagerImplementor;
				__obj.Redo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void BeginNotUndoableActionNativeDelegate (IntPtr inst);

		static void BeginNotUndoableAction_cb (IntPtr inst)
		{
			try {
				IUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as IUndoManagerImplementor;
				__obj.BeginNotUndoableAction ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EndNotUndoableActionNativeDelegate (IntPtr inst);

		static void EndNotUndoableAction_cb (IntPtr inst)
		{
			try {
				IUndoManagerImplementor __obj = GLib.Object.GetObject (inst, false) as IUndoManagerImplementor;
				__obj.EndNotUndoableAction ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkSourceUndoManagerIface native_iface = (GtkSourceUndoManagerIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkSourceUndoManagerIface));
			native_iface.CanUndo = iface.CanUndo;
			native_iface.CanRedo = iface.CanRedo;
			native_iface.Undo = iface.Undo;
			native_iface.Redo = iface.Redo;
			native_iface.BeginNotUndoableAction = iface.BeginNotUndoableAction;
			native_iface.EndNotUndoableAction = iface.EndNotUndoableAction;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public UndoManagerAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public UndoManagerAdapter (IUndoManagerImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public UndoManagerAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_source_undo_manager_get_type();
		static d_gtk_source_undo_manager_get_type gtk_source_undo_manager_get_type = FuncLoader.LoadFunction<d_gtk_source_undo_manager_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_get_type"));

		private static GLib.GType _gtype = new GLib.GType (gtk_source_undo_manager_get_type ());

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

		public static IUndoManager GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IUndoManager GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IUndoManagerImplementor)
				return new UndoManagerAdapter (obj as IUndoManagerImplementor);
			else if (obj as IUndoManager == null)
				return new UndoManagerAdapter (obj.Handle);
			else
				return obj as IUndoManager;
		}

		public IUndoManagerImplementor Implementor {
			get {
				return implementor as IUndoManagerImplementor;
			}
		}

		[GLib.Signal("can-undo-changed")]
		public event System.EventHandler EmitCanUndoChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("can-undo-changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("can-undo-changed", value);
			}
		}

		[GLib.Signal("can-redo-changed")]
		public event System.EventHandler EmitCanRedoChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("can-redo-changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("can-redo-changed", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_undo_manager_begin_not_undoable_action(IntPtr raw);
		static d_gtk_source_undo_manager_begin_not_undoable_action gtk_source_undo_manager_begin_not_undoable_action = FuncLoader.LoadFunction<d_gtk_source_undo_manager_begin_not_undoable_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_begin_not_undoable_action"));

		public void BeginNotUndoableAction() {
			gtk_source_undo_manager_begin_not_undoable_action(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_undo_manager_can_redo(IntPtr raw);
		static d_gtk_source_undo_manager_can_redo gtk_source_undo_manager_can_redo = FuncLoader.LoadFunction<d_gtk_source_undo_manager_can_redo>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_can_redo"));

		public bool CanRedo() {
			bool raw_ret = gtk_source_undo_manager_can_redo(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_undo_manager_can_redo_changed(IntPtr raw);
		static d_gtk_source_undo_manager_can_redo_changed gtk_source_undo_manager_can_redo_changed = FuncLoader.LoadFunction<d_gtk_source_undo_manager_can_redo_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_can_redo_changed"));

		public void CanRedoChanged() {
			gtk_source_undo_manager_can_redo_changed(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_source_undo_manager_can_undo(IntPtr raw);
		static d_gtk_source_undo_manager_can_undo gtk_source_undo_manager_can_undo = FuncLoader.LoadFunction<d_gtk_source_undo_manager_can_undo>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_can_undo"));

		public bool CanUndo() {
			bool raw_ret = gtk_source_undo_manager_can_undo(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_undo_manager_can_undo_changed(IntPtr raw);
		static d_gtk_source_undo_manager_can_undo_changed gtk_source_undo_manager_can_undo_changed = FuncLoader.LoadFunction<d_gtk_source_undo_manager_can_undo_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_can_undo_changed"));

		public void CanUndoChanged() {
			gtk_source_undo_manager_can_undo_changed(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_undo_manager_end_not_undoable_action(IntPtr raw);
		static d_gtk_source_undo_manager_end_not_undoable_action gtk_source_undo_manager_end_not_undoable_action = FuncLoader.LoadFunction<d_gtk_source_undo_manager_end_not_undoable_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_end_not_undoable_action"));

		public void EndNotUndoableAction() {
			gtk_source_undo_manager_end_not_undoable_action(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_undo_manager_redo(IntPtr raw);
		static d_gtk_source_undo_manager_redo gtk_source_undo_manager_redo = FuncLoader.LoadFunction<d_gtk_source_undo_manager_redo>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_redo"));

		public void Redo() {
			gtk_source_undo_manager_redo(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_source_undo_manager_undo(IntPtr raw);
		static d_gtk_source_undo_manager_undo gtk_source_undo_manager_undo = FuncLoader.LoadFunction<d_gtk_source_undo_manager_undo>(FuncLoader.GetProcAddress(GLibrary.Load(Library.GtkSource), "gtk_source_undo_manager_undo"));

		public void Undo() {
			gtk_source_undo_manager_undo(Handle);
		}

#endregion
	}
}
