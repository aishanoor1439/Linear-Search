using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int location = 0;
            int x = 30;
            int[] a = { 10, 20, 30, 40, 50 };
            int n = a.Length;
            int i = 1;
            while(i <= n && x != a[i])
            {
                i++;
                if(x == a[i])
                {
                    location = i;
                }
                Console.WriteLine(location);
            }


        }
    }
}
