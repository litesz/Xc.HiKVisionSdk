using System;
using System.Collections.Generic;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Models
{
    public class IscSdkOption
    {
        public const string Position = "Hikvision.Isc";
        public string Ak { get; set; }
        public string Sk { get; set; }
        public string BaseUrl { get; set; }
        public decimal Ver { get; set; } = 1;
    }
}
