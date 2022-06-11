using Gtk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;

public class BlocksManager
{
    public List<List<Block>> BlocksMatrix;
    public List<Block> BlocksList => BlocksMatrix.SelectMany(p => p).ToList();

    public BlocksManager()
    {
        BlocksMatrix = new List<List<Block>>();
        for (int i = 0; i < GameParameters.RowColumnCount; i++)
        {
            BlocksMatrix.Add(new List<Block>());
            for (int j = 0; j < GameParameters.RowColumnCount; j++)
                BlocksMatrix.Last().Add(new Block());
        }
        //alternative
        /*for (int i = 0; i < GameParameters.BlockCount; i++)
            BlocksList.Add(new Block());*/

        BlocksList.ForEach(p=>p.Value = 1);
        Random rnd= new Random();
        List<int> startIndexes = Enumerable.Range(0, GameParameters.BlockCount).OrderBy(x => rnd.Next()).Take(2).ToList();
        foreach (int index in startIndexes)
            BlocksList[index].Value = 2;

        /*for (int i = 0; i < GameParameters.BlockCount; i++)
        {
            var coordinates = i.IndexToCoordinatesOfMatrix(GameParameters.RowColumnCount);
            BlocksList[i].DrawBlock(BlocksList[i].Value, new Cairo.Point(coordinates.X,coordinates.Y));
        }*/

    }
}
public class BlocksManagerOld
{
    public Dictionary<BlockType, byte[]> blocksPixelData;

    public BlocksManagerOld()
    {
        blocksPixelData = new Dictionary<BlockType, byte[]>();
        foreach (var b in (BlockType[])Enum.GetValues(typeof(BlockType)))
            blocksPixelData.Add(b, LoadBlock(b).Pixbuf.PixelBytes.Data);
    }

    protected bool IsMergable(Image im1, Image im2) => Picture.Compare(im1, im2);

    protected BlockType GetBlockType(Gdk.Pixbuf pixbuf)
    {
        foreach (var img in blocksPixelData)
            if (Utils.CompareByteArrays(pixbuf.PixelBytes.Data, img.Value))
                return img.Key;
        return BlockType._1;
    }

    protected BlockType GetNextBlockType(BlockType blockType)
    {
        int nextBlock = 2 * (int)blockType;
        if (nextBlock > 2048)
            nextBlock = 2048;
        return (BlockType)nextBlock;
    }

    protected Image LoadBlock(BlockType blockType) =>
        new Image(Gdk.Pixbuf.LoadFromResource(((int)blockType).ToString()).ScaleSimple(GameParameters.BlockSize, GameParameters.BlockSize, Gdk.InterpType.Nearest));

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