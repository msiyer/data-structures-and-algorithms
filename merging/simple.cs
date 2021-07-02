using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class Merging
    {
       /// <summary>
       /// Merges two sorted lists of equal or unequal sizes into one output list. 
       /// Although this algo will merge unsorted lists, the results will be funny.
       /// </summary>
       /// <param name="firstList"></param>
       /// <param name="secondList"></param>
       /// <returns></returns>
        public static List<int> TwoWayMergeIterative(List<int> firstList, List<int> secondList)
        {
            List<int> output = new List<int>();
            int i = 0; int j = 0;
            while (i < firstList.Count && j < secondList.Count)
            {
                if (firstList[i] < secondList[j])
                    output.Add(firstList[i++]);
                else
                    output.Add(secondList[j++]);
            }

            for (; i < firstList.Count; i++)
                output.Add(firstList[i]);

            for (; j < secondList.Count; j++)
                output.Add(secondList[j]);

            return output;
        }
    }
}
