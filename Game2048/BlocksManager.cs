using Gtk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;

public class BlocksManager
{
    public List<Block> BlocksList;

    public BlocksManager()
    {
        BlocksList = new List<Block>();
        for (int i = 0; i < GameParameters.BlockCount; i++)
            BlocksList.Add(new Block(i));

        BlocksList.ForEach(p=>p.Value = 1);
        Random rnd= new Random();
        List<int> startIndexes = Enumerable.Range(0, GameParameters.BlockCount).OrderBy(x => rnd.Next()).Take(2).ToList();
        foreach (int index in startIndexes)
            BlocksList[index].Value = 2;
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}