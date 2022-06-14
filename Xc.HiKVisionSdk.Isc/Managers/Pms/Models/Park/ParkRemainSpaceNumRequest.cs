using Xc.HiKVisionSdk.Models.Request;
using System;

namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 查询停车库剩余车位数请求
    /// </summary>
    public class ParkRemainSpaceNumRequest : BaseRequest
    {
        /// <summary>
        /// 停车库唯一标识码（最大长度64）
        /// 为空时获取全部停车库的车位剩余情况，可通过获取停车库列表接口获取
        /// </summary>
        public string ParkSyscode { get; set; }

        /// <summary>
        /// 查询停车库剩余车位数请求
        /// </summary>
        /// <param name="parkSyscode">停车库唯一标识码,为空时获取全部停车库的车位剩余情况</param>
        public ParkRemainSpaceNumRequest(string parkSyscode = null)
        {
            ParkSyscode = parkSyscode;
        }



        /// <summary>
        /// 
        /// </summary>
        public override void CheckParams()
        {
            if (!string.IsNullOrWhiteSpace(ParkSyscode) && ParkSyscode.Length > 64)
            {
                throw new ArgumentOutOfRangeException(nameof(ParkSyscode), ParkSyscode.Length, "最大长度 64 位");
            }
        }
    }
}
