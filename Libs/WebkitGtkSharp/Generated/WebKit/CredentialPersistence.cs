// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (WebKit.CredentialPersistenceGType))]
	public enum CredentialPersistence {

		None = 0,
		ForSession = 1,
		Permanent = 2,
	}

	internal class CredentialPersistenceGType {
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_credential_persistence_get_type();
		static d_webkit_credential_persistence_get_type webkit_credential_persistence_get_type = FuncLoader.LoadFunction<d_webkit_credential_persistence_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_credential_persistence_get_type"));

		public static GLib.GType GType {
			get {
				return new GLib.GType (webkit_credential_persistence_get_type ());
			}
		}
	}
#endregion
}
