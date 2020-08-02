namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 成功信息
    /// </summary>
    public class PersonBatchAddResponseSuccess
    {
        /// <summary>
        /// 调用方指定人员临时标志
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 服务端生成的唯一标识
        /// </summary>
        public string PersonId { get; set; }
    }
}
