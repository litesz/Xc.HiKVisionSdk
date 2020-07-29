using Xc.HiKVisionSdk.Isc.Models.Commons;

namespace Xc.HiKVisionSdk.Isc.Callbacks.Acs
{
    public class ExtEventIdentityCardInfo
    {
        /// <summary>
        /// 住址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string Birth { get; set; }
        /// <summary>
        /// 有效日期结束时间
        /// </summary>
        public string EndDate { get; set; }
        /// <summary>
        /// 身份证id
        /// </summary>
        public string IdNum { get; set; }
        /// <summary>
        /// 签发机关
        /// </summary>
        public string IssuingAuthority { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public int Nation { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public Gender Sex { get; set; }
        /// <summary>
        /// 有效日期开始时间
        /// </summary>
        public string StartDate { get; set; }
        /// <summary>
        /// 是否长期有效
        /// 0-否（有效截止日期有效）
        /// 1-是（有效截止日期无效）
        /// </summary>
        public TermOfValidity TermOfValidity { get; set; }
    }
}
