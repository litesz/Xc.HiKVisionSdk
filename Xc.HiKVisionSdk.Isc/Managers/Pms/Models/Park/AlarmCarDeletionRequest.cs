namespace Xc.HiKVisionSdk.Isc.Managers.Pms.Models
{
    /// <summary>
    /// 取消车辆布控
    /// </summary>
    public class AlarmCarDeletionRequest
    {
        /// <summary>
        /// 布控车辆唯一标识集合(编号间用‘,’分隔)
        /// </summary>
        public string AlarmSyscodes { get; set; }
    }
}
