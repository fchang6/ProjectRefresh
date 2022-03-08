using System;
namespace ProjectRefresh
{
    public class InsertionSort : AnySort
    {

        public InsertionSort(decimal[] param) : base(param)
        {
            //Console.WriteLine(GetType());
            
        }
        public override void Run()
        {
            for (int i = 0; i < MyList.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (MyList[j] < MyList[j - 1])
                        Swap(j, j - 1);
                    else
                        break;

                }      
            }
            
        }
    }
}
