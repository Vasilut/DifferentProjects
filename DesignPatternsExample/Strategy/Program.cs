using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        /*
         *
         * Define a family of algorithms, encapsulate each one, and make them interchangeable.
        */
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(10);
            sortedList.Add(6);
            sortedList.Add(12);
            sortedList.Add(5);
            sortedList.Add(8);

            //SORT WITH QUICKSORT
            sortedList.SetSortStrategy(new QuickSort());
            sortedList.Sort();

            //sort with mergesort
            sortedList.SetSortStrategy(new MergeSort());
            sortedList.Sort();

            //sort with bubblesort
            sortedList.SetSortStrategy(new BubbleSort());
            sortedList.Sort();

            Console.WriteLine("Hello from stategy pattern");
            Console.ReadLine();
        }
    }
}
