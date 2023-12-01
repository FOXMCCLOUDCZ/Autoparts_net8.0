using AutopartsEntity.Catalog.ViewModels.ModelViewModel;

namespace AutopartsService.Services.Catalog.Interfaces
{
    public interface IModelService
    {
        Task<List<ModelListVM>> AllListAsync();
        Task CreateModelAsync(ModelCreateVM request);
        Task DeleteModelAsync(int id);
        Task<ModelEditVM> GetModelById(int id);
        Task EditModelAsync(ModelEditVM request);
    }
}