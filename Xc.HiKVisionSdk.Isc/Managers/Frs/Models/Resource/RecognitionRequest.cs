using System;
using System.Collections.Generic;
using System.Text;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件查询识别资源请求
    /// </summary>
    public class RecognitionRequest
    {
        /// <summary>
        /// 通过indexCode集合查询指定的识别资源集合
        /// </summary>
        public string[] IndexCodes { get; set; }
        /// <summary>
        /// 识别资源名称模糊查询
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 根据识别资源的类型搜索，SUPER_BRAIN 超脑，FACE_RECOGNITION_SERVER 脸谱，COMPARISON 深眸
        /// </summary>
        public string RecognitionResourceType { get; set; }

    }

   
}
