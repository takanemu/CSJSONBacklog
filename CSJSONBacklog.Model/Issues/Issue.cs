/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
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
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string IssueKey { get; set; }
        public int KeyId { get; set; }
        public IssueType IssueType { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Resolution Resolution { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public User Assignee { get; set; }
        public List<Category> Category { get; set; }
        public List<object> Versions { get; set; }
        public List<object> Milestone { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public Decimal? EstimatedHours { get; set; }
        public Decimal? ActualHours { get; set; }
        public int? ParentIssueId { get; set; }
        public User CreatedUser { get; set; }
        public string Created { get; set; }
        public User UpdatedUser { get; set; }
        public string Updated { get; set; }
        public List<CustomField> CustomFields { get; set; }
        public List<Attachment> Attachments { get; set; }
        public List<SharedFile> SharedFiles { get; set; }
        public List<Star> Stars { get; set; }

        public override string ToString()
        {
            return string.Format("Issue: {0} {1}({2})", IssueKey, Summary, Status);
        }
    }

    public class IssueType
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int DisplayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("IssueType: {0}({1})", Name, Id);
        }
    }

    public class Resolution
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Resolution: {0}", Name);
        }
    }

    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Priority: {0}", Name);
        }
    }

    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Status: {0}", Name);
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("Category: {0}", Name);
        }
    }

    public class Milestone
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ReleaseDueDate { get; set; }
        public bool Archived { get; set; }
        public int DisplayOrder { get; set; }

        public override string ToString()
        {
            return string.Format("Milestone: {0}", Name);
        }
    }

    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }

        public override string ToString()
        {
            return string.Format("Attachment: {0}", Name);
        }
    }

    public class SharedFile
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Dir { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public User CreatedUser { get; set; }
        public DateTime? Created { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime? Updated { get; set; }

        public override string ToString()
        {
            return string.Format("SharedFile: {0}", Name);
        }
    }

    public class Star
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public User Presenter { get; set; }
        public DateTime? Created { get; set; }

        public override string ToString()
        {
            return string.Format("Star: {0}(Presenter: {1})", Title, Presenter);
        }
    }



    public class CountValue
    {
        public int Count { get; set; }
    }
}
