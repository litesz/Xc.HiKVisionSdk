using Company.WpfApplication1.Pages;
using Stylet;
using StyletIoC;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.Managers.Acs;
using Xc.HiKVisionSdk.Isc.Managers.EventService;
using Xc.HiKVisionSdk.Isc.Managers.Frs;
using Xc.HiKVisionSdk.Isc.Managers.Irds;
using Xc.HiKVisionSdk.Isc.Managers.Pms;
using Xc.HiKVisionSdk.Isc.Managers.Resource;
using Xc.HiKVisionSdk.Isc.Models;

namespace Company.WpfApplication1
{
    public class Bootstrapper : Bootstrapper<ShellViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            // Configure the IoC container in here

            builder.Bind<IscSdkOption>().ToSelf().InSingletonScope();
            builder.Bind<IHikVisionApiManager>().To<HikVisionApiManager>();
            builder.Bind<IHikPmsApiManager>().To<HikPmsApiManager>();
            builder.Bind<IHikResourceApiManager>().To<HikResourceApiManager>();
            builder.Bind<IHikEventServiceApiManager>().To<HikEventServiceApiManager>();
            builder.Bind<IHikFrsApiManager>().To<HikFrsApiManager>();
            builder.Bind<IHikAcsApiManager>().To<HikAcsApiManager>();
            builder.Bind<IHikIrdsApiManager>().To<HikIrdsApiManager>();



        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }
    }
}
