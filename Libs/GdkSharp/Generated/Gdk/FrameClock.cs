// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class FrameClock : GLib.Object {

		public FrameClock (IntPtr raw) : base(raw) {}

		protected FrameClock() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("flush-events")]
		public event System.EventHandler FlushEvents {
			add {
				this.AddSignalHandler ("flush-events", value);
			}
			remove {
				this.RemoveSignalHandler ("flush-events", value);
			}
		}

		[GLib.Signal("before-paint")]
		public event System.EventHandler BeforePaint {
			add {
				this.AddSignalHandler ("before-paint", value);
			}
			remove {
				this.RemoveSignalHandler ("before-paint", value);
			}
		}

		[GLib.Signal("paint")]
		public event System.EventHandler Paint {
			add {
				this.AddSignalHandler ("paint", value);
			}
			remove {
				this.RemoveSignalHandler ("paint", value);
			}
		}

		[GLib.Signal("layout")]
		public event System.EventHandler Layout {
			add {
				this.AddSignalHandler ("layout", value);
			}
			remove {
				this.RemoveSignalHandler ("layout", value);
			}
		}

		[GLib.Signal("resume-events")]
		public event System.EventHandler ResumeEvents {
			add {
				this.AddSignalHandler ("resume-events", value);
			}
			remove {
				this.RemoveSignalHandler ("resume-events", value);
			}
		}

		[GLib.Signal("update")]
		public event System.EventHandler Update {
			add {
				this.AddSignalHandler ("update", value);
			}
			remove {
				this.RemoveSignalHandler ("update", value);
			}
		}

		[GLib.Signal("after-paint")]
		public event System.EventHandler AfterPaint {
			add {
				this.AddSignalHandler ("after-paint", value);
			}
			remove {
				this.RemoveSignalHandler ("after-paint", value);
			}
		}

		static FlushEventsNativeDelegate FlushEvents_cb_delegate;
		static FlushEventsNativeDelegate FlushEventsVMCallback {
			get {
				if (FlushEvents_cb_delegate == null)
					FlushEvents_cb_delegate = new FlushEventsNativeDelegate (FlushEvents_cb);
				return FlushEvents_cb_delegate;
			}
		}

		static void OverrideFlushEvents (GLib.GType gtype)
		{
			OverrideFlushEvents (gtype, FlushEventsVMCallback);
		}

		static void OverrideFlushEvents (GLib.GType gtype, FlushEventsNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "flush-events", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FlushEventsNativeDelegate (IntPtr inst);

		static void FlushEvents_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnFlushEvents ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideFlushEvents")]
		protected virtual void OnFlushEvents ()
		{
			InternalFlushEvents ();
		}

		private void InternalFlushEvents ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static BeforePaintNativeDelegate BeforePaint_cb_delegate;
		static BeforePaintNativeDelegate BeforePaintVMCallback {
			get {
				if (BeforePaint_cb_delegate == null)
					BeforePaint_cb_delegate = new BeforePaintNativeDelegate (BeforePaint_cb);
				return BeforePaint_cb_delegate;
			}
		}

		static void OverrideBeforePaint (GLib.GType gtype)
		{
			OverrideBeforePaint (gtype, BeforePaintVMCallback);
		}

		static void OverrideBeforePaint (GLib.GType gtype, BeforePaintNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "before-paint", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void BeforePaintNativeDelegate (IntPtr inst);

		static void BeforePaint_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnBeforePaint ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideBeforePaint")]
		protected virtual void OnBeforePaint ()
		{
			InternalBeforePaint ();
		}

		private void InternalBeforePaint ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static UpdateNativeDelegate Update_cb_delegate;
		static UpdateNativeDelegate UpdateVMCallback {
			get {
				if (Update_cb_delegate == null)
					Update_cb_delegate = new UpdateNativeDelegate (Update_cb);
				return Update_cb_delegate;
			}
		}

		static void OverrideUpdate (GLib.GType gtype)
		{
			OverrideUpdate (gtype, UpdateVMCallback);
		}

		static void OverrideUpdate (GLib.GType gtype, UpdateNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "update", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UpdateNativeDelegate (IntPtr inst);

		static void Update_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnUpdate ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideUpdate")]
		protected virtual void OnUpdate ()
		{
			InternalUpdate ();
		}

		private void InternalUpdate ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static LayoutNativeDelegate Layout_cb_delegate;
		static LayoutNativeDelegate LayoutVMCallback {
			get {
				if (Layout_cb_delegate == null)
					Layout_cb_delegate = new LayoutNativeDelegate (Layout_cb);
				return Layout_cb_delegate;
			}
		}

		static void OverrideLayout (GLib.GType gtype)
		{
			OverrideLayout (gtype, LayoutVMCallback);
		}

		static void OverrideLayout (GLib.GType gtype, LayoutNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "layout", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LayoutNativeDelegate (IntPtr inst);

		static void Layout_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnLayout ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideLayout")]
		protected virtual void OnLayout ()
		{
			InternalLayout ();
		}

		private void InternalLayout ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PaintNativeDelegate Paint_cb_delegate;
		static PaintNativeDelegate PaintVMCallback {
			get {
				if (Paint_cb_delegate == null)
					Paint_cb_delegate = new PaintNativeDelegate (Paint_cb);
				return Paint_cb_delegate;
			}
		}

		static void OverridePaint (GLib.GType gtype)
		{
			OverridePaint (gtype, PaintVMCallback);
		}

		static void OverridePaint (GLib.GType gtype, PaintNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "paint", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PaintNativeDelegate (IntPtr inst);

		static void Paint_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnPaint ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverridePaint")]
		protected virtual void OnPaint ()
		{
			InternalPaint ();
		}

		private void InternalPaint ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static AfterPaintNativeDelegate AfterPaint_cb_delegate;
		static AfterPaintNativeDelegate AfterPaintVMCallback {
			get {
				if (AfterPaint_cb_delegate == null)
					AfterPaint_cb_delegate = new AfterPaintNativeDelegate (AfterPaint_cb);
				return AfterPaint_cb_delegate;
			}
		}

		static void OverrideAfterPaint (GLib.GType gtype)
		{
			OverrideAfterPaint (gtype, AfterPaintVMCallback);
		}

		static void OverrideAfterPaint (GLib.GType gtype, AfterPaintNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "after-paint", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AfterPaintNativeDelegate (IntPtr inst);

		static void AfterPaint_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnAfterPaint ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideAfterPaint")]
		protected virtual void OnAfterPaint ()
		{
			InternalAfterPaint ();
		}

		private void InternalAfterPaint ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ResumeEventsNativeDelegate ResumeEvents_cb_delegate;
		static ResumeEventsNativeDelegate ResumeEventsVMCallback {
			get {
				if (ResumeEvents_cb_delegate == null)
					ResumeEvents_cb_delegate = new ResumeEventsNativeDelegate (ResumeEvents_cb);
				return ResumeEvents_cb_delegate;
			}
		}

		static void OverrideResumeEvents (GLib.GType gtype)
		{
			OverrideResumeEvents (gtype, ResumeEventsVMCallback);
		}

		static void OverrideResumeEvents (GLib.GType gtype, ResumeEventsNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "resume-events", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ResumeEventsNativeDelegate (IntPtr inst);

		static void ResumeEvents_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnResumeEvents ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideResumeEvents")]
		protected virtual void OnResumeEvents ()
		{
			InternalResumeEvents ();
		}

		private void InternalResumeEvents ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static GetFrameTimeNativeDelegate GetFrameTime_cb_delegate;
		static GetFrameTimeNativeDelegate GetFrameTimeVMCallback {
			get {
				if (GetFrameTime_cb_delegate == null)
					GetFrameTime_cb_delegate = new GetFrameTimeNativeDelegate (GetFrameTime_cb);
				return GetFrameTime_cb_delegate;
			}
		}

		static void OverrideGetFrameTime (GLib.GType gtype)
		{
			OverrideGetFrameTime (gtype, GetFrameTimeVMCallback);
		}

		static void OverrideGetFrameTime (GLib.GType gtype, GetFrameTimeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_frame_time"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate long GetFrameTimeNativeDelegate (IntPtr inst);

		static long GetFrameTime_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				long __result;
				__result = __obj.OnGetFrameTime ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideGetFrameTime")]
		protected virtual long OnGetFrameTime ()
		{
			return InternalGetFrameTime ();
		}

		private long InternalGetFrameTime ()
		{
			GetFrameTimeNativeDelegate unmanaged = class_abi.BaseOverride<GetFrameTimeNativeDelegate>(this.LookupGType(), "get_frame_time");
			if (unmanaged == null) return 0;

			long __result = unmanaged (this.Handle);
			return __result;
		}

		static RequestPhaseNativeDelegate RequestPhase_cb_delegate;
		static RequestPhaseNativeDelegate RequestPhaseVMCallback {
			get {
				if (RequestPhase_cb_delegate == null)
					RequestPhase_cb_delegate = new RequestPhaseNativeDelegate (RequestPhase_cb);
				return RequestPhase_cb_delegate;
			}
		}

		static void OverrideRequestPhase (GLib.GType gtype)
		{
			OverrideRequestPhase (gtype, RequestPhaseVMCallback);
		}

		static void OverrideRequestPhase (GLib.GType gtype, RequestPhaseNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("request_phase"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RequestPhaseNativeDelegate (IntPtr inst, int phase);

		static void RequestPhase_cb (IntPtr inst, int phase)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnRequestPhase ((Gdk.FrameClockPhase) phase);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideRequestPhase")]
		protected virtual void OnRequestPhase (Gdk.FrameClockPhase phase)
		{
			InternalRequestPhase (phase);
		}

		private void InternalRequestPhase (Gdk.FrameClockPhase phase)
		{
			RequestPhaseNativeDelegate unmanaged = class_abi.BaseOverride<RequestPhaseNativeDelegate>(this.LookupGType(), "request_phase");
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) phase);
		}

		static BeginUpdatingNativeDelegate BeginUpdating_cb_delegate;
		static BeginUpdatingNativeDelegate BeginUpdatingVMCallback {
			get {
				if (BeginUpdating_cb_delegate == null)
					BeginUpdating_cb_delegate = new BeginUpdatingNativeDelegate (BeginUpdating_cb);
				return BeginUpdating_cb_delegate;
			}
		}

		static void OverrideBeginUpdating (GLib.GType gtype)
		{
			OverrideBeginUpdating (gtype, BeginUpdatingVMCallback);
		}

		static void OverrideBeginUpdating (GLib.GType gtype, BeginUpdatingNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("begin_updating"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void BeginUpdatingNativeDelegate (IntPtr inst);

		static void BeginUpdating_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnBeginUpdating ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideBeginUpdating")]
		protected virtual void OnBeginUpdating ()
		{
			InternalBeginUpdating ();
		}

		private void InternalBeginUpdating ()
		{
			BeginUpdatingNativeDelegate unmanaged = class_abi.BaseOverride<BeginUpdatingNativeDelegate>(this.LookupGType(), "begin_updating");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static EndUpdatingNativeDelegate EndUpdating_cb_delegate;
		static EndUpdatingNativeDelegate EndUpdatingVMCallback {
			get {
				if (EndUpdating_cb_delegate == null)
					EndUpdating_cb_delegate = new EndUpdatingNativeDelegate (EndUpdating_cb);
				return EndUpdating_cb_delegate;
			}
		}

		static void OverrideEndUpdating (GLib.GType gtype)
		{
			OverrideEndUpdating (gtype, EndUpdatingVMCallback);
		}

		static void OverrideEndUpdating (GLib.GType gtype, EndUpdatingNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("end_updating"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EndUpdatingNativeDelegate (IntPtr inst);

		static void EndUpdating_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnEndUpdating ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideEndUpdating")]
		protected virtual void OnEndUpdating ()
		{
			InternalEndUpdating ();
		}

		private void InternalEndUpdating ()
		{
			EndUpdatingNativeDelegate unmanaged = class_abi.BaseOverride<EndUpdatingNativeDelegate>(this.LookupGType(), "end_updating");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static FreezeNativeDelegate Freeze_cb_delegate;
		static FreezeNativeDelegate FreezeVMCallback {
			get {
				if (Freeze_cb_delegate == null)
					Freeze_cb_delegate = new FreezeNativeDelegate (Freeze_cb);
				return Freeze_cb_delegate;
			}
		}

		static void OverrideFreeze (GLib.GType gtype)
		{
			OverrideFreeze (gtype, FreezeVMCallback);
		}

		static void OverrideFreeze (GLib.GType gtype, FreezeNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("freeze"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FreezeNativeDelegate (IntPtr inst);

		static void Freeze_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnFreeze ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideFreeze")]
		protected virtual void OnFreeze ()
		{
			InternalFreeze ();
		}

		private void InternalFreeze ()
		{
			FreezeNativeDelegate unmanaged = class_abi.BaseOverride<FreezeNativeDelegate>(this.LookupGType(), "freeze");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ThawNativeDelegate Thaw_cb_delegate;
		static ThawNativeDelegate ThawVMCallback {
			get {
				if (Thaw_cb_delegate == null)
					Thaw_cb_delegate = new ThawNativeDelegate (Thaw_cb);
				return Thaw_cb_delegate;
			}
		}

		static void OverrideThaw (GLib.GType gtype)
		{
			OverrideThaw (gtype, ThawVMCallback);
		}

		static void OverrideThaw (GLib.GType gtype, ThawNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("thaw"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ThawNativeDelegate (IntPtr inst);

		static void Thaw_cb (IntPtr inst)
		{
			try {
				FrameClock __obj = GLib.Object.GetObject (inst, false) as FrameClock;
				__obj.OnThaw ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.FrameClock), ConnectionMethod="OverrideThaw")]
		protected virtual void OnThaw ()
		{
			InternalThaw ();
		}

		private void InternalThaw ()
		{
			ThawNativeDelegate unmanaged = class_abi.BaseOverride<ThawNativeDelegate>(this.LookupGType(), "thaw");
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_frame_time"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // get_frame_time
							, null
							, "request_phase"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("request_phase"
							, -1
							, (uint) sizeof( IntPtr ) // request_phase
							, "get_frame_time"
							, "begin_updating"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("begin_updating"
							, -1
							, (uint) sizeof( IntPtr ) // begin_updating
							, "request_phase"
							, "end_updating"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("end_updating"
							, -1
							, (uint) sizeof( IntPtr ) // end_updating
							, "begin_updating"
							, "freeze"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("freeze"
							, -1
							, (uint) sizeof( IntPtr ) // freeze
							, "end_updating"
							, "thaw"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("thaw"
							, -1
							, (uint) sizeof( IntPtr ) // thaw
							, "freeze"
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
		delegate void d_gdk_frame_clock_begin_updating(IntPtr raw);
		static d_gdk_frame_clock_begin_updating gdk_frame_clock_begin_updating = FuncLoader.LoadFunction<d_gdk_frame_clock_begin_updating>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_begin_updating"));

		public void BeginUpdating() {
			gdk_frame_clock_begin_updating(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_frame_clock_end_updating(IntPtr raw);
		static d_gdk_frame_clock_end_updating gdk_frame_clock_end_updating = FuncLoader.LoadFunction<d_gdk_frame_clock_end_updating>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_end_updating"));

		public void EndUpdating() {
			gdk_frame_clock_end_updating(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_frame_clock_get_current_timings(IntPtr raw);
		static d_gdk_frame_clock_get_current_timings gdk_frame_clock_get_current_timings = FuncLoader.LoadFunction<d_gdk_frame_clock_get_current_timings>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_current_timings"));

		public Gdk.FrameTimings CurrentTimings { 
			get {
				IntPtr raw_ret = gdk_frame_clock_get_current_timings(Handle);
				Gdk.FrameTimings ret = raw_ret == IntPtr.Zero ? null : (Gdk.FrameTimings) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.FrameTimings), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate long d_gdk_frame_clock_get_frame_counter(IntPtr raw);
		static d_gdk_frame_clock_get_frame_counter gdk_frame_clock_get_frame_counter = FuncLoader.LoadFunction<d_gdk_frame_clock_get_frame_counter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_frame_counter"));

		public long FrameCounter { 
			get {
				long raw_ret = gdk_frame_clock_get_frame_counter(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate long d_gdk_frame_clock_get_frame_time(IntPtr raw);
		static d_gdk_frame_clock_get_frame_time gdk_frame_clock_get_frame_time = FuncLoader.LoadFunction<d_gdk_frame_clock_get_frame_time>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_frame_time"));

		public long FrameTime { 
			get {
				long raw_ret = gdk_frame_clock_get_frame_time(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate long d_gdk_frame_clock_get_history_start(IntPtr raw);
		static d_gdk_frame_clock_get_history_start gdk_frame_clock_get_history_start = FuncLoader.LoadFunction<d_gdk_frame_clock_get_history_start>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_history_start"));

		public long HistoryStart { 
			get {
				long raw_ret = gdk_frame_clock_get_history_start(Handle);
				long ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_frame_clock_get_refresh_info(IntPtr raw, long base_time, out long refresh_interval_return, out long presentation_time_return);
		static d_gdk_frame_clock_get_refresh_info gdk_frame_clock_get_refresh_info = FuncLoader.LoadFunction<d_gdk_frame_clock_get_refresh_info>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_refresh_info"));

		public void GetRefreshInfo(long base_time, out long refresh_interval_return, out long presentation_time_return) {
			gdk_frame_clock_get_refresh_info(Handle, base_time, out refresh_interval_return, out presentation_time_return);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_frame_clock_get_timings(IntPtr raw, long frame_counter);
		static d_gdk_frame_clock_get_timings gdk_frame_clock_get_timings = FuncLoader.LoadFunction<d_gdk_frame_clock_get_timings>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_timings"));

		public Gdk.FrameTimings GetTimings(long frame_counter) {
			IntPtr raw_ret = gdk_frame_clock_get_timings(Handle, frame_counter);
			Gdk.FrameTimings ret = raw_ret == IntPtr.Zero ? null : (Gdk.FrameTimings) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.FrameTimings), false);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gdk_frame_clock_get_type();
		static d_gdk_frame_clock_get_type gdk_frame_clock_get_type = FuncLoader.LoadFunction<d_gdk_frame_clock_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_frame_clock_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gdk_frame_clock_request_phase(IntPtr raw, int phase);
		static d_gdk_frame_clock_request_phase gdk_frame_clock_request_phase = FuncLoader.LoadFunction<d_gdk_frame_clock_request_phase>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gdk), "gdk_frame_clock_request_phase"));

		public void RequestPhase(Gdk.FrameClockPhase phase) {
			gdk_frame_clock_request_phase(Handle, (int) phase);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}