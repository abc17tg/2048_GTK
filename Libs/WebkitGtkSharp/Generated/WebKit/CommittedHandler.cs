// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void CommittedHandler(object o, CommittedArgs args);

	public class CommittedArgs : GLib.SignalArgs {
		public string Text{
			get {
				return (string) Args [0];
			}
		}

	}
}
