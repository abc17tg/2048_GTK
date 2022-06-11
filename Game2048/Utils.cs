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

    public static void ForEach2D<T>(this IEnumerable<IEnumerable<T>> lists, Action<T> action)
    {
        foreach (IEnumerable<T> list in lists)
            foreach (T item in list)
                action(item);
    }

    public static List<T> Column<T>(this IEnumerable<IEnumerable<T>> matrix, int columnNumber)
    {
        return Enumerable.Range(0, matrix.Count())
                .Select(x => matrix.ElementAt(x).ElementAt(columnNumber))
                .ToList();
    }

    public static List<T> Row<T>(this IEnumerable<IEnumerable<T>> matrix, int rowNumber)
    {
        return Enumerable.Range(0, matrix.First().Count())
                .Select(x => matrix.ElementAt(rowNumber).ElementAt(x))
                .ToList();
    }

    public static (int X, int Y) CoordinatesOf<T>(this IEnumerable<IEnumerable<T>> matrix, T value)
    {
        for (int x = 0; x < matrix.First().Count(); x++)
            for (int y = 0; y < matrix.Count(); ++y)
                if (matrix.ElementAt(x).ElementAt(y).Equals(value))
                    return (x, y);
        return (-1, -1);
    }

    public static (int X, int Y) IndexToCoordinatesOfMatrix(this int index, int rowLength)
    {
        int row = (int)Math.Floor((double)index / rowLength);
        int column = (int)Math.Round((double)((double)index / rowLength - row) * rowLength);

        return (row, column);
    }

}