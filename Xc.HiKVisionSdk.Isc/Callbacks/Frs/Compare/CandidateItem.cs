using Newtonsoft.Json;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Compare
{
    /// <summary>
    /// 比对到的目标人脸
    /// </summary>
    public class CandidateItem
    {
        /// <summary>
        /// 比对到的人脸所属人脸分组的唯一标识
        /// 注意和平台的人脸分组的标识不一定相同
        /// </summary>
        [JsonProperty("blacklist_id")]
        public string BlacklistId { get; set; }
        /// <summary>
        /// 人员数据
        /// </summary>
        [JsonProperty("human_data")]
        public HumanDataItem[] HumanData { get; set; }
        /// <summary>
        /// 比对到的人脸所属人脸的唯一标识
        /// </summary>
        [JsonProperty("human_id")]
        public string HumanId { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        [JsonProperty("reserve_field")]
        public ReserveField ReserveField { get; set; }
        /// <summary>
        /// 比对到的人脸和抓拍到的人脸之间的相似度
        /// </summary>
        public double Similarity { get; set; }
    }
}
