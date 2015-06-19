/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Model.Issues
{
    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public List<ChangeLog> changeLog { get; set; }
        public User createdUser { get; set; }
        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public List<Star> stars { get; set; }
        public List<Notification> notifications { get; set; }
    }

    public class ChangeLog
    {
        public string field { get; set; }
        public string newValue { get; set; }
        public string originalValue { get; set; }
        // TODO:attachmentInfo
        public object attachmentInfo { get; set; }
        // TODO:attributeInfo
        public object attributeInfo { get; set; }
        // TODO:notificationInfo
        public object notificationInfo { get; set; }
    }
}
