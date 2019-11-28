using General.Core;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GeneralMVC
{
    public class GeneralEngin : IEngin
    {
        private readonly IServiceProvider _serviceProvider;

        public GeneralEngin(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }
        

        /// <summary>
        /// 构建实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Resolve<T>() where T : class
        {
            return _serviceProvider.GetService<T>();
        }
    }
}
