using System.Collections.Generic;
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
        /// Returns information about project disk usage.
        /// </summary>
        object GetProjectDiskUsage();
    }
}
