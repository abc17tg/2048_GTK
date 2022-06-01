// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using static GLib.AbiStructExtension;

#region Autogenerated code
	public partial class RecentChooserDefault : Gtk.Box, Gtk.IRecentChooser, Gtk.IActivatable {

		public RecentChooserDefault (IntPtr raw) : base(raw) {}

		protected RecentChooserDefault() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_add_filter(IntPtr raw, IntPtr filter);
		static d_gtk_recent_chooser_add_filter gtk_recent_chooser_add_filter = FuncLoader.LoadFunction<d_gtk_recent_chooser_add_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_add_filter"));

		public void AddFilter(Gtk.RecentFilter filter) {
			gtk_recent_chooser_add_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_get_current_item(IntPtr raw);
		static d_gtk_recent_chooser_get_current_item gtk_recent_chooser_get_current_item = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_current_item>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_current_item"));

		public Gtk.RecentInfo CurrentItem { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_current_item(Handle);
				Gtk.RecentInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.RecentInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.RecentInfo), false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_get_current_uri(IntPtr raw);
		static d_gtk_recent_chooser_get_current_uri gtk_recent_chooser_get_current_uri = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_current_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_current_uri"));

		public string CurrentUri { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_current_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_get_filter(IntPtr raw);
		static d_gtk_recent_chooser_get_filter gtk_recent_chooser_get_filter = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_filter"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_filter(IntPtr raw, IntPtr filter);
		static d_gtk_recent_chooser_set_filter gtk_recent_chooser_set_filter = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_filter"));

		public Gtk.RecentFilter Filter { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_filter(Handle);
				Gtk.RecentFilter ret = GLib.Object.GetObject(raw_ret) as Gtk.RecentFilter;
				return ret;
			}
			set {
				gtk_recent_chooser_set_filter(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_get_items(IntPtr raw);
		static d_gtk_recent_chooser_get_items gtk_recent_chooser_get_items = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_items>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_items"));

		public Gtk.RecentInfo[] Items { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_items(Handle);
				Gtk.RecentInfo[] ret = GLib.Marshaller.ListPtrToArray<Gtk.RecentInfo, Gtk.RecentInfo> (raw_ret, true, true);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_recent_chooser_get_limit(IntPtr raw);
		static d_gtk_recent_chooser_get_limit gtk_recent_chooser_get_limit = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_limit>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_limit"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_limit(IntPtr raw, int limit);
		static d_gtk_recent_chooser_set_limit gtk_recent_chooser_set_limit = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_limit>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_limit"));

		public int Limit { 
			get {
				int raw_ret = gtk_recent_chooser_get_limit(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_limit(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_get_local_only(IntPtr raw);
		static d_gtk_recent_chooser_get_local_only gtk_recent_chooser_get_local_only = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_local_only>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_local_only"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_local_only(IntPtr raw, bool local_only);
		static d_gtk_recent_chooser_set_local_only gtk_recent_chooser_set_local_only = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_local_only>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_local_only"));

		public bool LocalOnly { 
			get {
				bool raw_ret = gtk_recent_chooser_get_local_only(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_local_only(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_get_select_multiple(IntPtr raw);
		static d_gtk_recent_chooser_get_select_multiple gtk_recent_chooser_get_select_multiple = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_select_multiple>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_select_multiple"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_select_multiple(IntPtr raw, bool select_multiple);
		static d_gtk_recent_chooser_set_select_multiple gtk_recent_chooser_set_select_multiple = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_select_multiple>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_select_multiple"));

		public bool SelectMultiple { 
			get {
				bool raw_ret = gtk_recent_chooser_get_select_multiple(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_select_multiple(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_get_show_icons(IntPtr raw);
		static d_gtk_recent_chooser_get_show_icons gtk_recent_chooser_get_show_icons = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_show_icons>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_show_icons"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_show_icons(IntPtr raw, bool show_icons);
		static d_gtk_recent_chooser_set_show_icons gtk_recent_chooser_set_show_icons = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_show_icons>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_show_icons"));

		public bool ShowIcons { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_icons(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_icons(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_get_show_not_found(IntPtr raw);
		static d_gtk_recent_chooser_get_show_not_found gtk_recent_chooser_get_show_not_found = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_show_not_found>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_show_not_found"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_show_not_found(IntPtr raw, bool show_not_found);
		static d_gtk_recent_chooser_set_show_not_found gtk_recent_chooser_set_show_not_found = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_show_not_found>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_show_not_found"));

		public bool ShowNotFound { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_not_found(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_not_found(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_get_show_private(IntPtr raw);
		static d_gtk_recent_chooser_get_show_private gtk_recent_chooser_get_show_private = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_show_private>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_show_private"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_show_private(IntPtr raw, bool show_private);
		static d_gtk_recent_chooser_set_show_private gtk_recent_chooser_set_show_private = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_show_private>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_show_private"));

		public bool ShowPrivate { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_private(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_private(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_get_show_tips(IntPtr raw);
		static d_gtk_recent_chooser_get_show_tips gtk_recent_chooser_get_show_tips = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_show_tips>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_show_tips"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_show_tips(IntPtr raw, bool show_tips);
		static d_gtk_recent_chooser_set_show_tips gtk_recent_chooser_set_show_tips = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_show_tips>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_show_tips"));

		public bool ShowTips { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_tips(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_show_tips(Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int d_gtk_recent_chooser_get_sort_type(IntPtr raw);
		static d_gtk_recent_chooser_get_sort_type gtk_recent_chooser_get_sort_type = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_sort_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_sort_type"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_sort_type(IntPtr raw, int sort_type);
		static d_gtk_recent_chooser_set_sort_type gtk_recent_chooser_set_sort_type = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_sort_type>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_sort_type"));

		public Gtk.RecentSortType SortType { 
			get {
				int raw_ret = gtk_recent_chooser_get_sort_type(Handle);
				Gtk.RecentSortType ret = (Gtk.RecentSortType) raw_ret;
				return ret;
			}
			set {
				gtk_recent_chooser_set_sort_type(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_get_uris(IntPtr raw, out UIntPtr length);
		static d_gtk_recent_chooser_get_uris gtk_recent_chooser_get_uris = FuncLoader.LoadFunction<d_gtk_recent_chooser_get_uris>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_get_uris"));

		public string[] GetUris(out ulong length) {
			UIntPtr native_length;
			IntPtr raw_ret = gtk_recent_chooser_get_uris(Handle, out native_length);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			length = (ulong) native_length;
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_recent_chooser_list_filters(IntPtr raw);
		static d_gtk_recent_chooser_list_filters gtk_recent_chooser_list_filters = FuncLoader.LoadFunction<d_gtk_recent_chooser_list_filters>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_list_filters"));

		public Gtk.RecentFilter[] Filters { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_list_filters(Handle);
				Gtk.RecentFilter[] ret = GLib.Marshaller.SListPtrToArray<Gtk.RecentFilter, Gtk.RecentFilter> (raw_ret, true, false);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_remove_filter(IntPtr raw, IntPtr filter);
		static d_gtk_recent_chooser_remove_filter gtk_recent_chooser_remove_filter = FuncLoader.LoadFunction<d_gtk_recent_chooser_remove_filter>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_remove_filter"));

		public void RemoveFilter(Gtk.RecentFilter filter) {
			gtk_recent_chooser_remove_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_select_all(IntPtr raw);
		static d_gtk_recent_chooser_select_all gtk_recent_chooser_select_all = FuncLoader.LoadFunction<d_gtk_recent_chooser_select_all>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_select_all"));

		public void SelectAll() {
			gtk_recent_chooser_select_all(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_select_uri(IntPtr raw, IntPtr uri, out IntPtr error);
		static d_gtk_recent_chooser_select_uri gtk_recent_chooser_select_uri = FuncLoader.LoadFunction<d_gtk_recent_chooser_select_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_select_uri"));

		public bool SelectUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_chooser_select_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_recent_chooser_set_current_uri(IntPtr raw, IntPtr uri, out IntPtr error);
		static d_gtk_recent_chooser_set_current_uri gtk_recent_chooser_set_current_uri = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_current_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_current_uri"));

		public bool SetCurrentUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_chooser_set_current_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_set_sort_func(IntPtr raw, GtkSharp.RecentSortFuncNative sort_func, IntPtr sort_data, GLib.DestroyNotify data_destroy);
		static d_gtk_recent_chooser_set_sort_func gtk_recent_chooser_set_sort_func = FuncLoader.LoadFunction<d_gtk_recent_chooser_set_sort_func>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_set_sort_func"));

		public Gtk.RecentSortFunc SortFunc { 
			set {
				GtkSharp.RecentSortFuncWrapper value_wrapper = new GtkSharp.RecentSortFuncWrapper (value);
				IntPtr sort_data;
				GLib.DestroyNotify data_destroy;
				if (value == null) {
					sort_data = IntPtr.Zero;
					data_destroy = null;
				} else {
					sort_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					data_destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_recent_chooser_set_sort_func(Handle, value_wrapper.NativeDelegate, sort_data, data_destroy);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_unselect_all(IntPtr raw);
		static d_gtk_recent_chooser_unselect_all gtk_recent_chooser_unselect_all = FuncLoader.LoadFunction<d_gtk_recent_chooser_unselect_all>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_unselect_all"));

		public void UnselectAll() {
			gtk_recent_chooser_unselect_all(Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_recent_chooser_unselect_uri(IntPtr raw, IntPtr uri);
		static d_gtk_recent_chooser_unselect_uri gtk_recent_chooser_unselect_uri = FuncLoader.LoadFunction<d_gtk_recent_chooser_unselect_uri>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_recent_chooser_unselect_uri"));

		public void UnselectUri(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			gtk_recent_chooser_unselect_uri(Handle, native_uri);
			GLib.Marshaller.Free (native_uri);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_do_set_related_action(IntPtr raw, IntPtr action);
		static d_gtk_activatable_do_set_related_action gtk_activatable_do_set_related_action = FuncLoader.LoadFunction<d_gtk_activatable_do_set_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_do_set_related_action"));

		[Obsolete]
		public void DoSetRelatedAction(Gtk.Action action) {
			gtk_activatable_do_set_related_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_sync_action_properties(IntPtr raw, IntPtr action);
		static d_gtk_activatable_sync_action_properties gtk_activatable_sync_action_properties = FuncLoader.LoadFunction<d_gtk_activatable_sync_action_properties>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_sync_action_properties"));

		[Obsolete]
		public void SyncActionProperties(Gtk.Action action) {
			gtk_activatable_sync_action_properties(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr d_gtk_activatable_get_related_action(IntPtr raw);
		static d_gtk_activatable_get_related_action gtk_activatable_get_related_action = FuncLoader.LoadFunction<d_gtk_activatable_get_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_related_action"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_set_related_action(IntPtr raw, IntPtr action);
		static d_gtk_activatable_set_related_action gtk_activatable_set_related_action = FuncLoader.LoadFunction<d_gtk_activatable_set_related_action>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_set_related_action"));

		[Obsolete]
		[GLib.Property ("related-action")]
		public Gtk.Action RelatedAction {
			get  {
				IntPtr raw_ret = gtk_activatable_get_related_action(Handle);
				Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
				return ret;
			}
			set  {
				gtk_activatable_set_related_action(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool d_gtk_activatable_get_use_action_appearance(IntPtr raw);
		static d_gtk_activatable_get_use_action_appearance gtk_activatable_get_use_action_appearance = FuncLoader.LoadFunction<d_gtk_activatable_get_use_action_appearance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_get_use_action_appearance"));

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void d_gtk_activatable_set_use_action_appearance(IntPtr raw, bool use_appearance);
		static d_gtk_activatable_set_use_action_appearance gtk_activatable_set_use_action_appearance = FuncLoader.LoadFunction<d_gtk_activatable_set_use_action_appearance>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_activatable_set_use_action_appearance"));

		[Obsolete]
		[GLib.Property ("use-action-appearance")]
		public bool UseActionAppearance {
			get  {
				bool raw_ret = gtk_activatable_get_use_action_appearance(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_activatable_set_use_action_appearance(Handle, value);
			}
		}

#endregion
	}
}
