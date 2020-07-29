using System.ComponentModel;
using Xc.HiKVisionSdk.Isc.Models.Common;

namespace Xc.HiKVisionSdk.Isc.Models
{

    public class PagedQuery : IRequestModel, IPaged
    {
        public int PageSize { get; set; } = 1;
        public int PageNo { get; set; } = 1;
    }

    /// <summary>
    /// 基础返回值,仅包含code和msg
    /// </summary>
    public class HiKVisionResponse : IResponseModel
    {
        public bool IsSuccess => Code == "0";
        public string Code { get; set; }
        public string Msg { get; set; }
    }

    /// <summary>
    /// 泛型data返回值
    /// T Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HiKVisionDataResponse<T> : HiKVisionResponse
    {

        public T Data { get; set; }
    }


    /// <summary>
    /// 泛型data数组返回值
    /// T[] Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HiKVisionDataArrayResponse<T> : HiKVisionResponse
    {
        public T[] Data { get; set; }
    }

    /// <summary>
    /// 包含分页的泛型返回值
    /// HiKVisionPagedDataResponseData Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HiKVisionPagedDataResponse<T> : HiKVisionResponse
    {
        public HiKVisionPagedDataResponseData<T> Data { get; set; }
    }

    /// <summary>
    /// 分页信息,切勿直接继承
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class HiKVisionPagedDataResponseData<T>
    {

        public int Total { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public T[] List { get; set; }
    }




}
