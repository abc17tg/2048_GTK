using Gtk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;
public class BlocksController
{
    public BlocksView View;
    public BlocksManager Blocks;
    public GameOver GameOverObject;

    public BlocksController()
    {
        GameOverObject = new GameOver();
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
        TryMove(direction, out bool merged);
        if (merged)
            if (!TrySpawn())
                if (GameOverObject.IsGameOver(Blocks.BlocksList))
                    GameOverObject.GameOverWindow();
    }

    private bool TrySpawn()
    {
        if (!Blocks.BlocksList.Any(p => p.Value == 1))
            return false;

        Random rnd = new Random();
        List<Block> emptyBlocks = Blocks.BlocksList.Where(p => p.Value == 1).ToList();
        int randomEmptyIndex = Blocks.BlocksList.IndexOf(emptyBlocks.ElementAt(rnd.Next(emptyBlocks.Count)));
        var coordinates = randomEmptyIndex.IndexToCoordinatesOfMatrix(GameParameters.RowColumnCount);
        Blocks.BlocksList[randomEmptyIndex].Value = rnd.Next(101) < 30 ? 4 : 2;
        return true;
    }

    private void TryMove(Direction direction, out bool result)
    {
        result = false;
        if (direction == Direction.Up || direction == Direction.Down)
        {
            if (MergeEmptyUpDown(direction))
                result = true;
            if (MergeUpDown(direction))
                result = true;
            MergeEmptyUpDown(direction);
        }
        else
        {
            if (MergeEmptyLeftRight(direction))
                result = true;
            if (MergeLeftRight(direction))
                result = true;
            MergeEmptyLeftRight(direction);
        }
    }

    private bool MergeUpDown(Direction direction)
    {
        List<bool> merged = new List<bool>();
        for (int i = direction == Direction.Up ? 0 : GameParameters.RowColumnCount - 1;
            direction == Direction.Up ? i < GameParameters.RowColumnCount - 1 : i > 0;
            i = direction == Direction.Up ? i + 1 : i - 1)
        {
            var targetRow = Blocks.BlocksList.Row(i, GameParameters.RowColumnCount);
            var sourceRow = Blocks.BlocksList.Row(direction == Direction.Up ? i + 1 : i - 1, GameParameters.RowColumnCount);
            for (int j = 0; j < GameParameters.RowColumnCount; j++)
                if (!TryMerge(new Cairo.Point(direction == Direction.Up ? i + 1 : i - 1, j), new Cairo.Point(i, j)))
                    merged.Add(true);
                else
                    merged.Add(false);
        }
        return merged.First();
    }

    private bool MergeLeftRight(Direction direction)
    {
        List<bool> merged = new List<bool>();
        for (int i = 0; i < GameParameters.RowColumnCount; i++)
        {
            var targetRow = Blocks.BlocksList.Column(i, GameParameters.RowColumnCount);
            var sourceRow = Blocks.BlocksList.Column(direction == Direction.Up ? i + 1 : i - 1, GameParameters.RowColumnCount);
            for (int j = direction == Direction.Left ? 0 : GameParameters.RowColumnCount - 1;
                direction == Direction.Left ? j < GameParameters.RowColumnCount - 1 : j > 0;
                j = direction == Direction.Left ? j + 1 : j - 1)
            {
                if (!TryMerge(new Cairo.Point(i, direction == Direction.Left ? j + 1 : j - 1), new Cairo.Point(i, j)))
                    merged.Add(true);
                else
                    merged.Add(false);
            }
        }
        return merged.First();
    }

    private bool MergeEmptyUpDown(Direction direction)
    {
        bool merged = false;
        int loop = 0;
        List<bool> stillEmpty;
        do
        {
            stillEmpty = Enumerable.Repeat(true, GameParameters.BlockCount - GameParameters.RowColumnCount).ToList();
            int index = 0;
            for (int i = direction == Direction.Up ? 0 : GameParameters.RowColumnCount - 1;
            direction == Direction.Up ? i < GameParameters.RowColumnCount - 1 : i > 0;
            i = direction == Direction.Up ? i + 1 : i - 1)
            {
                var targetRow = Blocks.BlocksList.Row(i, GameParameters.RowColumnCount);
                var sourceRow = Blocks.BlocksList.Row(direction == Direction.Up ? i + 1 : i - 1, GameParameters.RowColumnCount);
                for (int j = 0; j < GameParameters.RowColumnCount; j++)
                    if (!TryMergeEmpty(new Cairo.Point(direction == Direction.Up ? i + 1 : i - 1, j), new Cairo.Point(i, j)))
                        stillEmpty[index++] = false;
            }

            if (loop++ == 0 && stillEmpty.Contains(true))
                merged = true;

        } while (stillEmpty.Contains(true));

        return merged;
    }

    private bool MergeEmptyLeftRight(Direction direction)
    {
        bool merged = false;
        int loop = 0;
        List<bool> stillEmpty;
        do
        {
            stillEmpty = Enumerable.Repeat(true, GameParameters.BlockCount - GameParameters.RowColumnCount).ToList();
            int index = 0;
            for (int i = 0; i < GameParameters.RowColumnCount; i++)
            {
                var targetRow = Blocks.BlocksList.Column(i, GameParameters.RowColumnCount);
                var sourceRow = Blocks.BlocksList.Column(direction == Direction.Up ? i + 1 : i - 1, GameParameters.RowColumnCount);
                for (int j = direction == Direction.Left ? 0 : GameParameters.RowColumnCount - 1;
                    direction == Direction.Left ? j < GameParameters.RowColumnCount - 1 : j > 0;
                    j = direction == Direction.Left ? j + 1 : j - 1)
                {
                    if (!TryMergeEmpty(new Cairo.Point(i, direction == Direction.Left ? j + 1 : j - 1), new Cairo.Point(i, j)))
                        stillEmpty[index++] = false;
                }
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
        if (Blocks.BlocksList[indexSource].Value == 1 || Blocks.BlocksList[indexTarget].Value == 1)
            return false;

        if (Blocks.BlocksList[indexSource].Value != Blocks.BlocksList[indexTarget].Value)
            return false;

        Blocks.BlocksList = Blocks.BlocksList.Swap(indexSource, indexTarget);
        Blocks.BlocksList[indexTarget].Value = Blocks.BlocksList[indexTarget].GetNextValue();
        Blocks.BlocksList[indexSource].Value = 1;
        return true;
    }

    private bool TryMergeEmpty(Cairo.Point source, Cairo.Point empty)
    {
        int indexSource = source.CoordinatesOfMatrixToIndex(GameParameters.RowColumnCount);
        int indexEmpty = empty.CoordinatesOfMatrixToIndex(GameParameters.RowColumnCount);

        if (Blocks.BlocksList[indexEmpty].Value != 1 || Blocks.BlocksList[indexSource].Value == 1)
            return false;

        Blocks.BlocksList = Blocks.BlocksList.Swap(indexEmpty, indexSource);
        return true;
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
