using Gtk;
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
            if(!TrySpawn())
                 new GameOver().GameOverWindow();
    }

    private bool TrySpawn()
    {
        if(!Blocks.BlocksList.Any(p=>p.Value==1))
            return false;
        
        Random rnd = new Random();
        List<Block> emptyBlocks = Blocks.BlocksList.Where(p => p.Value == 1).ToList();
        int randomEmptyIndex = Blocks.BlocksList.IndexOf(emptyBlocks.ElementAt(rnd.Next(emptyBlocks.Count)));
        var coordinates = randomEmptyIndex.IndexToCoordinatesOfMatrix(GameParameters.RowColumnCount);
        Blocks.BlocksList[randomEmptyIndex].Value = rnd.Next(101) < 30 ? 4 : 2;
        View.DrawBlock(Blocks.BlocksList[randomEmptyIndex].Value, new Cairo.Point(coordinates.X, coordinates.Y));
        return true;
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
                if (TryMerge(new Cairo.Point(ii, jj), new Cairo.Point(i, j)))
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
                    if (!TryMergeEmpty(new Cairo.Point(ii, jj), new Cairo.Point(i, j)))
                        stillEmpty[index++] = false;
                }
            if (loop++ == 0 && stillEmpty.Contains(true))
                merged = true;

        } while (stillEmpty.Contains(true));

        return merged;
    }

    private bool TryMerge(Cairo.Point source, Cairo.Point target)
    {
        int indexTarget = target.CoordinatesOfMatrixToIndex(GameParameters.RowColumnCount);
        int indexSource = source.CoordinatesOfMatrixToIndex(GameParameters.RowColumnCount);
        if (BlocksList[indexSource].Value != BlocksList[indexTarget].Value)
            return false;

        Blocks.BlocksList.Swap(indexSource, indexTarget);
        BlocksList[indexTarget].Value = BlocksList[indexTarget].GetNextValue();
        BlocksList[indexSource].Value = 1;
        View.DrawBlock(BlocksList[indexTarget].Value, target);
        View.DrawBlock(BlocksList[indexSource].Value, source);
        return true;
    }

    private bool TryMergeEmpty(Cairo.Point source, Cairo.Point empty)
    {
        int indexSource= source.CoordinatesOfMatrixToIndex(GameParameters.RowColumnCount);
        int indexEmpty = empty.CoordinatesOfMatrixToIndex(GameParameters.RowColumnCount);

        if (BlocksList[indexEmpty].Value != 1 || BlocksList[indexSource].Value == 1)
            return false;

        Blocks.BlocksList.Swap(indexEmpty, indexSource);
        View.DrawBlock(BlocksList[indexSource].Value, source);
        View.DrawBlock(BlocksList[indexEmpty].Value, empty);
        return true;
    }


}
