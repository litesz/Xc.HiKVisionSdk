using System.ComponentModel;

namespace Xc.HiKVisionSdk.Models.Responses
{

    /// <summary>
    /// 基础返回值,仅包含code和msg
    /// </summary>
    public abstract class HiKVisionResponse : IResponseModel
    {
        private string msg;

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
        public string Msg
        {
            get => msg; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                msg = value;
            }
        }

        /// <summary>
        /// 异常时间戳
        /// </summary>
        public long Timestamp { get; set; }
        /// <summary>
        /// 异常状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 异常错误
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// 异常消息
        /// </summary>
        public string Message
        {
            get => msg; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                msg = value;
            }
        }
        /// <summary>
        /// 异常请求路径
        /// </summary>
        public string Path { get; set; }
    }




}
