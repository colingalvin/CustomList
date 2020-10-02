using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Remove(1);
            list.Remove(1);

            list.TrimExcess();

            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
        }
    }
}
