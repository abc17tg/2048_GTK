using Gtk;
using Gdk;
using Cairo;
using System.Numerics;
using System;
using System.Collections.Generic;

namespace Game2048;

class MainWindow : Gtk.Window
{
    private HeaderBar headerBar;

    private Button playButton;
    private Button randomButton;
    private Button quitButton;

    //public BlocksController blocksController;
    private BlocksView blocksView;
    private BlocksManager blocksManager;
    public Block block;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        WindowPosition = WindowPosition.Center;
        InitStartButtons();
        InitHeaderBar();

        Titlebar = headerBar;
        //block = new Block();
        blocksView = new BlocksView();
        blocksView.SetSizeRequest((int)Math.Round(GameParameters.WindowSize.X), (int)Math.Round(GameParameters.WindowSize.Y));
        blocksView.ShowAll();
        Child = blocksView;

        blocksManager = new BlocksManager();
        DrawGrid();

        //KeyPressEvent += blocksController.Move;
    }

    private void DrawGrid()
    {
        for (int i = 0; i < GameParameters.BlockCount; i++)
        {
            var coordinates = i.IndexToCoordinatesOfMatrix(GameParameters.RowColumnCount);
            blocksView.DrawBlock(blocksManager.BlocksList[i].Value, new Cairo.Point(coordinates.X, coordinates.Y));
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
        //randomButton.Clicked += (sender, e) => blocksController.Move(Utils.RandomEnumValue<BlocksManager.Direction>());

        quitButton = new Button();
        quitButton.Label = "Quit";
        quitButton.Clicked += (sender, e) => Application.Quit();
    }


}
