using General.Core.Data;
using System.Collections.Generic;

namespace General.Services.Category
{
    public interface ICategoryService
    {
        List<Entities.Category.Category> getList();
    }
    public interface IGeneralService
    {
    }
}
