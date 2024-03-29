// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class TlsCertificate : GLib.Object {

		public TlsCertificate (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_certificate_new_from_file(IntPtr file, out IntPtr error);
		static d_g_tls_certificate_new_from_file g_tls_certificate_new_from_file = FuncLoader.LoadFunction<d_g_tls_certificate_new_from_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_new_from_file"));

		public unsafe TlsCertificate (string file) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TlsCertificate)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_file = GLib.Marshaller.StringToPtrGStrdup (file);
			IntPtr error = IntPtr.Zero;
			Raw = g_tls_certificate_new_from_file(native_file, out error);
			GLib.Marshaller.Free (native_file);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_certificate_new_from_files(IntPtr cert_file, IntPtr key_file, out IntPtr error);
		static d_g_tls_certificate_new_from_files g_tls_certificate_new_from_files = FuncLoader.LoadFunction<d_g_tls_certificate_new_from_files>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_new_from_files"));

		public unsafe TlsCertificate (string cert_file, string key_file) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TlsCertificate)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_cert_file = GLib.Marshaller.StringToPtrGStrdup (cert_file);
			IntPtr native_key_file = GLib.Marshaller.StringToPtrGStrdup (key_file);
			IntPtr error = IntPtr.Zero;
			Raw = g_tls_certificate_new_from_files(native_cert_file, native_key_file, out error);
			GLib.Marshaller.Free (native_cert_file);
			GLib.Marshaller.Free (native_key_file);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_certificate_new_from_pem(IntPtr data, IntPtr length, out IntPtr error);
		static d_g_tls_certificate_new_from_pem g_tls_certificate_new_from_pem = FuncLoader.LoadFunction<d_g_tls_certificate_new_from_pem>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_new_from_pem"));

		public static unsafe TlsCertificate NewFromPem(string data)
		{
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup (data);
			IntPtr error = IntPtr.Zero;
			TlsCertificate result = new TlsCertificate (g_tls_certificate_new_from_pem(native_data, new IntPtr ((long) System.Text.Encoding.UTF8.GetByteCount (data)), out error));
			GLib.Marshaller.Free (native_data);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return result;
		}

		[GLib.Property ("certificate")]
		public IntPtr Certificate {
			get {
				GLib.Value val = GetProperty ("certificate");
				IntPtr ret = (IntPtr) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("certificate-pem")]
		public string CertificatePem {
			get {
				GLib.Value val = GetProperty ("certificate-pem");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_certificate_get_issuer(IntPtr raw);
		static d_g_tls_certificate_get_issuer g_tls_certificate_get_issuer = FuncLoader.LoadFunction<d_g_tls_certificate_get_issuer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_get_issuer"));

		[GLib.Property ("issuer")]
		public GLib.TlsCertificate Issuer {
			get  {
				IntPtr raw_ret = g_tls_certificate_get_issuer(Handle);
				GLib.TlsCertificate ret = GLib.Object.GetObject(raw_ret) as GLib.TlsCertificate;
				return ret;
			}
		}

		static VerifyNativeDelegate Verify_cb_delegate;
		static VerifyNativeDelegate VerifyVMCallback {
			get {
				if (Verify_cb_delegate == null)
					Verify_cb_delegate = new VerifyNativeDelegate (Verify_cb);
				return Verify_cb_delegate;
			}
		}

		static void OverrideVerify (GLib.GType gtype)
		{
			OverrideVerify (gtype, VerifyVMCallback);
		}

		static void OverrideVerify (GLib.GType gtype, VerifyNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("verify"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int VerifyNativeDelegate (IntPtr inst, IntPtr identity, IntPtr trusted_ca);

		static int Verify_cb (IntPtr inst, IntPtr identity, IntPtr trusted_ca)
		{
			try {
				TlsCertificate __obj = GLib.Object.GetObject (inst, false) as TlsCertificate;
				GLib.TlsCertificateFlags __result;
				__result = __obj.OnVerify (GLib.SocketConnectableAdapter.GetObject (identity, false), GLib.Object.GetObject(trusted_ca) as GLib.TlsCertificate);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsCertificate), ConnectionMethod="OverrideVerify")]
		protected virtual GLib.TlsCertificateFlags OnVerify (GLib.ISocketConnectable identity, GLib.TlsCertificate trusted_ca)
		{
			return InternalVerify (identity, trusted_ca);
		}

		private GLib.TlsCertificateFlags InternalVerify (GLib.ISocketConnectable identity, GLib.TlsCertificate trusted_ca)
		{
			VerifyNativeDelegate unmanaged = class_abi.BaseOverride<VerifyNativeDelegate>(this.LookupGType(), "verify");
			if (unmanaged == null) return (GLib.TlsCertificateFlags) 0;

			int __result = unmanaged (this.Handle, identity == null ? IntPtr.Zero : ((identity is GLib.Object) ? (identity as GLib.Object).Handle : (identity as GLib.SocketConnectableAdapter).Handle), trusted_ca == null ? IntPtr.Zero : trusted_ca.Handle);
			return (GLib.TlsCertificateFlags) __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("verify"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // verify
							, null
							, "padding"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) sizeof( IntPtr ) * 8 // padding
							, "verify"
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_certificate_get_type();
		static d_g_tls_certificate_get_type g_tls_certificate_get_type = FuncLoader.LoadFunction<d_g_tls_certificate_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_tls_certificate_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_g_tls_certificate_is_same(IntPtr raw, IntPtr cert_two);
		static d_g_tls_certificate_is_same g_tls_certificate_is_same = FuncLoader.LoadFunction<d_g_tls_certificate_is_same>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_is_same"));

		public bool IsSame(GLib.TlsCertificate cert_two) {
			bool raw_ret = g_tls_certificate_is_same(Handle, cert_two == null ? IntPtr.Zero : cert_two.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_certificate_list_new_from_file(IntPtr file, out IntPtr error);
		static d_g_tls_certificate_list_new_from_file g_tls_certificate_list_new_from_file = FuncLoader.LoadFunction<d_g_tls_certificate_list_new_from_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_list_new_from_file"));

		public static unsafe GLib.TlsCertificate[] ListNewFromFile(string file) {
			IntPtr native_file = GLib.Marshaller.StringToPtrGStrdup (file);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_tls_certificate_list_new_from_file(native_file, out error);
			GLib.TlsCertificate[] ret = GLib.Marshaller.ListPtrToArray<GLib.TlsCertificate, GLib.TlsCertificate> (raw_ret, true, true);
			GLib.Marshaller.Free (native_file);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_certificate_verify(IntPtr raw, IntPtr identity, IntPtr trusted_ca);
		static d_g_tls_certificate_verify g_tls_certificate_verify = FuncLoader.LoadFunction<d_g_tls_certificate_verify>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_certificate_verify"));

		public GLib.TlsCertificateFlags Verify(GLib.ISocketConnectable identity, GLib.TlsCertificate trusted_ca) {
			int raw_ret = g_tls_certificate_verify(Handle, identity == null ? IntPtr.Zero : ((identity is GLib.Object) ? (identity as GLib.Object).Handle : (identity as GLib.SocketConnectableAdapter).Handle), trusted_ca == null ? IntPtr.Zero : trusted_ca.Handle);
			GLib.TlsCertificateFlags ret = (GLib.TlsCertificateFlags) raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // priv
							, null
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
