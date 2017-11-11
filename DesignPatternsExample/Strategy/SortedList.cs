using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SortedList
    {
        private List<int> _elements;
        private ISortStrategy _sortStrategy = null;
        public SortedList()
        {
            _elements = new List<int>();
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(int element)
        {
            _elements.Add(element);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_elements);

            foreach (var item in _elements)
            {
                Console.WriteLine(item);
            }
        }


    }
}
