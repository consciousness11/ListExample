using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
   public class Quick
    {
        public  void Quick_Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);

                if (pivot > 1)
                {
                    Quick_Sort(arr, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    Quick_Sort(arr, pivot + 1, end);
                }
            }

        }

       public int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[start];
            while (true)
            {

                while (arr[start] < pivot)
                {
                    start++;
                }

                while (arr[end] > pivot)
                {
                    end--;
                }

                if (start < end)
                {
                    if (arr[start] == arr[end]) return end;

                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;


                }
                else
                {
                    return end;
                }
            }
        }
    }
}
