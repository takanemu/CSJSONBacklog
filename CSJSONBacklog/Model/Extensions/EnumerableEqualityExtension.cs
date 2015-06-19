using System.Collections.Generic;
using System.Linq;

namespace CSJSONBacklog.Model.Extensions
{
    public static class EnumerableEqualityExtension
    {
        /// <summary>
        /// Compare two Enumerable objects for equality
        /// </summary>
        /// <see cref="http://stackoverflow.com/questions/3669970/compare-two-listt-objects-for-equality-ignoring-order"/>
        public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
        {
            var cnt = new Dictionary<T, int>();
            foreach (T s in list1)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]++;
                }
                else
                {
                    cnt.Add(s, 1);
                }
            }
            foreach (T s in list2)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]--;
                }
                else
                {
                    return false;
                }
            }
            return cnt.Values.All(c => c == 0);
        }
    }
}
