/* See the file "LICENSE" for the full license governing this code. */

namespace CSJSONBacklog.Communicator
{
    interface ICommunicator
    {
        string Spacename { get; }
        string ApiKey { get; }
        string GetJson(string uri);
    }
}
