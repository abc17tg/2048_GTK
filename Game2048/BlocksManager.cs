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
        switch (e.Event.Key)
        {
            case Gdk.Key.w or Gdk.Key.uparrow:
                Move(Direction.Up);
                break;
            case Gdk.Key.s or Gdk.Key.downarrow:
                Move(Direction.Down);
                break;
            case Gdk.Key.a or Gdk.Key.leftarrow:
                Move(Direction.Left);
                break;
            case Gdk.Key.d or Gdk.Key.rightarrow:
                Move(Direction.Right);
                break;
        }
    }

    public void Move(Direction direction)
    {
        bool merged = false;
        switch (direction)
        {
            case Direction.Up:
                TryMove(direction, out merged);
                break;
            case Direction.Down:
                TryMove(direction, out merged);
                break;
            case Direction.Left:
                TryMove(direction, out merged);
                break;
            case Direction.Right:
                TryMove(direction, out merged);
                break;
        }
        if (merged)
            Spawn();
        else if (!grid.Children.Any(p => Utils.CompareByteArrays(((Image)p).Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1))))
            GameOverWindow();

        grid.ShowAll();
    }

    private bool IsMergable(Image im1, Image im2) => Picture.Compare(im1, im2);

    private void Spawn()
    {
        Image child;
        int l, t;
        Random rnd = new Random();

        do
        {
            l = rnd.Next(4); t = rnd.Next(4);
            child = (Image)grid.GetChildAt(l, t);
        } while (!Utils.CompareByteArrays(child.Pixbuf.PixelBytes.Data, blocksPixelData.GetValueOrDefault(BlockType._1)));

        grid.Remove(child); child.Dispose(); child = null;
        grid.Attach(LoadBlock(rnd.Next(101) < 30 ? BlockType._4 : BlockType._2), l, t, 1, 1);
    }

    private void GameOverWindow()
    {
        Window go = new Window(WindowType.Popup);
        Program.App.AddWindow(go);
        Program.Win.GetPosition(out int x, out int y);
        go.Move(x + (int)Math.Round(Program.Win.AllocatedWidth * 0.25), y + (int)Math.Round(Program.Win.AllocatedHeight * 0.25));
        go.SetDefaultSize((int)Math.Round(Program.Win.AllocatedWidth * 0.5), (int)Math.Round(Program.Win.AllocatedHeight * 0.5));
        var label = new Label();
        label.Markup = "<span size='35000'>Game Over</span>";
        Button gameOverBtn = new Button(label);
        gameOverBtn.Clicked += (sender, e) =>
        {
            Program.App.RemoveWindow(go);
            go.Close();
            go.Destroy(); go.Dispose();
            Program.Restart();
        };
        go.Add(gameOverBtn);
        go.ShowAll();
    }

    private (int X1, int Y1, int X2, int Y2) MergeLoopParameters(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                return (0, 3, 0, 4);

            case Direction.Down:
                return (3, 0, 0, 4);

            case Direction.Left:
                return (0, 4, 0, 3);

            case Direction.Right:
                return (0, 4, 3, 0);

            default:
                return (0, 0, 0, 0);
        }
    }

    private void TryMove(Direction direction, out bool result)
    {
        result = false;
        if (MergeEmpty(direction))
            result = true;
        if (Merge(direction))
            result = true;
        MergeEmpty(direction);
    }

    private bool Merge(Direction direction)
    {
        List<bool> merged = new List<bool>();
        var par = MergeLoopParameters(direction);
        for (int j = par.X1; par.X1 < par.Y1 ? j < par.Y1 : j > par.Y1; j = par.X1 < par.Y1 ? j + 1 : j - 1)
            for (int i = par.X2; par.X2 < par.Y2 ? i < par.Y2 : i > par.Y2; i = par.X2 < par.Y2 ? i + 1 : i - 1)
            {
                var ii = direction == Direction.Left ? i + 1 : direction == Direction.Right ? i - 1 : i;
                var jj = direction == Direction.Up ? j + 1 : direction == Direction.Down ? j - 1 : j;
                if (TryMerge(ii, jj, i, j))
                    merged.Add(true);
                else
                    merged.Add(false);
            }
        return merged.First();
    }

    private bool MergeEmpty(Direction direction)
    {
        bool merged = false;
        int loop = 0;
        var par = MergeLoopParameters(direction);
        List<bool> stillEmpty;
        do
        {
            stillEmpty = Enumerable.Repeat(true, 12).ToList();
            int index = 0;
            for (int j = par.X1; par.X1 < par.Y1 ? j < par.Y1 : j > par.Y1; j = par.X1 < par.Y1 ? j + 1 : j - 1)
                for (int i = par.X2; par.X2 < par.Y2 ? i < par.Y2 : i > par.Y2; i = par.X2 < par.Y2 ? i + 1 : i - 1)
                {
                    var ii = direction == Direction.Left ? i + 1 : direction == Direction.Right ? i - 1 : i;
                    var jj = direction == Direction.Up ? j + 1 : direction == Direction.Down ? j - 1 : j;
                    if (!TryMergeEmpty(ii, jj, i, j))
                        stillEmpty[index++] = false;
                }
            if (loop++ == 0 && stillEmpty.Contains(true))
                merged = true;

        } while (stillEmpty.Contains(true));

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

    private bool TryMergeEmpty(int sourceLeftPosition, int sourceTopPosition, int emptyLeftPosition, int emptyTopPosition)
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
}
