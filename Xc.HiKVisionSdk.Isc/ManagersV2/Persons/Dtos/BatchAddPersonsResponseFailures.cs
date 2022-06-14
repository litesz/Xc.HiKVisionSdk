namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 失败信息
    /// </summary>
    public class BatchAddPersonsResponseFailures
    {
        /// <summary>
        /// 调用方指定人员临时标志
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }
    }
}
