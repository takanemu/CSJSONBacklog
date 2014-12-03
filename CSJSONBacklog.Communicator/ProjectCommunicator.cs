/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Projects;
using CSJSONBacklog.API;
using Newtonsoft.Json;

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
            var uri = string.Format("https://{0}.backlog.jp/api/v2/projects?apiKey={1}", Spacename, ApiKey);

            var json = GetJson(uri);

            var list = JsonConvert.DeserializeObject<List<Project>>(json);

            return list;
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
            var uri = string.Format("https://{0}.backlog.jp/api/v2/projects/{1}/customFields?apiKey={2}", Spacename, projectIdOrKey, ApiKey);

            var json = GetJson(uri);

            var list = JsonConvert.DeserializeObject<List<CustomField>>(json);

            return list;
        }

        public object GetProjectDiskUsage()
        {
            throw new System.NotImplementedException();
        }
    }
}
