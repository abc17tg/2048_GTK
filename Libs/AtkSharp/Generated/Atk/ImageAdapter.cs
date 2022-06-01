// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ImageAdapter : GLib.GInterfaceAdapter, Atk.IImage {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkImageIface {
			public GetImagePositionNativeDelegate GetImagePosition;
			public GetImageDescriptionNativeDelegate GetImageDescription;
			public GetImageSizeNativeDelegate GetImageSize;
			public SetImageDescriptionNativeDelegate SetImageDescription;
			public GetImageLocaleNativeDelegate GetImageLocale;
		}

		static AtkImageIface iface;

		static ImageAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ImageAdapter));
			iface.GetImagePosition = new GetImagePositionNativeDelegate (GetImagePosition_cb);
			iface.GetImageDescription = new GetImageDescriptionNativeDelegate (GetImageDescription_cb);
			iface.GetImageSize = new GetImageSizeNativeDelegate (GetImageSize_cb);
			iface.SetImageDescription = new SetImageDescriptionNativeDelegate (SetImageDescription_cb);
			iface.GetImageLocale = new GetImageLocaleNativeDelegate (GetImageLocale_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetImagePositionNativeDelegate (IntPtr inst, out int x, out int y, int coord_type);

		static void GetImagePosition_cb (IntPtr inst, out int x, out int y, int coord_type)
		{
			try {
				IImageImplementor __obj = GLib.Object.GetObject (inst, false) as IImageImplementor;
				__obj.GetImagePosition (out x, out y, (Atk.CoordType) coord_type);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetImageDescriptionNativeDelegate (IntPtr inst);

		static IntPtr GetImageDescription_cb (IntPtr inst)
		{
			try {
				IImageImplementor __obj = GLib.Object.GetObject (inst, false) as IImageImplementor;
				string __result;
				__result = __obj.ImageDescription;
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetImageSizeNativeDelegate (IntPtr inst, out int width, out int height);

		static void GetImageSize_cb (IntPtr inst, out int width, out int height)
		{
			try {
				IImageImplementor __obj = GLib.Object.GetObject (inst, false) as IImageImplementor;
				__obj.GetImageSize (out width, out height);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetImageDescriptionNativeDelegate (IntPtr inst, IntPtr description);

		static bool SetImageDescription_cb (IntPtr inst, IntPtr description)
		{
			try {
				IImageImplementor __obj = GLib.Object.GetObject (inst, false) as IImageImplementor;
				bool __result;
				__result = __obj.SetImageDescription (GLib.Marshaller.Utf8PtrToString (description));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetImageLocaleNativeDelegate (IntPtr inst);

		static IntPtr GetImageLocale_cb (IntPtr inst)
		{
			try {
				IImageImplementor __obj = GLib.Object.GetObject (inst, false) as IImageImplementor;
				string __result;
				__result = __obj.ImageLocale;
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
			AtkImageIface native_iface = (AtkImageIface) Marshal.PtrToStructure (ifaceptr, typeof (AtkImageIface));
			native_iface.GetImagePosition = iface.GetImagePosition;
			native_iface.GetImageDescription = iface.GetImageDescription;
			native_iface.GetImageSize = iface.GetImageSize;
			native_iface.SetImageDescription = iface.SetImageDescription;
			native_iface.GetImageLocale = iface.GetImageLocale;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ImageAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ImageAdapter (IImageImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ImageAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_image_get_type();
		static d_atk_image_get_type atk_image_get_type = FuncLoader.LoadFunction<d_atk_image_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_image_get_type"));

		private static GLib.GType _gtype = new GLib.GType (atk_image_get_type ());

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

		public static IImage GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IImage GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IImageImplementor)
				return new ImageAdapter (obj as IImageImplementor);
			else if (obj as IImage == null)
				return new ImageAdapter (obj.Handle);
			else
				return obj as IImage;
		}

		public IImageImplementor Implementor {
			get {
				return implementor as IImageImplementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_image_get_image_description(IntPtr raw);
		static d_atk_image_get_image_description atk_image_get_image_description = FuncLoader.LoadFunction<d_atk_image_get_image_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_image_get_image_description"));

		public string ImageDescription { 
			get {
				IntPtr raw_ret = atk_image_get_image_description(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_atk_image_get_image_locale(IntPtr raw);
		static d_atk_image_get_image_locale atk_image_get_image_locale = FuncLoader.LoadFunction<d_atk_image_get_image_locale>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_image_get_image_locale"));

		public string ImageLocale { 
			get {
				IntPtr raw_ret = atk_image_get_image_locale(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_image_get_image_position(IntPtr raw, out int x, out int y, int coord_type);
		static d_atk_image_get_image_position atk_image_get_image_position = FuncLoader.LoadFunction<d_atk_image_get_image_position>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_image_get_image_position"));

		public void GetImagePosition(out int x, out int y, Atk.CoordType coord_type) {
			atk_image_get_image_position(Handle, out x, out y, (int) coord_type);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_atk_image_get_image_size(IntPtr raw, out int width, out int height);
		static d_atk_image_get_image_size atk_image_get_image_size = FuncLoader.LoadFunction<d_atk_image_get_image_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_image_get_image_size"));

		public void GetImageSize(out int width, out int height) {
			atk_image_get_image_size(Handle, out width, out height);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_atk_image_set_image_description(IntPtr raw, IntPtr description);
		static d_atk_image_set_image_description atk_image_set_image_description = FuncLoader.LoadFunction<d_atk_image_set_image_description>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Atk), "atk_image_set_image_description"));

		public bool SetImageDescription(string description) {
			IntPtr native_description = GLib.Marshaller.StringToPtrGStrdup (description);
			bool raw_ret = atk_image_set_image_description(Handle, native_description);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_description);
			return ret;
		}

#endregion
	}
}
