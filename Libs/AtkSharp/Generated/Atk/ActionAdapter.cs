// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ActionAdapter : GLib.GInterfaceAdapter, Atk.IAction {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkActionIface {
			public DoActionNativeDelegate DoAction;
			public GetNActionsNativeDelegate GetNActions;
			public GetDescriptionNativeDelegate GetDescription;
			public GetNameNativeDelegate GetName;
			public GetKeybindingNativeDelegate GetKeybinding;
			public SetDescriptionNativeDelegate SetDescription;
			public GetLocalizedNameNativeDelegate GetLocalizedName;
		}

		static AtkActionIface iface;

		static ActionAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ActionAdapter));
			iface.DoAction = new DoActionNativeDelegate (DoAction_cb);
			iface.GetNActions = new GetNActionsNativeDelegate (GetNActions_cb);
			iface.GetDescription = new GetDescriptionNativeDelegate (GetDescription_cb);
			iface.GetName = new GetNameNativeDelegate (GetName_cb);
			iface.GetKeybinding = new GetKeybindingNativeDelegate (GetKeybinding_cb);
			iface.SetDescription = new SetDescriptionNativeDelegate (SetDescription_cb);
			iface.GetLocalizedName = new GetLocalizedNameNativeDelegate (GetLocalizedName_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool DoActionNativeDelegate (IntPtr inst, int i);

		static bool DoAction_cb (IntPtr inst, int i)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				bool __result;
				__result = __obj.DoAction (i);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNActionsNativeDelegate (IntPtr inst);

		static int GetNActions_cb (IntPtr inst)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				int __result;
				__result = __obj.NActions;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetDescriptionNativeDelegate (IntPtr inst, int i);

		static IntPtr GetDescription_cb (IntPtr inst, int i)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				string __result;
				__result = __obj.GetDescription (i);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetNameNativeDelegate (IntPtr inst, int i);

		static IntPtr GetName_cb (IntPtr inst, int i)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				string __result;
				__result = __obj.GetName (i);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetKeybindingNativeDelegate (IntPtr inst, int i);

		static IntPtr GetKeybinding_cb (IntPtr inst, int i)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				string __result;
				__result = __obj.GetKeybinding (i);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetDescriptionNativeDelegate (IntPtr inst, int i, IntPtr desc);

		static bool SetDescription_cb (IntPtr inst, int i, IntPtr desc)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				bool __result;
				__result = __obj.SetDescription (i, GLib.Marshaller.Utf8PtrToString (desc));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetLocalizedNameNativeDelegate (IntPtr inst, int i);

		static IntPtr GetLocalizedName_cb (IntPtr inst, int i)
		{
			try {
				IActionImplementor __obj = GLib.Object.GetObject (inst, false) as IActionImplementor;
				string __result;
				__result = __obj.GetLocalizedName (i);
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
			AtkActionIface native_iface = (AtkActionIface) Marshal.PtrToStructure (ifaceptr, typeof (AtkActionIface));
			native_iface.DoAction = iface.DoAction;
			native_iface.GetNActions = iface.GetNActions;
			native_iface.GetDescription = iface.GetDescription;
			native_iface.GetName = iface.GetName;
			native_iface.GetKeybinding = iface.GetKeybinding;
			native_iface.SetDescription = iface.SetDescription;
			native_iface.GetLocalizedName = iface.GetLocalizedName;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ActionAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ActionAdapter (IActionImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ActionAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_action_get_type();
		static d_atk_action_get_type atk_action_get_type = FuncLoader.LoadFunction<d_atk_action_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_get_type"));

		private static GLib.GType _gtype = new GLib.GType (atk_action_get_type ());

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

		public static IAction GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IAction GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IActionImplementor)
				return new ActionAdapter (obj as IActionImplementor);
			else if (obj as IAction == null)
				return new ActionAdapter (obj.Handle);
			else
				return obj as IAction;
		}

		public IActionImplementor Implementor {
			get {
				return implementor as IActionImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_action_do_action(IntPtr raw, int i);
		static d_atk_action_do_action atk_action_do_action = FuncLoader.LoadFunction<d_atk_action_do_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_do_action"));

		public bool DoAction(int i) {
			bool raw_ret = atk_action_do_action(Handle, i);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_action_get_description(IntPtr raw, int i);
		static d_atk_action_get_description atk_action_get_description = FuncLoader.LoadFunction<d_atk_action_get_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_get_description"));

		public string GetDescription(int i) {
			IntPtr raw_ret = atk_action_get_description(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_action_get_keybinding(IntPtr raw, int i);
		static d_atk_action_get_keybinding atk_action_get_keybinding = FuncLoader.LoadFunction<d_atk_action_get_keybinding>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_get_keybinding"));

		public string GetKeybinding(int i) {
			IntPtr raw_ret = atk_action_get_keybinding(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_action_get_localized_name(IntPtr raw, int i);
		static d_atk_action_get_localized_name atk_action_get_localized_name = FuncLoader.LoadFunction<d_atk_action_get_localized_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_get_localized_name"));

		public string GetLocalizedName(int i) {
			IntPtr raw_ret = atk_action_get_localized_name(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_atk_action_get_n_actions(IntPtr raw);
		static d_atk_action_get_n_actions atk_action_get_n_actions = FuncLoader.LoadFunction<d_atk_action_get_n_actions>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_get_n_actions"));

		public int NActions { 
			get {
				int raw_ret = atk_action_get_n_actions(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_action_get_name(IntPtr raw, int i);
		static d_atk_action_get_name atk_action_get_name = FuncLoader.LoadFunction<d_atk_action_get_name>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_get_name"));

		public string GetName(int i) {
			IntPtr raw_ret = atk_action_get_name(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_action_set_description(IntPtr raw, int i, IntPtr desc);
		static d_atk_action_set_description atk_action_set_description = FuncLoader.LoadFunction<d_atk_action_set_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_action_set_description"));

		public bool SetDescription(int i, string desc) {
			IntPtr native_desc = GLib.Marshaller.StringToPtrGStrdup (desc);
			bool raw_ret = atk_action_set_description(Handle, i, native_desc);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_desc);
			return ret;
		}

#endregion
	}
}
