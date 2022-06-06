using System;
using System.Collections.Generic;
using System.Text;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Cis.Models.Card
{
    /// <summary>
    /// 生成卡片二维码请求
    /// </summary>
    public class GenerateBarCodeRequest : BaseRequest
    {


        /// <summary>
        /// 人员ID，cardNo存在的情况下 人员ID可不填，根据获取人员列表v2接口获取返回参数personId
        /// </summary>
        public string PersonId { get; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; }
        /// <summary>
        /// 证件类型，当人员唯一标示是证件类型+证件号码时必填，111:身份证,414:护照,113:户口簿,335:驾驶证,131:工作证,133:学生证,990:其他
        /// </summary>
        public int? CertType { get; }
        /// <summary>
        /// 证件号码，当人员唯一标示是证件类型+证件号码时必填，根据获取人员列表v2接口获取返回参数certificateNo
        /// </summary>
        public string CertNum { get; }
        /// <summary>
        /// 手机号码，当人员唯一标示是手机号码时必填根据获取人员列表v2接口获取返回参数phoneNo
        /// </summary>
        public string Phone { get; }
        /// <summary>
        /// 职工号，当人员唯一标示是工号时必填，根据获取人员列表v2接口获取返回参数jobNo
        /// </summary>
        public string EmployeeId { get; }
        /// <summary>
        /// 人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟
        /// </summary>
        public int Duration { get; }
        /// <summary>
        /// 最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次
        /// </summary>
        public int MaxLock { get; }

        /// <summary>
        /// 生成卡片二维码请求
        /// </summary>
        /// <param name="personId">人员ID，cardNo存在的情况下 人员ID可不填，根据获取人员列表v2接口获取返回参数personId</param>
        /// <param name="cardNo">卡号</param>
        /// <param name="certType">证件类型，当人员唯一标示是证件类型+证件号码时必填，111:身份证,414:护照,113:户口簿,335:驾驶证,131:工作证,133:学生证,990:其他</param>
        /// <param name="certNum">证件号码，当人员唯一标示是证件类型+证件号码时必填，根据获取人员列表v2接口获取返回参数certificateNo</param>
        /// <param name="phone">手机号码，当人员唯一标示是手机号码时必填根据获取人员列表v2接口获取返回参数phoneNo</param>
        /// <param name="employeeId">职工号，当人员唯一标示是工号时必填，根据获取人员列表v2接口获取返回参数jobNo</param>
        /// <param name="duration">人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟</param>
        /// <param name="maxLock">最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次</param>
        protected GenerateBarCodeRequest(string personId, string cardNo, int? certType, string certNum, string phone, string employeeId, int duration = 1440, int maxLock = 4)
        {
            PersonId = personId;
            CardNo = cardNo;
            CertType = certType;
            CertNum = certNum;
            Phone = phone;
            EmployeeId = employeeId;
            Duration = duration;
            MaxLock = maxLock;
        }

        /// <summary>
        /// 使用人员ID创建
        /// </summary>
        /// <param name="personId">人员ID，cardNo存在的情况下 人员ID可不填，根据获取人员列表v2接口获取返回参数personId</param>
        /// <param name="duration">人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟</param>
        /// <param name="maxLock">最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次</param>
        public static GenerateBarCodeRequest NewByPersonId(string personId, int duration = 1440, int maxLock = 4)
        {
            if (string.IsNullOrEmpty(personId))
            {
                throw new ArgumentNullException(nameof(personId));
            }
            return new GenerateBarCodeRequest(personId, "", null, "", "", "", duration, maxLock);
        }

        /// <summary>
        /// 使用证件创建
        /// </summary>
        /// <param name="certType">证件类型，当人员唯一标示是证件类型+证件号码时必填，111:身份证,414:护照,113:户口簿,335:驾驶证,131:工作证,133:学生证,990:其他</param>
        /// <param name="certNum">证件号码，当人员唯一标示是证件类型+证件号码时必填，根据获取人员列表v2接口获取返回参数certificateNo</param>
        /// <param name="duration">人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟</param>
        /// <param name="maxLock">最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次</param>
        public static GenerateBarCodeRequest NewByCert(int certType, string certNum, int duration = 1440, int maxLock = 4)
        {
            if (string.IsNullOrEmpty(certNum))
            {
                throw new ArgumentNullException(nameof(certNum));
            }
            return new GenerateBarCodeRequest("", "", certType, certNum, "", "", duration, maxLock);
        }

        /// <summary>
        /// 使用卡号创建
        /// </summary>
        /// <param name="cardNo">卡号</param>
        /// <param name="duration">人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟</param>
        /// <param name="maxLock">最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次</param>
        /// <returns></returns>
        public static GenerateBarCodeRequest NewByCardNo(string cardNo, int duration = 1440, int maxLock = 4)
        {
            if (string.IsNullOrEmpty(cardNo))
            {
                throw new ArgumentNullException(nameof(cardNo));
            }
            return new GenerateBarCodeRequest("", cardNo, null, "", "", "", duration, maxLock);
        }

        /// <summary>
        /// 使用手机号创建
        /// </summary>
        /// <param name="phone">手机号码，当人员唯一标示是手机号码时必填根据获取人员列表v2接口获取返回参数phoneNo</param>
        /// <param name="duration">人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟</param>
        /// <param name="maxLock">最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次</param>
        /// <returns></returns>
        public static GenerateBarCodeRequest NewByPhone(string phone, int duration = 1440, int maxLock = 4)
        {
            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentNullException(nameof(phone));
            }
            return new GenerateBarCodeRequest("", "", null, "", phone, "", duration, maxLock);
        }

        /// <summary>
        /// 使用职工号创建
        /// </summary>
        /// <param name="employeeId">职工号，当人员唯一标示是工号时必填，根据获取人员列表v2接口获取返回参数jobNo</param>
        /// <param name="duration">人员卡片二维码有效期时长，非必填字段，单位为分钟，范围为[5~7*24*60]分钟，不传默认为24*60分钟</param>
        /// <param name="maxLock">最大开锁次数，其中针对同一台设备最大开锁次数不超过指定的次数，不传默认最大开锁次数为4次</param>
        /// <returns></returns>
        public static GenerateBarCodeRequest NewByEmployeeId(string employeeId, int duration = 1440, int maxLock = 4)
        {
            if (string.IsNullOrEmpty(employeeId))
            {
                throw new ArgumentNullException(nameof(employeeId));
            }
            return new GenerateBarCodeRequest("", "", null, "", "", employeeId, duration, maxLock);
        }
    }
}
