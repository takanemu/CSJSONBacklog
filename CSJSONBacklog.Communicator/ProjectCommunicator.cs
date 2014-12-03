/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;
using CSJSONBacklog.Model.Projects;
using CSJSONBacklog.API;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Communicator
{
    public class ProjectCommunicator : AbstractCommunicator, IProjectMethods
    {
        public ProjectCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}



        #region Project
        /// <summary>
        /// Returns list of projects.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-projects"/>
        public IEnumerable<Project> GetProjectList()
        {
            return GetT<IEnumerable<Project>>(string.Format("https://{0}.backlog.jp/api/v2/projects?apiKey={1}", Spacename, ApiKey));
        }

        public Project GetProject(string projectIdOrKey) { throw new System.NotImplementedException(); }
        public Project AddProject(string projectIdOrKey) { throw new System.NotImplementedException(); }
        public Project UpdateProject(string projectIdOrKey) { throw new System.NotImplementedException(); }
        public Project DeleteProject(string projectIdOrKey) { throw new System.NotImplementedException(); }
        #endregion Project



        #region Project User
        /// <summary>
        /// Returns list of project members.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-project-users"/>
        public IEnumerable<User> GetProjectUserList(string projectIdOrKey)
        {
            return GetT<IEnumerable<User>>(string.Format("https://{0}.backlog.jp/api/v2/projects/{1}/users?apiKey={2}", Spacename, projectIdOrKey, ApiKey));
        }

        public User AddProjectUser(string projectIdOrKey) { throw new System.NotImplementedException(); }
        public User DeleteProjectUser(string projectIdOrKey) { throw new System.NotImplementedException(); }
        #endregion Project User


        #region Project Administrator
        /// <summary>
        /// Returns list of users who has Project Administrator role
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-project-adminnistrators"/>
        public IEnumerable<User> GetProjectAdministratorList(string projectIdOrKey)
        {
            return GetT<IEnumerable<User>>(string.Format("https://{0}.backlog.jp/api/v2/projects/{1}/administrators?apiKey={2}", Spacename, projectIdOrKey, ApiKey));
        }

        public User GetProjectAdministrator(string projectIdOrKey) { throw new System.NotImplementedException(); }
        public User AddProjectAdministrator(string projectIdOrKey) { throw new System.NotImplementedException(); }
        public User DeleteProjectAdministrator(string projectIdOrKey) { throw new System.NotImplementedException(); }
        #endregion Project Administrator



        #region misc
        /// <summary>
        /// Downloads project icon.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-project-icon"/>
        public byte[] GetProjectIcon()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns recent update in the project.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-project-activities"/>
        public object GetProjectRecentUpdate()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns list of projects which the user viewed recently.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-user-recentlyviewedprojects"/>
        public object GetListofRecentlyViewedProjects()
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

        /// <summary>
        /// Returns information about project disk usage.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-project-diskusage"/>
        public DiskUsage GetProjectDiskUsage(string projectIdOrKey)
        {
            return GetT<DiskUsage>(string.Format("https://{0}.backlog.jp/api/v2/projects/{1}/diskUsage?apiKey={2}", Spacename, projectIdOrKey, ApiKey));
        }
        #endregion misc
    }
}
