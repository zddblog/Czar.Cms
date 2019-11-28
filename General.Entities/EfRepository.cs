using General.Core.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace General.Entities
{

    /// <summary>
    /// EfCore数据操作类 实现基本仓储接口 IRepository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly GeneralDbContext _generalDbContext;

        public EfRepository(GeneralDbContext generalDbContext)
        {
            this._generalDbContext = generalDbContext;
        }

        public DbContext dbContext {
            get {
                return _generalDbContext;
            }
        }

        public DbSet<T> Entities {
            get {
                return _generalDbContext.Set<T>();
            }
        }

        public void Add(T TModel)
        {
            _generalDbContext.Set<T>().Add(TModel);
            _generalDbContext.SaveChanges();
        }

        public void Delete(object Id)
        {
            var entity = GetSingle(Id);

            if (entity!=null)
            {
                _generalDbContext.Set<T>().Remove(entity);
                _generalDbContext.SaveChanges();
            }
          
        }

        public IEnumerable<T> GetList()
        {
            return _generalDbContext.Set<T>().ToList();
        }

        public T GetSingle(object Id)
        {
            return  _generalDbContext.Set<T>().Find(Id);
        }

        public void Update(T TModel)
        {
            _generalDbContext.Set<T>().Update(TModel);
        }
    }
}
