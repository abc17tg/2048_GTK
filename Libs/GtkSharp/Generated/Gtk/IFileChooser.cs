// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

#region Autogenerated code
	public partial interface IFileChooser : GLib.IWrapper {

		event System.EventHandler UpdatePreview;
		event System.EventHandler CurrentFolderChanged;
		event System.EventHandler SelectionChanged;
		event Gtk.ConfirmOverwriteHandler ConfirmOverwrite;
		event System.EventHandler FileActivated;
		void AddChoice(string id, string label, string options, string option_labels);
		void AddFilter(Gtk.FileFilter filter);
		bool AddShortcutFolder(string folder);
		bool AddShortcutFolderUri(string uri);
		string GetChoice(string id);
		string CurrentFolder { 
			get;
		}
		GLib.IFile CurrentFolderFile { 
			get;
		}
		string CurrentFolderUri { 
			get;
		}
		string CurrentName { 
			get; set;
		}
		GLib.IFile File { 
			get;
		}
		string Filename { 
			get;
		}
		string[] Filenames { 
			get;
		}
		GLib.IFile[] Files { 
			get;
		}
		GLib.IFile PreviewFile { 
			get;
		}
		string PreviewFilename { 
			get;
		}
		string PreviewUri { 
			get;
		}
		string Uri { 
			get;
		}
		string[] Uris { 
			get;
		}
		Gtk.FileFilter[] Filters { 
			get;
		}
		string[] ShortcutFolderUris { 
			get;
		}
		string[] ShortcutFolders { 
			get;
		}
		void RemoveChoice(string id);
		void RemoveFilter(Gtk.FileFilter filter);
		bool RemoveShortcutFolder(string folder);
		bool RemoveShortcutFolderUri(string uri);
		void SelectAll();
		bool SelectFile(GLib.IFile file);
		bool SelectFilename(string filename);
		bool SelectUri(string uri);
		void SetChoice(string id, string option);
		bool SetCurrentFolder(string filename);
		bool SetCurrentFolderFile(GLib.IFile file);
		bool SetCurrentFolderUri(string uri);
		bool SetFile(GLib.IFile file);
		bool SetFilename(string filename);
		bool SetUri(string uri);
		void UnselectAll();
		void UnselectFile(GLib.IFile file);
		void UnselectFilename(string filename);
		void UnselectUri(string uri);
		Gtk.FileChooserAction Action {
			get; set;
		}
		Gtk.FileFilter Filter {
			get; set;
		}
		bool LocalOnly {
			get; set;
		}
		Gtk.Widget PreviewWidget {
			get; set;
		}
		bool PreviewWidgetActive {
			get; set;
		}
		bool UsePreviewLabel {
			get; set;
		}
		Gtk.Widget ExtraWidget {
			get; set;
		}
		bool SelectMultiple {
			get; set;
		}
		bool ShowHidden {
			get; set;
		}
		bool DoOverwriteConfirmation {
			get; set;
		}
		bool CreateFolders {
			get; set;
		}
	}
#endregion
}
