// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void ScriptDialogHandler(object o, ScriptDialogArgs args);

	public class ScriptDialogArgs : GLib.SignalArgs {
		public WebKit.ScriptDialog Dialog{
			get {
				return (WebKit.ScriptDialog) Args [0];
			}
		}

	}
}
