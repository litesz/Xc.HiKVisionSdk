using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Models;
using Xc.HiKVisionSdk.Isc.Models.Common;

namespace Xc.HiKVisionSdk.Isc.Managers.Eaas
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHikEaasServiceApiManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<OvertimeSearchResponse> OvertimeSearch(OvertimeSearchRequest model);
    }

    /// <summary>
    /// 
    /// </summary>
    public class HikEaasServiceApiManager : IHikEaasServiceApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEaasServiceApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }


        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<OvertimeSearchResponse> OvertimeSearch(OvertimeSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<OvertimeSearchRequest, OvertimeSearchResponse>("/api/eaas/v2/overtime/batch/records/search", model, Const.V1_3);
        }



    }
    /// <summary>
    /// 
    /// </summary>
    public class OvertimeSearchRequest : IPagedQuery
    {
        /// <summary>
        ///  开始时间,ISO8601时间
        /// </summary>
        [Required]
        public string StartTime { get; set; }
        /// <summary>
        /// 结束时间,ISO8601时间
        /// </summary>
        [Required]
        public string EndTime { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        [Required]
        public int PageSize { get; set; }
        /// <summary>
        /// 页码
        /// </summary>
        [Required]
        public int PageNo { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class OvertimeSearchResponse : HiKVisionPagedDataResponse<OvertimeSearchResponseData>
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public class OvertimeSearchResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    }
}
