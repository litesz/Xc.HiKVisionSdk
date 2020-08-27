namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件查询重点人员事件结果数据
    /// </summary>
    public class EventBlackSearchResponseData
    {
        /// <summary>
        /// 重点人员事件抓拍信息
        /// </summary>
        public SnapInfo SnapInfo { get; set; }
        /// <summary>
        /// 重点人员事件目标图信息集
        /// </summary>
        public TargetInfo[] TargetInfoList { get; set; }
    }

}
