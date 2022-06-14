using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Persons.Dtos
{
    /// <summary>
    /// 获取人员列表v2
    /// </summary>
    public class GetPersonListV2Request : PagedRequest
    {
        /// <summary>
        /// 获取人员列表v2
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public GetPersonListV2Request(int pageNo, int pageSize) : base(pageNo, pageSize) { }
    }
}
