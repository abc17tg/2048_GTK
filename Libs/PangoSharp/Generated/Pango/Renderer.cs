// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class Renderer : GLib.Object {

		public Renderer (IntPtr raw) : base(raw) {}

		protected Renderer() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_renderer_get_matrix(IntPtr raw);
		static d_pango_renderer_get_matrix pango_renderer_get_matrix = FuncLoader.LoadFunction<d_pango_renderer_get_matrix>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_get_matrix"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_set_matrix(IntPtr raw, IntPtr value);
		static d_pango_renderer_set_matrix pango_renderer_set_matrix = FuncLoader.LoadFunction<d_pango_renderer_set_matrix>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_set_matrix"));

		public Pango.Matrix Matrix {
			get  {
				IntPtr raw_ret = pango_renderer_get_matrix(Handle);
				Pango.Matrix ret = Pango.Matrix.New (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				pango_renderer_set_matrix(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		static DrawGlyphsNativeDelegate DrawGlyphs_cb_delegate;
		static DrawGlyphsNativeDelegate DrawGlyphsVMCallback {
			get {
				if (DrawGlyphs_cb_delegate == null)
					DrawGlyphs_cb_delegate = new DrawGlyphsNativeDelegate (DrawGlyphs_cb);
				return DrawGlyphs_cb_delegate;
			}
		}

		static void OverrideDrawGlyphs (GLib.GType gtype)
		{
			OverrideDrawGlyphs (gtype, DrawGlyphsVMCallback);
		}

		static void OverrideDrawGlyphs (GLib.GType gtype, DrawGlyphsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_glyphs"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawGlyphsNativeDelegate (IntPtr inst, IntPtr font, IntPtr glyphs, int x, int y);

		static void DrawGlyphs_cb (IntPtr inst, IntPtr font, IntPtr glyphs, int x, int y)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawGlyphs (GLib.Object.GetObject(font) as Pango.Font, glyphs == IntPtr.Zero ? null : (Pango.GlyphString) GLib.Opaque.GetOpaque (glyphs, typeof (Pango.GlyphString), false), x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawGlyphs")]
		protected virtual void OnDrawGlyphs (Pango.Font font, Pango.GlyphString glyphs, int x, int y)
		{
			InternalDrawGlyphs (font, glyphs, x, y);
		}

		private void InternalDrawGlyphs (Pango.Font font, Pango.GlyphString glyphs, int x, int y)
		{
			DrawGlyphsNativeDelegate unmanaged = class_abi.BaseOverride<DrawGlyphsNativeDelegate>(this.LookupGType(), "draw_glyphs");
			if (unmanaged == null) return;

			unmanaged (this.Handle, font == null ? IntPtr.Zero : font.Handle, glyphs == null ? IntPtr.Zero : glyphs.Handle, x, y);
		}

		static DrawRectangleNativeDelegate DrawRectangle_cb_delegate;
		static DrawRectangleNativeDelegate DrawRectangleVMCallback {
			get {
				if (DrawRectangle_cb_delegate == null)
					DrawRectangle_cb_delegate = new DrawRectangleNativeDelegate (DrawRectangle_cb);
				return DrawRectangle_cb_delegate;
			}
		}

		static void OverrideDrawRectangle (GLib.GType gtype)
		{
			OverrideDrawRectangle (gtype, DrawRectangleVMCallback);
		}

		static void OverrideDrawRectangle (GLib.GType gtype, DrawRectangleNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_rectangle"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawRectangleNativeDelegate (IntPtr inst, int part, int x, int y, int width, int height);

		static void DrawRectangle_cb (IntPtr inst, int part, int x, int y, int width, int height)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawRectangle ((Pango.RenderPart) part, x, y, width, height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawRectangle")]
		protected virtual void OnDrawRectangle (Pango.RenderPart part, int x, int y, int width, int height)
		{
			InternalDrawRectangle (part, x, y, width, height);
		}

		private void InternalDrawRectangle (Pango.RenderPart part, int x, int y, int width, int height)
		{
			DrawRectangleNativeDelegate unmanaged = class_abi.BaseOverride<DrawRectangleNativeDelegate>(this.LookupGType(), "draw_rectangle");
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) part, x, y, width, height);
		}

		static DrawErrorUnderlineNativeDelegate DrawErrorUnderline_cb_delegate;
		static DrawErrorUnderlineNativeDelegate DrawErrorUnderlineVMCallback {
			get {
				if (DrawErrorUnderline_cb_delegate == null)
					DrawErrorUnderline_cb_delegate = new DrawErrorUnderlineNativeDelegate (DrawErrorUnderline_cb);
				return DrawErrorUnderline_cb_delegate;
			}
		}

		static void OverrideDrawErrorUnderline (GLib.GType gtype)
		{
			OverrideDrawErrorUnderline (gtype, DrawErrorUnderlineVMCallback);
		}

		static void OverrideDrawErrorUnderline (GLib.GType gtype, DrawErrorUnderlineNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_error_underline"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawErrorUnderlineNativeDelegate (IntPtr inst, int x, int y, int width, int height);

		static void DrawErrorUnderline_cb (IntPtr inst, int x, int y, int width, int height)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawErrorUnderline (x, y, width, height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawErrorUnderline")]
		protected virtual void OnDrawErrorUnderline (int x, int y, int width, int height)
		{
			InternalDrawErrorUnderline (x, y, width, height);
		}

		private void InternalDrawErrorUnderline (int x, int y, int width, int height)
		{
			DrawErrorUnderlineNativeDelegate unmanaged = class_abi.BaseOverride<DrawErrorUnderlineNativeDelegate>(this.LookupGType(), "draw_error_underline");
			if (unmanaged == null) return;

			unmanaged (this.Handle, x, y, width, height);
		}

		static DrawShapeNativeDelegate DrawShape_cb_delegate;
		static DrawShapeNativeDelegate DrawShapeVMCallback {
			get {
				if (DrawShape_cb_delegate == null)
					DrawShape_cb_delegate = new DrawShapeNativeDelegate (DrawShape_cb);
				return DrawShape_cb_delegate;
			}
		}

		static void OverrideDrawShape (GLib.GType gtype)
		{
			OverrideDrawShape (gtype, DrawShapeVMCallback);
		}

		static void OverrideDrawShape (GLib.GType gtype, DrawShapeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_shape"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawShapeNativeDelegate (IntPtr inst, IntPtr attr, int x, int y);

		static void DrawShape_cb (IntPtr inst, IntPtr attr, int x, int y)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawShape (Pango.Attribute.GetAttribute (attr), x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawShape")]
		protected virtual void OnDrawShape (Pango.Attribute attr, int x, int y)
		{
			InternalDrawShape (attr, x, y);
		}

		private void InternalDrawShape (Pango.Attribute attr, int x, int y)
		{
			DrawShapeNativeDelegate unmanaged = class_abi.BaseOverride<DrawShapeNativeDelegate>(this.LookupGType(), "draw_shape");
			if (unmanaged == null) return;

			unmanaged (this.Handle, attr.Handle, x, y);
		}

		static DrawTrapezoidNativeDelegate DrawTrapezoid_cb_delegate;
		static DrawTrapezoidNativeDelegate DrawTrapezoidVMCallback {
			get {
				if (DrawTrapezoid_cb_delegate == null)
					DrawTrapezoid_cb_delegate = new DrawTrapezoidNativeDelegate (DrawTrapezoid_cb);
				return DrawTrapezoid_cb_delegate;
			}
		}

		static void OverrideDrawTrapezoid (GLib.GType gtype)
		{
			OverrideDrawTrapezoid (gtype, DrawTrapezoidVMCallback);
		}

		static void OverrideDrawTrapezoid (GLib.GType gtype, DrawTrapezoidNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_trapezoid"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawTrapezoidNativeDelegate (IntPtr inst, int part, double y1_, double x11, double x21, double y2, double x12, double x22);

		static void DrawTrapezoid_cb (IntPtr inst, int part, double y1_, double x11, double x21, double y2, double x12, double x22)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawTrapezoid ((Pango.RenderPart) part, y1_, x11, x21, y2, x12, x22);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawTrapezoid")]
		protected virtual void OnDrawTrapezoid (Pango.RenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22)
		{
			InternalDrawTrapezoid (part, y1_, x11, x21, y2, x12, x22);
		}

		private void InternalDrawTrapezoid (Pango.RenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22)
		{
			DrawTrapezoidNativeDelegate unmanaged = class_abi.BaseOverride<DrawTrapezoidNativeDelegate>(this.LookupGType(), "draw_trapezoid");
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) part, y1_, x11, x21, y2, x12, x22);
		}

		static DrawGlyphNativeDelegate DrawGlyph_cb_delegate;
		static DrawGlyphNativeDelegate DrawGlyphVMCallback {
			get {
				if (DrawGlyph_cb_delegate == null)
					DrawGlyph_cb_delegate = new DrawGlyphNativeDelegate (DrawGlyph_cb);
				return DrawGlyph_cb_delegate;
			}
		}

		static void OverrideDrawGlyph (GLib.GType gtype)
		{
			OverrideDrawGlyph (gtype, DrawGlyphVMCallback);
		}

		static void OverrideDrawGlyph (GLib.GType gtype, DrawGlyphNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_glyph"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawGlyphNativeDelegate (IntPtr inst, IntPtr font, uint glyph, double x, double y);

		static void DrawGlyph_cb (IntPtr inst, IntPtr font, uint glyph, double x, double y)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawGlyph (GLib.Object.GetObject(font) as Pango.Font, glyph, x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawGlyph")]
		protected virtual void OnDrawGlyph (Pango.Font font, uint glyph, double x, double y)
		{
			InternalDrawGlyph (font, glyph, x, y);
		}

		private void InternalDrawGlyph (Pango.Font font, uint glyph, double x, double y)
		{
			DrawGlyphNativeDelegate unmanaged = class_abi.BaseOverride<DrawGlyphNativeDelegate>(this.LookupGType(), "draw_glyph");
			if (unmanaged == null) return;

			unmanaged (this.Handle, font == null ? IntPtr.Zero : font.Handle, glyph, x, y);
		}

		static PartChangedNativeDelegate PartChanged_cb_delegate;
		static PartChangedNativeDelegate PartChangedVMCallback {
			get {
				if (PartChanged_cb_delegate == null)
					PartChanged_cb_delegate = new PartChangedNativeDelegate (PartChanged_cb);
				return PartChanged_cb_delegate;
			}
		}

		static void OverridePartChanged (GLib.GType gtype)
		{
			OverridePartChanged (gtype, PartChangedVMCallback);
		}

		static void OverridePartChanged (GLib.GType gtype, PartChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("part_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PartChangedNativeDelegate (IntPtr inst, int part);

		static void PartChanged_cb (IntPtr inst, int part)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnPartChanged ((Pango.RenderPart) part);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverridePartChanged")]
		protected virtual void OnPartChanged (Pango.RenderPart part)
		{
			InternalPartChanged (part);
		}

		private void InternalPartChanged (Pango.RenderPart part)
		{
			PartChangedNativeDelegate unmanaged = class_abi.BaseOverride<PartChangedNativeDelegate>(this.LookupGType(), "part_changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) part);
		}

		static BeginNativeDelegate Begin_cb_delegate;
		static BeginNativeDelegate BeginVMCallback {
			get {
				if (Begin_cb_delegate == null)
					Begin_cb_delegate = new BeginNativeDelegate (Begin_cb);
				return Begin_cb_delegate;
			}
		}

		static void OverrideBegin (GLib.GType gtype)
		{
			OverrideBegin (gtype, BeginVMCallback);
		}

		static void OverrideBegin (GLib.GType gtype, BeginNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("begin"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void BeginNativeDelegate (IntPtr inst);

		static void Begin_cb (IntPtr inst)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnBegin ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideBegin")]
		protected virtual void OnBegin ()
		{
			InternalBegin ();
		}

		private void InternalBegin ()
		{
			BeginNativeDelegate unmanaged = class_abi.BaseOverride<BeginNativeDelegate>(this.LookupGType(), "begin");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static EndNativeDelegate End_cb_delegate;
		static EndNativeDelegate EndVMCallback {
			get {
				if (End_cb_delegate == null)
					End_cb_delegate = new EndNativeDelegate (End_cb);
				return End_cb_delegate;
			}
		}

		static void OverrideEnd (GLib.GType gtype)
		{
			OverrideEnd (gtype, EndVMCallback);
		}

		static void OverrideEnd (GLib.GType gtype, EndNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("end"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EndNativeDelegate (IntPtr inst);

		static void End_cb (IntPtr inst)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnEnd ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideEnd")]
		protected virtual void OnEnd ()
		{
			InternalEnd ();
		}

		private void InternalEnd ()
		{
			EndNativeDelegate unmanaged = class_abi.BaseOverride<EndNativeDelegate>(this.LookupGType(), "end");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static PrepareRunNativeDelegate PrepareRun_cb_delegate;
		static PrepareRunNativeDelegate PrepareRunVMCallback {
			get {
				if (PrepareRun_cb_delegate == null)
					PrepareRun_cb_delegate = new PrepareRunNativeDelegate (PrepareRun_cb);
				return PrepareRun_cb_delegate;
			}
		}

		static void OverridePrepareRun (GLib.GType gtype)
		{
			OverridePrepareRun (gtype, PrepareRunVMCallback);
		}

		static void OverridePrepareRun (GLib.GType gtype, PrepareRunNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("prepare_run"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrepareRunNativeDelegate (IntPtr inst, IntPtr run);

		static void PrepareRun_cb (IntPtr inst, IntPtr run)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnPrepareRun (Pango.LayoutRun.New (run));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverridePrepareRun")]
		protected virtual void OnPrepareRun (Pango.LayoutRun run)
		{
			InternalPrepareRun (run);
		}

		private void InternalPrepareRun (Pango.LayoutRun run)
		{
			PrepareRunNativeDelegate unmanaged = class_abi.BaseOverride<PrepareRunNativeDelegate>(this.LookupGType(), "prepare_run");
			if (unmanaged == null) return;

			IntPtr native_run = GLib.Marshaller.StructureToPtrAlloc (run);
			unmanaged (this.Handle, native_run);
			Marshal.FreeHGlobal (native_run);
		}

		static DrawGlyphItemNativeDelegate DrawGlyphItem_cb_delegate;
		static DrawGlyphItemNativeDelegate DrawGlyphItemVMCallback {
			get {
				if (DrawGlyphItem_cb_delegate == null)
					DrawGlyphItem_cb_delegate = new DrawGlyphItemNativeDelegate (DrawGlyphItem_cb);
				return DrawGlyphItem_cb_delegate;
			}
		}

		static void OverrideDrawGlyphItem (GLib.GType gtype)
		{
			OverrideDrawGlyphItem (gtype, DrawGlyphItemVMCallback);
		}

		static void OverrideDrawGlyphItem (GLib.GType gtype, DrawGlyphItemNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_glyph_item"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawGlyphItemNativeDelegate (IntPtr inst, IntPtr text, IntPtr glyph_item, int x, int y);

		static void DrawGlyphItem_cb (IntPtr inst, IntPtr text, IntPtr glyph_item, int x, int y)
		{
			try {
				Renderer __obj = GLib.Object.GetObject (inst, false) as Renderer;
				__obj.OnDrawGlyphItem (GLib.Marshaller.Utf8PtrToString (text), Pango.GlyphItem.New (glyph_item), x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Pango.Renderer), ConnectionMethod="OverrideDrawGlyphItem")]
		protected virtual void OnDrawGlyphItem (string text, Pango.GlyphItem glyph_item, int x, int y)
		{
			InternalDrawGlyphItem (text, glyph_item, x, y);
		}

		private void InternalDrawGlyphItem (string text, Pango.GlyphItem glyph_item, int x, int y)
		{
			DrawGlyphItemNativeDelegate unmanaged = class_abi.BaseOverride<DrawGlyphItemNativeDelegate>(this.LookupGType(), "draw_glyph_item");
			if (unmanaged == null) return;

			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			IntPtr native_glyph_item = GLib.Marshaller.StructureToPtrAlloc (glyph_item);
			unmanaged (this.Handle, native_text, native_glyph_item, x, y);
			GLib.Marshaller.Free (native_text);
			Marshal.FreeHGlobal (native_glyph_item);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("draw_glyphs"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // draw_glyphs
							, null
							, "draw_rectangle"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("draw_rectangle"
							, -1
							, (uint) sizeof( IntPtr ) // draw_rectangle
							, "draw_glyphs"
							, "draw_error_underline"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("draw_error_underline"
							, -1
							, (uint) sizeof( IntPtr ) // draw_error_underline
							, "draw_rectangle"
							, "draw_shape"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("draw_shape"
							, -1
							, (uint) sizeof( IntPtr ) // draw_shape
							, "draw_error_underline"
							, "draw_trapezoid"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("draw_trapezoid"
							, -1
							, (uint) sizeof( IntPtr ) // draw_trapezoid
							, "draw_shape"
							, "draw_glyph"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("draw_glyph"
							, -1
							, (uint) sizeof( IntPtr ) // draw_glyph
							, "draw_trapezoid"
							, "part_changed"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("part_changed"
							, -1
							, (uint) sizeof( IntPtr ) // part_changed
							, "draw_glyph"
							, "begin"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("begin"
							, -1
							, (uint) sizeof( IntPtr ) // begin
							, "part_changed"
							, "end"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("end"
							, -1
							, (uint) sizeof( IntPtr ) // end
							, "begin"
							, "prepare_run"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("prepare_run"
							, -1
							, (uint) sizeof( IntPtr ) // prepare_run
							, "end"
							, "draw_glyph_item"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("draw_glyph_item"
							, -1
							, (uint) sizeof( IntPtr ) // draw_glyph_item
							, "prepare_run"
							, "_pango_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_pango_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _pango_reserved2
							, "draw_glyph_item"
							, "_pango_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_pango_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _pango_reserved3
							, "_pango_reserved2"
							, "_pango_reserved4"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_pango_reserved4"
							, -1
							, (uint) sizeof( IntPtr ) // _pango_reserved4
							, "_pango_reserved3"
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_activate(IntPtr raw);
		static d_pango_renderer_activate pango_renderer_activate = FuncLoader.LoadFunction<d_pango_renderer_activate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_activate"));

		public void Activate() {
			pango_renderer_activate(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_deactivate(IntPtr raw);
		static d_pango_renderer_deactivate pango_renderer_deactivate = FuncLoader.LoadFunction<d_pango_renderer_deactivate>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_deactivate"));

		public void Deactivate() {
			pango_renderer_deactivate(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_error_underline(IntPtr raw, int x, int y, int width, int height);
		static d_pango_renderer_draw_error_underline pango_renderer_draw_error_underline = FuncLoader.LoadFunction<d_pango_renderer_draw_error_underline>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_error_underline"));

		public void DrawErrorUnderline(int x, int y, int width, int height) {
			pango_renderer_draw_error_underline(Handle, x, y, width, height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_glyph(IntPtr raw, IntPtr font, uint glyph, double x, double y);
		static d_pango_renderer_draw_glyph pango_renderer_draw_glyph = FuncLoader.LoadFunction<d_pango_renderer_draw_glyph>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_glyph"));

		public void DrawGlyph(Pango.Font font, uint glyph, double x, double y) {
			pango_renderer_draw_glyph(Handle, font == null ? IntPtr.Zero : font.Handle, glyph, x, y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_glyph_item(IntPtr raw, IntPtr text, IntPtr glyph_item, int x, int y);
		static d_pango_renderer_draw_glyph_item pango_renderer_draw_glyph_item = FuncLoader.LoadFunction<d_pango_renderer_draw_glyph_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_glyph_item"));

		public void DrawGlyphItem(string text, Pango.GlyphItem glyph_item, int x, int y) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			IntPtr native_glyph_item = GLib.Marshaller.StructureToPtrAlloc (glyph_item);
			pango_renderer_draw_glyph_item(Handle, native_text, native_glyph_item, x, y);
			GLib.Marshaller.Free (native_text);
			Marshal.FreeHGlobal (native_glyph_item);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_glyphs(IntPtr raw, IntPtr font, IntPtr glyphs, int x, int y);
		static d_pango_renderer_draw_glyphs pango_renderer_draw_glyphs = FuncLoader.LoadFunction<d_pango_renderer_draw_glyphs>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_glyphs"));

		public void DrawGlyphs(Pango.Font font, Pango.GlyphString glyphs, int x, int y) {
			pango_renderer_draw_glyphs(Handle, font == null ? IntPtr.Zero : font.Handle, glyphs == null ? IntPtr.Zero : glyphs.Handle, x, y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_layout(IntPtr raw, IntPtr layout, int x, int y);
		static d_pango_renderer_draw_layout pango_renderer_draw_layout = FuncLoader.LoadFunction<d_pango_renderer_draw_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_layout"));

		public void DrawLayout(Pango.Layout layout, int x, int y) {
			pango_renderer_draw_layout(Handle, layout == null ? IntPtr.Zero : layout.Handle, x, y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_layout_line(IntPtr raw, IntPtr line, int x, int y);
		static d_pango_renderer_draw_layout_line pango_renderer_draw_layout_line = FuncLoader.LoadFunction<d_pango_renderer_draw_layout_line>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_layout_line"));

		public void DrawLayoutLine(Pango.LayoutLine line, int x, int y) {
			pango_renderer_draw_layout_line(Handle, line == null ? IntPtr.Zero : line.Handle, x, y);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_rectangle(IntPtr raw, int part, int x, int y, int width, int height);
		static d_pango_renderer_draw_rectangle pango_renderer_draw_rectangle = FuncLoader.LoadFunction<d_pango_renderer_draw_rectangle>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_rectangle"));

		public void DrawRectangle(Pango.RenderPart part, int x, int y, int width, int height) {
			pango_renderer_draw_rectangle(Handle, (int) part, x, y, width, height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_draw_trapezoid(IntPtr raw, int part, double y1_, double x11, double x21, double y2, double x12, double x22);
		static d_pango_renderer_draw_trapezoid pango_renderer_draw_trapezoid = FuncLoader.LoadFunction<d_pango_renderer_draw_trapezoid>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_draw_trapezoid"));

		public void DrawTrapezoid(Pango.RenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22) {
			pango_renderer_draw_trapezoid(Handle, (int) part, y1_, x11, x21, y2, x12, x22);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate ushort d_pango_renderer_get_alpha(IntPtr raw, int part);
		static d_pango_renderer_get_alpha pango_renderer_get_alpha = FuncLoader.LoadFunction<d_pango_renderer_get_alpha>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_get_alpha"));

		public ushort GetAlpha(Pango.RenderPart part) {
			ushort raw_ret = pango_renderer_get_alpha(Handle, (int) part);
			ushort ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_renderer_get_color(IntPtr raw, int part);
		static d_pango_renderer_get_color pango_renderer_get_color = FuncLoader.LoadFunction<d_pango_renderer_get_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_get_color"));

		public Pango.Color GetColor(Pango.RenderPart part) {
			IntPtr raw_ret = pango_renderer_get_color(Handle, (int) part);
			Pango.Color ret = Pango.Color.New (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_renderer_get_layout(IntPtr raw);
		static d_pango_renderer_get_layout pango_renderer_get_layout = FuncLoader.LoadFunction<d_pango_renderer_get_layout>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_get_layout"));

		public Pango.Layout Layout { 
			get {
				IntPtr raw_ret = pango_renderer_get_layout(Handle);
				Pango.Layout ret = GLib.Object.GetObject(raw_ret) as Pango.Layout;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_renderer_get_layout_line(IntPtr raw);
		static d_pango_renderer_get_layout_line pango_renderer_get_layout_line = FuncLoader.LoadFunction<d_pango_renderer_get_layout_line>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_get_layout_line"));

		public Pango.LayoutLine LayoutLine { 
			get {
				IntPtr raw_ret = pango_renderer_get_layout_line(Handle);
				Pango.LayoutLine ret = raw_ret == IntPtr.Zero ? null : (Pango.LayoutLine) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.LayoutLine), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_renderer_get_type();
		static d_pango_renderer_get_type pango_renderer_get_type = FuncLoader.LoadFunction<d_pango_renderer_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_renderer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_part_changed(IntPtr raw, int part);
		static d_pango_renderer_part_changed pango_renderer_part_changed = FuncLoader.LoadFunction<d_pango_renderer_part_changed>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_part_changed"));

		public void PartChanged(Pango.RenderPart part) {
			pango_renderer_part_changed(Handle, (int) part);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_set_alpha(IntPtr raw, int part, ushort alpha);
		static d_pango_renderer_set_alpha pango_renderer_set_alpha = FuncLoader.LoadFunction<d_pango_renderer_set_alpha>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_set_alpha"));

		public void SetAlpha(Pango.RenderPart part, ushort alpha) {
			pango_renderer_set_alpha(Handle, (int) part, alpha);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_renderer_set_color(IntPtr raw, int part, IntPtr color);
		static d_pango_renderer_set_color pango_renderer_set_color = FuncLoader.LoadFunction<d_pango_renderer_set_color>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_renderer_set_color"));

		public void SetColor(Pango.RenderPart part, Pango.Color color) {
			IntPtr native_color = GLib.Marshaller.StructureToPtrAlloc (color);
			pango_renderer_set_color(Handle, (int) part, native_color);
			Marshal.FreeHGlobal (native_color);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("underline"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof(Pango.Underline) // underline
							, null
							, "strikethrough"
							, (long) Marshal.OffsetOf<PangoRenderer_underlineAlign>("underline")
							, 0
							),
						new GLib.AbiField("strikethrough"
							, -1
							, (uint) Marshal.SizeOf<bool>() // strikethrough
							, "underline"
							, "active_count"
							, (long) Marshal.OffsetOf<PangoRenderer_strikethroughAlign>("strikethrough")
							, 0
							),
						new GLib.AbiField("active_count"
							, -1
							, (uint) sizeof( int ) // active_count
							, "strikethrough"
							, "matrix"
							, (long) Marshal.OffsetOf<PangoRenderer_active_countAlign>("active_count")
							, 0
							),
						new GLib.AbiField("matrix"
							, -1
							, (uint) sizeof( IntPtr ) // matrix
							, "active_count"
							, "priv"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) sizeof( IntPtr ) // priv
							, "matrix"
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoRenderer_underlineAlign
		{
			sbyte f1;
			private Pango.Underline underline;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoRenderer_strikethroughAlign
		{
			sbyte f1;
			private bool strikethrough;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoRenderer_active_countAlign
		{
			sbyte f1;
			private int active_count;
		}


		// End of the ABI representation.

#endregion
	}
}
