﻿using General.Framework.Cotrollers;
using General.Services.Category;
using GeneralMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeneralMVC.Controllers
{
    public class HomeController :BaseController
    {
        private readonly ICategoryService _categoryService;


        public HomeController(ICategoryService categoryService)
        {
           this._categoryService = categoryService;
        }
        public IActionResult Index()
        {
            //_categoryService = EngineContext.Current.Resolve<ICategoryService>();
            ////var list = _categoryService.GetList();
            //var ss = _categoryService.getList();

            var ss = _categoryService.getList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
