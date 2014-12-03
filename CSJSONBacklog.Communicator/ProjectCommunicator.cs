/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;
using CSJSONBacklog.Model.Projects;
using CSJSONBacklog.API;

namespace CSJSONBacklog.Communicator
{
    public class ProjectCommunicator : AbstractCommunicator, IProjectMethods
    {
        public ProjectCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}

        public object GetListofRecentlyViewedProjects()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Project> GetProjectList()
        {
            return GetT<IEnumerable<Project>>(string.Format("https://{0}.backlog.jp/api/v2/projects?apiKey={1}", Spacename, ApiKey));
        }

        public void AddProject()
        {
            throw new System.NotImplementedException();
        }

        public void GetProject()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProject()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProject()
        {
            throw new System.NotImplementedException();
        }

        public byte[] GetProjectIcon()
        {
            throw new System.NotImplementedException();
        }

        public object GetProjectRecentUpdate()
        {
            throw new System.NotImplementedException();
        }

        public void AddProjectUser()
        {
            throw new System.NotImplementedException();
        }

        public object GetProjectUserList()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProjectUser()
        {
            throw new System.NotImplementedException();
        }

        public void AddProjectAdministrator()
        {
            throw new System.NotImplementedException();
        }

        public object GetProjectAdministratorList()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProjectAdministrator()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns list of Custom Fields in the project.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-customfields"/>
        public IEnumerable<CustomField> GetCustomFieldList(string projectIdOrKey)
        {
            return GetT<IEnumerable<CustomField>>(string.Format("https://{0}.backlog.jp/api/v2/projects/{1}/customFields?apiKey={2}", Spacename, projectIdOrKey, ApiKey));
        }

        /// <summary>
        /// Returns list of Issue Types in the project.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issuetypes"/>
        public IEnumerable<IssueType> GetIssueTypeList(string projectIdOrKey)
        {
            return GetT<IEnumerable<IssueType>>(string.Format("https://{0}.backlog.jp/api/v2/projects/{1}/issueTypes?apiKey={2}", Spacename, projectIdOrKey, ApiKey));
        }

        public object GetProjectDiskUsage()
        {
            throw new System.NotImplementedException();
        }
    }
}
