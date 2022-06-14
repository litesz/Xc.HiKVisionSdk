namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 批量新增组织结果数据
    /// </summary>
    public class BatchAddOrgsResponseData
    {
        /// <summary>
        /// 批量添加成功的记录
        /// </summary>
        public BatchAddOrgsResponseSuccess[] Successes { get; set; }
        /// <summary>
        /// 批量添加失败的记录
        /// </summary>
        public BatchAddOrgsResponseFailures[] Failures { get; set; }

        /// <summary>
        /// 有失败记录
        /// </summary>
        public bool HasFailed => Failures != null && Failures.Length > 0;
    }
}
