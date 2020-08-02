namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 批量添加人员请求详细
    /// </summary>
    public class PersonBatchAddRequestItem : PersonRequestBase
    {
        /// <summary>
        /// 人员临时标志，
        /// 当调用方未指定personId时，clientId作为人员标志，在返回值中标志每个人员的添加结果。
        /// 所以每次接口调用，每个人员的clientid需保持唯一，1~10个字符，只支持数字。
        /// 注：clientid只对本次调用有效
        /// </summary>
        public int ClientId { get; set; }
    }
}
