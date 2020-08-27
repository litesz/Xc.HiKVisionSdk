using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xc.HiKVisionSdk.Isc.Dictionaries;
using Xc.HiKVisionSdk.Isc.Managers;
using Xc.HiKVisionSdk.Isc.Managers.Acs;
using Xc.HiKVisionSdk.Isc.Managers.EventService;
using Xc.HiKVisionSdk.Isc.Managers.Frs;
using Xc.HiKVisionSdk.Isc.Managers.Irds;
using Xc.HiKVisionSdk.Isc.Managers.Mpc;
using Xc.HiKVisionSdk.Isc.Managers.Pms;
using Xc.HiKVisionSdk.Isc.Managers.Resource;
using Xc.HiKVisionSdk.Isc.Models;

namespace Xc.HiKVisionSdk.Isc
{
    /// <summary>
    /// di扩展
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加海康API管理
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddHikVisionIsc(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<IscSdkOption>(configuration.GetSection(IscSdkOption.Position));

            services.AddSingleton<IPlanStatusCollection, PlanStatusCollection>();
            services.AddSingleton<IInstallLocationCollection, InstallLocationCollection>();
            services.AddSingleton<IEventCollection, EventCollection>();
            services.AddSingleton<IDoorEventSortCollection, DoorEventSortCollection>();

            services.AddScoped<IHikVisionApiManager, HikVisionApiManager>();
            services.AddScoped<IHikAcsApiManager, HikAcsApiManager>();
            services.AddScoped<IHikEventServiceApiManager, HikEventServiceApiManager>();
            services.AddScoped<IHikFrsApiManager, HikFrsApiManager>();
            services.AddScoped<IHikPmsApiManager, HikPmsApiManager>();
            services.AddScoped<IHikResourceApiManager, HikResourceApiManager>();
            services.AddScoped<IHikIrdsApiManager, HikIrdsApiManager>();
            services.AddScoped<IHikMpcApiManager, HikMpcApiManager>();


            return services;
        }
    }
}
