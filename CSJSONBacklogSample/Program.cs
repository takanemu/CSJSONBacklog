/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSJSONBacklog.Communicator;
using CSJSONBacklog.Model.Issues;
using CSJSONBacklog.Model.Projects;

namespace CSJSONBacklogSample
{
    /// <summary>
    /// Sample Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        static void Main(string[] args)
        {
            string spaceName = Properties.Settings.Default.SpaceName;// must change!
            string apiKey = Properties.Settings.Default.APIKey;// must change!

#if true
            // Dump all project in space
            var projects = DumpProjects(spaceName, apiKey).ToList();

            // Dump issues in a project
            var issueCommunicator = new IssueCommunicator(spaceName, apiKey);
            foreach (var project in projects)
            {
                DumpIssues(issueCommunicator, project);
            }
#else
            var projectCommunicator = new ProjectCommunicator(spaceName, apiKey);
            var projects = projectCommunicator.GetProjectList().ToList();
            var proj = projects.FirstOrDefault(x => x.ProjectKey.Equals("SND"));

            var issueCommunicator = new IssueCommunicator(spaceName, apiKey);
            var count = issueCommunicator.GetIssuesCount(proj.Id);

            Debug.WriteLine("\t" + proj + " " + count);

            // issues in a project
            var param = new QueryIssueParameters
            {
                ProjectIds = new List<int> { proj.Id },
                ParentChild = ParentChild.All,
                Offset = 0,
                Count = 100,// per 100 max
                Order = Order.Asc,
                Sort = Sort.Created
            };
            var issue = issueCommunicator.GetIssues(param).FirstOrDefault();

            issue.description += " Update by api @" + DateTime.Now;
            issueCommunicator.UpdateIssue(issue);
#endif
        }

        /// <summary>
        /// Print all project info in space
        /// </summary>
        private static IEnumerable<Project> DumpProjects(string spaceName, string apiKey)
        {
            // project list
            var projectCommunicator = new ProjectCommunicator(spaceName, apiKey);
            var projects = projectCommunicator.GetProjectList().ToList();
            foreach (var project in projects)
            {
                Debug.WriteLine(project);

                // disk usage
                var usage = projectCommunicator.GetProjectDiskUsage(project.ProjectKey);
                Debug.WriteLine("\t" + usage);

                // project user
                var users = projectCommunicator.GetProjectUserList(project.ProjectKey);
                foreach (var user in users)
                {
                    Debug.WriteLine("\t" + user);
                }

                var admins = projectCommunicator.GetProjectAdministratorList(project.ProjectKey);
                foreach (var user in admins)
                {
                    Debug.WriteLine("\t" + user);
                }

                // issue types
                var issueTypes = projectCommunicator.GetIssueTypeList(project.ProjectKey);
                foreach (var issueType in issueTypes)
                {
                    Debug.WriteLine("\t" + issueType);
                }

                // custom fields
                var customFieldList = projectCommunicator.GetCustomFieldList(project.ProjectKey);
                foreach (var customField in customFieldList)
                {
                    Debug.WriteLine("\t" + customField);
                }

#if false // TODO:{"errors":[{"message":"Authentication failure.","code":11,"moreInfo":""}]}
                // git repositories
                var repos = projectCommunicator.GetListofGitRepositories(project.ProjectKey);
                foreach (var gitRepository in repos)
                {
                    Debug.WriteLine("\t" + gitRepository);
                }
#endif
            }

            return projects;
        }

        private static void DumpIssues(IssueCommunicator issueCommunicator, Project project)
        {
            var count = issueCommunicator.GetIssuesCount(project.Id);

            Debug.WriteLine("\t" + project + " " + count);

            // issues in a project
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
                    Debug.WriteLine("\t" + issue);
                }
            }
        }
    }
}
