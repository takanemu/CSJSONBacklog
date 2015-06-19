/* See the file "LICENSE" for the full license governing this code. */
using System;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// Star
    /// </summary>
    public class Star
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public User Presenter { get; set; }
        public DateTime? Created { get; set; }

        public override string ToString()
        {
            return string.Format("Star: {0}(Presenter: {1})", Title, Presenter);
        }
    }
}
