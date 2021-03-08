using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    class Program
    {
        public static void Bubblesort(int[] data)
        {
            int t;
            for (int p = 0; p <= data.Length - 2; p++)
            {
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        t = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = t;
                    }
                }
            }
        }

        public static void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        int tmp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = tmp;
                    }
                    else
                        break;
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int pos_min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
        }


       

        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 100000;

            int[] talarray = new int[10000];

            Random randNum = new Random();
            for (int i = 0; i < talarray.Length; i++)
            {
                talarray[i] = randNum.Next(Min, Max);
            }
            int svar = 5;

            Stopwatch stopWatch = new Stopwatch();

            
            while (svar != 0)
            { 
                Console.WriteLine("=======================================");
                Console.WriteLine("Vilken sorteringsmetod vill du använda? ");
                Console.WriteLine("0. Avsluta 1. Bubblesort 2. Insertionsort 3. Selectionsort");
                svar = int.Parse(Console.ReadLine());
                
                if ( svar == 1)
                {
                    stopWatch.Start();

                    Bubblesort(talarray);

                    stopWatch.Stop();
                    Console.WriteLine("Listan är sorterad genom Bubblesort!");
                    Console.WriteLine("Tid det tog: " + stopWatch.Elapsed);
                    Console.WriteLine(talarray.Length);
                }
                else if (svar == 2)
                {
                    stopWatch.Start();

                    InsertionSort(talarray);

                    stopWatch.Stop();
                    Console.WriteLine("Listan är sorterad genom Insertionsort!");
                    Console.WriteLine("Tid det tog: " + stopWatch.Elapsed);
                }
                else if (svar == 3)
                {
                    stopWatch.Start();

                    SelectionSort(talarray);

                    stopWatch.Stop();
                    Console.WriteLine("Listan är sorterad genom Selectionsort!");
                    Console.WriteLine("Tid det tog: " + stopWatch.Elapsed);
                }
            }
            
            
            

        }
    }
}
