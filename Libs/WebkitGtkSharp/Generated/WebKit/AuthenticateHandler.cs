// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void AuthenticateHandler(object o, AuthenticateArgs args);

	public class AuthenticateArgs : GLib.SignalArgs {
		public WebKit.AuthenticationRequest Request{
			get {
				return (WebKit.AuthenticationRequest) Args [0];
			}
		}

	}
}
