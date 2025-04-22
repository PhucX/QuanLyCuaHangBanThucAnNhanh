using DoAnDemo.Models;
using System.Collections.Generic;

namespace DoAnDemo.BusinessLogicLayer.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryViewModel> GetAllCategories();
    }
}