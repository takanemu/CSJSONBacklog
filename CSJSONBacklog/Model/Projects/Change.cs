/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Projects
{
    public class Change
    {
        public string Field { get; set; }
        public string New_value { get; set; }
        public string Old_value { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("Change: {0} New_value: {1} Old_value: {2} Type: {3}", Field, New_value, Old_value, Type);
        }
    }
}
