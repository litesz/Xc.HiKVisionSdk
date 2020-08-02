using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 获取组织下人员列表v2请求
    /// </summary>
    public class OrgIndexCodePersonListV2Request : PagedQuery
    {
        /// <summary>
        /// 组织唯一标识码， 获取组织列表 接口获取
        /// </summary>
        public string OrgIndexCode { get; set; }
    }
}
