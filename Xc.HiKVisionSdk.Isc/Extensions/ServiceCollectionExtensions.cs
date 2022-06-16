using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.Managers.Acs;
using Xc.HiKVisionSdk.Isc.Managers.EventService;
using Xc.HiKVisionSdk.Isc.Managers.Frs;
using Xc.HiKVisionSdk.Isc.Managers.Irds;
using Xc.HiKVisionSdk.Isc.Managers.Mpc;
using Xc.HiKVisionSdk.Isc.Managers.Pms;
using Xc.HiKVisionSdk.Isc.Managers.Resource;
using Xc.HiKVisionSdk.Isc.Managers.Video;
using Xc.HiKVisionSdk.Isc.ManagersV2.Cards;
using Xc.HiKVisionSdk.Isc.ManagersV2.Events;
using Xc.HiKVisionSdk.Isc.ManagersV2.Faces;
using Xc.HiKVisionSdk.Isc.ManagersV2.Orgs;
using Xc.HiKVisionSdk.Isc.ManagersV2.Persons;
using Xc.HiKVisionSdk.Isc.ManagersV2.Resources;
using Xc.HiKVisionSdk.Isc.Models;
using Xc.HiKVisionSdk.Options;

namespace Xc.HiKVisionSdk.Isc
{
    /// <summary>
    /// di扩展
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加海康ISCAPI管理
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddHikVisionIsc(this IServiceCollection services, IConfiguration configuration)
        {
            //
            services.Configure<HiKVisionOptions>(configuration.GetSection("Hikvision"));
            services.Configure<IscSdkOption>(configuration.GetSection(IscSdkOption.Position));

            //services.AddSingleton<IPlanStatusCollection, PlanStatusCollection>();
            //services.AddSingleton<IInstallLocationCollection, InstallLocationCollection>();
            //services.AddSingleton<IEventCollection, EventCollection>();
            //services.AddSingleton<IDoorEventSortCollection, DoorEventSortCollection>();


            services
                .AddHttpClient<IHikVisionIscApiManager, HikVisionIscApiManager>(option =>
                {
                    option.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                })
                .ConfigurePrimaryHttpMessageHandler(() =>
                {
                    return new HttpClientHandler()
                    {
                        ServerCertificateCustomValidationCallback = (message, certificate2, arg3, arg4) => true
                    };
                });



            services.AddManagers();

            services.AddV2Managers();


            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddManagers(this IServiceCollection services)
        {
            services.AddScoped<IHikAcsApiManager, HikAcsApiManager>();
            services.AddScoped<IHikEventServiceApiManager, HikEventServiceApiManager>();
            services.AddScoped<IHikFrsApiManager, HikFrsApiManager>();
            services.AddScoped<IHikPmsApiManager, HikPmsApiManager>();
            services.AddScoped<IHikResourceApiManager, HikResourceApiManager>();
            services.AddScoped<IHikIrdsApiManager, HikIrdsApiManager>();
            services.AddScoped<IHikMpcApiManager, HikMpcApiManager>();
            services.AddScoped<IHikVideoApiManager, HikVideoApiManager>();
            return services;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        private static IServiceCollection AddV2Managers(this IServiceCollection services)
        {

            return services
                .AddScoped<IHikCardManager, HikCardManager>()
                .AddScoped<IHikOrgManager, HikOrgManager>()
                .AddScoped<IHikResourceManager, HikResourceManager>()
                .AddScoped<IHikPersonManager, HikPersonManager>()
                .AddScoped<IHikFaceManager, HikFaceManager>()
                .AddScoped<IHikEventManager, HikEventManager>()
                ;
            
        }
    }
}
