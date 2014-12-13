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
        /// Returns information about issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issue"/>
        public Issue GetIssue(string issueIdOrKey)
        {
            return GetT<Issue>(string.Format("https://{0}.backlog.jp/api/v2/issues/{1}?apiKey={2}", Spacename, issueIdOrKey, ApiKey));
        }

        /// <summary>
        /// Returns list of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues"/>
        public IEnumerable<Issue> GetIssues(IssueQuery param)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues?apiKey={1}&{2}", Spacename, ApiKey, param.GetParametersForAPI());
            return GetT<IEnumerable<Issue>>(uri);
        }

        /// <summary>
        /// Updates information about issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/update-issue"/>
        public Issue UpdateIssue(Issue issue)
        {
            return PatchT(string.Format("/api/v2/issues/{0}", issue.issueKey), issue);
        }

        /// <summary>
        /// Returns list of comments in issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-comments"/>
        public IEnumerable<Comment> GetCommentList(string issueIdOrKey, CommentQuery query)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues/{1}/comments?apiKey={2}&{3}", Spacename, issueIdOrKey, ApiKey, query.GetParametersForAPI());
            return GetT<IEnumerable<Comment>>(uri);
        }

        /// <summary>
        /// Returns list of comments in issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-comments"/>
        public IEnumerable<Comment> GetCommentList(string issueIdOrKey)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues/{1}/comments?apiKey={2}", Spacename, issueIdOrKey, ApiKey);
            return GetT<IEnumerable<Comment>>(uri);
        }
    }
}
