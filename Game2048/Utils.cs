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

    public static List<T> Column<T>(this IEnumerable<T> list, int columnIndex, int rowLength)
    {
        List<T> result = new List<T>();
        for (int i = 0; i < list.Count(); i += rowLength)
            result.Add(list.ElementAt(i));
        return result;
    }

    public static List<T> Row<T>(this IEnumerable<T> list, int rowIndex, int rowLength)
    {
        List<T> result = new List<T>();
        for (int i = rowIndex * rowLength; i < (rowIndex + 1) * rowLength; i++)
            result.Add(list.ElementAt(i));
        return result;
    }

    public static (int X, int Y) IndexToCoordinatesOfMatrix(this int index, int rowLength)
    {
        int row = (int)Math.Floor((double)index / rowLength);
        int column = (int)Math.Round((double)((double)index / rowLength - row) * rowLength);
        return (column,row);
    }

    public static int CoordinatesOfMatrixToIndex(this Cairo.Point coordinates, int rowLength) => coordinates.X * rowLength + coordinates.Y;

    public static List<T> Swap<T>(this List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
        return list;
    }

    public static bool HasDuplicates<T>(this IEnumerable<T> list, int allowedDistance)
    {
        HashSet<T> set = new HashSet<T>();
        for (int i = 0; i < list.Count(); i++)
        {
            if (set.Contains(list.ElementAt(i)))
                return true;
            set.Add(list.ElementAt(i));
            if (i >= allowedDistance)
                set.Remove(list.ElementAt(i - allowedDistance));
        }
        return false;
    }

}