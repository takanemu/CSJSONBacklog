/* See the file "LICENSE" for the full license governing this code. */
using System;

namespace CSJSONBacklog.Model.Projects
{
    /// <summary>
    /// Version(Milestone)
    /// </summary>
    public class Version
    {
        public int id { get; set; }
        public int projectId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? releaseDueDate { get; set; }
        public bool archived { get; set; }
        public int displayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("Version: {0}({1})", name, id);
        }
    }
}
