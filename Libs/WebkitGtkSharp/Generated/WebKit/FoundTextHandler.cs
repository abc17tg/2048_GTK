// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void FoundTextHandler(object o, FoundTextArgs args);

	public class FoundTextArgs : GLib.SignalArgs {
		public uint MatchCount{
			get {
				return (uint) Args [0];
			}
		}

	}
}
