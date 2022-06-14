namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 批量删除组织结果数据
    /// </summary>
    public class BatchDeleteOrgsResponseData
    {
        /// <summary>
        /// 组织标志
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Msg { get; set; }
    }
}
