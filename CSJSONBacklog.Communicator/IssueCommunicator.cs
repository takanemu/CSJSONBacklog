/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;
using Newtonsoft.Json;

namespace CSJSONBacklog.Communicator
{
    public class IssueCommunicator : AbstractCommunicator
    {
        public IssueCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}

        public IEnumerable<Issue> GetIssues(int projectId)
        {
            var uri = string.Format("https://{0}.backlog.jp/api/v2/issues?apiKey={1}&projectId[]={2}", Spacename, ApiKey, projectId);

            var json = GetJson(uri);

            var list = JsonConvert.DeserializeObject<List<Issue>>(json);

            return list ?? new List<Issue>();
        }
    }
}
