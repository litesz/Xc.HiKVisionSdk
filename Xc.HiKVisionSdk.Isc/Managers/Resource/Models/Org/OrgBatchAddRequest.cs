using System.Linq;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 添加添加组织
    /// </summary>
    public class OrgBatchAddRequest
    {
        /// <summary>
        /// 批量添加组织信息
        /// </summary>
        public OrgBatchAddRequestItem[] Items { get; set; }

        /// <summary>
        /// 添加添加组织
        /// </summary>
        /// <param name="items">组织信息</param>
        public OrgBatchAddRequest(params OrgBatchAddRequestItem[] items)
        {
            if (items == null || items.Length == 0)
            {
                throw new System.NullReferenceException(nameof(items));
            }
            int clientId = 1;
            foreach (var item in items.Where(u => u.ClientId == 0))
            {
                item.ClientId = clientId++;
            }

            Items = items;
        }

    }
}
