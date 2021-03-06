﻿namespace Xc.HiKVisionSdk.Isc.Dictionaries
{
    /// <summary>
    /// 海康字典表索引
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IHikDictionaryCollection<TKey, TResult>
    {
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TResult this[TKey key] { get; }
    }
}
