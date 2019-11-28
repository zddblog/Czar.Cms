using System.Collections.Generic;
using General.Core.Data;
using General.Entities.Category;
using Microsoft.EntityFrameworkCore;

namespace General.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Entities.Category.Category> _repository;


        public CategoryService(IRepository<Entities.Category.Category> repository)
        {
            this._repository = repository;
        }
        public DbContext dbContext
        {
            get
            {
                return _repository.dbContext;
            }
        }

        public DbSet<Entities.Category.Category> Entities
        {
            get
            { 
                return _repository.Entities;
            }
        }
        public void Add(Entities.Category.Category TModel)
        {
            _repository.Add(TModel);
        }

        public void Delete(object Id)
        {
            _repository.Delete(Id);
        }

        public IEnumerable<Entities.Category.Category> GetList()
        {
            return _repository.GetList();
        }

        public Entities.Category.Category GetSingle(object Id)
        {
            return _repository.GetSingle(Id);
        }

        public void Update(Entities.Category.Category TModel)
        {
            _repository.Update(TModel);
        }
    }
}
