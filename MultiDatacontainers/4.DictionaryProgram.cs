using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryNamespace
{
     class DictionaryClass
    {
        static void Main()
        {
            Dictionary<int,string> englishDictionary = new Dictionary<int,string>();

            englishDictionary.Add(1, "A");
            //englishDictionary.Add(1, "A");
            englishDictionary.Add(2, "B");
            englishDictionary.Add(3, "C");


            Dictionary<int, string> studentNames = new Dictionary<int, string>();
            studentNames.Add(1, "Siva");
            studentNames.Add(2, "Keerthi");
            studentNames.Add(3, "Karthik");
            studentNames.Add(4, "Shashank");

            string studetnFirstname =  studentNames[1];

            if(studentNames.ContainsKey(2)) // value is their or not.
            {
                // Do your Code
            }


            studentNames.Remove(2); // removing an item by key.


            //Print each and everyvalue.
            foreach(KeyValuePair<int,string> keyValuePair in studentNames)
            {
                Console.WriteLine("key is" + keyValuePair.Key);
                Console.WriteLine("value is"+  keyValuePair.Value);

            }

            Console.ReadLine();



        }
    }
}
