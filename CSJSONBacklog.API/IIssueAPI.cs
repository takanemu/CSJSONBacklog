﻿/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;

namespace CSJSONBacklog.API
{
    public interface IIssueAPI
    {
        /// <summary>
        /// Returns number of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues-count"/>
        int GetIssuesCount(IEnumerable<int> projectIds);

        /// <summary>
        /// Returns list of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues"/>
        IEnumerable<Issue> GetIssues(QueryIssueParameters param);

        /// <summary>
        /// Updates information about issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/update-issue"/>
        Issue UpdateIssue(Issue issue);
    }
}
