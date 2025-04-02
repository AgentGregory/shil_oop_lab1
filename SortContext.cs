using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shil_oop_lab1
{
    public class SortContext<T> where T : IComparable<T>
    {
        private ISortStrategy<T> _strategy;

        public void SetStrategy(ISortStrategy<T> strategy)
        {
            _strategy = strategy;
        }

        public IEnumerable<T> Sort(IEnumerable<T> collection, bool ascending)
        {
            return _strategy?.Sort(collection, ascending) ?? collection;
        }
    }
}
