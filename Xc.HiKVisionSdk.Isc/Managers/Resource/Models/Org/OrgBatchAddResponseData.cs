namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 批量新增组织结果数据
    /// </summary>
    public class OrgBatchAddResponseData
    {
        /// <summary>
        /// 批量添加成功的记录
        /// </summary>
        public OrgBatchAddResponseSuccess[] Successes { get; set; }
        /// <summary>
        /// 批量添加失败的记录
        /// </summary>
        public OrgBatchAddResponseFailures[] Failures { get; set; }
    }
}
