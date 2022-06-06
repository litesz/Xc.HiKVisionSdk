namespace Xc.HiKVisionSdk.Isc.ManagersV2.Cards.Dtos
{
    /// <summary>
    /// 批量开卡结果数据
    /// </summary>
    public class BindingResponseData
    {
        /// <summary>
        /// 卡片ID
        /// </summary>
        public string CardId { get; set; }
        /// <summary>
        /// 人员ID
        /// </summary>
        public string PersonId { get; set; }
        /// <summary>
        /// 人员组织IndexCode
        /// </summary>
        public string OrgIndexCode { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }
    }
}
