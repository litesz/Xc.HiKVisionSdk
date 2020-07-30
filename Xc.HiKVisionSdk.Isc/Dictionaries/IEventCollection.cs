using System.Collections.Generic;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Dictionaries
{
    /// <summary>
    /// 事件类型
    /// </summary>
    public interface IEventCollection : IHikDictionaryCollection<int, EventCollectionItem>
    {
        /// <summary>
        /// 
        /// </summary>
        bool IsLoadState { get; set; }

        /// <summary>
        /// 事件
        /// </summary>
        Dictionary<int, EventCollectionItem> Items { get; }

        /// <summary>
        /// 获得类型
        /// </summary>
        /// <returns></returns>
        KeyValuePair<string, string>[] GetEventTypes();

        /// <summary>
        /// 获得子类
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        KeyValuePair<string, string>[] GetEventSubclasses(string type);
    }
}
