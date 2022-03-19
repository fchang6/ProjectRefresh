using System;

namespace ProjectRefresh
{
    class Program
    {

        static void Main(string[] args)
        {
            #region sorting
            //decimal[] array1 = { 1, 9,15, 4,7,8,13, 3, 2, 9, -4 };

            //QuickSort qs = new QuickSort(array1);
            //BubbleSort qs = new BubbleSort(array1);
            //InsertionSort qs = new InsertionSort(array1);
            //MergeSort qs = new(array1);
            //Console.WriteLine(qs.Print());
            //qs.Swap(2,3);

            //Console.WriteLine(qs.Print());
            //qs.Run();
            //qs.Merge(0, 2, 3,3);
            //Console.WriteLine(qs.Print());
            //Console.WriteLine(qs.PrintNew());
            //Console.WriteLine(qs.Count);

            #endregion

            #region search

            /*int[] array1 = new int[] { 1, 2, 5, 8, 9, 13,15,18 };
            BinarySearch bs = new BinarySearch(array1, 1);
            bs.Run();
            Console.WriteLine($"{bs.result} {bs.resultIndex}");
            */
            #endregion

            #region binary to decimal
            /*
            Console.WriteLine("Insert a binary number");
            string v = Console.ReadLine();

            NumberConverter mc = new NumberConverter();
            int r1 = mc.BinaryToDecimal(v);
            if (mc.status)
            {
                Console.WriteLine($"{mc.resultMsg}. The binary number of {v} is {r1}. there're {mc.numOfOne} of 1's in {v}.");
            }
            else
            {
                Console.WriteLine(mc.resultMsg);
            }*/


            #endregion

            #region decimal to binary
            /*Console.WriteLine("Insert a decimal number");
            v = Console.ReadLine();

            NumberConverter mc1 = new NumberConverter();
            string r2 = mc1.DecimalToBinary(v);
            if (mc1.status)
            {
                Console.WriteLine($"{mc1.resultMsg}.The binary number of {v} is {r2}. there're {mc1.numOfOne} of 1's in {r2}");
            }
            else
            {
                Console.WriteLine(mc1.resultMsg);
            }
            */

            #endregion

            #region Fibonacci

            Fibonacci fi = new Fibonacci();
            Console.WriteLine($"{fi.getFibonacciNumber(5)} {fi.count}");
            Console.WriteLine($"{fi.getFibonacciNumberNonRecursive(5)} {fi.count}");
            Console.WriteLine($"{fi.getFibonacciNumberNonRecursive2(5)} {fi.count}");
            Console.WriteLine($"{fi.getSmallestFibonacciNumberLargerThan(20)} {fi.idx}");
            Console.WriteLine($"{fi.getLargestFibonacciNumberSmallerThan(20)} {fi.idx}");


            #endregion
        }

    }
}