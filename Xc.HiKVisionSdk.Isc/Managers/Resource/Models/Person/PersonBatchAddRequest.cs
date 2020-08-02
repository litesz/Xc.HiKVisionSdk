namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 批量添加人员请求
    /// </summary>
    public class PersonBatchAddRequest
    {
        /// <summary>
        /// 批量添加人员信息
        /// </summary>
        public PersonBatchAddRequestItem[] Items { get; set; }
    }
}
