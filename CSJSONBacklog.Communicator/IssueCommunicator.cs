/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.API;
using CSJSONBacklog.Model.Issues;
using Newtonsoft.Json;

namespace CSJSONBacklog.Communicator
{
    public class IssueCommunicator : AbstractCommunicator, IIssueMethods
    {
        public IssueCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}

        private int _CountIssue(string uri)
        {
            var json = GetJson(uri);
            var issueCount = JsonConvert.DeserializeObject<CountValue>(json);
            return issueCount == null ? 0 : issueCount.Count;
        }

        /// <summary>
        /// Returns number of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues-count"/>
        public int GetIssuesCount(int projectId)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues/count?apiKey={1}&projectId[]={2}", Spacename, ApiKey, projectId);
            return _CountIssue(uri);
        }

        /// <summary>
        /// Returns number of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues-count"/>
        public int GetIssuesCount(IEnumerable<int> projectIds)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues/count?apiKey={1}&{2}", Spacename, ApiKey, MultiParametersForAPI(@"projectId", projectIds));
            return _CountIssue(uri);
        }

        public IEnumerable<Issue> GetIssues(QueryIssueParameters param)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues?apiKey={1}&{2}",
                Spacename,
                ApiKey,
                param.GetParametersForAPI());

            var json = GetJson(uri);
            var list = JsonConvert.DeserializeObject<List<Issue>>(json);
            return list ?? new List<Issue>();
        }
    }
}
