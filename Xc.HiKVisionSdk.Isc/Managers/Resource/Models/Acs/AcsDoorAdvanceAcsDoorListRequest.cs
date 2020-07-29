using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Acs
{
    public class AcsDoorAdvanceAcsDoorListRequest : PagedQuery
    {
        /// <summary>
        /// 门禁点唯一标识符集 
        /// 多个值使用英文逗号分隔， 获取门禁设备列表接口可以获取
        /// </summary>
        public string DoorIndexCodes { get; set; }

        /// <summary>
        /// 门禁点名称
        /// 支持中英文字符，不能包含 ’ / \ : * ? " < >
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


    }
}
