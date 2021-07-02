using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class Sorting<T> where T : IComparable<T>
    {
        /// <summary>
        /// Uses Bubble Sort algorithm to sort a List<T> of IComparable<T> items.
        /// </summary>
        /// <param name="list">The list of IComparable<T> items to sort</param>
        /// <param name="ascending">Ascending or descending?</param>
        public static void BubbleSort(List<T> list, bool ascending = true)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if ((ascending))
                    {
                        if (list[j].CompareTo(list[j + 1]) > 0)
                            Swap(list, j, j + 1);
                    }
                    else
                    {
                        if (list[j].CompareTo(list[j + 1]) < 0)
                            Swap(list, j + 1, j);
                    }
                }
            }
        }

        public static void SelectionSort(List<T> list, bool ascending = true)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (ascending)
                    {
                        if (list[j].CompareTo(list[i]) < 0)
                            Swap(list, i, j);
                    }
                    else
                    {
                        if (list[j].CompareTo(list[i]) > 0)
                            Swap(list, i, j);
                    }
                }
            }
        }

        public static void InsertionSort(List<T> list, bool ascending = true)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (ascending)
                    {
                        if (list[j].CompareTo(list[j - 1]) < 0)
                            Swap(list, j, j - 1);
                    }
                    else
                    {
                        if (list[j].CompareTo(list[j - 1]) > 0)
                            Swap(list, j, j - 1);
                    }
                }
            }
        }


        private static void Swap(List<T> list, int j, int k)
        {
            var temp = list[j];
            list[j] = list[k];
            list[k] = temp;
        }
    }
}
