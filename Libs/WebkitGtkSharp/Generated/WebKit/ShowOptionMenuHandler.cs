// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void ShowOptionMenuHandler(object o, ShowOptionMenuArgs args);

	public class ShowOptionMenuArgs : GLib.SignalArgs {
		public WebKit.OptionMenu Object{
			get {
				return (WebKit.OptionMenu) Args [0];
			}
		}

		public Gdk.Event P0{
			get {
				return (Gdk.Event) Args [1];
			}
		}

		public Gdk.Rectangle P1{
			get {
				return (Gdk.Rectangle) Args [2];
			}
		}

	}
}
