/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Projects
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return string.Format("Comment: {0} Content: {1}", Id, Content);
        }
    }
}
