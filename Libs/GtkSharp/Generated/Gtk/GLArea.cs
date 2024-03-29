// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class GLArea : Gtk.Widget {

		public GLArea (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_gl_area_new();
		static d_gtk_gl_area_new gtk_gl_area_new = FuncLoader.LoadFunction<d_gtk_gl_area_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_new"));

		public GLArea () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GLArea)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_gl_area_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_gl_area_get_auto_render(IntPtr raw);
		static d_gtk_gl_area_get_auto_render gtk_gl_area_get_auto_render = FuncLoader.LoadFunction<d_gtk_gl_area_get_auto_render>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_auto_render"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_auto_render(IntPtr raw, bool auto_render);
		static d_gtk_gl_area_set_auto_render gtk_gl_area_set_auto_render = FuncLoader.LoadFunction<d_gtk_gl_area_set_auto_render>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_auto_render"));

		[GLib.Property ("auto-render")]
		public bool AutoRender {
			get  {
				bool raw_ret = gtk_gl_area_get_auto_render(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_gl_area_set_auto_render(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_gl_area_get_has_alpha(IntPtr raw);
		static d_gtk_gl_area_get_has_alpha gtk_gl_area_get_has_alpha = FuncLoader.LoadFunction<d_gtk_gl_area_get_has_alpha>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_has_alpha"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_has_alpha(IntPtr raw, bool has_alpha);
		static d_gtk_gl_area_set_has_alpha gtk_gl_area_set_has_alpha = FuncLoader.LoadFunction<d_gtk_gl_area_set_has_alpha>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_has_alpha"));

		[GLib.Property ("has-alpha")]
		public bool HasAlpha {
			get  {
				bool raw_ret = gtk_gl_area_get_has_alpha(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_gl_area_set_has_alpha(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_gl_area_get_has_depth_buffer(IntPtr raw);
		static d_gtk_gl_area_get_has_depth_buffer gtk_gl_area_get_has_depth_buffer = FuncLoader.LoadFunction<d_gtk_gl_area_get_has_depth_buffer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_has_depth_buffer"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_has_depth_buffer(IntPtr raw, bool has_depth_buffer);
		static d_gtk_gl_area_set_has_depth_buffer gtk_gl_area_set_has_depth_buffer = FuncLoader.LoadFunction<d_gtk_gl_area_set_has_depth_buffer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_has_depth_buffer"));

		[GLib.Property ("has-depth-buffer")]
		public bool HasDepthBuffer {
			get  {
				bool raw_ret = gtk_gl_area_get_has_depth_buffer(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_gl_area_set_has_depth_buffer(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_gl_area_get_has_stencil_buffer(IntPtr raw);
		static d_gtk_gl_area_get_has_stencil_buffer gtk_gl_area_get_has_stencil_buffer = FuncLoader.LoadFunction<d_gtk_gl_area_get_has_stencil_buffer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_has_stencil_buffer"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_has_stencil_buffer(IntPtr raw, bool has_stencil_buffer);
		static d_gtk_gl_area_set_has_stencil_buffer gtk_gl_area_set_has_stencil_buffer = FuncLoader.LoadFunction<d_gtk_gl_area_set_has_stencil_buffer>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_has_stencil_buffer"));

		[GLib.Property ("has-stencil-buffer")]
		public bool HasStencilBuffer {
			get  {
				bool raw_ret = gtk_gl_area_get_has_stencil_buffer(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_gl_area_set_has_stencil_buffer(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_gl_area_get_use_es(IntPtr raw);
		static d_gtk_gl_area_get_use_es gtk_gl_area_get_use_es = FuncLoader.LoadFunction<d_gtk_gl_area_get_use_es>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_use_es"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_use_es(IntPtr raw, bool use_es);
		static d_gtk_gl_area_set_use_es gtk_gl_area_set_use_es = FuncLoader.LoadFunction<d_gtk_gl_area_set_use_es>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_use_es"));

		[GLib.Property ("use-es")]
		public bool UseEs {
			get  {
				bool raw_ret = gtk_gl_area_get_use_es(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_gl_area_set_use_es(Handle, value);
			}
		}

		[GLib.Signal("render")]
		public event Gtk.RenderHandler Render {
			add {
				this.AddSignalHandler ("render", value, typeof (Gtk.RenderArgs));
			}
			remove {
				this.RemoveSignalHandler ("render", value);
			}
		}

		[GLib.Signal("resize")]
		public event Gtk.ResizeHandler Resize {
			add {
				this.AddSignalHandler ("resize", value, typeof (Gtk.ResizeArgs));
			}
			remove {
				this.RemoveSignalHandler ("resize", value);
			}
		}

		[GLib.Signal("create-context")]
		public event Gtk.CreateContextHandler CreateContext {
			add {
				this.AddSignalHandler ("create-context", value, typeof (Gtk.CreateContextArgs));
			}
			remove {
				this.RemoveSignalHandler ("create-context", value);
			}
		}

		static RenderNativeDelegate Render_cb_delegate;
		static RenderNativeDelegate RenderVMCallback {
			get {
				if (Render_cb_delegate == null)
					Render_cb_delegate = new RenderNativeDelegate (Render_cb);
				return Render_cb_delegate;
			}
		}

		static void OverrideRender (GLib.GType gtype)
		{
			OverrideRender (gtype, RenderVMCallback);
		}

		static void OverrideRender (GLib.GType gtype, RenderNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("render"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RenderNativeDelegate (IntPtr inst, IntPtr context);

		static bool Render_cb (IntPtr inst, IntPtr context)
		{
			try {
				GLArea __obj = GLib.Object.GetObject (inst, false) as GLArea;
				bool __result;
				__result = __obj.OnRender (GLib.Object.GetObject(context) as Gdk.GLContext);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GLArea), ConnectionMethod="OverrideRender")]
		protected virtual bool OnRender (Gdk.GLContext context)
		{
			return InternalRender (context);
		}

		private bool InternalRender (Gdk.GLContext context)
		{
			RenderNativeDelegate unmanaged = class_abi.BaseOverride<RenderNativeDelegate>(this.LookupGType(), "render");
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, context == null ? IntPtr.Zero : context.Handle);
			return __result;
		}

		static ResizeNativeDelegate Resize_cb_delegate;
		static ResizeNativeDelegate ResizeVMCallback {
			get {
				if (Resize_cb_delegate == null)
					Resize_cb_delegate = new ResizeNativeDelegate (Resize_cb);
				return Resize_cb_delegate;
			}
		}

		static void OverrideResize (GLib.GType gtype)
		{
			OverrideResize (gtype, ResizeVMCallback);
		}

		static void OverrideResize (GLib.GType gtype, ResizeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("resize"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ResizeNativeDelegate (IntPtr inst, int width, int height);

		static void Resize_cb (IntPtr inst, int width, int height)
		{
			try {
				GLArea __obj = GLib.Object.GetObject (inst, false) as GLArea;
				__obj.OnResize (width, height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GLArea), ConnectionMethod="OverrideResize")]
		protected virtual void OnResize (int width, int height)
		{
			InternalResize (width, height);
		}

		private void InternalResize (int width, int height)
		{
			ResizeNativeDelegate unmanaged = class_abi.BaseOverride<ResizeNativeDelegate>(this.LookupGType(), "resize");
			if (unmanaged == null) return;

			unmanaged (this.Handle, width, height);
		}

		static CreateContextNativeDelegate CreateContext_cb_delegate;
		static CreateContextNativeDelegate CreateContextVMCallback {
			get {
				if (CreateContext_cb_delegate == null)
					CreateContext_cb_delegate = new CreateContextNativeDelegate (CreateContext_cb);
				return CreateContext_cb_delegate;
			}
		}

		static void OverrideCreateContext (GLib.GType gtype)
		{
			OverrideCreateContext (gtype, CreateContextVMCallback);
		}

		static void OverrideCreateContext (GLib.GType gtype, CreateContextNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_context"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateContextNativeDelegate (IntPtr inst);

		static IntPtr CreateContext_cb (IntPtr inst)
		{
			try {
				GLArea __obj = GLib.Object.GetObject (inst, false) as GLArea;
				Gdk.GLContext __result;
				__result = __obj.OnCreateContext ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GLArea), ConnectionMethod="OverrideCreateContext")]
		protected virtual Gdk.GLContext OnCreateContext ()
		{
			return InternalCreateContext ();
		}

		private Gdk.GLContext InternalCreateContext ()
		{
			CreateContextNativeDelegate unmanaged = class_abi.BaseOverride<CreateContextNativeDelegate>(this.LookupGType(), "create_context");
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Object.GetObject(__result) as Gdk.GLContext;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("render"
							, Gtk.Widget.class_abi.Fields
							, (uint) sizeof( IntPtr ) // render
							, null
							, "resize"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("resize"
							, -1
							, (uint) sizeof( IntPtr ) // resize
							, "render"
							, "create_context"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("create_context"
							, -1
							, (uint) sizeof( IntPtr ) // create_context
							, "resize"
							, "_padding"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) sizeof( IntPtr ) * 6 // _padding
							, "create_context"
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
		delegate void d_gtk_gl_area_attach_buffers(IntPtr raw);
		static d_gtk_gl_area_attach_buffers gtk_gl_area_attach_buffers = FuncLoader.LoadFunction<d_gtk_gl_area_attach_buffers>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_attach_buffers"));

		public void AttachBuffers() {
			gtk_gl_area_attach_buffers(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_gl_area_get_context(IntPtr raw);
		static d_gtk_gl_area_get_context gtk_gl_area_get_context = FuncLoader.LoadFunction<d_gtk_gl_area_get_context>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_context"));

		public Gdk.GLContext Context { 
			get {
				IntPtr raw_ret = gtk_gl_area_get_context(Handle);
				Gdk.GLContext ret = GLib.Object.GetObject(raw_ret) as Gdk.GLContext;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_gl_area_get_error(IntPtr raw);
		static d_gtk_gl_area_get_error gtk_gl_area_get_error = FuncLoader.LoadFunction<d_gtk_gl_area_get_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_error"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_error(IntPtr raw, IntPtr error);
		static d_gtk_gl_area_set_error gtk_gl_area_set_error = FuncLoader.LoadFunction<d_gtk_gl_area_set_error>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_error"));

		public IntPtr Error { 
			get {
				IntPtr raw_ret = gtk_gl_area_get_error(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
			set {
				gtk_gl_area_set_error(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_get_required_version(IntPtr raw, out int major, out int minor);
		static d_gtk_gl_area_get_required_version gtk_gl_area_get_required_version = FuncLoader.LoadFunction<d_gtk_gl_area_get_required_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_required_version"));

		public void GetRequiredVersion(out int major, out int minor) {
			gtk_gl_area_get_required_version(Handle, out major, out minor);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_gl_area_get_type();
		static d_gtk_gl_area_get_type gtk_gl_area_get_type = FuncLoader.LoadFunction<d_gtk_gl_area_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gl_area_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_make_current(IntPtr raw);
		static d_gtk_gl_area_make_current gtk_gl_area_make_current = FuncLoader.LoadFunction<d_gtk_gl_area_make_current>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_make_current"));

		public void MakeCurrent() {
			gtk_gl_area_make_current(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_queue_render(IntPtr raw);
		static d_gtk_gl_area_queue_render gtk_gl_area_queue_render = FuncLoader.LoadFunction<d_gtk_gl_area_queue_render>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_queue_render"));

		public void QueueRender() {
			gtk_gl_area_queue_render(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_gl_area_set_required_version(IntPtr raw, int major, int minor);
		static d_gtk_gl_area_set_required_version gtk_gl_area_set_required_version = FuncLoader.LoadFunction<d_gtk_gl_area_set_required_version>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_gl_area_set_required_version"));

		public void SetRequiredVersion(int major, int minor) {
			gtk_gl_area_set_required_version(Handle, major, minor);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gtk.Widget.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
