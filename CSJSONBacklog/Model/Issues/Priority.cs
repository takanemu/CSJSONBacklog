/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Issues
{
    public class Priority
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return string.Format("Priority: {0}", name);
        }
    }
}
