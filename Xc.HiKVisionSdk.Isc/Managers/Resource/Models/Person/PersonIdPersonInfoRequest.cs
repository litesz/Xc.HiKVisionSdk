namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 根据人员编号获取单个人员信息请求
    /// </summary>
    public class PersonIdPersonInfoRequest
    {
        /// <summary>
        /// 人员ID, 获取人员列表v2 接口获取
        /// </summary>
        public string PersonId { get; set; }
    }

}
