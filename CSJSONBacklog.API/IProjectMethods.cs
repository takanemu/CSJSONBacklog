/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Issues;
using CSJSONBacklog.Model.Projects;

namespace CSJSONBacklog.API
{
    public interface IProjectMethods
    {
        object GetListofRecentlyViewedProjects();

        /// <summary>
        /// Returns list of projects.
        /// </summary>
        IEnumerable<Project> GetProjectList();

        void AddProject();
        void GetProject();
        void UpdateProject();
        void DeleteProject();
        byte[] GetProjectIcon();
        object GetProjectRecentUpdate();
        void AddProjectUser();
        object GetProjectUserList();
        void DeleteProjectUser();
        void AddProjectAdministrator();
        object GetProjectAdministratorList();
        void DeleteProjectAdministrator();

        /// <summary>
        /// Returns list of Custom Fields in the project.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-customfields"/>
        IEnumerable<CustomField> GetCustomFieldList(string projectIdOrKey);

        /// <summary>
        /// Returns list of Issue Types in the project.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-issuetypes"/>
        IEnumerable<IssueType> GetIssueTypeList(string projectIdOrKey);

        /// <summary>
        /// Returns information about project disk usage.
        /// </summary>
        object GetProjectDiskUsage();
    }
}
