using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Va1", 78);
            myDictionary.Add("Va2", 56);
            myDictionary.Add("Va3", 567);
            myDictionary.Add("Va4", 543);
            myDictionary.Add("Va5", 234);

            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


            if (myDictionary.ContainsKey("Va4"))
            {
                Console.WriteLine("Такий ключ Є тому занчення " + myDictionary["Va4"]);
            }
            else
            {
                Console.WriteLine("Такого ключа немае");
            }

            if (myDictionary.ContainsKey("Va99"))
            {
                Console.WriteLine("Такий ключ Є тому занчення " + myDictionary["Va499"]);
            }
            else
            {
                Console.WriteLine("Такого ключа немае");
            }




            Console.ReadKey();
        }
    }
}
