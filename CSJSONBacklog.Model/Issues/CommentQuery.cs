/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// Query Parameters - Get Comment List
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-comments"/>
    public class CommentQuery : AbstractParameter
    {
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

            return parameters;
        }
    }
}
