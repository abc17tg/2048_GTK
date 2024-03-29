// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class StyleProviderAdapter : GLib.GInterfaceAdapter, Gtk.IStyleProvider {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkStyleProviderIface {
			IntPtr GetStyle;
			public GetStylePropertyNativeDelegate GetStyleProperty;
			IntPtr GetIconFactory;
		}

		static GtkStyleProviderIface iface;

		static StyleProviderAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (StyleProviderAdapter));
			iface.GetStyleProperty = new GetStylePropertyNativeDelegate (GetStyleProperty_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetStylePropertyNativeDelegate (IntPtr inst, IntPtr path, int state, IntPtr pspec, IntPtr value);

		static bool GetStyleProperty_cb (IntPtr inst, IntPtr path, int state, IntPtr pspec, IntPtr value)
		{
			try {
				IStyleProviderImplementor __obj = GLib.Object.GetObject (inst, false) as IStyleProviderImplementor;
				bool __result;
				__result = __obj.GetStyleProperty (path == IntPtr.Zero ? null : (Gtk.WidgetPath) GLib.Opaque.GetOpaque (path, typeof (Gtk.WidgetPath), false), (Gtk.StateFlags) state, pspec, (GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value)));
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
			GtkStyleProviderIface native_iface = (GtkStyleProviderIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkStyleProviderIface));
			native_iface.GetStyleProperty = iface.GetStyleProperty;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public StyleProviderAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public StyleProviderAdapter (IStyleProviderImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public StyleProviderAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_style_provider_get_type();
		static d_gtk_style_provider_get_type gtk_style_provider_get_type = FuncLoader.LoadFunction<d_gtk_style_provider_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_provider_get_type"));

		private static GLib.GType _gtype = new GLib.GType (gtk_style_provider_get_type ());

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

		public static IStyleProvider GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IStyleProvider GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IStyleProviderImplementor)
				return new StyleProviderAdapter (obj as IStyleProviderImplementor);
			else if (obj as IStyleProvider == null)
				return new StyleProviderAdapter (obj.Handle);
			else
				return obj as IStyleProvider;
		}

		public IStyleProviderImplementor Implementor {
			get {
				return implementor as IStyleProviderImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_style_provider_get_style_property(IntPtr raw, IntPtr path, int state, IntPtr pspec, IntPtr value);
		static d_gtk_style_provider_get_style_property gtk_style_provider_get_style_property = FuncLoader.LoadFunction<d_gtk_style_provider_get_style_property>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_style_provider_get_style_property"));

		public bool GetStyleProperty(Gtk.WidgetPath path, Gtk.StateFlags state, IntPtr pspec, GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = gtk_style_provider_get_style_property(Handle, path == null ? IntPtr.Zero : path.Handle, (int) state, pspec, native_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

#endregion
	}
}
