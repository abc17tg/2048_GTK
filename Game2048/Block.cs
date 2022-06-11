using System;

namespace Game2048;
public class Block
{
    public int Value;
    private long id;

    public Block()
    {
        Random rnd = new Random();
        id = rnd.NextInt64();
    }

    public int GetNextValue() => 2 * Value;
}
