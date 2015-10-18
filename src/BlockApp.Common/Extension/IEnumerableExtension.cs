using System;
using System.Collections.Generic;
using System.Linq;

namespace BlockApp
{
    public static class IEnumerableExtension
    {
        public static T Random<T>(this IEnumerable<T> source)
        {
            if (source.Count() <= 0)
                new InvalidOperationException("The source sequence is empty.");

            Random rnd = new Random();
            int idx = rnd.Next(source.Count());

            return source.ElementAt(idx);
        }
    }
}
