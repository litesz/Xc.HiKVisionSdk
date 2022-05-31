using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Camera
{
    /// <summary>
    /// 根据区域编号获取下级监控点列表
    /// </summary>
    public class RegionIndexCodeCamerasRequest : PagedRequest
    {
        /// <summary>
        /// 区域编号唯一标识
        /// </summary>
        public string RegionIndexCode { get; set; }

        /// <summary>
        /// 根据区域编号获取下级监控点列表
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="regionIndexCode">区域编号唯一标识</param>
        public RegionIndexCodeCamerasRequest(int pageNo, int pageSize, string regionIndexCode) : base(pageNo, pageSize)
        {
            RegionIndexCode = regionIndexCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public override void CheckParams()
        {
            if (string.IsNullOrWhiteSpace(RegionIndexCode))
            {
                throw new ArgumentNullException(nameof(RegionIndexCode));
            }

            base.CheckParams();
        }

    }
}
