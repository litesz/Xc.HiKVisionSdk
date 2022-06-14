namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 批量删除人员结果数据
    /// </summary>
    public class BatchDeletePersonsResponseData
    {
        /// <summary>
        /// 人员标志
        /// </summary>
        public string PersonId { get; set; }
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
