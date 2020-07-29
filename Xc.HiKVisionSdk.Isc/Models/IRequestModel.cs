using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Models.Common
{
    public interface IRequestModel
    {
    }

    public interface IResponseModel
    {

    }

    public interface IPaged
    {
        int PageSize { get; set; }

        int PageNo { get; set; }
    }
  
}
