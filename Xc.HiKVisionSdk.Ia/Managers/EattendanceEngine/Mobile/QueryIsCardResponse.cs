using Xc.HiKVisionSdk.Models.Responses;

namespace Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile
{
    /// <summary>
    /// 查询是否是指定打卡地点结果
    /// </summary>
    public class QueryIsCardResponse : HiKVisionDataResponse
    {
        /// <summary>
        /// 是否是指定地点
        /// </summary>
        public bool IsOk => !string.IsNullOrEmpty(Data);
    }

}
