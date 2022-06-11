using Gtk;
using Gdk;
using Cairo;
using System;

namespace Game2048;
public class BlocksView : DrawingArea
{
    public ImageSurface GameCanvas = new ImageSurface(Format.Argb32, (int)Math.Round(GameParameters.WindowSize.X), (int)Math.Round(GameParameters.WindowSize.Y));
    public Context GameContext => new Context(GameCanvas);

    public void Clear()
    {
        GameCanvas = new ImageSurface(Format.Argb32, (int)Math.Round(GameParameters.WindowSize.X), (int)Math.Round(GameParameters.WindowSize.Y));
        QueueDraw();
    }

    public void DrawBlock(int value, Cairo.Point position)
    {
        DrawSquare(GameContext, value, position);
        if (value != 1)
            DrawText(GameContext, value, position);
        QueueDraw();
    }

    public Cairo.Point IndexPositionToRealPosition(Cairo.Point indexPosition)
    {
        int offset = GameParameters.BlockOffset;
        int size = GameParameters.BlockSize;
        int x = offset * (indexPosition.X + 1) + indexPosition.X * size;
        int y = offset * (indexPosition.Y + 1) + indexPosition.Y * size;
        return new Cairo.Point(x, y);
    }
    public Cairo.Point RealPositionToIndexPosition(Cairo.Point realPosition)
    {
        int offset = GameParameters.BlockOffset;
        int size = GameParameters.BlockSize;
        int x = (int)Math.Round((double)(realPosition.X - offset) / (size + offset));
        int y = (int)Math.Round((double)(realPosition.Y - offset) / (size + offset));
        return new Cairo.Point(x, y);
    }

    private void DrawSquare(Context cx, int value, Cairo.Point position)
    {
        cx.LineWidth = 3;
        if (value == 1)
            cx.SetSourceRGB(0.85, 0.85, 0.85);
        else
            cx.SetSourceRGBA(1, 1f - 0.7f * Math.Clamp((Math.Log2(value) + 4) / 16f, 0f, 1f),
                0, Math.Clamp((Math.Log2(value) + 4) / 16f, 0f, 1f));

        Cairo.Point positionReal = IndexPositionToRealPosition(position);
        int a = positionReal.X;
        int b = GameParameters.BlockSize + a;
        int c = positionReal.Y;
        int d = GameParameters.BlockSize + c;
        int radius = GameParameters.BlockCornerRadius;
        double PiHalf = Math.PI / 2;

        cx.Arc(a + radius, c + radius, radius, 2 * PiHalf, 3 * PiHalf);
        cx.Arc(b - radius, c + radius, radius, 3 * PiHalf, 4 * PiHalf);
        cx.Arc(b - radius, d - radius, radius, 0 * PiHalf, 1 * PiHalf);
        cx.Arc(a + radius, d - radius, radius, 1 * PiHalf, 2 * PiHalf);
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
        layout.GetPixelSize(out int textWidth, out int textHeight);

        int blockSize = GameParameters.BlockSize;
        Cairo.Point positionReal = IndexPositionToRealPosition(position);
        cx.MoveTo((blockSize - textWidth) / 2 + positionReal.X, (blockSize - textHeight) / 2 + positionReal.Y);
        Pango.CairoHelper.ShowLayout(cx, layout);
    }

    protected override bool OnDrawn(Context cx)
    {
        cx.SetSourceSurface(GameCanvas, 0, 0);
        cx.Paint();
        return true;
    }
}
