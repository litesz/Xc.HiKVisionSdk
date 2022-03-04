using System.Threading.Tasks;
using Xc.HiKVisionSdk.Ia.Managers.Eaas.Attendance;
using Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile;

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas
{
    /// <summary>
    /// 考勤
    /// </summary>
    public partial interface IHikEaasApiManager
    {

        /// <summary>
        /// 批量查询员工考勤数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>批量查询员工考勤数据</remarks>
        Task<AttendanceBatchSearchResponse> AttendanceBatchSearchAsync(AttendanceBatchSearchRequest model);

        /// <summary>
        /// 考勤结果查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <remarks>考勤结果查询接口</remarks>
        Task<AttendanceResultListResponse> AttendanceResultListAsync(AttendanceResultListRequest model);
    }
}
