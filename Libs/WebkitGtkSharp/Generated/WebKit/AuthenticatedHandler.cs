// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void AuthenticatedHandler(object o, AuthenticatedArgs args);

	public class AuthenticatedArgs : GLib.SignalArgs {
		public WebKit.Credential Credential{
			get {
				return (WebKit.Credential) Args [0];
			}
		}

	}
}
