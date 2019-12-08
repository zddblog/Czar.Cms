using General.Core.Data;
using General.Core.Librs;
using General.Entities;
using General.Entities.SysUser;
using System.Linq;
namespace General.Services.SysUser
{
    public  class SysUserService:ISysUserService
    {
        private IRepository<Entities.SysUser.SysUser> _sysUserRepository;
        public SysUserService(IRepository<Entities.SysUser.SysUser> sysUserRepository)
        {
            this._sysUserRepository = sysUserRepository;
        }

        public (bool Status, string Message, string Token, Entities.SysUser.SysUser) validateUser(LoginModel loginModel, string r) {
            var ret = getAccount(loginModel.Account);
            if (ret==null)
            {
                return (false, "用户名或密码错误", null,null);
            }
            var md5Password = EncryptorHelper.GetMd532(loginModel.Password+r);
            //if (md5Password.Equals())
            //{

            //}
            return (true, "登录成功", "aaaa111111", new Entities.SysUser.SysUser() { Name = "李四" });
        }

        public Entities.SysUser.SysUser getAccount(string Account)
        {
            return _sysUserRepository.GetSingle(Account);
        }

    }
}
