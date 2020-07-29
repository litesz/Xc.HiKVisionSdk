using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xc.HiKVisionSdk.Isc.Managers.Resource.Models
{


    public enum CertificateType
    {
        [Description("身份证")]
        IdentityCard = 111,
        [Description("护照")]
        Passport = 414,
        [Description("户口簿")]
        ResidenceBooklet = 113,
        [Description("驾驶证")]
        DriversLicense = 335,
        [Description("工作证")]
        EmployeeCard = 131,
        [Description("学生证")]
        StudentIDCard = 133,
        [Description("其他")]
        Other = 990,
    }
}
