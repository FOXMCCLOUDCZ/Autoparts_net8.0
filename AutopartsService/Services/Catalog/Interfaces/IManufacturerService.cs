using AutopartsEntity.Catalog.ViewModels.ManufacturerViewModel;

namespace AutopartsService.Services.Catalog.Interfaces
{
    public interface IManufacturerService
    {
        Task<List<ManufacturerListVM>> AllListAsync();
        Task CreateManufacturerAsync(ManufacturerCreateVM request);
        Task DeleteManufacturerAsync(int id);
        Task<ManufacturerEditVM> GetManufacturerById(int id);
        Task EditManufacturerAsync(ManufacturerEditVM request);
    }
}