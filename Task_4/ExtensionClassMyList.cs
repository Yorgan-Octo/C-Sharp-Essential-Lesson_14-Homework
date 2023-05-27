using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public static class ExtensionClassMyList
    {

        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();   
        }


    }
}
