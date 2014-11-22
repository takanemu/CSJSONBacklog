﻿/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model;
using CSJSONBacklog.Model.Issues;

namespace CSJSONBacklog.API
{
    public interface IIssueMethods
    {
        IEnumerable<Issue> GetIssues();
    }
}
