// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TlsClientConnectionAdapter : GLib.GInterfaceAdapter, GLib.ITlsClientConnection {

		[StructLayout (LayoutKind.Sequential)]
		struct GTlsClientConnectionInterface {
			public CopySessionStateNativeDelegate CopySessionState;
		}

		static GTlsClientConnectionInterface iface;

		static TlsClientConnectionAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (TlsClientConnectionAdapter));
			iface.CopySessionState = new CopySessionStateNativeDelegate (CopySessionState_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CopySessionStateNativeDelegate (IntPtr inst, IntPtr source);

		static void CopySessionState_cb (IntPtr inst, IntPtr source)
		{
			try {
				ITlsClientConnectionImplementor __obj = GLib.Object.GetObject (inst, false) as ITlsClientConnectionImplementor;
				__obj.CopySessionState (GLib.TlsClientConnectionAdapter.GetObject (source, false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GTlsClientConnectionInterface native_iface = (GTlsClientConnectionInterface) Marshal.PtrToStructure (ifaceptr, typeof (GTlsClientConnectionInterface));
			native_iface.CopySessionState = iface.CopySessionState;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public TlsClientConnectionAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public TlsClientConnectionAdapter (ITlsClientConnectionImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public TlsClientConnectionAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_client_connection_get_type();
		static d_g_tls_client_connection_get_type g_tls_client_connection_get_type = FuncLoader.LoadFunction<d_g_tls_client_connection_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_get_type"));

		private static GLib.GType _gtype = new GLib.GType (g_tls_client_connection_get_type ());

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

		public static ITlsClientConnection GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static ITlsClientConnection GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ITlsClientConnectionImplementor)
				return new TlsClientConnectionAdapter (obj as ITlsClientConnectionImplementor);
			else if (obj as ITlsClientConnection == null)
				return new TlsClientConnectionAdapter (obj.Handle);
			else
				return obj as ITlsClientConnection;
		}

		public ITlsClientConnectionImplementor Implementor {
			get {
				return implementor as ITlsClientConnectionImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_client_connection_get_validation_flags(IntPtr raw);
		static d_g_tls_client_connection_get_validation_flags g_tls_client_connection_get_validation_flags = FuncLoader.LoadFunction<d_g_tls_client_connection_get_validation_flags>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_get_validation_flags"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_tls_client_connection_set_validation_flags(IntPtr raw, int flags);
		static d_g_tls_client_connection_set_validation_flags g_tls_client_connection_set_validation_flags = FuncLoader.LoadFunction<d_g_tls_client_connection_set_validation_flags>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_set_validation_flags"));

		[GLib.Property ("validation-flags")]
		public GLib.TlsCertificateFlags ValidationFlags {
			get  {
				int raw_ret = g_tls_client_connection_get_validation_flags(Handle);
				GLib.TlsCertificateFlags ret = (GLib.TlsCertificateFlags) raw_ret;
				return ret;
			}
			set  {
				g_tls_client_connection_set_validation_flags(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_client_connection_get_server_identity(IntPtr raw);
		static d_g_tls_client_connection_get_server_identity g_tls_client_connection_get_server_identity = FuncLoader.LoadFunction<d_g_tls_client_connection_get_server_identity>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_get_server_identity"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_tls_client_connection_set_server_identity(IntPtr raw, IntPtr identity);
		static d_g_tls_client_connection_set_server_identity g_tls_client_connection_set_server_identity = FuncLoader.LoadFunction<d_g_tls_client_connection_set_server_identity>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_set_server_identity"));

		[GLib.Property ("server-identity")]
		public GLib.ISocketConnectable ServerIdentity {
			get  {
				IntPtr raw_ret = g_tls_client_connection_get_server_identity(Handle);
				GLib.ISocketConnectable ret = GLib.SocketConnectableAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				g_tls_client_connection_set_server_identity(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.SocketConnectableAdapter).Handle));
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_tls_client_connection_get_use_ssl3(IntPtr raw);
		static d_g_tls_client_connection_get_use_ssl3 g_tls_client_connection_get_use_ssl3 = FuncLoader.LoadFunction<d_g_tls_client_connection_get_use_ssl3>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_get_use_ssl3"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_tls_client_connection_set_use_ssl3(IntPtr raw, bool use_ssl3);
		static d_g_tls_client_connection_set_use_ssl3 g_tls_client_connection_set_use_ssl3 = FuncLoader.LoadFunction<d_g_tls_client_connection_set_use_ssl3>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_set_use_ssl3"));

		[GLib.Property ("use-ssl3")]
		public bool UseSsl3 {
			get  {
				bool raw_ret = g_tls_client_connection_get_use_ssl3(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				g_tls_client_connection_set_use_ssl3(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_client_connection_get_accepted_cas(IntPtr raw);
		static d_g_tls_client_connection_get_accepted_cas g_tls_client_connection_get_accepted_cas = FuncLoader.LoadFunction<d_g_tls_client_connection_get_accepted_cas>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_get_accepted_cas"));

		[GLib.Property ("accepted-cas")]
		public IntPtr[] AcceptedCas {
			get  {
				IntPtr raw_ret = g_tls_client_connection_get_accepted_cas(Handle);
				IntPtr[] ret = GLib.Marshaller.ListPtrToArray<IntPtr, IntPtr> (raw_ret, true, true);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_tls_client_connection_copy_session_state(IntPtr raw, IntPtr source);
		static d_g_tls_client_connection_copy_session_state g_tls_client_connection_copy_session_state = FuncLoader.LoadFunction<d_g_tls_client_connection_copy_session_state>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_client_connection_copy_session_state"));

		public void CopySessionState(GLib.ITlsClientConnection source) {
			g_tls_client_connection_copy_session_state(Handle, source == null ? IntPtr.Zero : ((source is GLib.Object) ? (source as GLib.Object).Handle : (source as GLib.TlsClientConnectionAdapter).Handle));
		}

#endregion
	}
}
