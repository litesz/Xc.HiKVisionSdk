using System.ComponentModel;
using Xc.HiKVisionSdk.Isc.Models.Common;

namespace Xc.HiKVisionSdk.Isc.Models
{

    /// <summary>
    /// 基础返回值,仅包含code和msg
    /// </summary>
    public class HiKVisionResponse : IResponseModel
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess => Code == "0";
        /// <summary>
        /// 状态码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
    }




}
