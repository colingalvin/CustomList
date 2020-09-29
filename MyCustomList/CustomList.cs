using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class CustomList<T>
    {
        // member variables
        private T[] list;
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        
        // indexer
        public T this[int index]
        {
            get
            {
                //if (index >0 && index <= capacity) // If index is within bounds of capacity
                {
                    return list[index];
                }
                //else
                //{
                //    // Need to add verification that user cannot access out-of-bounds index
                //    return;
                //}
            }
        }

        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            list = new T[capacity];
        }
       
        // member methods
    }
}
