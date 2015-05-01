/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using CSJSONBacklog.API;
using CSJSONBacklog.Model.Space;

namespace CSJSONBacklog.Communicator
{
    public class SpaceCommunicator : AbstractCommunicator, ISpaceAPI
    {
        public SpaceCommunicator(string spacename, string apiKey)
            : base(spacename, apiKey)
        {}

        /// <summary>
        /// Returns list of users in your space.
        /// </summary>
        /// <see cref="http://developer.nulab-inc.com/docs/backlog/api/2/get-users"/>
        public IEnumerable<User> GetUserList()
        {
            return GetT<IEnumerable<User>>(string.Format("https://{0}.backlog.jp/api/v2/users?apiKey={1}", Spacename, ApiKey));
        }
    }
}
