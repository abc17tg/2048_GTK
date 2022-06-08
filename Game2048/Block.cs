using Gtk;
using Cairo;
using Gdk;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Game2048;
public class Block
{
    public int Value;
    public ImageSurface ImSurface;
    public Antialias Antialiasing = Antialias.Subpixel;



    public Block()
    {
        ImSurface = new ImageSurface(Format.ARGB32, 150, 150);
    }

    public void DrawRoundedSquare(Gdk.Window window)
    {
        Context ring = Gdk.CairoHelper.Create(window);
        PointD point1, point2;
        point1 = new PointD(70, 0);
        point2 = new PointD(95, 0);
        ring.Antialias = Antialiasing;
        ring.Translate(100, 100);
        ring.Fill();
        ring.LineWidth = 3;
        ring.MoveTo(point1);
        ring.LineTo(point2);
        ring.SetSourceColor(new Cairo.Color(1, 0, 0));
        ring.Stroke();
        ring.GetTarget().Dispose();
        ring.Dispose();
    }

    public void DrawRoundedSquare(Context cx, Vector4 coordinates, int radius)
    {
        //var cx = new Context(ImSurface);
        cx.LineWidth = 3;
        cx.SetSourceRGB(1, 0, 0); 
        int a = (int)coordinates.X;
        int b = (int)coordinates.Y;
        int c = (int)coordinates.Z;
        int d = (int)coordinates.W;

        cx.Arc(a + radius, c + radius, radius, 2 * (Math.PI / 2), 3 * (Math.PI / 2));
        cx.Arc(b - radius, c + radius, radius, 3 * (Math.PI / 2), 4 * (Math.PI / 2));
        cx.Arc(b - radius, d - radius, radius, 0 * (Math.PI / 2), 1 * (Math.PI / 2));
        cx.Arc(a + radius, d - radius, radius, 1 * (Math.PI / 2), 2 * (Math.PI / 2));
        cx.ClosePath();
        cx.Fill();
    }



}



enum Tool { Square, Circle, Triangle };

class Area : DrawingArea
{
    ImageSurface canvas = new ImageSurface(Format.Argb32, 400, 400);
    public Tool tool = Tool.Square;

    public Area()
    {
        AddEvents((int)EventMask.ButtonPressMask);
        SetSizeRequest(400, 400);
    }

    public void clear()
    {
        canvas = new ImageSurface(Format.Argb32, 400, 400);
        QueueDraw();
    }

    protected override bool OnButtonPressEvent(EventButton e)
    {
        using (Context c = new Context(canvas))
        {
            c.SetSourceRGB(0, 0, 0);    // black
            c.LineWidth = 4;

            switch (tool)
            {
                case Tool.Square:
                    c.Rectangle(e.X - 50, e.Y - 50, 100, 100);
                    break;
                case Tool.Circle:
                    c.Arc(xc: e.X, yc: e.Y, radius: 50, angle1: 0, angle2: 2 * Math.PI);
                    break;
                case Tool.Triangle:
                    c.MoveTo(e.X, e.Y - 60);
                    c.LineTo(e.X + 60, e.Y + 30);
                    c.LineTo(e.X - 60, e.Y + 30);
                    c.ClosePath();
                    break;
            }

            c.StrokePreserve();
            Random rand = new Random();
            c.SetSourceRGB(rand.NextDouble(), rand.NextDouble(), rand.NextDouble());
            c.Fill();
        }

        QueueDraw();
        return true;
    }

    protected override bool OnDrawn(Context c)
    {
        c.SetSourceSurface(canvas, 0, 0);
        c.Paint();
        return true;
    }
}

class MyWindow : Gtk.Window
{
    Toolbar toolbar = new Toolbar();
    Area area = new Area();
    bool toggling;

    public MyWindow() : base("hello, world")
    {
        toolbar.Style = ToolbarStyle.Icons;

        ToggleToolButton square_button = toggle_button(square_icon(), Tool.Square);
        square_button.Active = true;
        toolbar.Add(square_button);
        toolbar.Add(toggle_button(circle_icon(), Tool.Circle));
        toolbar.Add(toggle_button(triangle_icon(), Tool.Triangle));

        toolbar.Add(new SeparatorToolItem());
        ToolButton b = new ToolButton(new Image(Gtk.Stock.Clear, IconSize.SmallToolbar), "clear");
        b.Clicked += on_clear;
        toolbar.Add(b);

        Box vbox = new Box(Orientation.Vertical, 0);
        vbox.Add(toolbar);
        vbox.PackStart(area, true, true, 0);
        Add(vbox);
    }

    Image icon(Action<Context> draw)
    {
        ImageSurface s = new ImageSurface(Format.Argb32, 16, 16);
        using (Context c = new Context(s))
        {
            c.SetSourceRGB(0, 0, 0);    // black
            c.LineWidth = 4;
            draw(c);
            c.StrokePreserve();
            c.SetSourceRGB(1, 1, 1);    // white
            c.Fill();
        }
        return new Image(s);
    }

    Image square_icon() => icon(c => c.Rectangle(2, 2, 12, 12));

    Image circle_icon() => icon(c => c.Arc(xc: 8, yc: 8, radius: 6,
                                           angle1: 0, angle2: 2 * Math.PI));

    void draw_triangle_icon(Context c)
    {
        c.MoveTo(8, 4);
        c.LineTo(14, 13);
        c.LineTo(2, 13);
        c.ClosePath();
    }

    Image triangle_icon() => icon(draw_triangle_icon);

    void toggle(object? sender, Tool tool)
    {
        if (toggling)
            return;     // prevent recursive invocations

        toggling = true;
        area.tool = tool;

        foreach (ToolItem b in toolbar)
            if (b != sender && b is ToggleToolButton ttb)
                ttb.Active = false;  // will fire Clicked event
        toggling = false;
    }

    ToggleToolButton toggle_button(Image icon, Tool tool)
    {
        ToggleToolButton b = new ToggleToolButton();
        b.IconWidget = icon;
        b.Clicked += (obj, args) => toggle(obj, tool);
        return b;
    }

    void on_clear(object? o, EventArgs args)
    {
        area.clear();
    }

    protected override bool OnDeleteEvent(Event e)
    {
        Application.Quit();
        return true;
    }
}