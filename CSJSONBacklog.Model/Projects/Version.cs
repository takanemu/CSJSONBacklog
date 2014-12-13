/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Projects
{
    /// <summary>
    /// Version
    /// </summary>
    public class Version
    {
        public int id { get; set; }
        public int projectId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public object startDate { get; set; }
        public object releaseDueDate { get; set; }
        public bool archived { get; set; }
        public int displayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("Version: {0}({1})", name, id);
        }
    }
}
