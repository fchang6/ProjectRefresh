using System;
namespace ProjectRefresh
{
    public class BinarySearch
    {
        public int[] MyList { get; set; }
        public int searchNum { get; set; }
        public bool result { get; set; }
        public int resultIndex { get; set; }
        
        public BinarySearch(int[] param, int param2)
        {
            MyList = param;
            searchNum = param2;
            result = false;
            resultIndex = -1;
        }
        public void Run()
        {
            binarySearch(0, MyList.Length - 1);
        }
        public void binarySearch(int start, int end)
        {
            Console.WriteLine($"{start} || {end}");
            if (start <= end)
            {
                int mid = (start + end + (start + end) % 2) / 2;
                if (MyList[mid] == searchNum)
                {
                    result = true;
                    resultIndex = mid;
                }

                if (!result)
                {
                    if (searchNum < MyList[mid])
                        binarySearch(start, mid - 1);
                    else
                        binarySearch(mid + 1, end);

                }

            }
        }
    }
}
