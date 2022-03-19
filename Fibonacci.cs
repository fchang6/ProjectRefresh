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
            int a = 0;//n0
            int b = 1;//n1
            if (index < 2)
                return index;
            for (int i = 0; i < (index/2); i++)
            {
                a += b;
                b += a;
                //Console.WriteLine($"{a} {b}");
               
            }
            //todo: deal with boundary
            count = index+1;
            return b;

        }
        public int getFibonacciNumberNonRecursive2(int index)
        {
            int nMinus1 = 0;
            int nMinus2 = 1;
            int n = 0;
            if (index < 2)
                return index;

            for (int i = 1; i <=index; i++)
            {
                n = nMinus1 + nMinus2;
                nMinus2 = nMinus1;
                nMinus1 = n;
                
                //Console.WriteLine($"{i} {nMinus1} {nMinus2} {r}");

            }
            
            return n;

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
