using System.ComponentModel.DataAnnotations;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Isc.Managers.Acs.Models
{
    /// <summary>
    /// 查询门禁请求
    /// </summary>
    public class DoorSearchV2Request : PagedRequest
    {
        /// <summary>
        /// 名称，模糊搜索，最大长度32，若包含中文，最大长度指不超过按照指定编码的字节长度，即getBytes(“utf-8”).length
        /// </summary>
        [MaxLength(32)]
        public string Name { get; set; }

        /// <summary>
        /// 区域编号,可以为空;
        /// String[]，支持根据区域批量查询；
        /// 区域编号个数 小于等于1000个；
        /// 单个长度小于等于64Byte；，可从查询区域列表v2接口获取返回参数indexCode
        /// </summary>
        public string[] RegionIndexCodes { get; set; }

        /// <summary>
        /// true时，搜索regionIndexCodes及其子孙区域的资源；
        /// false时，只搜索 regionIndexCodes的资源
        /// </summary>
        public bool IsSubRegion { get; set; }

        /// <summary>
        /// 权限码集合，详见附录A.3 资源权限码中门禁点对应的资源权限码
        /// </summary>
        public string[] AuthCodes { get; set; }

        /// <summary>
        /// 查询表达式
        /// </summary>
        public RequestExpression[] Expressions { get; set; }

        /// <summary>
        /// 排序字段,注意：排序字段必须是查询条件，否则返回参数错误
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// 降序升序,降序：desc 升序：asc
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 查询门禁请求
        /// </summary>
        public DoorSearchV2Request() { }

        /// <summary>
        /// 查询门禁请求
        /// </summary>
        /// <param name="pageNo">当前页码</param>
        /// <param name="pageSize">每页记录总数</param>
        public DoorSearchV2Request(int pageNo, int pageSize) : base(pageNo, pageSize) { }

    }
}
