using System;

namespace ProjectRefresh
{
    
    class QuickSort : AnySort
    {
        public QuickSort(decimal[] param):base(param)
        {
            //Console.WriteLine(this.GetType());
        }

        public override void Run() =>Partition(0, MyList.Length - 1);


        public int Partition(int start, int end){
            int pivot = end;
            int i=start-1;
            for (int j = start; j < end; j++)
            {
                if(MyList[j]<MyList[pivot]){
                    i++;
                    //if(i!=j)
                    Swap(i, j);
                }
            }
            i++;
            Swap(i, pivot);

            if (i - start > 1)
                Partition(start, i - 1);
            if (end - i > 1)
                Partition(i + 1, end);
            
            return i;

        } 
    }
}