﻿using System;
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
            // Create new lists of type int.
            CustomList<int> intList1 = new CustomList<int>();
            CustomList<int> intList2 = new CustomList<int>();

            // Add values to each list.
            intList1.Add(1);
            intList1.Add(3);
            intList1.Add(5);
            Console.WriteLine("intList1 contains: " + intList1.ToString());

            intList2.Add(2);
            intList2.Add(1);
            intList2.Add(6);
            Console.WriteLine("intList2 contains: " + intList2.ToString());

            // Compare intList1 and intList2, remove common instance of '1' in both lists from intList1.
            CustomList<int> newIntList = intList1 - intList2;
            Console.WriteLine("newIntList contains: " + newIntList.ToString());

            /* 
            
            The above code example produces the following output:
              
                intList1 contains: 135
                intList2 contains: 216
                newIntList contains: 35
             
            */

            CustomList<bool> boolList1 = new CustomList<bool>();
            CustomList<bool> boolList2 = new CustomList<bool>();

            boolList1.Add(true);
            boolList1.Add(false);
            boolList1.Add(false);
            Console.WriteLine("boolList1 contains: " + boolList1.ToString());

            boolList2.Add(false);
            Console.WriteLine("boolList2 contains: " + boolList2.ToString());

            // Compare lists, remove single values common to both lists from boolList1.
            // Only 1 'false' value will be removed from boolList1 in keeping with the 1:1 ratio of removal.
            CustomList<bool> newBoolList = boolList1 - boolList2;
            Console.WriteLine("newBoolList contains: " + newBoolList.ToString());

            /* 
            
            The above code example produces the following output:
              
                boolList1 contains: TrueFalseFalse
                boolList2 contains: False
                newBoolList contains: TrueFalse
             
            */

            CustomList<char> charList1 = new CustomList<char>();
            CustomList<char> charList2 = new CustomList<char>();

            charList1.Add('a');
            charList1.Add('b');
            Console.WriteLine("charList1 contains: " + charList1.ToString());
            
            charList2.Add('b');
            charList2.Add('c');
            charList2.Add('d');
            Console.WriteLine("charList2 contains: " + charList2.ToString());

            // Smaller lists may be compared to larger lists.
            // Compare lists, remove single values common to both lists from charList1.
            CustomList<char> newCharList = charList1 - charList2;
            Console.WriteLine("newCharList contains: " + newCharList.ToString());

            /* 
            
            The above code example produces the following output:
              
                charList1 contains: ab
                charList2 contains: bcd
                newBoolList contains: a
             
            */

            CustomList<string> stringList1 = new CustomList<string>();
            CustomList<string> stringList2 = new CustomList<string>();

            Console.WriteLine("stringList1 contains: " + stringList1.ToString());

            stringList2.Add("Hello");
            stringList2.Add("World");
            Console.WriteLine("stringList2 contains: " + stringList2.ToString());

            // Empty lists may be compared to lists of any size.
            CustomList<string> newStringList = stringList1 - stringList2;
            Console.WriteLine("newStringList contains: " + newStringList.ToString());

            /* 
            
            The above code example produces the following output:
              
                stringList1 contains:
                stringList2 contains: HelloWorld
                newstringList contains:
             
            */
        }
    }
}
