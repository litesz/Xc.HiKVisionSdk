namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 添加添加组织
    /// </summary>
    public class OrgBatchAddRequest
    {
        /// <summary>
        /// 批量添加组织信息
        /// </summary>
        public OrgBatchAddRequestItem[] Items { get; set; }
    }
}
