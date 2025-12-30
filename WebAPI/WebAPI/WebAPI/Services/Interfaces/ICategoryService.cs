using Lab09.DTOs;
using Lab09.Models;

namespace Lab09.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        void Add(CategoryDto dto);
        void Update(int id, CategoryDto dto);
        void Delete(int id);
    }
}