/* See the file "LICENSE" for the full license governing this code. */

using CSJSONBacklog.Model.Space;
using System;
using System.Collections.Generic;

namespace CSJSONBacklog.Model.Projects
{
    public class Activitie
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public ActivitieType Type { get; set; }
        public Content Content { get; set; }
        public List<Notification> Notifications { get; set; }
        public User CreatedUser { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return string.Format("Activitie: {0}({1}) Id: {2} Type: {3} CreatedUser: {4} Created: {5}", Project.Name, Project.Id, Id, Type, CreatedUser, Created);
        }
    }

    public enum ActivitieType
    {
        IssueCreated = 1,
        IssueUpdated = 2,
        IssueCommented = 3,
        IssueDeleted = 4,
        WikiCreated = 5,
        WikiUpdated = 6,
        WikiDeleted = 7,
        FileAdded = 8,
        FileUpdated = 9,
        FileDeleted = 10,
        SVNCommitted = 11,
        GitPushed = 12,
        GitRepositoryCreated = 13,
        IssueMultiUpdated = 14,
        ProjectUserAdded = 15,
        ProjectUserDeleted = 16,
        CommentNotificationAdded = 17,
        PullRequestAdded = 18,
        PullRequestUpdated = 19,
        CommentAddedOnPullRequest = 20,
    }
}
