using System;

namespace Xc.HiKVisionSdk.Models.Request
{
    /// <summary>
    /// 基础抽象类
    /// </summary>
    public abstract class BaseRequest : IBaseRequest
    {
        /// <summary>
        /// 验证必选项是否为空
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void CheckParams()
        {
            //throw new NotImplementedException("CheckParams");
        }

        public override string ToString()
        {
            return this.SerializeByCamelCase();
        }



    }

}
