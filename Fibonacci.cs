using System;
namespace ProjectRefresh
{
    public class Fibonacci
    {
        public int count { get; set; } = 0;
        public int idx { get; set; } = 0;
        //public int FibonacciNumber { get; set; } = -1;
        public Fibonacci()
        {
        }
        public int getFibonacciNumber(int index)
        {
            count++;
            if (index < 2)
                return index;

            return getFibonacciNumber(index - 1) + getFibonacciNumber(index - 2);
        }

        public int getFibonacciNumberNonRecursive(int index)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < (index/2); i++)
            {
                a += b;
                b += a;
                //Console.WriteLine($"{a} {b}");
               
            }
            count = index+1;
            return b;

        }
        public int getSmallestFibonacciNumberLargerThan(int floor)
        {
            idx = 0;
            int r=0;
            while (r < floor)
            {
                r = getFibonacciNumber(idx);
                idx++;
                
            }
            //r = getFibonacciNumber(idx + 1);
            return r;
        }
        public int getLargestFibonacciNumberSmallerThan(int ceiling)
        {
            idx = 0;
            int r = 0;
            while (r < ceiling)
            {
                r = getFibonacciNumber(idx);
                idx++;
                
            }
            idx -= 1;
            r = getFibonacciNumber(idx - 1);
            
            return r;
        }
        public bool isFibonacciNumber(int input)
        {
            //todo

            return false;
        }
    }
}
