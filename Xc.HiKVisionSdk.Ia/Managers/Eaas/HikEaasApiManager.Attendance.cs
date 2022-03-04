

using System.Threading.Tasks;
using Xc.HiKVisionSdk.Ia.Managers.Eaas.Attendance;
using Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine.Mobile;

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas
{
    /// <summary>
    /// 考勤api
    /// </summary>
    public partial class HikEaasApiManager : IHikEaasApiManager
    {
        /// <summary>
        /// 批量查询员工考勤数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AttendanceBatchSearchResponse> AttendanceBatchSearchAsync(AttendanceBatchSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AttendanceBatchSearchRequest, AttendanceBatchSearchResponse>("/api/eaas/v1/attendance/batch/search", model, VersionConsts.V1_0);
        }

        /// <summary>
        /// 考勤结果查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<AttendanceResultListResponse> AttendanceResultListAsync(AttendanceResultListRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<AttendanceResultListRequest, AttendanceResultListResponse>("/api/v1/attendance/result/list", model, VersionConsts.V1_0);
        }
    }
}
