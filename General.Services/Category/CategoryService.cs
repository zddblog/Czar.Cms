using General.Core.Data;
using System.Collections.Generic;

namespace General.Services.Category
{
    public class CategoryService : ICategoryService, IGeneralService
    {
        private IRepository<Entities.Category.Category> _repository;


        public CategoryService(IRepository<Entities.Category.Category> repository)
        {
            this._repository = repository;
        }

        public List<Entities.Category.Category> getList()
        {
          return  _repository.GetList() as List<Entities.Category.Category>;
        }
    }
}
