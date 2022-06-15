using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Resources.Dtos
{
    /// <summary>
    /// 获取资源属性请求
    /// </summary>
    public class GetPropertiesRequest : BaseRequest
    {
        /// <summary>
        /// 资源类型，当前版本支持,        person: 人员，region：区域，vehicle：车辆，organization：组织
        /// </summary>
        public string ResourceType { get; }

        /// <summary>
        /// 获取资源属性请求
        /// </summary>
        /// <param name="resourceType">资源类型，当前版本支持,        person: 人员，region：区域，vehicle：车辆，organization：组织</param>
        public GetPropertiesRequest(string resourceType)
        {
            if (string.IsNullOrEmpty(resourceType))
            {
                throw new ArgumentNullException(nameof(resourceType));
            }
            ResourceType = resourceType;
        }
    }
}
