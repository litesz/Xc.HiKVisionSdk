namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 人脸批量添加请求
    /// </summary>
    public class FaceBatchAdditionRequest
    {
        /// <summary>
        /// 请求内容
        /// </summary>
        public FaceBatchAdditionRequestItem[] Items { get; set; }
    }
}
