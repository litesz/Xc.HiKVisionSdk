using System;
using Xc.HiKVisionSdk.Dictionaries;
using Xc.HiKVisionSdk.Models.Request;
using Xc.HiKVisionSdk.Utils;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos
{
    /// <summary>
    /// 获取资源的历史在线记录
    /// </summary>
    public class GetOnlineHistoryRequest : PagedRequest
    {
        /// <summary>
        /// 资源编码，从获取资源列表v2接口获取返回报文中的indexCode字段
        /// </summary>
        public string IndexCode { get; }
        /// <summary>
        /// 开始日期，yyyy-MM-dd格式
        /// </summary>
        public string StartDate { get; }
        /// <summary>
        /// 结束日期，yyyy-MM-dd格式
        /// </summary>
        public string EndDate { get; }
        /// <summary>
        /// 资源类型,参考附录A.64 网管资源类型
        /// </summary>
        public string ResourceType { get; }

        /// <summary>
        /// 获取资源的历史在线记录
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <param name="indexCode">资源编码，从获取资源列表v2接口获取返回报文中的indexCode字段</param>
        /// <param name="resourceType">资源类型<see cref="ResourceTypeCollection"/></param>
        /// <param name="start"> 	开始日期，yyyy-MM-dd格式</param>
        /// <param name="end">结束日期，yyyy-MM-dd格式</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public GetOnlineHistoryRequest(int pageNo, int pageSize, string indexCode, string resourceType, DateTime? start = null, DateTime? end = null) : base(pageNo, pageSize)
        {

            if (string.IsNullOrWhiteSpace(indexCode))
            {
                throw new ArgumentNullException(indexCode);
            }
            IndexCode = indexCode;
            ResourceType = ResourceTypeCollection.GetCode(resourceType);
            if (start.HasValue)
            {
                StartDate = DateTimeFormat.ToDate(start.Value);
            }

            if (end.HasValue)
            {
                EndDate = DateTimeFormat.ToDate(end.Value);
            }

            if (start.HasValue && end.HasValue && start.Value > end.Value)
            {
                throw new ArgumentOutOfRangeException(nameof(end), "结束日期不可小于开始日期");
            }

        }

       
    }
}
