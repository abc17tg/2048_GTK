// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSource {

	using System;

	public delegate void SmartHomeEndFiredHandler(object o, SmartHomeEndFiredArgs args);

	public class SmartHomeEndFiredArgs : GLib.SignalArgs {
		public Gtk.TextIter P0{
			get {
				return (Gtk.TextIter) Args [0];
			}
		}

		public int P1{
			get {
				return (int) Args [1];
			}
		}

	}
}