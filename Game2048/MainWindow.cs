using Gtk;
using System;

namespace Game2048;

class MainWindow : Gtk.Window
{
    private HeaderBar headerBar;

    private Button playButton;
    private Button randomButton;
    private Button quitButton;

    public BlocksController blocksController;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        WindowPosition = WindowPosition.Center;
        InitStartButtons();
        InitHeaderBar();

        Titlebar = headerBar;
        blocksController = new BlocksController();
        blocksController.View.SetSizeRequest((int)Math.Round(GameParameters.WindowSize.X), (int)Math.Round(GameParameters.WindowSize.Y));
        blocksController.View.ShowAll();
        Child = blocksController.View;
        blocksController.View.DrawGrid(blocksController.Blocks.BlocksMatrix);

        KeyPressEvent += blocksController.Move;
        KeyReleaseEvent += (sender, e) => blocksController.View.DrawGrid(blocksController.Blocks.BlocksMatrix);
    }

    private void InitHeaderBar()
    {
        headerBar = new HeaderBar();
        headerBar.ShowCloseButton = true;
        headerBar.DecorationLayout = "menu:";
        headerBar.Title = "2048";
        headerBar.PackEnd(quitButton);
        Box box = new Box(Orientation.Horizontal, 3);
        box.Add(playButton);
        box.Add(randomButton);
        headerBar.PackStart(box);
        headerBar.ShowAll();
    }

    private void InitStartButtons()
    {
        playButton = new Button();
        playButton.Label = "Play";
        playButton.Clicked += (sender, e) => Program.Restart();

        randomButton = new Button();
        randomButton.Label = "Random";
        randomButton.Clicked += (sender, e) =>
        {
            blocksController.Move(Utils.RandomEnumValue<BlocksController.Direction>());
            blocksController.View.DrawGrid(blocksController.Blocks.BlocksMatrix);
        };

        quitButton = new Button();
        quitButton.Label = "Quit";
        quitButton.Clicked += (sender, e) => Application.Quit();
    }


}
