using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shil_oop_lab1
{
    public class InsertionSort<T> : ISortStrategy<T> where T: IComparable<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> collection, bool ascending)
        {
            var list = collection.ToList();
            for (int i = 1; i < list.Count; i++)
            {
                var key = list[i];
                int j = i - 1;
                while (j >= 0 && ((ascending && list[j].CompareTo(key) > 0) ||
                                  (!ascending && list[j].CompareTo(key) < 0)))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
            return list;
        }
    }
}
