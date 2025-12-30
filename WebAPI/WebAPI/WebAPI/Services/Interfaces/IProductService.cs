using Lab09.DTOs;
using Lab09.Models;

namespace Lab09.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void CreateProduct(CreateProductDto dto);
        void DeleteProduct(int id);
        void UpdateProduct(int id, CreateProductDto dto);
    }
}