using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    // Icomparible is used to provid a Default sort order for your obj(object).
    public class FindMaxGeneric<T> where T : IComparable//method is generic
    {
        public T FindMaximumGeneric(T a, T b, T c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            else
                return c;
        }
    }
}