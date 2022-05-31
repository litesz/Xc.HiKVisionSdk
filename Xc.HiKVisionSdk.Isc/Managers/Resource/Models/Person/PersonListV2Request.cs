using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{

    /// <summary>
    /// 获取人员列表v2请求
    /// </summary>
    public class PersonListV2Request : PagedRequest
    {
        /// <summary>
        /// 获取人员列表v2请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public PersonListV2Request(int pageNo, int pageSize) : base(pageNo, pageSize) { }
    }

}
