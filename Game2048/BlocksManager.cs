using Gtk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;
public class BlocksManager
{
    private Dictionary<BlockType, byte[]> blocksPixelData;

    public Grid grid;

    public BlocksManager()
    {
        blocksPixelData = new Dictionary<BlockType, byte[]>();
        foreach (var b in (BlockType[])Enum.GetValues(typeof(BlockType)))
            blocksPixelData.Add(b, LoadBlock(b).Pixbuf.PixelBytes.Data);
        ConstructGrid();
    }

    public void Move(object s, KeyPressEventArgs e)
    {

        bool merged = false;
        switch (e.Event.Key)
        {
            case Gdk.Key.w:
                merged = TryMergeUp();
                break;
            case Gdk.Key.s:
                merged = TryMergeDown();
                break;
            case Gdk.Key.a:
                merged = TryMergeLeft();
                break;
            case Gdk.Key.d:
                merged = TryMergeRight();
                break;
        }
        Spawn();
        grid.ShowAll();
    }

    private bool IsMergable(Image im1, Image im2) => Picture.Compare(im1, im2);

    private void Spawn()
    {
        Image child;
        int l, t;
        Random rnd = new Random();
        if (!grid.Children.Any(p => Utils.CompareByteArrays(((Image)p).Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1))))
        {
            Window go = new Window(WindowType.Popup);
            Program.App.AddWindow(go);
            go.WindowPosition = WindowPosition.Center;
            go.SetDefaultSize(100, 100);
            go.Add(new Button("Game Over"));
            go.ShowAll();
            return;
        }

        do
        {
            l = rnd.Next(4);
            t = rnd.Next(4);
            child = (Image)grid.GetChildAt(l, t);
        } while (!Utils.CompareByteArrays(child.Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1)));

        grid.Remove(child); child.Dispose(); child = null;

        grid.Attach(LoadBlock(rnd.Next(101) < 30 ? BlockType._4 : BlockType._2), l, t, 1, 1);
    }

    private bool TryMergeUp()
    {
        bool merged = false;
        List<bool> stillEmpty;
        do
        {
            stillEmpty = new List<bool>();
            for (int i = 0; i < 12; i++)
                stillEmpty.Add(true);
            int index = 0;
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 4; i++)
                    if (!TryMergeWithEmpty(i, j + 1, i, j))
                        stillEmpty[index++] = false;
        } while (stillEmpty.Contains(true));

        for (int j = 0; j < 3; j++)
            for (int i = 0; i < 4; i++)
                if (TryMerge(i, j + 1, i, j))
                    merged = true;
        return merged;
    }

    private bool TryMergeDown()
    {
        bool merged = false;
        List<bool> stillEmpty;
        do
        {
            stillEmpty = new List<bool>();
            for (int i = 0; i < 12; i++)
                stillEmpty.Add(true);
            int index = 0;
            for (int j = 3; j > 0; j--)
                for (int i = 0; i < 4; i++)
                    if (!TryMergeWithEmpty(i, j - 1, i, j))
                        stillEmpty[index++] = false;
        } while (stillEmpty.Contains(true));

        for (int j = 3; j > 0; j--)
            for (int i = 0; i < 4; i++)
                if (TryMerge(i, j - 1, i, j))
                    merged = true;
        return merged;
    }

    private bool TryMergeLeft()
    {
        bool merged = false;
        List<bool> stillEmpty;
        do
        {
            stillEmpty = new List<bool>();
            for (int i = 0; i < 12; i++)
                stillEmpty.Add(true);
            int index = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    if (!TryMergeWithEmpty(i + 1, j, i, j))
                        stillEmpty[index++] = false;
        } while (stillEmpty.Contains(true));

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                if (TryMerge(i + 1, j, i, j))
                    merged = true;
        return merged;
    }

    private bool TryMergeRight()
    {
        bool merged = false;
        List<bool> stillEmpty;
        do
        {
            stillEmpty = new List<bool>();
            for (int i = 0; i < 12; i++)
                stillEmpty.Add(true);
            int index = 0;
            for (int i = 3; i > 0; i--)
                for (int j = 0; j < 4; j++)
                    if (!TryMergeWithEmpty(i - 1, j, i, j))
                        stillEmpty[index++] = false;
        } while (stillEmpty.Contains(true));

        for (int i = 3; i > 0; i--)
            for (int j = 0; j < 4; j++)
                if (TryMerge(i - 1, j, i, j))
                    merged = true;
        return merged;
    }

    private bool TryMerge(int sourceLeftPosition, int sourceTopPosition, int targetLeftPosition, int targetTopPosition)
    {
        var child1 = (Image)grid.GetChildAt(sourceLeftPosition, sourceTopPosition);
        var child2 = (Image)grid.GetChildAt(targetLeftPosition, targetTopPosition);
        if (Utils.CompareByteArrays(child1.Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1)) ||
            Utils.CompareByteArrays(child2.Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1)) ||
            !IsMergable(child1, child2))
            return false;

        BlockType blockType = GetBlockType(child1.Pixbuf);
        grid.Remove(child1); child1.Dispose(); child1 = null;
        grid.Remove(child2); child2.Dispose(); child2 = null;
        grid.Attach(LoadBlock(BlockType._1), sourceLeftPosition, sourceTopPosition, 1, 1);
        grid.Attach(LoadBlock(GetNextBlockType(blockType)), targetLeftPosition, targetTopPosition, 1, 1);
        return true;
    }

    private bool TryMergeWithEmpty(int sourceLeftPosition, int sourceTopPosition, int emptyLeftPosition, int emptyTopPosition)
    {
        var child2 = (Image)grid.GetChildAt(emptyLeftPosition, emptyTopPosition);
        if (!Utils.CompareByteArrays(child2.Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1)))
            return false;

        var child1 = (Image)grid.GetChildAt(sourceLeftPosition, sourceTopPosition);
        if (Utils.CompareByteArrays(child1.Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1)))
            return false;

        BlockType blockType = GetBlockType(child1.Pixbuf);
        grid.Remove(child1); child1.Dispose(); child1 = null;
        grid.Remove(child2); child2.Dispose(); child2 = null;
        grid.Attach(LoadBlock(BlockType._1), sourceLeftPosition, sourceTopPosition, 1, 1);
        grid.Attach(LoadBlock(blockType), emptyLeftPosition, emptyTopPosition, 1, 1);
        return true;
    }

    private BlockType GetBlockType(Gdk.Pixbuf pixbuf)
    {
        foreach (var img in blocksPixelData)
            if (Utils.CompareByteArrays(pixbuf.PixelBytes.Data, img.Value))
                return img.Key;
        return BlockType._1;
    }

    private BlockType GetNextBlockType(BlockType blockType)
    {
        int nextBlock = 2 * (int)blockType;
        if (nextBlock > 2048)
            nextBlock = 2048;
        return (BlockType)nextBlock;
    }

    private Image LoadBlock(BlockType blockType) =>
        new Image(Gdk.Pixbuf.LoadFromResource(((int)blockType).ToString()).ScaleSimple(GameParameters.BlockSize, GameParameters.BlockSize, Gdk.InterpType.Nearest));


    private void ConstructGrid()
    {
        grid = new Grid();
        grid.Margin = 8;
        grid.Halign = Align.Center;
        grid.Valign = Align.Center;
        grid.ColumnSpacing = 10;
        grid.RowSpacing = 10;

        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                grid.Attach(LoadBlock(BlockType._1), i, j, 1, 1);

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
        var toDestroy1 = grid.GetChildAt(pl1, pt1);
        var toDestroy2 = grid.GetChildAt(pl2, pt2);
        grid.Remove(toDestroy1); toDestroy1.Dispose(); toDestroy1 = null;
        grid.Remove(toDestroy2); toDestroy2.Dispose(); toDestroy2 = null;
        grid.Attach(LoadBlock(BlockType._2), pl1, pt1, 1, 1);
        grid.Attach(LoadBlock(BlockType._2), pl2, pt2, 1, 1);
    }

    public enum BlockType
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public void Move(Direction direction)
    {
        bool merged = false;
        switch (direction)
        {
            case Direction.Up:
                merged = TryMergeUp();
                break;

            case Direction.Down:
                merged = TryMergeDown();
                break;

            case Direction.Left:
                merged = TryMergeLeft();
                break;

            case Direction.Right:
                merged = TryMergeRight();
                break;
        }
        Spawn();
        grid.ShowAll();

    }
}
