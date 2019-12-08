using System.ComponentModel.DataAnnotations;

namespace General.Entities
{
    public class LoginModel
    {


        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage ="请输入账号")]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "请输入密码")]
        public string Password { get; set; }
    }
}
