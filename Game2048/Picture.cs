namespace Game2048;

public class Picture
{
    private Gtk.Image image;

    public Picture(string resource) => image = Gtk.Image.LoadFromResource(resource);
    public Picture(Gtk.Image im) => image = im;

    public Picture(string resource, int width, int height)
    {
        image = Gtk.Image.LoadFromResource(resource);
        image = new Gtk.Image(image.Pixbuf.ScaleSimple(width, height, Gdk.InterpType.Nearest));
    }

    public Picture(Gtk.Image im, int width, int height) => 
        image = new Gtk.Image(im.Pixbuf.ScaleSimple(width, height, Gdk.InterpType.Nearest));

    public Gtk.Image GetImage() => image;

    public Gtk.Image GetImage(int width, int height) =>
        new Gtk.Image(image.Pixbuf.ScaleSimple(width, height, Gdk.InterpType.Nearest));

    public void SetImage(Gtk.Image im) => image = im;
    public void SetImage(Gdk.Pixbuf im) => image = new Gtk.Image(im);

    public void SetImage(Gtk.Image im, int width, int height) => 
        image = new Gtk.Image(im.Pixbuf.ScaleSimple(width, height, Gdk.InterpType.Nearest));
    public void SetImage(Gdk.Pixbuf im, int width, int height) => 
        image = image = new Gtk.Image(im.ScaleSimple(width, height, Gdk.InterpType.Nearest));

    public static bool Compare(Gtk.Image im1, Gtk.Image im2)
    {
        if (Utils.CompareByteArrays(im1.Pixbuf.PixelBytes.Data, im2.Pixbuf.PixelBytes.Data))
            return true;
        return false;
    }
}

