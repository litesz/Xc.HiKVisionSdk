namespace Xc.HiKVisionSdk.Isc.Models
{
    /// <summary>
    /// 事件类型项
    /// </summary>
    public class EventCollectionItem
    {
        /// <summary>
        /// 代码
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 子类
        /// </summary>
        public string Subclass { get; set; }
        /// <summary>
        /// 子类名
        /// </summary>
        public string SubclassName { get; set; }
        /// <summary>
        /// 已订阅
        /// </summary>
        public bool IsSub { get; set; }
        /// <summary>
        /// 回调action
        /// </summary>
        public string Action { get; set; }
    }
}
