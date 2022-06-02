using Xc.HiKVisionSdk.Isc.Enums.Resource;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 查询监控点列表请求
    /// </summary>
    public class AdvanceCameraListRequest : PagedRequest
    {
        /// <summary>
        /// 监控点唯一标识集
        /// 多个值使用英文逗号分隔，
        /// 可通过分页获取监控点资源获取
        /// </summary>
        public string[] CameraIndexCodes { get; set; }

        /// <summary>
        /// 监控点名称（最大长度32）支持中英文字符，不能包含 ’ / \ : * ? " ，支持模糊搜索
        /// </summary>
        public string CameraName { get; set; }

        /// <summary>
        /// 所属编码设备唯一标识 （最大长度64）
        /// 若指定编码设备的值，则只查询本级监控点；
        /// 可通过获取编码设备列表接口获取
        /// </summary>
        public string EncodeDevIndexCode { get; set; }

        /// <summary>
        /// 区域唯一标识；
        /// 可通过区域信息接口获取
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 0：非级联
        /// 1：级联
        /// 2：不限（包括级联和非级联）
        /// 默认取值：2
        /// </summary>
        public CascadeType IsCascade { get; set; } = CascadeType.All;

        /// <summary>
        /// 查询监控点列表请求
        /// </summary>
        public AdvanceCameraListRequest() { }

        /// <summary>
        /// 查询监控点列表请求
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        public AdvanceCameraListRequest(int pageNo, int pageSize) : base(pageNo, pageSize) { }
    }
}
