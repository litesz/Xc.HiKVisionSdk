using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{
    /// <summary>
    /// 获取组织下人员列表v2请求
    /// </summary>
    public class OrgIndexCodePersonListV2Request : PagedRequest
    {
        /// <summary>
        /// 组织唯一标识码， 获取组织列表 接口获取
        /// </summary>
        public string OrgIndexCode { get; set; }

        /// <summary>
        /// 获取组织下人员列表v2请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="orgIndexCode">组织唯一标识码</param>
        public OrgIndexCodePersonListV2Request(int pageNo, int pageSize, string orgIndexCode) : base(pageNo, pageSize)
        {
            OrgIndexCode = orgIndexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrEmpty(OrgIndexCode))
            {
                throw new System.ArgumentNullException(nameof(OrgIndexCode));
            }

            base.CheckParams();
        }

    }
}
