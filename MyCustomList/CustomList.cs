using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T> : IEnumerable
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
                if (index >= 0 && index <= count)
                {
                    return items[index];
                }
                else // Index doesn't exist
                {
                    throw new IndexOutOfRangeException(); // Write Unit Tests for this
                }
            }
            set
            {
                items[index] = value;
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        public void Add(T value)
        {
            if (Capacity == Count) // check if underlying array needs to be resized
            {
                items = Resize(items); // returns original values stored in larger array
            }
            items[count] = value; // add new item to underlying array at count index
            count++; // increment count
        }

        private T[] Resize(T[] oldArray)
        {
            T[] newArray = new T[capacity *= 2]; // Create new array (2x size)
            int i = 0;
            foreach (T item in oldArray)
            {
                newArray[i] = oldArray[i]; // Copy old array into new array
                i++;
            }
            return newArray;
        }

        public bool Remove(T value)
        {
            bool remove = false;
            int i = 0;
            foreach(T item in items)
            {
                if(items[i].Equals(value)) // Identify first instance of common value
                {
                    remove = true;
                    break; // Break loop, save index of common value
                }
                i++;
            }
            if(remove == true)
            {
                items = RemoveAndRebuild(items, i); // Remove instance of common value, rebuild rest of array
                count--;
            }
            return remove; // Return bool of whether remove occurred
        }

        private T[] RemoveAndRebuild(T[] oldArray, int skipIndex)
        {
            T[] newArray = new T[capacity]; // Create new array of same capacity
            int i = 0;
            int count = 0;
            foreach (T item in oldArray)
            {
                if (i == skipIndex) // Do not copy first instance of common value into new array
                {
                    i++; // Increment to skip first instance of common value in old array
                    continue;
                }
                else
                {
                    newArray[count] = oldArray[i]; // Copy old array into new array
                    count++;
                    i++;
                }
            }
            return newArray;
        }

        public override string ToString()
        {
            string returnString;
            if(count == 0) // Return empty string if list is empyu
            {
                returnString = "";
                return returnString;
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    stringBuilder.Append(items[i]);
                }
                returnString = stringBuilder.ToString();
                return returnString;
            }
        }

        // Combine two lists in alternating fashion
        public CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2) // Store result in new list
        {
            CustomList<T> newList = new CustomList<T>(); // Store result in new list

            if(list1.Count < list2.Count) // list1 shorter than list2
            {
                int carryover = 0;
                for (int i = 0; i < list1.Count; i++) // Alternate adding until list1 exhausted
                {
                    newList.Add(list1[i]);
                    newList.Add(list2[i]);
                    carryover++;
                }
                for (int j = carryover; j < list2.Count; j++) // Continue adding rest of list 2
                {
                    newList.Add(list2[j]);
                }
            }
            else if(list1.Count > list2.Count) // list1 longer than list2
            {
                int carryover = 0;
                for (int i = 0; i < list2.Count; i++) // Alternate adding until list2 exhausted
                {
                    newList.Add(list1[i]);
                    newList.Add(list2[i]);
                    carryover++;
                }
                for (int j = carryover; j < list1.Count; j++) // Continue adding rest of list1
                {
                    newList.Add(list1[j]);
                }
            }
            else // If counts equal
            {
                for (int i = 0; i < list1.Count; i++) // Alternate adding until both lists exhausted
                {
                    newList.Add(list1[i]);
                    newList.Add(list2[i]);
                }
            }
            return newList;
        }

        // Combine two lists together in sequence
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                newList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }

        // Remove single, common instances between two lists from primary list
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                list1.Remove(list2[i]);
            }
            return list1;
        }
    }
}
