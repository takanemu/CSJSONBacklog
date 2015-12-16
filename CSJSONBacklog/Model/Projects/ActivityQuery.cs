/* See the file "LICENSE" for the full license governing this code. */

using CSJSONBacklog.Model.Issues;
using System.Collections.Generic;

namespace CSJSONBacklog.Model.Projects
{
    /// <summary>
    /// Query Parameters - Get Project Recent Updates
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-project-activities"/>
    public class ActivityQuery : AbstractParameter
    {
        /// <summary>
        /// number of activity TypeId list to type(1-17)
        /// </summary>
        public IEnumerable<ActivitieType> activitieTypes { get; set; }

        /// <summary>
        /// minimum ID
        /// </summary>
        public int minId { get; set; }
        /// <summary>
        /// maximum ID
        /// </summary>
        public int maxId { get; set; }
        /// <summary>
        /// number of records to retrieve(1-100) default=20
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// "asc" or "desc" default="desc"
        /// </summary>
        public Order order { get; set; }

        public ActivityQuery()
        {
            activitieTypes = new List<ActivitieType>();
            minId = 0;
            maxId = 0;
            count = 20;
            order = Order.desc;
        }

        public string GetParametersForAPI()
        {
            //TODO: use RestSharp
            var parameters = string.Format("order={0}", order) + string.Format("&count={0}", count);

            if (minId > 0)
            {
                parameters += string.Format("&minId={0}", minId);
            }
            if (maxId > 0)
            {
                parameters += string.Format("&maxId={0}", maxId);
            }
            string types = string.Empty;

            foreach (var activitieType in activitieTypes)
            {
                types += "&activityTypeId[]=" + (int)activitieType;
            }
            if (!string.IsNullOrEmpty(types))
            {
                parameters += types;
            }
            return parameters;
        }
    }
}
