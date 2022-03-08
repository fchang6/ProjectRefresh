using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectRefresh
{
    class MergeSort : AnySort
    {
        
        public MergeSort(decimal[] param) : base(param)
        {
        }
        public override void Run()
        {
            DivideAndMerge(0, MyList.Length - 1);
            //MyList = NewList;
        }
        public void DivideAndMerge(int start, int end)
        {
            Count++;
            //if (Count < 50 && start!=end) // for debugging infinite loop
            if (start != end)
            {
                //int mid = (int)Math.Ceiling((new int[] { start, end }).Average());
                //int mid = (int)Math.Ceiling((decimal)(start + end) / 2);
                

                int mid = (int) Math.Ceiling(Enumerable.Average(new List <int> { start,end}));

                if (mid + 1 > end)
                    mid = end - 1;

                Console.WriteLine($"{start} {mid} || {mid+1} {end}");
                

                if (mid-start>0)
                {
                    DivideAndMerge(start, mid);
                }
                if (end-(mid+1)>0)
                    DivideAndMerge(mid+1, end);

                Merge(start, mid, mid + 1, end);

            }

        }
        public void Merge(int LeftStart, int LeftEnd, int RightStart, int RightEnd)
        {
            int baseindex = LeftStart;
            int i = LeftStart;
            int j = RightStart;
            while (baseindex<=RightEnd)
            {
              

                if(i == LeftEnd+1 && j<=RightEnd){
                    NewList[baseindex] = MyList[j];
                    baseindex++;
                    j++;
                    continue;
                }

                if(j == RightEnd+1 && i<=LeftEnd){
                    NewList[baseindex] = MyList[i];
                    baseindex++;
                    i++;
                    continue;
                }

                if (MyList[i] > MyList[j])
                {
                    NewList[baseindex] = MyList[j];
                    j++;
                    baseindex++;
                }
                else
                {
                     NewList[baseindex] = MyList[i];
                    i++;
                    baseindex++;
                }

                
            }
            for (int k = LeftStart; k <= RightEnd; k++)
            {
                MyList[k] = NewList[k];
            }
            //Console.WriteLine($"{LeftStart} {LeftEnd} -- {RightStart} {RightEnd} --" + PrintNew());


        }
    }
    
}
