using System;


namespace Sorting
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] Arr = new int[] { 1, 100, 45, 62, 3, 2, 1000 };

            //Merge Sort
            Merge_Sort mergeobj = new Merge_Sort();
            mergeobj.MergeSort(Arr);
            Console.WriteLine("Sorting using Merge Sort Method");
            mergeobj.Print(Arr);

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
