// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void FaviconChangedHandler(object o, FaviconChangedArgs args);

	public class FaviconChangedArgs : GLib.SignalArgs {
		public string PageUri{
			get {
				return (string) Args [0];
			}
		}

		public string FaviconUri{
			get {
				return (string) Args [1];
			}
		}

	}
}
