﻿/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;

namespace CSJSONBacklog.API
{
    public interface IIssueMethods
    {
        int GetCountIssue(int projectId);
        IEnumerable<Issue> GetIssues(QueryIssueParameters param);
    }
}
