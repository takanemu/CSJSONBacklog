/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSJSONBacklog.Model.Projects
{
    public class Content
    {
        public int Id { get; set; }
        public int Key_id { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Comment Comment { get; set; }
        public List<Change> Changes { get; set; }

        public override string ToString()
        {
            return string.Format("Content: {0} Key_id: {1} Summary: {2} Description: {3}", Id, Key_id, Summary, Description);
        }
    }
}
