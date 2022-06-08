using Gtk;
using Gdk;
using Cairo;
using System.Numerics;
using System;

namespace Game2048;

class MainWindow : Gtk.Window
{
    private HeaderBar headerBar;

    private Button playButton;
    private Button randomButton;
    private Button quitButton;

    public BlocksController blocksController;
    public DrawingArea DrawArea;
    public Block block;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        WindowPosition = WindowPosition.Center;
        InitStartButtons();
        InitHeaderBar();

        Titlebar = headerBar;
        block = new Block();
        GameArea DrawArea = new GameArea();
        DrawArea.SetSizeRequest(GameParameters.BlockSize * GameParameters.RowColumnCount + (GameParameters.RowColumnCount + 1) * GameParameters.BlockOffset,
            GameParameters.BlockSize * GameParameters.RowColumnCount + (GameParameters.RowColumnCount + 1) * GameParameters.BlockOffset);
        DrawArea.ShowAll();
        Child = DrawArea;

        int pow = 0;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                DrawArea.DrawBlock((int)Math.Pow(2, pow++), new Cairo.Point(i * GameParameters.BlockSize, j * GameParameters.BlockSize));


        /*
        drawArea.RegisterWindow(window);

        var cx = Gdk.CairoHelper.Create(drawArea.Window);
        drawArea.SetSizeRequest(150, 150);
        block.DrawRoundedSquare(cx, new System.Numerics.Vector4(150, 0, 150, 0), 3);*/
        //Child = blocksController.View.GameGrid;

        //KeyPressEvent += blocksController.Move;
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
        randomButton.Clicked += (sender, e) => blocksController.Move(Utils.RandomEnumValue<BlocksManager.Direction>());

        quitButton = new Button();
        quitButton.Label = "Quit";
        quitButton.Clicked += (sender, e) => Application.Quit();
    }


}

public class GameArea : DrawingArea
{

    public ImageSurface canvas = new ImageSurface(Format.Argb32, 800, 800);

    public GameArea()
    {

    }

    public void Clear()
    {
        canvas = new ImageSurface(Format.Argb32, 800, 800);
        QueueDraw();
    }

    public void DrawBlock(int value, Cairo.Point position)
    {
        using (Context cx = new Context(canvas))
        {
            DrawSquare(cx, value, position);
            if (value != 1)
                DrawText(cx, value, position);
        }
        QueueDraw();
    }

    public void DrawSquare(Context cx, int value, Cairo.Point position)
    {
        cx.LineWidth = 3;
        if (value == 1)
            cx.SetSourceRGB(0.85, 0.85, 0.85);
        else
            cx.SetSourceRGBA(1, 1f - 0.7f * Math.Clamp((Math.Log2(value) + 4) / 16f, 0f, 1f),
                0, Math.Clamp((Math.Log2(value) + 4) / 16f, 0f, 1f));

        int radius = 20;
        int a = 0 + GameParameters.BlockOffset * (position.X / GameParameters.BlockSize + 1) + position.X;
        int b = GameParameters.BlockSize + GameParameters.BlockOffset * (position.X / GameParameters.BlockSize + 1) + position.X;
        int c = 0 + GameParameters.BlockOffset * (position.Y / GameParameters.BlockSize + 1) + position.Y;
        int d = GameParameters.BlockSize + GameParameters.BlockOffset * (position.Y / GameParameters.BlockSize + 1) + position.Y;

        cx.Arc(a + radius, c + radius, radius, 2 * (Math.PI / 2), 3 * (Math.PI / 2));
        cx.Arc(b - radius, c + radius, radius, 3 * (Math.PI / 2), 4 * (Math.PI / 2));
        cx.Arc(b - radius, d - radius, radius, 0 * (Math.PI / 2), 1 * (Math.PI / 2));
        cx.Arc(a + radius, d - radius, radius, 1 * (Math.PI / 2), 2 * (Math.PI / 2));
        cx.ClosePath();
        cx.Fill();
    }

    private void DrawText(Context cx, int value, Cairo.Point position)
    {
        if (value < 32)
            cx.SetSourceRGB(0.2, 0.2, 0.2);
        else
            cx.SetSourceRGB(0.95, 0.95, 0.95);

        Pango.FontDescription font = new Pango.FontDescription();
        font.Family = "Consolas";
        font.Weight = Pango.Weight.Ultraheavy;
        font.Stretch = Pango.Stretch.UltraExpanded;
        font.Size = Convert.ToInt32(GameParameters.BlockFontSize * Pango.Scale.PangoScale);
        Pango.Layout layout = CreatePangoLayout(value.ToString());

        layout.FontDescription = font;
        layout.GetPixelSize(out int text_width, out int text_height);
        cx.MoveTo((GameParameters.BlockSize - text_width) / 2d + position.X + GameParameters.BlockOffset * (position.X / GameParameters.BlockSize + 1),
            (GameParameters.BlockSize - text_height) / 2d + position.Y + GameParameters.BlockOffset * (position.Y / GameParameters.BlockSize + 1));
        Pango.CairoHelper.ShowLayout(cx, layout);
    }

    protected override bool OnDrawn(Context cx)
    {
        cx.SetSourceSurface(canvas, 0, 0);
        cx.Paint();
        return true;
    }
}