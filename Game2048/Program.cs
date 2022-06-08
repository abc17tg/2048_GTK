using System;
using Gtk;
using Gdk;

namespace Game2048;

class Program
{
    public static Application App;
    public static Gtk.Window Win;

    [STAThread]
    public static void Main()
    {
        Application.Init();

        App = new Application("org._2048._2048", GLib.ApplicationFlags.None);
        App.Register(GLib.Cancellable.Current);

        Win = new MainWindow();
        App.AddWindow(Win);

        var menu = new GLib.Menu();
        menu.AppendItem(new GLib.MenuItem("Help", "app.help"));
        menu.AppendItem(new GLib.MenuItem("About", "app.about"));
        App.AppMenu = menu;

        var helpAction = new GLib.SimpleAction("help", null);
        helpAction.Activated += HelpActivated;
        App.AddAction(helpAction);

        var aboutAction = new GLib.SimpleAction("about", null);
        aboutAction.Activated += AboutActivated;
        App.AddAction(aboutAction);

        Win.ShowAll();
        Application.Run();
    }

    public static void Restart()
    {
        App.RemoveWindow(Win);
        Win.Close();
        Win.Destroy();
        Win.Dispose();
        Win = null;

        Win = new MainWindow();
        App.AddWindow(Win);
        Win.ShowAll();
    }

    private static void HelpActivated(object sender, EventArgs e)
    {      
        var label = new Label();
        label.Text = "Use arrows to get\n2048";

        var dialog = new Dialog();
        dialog.TransientFor = Win;
        dialog.Icon = new Picture("Logo").GetImage().Pixbuf;
        dialog.Title = "Help";
        dialog.Resizable = true;
        dialog.SetDefaultSize(100, 100);
        dialog.AddButton("Close",ResponseType.Close);
        dialog.ContentArea.Add(label);
        dialog.ShowAll();
        dialog.Run();
        dialog.Hide();
    }

    private static void AboutActivated(object sender, EventArgs e)
    {
        var dialog = new AboutDialog
        {
            TransientFor = Win,
            ProgramName = "2048 Game",
            Version = "v1.0",
            Logo = new Picture("Logo").GetImage(200, 200).Pixbuf,
            Comments = "Created using GtkSharp",
            Website = "https://www.github.com/GtkSharp/GtkSharp",
            WebsiteLabel = "GtkSharp Website",
        };

        dialog.Run();
        dialog.Hide();
    }
}
