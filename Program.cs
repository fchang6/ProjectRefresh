using System;

namespace ProjectRefresh
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal[] array1 = { 1, 9,15, 4,7,8,13, 3, 2, 9, -4 };
            //QuickSort qs = new QuickSort(array1);
            //BubbleSort qs = new BubbleSort(array1);
            //InsertionSort qs = new InsertionSort(array1);
            MergeSort qs = new MergeSort(array1);
            Console.WriteLine(qs.Print());
            //qs.Swap(2,3);
            //Console.WriteLine(qs.Print());
            qs.Run();
            //qs.Merge(0, 2, 3,3);
            Console.WriteLine(qs.Print());
            Console.WriteLine(qs.PrintNew());
            Console.WriteLine(qs.Count);

        }

    }
}