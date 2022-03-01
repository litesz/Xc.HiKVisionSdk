namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 修改组织
    /// </summary>
    public class OrgSingleUpdateRequest
    {
        /// <summary>
        /// 组织标识，必须保证已存在，        从获取组织列表 接口获取返回参数orgIndexCode。
        /// </summary>
        public string OrgIndexCode { get; set; }

        /// <summary>
        /// 组织名称，1~32个字符；不能包含 ’ / \ : * ? " 
        /// </summary>
        public string OrgName { get; set; }
    }
}
