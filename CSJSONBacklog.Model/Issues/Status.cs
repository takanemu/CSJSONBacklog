/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// Status
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-status"/>
    public class Status
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return string.Format("Status: {0}", name);
        }
    }
}
