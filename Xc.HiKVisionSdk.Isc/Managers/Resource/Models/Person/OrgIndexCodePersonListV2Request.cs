using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    public class OrgIndexCodePersonListV2Request : PagedQuery
    {
        /// <summary>
        /// 组织唯一标识码， 获取组织列表 接口获取
        /// </summary>
        public string OrgIndexCode { get; set; }
    }
}
