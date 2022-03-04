using System.Collections.Generic;
using Xc.HiKVisionSdk.Ia.Models.Reponse;
using Xc.HiKVisionSdk.Models.Request;

namespace Xc.HiKVisionSdk.Ia.Managers.Eaas.Attendance
{
    /// <summary>
    /// 批量查询员工考勤数据请求
    /// </summary>
    public class AttendanceResultListRequest : PagedQuery
    {
        /// <summary>
        /// 检索字段名，全部查询为*，多个字段英文逗号分隔，具体属性值可自定义
        /// </summary>
        public string Fields { get; }

        /// <summary>
        /// 查询参数
        /// </summary>
        public List<FieldOption> FieldOptions { get; private set; }

        /// <summary>
        /// 批量查询员工考勤数据请求
        /// </summary>
        /// <param name="pageNo">当前页</param>
        /// <param name="pageSize">容量</param>
        /// <param name="fields">检索字段名</param>
        public AttendanceResultListRequest(int pageNo, int pageSize, string fields = "*") : base(pageNo, pageSize)
        {
            Fields = fields;
        }

        /// <summary>
        /// 添加查询条件
        /// </summary>
        /// <param name="fieldName">查询字段名称</param>
        /// <param name="fieldValue">查询字段值</param>
        /// <param name="type">查询类型</param>
        public AttendanceResultListRequest AddFieldOption(string fieldName, string fieldValue, string type)
        {
            if (FieldOptions == null)
            {
                FieldOptions = new List<FieldOption>();
            }

            FieldOptions.Add(new FieldOption(fieldName, fieldValue, type));
            return this;
        }


    }
}
