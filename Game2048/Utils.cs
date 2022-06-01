using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;
public static class Utils
{
    public static IEnumerable<T> TakeRandom<T>(this IEnumerable<T> collection, int take)
    {
        var random = new Random();
        var available = collection.Count();
        var needed = take;
        foreach (var item in collection)
        {
            if (random.Next(available) < needed)
            {
                needed--;
                yield return item;
                if (needed == 0)
                {
                    break;
                }
            }
            available--;
        }
    }

    public static bool CompareByteArrays(byte[] a1, byte[] a2)
    {
        if (a1.Length != a2.Length) return false;

        for (int i = 0; i < a1.Length; i++)
        {
            if (a1[i] != a2[i])
                return false;
        }

        return true;
    }

    public static T RandomEnumValue<T>()
    {
        Random rnd = new Random();
        var v = Enum.GetValues(typeof(T));
        return (T)v.GetValue(rnd.Next(v.Length));
    }

    public static IEnumerable<T[]> Combinations<T>(this IEnumerable<T> source)
    {
        T[] data = source.ToArray();
        return Enumerable.Range(0, 1 << (data.Length)).Select(index => data.Where((v, i) => (index & (1 << i)) != 0).ToArray());
    }
}