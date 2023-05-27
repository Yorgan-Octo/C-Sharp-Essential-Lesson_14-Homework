using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_2;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Element> list = new MyList<Element>();

            Console.WriteLine("Количество елементов до добавления: " + list.Count);

            list.Add(new Element() { Name = "Artem", Value = "Hello Im Artem" });
            list.Add(new Element() { Name = "Dima", Value = "Hello Im Dima" });
            list.Add(new Element() { Name = "Liza", Value = "Hello Im Liza" });
            list.Add(new Element() { Name = "Anna", Value = "Hello Im Anna" });
            list.Add(new Element() { Name = "Gala", Value = "Hello Im Gala" });

            Console.WriteLine("Количество елементов после добавления: " + list.Count);

            Console.WriteLine(new String('-', 50));

            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(new String('-', 50));


            Element[] elements = list.GetArray();

            Console.WriteLine("начення елементів масиву, який повернув метод GetArray(), що розширює метод: ");
            Console.WriteLine(new String('-', 50));

            foreach (var item in elements)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadKey();


        }
    }
}
