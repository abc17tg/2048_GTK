// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void InsecureContentDetectedHandler(object o, InsecureContentDetectedArgs args);

	public class InsecureContentDetectedArgs : GLib.SignalArgs {
		public WebKit.InsecureContentEvent Event{
			get {
				return (WebKit.InsecureContentEvent) Args [0];
			}
		}

	}
}
