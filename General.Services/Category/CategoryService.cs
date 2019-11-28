using General.Entities;
using System.Collections.Generic;
using System.Linq;

namespace General.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly GeneralDbContext _generalDbContext;
        public CategoryService(GeneralDbContext generalDbContext)
        {
            _generalDbContext = generalDbContext;
        }

        public void Add(Entities.Category.Category TModel)
        {
            _generalDbContext.Categories.Add(TModel);
            _generalDbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var ret = GetSingle(Id);
            _generalDbContext.Set<Entities.Category.Category>().Remove(ret);
            _generalDbContext.SaveChangesAsync();
        }

        public List<Entities.Category.Category> GetList()
        {
            return _generalDbContext.Categories.ToList();
        }

        public Entities.Category.Category GetSingle(int Id)
        {
            return _generalDbContext.Categories.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Entities.Category.Category TModel)
        {
            _generalDbContext.Categories.Update(TModel);
            _generalDbContext.SaveChanges();
        }
    }
}
