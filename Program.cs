using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Day_29_Bitwise_AND
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string[] nk_var = Console.ReadLine().Split(' ');
                int n = int.Parse(nk_var[0]);
                int k = int.Parse(nk_var[1]);

                if ((k - 1 | k) > n && k % 2 == 0)
                    Console.WriteLine(k - 2);
                else
                    Console.WriteLine(k - 1);
            }
        }
    }
}
