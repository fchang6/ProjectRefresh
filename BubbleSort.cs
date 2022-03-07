using System;
namespace ProjectRefresh
{
    class BubbleSort:AnySort
    {
        public BubbleSort(decimal[] param):base(param)
        {
            //Console.WriteLine(GetType());
        }
        public override void Run()
        {
            for (int i = 0; i < MyList.Length; i++)
            {
                for (int j = i+1; j < MyList.Length; j++)
                {
                    if (MyList[i] > MyList[j])
                        Swap(i, j);

                }

            }
        }
    }
}
