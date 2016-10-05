using CSJSONBacklog.Model.Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSJSONBacklog.Model.Projects
{
    public class Activitie
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public int Type { get; set; }
        public User CreatedUser { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return string.Format("Activitie: {0}={1}", Project.Name, Created);
        }
    }
}
