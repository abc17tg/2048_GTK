using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;
public static class Utils
{
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
}