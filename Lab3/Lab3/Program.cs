using System;
using static System.Console;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, m1, n2, m2, temp;
            Random rnd = new Random();

            WriteLine("Podaj wymiary tablicy.");
            Write("n = ");
            n1 = int.Parse(ReadLine());
            Write("m = ");
            m1 = int.Parse(ReadLine());

            int[,] array = new int[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Write($"{array[i, j]}\t");
                }
                Write("\n");
            }
            WriteLine("\nPo zamianie\n");
            for (int i = 0; i < n1 / 2; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    temp = array[i, j];
                    array[i, j] = array[n1 - (i + 1), j];
                    array[n1 - (i + 1), j] = temp;
                }
            }
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Write($"{array[i, j]}\t");
                }
                Write("\n");
            }


            WriteLine("\n\nPodaj wymiary tablicy.");
            Write("n = ");
            n2 = int.Parse(ReadLine());
            Write("m = ");
            m2 = int.Parse(ReadLine());

            int[][] array2 = new int[n2][];
            for (int i = 0; i < n2; i++)
            {
                array2[i] = new int[m2];
            }

            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    array2[i][j] = rnd.Next(10);
                }
            }
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Write($"{array2[i][j]}\t");
                }
                Write("\n");
            }
            WriteLine("\nPo zamianie\n");
            for (int i = 0; i < n2 / 2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    temp = array2[i][j];
                    array2[i][j] = array2[n2 - (i + 1)][j];
                    array2[n2 - (i + 1)][j] = temp;
                }
            }
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Write($"{array2[i][j]}\t");
                }
                Write("\n");
            }
        }
    }
}
