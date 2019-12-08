using Microsoft.EntityFrameworkCore;

namespace General.Entities
{
    public class GeneralDbContext : DbContext
    {
        public GeneralDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        /// <summary>
        /// 日志
        /// </summary>
        public DbSet<Category.Category> Categories { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<SysUser.SysUser> SysUsers { get; set; }
        /// <summary>
        /// 用户Token
        /// </summary>
        public DbSet<SysUserToken.SysUserToken>  SysUserTokens{ get; set; }
    }
}
