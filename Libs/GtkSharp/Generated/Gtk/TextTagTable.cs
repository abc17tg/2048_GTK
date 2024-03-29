// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class TextTagTable : GLib.Object {

		public TextTagTable (IntPtr raw) : base(raw) {}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_text_tag_table_new();
		static d_gtk_text_tag_table_new gtk_text_tag_table_new = FuncLoader.LoadFunction<d_gtk_text_tag_table_new>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_new"));

		public TextTagTable () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TextTagTable)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_text_tag_table_new();
		}

		[GLib.Signal("tag-added")]
		public event Gtk.TagAddedHandler TagAdded {
			add {
				this.AddSignalHandler ("tag-added", value, typeof (Gtk.TagAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("tag-added", value);
			}
		}

		[GLib.Signal("tag-removed")]
		public event Gtk.TagRemovedHandler TagRemoved {
			add {
				this.AddSignalHandler ("tag-removed", value, typeof (Gtk.TagRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("tag-removed", value);
			}
		}

		[GLib.Signal("tag-changed")]
		public event Gtk.TagChangedHandler TagChanged {
			add {
				this.AddSignalHandler ("tag-changed", value, typeof (Gtk.TagChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("tag-changed", value);
			}
		}

		static TagChangedNativeDelegate TagChanged_cb_delegate;
		static TagChangedNativeDelegate TagChangedVMCallback {
			get {
				if (TagChanged_cb_delegate == null)
					TagChanged_cb_delegate = new TagChangedNativeDelegate (TagChanged_cb);
				return TagChanged_cb_delegate;
			}
		}

		static void OverrideTagChanged (GLib.GType gtype)
		{
			OverrideTagChanged (gtype, TagChangedVMCallback);
		}

		static void OverrideTagChanged (GLib.GType gtype, TagChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("tag_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TagChangedNativeDelegate (IntPtr inst, IntPtr tag, bool size_changed);

		static void TagChanged_cb (IntPtr inst, IntPtr tag, bool size_changed)
		{
			try {
				TextTagTable __obj = GLib.Object.GetObject (inst, false) as TextTagTable;
				__obj.OnTagChanged (GLib.Object.GetObject(tag) as Gtk.TextTag, size_changed);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TextTagTable), ConnectionMethod="OverrideTagChanged")]
		protected virtual void OnTagChanged (Gtk.TextTag tag, bool size_changed)
		{
			InternalTagChanged (tag, size_changed);
		}

		private void InternalTagChanged (Gtk.TextTag tag, bool size_changed)
		{
			TagChangedNativeDelegate unmanaged = class_abi.BaseOverride<TagChangedNativeDelegate>(this.LookupGType(), "tag_changed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, tag == null ? IntPtr.Zero : tag.Handle, size_changed);
		}

		static TagAddedNativeDelegate TagAdded_cb_delegate;
		static TagAddedNativeDelegate TagAddedVMCallback {
			get {
				if (TagAdded_cb_delegate == null)
					TagAdded_cb_delegate = new TagAddedNativeDelegate (TagAdded_cb);
				return TagAdded_cb_delegate;
			}
		}

		static void OverrideTagAdded (GLib.GType gtype)
		{
			OverrideTagAdded (gtype, TagAddedVMCallback);
		}

		static void OverrideTagAdded (GLib.GType gtype, TagAddedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("tag_added"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TagAddedNativeDelegate (IntPtr inst, IntPtr tag);

		static void TagAdded_cb (IntPtr inst, IntPtr tag)
		{
			try {
				TextTagTable __obj = GLib.Object.GetObject (inst, false) as TextTagTable;
				__obj.OnTagAdded (GLib.Object.GetObject(tag) as Gtk.TextTag);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TextTagTable), ConnectionMethod="OverrideTagAdded")]
		protected virtual void OnTagAdded (Gtk.TextTag tag)
		{
			InternalTagAdded (tag);
		}

		private void InternalTagAdded (Gtk.TextTag tag)
		{
			TagAddedNativeDelegate unmanaged = class_abi.BaseOverride<TagAddedNativeDelegate>(this.LookupGType(), "tag_added");
			if (unmanaged == null) return;

			unmanaged (this.Handle, tag == null ? IntPtr.Zero : tag.Handle);
		}

		static TagRemovedNativeDelegate TagRemoved_cb_delegate;
		static TagRemovedNativeDelegate TagRemovedVMCallback {
			get {
				if (TagRemoved_cb_delegate == null)
					TagRemoved_cb_delegate = new TagRemovedNativeDelegate (TagRemoved_cb);
				return TagRemoved_cb_delegate;
			}
		}

		static void OverrideTagRemoved (GLib.GType gtype)
		{
			OverrideTagRemoved (gtype, TagRemovedVMCallback);
		}

		static void OverrideTagRemoved (GLib.GType gtype, TagRemovedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("tag_removed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate(callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TagRemovedNativeDelegate (IntPtr inst, IntPtr tag);

		static void TagRemoved_cb (IntPtr inst, IntPtr tag)
		{
			try {
				TextTagTable __obj = GLib.Object.GetObject (inst, false) as TextTagTable;
				__obj.OnTagRemoved (GLib.Object.GetObject(tag) as Gtk.TextTag);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.TextTagTable), ConnectionMethod="OverrideTagRemoved")]
		protected virtual void OnTagRemoved (Gtk.TextTag tag)
		{
			InternalTagRemoved (tag);
		}

		private void InternalTagRemoved (Gtk.TextTag tag)
		{
			TagRemovedNativeDelegate unmanaged = class_abi.BaseOverride<TagRemovedNativeDelegate>(this.LookupGType(), "tag_removed");
			if (unmanaged == null) return;

			unmanaged (this.Handle, tag == null ? IntPtr.Zero : tag.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public unsafe new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("tag_changed"
							, GLib.Object.class_abi.Fields
							, (uint) sizeof( IntPtr ) // tag_changed
							, null
							, "tag_added"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("tag_added"
							, -1
							, (uint) sizeof( IntPtr ) // tag_added
							, "tag_changed"
							, "tag_removed"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("tag_removed"
							, -1
							, (uint) sizeof( IntPtr ) // tag_removed
							, "tag_added"
							, "_gtk_reserved1"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved1
							, "tag_removed"
							, "_gtk_reserved2"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) sizeof(IntPtr)
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) sizeof( IntPtr ) // _gtk_reserved4
							, "_gtk_reserved3"
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
		delegate bool d_gtk_text_tag_table_add(IntPtr raw, IntPtr tag);
		static d_gtk_text_tag_table_add gtk_text_tag_table_add = FuncLoader.LoadFunction<d_gtk_text_tag_table_add>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_add"));

		public bool Add(Gtk.TextTag tag) {
			bool raw_ret = gtk_text_tag_table_add(Handle, tag == null ? IntPtr.Zero : tag.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_text_tag_table_foreach(IntPtr raw, GtkSharp.TextTagTableForeachNative func, IntPtr data);
		static d_gtk_text_tag_table_foreach gtk_text_tag_table_foreach = FuncLoader.LoadFunction<d_gtk_text_tag_table_foreach>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_foreach"));

		public void Foreach(Gtk.TextTagTableForeach func) {
			GtkSharp.TextTagTableForeachWrapper func_wrapper = new GtkSharp.TextTagTableForeachWrapper (func);
			gtk_text_tag_table_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_text_tag_table_get_size(IntPtr raw);
		static d_gtk_text_tag_table_get_size gtk_text_tag_table_get_size = FuncLoader.LoadFunction<d_gtk_text_tag_table_get_size>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_get_size"));

		public int Size { 
			get {
				int raw_ret = gtk_text_tag_table_get_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_text_tag_table_get_type();
		static d_gtk_text_tag_table_get_type gtk_text_tag_table_get_type = FuncLoader.LoadFunction<d_gtk_text_tag_table_get_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_get_type"));

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_text_tag_table_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_text_tag_table_lookup(IntPtr raw, IntPtr name);
		static d_gtk_text_tag_table_lookup gtk_text_tag_table_lookup = FuncLoader.LoadFunction<d_gtk_text_tag_table_lookup>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_lookup"));

		public Gtk.TextTag Lookup(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gtk_text_tag_table_lookup(Handle, native_name);
			Gtk.TextTag ret = GLib.Object.GetObject(raw_ret) as Gtk.TextTag;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_text_tag_table_remove(IntPtr raw, IntPtr tag);
		static d_gtk_text_tag_table_remove gtk_text_tag_table_remove = FuncLoader.LoadFunction<d_gtk_text_tag_table_remove>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_tag_table_remove"));

		public void Remove(Gtk.TextTag tag) {
			gtk_text_tag_table_remove(Handle, tag == null ? IntPtr.Zero : tag.Handle);
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
