using System;
using static System.Console;
using static System.Array;

namespace Lab3Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 4, 3, 5, 2, 6, 8, 7, 1, 9 };
            PrintArray("Array", array);
            //Method IndexOf
            int index = IndexOf(array, 1);
            WriteLine($"IndexOf - searching index of '1': index = {index}");
            //Method Exist
            bool exist = Exists(array, elem => elem > 11);
            WriteLine($"Exist - predicate -> if bigger than 11: {exist}");
            //Method FindAll
            int[] find = FindAll(array, elem => elem < 8);
            WriteLine("FindAll - predicate -> if smaller than 8:");
            PrintArray("FindAll", find);
            //Method Sort
            Sort(array);
            PrintArray("Sort", array);
            //Method BinarySearch
            int index2 = BinarySearch(array, 6);
            WriteLine($"Indeks '6': {index2}");
            //Method Reverse
            Reverse(array);
            PrintArray("Reverse", array);
        }

        private static void PrintArray(string name, int[] array)
        {
            Write($"{name}: [ ");
            Write(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                Write($", {array[i]}");
            }
            WriteLine(" ]");
        }
    }
}
