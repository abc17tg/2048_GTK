using System;
using System.Collections.Generic;
using System.Linq;

namespace Game2048;
public static class Utils
{
    public static T RandomEnumValue<T>()
    {
        Random rnd = new Random();
        var v = Enum.GetValues(typeof(T));
        return (T)v.GetValue(rnd.Next(v.Length));
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

    public static (int X, int Y) IndexToCoordinatesOfMatrix(this int index, int rowLength)
    {
        int row = (int)Math.Floor((double)index / rowLength);
        int column = (int)Math.Round((double)((double)index / rowLength - row) * rowLength);
        return (row, column);
    }

    public static int CoordinatesOfMatrixToIndex(this Cairo.Point coordinates, int rowLength) => coordinates.X * rowLength + coordinates.Y;

    public static void Swap<T>(this List<T> list, int index1, int index2)
    {        
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }

}