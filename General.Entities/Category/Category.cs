using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace General.Entities.Category
{
    [Table("Category")]
    public class Category
    {


        /// <summary>
        /// 主键
        /// </summary>
        [Key, Required]
        public int Id { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required(ErrorMessage = "不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 是否菜单
        /// </summary>
        public bool IsMenu { get; set; }

        /// <summary>
        /// 区分菜单的唯一标识
        /// </summary>
        public string SysResource { get; set; }


        /// <summary>
        /// ResourceID
        /// </summary>
        public string ResourceID { get; set; }

        /// <summary>
        /// 上一级标识
        /// </summary>
        public string FatherResource { get; set; }

        /// <summary>
        /// 上一级IDss
        /// </summary>
        public string FatherID { get; set; }


        /// <summary>
        /// 控制器名
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// 路径Action
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 路由名
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// 类样式  例：图标
        /// </summary>
        public string CssClass { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool IsDisabled { get; set; }

    }
}
