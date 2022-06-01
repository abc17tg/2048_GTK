// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace WebKit {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct NavigationAction : IEquatable<NavigationAction> {


		public static WebKit.NavigationAction Zero = new WebKit.NavigationAction ();

		public static WebKit.NavigationAction New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return WebKit.NavigationAction.Zero;
			return (WebKit.NavigationAction) Marshal.PtrToStructure (raw, typeof (WebKit.NavigationAction));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_navigation_action_get_type();
		static d_webkit_navigation_action_get_type webkit_navigation_action_get_type = FuncLoader.LoadFunction<d_webkit_navigation_action_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = webkit_navigation_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_webkit_navigation_action_get_modifiers(IntPtr raw);
		static d_webkit_navigation_action_get_modifiers webkit_navigation_action_get_modifiers = FuncLoader.LoadFunction<d_webkit_navigation_action_get_modifiers>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_get_modifiers"));

		public uint Modifiers { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.NavigationAction>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				uint raw_ret = webkit_navigation_action_get_modifiers(this_as_native);
				uint ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint d_webkit_navigation_action_get_mouse_button(IntPtr raw);
		static d_webkit_navigation_action_get_mouse_button webkit_navigation_action_get_mouse_button = FuncLoader.LoadFunction<d_webkit_navigation_action_get_mouse_button>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_get_mouse_button"));

		public uint MouseButton { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.NavigationAction>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				uint raw_ret = webkit_navigation_action_get_mouse_button(this_as_native);
				uint ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_webkit_navigation_action_get_navigation_type(IntPtr raw);
		static d_webkit_navigation_action_get_navigation_type webkit_navigation_action_get_navigation_type = FuncLoader.LoadFunction<d_webkit_navigation_action_get_navigation_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_get_navigation_type"));

		public WebKit.NavigationType NavigationType { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.NavigationAction>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				int raw_ret = webkit_navigation_action_get_navigation_type(this_as_native);
				WebKit.NavigationType ret = (WebKit.NavigationType) raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_webkit_navigation_action_get_request(IntPtr raw);
		static d_webkit_navigation_action_get_request webkit_navigation_action_get_request = FuncLoader.LoadFunction<d_webkit_navigation_action_get_request>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_get_request"));

		public WebKit.URIRequest Request { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.NavigationAction>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = webkit_navigation_action_get_request(this_as_native);
				WebKit.URIRequest ret = GLib.Object.GetObject(raw_ret) as WebKit.URIRequest;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_navigation_action_is_redirect(IntPtr raw);
		static d_webkit_navigation_action_is_redirect webkit_navigation_action_is_redirect = FuncLoader.LoadFunction<d_webkit_navigation_action_is_redirect>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_is_redirect"));

		public bool IsRedirect { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.NavigationAction>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = webkit_navigation_action_is_redirect(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_webkit_navigation_action_is_user_gesture(IntPtr raw);
		static d_webkit_navigation_action_is_user_gesture webkit_navigation_action_is_user_gesture = FuncLoader.LoadFunction<d_webkit_navigation_action_is_user_gesture>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Webkit), "webkit_navigation_action_is_user_gesture"));

		public bool IsUserGesture { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf<WebKit.NavigationAction>());
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				bool raw_ret = webkit_navigation_action_is_user_gesture(this_as_native);
				bool ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		static void ReadNative (IntPtr native, ref WebKit.NavigationAction target)
		{
			target = New (native);
		}

		public bool Equals (NavigationAction other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is NavigationAction && Equals ((NavigationAction) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (WebKit.NavigationAction boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (WebKit.NavigationAction.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator WebKit.NavigationAction (GLib.Value val)
		{
			return (WebKit.NavigationAction) val.Val;
		}
#endregion
	}
}
