// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class TlsInteraction : GLib.Object {

		public TlsInteraction (IntPtr raw) : base(raw) {}

		protected TlsInteraction() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static AskPasswordNativeDelegate AskPassword_cb_delegate;
		static AskPasswordNativeDelegate AskPasswordVMCallback {
			get {
				if (AskPassword_cb_delegate == null)
					AskPassword_cb_delegate = new AskPasswordNativeDelegate (AskPassword_cb);
				return AskPassword_cb_delegate;
			}
		}

		static void OverrideAskPassword (GLib.GType gtype)
		{
			OverrideAskPassword (gtype, AskPasswordVMCallback);
		}

		static void OverrideAskPassword (GLib.GType gtype, AskPasswordNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("ask_password"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int AskPasswordNativeDelegate (IntPtr inst, IntPtr password, IntPtr cancellable, out IntPtr error);

		static int AskPassword_cb (IntPtr inst, IntPtr password, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				TlsInteraction __obj = GLib.Object.GetObject (inst, false) as TlsInteraction;
				GLib.TlsInteractionResult __result;
				__result = __obj.OnAskPassword (GLib.Object.GetObject(password) as GLib.TlsPassword, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsInteraction), ConnectionMethod="OverrideAskPassword")]
		protected virtual GLib.TlsInteractionResult OnAskPassword (GLib.TlsPassword password, GLib.Cancellable cancellable)
		{
			return InternalAskPassword (password, cancellable);
		}

		private GLib.TlsInteractionResult InternalAskPassword (GLib.TlsPassword password, GLib.Cancellable cancellable)
		{
			AskPasswordNativeDelegate unmanaged = class_abi.BaseOverride<AskPasswordNativeDelegate>(this.LookupGType(), "ask_password");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			int __result = unmanaged (this.Handle, password == null ? IntPtr.Zero : password.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return (GLib.TlsInteractionResult) __result;
		}

		static AskPasswordAsyncNativeDelegate AskPasswordAsync_cb_delegate;
		static AskPasswordAsyncNativeDelegate AskPasswordAsyncVMCallback {
			get {
				if (AskPasswordAsync_cb_delegate == null)
					AskPasswordAsync_cb_delegate = new AskPasswordAsyncNativeDelegate (AskPasswordAsync_cb);
				return AskPasswordAsync_cb_delegate;
			}
		}

		static void OverrideAskPasswordAsync (GLib.GType gtype)
		{
			OverrideAskPasswordAsync (gtype, AskPasswordAsyncVMCallback);
		}

		static void OverrideAskPasswordAsync (GLib.GType gtype, AskPasswordAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("ask_password_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AskPasswordAsyncNativeDelegate (IntPtr inst, IntPtr password, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void AskPasswordAsync_cb (IntPtr inst, IntPtr password, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				TlsInteraction __obj = GLib.Object.GetObject (inst, false) as TlsInteraction;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnAskPasswordAsync (GLib.Object.GetObject(password) as GLib.TlsPassword, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsInteraction), ConnectionMethod="OverrideAskPasswordAsync")]
		protected virtual void OnAskPasswordAsync (GLib.TlsPassword password, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalAskPasswordAsync (password, cancellable, cb);
		}

		private void InternalAskPasswordAsync (GLib.TlsPassword password, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			AskPasswordAsyncNativeDelegate unmanaged = class_abi.BaseOverride<AskPasswordAsyncNativeDelegate>(this.LookupGType(), "ask_password_async");
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, password == null ? IntPtr.Zero : password.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static AskPasswordFinishNativeDelegate AskPasswordFinish_cb_delegate;
		static AskPasswordFinishNativeDelegate AskPasswordFinishVMCallback {
			get {
				if (AskPasswordFinish_cb_delegate == null)
					AskPasswordFinish_cb_delegate = new AskPasswordFinishNativeDelegate (AskPasswordFinish_cb);
				return AskPasswordFinish_cb_delegate;
			}
		}

		static void OverrideAskPasswordFinish (GLib.GType gtype)
		{
			OverrideAskPasswordFinish (gtype, AskPasswordFinishVMCallback);
		}

		static void OverrideAskPasswordFinish (GLib.GType gtype, AskPasswordFinishNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("ask_password_finish"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int AskPasswordFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static int AskPasswordFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				TlsInteraction __obj = GLib.Object.GetObject (inst, false) as TlsInteraction;
				GLib.TlsInteractionResult __result;
				__result = __obj.OnAskPasswordFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsInteraction), ConnectionMethod="OverrideAskPasswordFinish")]
		protected virtual GLib.TlsInteractionResult OnAskPasswordFinish (GLib.IAsyncResult result)
		{
			return InternalAskPasswordFinish (result);
		}

		private GLib.TlsInteractionResult InternalAskPasswordFinish (GLib.IAsyncResult result)
		{
			AskPasswordFinishNativeDelegate unmanaged = class_abi.BaseOverride<AskPasswordFinishNativeDelegate>(this.LookupGType(), "ask_password_finish");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			int __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (GLib.TlsInteractionResult) __result;
		}

		static RequestCertificateNativeDelegate RequestCertificate_cb_delegate;
		static RequestCertificateNativeDelegate RequestCertificateVMCallback {
			get {
				if (RequestCertificate_cb_delegate == null)
					RequestCertificate_cb_delegate = new RequestCertificateNativeDelegate (RequestCertificate_cb);
				return RequestCertificate_cb_delegate;
			}
		}

		static void OverrideRequestCertificate (GLib.GType gtype)
		{
			OverrideRequestCertificate (gtype, RequestCertificateVMCallback);
		}

		static void OverrideRequestCertificate (GLib.GType gtype, RequestCertificateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("request_certificate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int RequestCertificateNativeDelegate (IntPtr inst, IntPtr connection, int flags, IntPtr cancellable, out IntPtr error);

		static int RequestCertificate_cb (IntPtr inst, IntPtr connection, int flags, IntPtr cancellable, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				TlsInteraction __obj = GLib.Object.GetObject (inst, false) as TlsInteraction;
				GLib.TlsInteractionResult __result;
				__result = __obj.OnRequestCertificate (GLib.Object.GetObject(connection) as GLib.TlsConnection, (GLib.TlsCertificateRequestFlags) flags, GLib.Object.GetObject(cancellable) as GLib.Cancellable);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsInteraction), ConnectionMethod="OverrideRequestCertificate")]
		protected virtual GLib.TlsInteractionResult OnRequestCertificate (GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable)
		{
			return InternalRequestCertificate (connection, flags, cancellable);
		}

		private GLib.TlsInteractionResult InternalRequestCertificate (GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable)
		{
			RequestCertificateNativeDelegate unmanaged = class_abi.BaseOverride<RequestCertificateNativeDelegate>(this.LookupGType(), "request_certificate");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			int __result = unmanaged (this.Handle, connection == null ? IntPtr.Zero : connection.Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			return (GLib.TlsInteractionResult) __result;
		}

		static RequestCertificateAsyncNativeDelegate RequestCertificateAsync_cb_delegate;
		static RequestCertificateAsyncNativeDelegate RequestCertificateAsyncVMCallback {
			get {
				if (RequestCertificateAsync_cb_delegate == null)
					RequestCertificateAsync_cb_delegate = new RequestCertificateAsyncNativeDelegate (RequestCertificateAsync_cb);
				return RequestCertificateAsync_cb_delegate;
			}
		}

		static void OverrideRequestCertificateAsync (GLib.GType gtype)
		{
			OverrideRequestCertificateAsync (gtype, RequestCertificateAsyncVMCallback);
		}

		static void OverrideRequestCertificateAsync (GLib.GType gtype, RequestCertificateAsyncNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("request_certificate_async"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RequestCertificateAsyncNativeDelegate (IntPtr inst, IntPtr connection, int flags, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		static void RequestCertificateAsync_cb (IntPtr inst, IntPtr connection, int flags, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data)
		{
			try {
				TlsInteraction __obj = GLib.Object.GetObject (inst, false) as TlsInteraction;
				GLibSharp.AsyncReadyCallbackInvoker cb_invoker = new GLibSharp.AsyncReadyCallbackInvoker (cb, user_data);
				__obj.OnRequestCertificateAsync (GLib.Object.GetObject(connection) as GLib.TlsConnection, (GLib.TlsCertificateRequestFlags) flags, GLib.Object.GetObject(cancellable) as GLib.Cancellable, cb_invoker.Handler);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsInteraction), ConnectionMethod="OverrideRequestCertificateAsync")]
		protected virtual void OnRequestCertificateAsync (GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			InternalRequestCertificateAsync (connection, flags, cancellable, cb);
		}

		private void InternalRequestCertificateAsync (GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb)
		{
			RequestCertificateAsyncNativeDelegate unmanaged = class_abi.BaseOverride<RequestCertificateAsyncNativeDelegate>(this.LookupGType(), "request_certificate_async");
			if (unmanaged == null) return;

			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			unmanaged (this.Handle, connection == null ? IntPtr.Zero : connection.Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		static RequestCertificateFinishNativeDelegate RequestCertificateFinish_cb_delegate;
		static RequestCertificateFinishNativeDelegate RequestCertificateFinishVMCallback {
			get {
				if (RequestCertificateFinish_cb_delegate == null)
					RequestCertificateFinish_cb_delegate = new RequestCertificateFinishNativeDelegate (RequestCertificateFinish_cb);
				return RequestCertificateFinish_cb_delegate;
			}
		}

		static void OverrideRequestCertificateFinish (GLib.GType gtype)
		{
			OverrideRequestCertificateFinish (gtype, RequestCertificateFinishVMCallback);
		}

		static void OverrideRequestCertificateFinish (GLib.GType gtype, RequestCertificateFinishNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("request_certificate_finish"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int RequestCertificateFinishNativeDelegate (IntPtr inst, IntPtr result, out IntPtr error);

		static int RequestCertificateFinish_cb (IntPtr inst, IntPtr result, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				TlsInteraction __obj = GLib.Object.GetObject (inst, false) as TlsInteraction;
				GLib.TlsInteractionResult __result;
				__result = __obj.OnRequestCertificateFinish (GLib.AsyncResultAdapter.GetObject (result, false));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsInteraction), ConnectionMethod="OverrideRequestCertificateFinish")]
		protected virtual GLib.TlsInteractionResult OnRequestCertificateFinish (GLib.IAsyncResult result)
		{
			return InternalRequestCertificateFinish (result);
		}

		private GLib.TlsInteractionResult InternalRequestCertificateFinish (GLib.IAsyncResult result)
		{
			RequestCertificateFinishNativeDelegate unmanaged = class_abi.BaseOverride<RequestCertificateFinishNativeDelegate>(this.LookupGType(), "request_certificate_finish");
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			int __result = unmanaged (this.Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			return (GLib.TlsInteractionResult) __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("ask_password"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // ask_password
							, null
							, "ask_password_async"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("ask_password_async"
							, -1
							, (uint) sizeof( IntPtr ) // ask_password_async
							, "ask_password"
							, "ask_password_finish"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("ask_password_finish"
							, -1
							, (uint) sizeof( IntPtr ) // ask_password_finish
							, "ask_password_async"
							, "request_certificate"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("request_certificate"
							, -1
							, (uint) sizeof( IntPtr ) // request_certificate
							, "ask_password_finish"
							, "request_certificate_async"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("request_certificate_async"
							, -1
							, (uint) sizeof( IntPtr ) // request_certificate_async
							, "request_certificate"
							, "request_certificate_finish"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("request_certificate_finish"
							, -1
							, (uint) sizeof( IntPtr ) // request_certificate_finish
							, "request_certificate_async"
							, "padding"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) sizeof( IntPtr ) * 21 // padding
							, "request_certificate_finish"
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
		delegate int d_g_tls_interaction_ask_password(IntPtr raw, IntPtr password, IntPtr cancellable, out IntPtr error);
		static d_g_tls_interaction_ask_password g_tls_interaction_ask_password = FuncLoader.LoadFunction<d_g_tls_interaction_ask_password>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_ask_password"));

		public unsafe GLib.TlsInteractionResult AskPassword(GLib.TlsPassword password, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_tls_interaction_ask_password(Handle, password == null ? IntPtr.Zero : password.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.TlsInteractionResult ret = (GLib.TlsInteractionResult) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_tls_interaction_ask_password_async(IntPtr raw, IntPtr password, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_tls_interaction_ask_password_async g_tls_interaction_ask_password_async = FuncLoader.LoadFunction<d_g_tls_interaction_ask_password_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_ask_password_async"));

		public void AskPasswordAsync(GLib.TlsPassword password, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_tls_interaction_ask_password_async(Handle, password == null ? IntPtr.Zero : password.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_interaction_ask_password_finish(IntPtr raw, IntPtr result, out IntPtr error);
		static d_g_tls_interaction_ask_password_finish g_tls_interaction_ask_password_finish = FuncLoader.LoadFunction<d_g_tls_interaction_ask_password_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_ask_password_finish"));

		public unsafe GLib.TlsInteractionResult AskPasswordFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_tls_interaction_ask_password_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.TlsInteractionResult ret = (GLib.TlsInteractionResult) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_g_tls_interaction_get_type();
		static d_g_tls_interaction_get_type g_tls_interaction_get_type = FuncLoader.LoadFunction<d_g_tls_interaction_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_tls_interaction_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_interaction_invoke_ask_password(IntPtr raw, IntPtr password, IntPtr cancellable, out IntPtr error);
		static d_g_tls_interaction_invoke_ask_password g_tls_interaction_invoke_ask_password = FuncLoader.LoadFunction<d_g_tls_interaction_invoke_ask_password>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_invoke_ask_password"));

		public unsafe GLib.TlsInteractionResult InvokeAskPassword(GLib.TlsPassword password, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_tls_interaction_invoke_ask_password(Handle, password == null ? IntPtr.Zero : password.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.TlsInteractionResult ret = (GLib.TlsInteractionResult) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_interaction_invoke_request_certificate(IntPtr raw, IntPtr connection, int flags, IntPtr cancellable, out IntPtr error);
		static d_g_tls_interaction_invoke_request_certificate g_tls_interaction_invoke_request_certificate = FuncLoader.LoadFunction<d_g_tls_interaction_invoke_request_certificate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_invoke_request_certificate"));

		public unsafe GLib.TlsInteractionResult InvokeRequestCertificate(GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_tls_interaction_invoke_request_certificate(Handle, connection == null ? IntPtr.Zero : connection.Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.TlsInteractionResult ret = (GLib.TlsInteractionResult) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_interaction_request_certificate(IntPtr raw, IntPtr connection, int flags, IntPtr cancellable, out IntPtr error);
		static d_g_tls_interaction_request_certificate g_tls_interaction_request_certificate = FuncLoader.LoadFunction<d_g_tls_interaction_request_certificate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_request_certificate"));

		public unsafe GLib.TlsInteractionResult RequestCertificate(GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_tls_interaction_request_certificate(Handle, connection == null ? IntPtr.Zero : connection.Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.TlsInteractionResult ret = (GLib.TlsInteractionResult) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_g_tls_interaction_request_certificate_async(IntPtr raw, IntPtr connection, int flags, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_g_tls_interaction_request_certificate_async g_tls_interaction_request_certificate_async = FuncLoader.LoadFunction<d_g_tls_interaction_request_certificate_async>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_request_certificate_async"));

		public void RequestCertificateAsync(GLib.TlsConnection connection, GLib.TlsCertificateRequestFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_tls_interaction_request_certificate_async(Handle, connection == null ? IntPtr.Zero : connection.Handle, (int) flags, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_g_tls_interaction_request_certificate_finish(IntPtr raw, IntPtr result, out IntPtr error);
		static d_g_tls_interaction_request_certificate_finish g_tls_interaction_request_certificate_finish = FuncLoader.LoadFunction<d_g_tls_interaction_request_certificate_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gio), "g_tls_interaction_request_certificate_finish"));

		public unsafe GLib.TlsInteractionResult RequestCertificateFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_tls_interaction_request_certificate_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.TlsInteractionResult ret = (GLib.TlsInteractionResult) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
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
