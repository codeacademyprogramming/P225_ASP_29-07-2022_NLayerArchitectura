using P225NLayerArchitectura.Service.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P225NLayerArchitectura.Service.Interfaces
{
    public interface ICategoryService
    {
        Task PostAsyn(CategoryPostDto categoryPostDto);

        Task<List<CategoryListDto>> GetAllAsync();
    }
}
