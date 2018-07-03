using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysPairs
{
    public class Pairs
    {
        public int GetPairs(int[] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < x; i++)
                for (int j = i + 1; j < x; j++)

                    // finding the index with same
                    // value but different index.
                    if (arr[i] == arr[j])
                        count++;
            if (count > 100000)
                return 100000;
                return count;
        }
    }
}


