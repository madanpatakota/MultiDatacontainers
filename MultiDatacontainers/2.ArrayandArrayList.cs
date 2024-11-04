using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayndArrayListNamespace
{
    //container means box
     class ArrayndArrayList
    {
        static void Main()
        {
            int[] ints = new int[4];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
            //ints[4] = 5;
            Console.WriteLine(ints);


            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("World");
            arrayList.Add(true);
            arrayList.Add(30.114);


            //you should do the casting.
            int firstValue =  (int)arrayList[0]; //10
            string secondvalue = (string)arrayList[1];
            bool boolvalue = (bool)arrayList[2];
            double decimalVAlue = (double)arrayList[3];


            Console.WriteLine(arrayList);

            arrayList.Remove(10);
            arrayList.Remove("World");
            arrayList.Remove(true);
           

            Console.ReadLine();


        }
    }
}
