// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

	public delegate void ActivatedHandler(object o, ActivatedArgs args);

	public class ActivatedArgs : GLib.SignalArgs {
		public Gtk.TextIter Iter{
			get {
				return (Gtk.TextIter) Args [0];
			}
		}

		public Gdk.Rectangle Area{
			get {
				return (Gdk.Rectangle) Args [1];
			}
		}

		public Gdk.Event Event{
			get {
				return (Gdk.Event) Args [2];
			}
		}

	}
}
