using Microsoft.AspNetCore.Mvc;


namespace General.Framework.Cotrollers
{
    public abstract class BaseController : Controller
    {

        /// <summary>
        /// Ajax请求的数据结果
        /// </summary>
        public AjaxResult AjaxResult
        {
            get
            {
                return new AjaxResult();
            }

        }
    }
}
