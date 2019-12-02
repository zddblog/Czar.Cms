using General.Framework.Cotrollers.Admin;
using Microsoft.AspNetCore.Mvc;

namespace GeneralMVC.Areas.Admin.Controllers
{

    /// <summary>
    /// 后台管理登录
    /// </summary>
    public class LoginController:AdminAreaController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}