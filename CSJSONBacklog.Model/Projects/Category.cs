/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Projects
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public int displayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("Category: {0}", name);
        }
    }
}
