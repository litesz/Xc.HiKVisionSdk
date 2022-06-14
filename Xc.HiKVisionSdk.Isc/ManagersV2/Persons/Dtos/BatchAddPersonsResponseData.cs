namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 批量添加人员结果数据
    /// </summary>
    public class BatchAddPersonsResponseData
    {
        /// <summary>
        /// 批量添加成功的记录
        /// </summary>
        public BatchAddPersonsResponseSuccess[] Successes { get; set; }
        /// <summary>
        /// 批量添加失败的记录
        /// </summary>
        public BatchAddPersonsResponseFailures[] Failures { get; set; }
    }
}
