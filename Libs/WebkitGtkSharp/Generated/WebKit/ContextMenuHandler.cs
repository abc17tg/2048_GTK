// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void ContextMenuHandler(object o, ContextMenuArgs args);

	public class ContextMenuArgs : GLib.SignalArgs {
		public WebKit.ContextMenu ContextMenu{
			get {
				return (WebKit.ContextMenu) Args [0];
			}
		}

		public Gdk.Event Event{
			get {
				return (Gdk.Event) Args [1];
			}
		}

		public WebKit.HitTestResult HitTestResult{
			get {
				return (WebKit.HitTestResult) Args [2];
			}
		}

	}
}