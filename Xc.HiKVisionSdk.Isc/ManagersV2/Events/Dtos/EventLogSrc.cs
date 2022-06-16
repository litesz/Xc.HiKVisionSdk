using System;

namespace Xc.HiKVisionSdk.Isc.ManagersV2.Events.Dtos
{
    /// <summary>
    /// 事件记录
    /// </summary>
    public class EventLogSrc
    {
        /// <summary>
        /// 事件源id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 事件id
        /// </summary>
        public string EventLogId { get; set; }
        /// <summary>
        ///  事件分类，详见附录A.62
        /// </summary>
        public string Ability { get; set; }
        /// <summary>
        /// 事件类型，详见附录D.1
        /// </summary>
        public int EventType { get; set; }
        /// <summary>
        /// 事件类型名称
        /// </summary>
        public string EventTypeName { get; set; }
        /// <summary>
        /// 事件源编号
        /// </summary>
        public string ResIndexCode { get; set; }
        /// <summary>
        /// 事件源类型，详见附录A.63
        /// </summary>
        public string ResType { get; set; }
        /// <summary>
        /// 事件源名称
        /// </summary>
        public string ResName { get; set; }
        /// <summary>
        /// 所属区域编号
        /// </summary>
        public string RegionIndexCode { get; set; }
        /// <summary>
        /// 所属区域名称
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// 所属位置，详见附录A.81 安装位置
        /// </summary>
        public string LocationIndexCode { get; set; }
        /// <summary>
        /// 所属位置名称
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 扩展字段1，暂不使用
        /// </summary>
        public string Extend1 { get; set; }
        /// <summary>
        /// 扩展字段2，暂不使用
        /// </summary>
        public string Extend2 { get; set; }
        /// <summary>
        ///  开始时间,ISO8601时间
        /// </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>
        /// 事件扩展信息
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 反序列化扩展信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetDataAs<T>()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Data);
        }

        /// <summary>
        /// 基于json格式，查询指定参数第一次遇到的值
        /// </summary>
        /// <param name="param">参数</param>
        /// <returns></returns>
        /// <remarks>仅能针对普通值，数组/对象将返回异常</remarks>
        public string GetFirstParamFromData(string param)
        {
            //TODO 数组对象等格式
            if (string.IsNullOrWhiteSpace(Data))
            {
                return "";
            }
            param = $"\"{param}\":";
            int l = Data.IndexOf(param);
            if (l == -1)
            {
                return "";
            }
            var start = l + param.Length;

            if (start >= Data.Length - 1)
            {
                return "";
            }

            var end = Data.IndexOf(",", start);
            if (end == -1)
            {
                return "";
            }
            return Data.Substring(start, end - start).Trim(new char[] { '\"' });
        }
    }
}
