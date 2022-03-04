using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using Xc.HiKVisionSdk.Ia.Managers;
using Xc.HiKVisionSdk.Ia.Managers.Eaas;
using Xc.HiKVisionSdk.Ia.Models;

namespace Xc.HiKVisionSdk.Ia.Extensions
{
    /// <summary>
    /// di扩展
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加海康考勤平台API管理
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddHikVisionIa(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<IaSdkOption>(configuration.GetSection(IaSdkOption.Position));

            //services.AddSingleton<IPlanStatusCollection, PlanStatusCollection>();
            //services.AddSingleton<IInstallLocationCollection, InstallLocationCollection>();
            //services.AddSingleton<IEventCollection, EventCollection>();
            //services.AddSingleton<IDoorEventSortCollection, DoorEventSortCollection>();


            services
                .AddHttpClient<IHikVisionIaApiManager, HikVisionIaApiManager>(option =>
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

            //services.AddScoped<IHikAcsApiManager, HikAcsApiManager>();
            //services.AddScoped<IHikEventServiceApiManager, HikEventServiceApiManager>();
            //services.AddScoped<IHikFrsApiManager, HikFrsApiManager>();
            //services.AddScoped<IHikPmsApiManager, HikPmsApiManager>();
            //services.AddScoped<IHikResourceApiManager, HikResourceApiManager>();
            //services.AddScoped<IHikIrdsApiManager, HikIrdsApiManager>();
            services.AddScoped<IHikEaasApiManager, HikEaasApiManager>();


            return services;
        }
    }
}
