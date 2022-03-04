using Xc.HiKVisionSdk.Enums;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models.Person
{

    /// <summary>
    /// 查询人员列表V2请求
    /// </summary>
    public class AdvancePersonListV2Request : PagedQuery
    {
        /// <summary>
        /// 人员ID集合
        /// 多个值使用英文逗号分隔，不超过1000个
        /// 获取人员列表v2 接口获取
        /// </summary>
        public string PersonIds { get; set; }
        /// <summary>
        /// 人员姓名
        /// 支持中英文字符，不能包含 ’ / \ : * ? " 
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 性别
        /// 1：男
        /// 2：女
        /// 0：未知
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        ///  	所属组织唯一标识码集合
        ///  	多个值使用英文逗号分隔，不超过1000个
        /// </summary>
        public string OrgIndexCodes { get; set; }
        /// <summary>
        ///  	证件类型
        ///  	111:身份证
        ///  	414:护照
        ///  	113:户口簿
        ///  	335:驾驶证
        ///  	131:工作证
        ///  	133:学生证
        ///  	990:其他
        ///  	平台上人员信息实名标识选择为身份证件时必填
        /// </summary>
        public int CertificateType { get; set; }
        /// <summary>
        /// 证件号码(最大长度64)
        /// </summary>
        public string CertificateNo { get; set; }

        /// <summary>
        /// 是否包含下级组织，true时，搜索orgIndexCodes及其所有子孙组织的人员；
        /// false时，只搜索orgIndexCodes的人员
        /// </summary>
        public string IsSubOrg { get; set; }
        /// <summary>
        /// 卡号, 获取卡片列表接口可以获取
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string PlateNo { get; set; }


        /// <summary>
        /// 排序字段，注意：排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// 降序：desc
        /// 升序：asc
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 查询表达式
        /// </summary>
        public RequestExpression[] Expressions { get; set; }
    }

}
