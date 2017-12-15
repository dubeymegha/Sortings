namespace Sorting
{
    class HeapSort
    {
        public void Heap_Sort(int[] Arr)
        {
            for (int i = Arr.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(Arr, Arr.Length, i);
            }

            for (int i = Arr.Length - 1; i >= 0; i--)
            {
                Arr = Swap(0, i, Arr);
                Heapify(Arr, i, 0);
            }

            //printing
            for (int i = 0; i < Arr.Length; i++)
            {
                System.Console.WriteLine(Arr[i]);
            }

        }

        public int[] Swap(int i, int j, int[] Arr)
        {
            int temp = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = temp;
            return Arr;
        }
        public void Heapify(int[] Arr, int n, int i)
        {
            int largest = i;
            int Left = 2 * i + 1;
            int Right = 2 * i + 2;
            if (Left < n && Arr[Left] > Arr[largest])
            {
                largest = Left;
            }
             if (Right < n && Arr[Right] > Arr[largest])
            {
                largest = Right;
            }
            if (largest != i)
            {
                Arr = Swap(largest, i, Arr);
                Heapify(Arr, n, largest);
            }


        }
    }
}
