using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace General.Entities.SysUser
{
    [Table("SysUser")]
    public class SysUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key, Required]
        public int Id { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }


        /// <summary>
        /// 密码盐
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// 有效标识
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public bool IsAdmin { get; set; }


        /// <summary>
        /// 登陆失败的次数
        /// </summary>
        public int LoginFailedNum { get; set; }

        /// <summary>
        /// 允许登录的时间
        /// </summary>
        public DateTime AllowLoginTime { get; set; }
        /// <summary>
        /// 是否被锁定
        /// </summary>
        public bool LoginLock { get; set; }

        /// <summary>
        /// 是否被删除
        /// </summary>
        public bool IsDeleted { get; set; }
       
    }
}
