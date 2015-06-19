/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using CSJSONBacklog.Model.Attributes;
using CSJSONBacklog.Model.Projects;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Model.Issues
{
    /// <summary>
    /// Issue
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/add-issue"/>
    public class Issue
    {
        public int id { get; set; }
        public int projectId { get; set; }
        public string issueKey { get; set; }
        public int keyId { get; set; }
        public IssueType issueType { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public Resolution resolution { get; set; }
        public Priority priority { get; set; }
        public Status status { get; set; }
        public User assignee { get; set; }
        public List<Category> category { get; set; }
        public List<Projects.Version> versions { get; set; }
        public List<Projects.Version> milestone { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? dueDate { get; set; }
        public Decimal? estimatedHours { get; set; }
        public Decimal? actualHours { get; set; }
        public int? parentIssueId { get; set; }
        public User createdUser { get; set; }
        public DateTime? created { get; set; }
        public User updatedUser { get; set; }
        public DateTime? updated { get; set; }
        public List<CustomFieldInIssue> customFields { get; set; }
        public List<Attachment> attachments { get; set; }
        public List<SharedFile> sharedFiles { get; set; }
        public List<Star> stars { get; set; }

        public int issueTypeId { get { return issueType == null ? 0 : issueType.id; } }
        public int priorityId { get { return priority == null ? 0 : priority.id; } }
        public int resolutionId { get { return resolution == null ? 0 : resolution.id; } }

        public string comment { get; set; }

        /// <summary>
        /// return properties for Patch
        /// </summary>
        /// <returns></returns>
        [PatchPropertyNamesMethod]
        public static IEnumerable<string> PatchPropertyNames()
        {
            return new List<string>
            {
                "summary",
                "parentIssueId",
                "description",
                "statusId",
                "resolutionId",
                "startDate",
                "dueDate",
                "estimatedHours",
                "actualHours",
                "issueTypeId",
                //"categoryId[]",
                //"versionId[]",
                //"milestoneId[]",
                "priorityId",
                //"assigneeId",
                //"notifiedUserId[]",
                //"attachmentId[]",
                "comment",
            };
        }

        public override string ToString()
        {
            return string.Format("Issue: {0} {1}({2} {3})", issueKey, summary, status, issueType);
        }
    }


    /// <summary>
    /// CountValue - Number of int.
    /// </summary>
    public class CountValue
    {
        public int Count { get; set; }
    }
}
