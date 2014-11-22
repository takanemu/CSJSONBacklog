/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Projects;
using Newtonsoft.Json;

namespace CSJSONBacklog.Communicator
{
    public class ProjectCommunicator : AbstractCommunicator
    {
        public ProjectCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}

        public IEnumerable<Project> GetProjects()
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/projects?apiKey={1}", Spacename, ApiKey);

            var json = GetJson(uri);

            var list = JsonConvert.DeserializeObject<List<Project>>(json);

            return list;
        }
    }
}
