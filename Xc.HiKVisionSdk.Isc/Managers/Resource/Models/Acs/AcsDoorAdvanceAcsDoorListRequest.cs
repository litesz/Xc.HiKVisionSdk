using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs
{
    /// <summary>
    /// 查询门禁点列表请求
    /// </summary>
    public class AcsDoorAdvanceAcsDoorListRequest : PagedRequest
    {
        /// <summary>
        /// 门禁点唯一标识符集 
        /// 多个值使用英文逗号分隔， 获取门禁设备列表接口可以获取
        /// </summary>
        public string DoorIndexCodes { get; set; }

        /// <summary>
        /// 门禁点名称
        /// 支持中英文字符，不能包含 ’ / \ : * ? "
        /// 支持模糊搜索，获取门禁设备列表接口可以获取
        /// </summary>
        public string DoorName { get; set; }

        /// <summary>
        /// 门禁设备唯一标识，获取门禁设备列表接口可以获取
        /// </summary>
        public string AcsDevIndexCode { get; set; }

        /// <summary>
        /// 所属区域唯一标识，分页获取区域列表
        /// </summary>
        public string RegionIndexCode { get; set; }

        /// <summary>
        /// 查询门禁点列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="regionIndexCode">所属区域唯一标识</param>
        /// <param name="acsDevIndexCode">门禁设备唯一标识</param>
        /// <param name="doorName">门禁点名称</param>
        public AcsDoorAdvanceAcsDoorListRequest(int pageNo, int pageSize, string regionIndexCode = "", string acsDevIndexCode = "", string doorName = "") : base(pageNo, pageSize)
        {
            RegionIndexCode = regionIndexCode;
            AcsDevIndexCode = acsDevIndexCode;
            DoorName = doorName;
        }

        /// <summary>
        /// 门禁点唯一标识符集
        /// </summary>
        /// <param name="doorIndexCodes">门禁点唯一标识符集</param>
        /// <returns></returns>
        public AcsDoorAdvanceAcsDoorListRequest UseDoorIndexCodes(params string[] doorIndexCodes)
        {
            DoorIndexCodes = string.Join(",", doorIndexCodes);
            return this;
        }
    }
}
