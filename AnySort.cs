using System;
using System.Linq;

namespace ProjectRefresh
{
    public class AnySort
    {
        public decimal[] MyList { get; set; }
        public decimal[] NewList { get; set; }
        public int Count { get; set; }
        public AnySort(decimal[] param)
        {
            MyList = param;
            NewList = new decimal[MyList.Length];
            Console.WriteLine("AnySort:" + GetType()); ;
        }
        public virtual void Run()
        {
            
        }

        public string Print()
        {
            return Print(MyList);
        }
        public string Print(params decimal[] input)
        { 
            string result = "";
            result = string.Join(",", input);
            return result;
            //Array.ForEach(input, i=> result += ($"{i.ToString(){,"));
            //input.ToList().ForEach(i => result+=(i.ToString()+","));
            /*
             * foreach (decimal item in input)
            {
                result += (item.ToString() + ",");

            }*/

            //return result[..^1];
            //return result.Substring(0, result.Length - 1);
            //return result.TrimEnd(',');
        }
        public string PrintNew()
        {
            return Print(NewList);
        }

        public void Swap(int i, int j)
        {
            decimal tmp = MyList[i];
            MyList[i] = MyList[j];
            MyList[j] = tmp;

            Count++;

        }

    }
}
