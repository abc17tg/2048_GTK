using Gtk;
using System;

namespace Game2048;
public class BlocksView : BlocksManager
{
    public Grid GameGrid;
    public Fixed Canvas;

    public BlocksView()
    {
        //ConstructGrid();

        Canvas.SetSizeRequest(800, 800);
    }

    public void UpdateView()
    {
        //GameGrid.ShowAll();
    }

    /*private void ConstructGrid()
    {
        GameGrid = new Grid();
        GameGrid.Margin = 8;
        GameGrid.Halign = Align.Center;
        GameGrid.Valign = Align.Center;
        GameGrid.ColumnSpacing = 10;
        GameGrid.RowSpacing = 10;

        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                GameGrid.Attach(LoadBlock(BlockType._1), i, j, 1, 1);

        Random rnd = new Random();
        int pl1 = rnd.Next(4);
        int pt1 = rnd.Next(4);
        int pl2 = rnd.Next(4);
        int pt2 = rnd.Next(4);
        while (pl1 == pl2 && pt1 == pt2)
        {
            pl2 = rnd.Next(4);
            pt2 = rnd.Next(4);
        }
        var toDestroy1 = GameGrid.GetChildAt(pl1, pt1);
        var toDestroy2 = GameGrid.GetChildAt(pl2, pt2);
        GameGrid.Remove(toDestroy1); toDestroy1.Dispose(); toDestroy1 = null;
        GameGrid.Remove(toDestroy2); toDestroy2.Dispose(); toDestroy2 = null;
        GameGrid.Attach(LoadBlock(BlockType._2), pl1, pt1, 1, 1);
        GameGrid.Attach(LoadBlock(BlockType._2), pl2, pt2, 1, 1);
    }*/
}
