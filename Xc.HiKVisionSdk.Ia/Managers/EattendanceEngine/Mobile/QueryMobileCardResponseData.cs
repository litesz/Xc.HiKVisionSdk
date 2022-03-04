namespace Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile
{
    /// <summary>
    /// 获取移动考勤有效打卡地点结果数据
    /// </summary>
    public class QueryMobileCardResponseData
    {
        /// <summary>
        /// 规则标识
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 规则名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 打卡范围
        /// </summary>
        public string CardPlaceRange { get; set; }
        /// <summary>
        /// 中心点
        /// </summary>
        public string CenterRange { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }

    }

}
