using System;
using System.Linq;
using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos
{
    /// <summary>
    /// 获取联动事件列表
    /// </summary>
    public class GetEventsListRequest : IOSTimeRangeWithPagedRequest
    {


        /// <summary>
        ///  事件规则id
        /// </summary>
        public string EventRuleId { get; private set; }
        /// <summary>
        ///  事件分类，详见附录A.62
        /// </summary>
        public string Ability { get; private set; }
        /// <summary>
        /// 区域编号
        /// </summary>
        public string RegionIndexCode { get; private set; }
        /// <summary>
        /// 所属位置，详见附录A.81 安装位置
        /// </summary>
        public string[] LocationIndexCodes { get; private set; }
        /// <summary>
        ///  事件源名称
        /// </summary>
        public string ResName { get; private set; }
        /// <summary>
        /// 事件源编号
        /// </summary>
        public string[] ResIndexCodes { get; private set; }
        /// <summary>
        ///  事件源类型，详见附录A.63
        /// </summary>
        public string[] ResTypes { get; private set; }
        /// <summary>
        /// 事件类型，详见附录D
        /// </summary>
        public string EventType { get; private set; }
        /// <summary>
        /// 事件等级，1-低，2-中，3-高
        /// </summary>
        public string[] EventLevels { get; private set; }
        /// <summary>
        /// 处理意见
        /// </summary>
        public string Remark { get; private set; }
        /// <summary>
        ///  处理状态，0-未处理，1-已处理
        /// </summary>
        public HandleStatus? HandleStatus { get; private set; }




        /// <summary>
        /// 获取联动事件列表请求
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        /// <param name="startTime"> 开始时间</param>
        /// <param name="endTime">结束时间</param>
        /// <param name="eventRuleId">事件规则id</param>
        /// <param name="ability">事件分类</param>
        /// <param name="regionIndexCode">区域编号</param>
        /// <param name="resName">事件源名称</param>
        /// <param name="eventType">事件类型</param>
        /// <param name="remark">处理意见</param>
        /// <param name="handleStatus">处理状态</param>

        public GetEventsListRequest(int pageNo, int pageSize, DateTime startTime, DateTime endTime, string eventRuleId = "", string ability = "", string regionIndexCode = "", string resName = "", string eventType = "", string remark = "", HandleStatus? handleStatus = null) : base(pageNo, pageSize, startTime, endTime)
        {
            EventRuleId = eventRuleId;
            Ability = ability;
            RegionIndexCode = regionIndexCode;
            ResName = resName;
            Remark = remark;
            HandleStatus = handleStatus;
            EventType = eventType;
        }

        /// <summary>
        /// 使用事件等级
        /// </summary>
        /// <param name="eventLevels"> 	事件等级，1-低，2-中，3-高</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public GetEventsListRequest UseEventLevels(params EventLevel[] eventLevels)
        {

            if (eventLevels == null || eventLevels.Length == 0)
            {
                throw new ArgumentNullException(nameof(eventLevels));
            }


            EventLevels = eventLevels.Select(u => ((int)u).ToString()).ToArray();
            return this;
        }

        /// <summary>
        /// 使用事件源类型
        /// </summary>
        /// <param name="resTypes">事件源类型</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public GetEventsListRequest UseResTypes(params string[] resTypes)
        {

            if (resTypes == null || resTypes.Length == 0)
            {
                throw new ArgumentNullException(nameof(resTypes));
            }

            ResTypes = resTypes;
            return this;
        }
        /// <summary>
        /// 使用事件源编号
        /// </summary>
        /// <param name="resIndexCodes">事件源编号</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public GetEventsListRequest UseResIndexCodes(params string[] resIndexCodes)
        {

            if (resIndexCodes == null || resIndexCodes.Length == 0)
            {
                throw new ArgumentNullException(nameof(resIndexCodes));
            }

            ResIndexCodes = resIndexCodes;
            return this;
        }
        /// <summary>
        /// 使用所属位置
        /// </summary>
        /// <param name="locationIndexCodes">所属位置</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public GetEventsListRequest UseLocationIndexCodes(params string[] locationIndexCodes)
        {

            if (locationIndexCodes == null || locationIndexCodes.Length == 0)
            {
                throw new ArgumentNullException(nameof(locationIndexCodes));
            }

            LocationIndexCodes = locationIndexCodes;
            return this;
        }
    }
}
