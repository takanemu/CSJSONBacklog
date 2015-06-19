/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// IssueType
    /// </summary>
    public class IssueType
    {
        public int id { get; set; }
        public int projectId { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int displayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("IssueType: {0}({1})", name, id);
        }
    }
}
