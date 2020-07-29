using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc
{
    public static class JsonExtensions
    {
        public static T DeserializeObject<T>(string str) where T : class
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public static string Serialize<T>(this T entity) where T : class
        {
            return JsonConvert.SerializeObject(entity);
        }

        public static string SerializeByCamelCase<T>(this T entity) where T : class
        {
            return JsonConvert.SerializeObject(entity, Formatting.Indented, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

        }
    }
}
