// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Item : GLib.Opaque {

		public int Offset {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("offset"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("offset"));
					*raw_ptr = value;
				}
			}
		}

		public int Length {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("length"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("length"));
					*raw_ptr = value;
				}
			}
		}

		public int NumChars {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("num_chars"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("num_chars"));
					*raw_ptr = value;
				}
			}
		}

		public Pango.Analysis Analysis {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("analysis"));
					return Pango.Analysis.New ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("analysis"));
					*raw_ptr = GLib.Marshaller.StructureToPtrAlloc (value);
				}
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_item_copy(IntPtr raw);
		static d_pango_item_copy pango_item_copy = FuncLoader.LoadFunction<d_pango_item_copy>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_item_copy"));

		public Pango.Item Copy() {
			IntPtr raw_ret = pango_item_copy(Handle);
			Pango.Item ret = raw_ret == IntPtr.Zero ? null : (Pango.Item) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Item), true);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_item_get_type();
		static d_pango_item_get_type pango_item_get_type = FuncLoader.LoadFunction<d_pango_item_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_item_get_type"));

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_item_split(IntPtr raw, int split_index, int split_offset);
		static d_pango_item_split pango_item_split = FuncLoader.LoadFunction<d_pango_item_split>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_item_split"));

		public Pango.Item Split(int split_index, int split_offset) {
			IntPtr raw_ret = pango_item_split(Handle, split_index, split_offset);
			Pango.Item ret = raw_ret == IntPtr.Zero ? null : (Pango.Item) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Item), false);
			return ret;
		}

		public Item(IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_pango_item_new();
		static d_pango_item_new pango_item_new = FuncLoader.LoadFunction<d_pango_item_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_item_new"));

		public Item () 
		{
			Raw = pango_item_new();
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_pango_item_free(IntPtr raw);
		static d_pango_item_free pango_item_free = FuncLoader.LoadFunction<d_pango_item_free>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Pango), "pango_item_free"));

		protected override void Free (IntPtr raw)
		{
			pango_item_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;
			public uint timeoutHandlerId;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				pango_item_free (handle);
				GLib.Timeout.Remove(timeoutHandlerId);
				return false;
			}
		}

		~Item ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			info.timeoutHandlerId = GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public unsafe GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("offset"
							, 0
							, (uint) sizeof( int ) // offset
							, null
							, "length"
							, (long) Marshal.OffsetOf<PangoItem_offsetAlign>("offset")
							, 0
							),
						new GLib.AbiField("length"
							, -1
							, (uint) sizeof( int ) // length
							, "offset"
							, "num_chars"
							, (long) Marshal.OffsetOf<PangoItem_lengthAlign>("length")
							, 0
							),
						new GLib.AbiField("num_chars"
							, -1
							, (uint) sizeof( int ) // num_chars
							, "length"
							, "analysis"
							, (long) Marshal.OffsetOf<PangoItem_num_charsAlign>("num_chars")
							, 0
							),
						new GLib.AbiField("analysis"
							, -1
							, (uint) Marshal.SizeOf<Pango.Analysis>() // analysis
							, "num_chars"
							, null
							, (long) Marshal.OffsetOf<PangoItem_analysisAlign>("analysis")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoItem_offsetAlign
		{
			sbyte f1;
			private int offset;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoItem_lengthAlign
		{
			sbyte f1;
			private int length;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoItem_num_charsAlign
		{
			sbyte f1;
			private int num_chars;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoItem_analysisAlign
		{
			sbyte f1;
			private Pango.Analysis analysis;
		}


		// End of the ABI representation.

#endregion
	}
}
