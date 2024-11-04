using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//100000 % i am very much sure. 

//if you only know hte C#.net
namespace hashsetNamespace
{
    internal class hashsetClass
    {
        static void Main()
        {
            //duplicate

            int[] ints = { 10 , 20 ,30 , 10 };

            HashSet<int> set = new HashSet<int>();
            set.Add(10);
            set.Add(20);
            set.Add(30);
            set.Add(10);
            set.Add(10);
            set.Add(10);
            set.Add(10);

            HashSet<string> hstrings = new HashSet<string>();
            hstrings.Add("a");
            hstrings.Add("b");
            hstrings.Add("c");
            hstrings.Add("a");
            

            List<int> lset = new List<int>();
            lset.Add(10);
            lset.Add(20);
            lset.Add(30);
            lset.Add(10);
            lset.Add(10);
            lset.Add(10);
            lset.Add(10);

            Console.WriteLine("Hasset");
            Console.ReadLine();

        }
    }
}
