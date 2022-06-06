// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class UserContentFilterStore : GLib.Object {

		public UserContentFilterStore (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_filter_store_new(IntPtr storage_path);
		static d_webkit_user_content_filter_store_new webkit_user_content_filter_store_new = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_new"));

		public UserContentFilterStore (string storage_path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UserContentFilterStore)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_storage_path = GLib.Marshaller.StringToPtrGStrdup (storage_path);
			Raw = webkit_user_content_filter_store_new(native_storage_path);
			GLib.Marshaller.Free (native_storage_path);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_filter_store_get_path(IntPtr raw);
		static d_webkit_user_content_filter_store_get_path webkit_user_content_filter_store_get_path = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_get_path>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_get_path"));

		[GLib.Property ("path")]
		public string Path {
			get  {
				IntPtr raw_ret = webkit_user_content_filter_store_get_path(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_webkit_reserved0"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _webkit_reserved0
							, null
							, "_webkit_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved1
							, "_webkit_reserved0"
							, "_webkit_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved2
							, "_webkit_reserved1"
							, "_webkit_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved3
							, "_webkit_reserved2"
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
		delegate IntPtr d_webkit_user_content_filter_store_get_type();
		static d_webkit_user_content_filter_store_get_type webkit_user_content_filter_store_get_type = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_user_content_filter_store_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_filter_store_fetch_identifiers(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_webkit_user_content_filter_store_fetch_identifiers webkit_user_content_filter_store_fetch_identifiers = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_fetch_identifiers>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_fetch_identifiers"));

		public void FetchIdentifiers(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			webkit_user_content_filter_store_fetch_identifiers(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		public void FetchIdentifiers() {
			FetchIdentifiers (null, null);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_filter_store_fetch_identifiers_finish(IntPtr raw, IntPtr _result);
		static d_webkit_user_content_filter_store_fetch_identifiers_finish webkit_user_content_filter_store_fetch_identifiers_finish = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_fetch_identifiers_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_fetch_identifiers_finish"));

		public string[] FetchIdentifiersFinish(GLib.IAsyncResult _result) {
			IntPtr raw_ret = webkit_user_content_filter_store_fetch_identifiers_finish(Handle, _result == null ? IntPtr.Zero : ((_result is GLib.Object) ? (_result as GLib.Object).Handle : (_result as GLib.AsyncResultAdapter).Handle));
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_filter_store_load(IntPtr raw, IntPtr identifier, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_webkit_user_content_filter_store_load webkit_user_content_filter_store_load = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_load>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_load"));

		public void Load(string identifier, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_identifier = GLib.Marshaller.StringToPtrGStrdup (identifier);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			webkit_user_content_filter_store_load(Handle, native_identifier, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_identifier);
		}

		public void Load(string identifier) {
			Load (identifier, null, null);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_filter_store_load_finish(IntPtr raw, IntPtr _result, out IntPtr error);
		static d_webkit_user_content_filter_store_load_finish webkit_user_content_filter_store_load_finish = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_load_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_load_finish"));

		public unsafe WebKit.UserContentFilter LoadFinish(GLib.IAsyncResult _result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = webkit_user_content_filter_store_load_finish(Handle, _result == null ? IntPtr.Zero : ((_result is GLib.Object) ? (_result as GLib.Object).Handle : (_result as GLib.AsyncResultAdapter).Handle), out error);
			WebKit.UserContentFilter ret = WebKit.UserContentFilter.New (raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_filter_store_remove(IntPtr raw, IntPtr identifier, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_webkit_user_content_filter_store_remove webkit_user_content_filter_store_remove = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_remove>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_remove"));

		public void Remove(string identifier, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_identifier = GLib.Marshaller.StringToPtrGStrdup (identifier);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			webkit_user_content_filter_store_remove(Handle, native_identifier, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_identifier);
		}

		public void Remove(string identifier) {
			Remove (identifier, null, null);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_user_content_filter_store_remove_finish(IntPtr raw, IntPtr _result, out IntPtr error);
		static d_webkit_user_content_filter_store_remove_finish webkit_user_content_filter_store_remove_finish = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_remove_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_remove_finish"));

		public unsafe bool RemoveFinish(GLib.IAsyncResult _result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = webkit_user_content_filter_store_remove_finish(Handle, _result == null ? IntPtr.Zero : ((_result is GLib.Object) ? (_result as GLib.Object).Handle : (_result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_filter_store_save(IntPtr raw, IntPtr identifier, IntPtr source, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_webkit_user_content_filter_store_save webkit_user_content_filter_store_save = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_save>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_save"));

		public void Save(string identifier, GLib.Bytes source, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_identifier = GLib.Marshaller.StringToPtrGStrdup (identifier);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			webkit_user_content_filter_store_save(Handle, native_identifier, source == null ? IntPtr.Zero : source.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_identifier);
		}

		public void Save(string identifier, GLib.Bytes source) {
			Save (identifier, source, null, null);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_filter_store_save_finish(IntPtr raw, IntPtr _result, out IntPtr error);
		static d_webkit_user_content_filter_store_save_finish webkit_user_content_filter_store_save_finish = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_save_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_save_finish"));

		public unsafe WebKit.UserContentFilter SaveFinish(GLib.IAsyncResult _result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = webkit_user_content_filter_store_save_finish(Handle, _result == null ? IntPtr.Zero : ((_result is GLib.Object) ? (_result as GLib.Object).Handle : (_result as GLib.AsyncResultAdapter).Handle), out error);
			WebKit.UserContentFilter ret = WebKit.UserContentFilter.New (raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_user_content_filter_store_save_from_file(IntPtr raw, IntPtr identifier, IntPtr file, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);
		static d_webkit_user_content_filter_store_save_from_file webkit_user_content_filter_store_save_from_file = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_save_from_file>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_save_from_file"));

		public void SaveFromFile(string identifier, GLib.IFile file, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_identifier = GLib.Marshaller.StringToPtrGStrdup (identifier);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			webkit_user_content_filter_store_save_from_file(Handle, native_identifier, file == null ? IntPtr.Zero : ((file is GLib.Object) ? (file as GLib.Object).Handle : (file as GLib.FileAdapter).Handle), cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_identifier);
		}

		public void SaveFromFile(string identifier, GLib.IFile file) {
			SaveFromFile (identifier, file, null, null);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_user_content_filter_store_save_from_file_finish(IntPtr raw, IntPtr _result, out IntPtr error);
		static d_webkit_user_content_filter_store_save_from_file_finish webkit_user_content_filter_store_save_from_file_finish = FuncLoader.LoadFunction<d_webkit_user_content_filter_store_save_from_file_finish>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_user_content_filter_store_save_from_file_finish"));

		public unsafe WebKit.UserContentFilter SaveFromFileFinish(GLib.IAsyncResult _result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = webkit_user_content_filter_store_save_from_file_finish(Handle, _result == null ? IntPtr.Zero : ((_result is GLib.Object) ? (_result as GLib.Object).Handle : (_result as GLib.AsyncResultAdapter).Handle), out error);
			WebKit.UserContentFilter ret = WebKit.UserContentFilter.New (raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}


		static UserContentFilterStore ()
		{
			GtkSharp.WebkitGtkSharp.ObjectManager.Initialize ();
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