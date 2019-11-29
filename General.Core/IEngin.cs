namespace General.Core
{
    /// <summary>
    /// 系统引擎接口
    /// </summary>
    public interface IEngin
    {

        /// <summary>
        /// 构建一个实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>() where T : class;
    }
}
