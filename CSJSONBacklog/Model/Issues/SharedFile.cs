/* See the file "LICENSE" for the full license governing this code. */

using System;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// SharedFile
    /// </summary>
    public class SharedFile
    {
        public int id { get; set; }
        public string type { get; set; }
        public string dir { get; set; }
        public string name { get; set; }
        public int size { get; set; }
        public User createdUser { get; set; }
        public DateTime? created { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime? Updated { get; set; }

        public override string ToString()
        {
            return string.Format("SharedFile: {0}", name);
        }
    }
}
