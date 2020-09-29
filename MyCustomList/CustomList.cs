using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class CustomList<T> where T : new()
    {
        // member variables
        private T[] list;
        public int Count
        {
            get
            {
                int count = 0;
                foreach(T obj in list)
                {
                    if(!obj.Equals(default(T)))
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return list.Length; // can't use array methods?
            }
        }

        // constructor
        public CustomList()
        {
            list = new T[5]; // Initially instantiate array of length 5
        }
       
        // member methods
    }
}
