// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void DriveDisconnectedHandler(object o, DriveDisconnectedArgs args);

	public class DriveDisconnectedArgs : GLib.SignalArgs {
		public GLib.IDrive Drive{
			get {
				return GLib.DriveAdapter.GetObject (Args [0] as GLib.Object);
			}
		}

	}
}