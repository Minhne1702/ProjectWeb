using Lab08.Models;

namespace Lab08.Services.Interfaces
{
    public interface ICarModelService
    {
        List<CarModelVm> GetCarModels();
        CarModelVm? GetCarModelById(int id);
        void CreateCarModel(CarModelVm carVm);
        void UpdateCarModel(CarModelVm carVm);
        void DeleteCarModel(int id);
    }
}