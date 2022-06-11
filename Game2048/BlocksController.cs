/*using Gtk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;
public class BlocksController : BlocksManager
{
    public BlocksView View;
    public BlocksManager Blocks;

    public BlocksController()
    {
        View = new BlocksView();
        Blocks = new BlocksManager();
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
        else if (!View.GameGrid.Children.Any(p => Utils.CompareByteArrays(((Image)p).Pixbuf.PixelBytes.Data, Blocks.blocksPixelData.GetValueOrDefault(BlockType._1))))
            new GameOver().GameOverWindow();

        View.UpdateView();
    }

    private void Spawn()
    {
        Image child;
        int l, t;
        Random rnd = new Random();

        do
        {
            l = rnd.Next(4); t = rnd.Next(4);
            child = (Image)View.GameGrid.GetChildAt(l, t);
        } while (!Utils.CompareByteArrays(child.Pixbuf.PixelBytes.Data, Blocks.blocksPixelData.GetValueOrDefault(BlockType._1)));

        View.GameGrid.Remove(child); child.Dispose(); child = null;
        View.GameGrid.Attach(LoadBlock(rnd.Next(101) < 30 ? BlockType._4 : BlockType._2), l, t, 1, 1);
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
        var child1 = (Image)View.GameGrid.GetChildAt(sourceLeftPosition, sourceTopPosition);
        var child2 = (Image)View.GameGrid.GetChildAt(targetLeftPosition, targetTopPosition);
        if (Utils.CompareByteArrays(child1.Pixbuf.PixelBytes.Data, Blocks.blocksPixelData.GetValueOrDefault(BlockType._1)) ||
            Utils.CompareByteArrays(child2.Pixbuf.PixelBytes.Data, Blocks.blocksPixelData.GetValueOrDefault(BlockType._1)) ||
            !IsMergable(child1, child2))
            return false;

        BlockType blockType = GetBlockType(child1.Pixbuf);
        View.GameGrid.Remove(child1); child1.Dispose(); child1 = null;
        View.GameGrid.Remove(child2); child2.Dispose(); child2 = null;
        View.GameGrid.Attach(LoadBlock(BlockType._1), sourceLeftPosition, sourceTopPosition, 1, 1);
        View.GameGrid.Attach(LoadBlock(GetNextBlockType(blockType)), targetLeftPosition, targetTopPosition, 1, 1);
        return true;
    }

    private bool TryMergeEmpty(int sourceLeftPosition, int sourceTopPosition, int emptyLeftPosition, int emptyTopPosition)
    {
        var child2 = (Image)View.GameGrid.GetChildAt(emptyLeftPosition, emptyTopPosition);
        if (!Utils.CompareByteArrays(child2.Pixbuf.PixelBytes.Data, Blocks.blocksPixelData.GetValueOrDefault(BlockType._1)))
            return false;

        var child1 = (Image)View.GameGrid.GetChildAt(sourceLeftPosition, sourceTopPosition);
        if (Utils.CompareByteArrays(child1.Pixbuf.PixelBytes.Data, Blocks.blocksPixelData.GetValueOrDefault(BlockType._1)))
            return false;

        BlockType blockType = GetBlockType(child1.Pixbuf);
        View.GameGrid.Remove(child1); child1.Dispose(); child1 = null;
        View.GameGrid.Remove(child2); child2.Dispose(); child2 = null;
        View.GameGrid.Attach(LoadBlock(BlockType._1), sourceLeftPosition, sourceTopPosition, 1, 1);
        View.GameGrid.Attach(LoadBlock(blockType), emptyLeftPosition, emptyTopPosition, 1, 1);
        return true;
    }


}
*/