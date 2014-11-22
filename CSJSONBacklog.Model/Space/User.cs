﻿/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Model.Space
{
    /// <summary>
    /// User
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/add-user"/>
    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public RoleType RoleType { get; set; }
        public string Lang { get; set; }
        public string MailAddress { get; set; }

        public override string ToString()
        {
            return string.Format("User: {0}({1})", Name, UserId);
        }
    }

    /// <summary>
    /// <para>RoleType</para>
    /// <para>Administrator(1) Normal User(2) Reporter(3) Viewer(4) Guest Reporter(5) Guest Viewer(6)</para>
    /// </summary>
    /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/add-user"/>
    public enum RoleType
    {
        None = 0,
        Administrator = 1,
        NormalUser = 2,
        Reporter = 3,
        Viewer = 4,
        GuestReporter = 5,
        GuestViewer = 6,
    }
}
