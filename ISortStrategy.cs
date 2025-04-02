using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shil_oop_lab1
{
    public interface ISortStrategy<T> where T : IComparable<T>
    {
        IEnumerable<T> Sort(IEnumerable<T> arr, bool ascending);
    }
}
