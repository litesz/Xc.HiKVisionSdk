using System;
using System.Linq;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Orgs.Dtos
{
    /// <summary>
    /// 批量添加人员请求
    /// </summary>
    public class BatchAddOrgsRequest : BaseRequest
    {
        /// <summary>
        /// 批量添加组织信息
        /// </summary>
        public BatchAddOrgsRequestItem[] Items { get;  }

        /// <summary>
        /// 添加添加组织
        /// </summary>
        /// <param name="items">组织信息</param>
        public BatchAddOrgsRequest(params BatchAddOrgsRequestItem[] items)
        {

            if (items == null || items.Length == 0)
            {
                throw new ArgumentNullException(nameof(items));
            }
            if (items.Length > 1000)
            {
                throw new ArgumentOutOfRangeException(nameof(items), "最大1000个");
            }

            var clientId = items.Max(u => u.ClientId);

            foreach (var item in items.Where(u => u.ClientId == 0))
            {
                item.SetClientId(++clientId);
            }

            Items = items;
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
