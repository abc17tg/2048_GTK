// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

	public delegate void SourceMarkUpdatedHandler(object o, SourceMarkUpdatedArgs args);

	public class SourceMarkUpdatedArgs : GLib.SignalArgs {
		public Gtk.TextMark P0{
			get {
				return (Gtk.TextMark) Args [0];
			}
		}

	}
}
