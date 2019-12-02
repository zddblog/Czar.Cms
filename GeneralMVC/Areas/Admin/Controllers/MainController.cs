using General.Framework.Cotrollers.Admin;
using Microsoft.AspNetCore.Mvc;

namespace GeneralMVC.Areas.Admin.Controllers
{
    public class MainController: PublicAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}