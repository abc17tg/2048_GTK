// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;

	public delegate void SubmitFormHandler(object o, SubmitFormArgs args);

	public class SubmitFormArgs : GLib.SignalArgs {
		public WebKit.FormSubmissionRequest Request{
			get {
				return (WebKit.FormSubmissionRequest) Args [0];
			}
		}

	}
}
