/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;

namespace CSJSONBacklog.Model.Space
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
        public object DisplayOrder { get; set; }
        public User CreatedUser { get; set; }
        public string Created { get; set; }
        public User UpdatedUser { get; set; }
        public string Updated { get; set; }

        public override string ToString()
        {
            return string.Format("Group: {0}({1})", Name, Id);
        }
    }
}
