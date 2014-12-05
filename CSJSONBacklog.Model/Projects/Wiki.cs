/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Model.Projects
{
    public class WikiPage
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<Tag> Tags { get; set; }
        public User CreatedUser { get; set; }
        public string Created { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime Updated { get; set; }

        public override string ToString()
        {
            return string.Format("WikiPage: {0}({1})", Name, Id);
        }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Tag: {0}({1})", Name, Id);
        }
    }
}
