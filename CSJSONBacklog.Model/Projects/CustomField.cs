/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Attributes;

namespace CSJSONBacklog.Model.Projects
{
    public class CustomField
    {
        public int id { get; set; }
        public CustomFieldType typeId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public List<int> applicableIssueTypes { get; set; }
        public string min { get; set; }
        public string max { get; set; }
        public string initialValue { get; set; }
        public string unit { get; set; }
        public bool? allowAddItem { get; set; }
        public bool? allowInput { get; set; }

        public override string ToString()
        {
            return string.Format("CustomField: {0}({1}) TypeId: {2}", name, id, typeId);
        }
    }

    public enum CustomFieldType
    {
        Text = 1,
        Sentence = 2,
        Number = 3,
        Date = 4,
        SingleList = 5,
        MultipleList = 6,
        Checkbox = 7,
        Radio = 8,
    }
    
    public class CustomFieldItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int displayOrder { get; set; }

        /// <summary>
        /// return properties for Patch
        /// </summary>
        /// <returns></returns>
        [PatchPropertyNamesMethod]
        public static IEnumerable<string> PatchPropertyNames()
        {
            return new List<string>
                {
                    @"id",
                };
        }

        public override string ToString()
        {
            return string.Format("CustomFieldItem: {0}({1}) DisplayOrder: {2}", name, id, displayOrder);
        }
    }
}
