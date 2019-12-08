using General.Entities;
using System;

namespace General.Services.SysUser
{
    public interface ISysUserService
    {

        /// <summary>
        /// 验证登录状态
        /// </summary>
        /// <param name="loginModel">登录实体</param>
        /// <param name="r"></param>
        /// <returns></returns>
        (bool Status, string Message, string Token, Entities.SysUser.SysUser) validateUser(LoginModel loginModel,string r);


        /// <summary>
        /// 通过账号获取用户
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        Entities.SysUser.SysUser getAccount(string Account);
    }
}
