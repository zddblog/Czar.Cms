namespace General.Framework.Secunity.Admin
{
    public interface IAdminAuthService
    {

        /// <summary>
        /// 获取当前登录用户
        /// </summary>
        /// <returns></returns>
        Entities.SysUser.SysUser getCurrentUser();
        /// <summary>
        /// 保存登录状态
        /// </summary>
        /// <param name="token"></param>
        /// <param name="name"></param>
        void sginIn(string token, string name);
    }
}
