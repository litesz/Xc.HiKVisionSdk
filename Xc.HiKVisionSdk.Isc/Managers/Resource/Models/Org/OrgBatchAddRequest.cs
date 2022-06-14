using System;
using System.Linq;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Org
{
    /// <summary>
    /// 添加添加组织
    /// </summary>
    public class OrgBatchAddRequest : BaseRequest
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
            var clientId = items.Max(u => u.ClientId);

            foreach (var item in items.Where(u => u.ClientId == 0))
            {
                item.ClientId = clientId++;
            }

            Items = items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public override void CheckParams()
        {
            if (Items == null || Items.Length == 0)
            {
                throw new ArgumentNullException(nameof(Items));
            }
            if (Items.Length > 1000)
            {
                throw new ArgumentOutOfRangeException("Items", Items.Length, "最大1000个");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Items.SerializeByCamelCase();
        }

    }
}
