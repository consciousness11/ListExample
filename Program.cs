using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> subjects = new List<string>();
            int[] arr = new int[] { 2, 5, 6, -7, 8, 9, 1, 0 };

            Quick q = new Quick();
            q.Quick_Sort(arr, 0, arr.Length - 1);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }


            subjects.Add("Programming");
            subjects.Add("Database");
            subjects.Add("Project");
            subjects.Sort();
            subjects.Remove("Project");
           // Console.WriteLine(subjects.IndexOf("Programming"));

            int x = subjects.BinarySearch("Project");
          //  Console.WriteLine(x);


            foreach(string s in subjects)
            {
           //     Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
