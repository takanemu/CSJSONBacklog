/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;

namespace CSJSONBacklog.Model.Issues
{
    public class QueryIssueParameters
    {
        public int ProjectId { get; set; }
        public IssueType IssueType { get; set; }
        public Category CategoryId { get; set; }
        public int VersionId { get; set; }
        public int MilestoneId { get; set; }
        public int StatusId { get; set; }
        public int PriorityId { get; set; }
        public int AssignerId { get; set; }
        public int CreatedUserId { get; set; }
        public int ResolutionId { get; set; }
        public ParentChild ParentChild { get; set; }
        public bool Attachment { get; set; }
        public bool SharedFile { get; set; }
        public Sort Sort { get; set; }
        public Order Order { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public Decimal? CreatedSince { get; set; }
        public Decimal? CreatedUntil { get; set; }
        public Decimal? UpdatedSince { get; set; }
        public Decimal? UpdatedUntil { get; set; }
        public Decimal? StartDateSince { get; set; }
        public Decimal? StartDateUntil { get; set; }
        public Decimal? DueDateSince { get; set; }
        public Decimal? DueDateUntil { get; set; }
        public List<int> Id { get; set; }
        public List<int> ParentIssueId { get; set; }
        public String Keyword { get; set; }
    }

    public enum ParentChild
    {
        All = 0,
        ExcludeChildIssue = 1,
        ChildIssue = 2,
        NeitherParentIssueNorChildIssue = 3,
        ParentIssue = 4,
    }

    public enum Sort
    {
        None = 0,
        IssueType = 1,
        Category = 2,
        Version = 3,
        Milestone = 4,
        Summary = 5,
        Status = 6,
        Priority = 7,
        Attachment = 8,
        SharedFile = 9,
        Created = 10,
        CreatedUser = 11,
        Updated = 12,
        UpdatedUser = 13,
        Assignee = 14,
        StartDate = 15,
        DueDate = 16,
        EstimatedHours = 17,
        ActualHours = 18,
        ChildIssue = 19,
        //customField_${id} //TODO:Sort customField_${id}
    }

    public enum Order
    {
        Desc = 0,
        Asc = 1,
    }
}

