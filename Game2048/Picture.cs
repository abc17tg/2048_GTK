namespace Game2048;

public class Picture
{
    private Gtk.Image image;

    public Picture(string resource) => image = Gtk.Image.LoadFromResource(resource);

    public Gtk.Image GetImage() => image;

    public Gtk.Image GetImage(int width, int height) =>
        new Gtk.Image(image.Pixbuf.ScaleSimple(width, height, Gdk.InterpType.Nearest));

    public static bool Compare(Gtk.Image im1, Gtk.Image im2)
    {
        if (Utils.CompareByteArrays(im1.Pixbuf.PixelBytes.Data, im2.Pixbuf.PixelBytes.Data))
            return true;
        return false;
    }
}

