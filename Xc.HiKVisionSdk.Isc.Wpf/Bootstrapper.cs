using Company.WpfApplication1.Pages;
using Microsoft.Extensions.Options;
using Stylet;
using StyletIoC;
using System.Net.Http;
using Xc.HiKVisionSdk.Ia.Managers;
using Xc.HiKVisionSdk.Ia.Managers.Eaas;
using Xc.HiKVisionSdk.Ia.Managers.EattendanceEngine;
using Xc.HiKVisionSdk.Ia.Models;
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
            //var p = new Xc.HiKVisionSdk.Isc.Managers.EventService.Models.EventsSearchRequest(System.DateTime.Now, System.DateTime.Now, 1, 50);
            //var d = p.ToString();

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

            // builder.Bind<IscSdkOption>().ToSelf().InSingletonScope();

            builder.Bind<IOptions<IscSdkOption>>().To<SdkOption>().InSingletonScope();
            builder.Bind<IOptions<IaSdkOption>>().To<IaOption>().InSingletonScope();

            builder.Bind<IHikVisionIscApiManager>().To<HikVisionIscApiManager>();
            builder.Bind<IHikPmsApiManager>().To<HikPmsApiManager>();
            builder.Bind<IHikResourceApiManager>().To<HikResourceApiManager>();
            builder.Bind<IHikEventServiceApiManager>().To<HikEventServiceApiManager>();
            builder.Bind<IHikFrsApiManager>().To<HikFrsApiManager>();
            builder.Bind<IHikAcsApiManager>().To<HikAcsApiManager>();
            builder.Bind<IHikIrdsApiManager>().To<HikIrdsApiManager>();



            builder.Bind<Xc.HiKVisionSdk.Ia.Managers.EventService.IHikEventServiceApiManager>().To<Xc.HiKVisionSdk.Ia.Managers.EventService.HikEventServiceApiManager>();

            builder.Bind<IHikVisionIaApiManager>().To<HikVisionIaApiManager>();
            builder.Bind<IHikEattendanceEngineApiManager>().To<HikEattendanceEngineApiManager>();
            builder.Bind<IHikEaasApiManager>().To<HikEaasApiManager>();



        }

        protected override void Configure()
        {
            // Perform any other configuration before the application starts
        }
    }
}
