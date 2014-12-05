/* See the file "LICENSE" for the full license governing this code. */

using System;

namespace CSJSONBacklog.Model.Space
{
    /// <summary>
    /// Git Repository
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-git-repositories"/>
    public class GitRepository
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object HookUrl { get; set; }
        public string HttpUrl { get; set; }
        public string SshUrl { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime PushedAt { get; set; }
        public User createdUser { get; set; }
        public DateTime Created { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime Updated { get; set; }
    }
}
