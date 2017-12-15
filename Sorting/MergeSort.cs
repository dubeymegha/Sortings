using System;


namespace Sorting
{
    class Merge_Sort
    {
        static void Merge(int[] L, int[] R, int[] A)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < L.Length && j < R.Length)
            {
                if (L[i] < R[j])
                {
                    A[k] = L[i];
                    i++;
                    k++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                    k++;
                }
            }

            while (i < L.Length)
            {
                A[k] = L[i];
                k++;
                i++;
            }
            while (j < R.Length)
            {
                A[k] = R[j];
                k++;
                j++;
            }

        }
        static void MergeSort(int[] Arr)
        {
            if (Arr.Length < 2)
                return;
            int mid = Arr.Length / 2;
            int[] L = new int[mid];
            int[] R = new int[Arr.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                L[i] = Arr[i];
            }
            int j = 0;
            for (int i = mid; i < Arr.Length; i++, j++)
            {
                R[j] = Arr[i];
            }
            MergeSort(L);
            MergeSort(R);
            Merge(L, R, Arr);
        }
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 1, 100, 45, 62, 3, 2, 1000 };

            //Merge Sort
            MergeSort(Arr);
            Console.WriteLine("Sorting using Merge Sort Method");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            //Counting Sort
            Console.WriteLine("Sorting using Counting Sort Method");
            CountingSort obj = new CountingSort();
            obj.Counting_Sort(Arr, 10001);

            //Heap Sort
            Console.WriteLine("Sorting using Heap Sort Method");
            HeapSort heap = new HeapSort();
            heap.Heap_Sort(Arr);

            Console.ReadKey();
        }
    }
}
