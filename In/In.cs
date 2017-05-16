using System.Collections.Generic;
using System.Linq;

namespace In
{
    public static class InExtension
    {
        public static bool In<T>(this T item, params T[] list)
        {
            return list.Contains(item);
        }

        public static bool In<T>(this T item, IEnumerable<T> list)
        {
            return list != null && list.Contains(item);
        }
    }
}
