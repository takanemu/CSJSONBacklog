/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSJSONBacklog.Model.Issues
{
    public class QueryIssueParameters
    {
        public List<int> ProjectIds = new List<int>();
        public List<IssueType> IssueTypes = new List<IssueType>();
        public List<Category> CategoryIds = new List<Category>();
        public List<int> VersionIds = new List<int>();
        public List<int> MilestoneIds = new List<int>();
        public List<int> StatusIds = new List<int>();
        public List<int> PriorityIds = new List<int>();
        public List<int> AssigneeIds = new List<int>();
        public List<int> CreatedUserIds = new List<int>();
        public List<int> ResolutionIds = new List<int>();
        public ParentChild ParentChild { get; set; }
        public bool Attachment { get; set; }
        public bool SharedFile { get; set; }
        public Sort Sort { get; set; }
        public Order Order { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        public DateTime? CreatedSince { get; set; }
        public DateTime? CreatedUntil { get; set; }
        public DateTime? UpdatedSince { get; set; }
        public DateTime? UpdatedUntil { get; set; }
        public DateTime? StartDateSince { get; set; }
        public DateTime? StartDateUntil { get; set; }
        public DateTime? DueDateSince { get; set; }
        public DateTime? DueDateUntil { get; set; }
        public List<int> Ids = new List<int>();
        public List<int> ParentIssueIds = new List<int>();
        public String Keyword { get; set; }

        public string GetParametersForAPI()
        {
            var parameters = string.Format("{0}&offset={1}&count={2}&order={3}&sort={4}&attachment={5}&sharedFile={6}&parentChild={7}&keyword={8}",
                StringParametersForAPI(@"projectId", ProjectIds),
                Offset,
                Count,
                Order,
                Sort,
                Attachment.ToString().ToLower(),
                SharedFile.ToString().ToLower(),
                (int)ParentChild,
                Keyword);

            parameters += StringParametersForAPI(@"issueTypeId", IssueTypes.Select(x => x.Id));
            parameters += StringParametersForAPI(@"categoryId", CategoryIds.Select(x => x.Id));
            parameters += StringParametersForAPI(@"versionId", VersionIds);
            parameters += StringParametersForAPI(@"milestoneId", MilestoneIds);
            parameters += StringParametersForAPI(@"statusId", StatusIds);
            parameters += StringParametersForAPI(@"priorityId", PriorityIds);
            parameters += StringParametersForAPI(@"assigneeId", PriorityIds);
            parameters += StringParametersForAPI(@"createdUserId", CreatedUserIds);
            parameters += StringParametersForAPI(@"resolutionId", ResolutionIds);

            parameters += StringParametersForAPIDate("createdSince", CreatedSince);
            parameters += StringParametersForAPIDate("createdUntil", CreatedUntil);
            parameters += StringParametersForAPIDate("updatedSince", UpdatedSince);
            parameters += StringParametersForAPIDate("updatedUntil", UpdatedUntil);
            parameters += StringParametersForAPIDate("startDateSince", StartDateSince);
            parameters += StringParametersForAPIDate("startDateUntil", StartDateUntil);
            parameters += StringParametersForAPIDate("dueDateSince", DueDateSince);
            parameters += StringParametersForAPIDate("dueDateUntil", DueDateUntil);
            parameters += StringParametersForAPI(@"id", Ids);
            parameters += StringParametersForAPI(@"parentIssueId", ParentIssueIds);

            return parameters;
        }

        private string StringParametersForAPI(string paramName, IEnumerable<int> paramList)
        {
            var parameters = string.Empty;

            var list = paramList as int[] ?? paramList.ToArray();
            for (var i = 0; i < list.Count(); i++)
            {
                parameters += string.Format("{0}[{1}]={2}&", paramName, i, list[i]);
            }

            return parameters.Count() > 2 ? parameters.Remove(parameters.Length - 1, 1) : string.Empty;
        }

        private string StringParametersForAPIDate(string paramName, DateTime? date)
        {
            return !date.HasValue
                ? string.Empty
                : string.Format("&paramName={0}", date.Value.ToString("yyyy-MM-dd"));
        }
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

