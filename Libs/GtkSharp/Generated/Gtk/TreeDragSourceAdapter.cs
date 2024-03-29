// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TreeDragSourceAdapter : GLib.GInterfaceAdapter, Gtk.ITreeDragSource {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkTreeDragSourceIface {
			public RowDraggableNativeDelegate RowDraggable;
			public DragDataGetNativeDelegate DragDataGet;
			public DragDataDeleteNativeDelegate DragDataDelete;
		}

		static GtkTreeDragSourceIface iface;

		static TreeDragSourceAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (TreeDragSourceAdapter));
			iface.RowDraggable = new RowDraggableNativeDelegate (RowDraggable_cb);
			iface.DragDataGet = new DragDataGetNativeDelegate (DragDataGet_cb);
			iface.DragDataDelete = new DragDataDeleteNativeDelegate (DragDataDelete_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RowDraggableNativeDelegate (IntPtr inst, IntPtr path);

		static bool RowDraggable_cb (IntPtr inst, IntPtr path)
		{
			try {
				ITreeDragSourceImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeDragSourceImplementor;
				bool __result;
				__result = __obj.RowDraggable (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool DragDataGetNativeDelegate (IntPtr inst, IntPtr path, IntPtr selection_data);

		static bool DragDataGet_cb (IntPtr inst, IntPtr path, IntPtr selection_data)
		{
			try {
				ITreeDragSourceImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeDragSourceImplementor;
				bool __result;
				__result = __obj.DragDataGet (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false), selection_data == IntPtr.Zero ? null : (Gtk.SelectionData) GLib.Opaque.GetOpaque (selection_data, typeof (Gtk.SelectionData), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool DragDataDeleteNativeDelegate (IntPtr inst, IntPtr path);

		static bool DragDataDelete_cb (IntPtr inst, IntPtr path)
		{
			try {
				ITreeDragSourceImplementor __obj = GLib.Object.GetObject (inst, false) as ITreeDragSourceImplementor;
				bool __result;
				__result = __obj.DragDataDelete (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false));
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
			GtkTreeDragSourceIface native_iface = (GtkTreeDragSourceIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkTreeDragSourceIface));
			native_iface.RowDraggable = iface.RowDraggable;
			native_iface.DragDataGet = iface.DragDataGet;
			native_iface.DragDataDelete = iface.DragDataDelete;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public TreeDragSourceAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public TreeDragSourceAdapter (ITreeDragSourceImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public TreeDragSourceAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_drag_source_get_type();
		static d_gtk_tree_drag_source_get_type gtk_tree_drag_source_get_type = FuncLoader.LoadFunction<d_gtk_tree_drag_source_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_drag_source_get_type"));

		private static GLib.GType _gtype = new GLib.GType (gtk_tree_drag_source_get_type ());

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

		public static ITreeDragSource GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ITreeDragSource GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ITreeDragSourceImplementor)
				return new TreeDragSourceAdapter (obj as ITreeDragSourceImplementor);
			else if (obj as ITreeDragSource == null)
				return new TreeDragSourceAdapter (obj.Handle);
			else
				return obj as ITreeDragSource;
		}

		public ITreeDragSourceImplementor Implementor {
			get {
				return implementor as ITreeDragSourceImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_drag_source_drag_data_delete(IntPtr raw, IntPtr path);
		static d_gtk_tree_drag_source_drag_data_delete gtk_tree_drag_source_drag_data_delete = FuncLoader.LoadFunction<d_gtk_tree_drag_source_drag_data_delete>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_drag_source_drag_data_delete"));

		public bool DragDataDelete(Gtk.TreePath path) {
			bool raw_ret = gtk_tree_drag_source_drag_data_delete(Handle, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_drag_source_drag_data_get(IntPtr raw, IntPtr path, IntPtr selection_data);
		static d_gtk_tree_drag_source_drag_data_get gtk_tree_drag_source_drag_data_get = FuncLoader.LoadFunction<d_gtk_tree_drag_source_drag_data_get>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_drag_source_drag_data_get"));

		public bool DragDataGet(Gtk.TreePath path, Gtk.SelectionData selection_data) {
			bool raw_ret = gtk_tree_drag_source_drag_data_get(Handle, path == null ? IntPtr.Zero : path.Handle, selection_data == null ? IntPtr.Zero : selection_data.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_drag_source_row_draggable(IntPtr raw, IntPtr path);
		static d_gtk_tree_drag_source_row_draggable gtk_tree_drag_source_row_draggable = FuncLoader.LoadFunction<d_gtk_tree_drag_source_row_draggable>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_drag_source_row_draggable"));

		public bool RowDraggable(Gtk.TreePath path) {
			bool raw_ret = gtk_tree_drag_source_row_draggable(Handle, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
