using System.Reflection;
using System.Runtime.Loader;

namespace General.Core.Librs
{

    /// <summary>
    /// 运行时辅助类(反射机制)
    /// </summary>
    public class RunTimeHelper
    {

        /// <summary>
        /// 通过程序集的名称加载程序集
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <returns></returns>
        public static Assembly  GetAssemblyByName(string assemblyName)
        {
           return AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(assemblyName));
        }
    }
}
