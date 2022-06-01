// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextAdapter : GLib.GInterfaceAdapter, Atk.IText {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkTextIface {
			public GetTextNativeDelegate GetText;
			public GetTextAfterOffsetNativeDelegate GetTextAfterOffset;
			public GetTextAtOffsetNativeDelegate GetTextAtOffset;
			public GetCharacterAtOffsetNativeDelegate GetCharacterAtOffset;
			public GetTextBeforeOffsetNativeDelegate GetTextBeforeOffset;
			public GetCaretOffsetNativeDelegate GetCaretOffset;
			public GetRunAttributesNativeDelegate GetRunAttributes;
			public GetDefaultAttributesNativeDelegate GetDefaultAttributes;
			public GetCharacterExtentsNativeDelegate GetCharacterExtents;
			public GetCharacterCountNativeDelegate GetCharacterCount;
			public GetOffsetAtPointNativeDelegate GetOffsetAtPoint;
			public GetNSelectionsNativeDelegate GetNSelections;
			public GetSelectionNativeDelegate GetSelection;
			public AddSelectionNativeDelegate AddSelection;
			public RemoveSelectionNativeDelegate RemoveSelection;
			public SetSelectionNativeDelegate SetSelection;
			public SetCaretOffsetNativeDelegate SetCaretOffset;
			IntPtr TextChanged;
			IntPtr TextCaretMoved;
			IntPtr TextSelectionChanged;
			IntPtr TextAttributesChanged;
			public GetRangeExtentsNativeDelegate GetRangeExtents;
			public GetBoundedRangesNativeDelegate GetBoundedRanges;
			public GetStringAtOffsetNativeDelegate GetStringAtOffset;
		}

		static AtkTextIface iface;

		static TextAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (TextAdapter));
			iface.GetText = new GetTextNativeDelegate (GetText_cb);
			iface.GetTextAfterOffset = new GetTextAfterOffsetNativeDelegate (GetTextAfterOffset_cb);
			iface.GetTextAtOffset = new GetTextAtOffsetNativeDelegate (GetTextAtOffset_cb);
			iface.GetCharacterAtOffset = new GetCharacterAtOffsetNativeDelegate (GetCharacterAtOffset_cb);
			iface.GetTextBeforeOffset = new GetTextBeforeOffsetNativeDelegate (GetTextBeforeOffset_cb);
			iface.GetCaretOffset = new GetCaretOffsetNativeDelegate (GetCaretOffset_cb);
			iface.GetRunAttributes = new GetRunAttributesNativeDelegate (GetRunAttributes_cb);
			iface.GetDefaultAttributes = new GetDefaultAttributesNativeDelegate (GetDefaultAttributes_cb);
			iface.GetCharacterExtents = new GetCharacterExtentsNativeDelegate (GetCharacterExtents_cb);
			iface.GetCharacterCount = new GetCharacterCountNativeDelegate (GetCharacterCount_cb);
			iface.GetOffsetAtPoint = new GetOffsetAtPointNativeDelegate (GetOffsetAtPoint_cb);
			iface.GetNSelections = new GetNSelectionsNativeDelegate (GetNSelections_cb);
			iface.GetSelection = new GetSelectionNativeDelegate (GetSelection_cb);
			iface.AddSelection = new AddSelectionNativeDelegate (AddSelection_cb);
			iface.RemoveSelection = new RemoveSelectionNativeDelegate (RemoveSelection_cb);
			iface.SetSelection = new SetSelectionNativeDelegate (SetSelection_cb);
			iface.SetCaretOffset = new SetCaretOffsetNativeDelegate (SetCaretOffset_cb);
			iface.GetRangeExtents = new GetRangeExtentsNativeDelegate (GetRangeExtents_cb);
			iface.GetBoundedRanges = new GetBoundedRangesNativeDelegate (GetBoundedRanges_cb);
			iface.GetStringAtOffset = new GetStringAtOffsetNativeDelegate (GetStringAtOffset_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetTextNativeDelegate (IntPtr inst, int start_offset, int end_offset);

		static IntPtr GetText_cb (IntPtr inst, int start_offset, int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				string __result;
				__result = __obj.GetText (start_offset, end_offset);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetTextAfterOffsetNativeDelegate (IntPtr inst, int offset, int boundary_type, out int start_offset, out int end_offset);

		static IntPtr GetTextAfterOffset_cb (IntPtr inst, int offset, int boundary_type, out int start_offset, out int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				string __result;
				__result = __obj.GetTextAfterOffset (offset, (Atk.TextBoundary) boundary_type, out start_offset, out end_offset);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetTextAtOffsetNativeDelegate (IntPtr inst, int offset, int boundary_type, out int start_offset, out int end_offset);

		static IntPtr GetTextAtOffset_cb (IntPtr inst, int offset, int boundary_type, out int start_offset, out int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				string __result;
				__result = __obj.GetTextAtOffset (offset, (Atk.TextBoundary) boundary_type, out start_offset, out end_offset);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint GetCharacterAtOffsetNativeDelegate (IntPtr inst, int offset);

		static uint GetCharacterAtOffset_cb (IntPtr inst, int offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				char __result;
				__result = __obj.GetCharacterAtOffset (offset);
				return GLib.Marshaller.CharToGUnichar (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetTextBeforeOffsetNativeDelegate (IntPtr inst, int offset, int boundary_type, out int start_offset, out int end_offset);

		static IntPtr GetTextBeforeOffset_cb (IntPtr inst, int offset, int boundary_type, out int start_offset, out int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				string __result;
				__result = __obj.GetTextBeforeOffset (offset, (Atk.TextBoundary) boundary_type, out start_offset, out end_offset);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetCaretOffsetNativeDelegate (IntPtr inst);

		static int GetCaretOffset_cb (IntPtr inst)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				int __result;
				__result = __obj.CaretOffset;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetRunAttributesNativeDelegate (IntPtr inst, int offset, out int start_offset, out int end_offset);

		static IntPtr GetRunAttributes_cb (IntPtr inst, int offset, out int start_offset, out int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				Atk.Attribute[] __result;
				__result = __obj.GetRunAttributes (offset, out start_offset, out end_offset);
				return new GLib.SList(__result, typeof (Atk.Attribute), false, false) == null ? IntPtr.Zero : new GLib.SList(__result, typeof (Atk.Attribute), false, false).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetDefaultAttributesNativeDelegate (IntPtr inst);

		static IntPtr GetDefaultAttributes_cb (IntPtr inst)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				Atk.Attribute[] __result;
				__result = __obj.DefaultAttributes;
				return new GLib.SList(__result, typeof (Atk.Attribute), false, false) == null ? IntPtr.Zero : new GLib.SList(__result, typeof (Atk.Attribute), false, false).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetCharacterExtentsNativeDelegate (IntPtr inst, int offset, out int x, out int y, out int width, out int height, int coords);

		static void GetCharacterExtents_cb (IntPtr inst, int offset, out int x, out int y, out int width, out int height, int coords)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				__obj.GetCharacterExtents (offset, out x, out y, out width, out height, (Atk.CoordType) coords);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetCharacterCountNativeDelegate (IntPtr inst);

		static int GetCharacterCount_cb (IntPtr inst)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				int __result;
				__result = __obj.CharacterCount;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetOffsetAtPointNativeDelegate (IntPtr inst, int x, int y, int coords);

		static int GetOffsetAtPoint_cb (IntPtr inst, int x, int y, int coords)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				int __result;
				__result = __obj.GetOffsetAtPoint (x, y, (Atk.CoordType) coords);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNSelectionsNativeDelegate (IntPtr inst);

		static int GetNSelections_cb (IntPtr inst)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				int __result;
				__result = __obj.NSelections;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetSelectionNativeDelegate (IntPtr inst, int selection_num, out int start_offset, out int end_offset);

		static IntPtr GetSelection_cb (IntPtr inst, int selection_num, out int start_offset, out int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				string __result;
				__result = __obj.GetSelection (selection_num, out start_offset, out end_offset);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool AddSelectionNativeDelegate (IntPtr inst, int start_offset, int end_offset);

		static bool AddSelection_cb (IntPtr inst, int start_offset, int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				bool __result;
				__result = __obj.AddSelection (start_offset, end_offset);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RemoveSelectionNativeDelegate (IntPtr inst, int selection_num);

		static bool RemoveSelection_cb (IntPtr inst, int selection_num)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				bool __result;
				__result = __obj.RemoveSelection (selection_num);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetSelectionNativeDelegate (IntPtr inst, int selection_num, int start_offset, int end_offset);

		static bool SetSelection_cb (IntPtr inst, int selection_num, int start_offset, int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				bool __result;
				__result = __obj.SetSelection (selection_num, start_offset, end_offset);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetCaretOffsetNativeDelegate (IntPtr inst, int offset);

		static bool SetCaretOffset_cb (IntPtr inst, int offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				bool __result;
				__result = __obj.SetCaretOffset (offset);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetRangeExtentsNativeDelegate (IntPtr inst, int start_offset, int end_offset, int coord_type, IntPtr rect);

		static void GetRangeExtents_cb (IntPtr inst, int start_offset, int end_offset, int coord_type, IntPtr rect)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				Atk.TextRectangle myrect;
				__obj.GetRangeExtents (start_offset, end_offset, (Atk.CoordType) coord_type, out myrect);
				if (rect != IntPtr.Zero) System.Runtime.InteropServices.Marshal.StructureToPtr (myrect, rect, false);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetBoundedRangesNativeDelegate (IntPtr inst, IntPtr rect, int coord_type, int x_clip_type, int y_clip_type);

		static IntPtr GetBoundedRanges_cb (IntPtr inst, IntPtr rect, int coord_type, int x_clip_type, int y_clip_type)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				Atk.TextRange __result;
				__result = __obj.GetBoundedRanges (Atk.TextRectangle.New (rect), (Atk.CoordType) coord_type, (Atk.TextClipType) x_clip_type, (Atk.TextClipType) y_clip_type);
				return GLib.Marshaller.StructureToPtrAlloc (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStringAtOffsetNativeDelegate (IntPtr inst, int offset, int granularity, out int start_offset, out int end_offset);

		static IntPtr GetStringAtOffset_cb (IntPtr inst, int offset, int granularity, out int start_offset, out int end_offset)
		{
			try {
				ITextImplementor __obj = GLib.Object.GetObject (inst, false) as ITextImplementor;
				string __result;
				__result = __obj.GetStringAtOffset (offset, (Atk.TextGranularity) granularity, out start_offset, out end_offset);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			AtkTextIface native_iface = (AtkTextIface) Marshal.PtrToStructure (ifaceptr, typeof (AtkTextIface));
			native_iface.GetText = iface.GetText;
			native_iface.GetTextAfterOffset = iface.GetTextAfterOffset;
			native_iface.GetTextAtOffset = iface.GetTextAtOffset;
			native_iface.GetCharacterAtOffset = iface.GetCharacterAtOffset;
			native_iface.GetTextBeforeOffset = iface.GetTextBeforeOffset;
			native_iface.GetCaretOffset = iface.GetCaretOffset;
			native_iface.GetRunAttributes = iface.GetRunAttributes;
			native_iface.GetDefaultAttributes = iface.GetDefaultAttributes;
			native_iface.GetCharacterExtents = iface.GetCharacterExtents;
			native_iface.GetCharacterCount = iface.GetCharacterCount;
			native_iface.GetOffsetAtPoint = iface.GetOffsetAtPoint;
			native_iface.GetNSelections = iface.GetNSelections;
			native_iface.GetSelection = iface.GetSelection;
			native_iface.AddSelection = iface.AddSelection;
			native_iface.RemoveSelection = iface.RemoveSelection;
			native_iface.SetSelection = iface.SetSelection;
			native_iface.SetCaretOffset = iface.SetCaretOffset;
			native_iface.GetRangeExtents = iface.GetRangeExtents;
			native_iface.GetBoundedRanges = iface.GetBoundedRanges;
			native_iface.GetStringAtOffset = iface.GetStringAtOffset;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public TextAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public TextAdapter (ITextImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public TextAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_type();
		static d_atk_text_get_type atk_text_get_type = FuncLoader.LoadFunction<d_atk_text_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_type"));

		private static GLib.GType _gtype = new GLib.GType (atk_text_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IText GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IText GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is ITextImplementor)
				return new TextAdapter (obj as ITextImplementor);
			else if (obj as IText == null)
				return new TextAdapter (obj.Handle);
			else
				return obj as IText;
		}

		public ITextImplementor Implementor {
			get {
				return implementor as ITextImplementor;
			}
		}

		[GLib.Signal("text_selection_changed")]
		public event System.EventHandler TextSelectionChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("text_selection_changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("text_selection_changed", value);
			}
		}

		[GLib.Signal("text_caret_moved")]
		public event Atk.TextCaretMovedHandler TextCaretMoved {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("text_caret_moved", value, typeof (Atk.TextCaretMovedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("text_caret_moved", value);
			}
		}

		[GLib.Signal("text_insert")]
		public event Atk.TextInsertHandler TextInsert {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("text_insert", value, typeof (Atk.TextInsertArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("text_insert", value);
			}
		}

		[GLib.Signal("text_remove")]
		public event Atk.TextRemoveHandler TextRemove {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("text_remove", value, typeof (Atk.TextRemoveArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("text_remove", value);
			}
		}

		[GLib.Signal("text_attributes_changed")]
		public event System.EventHandler TextAttributesChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("text_attributes_changed", value);
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("text_attributes_changed", value);
			}
		}

		[GLib.Signal("text_changed")]
		public event Atk.TextChangedHandler TextChanged {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("text_changed", value, typeof (Atk.TextChangedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("text_changed", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_text_add_selection(IntPtr raw, int start_offset, int end_offset);
		static d_atk_text_add_selection atk_text_add_selection = FuncLoader.LoadFunction<d_atk_text_add_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_add_selection"));

		public bool AddSelection(int start_offset, int end_offset) {
			bool raw_ret = atk_text_add_selection(Handle, start_offset, end_offset);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_text_attribute_for_name(IntPtr name);
		static d_atk_text_attribute_for_name atk_text_attribute_for_name = FuncLoader.LoadFunction<d_atk_text_attribute_for_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_attribute_for_name"));

		public static Atk.TextAttribute AttributeForName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = atk_text_attribute_for_name(native_name);
			Atk.TextAttribute ret = (Atk.TextAttribute) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_attribute_get_name(int attr);
		static d_atk_text_attribute_get_name atk_text_attribute_get_name = FuncLoader.LoadFunction<d_atk_text_attribute_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_attribute_get_name"));

		public static string AttributeGetName(Atk.TextAttribute attr) {
			IntPtr raw_ret = atk_text_attribute_get_name((int) attr);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_attribute_get_value(int attr, int index_);
		static d_atk_text_attribute_get_value atk_text_attribute_get_value = FuncLoader.LoadFunction<d_atk_text_attribute_get_value>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_attribute_get_value"));

		public static string AttributeGetValue(Atk.TextAttribute attr, int index_) {
			IntPtr raw_ret = atk_text_attribute_get_value((int) attr, index_);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_text_attribute_register(IntPtr name);
		static d_atk_text_attribute_register atk_text_attribute_register = FuncLoader.LoadFunction<d_atk_text_attribute_register>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_attribute_register"));

		public static Atk.TextAttribute AttributeRegister(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = atk_text_attribute_register(native_name);
			Atk.TextAttribute ret = (Atk.TextAttribute) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_text_free_ranges(IntPtr ranges);
		static d_atk_text_free_ranges atk_text_free_ranges = FuncLoader.LoadFunction<d_atk_text_free_ranges>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_free_ranges"));

		public static void FreeRanges(Atk.TextRange ranges) {
			IntPtr native_ranges = GLib.Marshaller.StructureToPtrAlloc (ranges);
			atk_text_free_ranges(native_ranges);
			Marshal.FreeHGlobal (native_ranges);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_bounded_ranges(IntPtr raw, IntPtr rect, int coord_type, int x_clip_type, int y_clip_type);
		static d_atk_text_get_bounded_ranges atk_text_get_bounded_ranges = FuncLoader.LoadFunction<d_atk_text_get_bounded_ranges>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_bounded_ranges"));

		public Atk.TextRange GetBoundedRanges(Atk.TextRectangle rect, Atk.CoordType coord_type, Atk.TextClipType x_clip_type, Atk.TextClipType y_clip_type) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			IntPtr raw_ret = atk_text_get_bounded_ranges(Handle, native_rect, (int) coord_type, (int) x_clip_type, (int) y_clip_type);
			Atk.TextRange ret = Atk.TextRange.New (raw_ret);
			Marshal.FreeHGlobal (native_rect);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_text_get_caret_offset(IntPtr raw);
		static d_atk_text_get_caret_offset atk_text_get_caret_offset = FuncLoader.LoadFunction<d_atk_text_get_caret_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_caret_offset"));

		public int CaretOffset { 
			get {
				int raw_ret = atk_text_get_caret_offset(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_atk_text_get_character_at_offset(IntPtr raw, int offset);
		static d_atk_text_get_character_at_offset atk_text_get_character_at_offset = FuncLoader.LoadFunction<d_atk_text_get_character_at_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_character_at_offset"));

		public char GetCharacterAtOffset(int offset) {
			uint raw_ret = atk_text_get_character_at_offset(Handle, offset);
			char ret = GLib.Marshaller.GUnicharToChar (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_text_get_character_count(IntPtr raw);
		static d_atk_text_get_character_count atk_text_get_character_count = FuncLoader.LoadFunction<d_atk_text_get_character_count>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_character_count"));

		public int CharacterCount { 
			get {
				int raw_ret = atk_text_get_character_count(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_text_get_character_extents(IntPtr raw, int offset, out int x, out int y, out int width, out int height, int coords);
		static d_atk_text_get_character_extents atk_text_get_character_extents = FuncLoader.LoadFunction<d_atk_text_get_character_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_character_extents"));

		public void GetCharacterExtents(int offset, out int x, out int y, out int width, out int height, Atk.CoordType coords) {
			atk_text_get_character_extents(Handle, offset, out x, out y, out width, out height, (int) coords);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_default_attributes(IntPtr raw);
		static d_atk_text_get_default_attributes atk_text_get_default_attributes = FuncLoader.LoadFunction<d_atk_text_get_default_attributes>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_default_attributes"));

		public Atk.Attribute[] DefaultAttributes { 
			get {
				IntPtr raw_ret = atk_text_get_default_attributes(Handle);
				Atk.Attribute[] ret = GLib.Marshaller.SListPtrToArray<Atk.Attribute, Atk.Attribute> (raw_ret, false, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_text_get_n_selections(IntPtr raw);
		static d_atk_text_get_n_selections atk_text_get_n_selections = FuncLoader.LoadFunction<d_atk_text_get_n_selections>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_n_selections"));

		public int NSelections { 
			get {
				int raw_ret = atk_text_get_n_selections(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_text_get_offset_at_point(IntPtr raw, int x, int y, int coords);
		static d_atk_text_get_offset_at_point atk_text_get_offset_at_point = FuncLoader.LoadFunction<d_atk_text_get_offset_at_point>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_offset_at_point"));

		public int GetOffsetAtPoint(int x, int y, Atk.CoordType coords) {
			int raw_ret = atk_text_get_offset_at_point(Handle, x, y, (int) coords);
			int ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_text_get_range_extents(IntPtr raw, int start_offset, int end_offset, int coord_type, IntPtr rect);
		static d_atk_text_get_range_extents atk_text_get_range_extents = FuncLoader.LoadFunction<d_atk_text_get_range_extents>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_range_extents"));

		public Atk.TextRectangle GetRangeExtents(int start_offset, int end_offset, Atk.CoordType coord_type) {
			Atk.TextRectangle rect;
			IntPtr native_rect = Marshal.AllocHGlobal (Marshal.SizeOf<Atk.TextRectangle>());
			atk_text_get_range_extents(Handle, start_offset, end_offset, (int) coord_type, native_rect);
			rect = Atk.TextRectangle.New (native_rect);
			Marshal.FreeHGlobal (native_rect);
			return rect;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_run_attributes(IntPtr raw, int offset, out int start_offset, out int end_offset);
		static d_atk_text_get_run_attributes atk_text_get_run_attributes = FuncLoader.LoadFunction<d_atk_text_get_run_attributes>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_run_attributes"));

		public Atk.Attribute[] GetRunAttributes(int offset, out int start_offset, out int end_offset) {
			IntPtr raw_ret = atk_text_get_run_attributes(Handle, offset, out start_offset, out end_offset);
			Atk.Attribute[] ret = GLib.Marshaller.SListPtrToArray<Atk.Attribute, Atk.Attribute> (raw_ret, false, false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_selection(IntPtr raw, int selection_num, out int start_offset, out int end_offset);
		static d_atk_text_get_selection atk_text_get_selection = FuncLoader.LoadFunction<d_atk_text_get_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_selection"));

		public string GetSelection(int selection_num, out int start_offset, out int end_offset) {
			IntPtr raw_ret = atk_text_get_selection(Handle, selection_num, out start_offset, out end_offset);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_string_at_offset(IntPtr raw, int offset, int granularity, out int start_offset, out int end_offset);
		static d_atk_text_get_string_at_offset atk_text_get_string_at_offset = FuncLoader.LoadFunction<d_atk_text_get_string_at_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_string_at_offset"));

		public string GetStringAtOffset(int offset, Atk.TextGranularity granularity, out int start_offset, out int end_offset) {
			IntPtr raw_ret = atk_text_get_string_at_offset(Handle, offset, (int) granularity, out start_offset, out end_offset);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_text(IntPtr raw, int start_offset, int end_offset);
		static d_atk_text_get_text atk_text_get_text = FuncLoader.LoadFunction<d_atk_text_get_text>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_text"));

		public string GetText(int start_offset, int end_offset) {
			IntPtr raw_ret = atk_text_get_text(Handle, start_offset, end_offset);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_text_after_offset(IntPtr raw, int offset, int boundary_type, out int start_offset, out int end_offset);
		static d_atk_text_get_text_after_offset atk_text_get_text_after_offset = FuncLoader.LoadFunction<d_atk_text_get_text_after_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_text_after_offset"));

		[Obsolete]
		public string GetTextAfterOffset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset) {
			IntPtr raw_ret = atk_text_get_text_after_offset(Handle, offset, (int) boundary_type, out start_offset, out end_offset);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_text_at_offset(IntPtr raw, int offset, int boundary_type, out int start_offset, out int end_offset);
		static d_atk_text_get_text_at_offset atk_text_get_text_at_offset = FuncLoader.LoadFunction<d_atk_text_get_text_at_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_text_at_offset"));

		[Obsolete]
		public string GetTextAtOffset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset) {
			IntPtr raw_ret = atk_text_get_text_at_offset(Handle, offset, (int) boundary_type, out start_offset, out end_offset);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_text_get_text_before_offset(IntPtr raw, int offset, int boundary_type, out int start_offset, out int end_offset);
		static d_atk_text_get_text_before_offset atk_text_get_text_before_offset = FuncLoader.LoadFunction<d_atk_text_get_text_before_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_get_text_before_offset"));

		[Obsolete]
		public string GetTextBeforeOffset(int offset, Atk.TextBoundary boundary_type, out int start_offset, out int end_offset) {
			IntPtr raw_ret = atk_text_get_text_before_offset(Handle, offset, (int) boundary_type, out start_offset, out end_offset);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_text_remove_selection(IntPtr raw, int selection_num);
		static d_atk_text_remove_selection atk_text_remove_selection = FuncLoader.LoadFunction<d_atk_text_remove_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_remove_selection"));

		public bool RemoveSelection(int selection_num) {
			bool raw_ret = atk_text_remove_selection(Handle, selection_num);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_text_set_caret_offset(IntPtr raw, int offset);
		static d_atk_text_set_caret_offset atk_text_set_caret_offset = FuncLoader.LoadFunction<d_atk_text_set_caret_offset>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_set_caret_offset"));

		public bool SetCaretOffset(int offset) {
			bool raw_ret = atk_text_set_caret_offset(Handle, offset);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_text_set_selection(IntPtr raw, int selection_num, int start_offset, int end_offset);
		static d_atk_text_set_selection atk_text_set_selection = FuncLoader.LoadFunction<d_atk_text_set_selection>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_text_set_selection"));

		public bool SetSelection(int selection_num, int start_offset, int end_offset) {
			bool raw_ret = atk_text_set_selection(Handle, selection_num, start_offset, end_offset);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
