using System.Collections.Generic;
using System;

namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 网管资源类型
    /// </summary>
    public static class ResourceType
    {
        /// <summary>
        /// 编码设备
        /// </summary>
        public const string EncodeDevice = "encodeDevice";
        /// <summary>
        /// 监控点
        /// </summary>
        public const string Camera = "camera";
        /// <summary>
        /// 存储设备
        /// </summary>
        public const string StorageDevice = "storageDevice";
        /// <summary>
        /// 解码设备
        /// </summary>
        public const string DecodeDevice = "decodeDevice";
        /// <summary>
        /// 门禁设备
        /// </summary>
        public const string AcsDevice = "acsDevice";
        /// <summary>
        /// 门禁点
        /// </summary>
        public const string Door = "door";
        /// <summary>
        /// 读卡器
        /// </summary>
        public const string Reader = "reader";
        /// <summary>
        /// 梯控主机
        /// </summary>
        public const string LadderController = "ladderController";
        /// <summary>
        /// 梯控读卡器
        /// </summary>
        public const string LadderCardReader = "ladderCardReader";
        /// <summary>
        /// 可视对讲设备
        /// </summary>
        public const string VisDevice = "visDevice";

        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<string, DictionariesCodeTextItem> _collection = new Dictionary<string, DictionariesCodeTextItem>();

        static ResourceType()
        {
            _collection.Add(EncodeDevice.ToLower(), new DictionariesCodeTextItem(EncodeDevice, "编码设备"));
            _collection.Add(Camera.ToLower(), new DictionariesCodeTextItem(Camera, "监控点"));
            _collection.Add(StorageDevice.ToLower(), new DictionariesCodeTextItem(StorageDevice, "存储设备"));
            _collection.Add(DecodeDevice.ToLower(), new DictionariesCodeTextItem(DecodeDevice, "解码设备"));
            _collection.Add(AcsDevice.ToLower(), new DictionariesCodeTextItem(AcsDevice, "门禁设备"));
            _collection.Add(Door.ToLower(), new DictionariesCodeTextItem(Door, "门禁点"));
            _collection.Add(Reader.ToLower(), new DictionariesCodeTextItem(Reader, "读卡器"));
            _collection.Add(LadderController.ToLower(), new DictionariesCodeTextItem(LadderController, "梯控主机"));
            _collection.Add(LadderCardReader.ToLower(), new DictionariesCodeTextItem(LadderCardReader, "梯控读卡器"));
            _collection.Add(VisDevice.ToLower(), new DictionariesCodeTextItem(VisDevice, "可视对讲设备"));
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
}
