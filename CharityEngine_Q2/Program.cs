using System;
using System.Collections.Generic;
using System.Linq;

namespace CharityEngine_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] items = { 1, 4, 2, 2, 3, 3, 1 };
            Console.WriteLine(getUniqueElement(items));
            Console.ReadLine();
        }

        public static long getUniqueElement(long[] input_array)
        {
            //Convert array to list
            var arrayToList = input_array.ToList();

            //find duplicates values in list
            var duplicatesValuesList = arrayToList.GroupBy(s => s).SelectMany(grp => grp.Skip(1)); //

            //Get the difference between the two list
            var differenceBetweenLists = arrayToList.Where(i => !duplicatesValuesList.Contains(i));

            return differenceBetweenLists.FirstOrDefault();
        }
    }
}
