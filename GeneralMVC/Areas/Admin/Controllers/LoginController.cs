using General.Entities;
using General.Framework.Cotrollers.Admin;
using General.Framework.Secunity.Admin;
using General.Services.SysUser;
using Microsoft.AspNetCore.Mvc;

namespace GeneralMVC.Areas.Admin.Controllers
{

    [Route("admin")]
    /// <summary>
    /// 后台管理登录
    /// </summary>
    public class LoginController : AdminAreaController
    {

        private ISysUserService _sysUserService;
        private IAdminAuthService _authenticationService;
        public LoginController(ISysUserService sysUserService, IAdminAuthService authenticationService)
        {
            this._sysUserService = sysUserService;
            this._authenticationService = authenticationService;
        }

        [Route("login", Name = "adminLogin")]
        public IActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Index(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                AjaxResult.Message = "请输入账号和密码!";
                return Json(AjaxResult);
            }
            var result = _sysUserService.validateUser(loginModel, "");
            AjaxResult.Status = result.Item1;
            AjaxResult.Message = result.Item2;
            if (result.Item1)
            {
                //保存登录状态
                _authenticationService.sginIn(result.Item3, result.Item4.Name);
            }
            return Json(AjaxResult);
        }
    }
}