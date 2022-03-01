namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 批量添加成功的记录
    /// </summary>
    public class OrgBatchAddResponseSuccess
    {
        /// <summary>
        /// 调用方指定人员临时标志
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 服务端生成的唯一标识
        /// </summary>
        public string OrgIndexCode { get; set; }
    }
}
