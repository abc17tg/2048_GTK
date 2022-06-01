// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class PolicyDecision : GLib.Object {

		protected PolicyDecision (IntPtr raw) : base(raw) {}

		protected PolicyDecision() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_webkit_reserved0"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // _webkit_reserved0
							, null
							, "_webkit_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved1
							, "_webkit_reserved0"
							, "_webkit_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved2
							, "_webkit_reserved1"
							, "_webkit_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_webkit_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _webkit_reserved3
							, "_webkit_reserved2"
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
		delegate IntPtr d_webkit_policy_decision_get_type();
		static d_webkit_policy_decision_get_type webkit_policy_decision_get_type = FuncLoader.LoadFunction<d_webkit_policy_decision_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_policy_decision_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_policy_decision_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_policy_decision_download(IntPtr raw);
		static d_webkit_policy_decision_download webkit_policy_decision_download = FuncLoader.LoadFunction<d_webkit_policy_decision_download>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_policy_decision_download"));

		public void Download() {
			webkit_policy_decision_download(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_policy_decision_ignore(IntPtr raw);
		static d_webkit_policy_decision_ignore webkit_policy_decision_ignore = FuncLoader.LoadFunction<d_webkit_policy_decision_ignore>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_policy_decision_ignore"));

		public void Ignore() {
			webkit_policy_decision_ignore(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_policy_decision_use(IntPtr raw);
		static d_webkit_policy_decision_use webkit_policy_decision_use = FuncLoader.LoadFunction<d_webkit_policy_decision_use>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_policy_decision_use"));

		public void Use() {
			webkit_policy_decision_use(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_webkit_policy_decision_use_with_policies(IntPtr raw, IntPtr policies);
		static d_webkit_policy_decision_use_with_policies webkit_policy_decision_use_with_policies = FuncLoader.LoadFunction<d_webkit_policy_decision_use_with_policies>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_policy_decision_use_with_policies"));

		public void UseWithPolicies(WebKit.WebsitePolicies policies) {
			webkit_policy_decision_use_with_policies(Handle, policies == null ? IntPtr.Zero : policies.Handle);
		}


		static PolicyDecision ()
		{
			GtkSharp.WebkitGtkSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) sizeof( IntPtr ) // priv
							, null
							, null
							, (uint) sizeof(IntPtr)
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
