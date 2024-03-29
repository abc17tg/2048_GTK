// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

#region Autogenerated code
	public partial interface IScrollable : GLib.IWrapper {

		bool GetBorder(out Gtk.Border border);
		Gtk.Adjustment Hadjustment {
			get; set;
		}
		Gtk.Adjustment Vadjustment {
			get; set;
		}
		Gtk.ScrollablePolicy HscrollPolicy {
			get; set;
		}
		Gtk.ScrollablePolicy VscrollPolicy {
			get; set;
		}
	}

	[GLib.GInterface (typeof (ScrollableAdapter))]
	public partial interface IScrollableImplementor : GLib.IWrapper {

		bool GetBorder (out Gtk.Border border);
		[GLib.Property ("hadjustment")]
		Gtk.Adjustment Hadjustment {
			get; set;
		}
		[GLib.Property ("vadjustment")]
		Gtk.Adjustment Vadjustment {
			get; set;
		}
		[GLib.Property ("hscroll-policy")]
		Gtk.ScrollablePolicy HscrollPolicy {
			get; set;
		}
		[GLib.Property ("vscroll-policy")]
		Gtk.ScrollablePolicy VscrollPolicy {
			get; set;
		}
	}
#endregion
}
