namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 根据组织编号获取组织详细信息
    /// </summary>
    public class OrgInfoRequest
    {
        /// <summary>
        /// 组织编号数组,从获取组织列表接口获取返回参数orgIndexCode，最大1000个
        /// </summary>
        public string[] OrgIndexCodes { get; set; }
    }
}
