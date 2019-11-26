using System;
using System.Collections.Generic;
using Core2._1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Core2._1.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content _content;
        public ContentController(IOptions<Content>  options)
        {
            _content = options.Value;
        }
        public IActionResult Index()
        {
            ViewBag.Contents = new List<Content>() { _content};
            return View();
        }
    }
}