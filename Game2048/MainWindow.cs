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
    public Block block;

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
        DrawGrid();

        KeyPressEvent += blocksController.Move;
        KeyReleaseEvent += (sender, e) => DrawGrid();
    }

    private void DrawGrid()
    {
        blocksController.View.Clear();
        for (int i = 0; i < GameParameters.BlockCount; i++)
        {
            var coordinates = i.IndexToCoordinatesOfMatrix(GameParameters.RowColumnCount);
            blocksController.View.DrawBlock(blocksController.Blocks.BlocksList[i].Value, new Cairo.Point(coordinates.X, coordinates.Y));
        }
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
            DrawGrid();
        };

        quitButton = new Button();
        quitButton.Label = "Quit";
        quitButton.Clicked += (sender, e) => Application.Quit();
    }


}
