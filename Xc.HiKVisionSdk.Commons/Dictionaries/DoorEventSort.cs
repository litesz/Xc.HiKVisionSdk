namespace Xc.HiKVisionSdk.Dictionaries
{
    /// <summary>
    /// 
    /// </summary>
    public static class DoorEventSort
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public const string PersonName = "personName";
        /// <summary>
        /// 设备名
        /// </summary>
        public const string DoorName = "doorName";
        /// <summary>
        /// 事件时间
        /// </summary>
        public const string EventTime = "eventTime";


        private static readonly DictionariesCodeTextCollection _items = new DictionariesCodeTextCollection();

        static DoorEventSort()
        {
            _items.Add(PersonName, "姓名");
            _items.Add(DoorName, "设备名");
            _items.Add(EventTime, "事件时间", true);
        }

        public static string GetCode(string key)
        {
            return _items.GetOrDefault(key).Code;
        }


    }
}
