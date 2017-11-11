using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<int> elementList)
        {
            elementList.Sort();
            Console.WriteLine("List sorted by quickSort");
        }
    }
}
