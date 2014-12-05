/* See the file "LICENSE" for the full license governing this code. */

using CSJSONBacklog.API;

namespace CSJSONBacklog.Communicator
{
    public class SpaceCommunicator : AbstractCommunicator, ISpaceAPI
    {
        public SpaceCommunicator(string spacename, string apiKey) : base(spacename, apiKey)
        {
        }
    }
}
