using System;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Mpc.Models
{
    /// <summary>
    /// 批量添加车辆黑名单请求
    /// </summary>
    public class AlarmBlackAddRequest : BaseRequest
    {
        /// <summary>
        /// 批量添加车辆黑名单详细
        /// </summary>
        public AlarmBlackAddRequestData[] Items { get; set; }


        /// <summary>
        /// 批量添加车辆黑名单请求
        /// </summary>
        /// <param name="items">批量添加车辆黑名单详细</param>
        public AlarmBlackAddRequest(params AlarmBlackAddRequestData[] items)
        {
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

            if (Items.Length > 400)
            {
                throw new ArgumentOutOfRangeException(nameof(Items), Items.Length, "一次添加最大不超过400个");
            }

            foreach (var item in Items)
            {
                item.Check();
            }

        }

    }
}
