// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void ScriptMessageReceivedHandler(object o, ScriptMessageReceivedArgs args);

	public class ScriptMessageReceivedArgs : GLib.SignalArgs {
		public WebKit.JavascriptResult JsResult{
			get {
				return (WebKit.JavascriptResult) Args [0];
			}
		}

	}
}
