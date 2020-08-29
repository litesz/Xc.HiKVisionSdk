using Company.WpfApplication1.Pages;
using Stylet;
using StyletIoC;
using System.Net.Http;
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


            builder.Bind<HttpClient>().ToFactory(container =>
            {

                var client = new HttpClient(
                    new HttpClientHandler
                    {
                        ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
                    });
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                return client;
            });

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
