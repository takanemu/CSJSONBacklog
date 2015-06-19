/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// Attachment
    /// </summary>
    public class Attachment
    {
        public int id { get; set; }
        public string name { get; set; }
        public long size { get; set; }

        public override string ToString()
        {
            return string.Format("Attachment: {0}", name);
        }
    }
}
