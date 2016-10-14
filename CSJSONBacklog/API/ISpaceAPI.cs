/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.API
{
    public interface ISpaceAPI
    {
        /// <summary>
        /// Returns information about your space.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-space"/>
        Space GetSpace();

        /// <summary>
        /// Returns list of users in your space.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-users"/>
        IEnumerable<User> GetUserList();

        /// <summary>
        /// Returns list of groups in your space.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/v2/groups"/>
        IEnumerable<Group> GetGroupList();

        /// <summary>
        /// Deletes group.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/delete-group"/>
        Group DeleteGroup(int groupId);

        /// <summary>
        /// Deletes user from the space.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/delete-user"/>
        User DeleteUser(int userId);
    }
}
