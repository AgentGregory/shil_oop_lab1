using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shil_oop_lab1
{
    public class QwertS : ISortStrategy<int>
    {
        public IEnumerable<int> Sort(IEnumerable<int> collection, bool ascending)
        {
            var list = collection.ToList();
            int max = list.Max();
            int exp = 1;
            while (max / exp > 0)
            {
                list = CountingSortByDigit(list, exp, ascending);
                exp *= 10;
            }
            return list;
        }

        private List<int> CountingSortByDigit(List<int> list, int exp, bool ascending)
        {
            int[] output = new int[list.Count];
            int[] count = new int[10];

            foreach (var num in list)
                count[(num / exp) % 10]++;

            if (!ascending)
            {
                for (int i = 8; i >= 0; i--)
                    count[i] += count[i + 1];
            }
            else
            {
                for (int i = 1; i < 10; i++)
                    count[i] += count[i - 1];
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                int index = (list[i] / exp) % 10;
                output[count[index] - 1] = list[i];
                count[index]--;
            }

            return output.ToList();
        }
    }
}
