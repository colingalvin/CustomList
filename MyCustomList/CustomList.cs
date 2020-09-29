using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>
    {
        // member variables
        private T[] items;
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
                    return items[index];
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
            items = new T[capacity];
        }
        
        // member methods

        // Add

        public void Add(T value)
        {
            if (Capacity == Count) // check for resize
            {
                items = Resize(items);
            }
            items[count] = value; // add new item to underlying array at count index
            count++; // increment count
        }

        private T[] Resize(T[] oldArray)
        {
            T[] temporaryArray = new T[capacity]; // Create temporary array to store old values
            int i = 0;
            foreach(T item in oldArray)
            {
                temporaryArray[i] = oldArray[i]; // Copy old array into temp
                i++;
            }

            T[] newArray = new T[capacity *= 2]; // Create new array (2x size) for old and new values
            i = 0;
            foreach (T item in temporaryArray)
            {
                newArray[i] = temporaryArray[i]; // Copy old array into temp
                i++;
            }

            return newArray;
        }
    }
}
