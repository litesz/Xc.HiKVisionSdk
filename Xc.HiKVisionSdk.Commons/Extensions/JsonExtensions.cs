﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Xc.HiKVisionSdk
{
    /// <summary>
    /// json扩展
    /// </summary>
    public static class JsonExtensions
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T DeserializeObject<T>(string str) where T : class
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string Serialize<T>(this T entity) where T : class
        {
            return JsonConvert.SerializeObject(entity);
        }


        /// <summary>
        /// 基于驼峰序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string SerializeByCamelCase<T>(this T entity) where T : class
        {
            return JsonConvert.SerializeObject(entity, Formatting.Indented, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

        }
    }
}
