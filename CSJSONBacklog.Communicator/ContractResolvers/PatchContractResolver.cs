/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.Collections.Generic;
using System.Linq;
using CSJSONBacklog.Model.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp.Extensions;

namespace CSJSONBacklog.Communicator.ContractResolvers
{
    public class PatchContractResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            var method = type.GetMethods().FirstOrDefault(x => x.GetAttribute<PatchPropertyNamesMethodAttribute>() != null);
            if (method == null)
            {
                throw new Exception("method is null");
            }
            var names = method.Invoke(null, null) as List<string>;
            if (names == null || !names.Any())
            {
                throw new Exception("PatchPropertyNamesMethod returns null or zero.");
            }

            return type.GetProperties().Where(x => names.Contains(x.Name))
                .Select(propertyInfo => base.CreateProperty(propertyInfo, memberSerialization)).ToList();
        }
    }
}
