namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    public class PersonBatchAddResponseFailures
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
