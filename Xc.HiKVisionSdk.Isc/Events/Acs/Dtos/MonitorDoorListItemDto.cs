namespace Xc.HiKVisionSdk.Isc.Events.Acs.Dtos
{
    /// <summary>
    /// 监听门项
    /// </summary>
    public class MonitorDoorListItemDto
    {
        /// <summary>
        /// 唯一id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string DoorName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 取反
        /// </summary>
        public bool IsReverse { get; set; }
    }


}
