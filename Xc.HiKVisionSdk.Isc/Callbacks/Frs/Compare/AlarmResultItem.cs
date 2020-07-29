namespace Xc.HiKVisionSdk.Isc.Callbacks.Frs.Compare
{
    /// <summary>
    /// 比对结果
    /// </summary>
    public class AlarmResultItem
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        public FacesItem[] Faces { get; set; }
        /// <summary>
        /// 目标属性
        /// </summary>
        public TargetAttrs TargetAttrs { get; set; }
    }

}
