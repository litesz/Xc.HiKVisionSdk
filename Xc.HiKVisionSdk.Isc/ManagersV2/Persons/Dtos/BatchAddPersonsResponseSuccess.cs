namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 成功信息
    /// </summary>
    public class BatchAddPersonsResponseSuccess
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
