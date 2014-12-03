/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSJSONBacklog.Model
{
    public abstract class AbstractParameter
    {
        protected string MultiParametersForAPI(string paramName, IEnumerable<int> paramList)
        {
            var parameters = string.Empty;

            var list = paramList as int[] ?? paramList.ToArray();
            for (var i = 0; i < list.Count(); i++)
            {
                parameters += string.Format("{0}[{1}]={2}&", paramName, i, list[i]);
            }

            return parameters.Count() > 2 ? parameters.Remove(parameters.Length - 1, 1) : string.Empty;
        }

        protected string StringParametersForAPIDate(string paramName, DateTime? date)
        {
            return !date.HasValue
                ? string.Empty
                : string.Format("&paramName={0}", date.Value.ToString("yyyy-MM-dd"));
        }
    }
}
