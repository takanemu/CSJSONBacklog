/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.API;
using CSJSONBacklog.Model.Issues;

namespace CSJSONBacklog.Communicator
{
    public class IssueCommunicator : AbstractCommunicator, IIssueAPI
    {
        public IssueCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}

        /// <summary>
        /// Returns number of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues-count"/>
        public int GetIssuesCount(int projectId)
        {
            var issueCount = GetT<CountValue>(string.Format("https://{0}.backlog.jp/api/v2/issues/count?apiKey={1}&projectId[]={2}", Spacename, ApiKey, projectId));
            return issueCount == null ? 0 : issueCount.Count;
        }

        /// <summary>
        /// Returns number of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues-count"/>
        public int GetIssuesCount(IEnumerable<int> projectIds)
        {
            var issueCount = GetT<CountValue>(string.Format("https://{0}.backlog.jp/api/v2/issues/count?apiKey={1}&{2}", Spacename, ApiKey, MultiParametersForAPI(@"projectId", projectIds)));
            return issueCount == null ? 0 : issueCount.Count;
        }

        /// <summary>
        /// Returns list of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues"/>
        public IEnumerable<Issue> GetIssues(QueryIssueParameters param)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues?apiKey={1}&{2}", Spacename, ApiKey, param.GetParametersForAPI());
            return GetT<IEnumerable<Issue>>(uri);
        }
    }
}
