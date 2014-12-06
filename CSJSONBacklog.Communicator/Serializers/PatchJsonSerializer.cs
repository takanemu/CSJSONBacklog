/* See the file "LICENSE" for the full license governing this code. */

using CSJSONBacklog.Communicator.ContractResolvers;
using Newtonsoft.Json;
using RestSharp.Serializers;

namespace CSJSONBacklog.Communicator.Serializers
{
    public class PatchJsonSerializer : ISerializer
    {
        public string Serialize(object obj)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings { ContractResolver = new PatchContractResolver() });
            return json;
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType { get; set; }
    }

}
