using System.Collections.Generic;
namespace General.Services.Category
{
    public interface ICategoryService
    {
        void Add(Entities.Category.Category TModel);

        void Delete(int Id);
         
        void Update(Entities.Category.Category TModel);
        Entities.Category.Category GetSingle(int Id);

        //IEnumerable<Entities.Category.Category> GetList();
        List<Entities.Category.Category> GetList();
    }
}
