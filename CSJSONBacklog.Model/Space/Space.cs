﻿/* See the file "LICENSE" for the full license governing this code. */

using System;

namespace CSJSONBacklog.Model.Space
{
    public class Space
    {
        public string SpaceKey { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string Lang { get; set; }
        public string Timezone { get; set; }
        public DateTime? ReportSendTime { get; set; }
        public string TextFormattingRule { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
