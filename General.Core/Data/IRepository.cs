using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace General.Core.Data
{


    /// <summary>
    /// EFCore数据操作基本仓储接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="TModel"></param>
        void Add(T TModel);



        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        void Delete(object Id);


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="TModel"></param>
        void Update(T TModel);



        /// <summary>
        /// 根据主键查询单个
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T GetSingle(object Id);

      
        /// <summary>
        /// 返回列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetList();


        /// <summary>
        /// 获取数据库上下文
        /// </summary>
        DbContext dbContext { get; }

        /// <summary>
        /// 获取该实体类型
        /// </summary>
        DbSet<T> Entities { get; }
    }
}
