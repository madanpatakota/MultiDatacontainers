using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandListContainers
{
    class Program
    {
        static void Main()
        {

            //int[] numbers = new int[3]; //fixed size
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //Console.WriteLine(numbers);

            //numbers.

            //not-fixed siz2

            // Box you hava to add speific type -- List.

            // BOx -- Pens
            // BOx- Pencils


            //List -> is the container which can holds multiple values. but same type
            List<int> list = new List<int>();
            list.Add(1);
            //list.Add("Madan");
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list);


            //Access the first value.

           int firstVAlue = list[0]; //1
           Console.WriteLine(firstVAlue);

           foreach(int vAlue in list)
            {
                Console.WriteLine($"{vAlue}");
            }

            list.Remove(3);

            list.Count();




            List<string> strings = new List<string>();
            strings.Add("a");
            strings.Add("b");
            strings.Add("c");
            Console.WriteLine(strings);

            List<bool> bools = new List<bool>();

            bools.Add(true);
            bools.Add(false);
            bools.Add(true);



            Console.ReadLine();

        }
    }
}
