/* See the file "LICENSE" for the full license governing this code. */

using System.Diagnostics;
using System.Linq;
using CSJSONBacklog.Communicator;

namespace CSJSONBacklogSample
{
    class Program
    {
        static void Main(string[] args)
        {
            const string spaceName = @"yourSpaceName";// TODO:must change!
            const string apiKey = @"yourApiKey";// TODO:must change!

            var projectCommunicator = new ProjectCommunicator(spaceName, apiKey);
            var projects = projectCommunicator.GetProjects().ToList();
            foreach (var project in projects)
            {
                Debug.WriteLine(project);
            }

            foreach (var project in projects)
            {
                Debug.WriteLine(project);

                var issueCommunicator = new IssueCommunicator(spaceName, apiKey);
                var issues = issueCommunicator.GetIssues(project.Id).ToList();
                foreach (var issue in issues)
                {
                    Debug.WriteLine(issue);
                }
            }
        }
    }
}
