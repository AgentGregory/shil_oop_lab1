using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shil_oop_lab1
{
    public class CocktailSort<T> : ISortStrategy<T> where T : IComparable<T>
    {
        public IEnumerable<T> Sort(IEnumerable<T> array, bool ascending)
        {
            var list = array.ToList();
            int left = 0, right = list.Count - 1;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = left; i < right; i++)
                {
                    if ((ascending && list[i].CompareTo(list[i + 1]) > 0) ||
                        (!ascending && list[i].CompareTo(list[i + 1]) < 0))
                    {
                        (list[i], list[i + 1]) = (list[i + 1], list[i]);
                        swapped = true;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if ((ascending && list[i - 1].CompareTo(list[i]) > 0) ||
                        (!ascending && list[i - 1].CompareTo(list[i]) < 0))
                    {
                        (list[i - 1], list[i]) = (list[i], list[i - 1]);
                        swapped = true;
                    }
                }
                left++;
            } while (swapped);
            return list;
        }
    }
}
