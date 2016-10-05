﻿﻿/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;
using CSJSONBacklog.Model.Space;

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
        /// Returns information about issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issue"/>
        Issue GetIssue(string issueIdOrKey);

        /// <summary>
        /// Returns list of issues.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issues"/>
        IEnumerable<Issue> GetIssues(IssueQuery param);

        /// <summary>
        /// Updates information about issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/update-issue"/>
        Issue UpdateIssue(Issue issue);

        /// <summary>
        /// Returns list of comments in issue.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-comments"/>
        IEnumerable<Comment> GetCommentList(string issueIdOrKey, CommentQuery query);

        /// <summary>
        /// Download issue attachment file.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issue-attachment"/>
        void DownloadAttachmentFile(string path, string issueKey, string filename, int issueIdOrKey, int attachmentId);

        /// <summary>
        /// Returns list of statuses.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-status"/>
        IEnumerable<Status> GetStatusList();

        /// <summary>
        /// Returns list of resolutions.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-resolutions"/>
        IEnumerable<Resolution> GetResolutionList();

        /// <summary>
        /// Returns list of priorities.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-priorities"/>
        IEnumerable<Resolution> GetPriorityList();
    }
}
