// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TreeRowReference : GLib.Opaque {

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_row_reference_copy(IntPtr raw);
		static d_gtk_tree_row_reference_copy gtk_tree_row_reference_copy = FuncLoader.LoadFunction<d_gtk_tree_row_reference_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_copy"));

		public Gtk.TreeRowReference Copy() {
			IntPtr raw_ret = gtk_tree_row_reference_copy(Handle);
			Gtk.TreeRowReference ret = raw_ret == IntPtr.Zero ? null : (Gtk.TreeRowReference) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TreeRowReference), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_row_reference_deleted(IntPtr proxy, IntPtr path);
		static d_gtk_tree_row_reference_deleted gtk_tree_row_reference_deleted = FuncLoader.LoadFunction<d_gtk_tree_row_reference_deleted>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_deleted"));

		public static void Deleted(GLib.Object proxy, Gtk.TreePath path) {
			gtk_tree_row_reference_deleted(proxy == null ? IntPtr.Zero : proxy.Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_row_reference_get_model(IntPtr raw);
		static d_gtk_tree_row_reference_get_model gtk_tree_row_reference_get_model = FuncLoader.LoadFunction<d_gtk_tree_row_reference_get_model>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_get_model"));

		public Gtk.ITreeModel Model { 
			get {
				IntPtr raw_ret = gtk_tree_row_reference_get_model(Handle);
				Gtk.ITreeModel ret = Gtk.TreeModelAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_row_reference_get_path(IntPtr raw);
		static d_gtk_tree_row_reference_get_path gtk_tree_row_reference_get_path = FuncLoader.LoadFunction<d_gtk_tree_row_reference_get_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_get_path"));

		public Gtk.TreePath Path { 
			get {
				IntPtr raw_ret = gtk_tree_row_reference_get_path(Handle);
				Gtk.TreePath ret = raw_ret == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TreePath), true);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_row_reference_get_type();
		static d_gtk_tree_row_reference_get_type gtk_tree_row_reference_get_type = FuncLoader.LoadFunction<d_gtk_tree_row_reference_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tree_row_reference_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_row_reference_inserted(IntPtr proxy, IntPtr path);
		static d_gtk_tree_row_reference_inserted gtk_tree_row_reference_inserted = FuncLoader.LoadFunction<d_gtk_tree_row_reference_inserted>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_inserted"));

		public static void Inserted(GLib.Object proxy, Gtk.TreePath path) {
			gtk_tree_row_reference_inserted(proxy == null ? IntPtr.Zero : proxy.Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_row_reference_reordered(IntPtr proxy, IntPtr path, IntPtr iter, out int new_order);
		static d_gtk_tree_row_reference_reordered gtk_tree_row_reference_reordered = FuncLoader.LoadFunction<d_gtk_tree_row_reference_reordered>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_reordered"));

		public static int Reordered(GLib.Object proxy, Gtk.TreePath path, Gtk.TreeIter iter) {
			int new_order;
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_row_reference_reordered(proxy == null ? IntPtr.Zero : proxy.Handle, path == null ? IntPtr.Zero : path.Handle, native_iter, out new_order);
			Marshal.FreeHGlobal (native_iter);
			return new_order;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_tree_row_reference_valid(IntPtr raw);
		static d_gtk_tree_row_reference_valid gtk_tree_row_reference_valid = FuncLoader.LoadFunction<d_gtk_tree_row_reference_valid>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_valid"));

		public bool Valid() {
			bool raw_ret = gtk_tree_row_reference_valid(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public TreeRowReference(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_row_reference_new(IntPtr model, IntPtr path);
		static d_gtk_tree_row_reference_new gtk_tree_row_reference_new = FuncLoader.LoadFunction<d_gtk_tree_row_reference_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_new"));

		public TreeRowReference (Gtk.ITreeModel model, Gtk.TreePath path) 
		{
			Raw = gtk_tree_row_reference_new(model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle), path == null ? IntPtr.Zero : path.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_tree_row_reference_new_proxy(IntPtr proxy, IntPtr model, IntPtr path);
		static d_gtk_tree_row_reference_new_proxy gtk_tree_row_reference_new_proxy = FuncLoader.LoadFunction<d_gtk_tree_row_reference_new_proxy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_new_proxy"));

		public TreeRowReference (GLib.Object proxy, Gtk.ITreeModel model, Gtk.TreePath path) 
		{
			Raw = gtk_tree_row_reference_new_proxy(proxy == null ? IntPtr.Zero : proxy.Handle, model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle), path == null ? IntPtr.Zero : path.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_tree_row_reference_free(IntPtr raw);
		static d_gtk_tree_row_reference_free gtk_tree_row_reference_free = FuncLoader.LoadFunction<d_gtk_tree_row_reference_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_tree_row_reference_free"));

		protected override void Free (IntPtr raw)
		{
			gtk_tree_row_reference_free (raw);
		}

		[Obsolete("Gtk.TreeRowReference is now freed automatically")]
		public void Free () {}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_tree_row_reference_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~TreeRowReference ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
