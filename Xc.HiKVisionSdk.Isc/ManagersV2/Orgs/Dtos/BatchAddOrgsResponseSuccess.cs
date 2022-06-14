namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 批量添加成功的记录
    /// </summary>
    public class BatchAddOrgsResponseSuccess
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
