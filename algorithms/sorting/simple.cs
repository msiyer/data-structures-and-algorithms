using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class Sorting
    {
        public static void BubbleSort(List<int> list, bool ascending = true)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if ((ascending))
                    {
                        if (list[j] > list[j + 1])
                            Swap(list, j, j + 1);
                    }
                    else
                    {
                        if (list[j] < list[j + 1])
                            Swap(list, j, j + 1);
                    }
                }
            }
        }

        public static void SelectionSort(List<int> list, bool ascending = true)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (ascending)
                    {
                        if (list[j] < list[i])
                            Swap(list, i, j);
                    }
                    else
                    {
                        if (list[j] > list[i])
                            Swap(list, i, j);
                    }
                }
            }
        }

        public static void InsertionSort(List<int> list, bool ascending = true)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (ascending)
                    {
                        if (list[j] < list[j - 1])
                            Swap(list, j, j - 1);
                    }
                    else
                    {
                        if (list[j] > list[j - 1])
                            Swap(list, j, j - 1);
                    }
                }
            }
        }


        private static void Swap(List<int> list, int j, int k)
        {
            int temp = list[j];
            list[j] = list[k];
            list[k] = temp;
        }
    }
}
