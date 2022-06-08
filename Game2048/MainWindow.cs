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
        DrawArea.SetSizeRequest(GameParameters.BlockSize * 4 + 5 * 10, GameParameters.BlockSize * 4 + 5 * 10);
        DrawArea.ShowAll();
        Child = DrawArea;

        int pow = 1;
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                DrawArea.DrawSquare((int)Math.Pow(2, pow++), GameParameters.BlockSize, 10, new Cairo.Point(i * GameParameters.BlockSize, j * GameParameters.BlockSize));


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
        int i = 0;
    }

    public void Clear()
    {
        canvas = new ImageSurface(Format.Argb32, 800, 800);
        QueueDraw();
    }

    public void DrawSquare(int value, int size, int offset, Cairo.Point position)
    {
        using (Context cx = new Context(canvas))
        {
            //cx.MoveTo(position);
            cx.LineWidth = 3;
            cx.SetSourceRGBA(1, 1f - 0.7f * Math.Clamp((Math.Log2(value) + 4) / 16f, 0f, 1f), 
                0, Math.Clamp((Math.Log2(value) + 4) / 16f, 0f, 1f));

            int radius = 20;
            int a = 0 + offset * (position.X / size + 1) + position.X;
            int b = size + offset * (position.X / size + 1) + position.X;
            int c = 0 + offset * (position.Y / size + 1) + position.Y;
            int d = size + offset * (position.Y / size + 1) + position.Y;

            cx.Arc(a + radius, c + radius, radius, 2 * (Math.PI / 2), 3 * (Math.PI / 2));
            cx.Arc(b - radius, c + radius, radius, 3 * (Math.PI / 2), 4 * (Math.PI / 2));
            cx.Arc(b - radius, d - radius, radius, 0 * (Math.PI / 2), 1 * (Math.PI / 2));
            cx.Arc(a + radius, d - radius, radius, 1 * (Math.PI / 2), 2 * (Math.PI / 2));
            cx.ClosePath();
            cx.Fill();

            cx.SetSourceRGB(0.2, 0.2, 0.2);
            cx.LineWidth = 5;
            DrawText(cx, size, value.ToString(), offset, position);
        }
        QueueDraw();
    }

    private void DrawText(Context cr, int size, string text, int offset, Cairo.Point position)
    {
        Pango.FontDescription font = new Pango.FontDescription();
        font.Family = "Consolas";
        font.Weight = Pango.Weight.Ultraheavy;
        font.Stretch = Pango.Stretch.UltraExpanded;
        font.Size = Convert.ToInt32(30 * Pango.Scale.PangoScale);
        Pango.Layout layout = CreatePangoLayout(text);

        layout.FontDescription = font;

        int text_width;
        int text_height;

        layout.GetPixelSize(out text_width, out text_height);
        cr.MoveTo((size - text_width) / 2d + position.X + offset * (position.X / size + 1),
            (size - text_height) / 2d + position.Y + offset * (position.Y / size + 1));

        Pango.CairoHelper.ShowLayout(cr, layout);
    }

    protected override bool OnDrawn(Context c)
    {
        c.SetSourceSurface(canvas, 0, 0);
        c.Paint();
        return true;
    }
}