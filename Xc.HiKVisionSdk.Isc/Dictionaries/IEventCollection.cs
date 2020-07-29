using System.Collections.Generic;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Dictionaries
{
    public interface IEventCollection
    {
        bool IsLoadState { get; set; }
        EventCollectionItem this[int code] { get; }
        Dictionary<int, EventCollectionItem> Items { get; }
        KeyValuePair<string, string>[] GetEventTypes();
        KeyValuePair<string, string>[] GetEventSubclasses(string type);
    }
}
