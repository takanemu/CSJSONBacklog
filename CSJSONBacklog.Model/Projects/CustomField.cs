/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;

namespace CSJSONBacklog.Model.Projects
{
    public class CustomField
    {
        public int Id { get; set; }
        public CustomFieldType TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public List<IssueType> ApplicableIssueTypes { get; set; }
        public bool AllowAddItem { get; set; }
        public List<CustomFieldItem> Items { get; set; }

        public override string ToString()
        {
            return string.Format("CustomField: {0}({1}) TypeId: {2}", Name, Id, TypeId);
        }
    }

    public enum CustomFieldType
    {
        None = 0,
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
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("CustomFieldItem: {0}({1})", Name, Id);
        }
    }
}
