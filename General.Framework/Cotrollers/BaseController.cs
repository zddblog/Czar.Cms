using Microsoft.AspNetCore.Mvc;


namespace General.Framework.Cotrollers
{
    public abstract class BaseController : Controller
    {
        private AjaxResult _result;
        public BaseController(AjaxResult result)
        {
            this._result = result;

        }
        /// <summary>
        /// Ajax请求的数据结果
        /// </summary>
        public AjaxResult AjaxResult
        {
            get
            {
                return _result;
            }

        }
    }
}
