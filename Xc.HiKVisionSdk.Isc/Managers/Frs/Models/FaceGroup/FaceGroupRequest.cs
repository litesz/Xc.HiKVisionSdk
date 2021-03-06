﻿namespace Xc.HiKVisionSdk.Isc.Managers.Frs.Models
{
    /// <summary>
    /// 按条件查询人脸分组请求
    /// </summary>
    public class FaceGroupRequest
    {
        /// <summary>
        /// 通过唯一标识集合查询指定的人脸分组集合
        /// </summary>
        public string IndexCode { get; set; }

        /// <summary>
        /// 人脸分组名称模糊查询
        /// </summary>
        public string Name { get; set; }

    }
}
