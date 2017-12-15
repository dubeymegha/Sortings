using System;

namespace Sorting
{
    class CountingSort
    {
        public void Counting_Sort(int[] Input, int GivenRange)
        {
            int[] Arr = new int[GivenRange];
            for (int i = 0; i < Input.Length; i++)
            {
                int temp = Input[i];
                Arr[temp]++;
            }

            //printing the Sorted Array
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > 0)
                    Console.WriteLine(i);
            }
        }
    }
}
