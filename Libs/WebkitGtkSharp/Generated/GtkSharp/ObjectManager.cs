// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp.WebkitGtkSharp {

	public class ObjectManager {

		static bool initialized = false;
		// Call this method from the appropriate module init function.
		public static void Initialize ()
		{
			if (initialized)
				return;

			initialized = true;
			GLib.GType.Register (WebKit.AuthenticationRequest.GType, typeof (WebKit.AuthenticationRequest));
			GLib.GType.Register (WebKit.AutomationSession.GType, typeof (WebKit.AutomationSession));
			GLib.GType.Register (WebKit.BackForwardList.GType, typeof (WebKit.BackForwardList));
			GLib.GType.Register (WebKit.BackForwardListItem.GType, typeof (WebKit.BackForwardListItem));
			GLib.GType.Register (WebKit.ColorChooserRequest.GType, typeof (WebKit.ColorChooserRequest));
			GLib.GType.Register (WebKit.ContextMenu.GType, typeof (WebKit.ContextMenu));
			GLib.GType.Register (WebKit.ContextMenuItem.GType, typeof (WebKit.ContextMenuItem));
			GLib.GType.Register (WebKit.CookieManager.GType, typeof (WebKit.CookieManager));
			GLib.GType.Register (WebKit.DeviceInfoPermissionRequest.GType, typeof (WebKit.DeviceInfoPermissionRequest));
			GLib.GType.Register (WebKit.Download.GType, typeof (WebKit.Download));
			GLib.GType.Register (WebKit.EditorState.GType, typeof (WebKit.EditorState));
			GLib.GType.Register (WebKit.FaviconDatabase.GType, typeof (WebKit.FaviconDatabase));
			GLib.GType.Register (WebKit.FileChooserRequest.GType, typeof (WebKit.FileChooserRequest));
			GLib.GType.Register (WebKit.FindController.GType, typeof (WebKit.FindController));
			GLib.GType.Register (WebKit.FormSubmissionRequest.GType, typeof (WebKit.FormSubmissionRequest));
			GLib.GType.Register (WebKit.GeolocationManager.GType, typeof (WebKit.GeolocationManager));
			GLib.GType.Register (WebKit.GeolocationPermissionRequest.GType, typeof (WebKit.GeolocationPermissionRequest));
			GLib.GType.Register (WebKit.HitTestResult.GType, typeof (WebKit.HitTestResult));
			GLib.GType.Register (WebKit.InputMethodContext.GType, typeof (WebKit.InputMethodContext));
			GLib.GType.Register (WebKit.InstallMissingMediaPluginsPermissionRequest.GType, typeof (WebKit.InstallMissingMediaPluginsPermissionRequest));
			GLib.GType.Register (WebKit.MediaKeySystemPermissionRequest.GType, typeof (WebKit.MediaKeySystemPermissionRequest));
			GLib.GType.Register (WebKit.NavigationPolicyDecision.GType, typeof (WebKit.NavigationPolicyDecision));
			GLib.GType.Register (WebKit.Notification.GType, typeof (WebKit.Notification));
			GLib.GType.Register (WebKit.NotificationPermissionRequest.GType, typeof (WebKit.NotificationPermissionRequest));
			GLib.GType.Register (WebKit.OptionMenu.GType, typeof (WebKit.OptionMenu));
			GLib.GType.Register (WebKit.Plugin.GType, typeof (WebKit.Plugin));
			GLib.GType.Register (WebKit.PointerLockPermissionRequest.GType, typeof (WebKit.PointerLockPermissionRequest));
			GLib.GType.Register (WebKit.PolicyDecision.GType, typeof (WebKit.PolicyDecision));
			GLib.GType.Register (WebKit.PrintCustomWidget.GType, typeof (WebKit.PrintCustomWidget));
			GLib.GType.Register (WebKit.PrintOperation.GType, typeof (WebKit.PrintOperation));
			GLib.GType.Register (WebKit.ResponsePolicyDecision.GType, typeof (WebKit.ResponsePolicyDecision));
			GLib.GType.Register (WebKit.SecurityManager.GType, typeof (WebKit.SecurityManager));
			GLib.GType.Register (WebKit.Settings.GType, typeof (WebKit.Settings));
			GLib.GType.Register (WebKit.URIRequest.GType, typeof (WebKit.URIRequest));
			GLib.GType.Register (WebKit.URIResponse.GType, typeof (WebKit.URIResponse));
			GLib.GType.Register (WebKit.URISchemeRequest.GType, typeof (WebKit.URISchemeRequest));
			GLib.GType.Register (WebKit.UserContentFilterStore.GType, typeof (WebKit.UserContentFilterStore));
			GLib.GType.Register (WebKit.UserContentManager.GType, typeof (WebKit.UserContentManager));
			GLib.GType.Register (WebKit.UserMediaPermissionRequest.GType, typeof (WebKit.UserMediaPermissionRequest));
			GLib.GType.Register (WebKit.UserMessage.GType, typeof (WebKit.UserMessage));
			GLib.GType.Register (WebKit.WebContext.GType, typeof (WebKit.WebContext));
			GLib.GType.Register (WebKit.WebInspector.GType, typeof (WebKit.WebInspector));
			GLib.GType.Register (WebKit.WebResource.GType, typeof (WebKit.WebResource));
			GLib.GType.Register (WebKit.WebView.GType, typeof (WebKit.WebView));
			GLib.GType.Register (WebKit.WebViewBase.GType, typeof (WebKit.WebViewBase));
			GLib.GType.Register (WebKit.WebsiteDataAccessPermissionRequest.GType, typeof (WebKit.WebsiteDataAccessPermissionRequest));
			GLib.GType.Register (WebKit.WebsiteDataManager.GType, typeof (WebKit.WebsiteDataManager));
			GLib.GType.Register (WebKit.WebsitePolicies.GType, typeof (WebKit.WebsitePolicies));
			GLib.GType.Register (WebKit.WindowProperties.GType, typeof (WebKit.WindowProperties));
		}
	}
}
