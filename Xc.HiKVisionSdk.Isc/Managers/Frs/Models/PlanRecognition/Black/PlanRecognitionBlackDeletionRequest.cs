namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 请求
    /// </summary>
    public class PlanRecognitionBlackDeletionRequest
    {
        /// <summary>
        /// 操作的计划的唯一标识集合，操作可能是删除等，可从查询重点人员识别计划获取
        /// </summary>
        public string[] IndexCodes { get; set; }
    }

}
