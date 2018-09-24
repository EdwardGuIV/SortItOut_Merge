using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortItOut_Merge_Insert
{
    class Program
    {
        public static void Main(string[] args)
        {


            TestMergeSort();
            Console.ReadKey();

            
        }

        public static void TestMergeSort()
        {
            string path = @"/Users/EDGUIV/Documents/eg-jf-jd.csv";

            string[] csvData = File.ReadAllLines(path);
            //csvData
            MergeSorter.SortMerge(csvData, 0, 1000000);

            foreach (var line in csvData)
            {

                Console.WriteLine(line);
            }
        }
    }

    public static class MergeSorter
    {
        static public void MainMerge<T>(T[] values, int left, int mid, int right) where T : IComparable<T>
        {
            T[] temp = new T[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (values[left].CompareTo(values[mid]) < 0)
                {
                    temp[pos++] = values[left++];
                }
                else
                {
                    temp[pos++] = values[mid++];
                }
            }

            while (left <= eol)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < num; i++)
            {
                values[right] = temp[right];
                right--;
            }
        }

        static public void SortMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);

                MainMerge(values, left, (mid + 1), right);
            }
        }
    }

    public class SortIdByMergeSort
    {

    }

    public class SortGuidByMergeSort
    {

    }

    public class SortDoubleByMergeSort
    {

    }

    //public static class MergeSorter
    //{
    //    public static void DoMergeSort(this string[] lines)
    //    {
    //        var sortedLines = MergeSort(lines);
    //        for (int i = 0; i < sortedLines.Length; i++)
    //        {
    //            lines[i] = sortedLines[i];
    //        }
    //    }

    //    private static string[] MergeSort(string[] lines)
    //    {
    //        //base class for merge algorith
    //        if (lines.Length <= 1)
    //        {
    //            return lines;
    //        }

    //        var left = new List<string>();
    //        var right = new List<string>();

    //        for (int i = 0; i < lines.Length; i++)
    //        {
    //            if (i % 2 > 0) //if it is odd
    //            {
    //                left.Add(lines[i]);
    //            }
    //            else
    //            {
    //                right.Add(lines[i]);
    //            }
    //        }

    //        left = MergeSort(left.ToArray()).ToList();
    //        right = MergeSort(right.ToArray()).ToList();

    //        return Merge(left, right);
    //    }

    //    private static string[] Merge(List<string> left, List<string> right)
    //    {
    //        var result = new List<string>(;

    //        while (left.Count > 0 && right.Count > 0)
    //        {
    //            if (left.First() <= right.First())
    //            {

    //            }
    //        }
    //    }
    //}
}
