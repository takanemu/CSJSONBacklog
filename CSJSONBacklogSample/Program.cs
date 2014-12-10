﻿/* See the file "LICENSE" for the full license governing this code. */

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

            // 1.get information
            SampleOfGetInfo(spaceName, apiKey);

            // 2.update information
            //SampleOfUpdateIssue(spaceName, apiKey, "PROJ1");
        }



        private static void SampleOfGetInfo(string spaceName, string apiKey)
        {
            var getInfoSample = new GetInfoSample(spaceName, apiKey);

            var projects = getInfoSample.GetProjects().ToList();
            getInfoSample.PrintProjectDetails(projects);

            foreach (var project in projects.Where(x => x.ProjectKey.Equals("SND")))
            {
                var issues = getInfoSample.GetIssues(project);
                getInfoSample.PrintIssues(issues);
            }
        }


        #region UPDATE

        private static void SampleOfUpdateIssue(string spaceName, string apiKey, string projectKey)
        {
            var projectCommunicator = new ProjectCommunicator(spaceName, apiKey);
            var projects = projectCommunicator.GetProjectList().ToList();
            var proj = projects.FirstOrDefault(x => x.ProjectKey.Equals(projectKey));

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
        }

        #endregion

    }
}