using General.Core.Librs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace General.Core.Extensions
{

    /// <summary>
    /// IServiceCollection 容器的扩展类
    /// </summary>
    public static class ServiceCollectionExtensions
    {

        /// <summary>
        /// 程序集依赖注入
        /// </summary>
        /// <param name="services"></param>
        /// <param name="assemblyName">程序集名</param>
        public static void AddAssembly(this IServiceCollection services, string assemblyName, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {

            if (services == null)
            {
                throw new ArgumentNullException(nameof(services) + "为空!");
            }
            if (string.IsNullOrEmpty(assemblyName))
            {
                throw new ArgumentNullException(nameof(assemblyName) + "为空!");
            }
            var assembly = RunTimeHelper.GetAssemblyByName(assemblyName);
            if (assembly == null)
            {
                throw new DllNotFoundException(nameof(assembly) + "不存在!");
            }
            var types = assembly.GetTypes();
            var list = types.Where(o => o.IsClass && !o.IsAbstract && !o.IsGenericType).ToList();
            if (list == null && !list.Any())
            {
                return;
            }
            foreach (var item in list)
            {
                var interfaceList = item.GetInterfaces();
                if (interfaceList == null || !interfaceList.Any())
                {
                    continue;
                }
                var inter = interfaceList.FirstOrDefault();
                switch (serviceLifetime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(inter, item);
                        break;
                    case ServiceLifetime.Scoped:
                        services.AddScoped(inter, item);
                        break;
                    case ServiceLifetime.Transient:
                        services.AddTransient(inter, item);
                        break;
                }
            }
        }
    }
}
