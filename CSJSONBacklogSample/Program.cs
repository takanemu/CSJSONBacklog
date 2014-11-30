/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSJSONBacklog.Communicator;
using CSJSONBacklog.Model.Issues;

namespace CSJSONBacklogSample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string spaceName = @"yourSpaceName";// TODO:must change!
            const string apiKey = @"yourApiKey";// TODO:must change!

            var projectCommunicator = new ProjectCommunicator(spaceName, apiKey);
            var projects = projectCommunicator.GetProjectList().ToList();
            foreach (var project in projects)
            {
                Debug.WriteLine(project);
            }

            foreach (var project in projects)
            {
                var issueCommunicator = new IssueCommunicator(spaceName, apiKey);
                var count = issueCommunicator.GetCountIssue(project.Id);

                Debug.WriteLine(project + " " + count);

                var param = new QueryIssueParameters
                {
                    ProjectIds = new List<int> { project.Id },
                    ParentChild = ParentChild.All,
                    Offset = 0,
                    Count = 100,// per 100 max
                    Order = Order.Asc,
                    Sort = Sort.Created
                };
                for (param.Offset = 0; param.Offset < count; param.Offset += 100)
                {
                    var issues = issueCommunicator.GetIssues(param).ToList();
                    foreach (var issue in issues)
                    {
                        Debug.WriteLine(issue);
                    }
                }
            }
        }
    }
}
