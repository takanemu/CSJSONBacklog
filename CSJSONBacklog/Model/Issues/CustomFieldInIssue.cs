/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Attributes;
using CSJSONBacklog.Model.Projects;

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// CustomFieldInIssue
    /// </summary>
    public class CustomFieldInIssue
    {
        public int id { get; set; }
        public CustomFieldType fieldTypeId { get; set; }
        public string name { get; set; }
        public object value { get; set; }
        public List<object> otherValue { get; set; }

        /// <summary>
        /// return properties for Patch
        /// </summary>
        /// <returns></returns>
        [PatchPropertyNamesMethod]
        public static IEnumerable<string> PatchPropertyNames()
        {
            return new List<string>
                {
                    @"value",
                    @"otherValue"
                };
        }
    }
}
