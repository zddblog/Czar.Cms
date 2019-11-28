using System.Collections.Generic;
using General.Core.Data;
using General.Entities.Category;
using Microsoft.EntityFrameworkCore;

namespace General.Services.Category
{
    public class CategoryService :ICategoryService
    {
        private IRepository<Entities.Category.Category> _repository;
        public CategoryService(IRepository<Entities.Category.Category> repository)
        {
            this._repository = repository;
        }

        public DbContext dbContext => throw new System.NotImplementedException();

        public DbSet<Entities.Category.Category> Entities => throw new System.NotImplementedException();

        public void Add(Entities.Category.Category TModel)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Entities.Category.Category> GetList()
        {
            throw new System.NotImplementedException();
        }

        public Entities.Category.Category GetSingle(object Id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Entities.Category.Category TModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
