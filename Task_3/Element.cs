using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal struct Element<T,R>
    {
        public T Key {  get; set; }
        public R Value { get; set; }

    }
}
