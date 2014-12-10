/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Projects
{
    public class DiskUsage
    {
        public long ProjectId { get; set; }
        public long Issue { get; set; }
        public long Wiki { get; set; }
        public long File { get; set; }
        public long Subversion { get; set; }
        public long Git { get; set; }

        public override string ToString()
        {
            return string.Format("File: {0}, Git: {1}, Issue: {2}, ProjectId: {3}, Subversion: {4}, Wiki: {5}", File, Git, Issue, ProjectId, Subversion, Wiki);
        }
    }
}
