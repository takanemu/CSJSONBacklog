/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.API
{
    public interface ISpaceAPI
    {
        IEnumerable<User> GetUserList();
    }
}
