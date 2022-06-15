using System.Collections.Generic;
using System;

namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 网管资源类型
    /// </summary>
    public static class ResourceTypeCollection
    {
        private static Dictionary<string, NameCode> _collection = new Dictionary<string, NameCode>();

        static ResourceTypeCollection()
        {
            _collection.Add("encodeDevice".ToLower(), new NameCode("encodeDevice", "编码设备"));
            _collection.Add("camera".ToLower(), new NameCode("camera", "监控点"));
            _collection.Add("storageDevice".ToLower(), new NameCode("storageDevice", "存储设备"));
            _collection.Add("decodeDevice".ToLower(), new NameCode("decodeDevice", "解码设备"));
            _collection.Add("acsDevice".ToLower(), new NameCode("acsDevice", "门禁设备"));
            _collection.Add("door".ToLower(), new NameCode("door", "门禁点"));
            _collection.Add("reader".ToLower(), new NameCode("reader", "读卡器"));
            _collection.Add("ladderController".ToLower(), new NameCode("ladderController", "梯控主机"));
            _collection.Add("ladderCardReader".ToLower(), new NameCode("ladderCardReader", "梯控读卡器"));
            _collection.Add("visDevice".ToLower(), new NameCode("visDevice", "可视对讲设备"));
        }

        public static string GetCode(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException("resourceType");
            }
            key = key.Trim().ToLower();

            if (_collection.ContainsKey(key))
            {
                return _collection[key].Code;
            }
            throw new ArgumentOutOfRangeException("resourceType", $"{key} 不是有效的值");
        }


    }


    public class NameCode
    {
        public NameCode(string code, string name)
        {
            Code = code;
            Text = name;
        }

        public string Code { get; set; }
        public string Text { get; set; }
    }
}
