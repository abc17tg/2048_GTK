// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

#region Autogenerated code
	public partial interface IText : GLib.IWrapper {

		event System.EventHandler TextSelectionChanged;
		event Atk.TextCaretMovedHandler TextCaretMoved;
		event Atk.TextInsertHandler TextInsert;
		event Atk.TextRemoveHandler TextRemove;
		event System.EventHandler TextAttributesChanged;
		event Atk.TextChangedHandler TextChanged;
		bool AddSelection(int start_offset, int end_offset);
		Atk.TextRange GetBoundedRanges(Atk.TextRectangle rect, Atk.CoordType coord_type, Atk.TextClipType x_clip_type, Atk.TextClipType y_clip_type);
		int CaretOffset { 
			get;
		}
		char GetCharacterAtOffset(int offset);
		int CharacterCount { 
			get;
		}
		void GetCharacterExtents(int offset, out int x, out int y, out int width, out int height, Atk.CoordType coords);
		Atk.Attribute[] DefaultAttributes { 
			get;
		}
		int NSelections { 
			get;
		}
		int GetOffsetAtPoint(int x, int y, Atk.CoordType coords);
		Atk.TextRectangle GetRangeExtents(int start_offset, int end_offset, Atk.CoordType coord_type);
		Atk.Attribute[] GetRunAttributes(int offset, out int start_offset, out int end_offset);
		string GetSelection(int selection_num, out int start_offset, out int end_offset);
		string GetStringAtOffset(int offset, Atk.TextGranularity granularity, out int start_offset, out int end_offset);
		string GetText(int start_offset, int end_offset);
		string GetTextAfterOffset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		string GetTextAtOffset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		string GetTextBeforeOffset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		bool RemoveSelection(int selection_num);
		bool SetCaretOffset(int offset);
		bool SetSelection(int selection_num, int start_offset, int end_offset);
	}

	[GLib.GInterface (typeof (TextAdapter))]
	public partial interface ITextImplementor : GLib.IWrapper {

		string GetText (int start_offset, int end_offset);
		string GetTextAfterOffset (int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		string GetTextAtOffset (int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		char GetCharacterAtOffset (int offset);
		string GetTextBeforeOffset (int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset);
		int CaretOffset { get; }
		Atk.Attribute[] GetRunAttributes (int offset, out int start_offset, out int end_offset);
		Atk.Attribute[] DefaultAttributes { get; }
		void GetCharacterExtents (int offset, out int x, out int y, out int width, out int height, Atk.CoordType coords);
		int CharacterCount { get; }
		int GetOffsetAtPoint (int x, int y, Atk.CoordType coords);
		int NSelections { get; }
		string GetSelection (int selection_num, out int start_offset, out int end_offset);
		bool AddSelection (int start_offset, int end_offset);
		bool RemoveSelection (int selection_num);
		bool SetSelection (int selection_num, int start_offset, int end_offset);
		bool SetCaretOffset (int offset);
		void GetRangeExtents (int start_offset, int end_offset, Atk.CoordType coord_type, out Atk.TextRectangle rect);
		Atk.TextRange GetBoundedRanges (Atk.TextRectangle rect, Atk.CoordType coord_type, Atk.TextClipType x_clip_type, Atk.TextClipType y_clip_type);
		string GetStringAtOffset (int offset, Atk.TextGranularity granularity, out int start_offset, out int end_offset);
	}
#endregion
}
