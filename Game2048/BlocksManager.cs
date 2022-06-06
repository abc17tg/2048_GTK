using Gtk;
using System;
using System.Collections.Generic;

namespace Game2048;
public class BlocksManager
{
    public Dictionary<BlockType, byte[]> blocksPixelData;

    public BlocksManager()
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